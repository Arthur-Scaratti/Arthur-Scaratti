
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_NFE_CONVENIO
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Tabela usada no processo de geracao das notas CFOP5929 para enviar a conveniada.
        /// </summary>
        public int DIE_NFE_CONVENIO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_FINAL { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AI_NFE_CONVENIO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n  CURSOR C1 IS\n  \n    SELECT N.BEG_FAT_NFS_ID, N.VL_TOTAL_NFS, N.AD_ORG_ID, N.BEG_VW_PESSOA_ENTREGA_ID, N.DT_EMISSAO, N.VLR_DESCONTO\n      FROM BEG_FAT_NFS N\n     WHERE N.BEG_CONVENIO_ID = :NEW.BEG_CONVENIO_ID\n       AND N.DT_EMISSAO BETWEEN :NEW.DT_INICIAL AND :NEW.DT_FINAL\n       AND NVL(N.CANCELADA, 'N') = 'N'\n       AND NOT EXISTS\n     (SELECT 1\n              FROM BEG_CPR_NFE NE\n             WHERE NE.BEG_FAT_NFS_ID = N.BEG_FAT_NFS_ID\n               AND NE.DT_EMISSAO BETWEEN :NEW.DT_INICIAL AND :NEW.DT_FINAL)\n      AND N.DIE_NFE_CONVENIO_ID IS NULL\n      AND N.IND_NF_CONVENIADA = 'N';\n\nBEGIN\n\n  FOR X IN C1 LOOP\n  \n    INSERT INTO DIE_NFE_CONV_NOTAS\n      (DIE_NFE_CONV_NOTAS_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       VALUE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       DIE_NFE_CONVENIO_ID,\n       BEG_FAT_NFS_ID,\n       DOCSTATUS,\n       VALOR,\n       BEG_FILIAL_ID,\n       BEG_PESSOA_ID,\n       DT_EMISSAO_NF,\n       VLR_DESCONTO)\n    VALUES\n      (BEG_FNC_AD_SEQUENCE('DIE_NFE_CONV_NOTAS'),\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID, --AD_ORG_ID             ,\n       'N', --ISACTIVE              ,\n       NULL, --VALUE                 ,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       :NEW.DIE_NFE_CONVENIO_ID,\n       X.BEG_FAT_NFS_ID,\n       'WC',\n       X.VL_TOTAL_NFS, -- VALOR   \n       X.AD_ORG_ID,\n       X.BEG_VW_PESSOA_ENTREGA_ID,\n       X.DT_EMISSAO  ,\n       X.VLR_DESCONTO  \n       );\n  \n  END LOOP;\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BI_NFE_CONVENIO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  CURSOR C1 IS\n    SELECT C.*\n      FROM BEG_CONVENIO C\n     WHERE C.BEG_CONVENIO_ID = :NEW.BEG_CONVENIO_ID;\n  R1 C1%ROWTYPE;\n\n  CURSOR C2 IS\n    SELECT COUNT(1) QTDE\n      FROM DIE_NFE_CONVENIO N\n     WHERE N.BEG_CONVENIO_ID = :NEW.BEG_CONVENIO_ID\n       AND N.DOCSTATUS <> 'CO'\n       AND N.ISACTIVE = 'Y';\n  R2 C2%ROWTYPE;\n\nBEGIN\n\n  IF INSERTING THEN\n  \n    OPEN C1;\n    FETCH C1\n      INTO R1;\n    CLOSE C1;\n  \n    IF TO_CHAR(:NEW.DT_FINAL, 'DD') <> to_char(R1.DIA_FIM) THEN\n      raise_application_error(-20001,\n                              'Dia final de faturamento diferente do cadastrado para o convenio');\n    END IF;\n  \n\n    OPEN C2;\n    FETCH C2\n      INTO R2;\n    CLOSE C2;\n  \n    IF nvl(R2.QTDE,0) > 0 THEN\n      raise_application_error(-20001,\n                              'Existe processo em aberto para este convenio. Verifique!!');\n    END IF;\n\n  END IF;  \n   \n  IF :NEW.DT_FINAL > TRUNC(SYSDATE) THEN\n      raise_application_error(-20001,\n                              'Data final não pode ser maior que o dia corrente. Verifique!!');\n    \n  END IF;\n    \n\n   IF :NEW.DT_FINAL < :NEW.DT_INICIAL THEN\n      raise_application_error(-20001,\n                              'Data final não pode ser menor que data inicial. Verifique!!');\n    \n  END IF;\n    \n\n\nEND;\n"}`;
    
    }
}
