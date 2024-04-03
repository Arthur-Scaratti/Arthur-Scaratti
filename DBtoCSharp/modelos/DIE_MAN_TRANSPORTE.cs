
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_MAN_TRANSPORTE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_MAN_TRANSPORTE_ID { get; set; }
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
        /// Data de emissao do manifesto
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOTAL_NFS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PLACA_VEICULO { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_SAIDA { get; set; }
            [Required]
        /// <summary>
        /// Loja destino
        /// </summary>
        public int BEG_VW_PESSOA_ENTREGA_ID { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// WC, AP, CO, CA
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// motorista ou freteiro terceirizado
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Lacres do caminhao
        /// </summary>
        public string LACRE { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// Numeracao Sequencial 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// Peso bruto da mercadoria constante nas NFs
        /// </summary>
        public int PESO_BRUTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica se o documento foi impresso.
        /// </summary>
        public string IMPRESSO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BI_MAN_TRANSPORTE { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  V_ID NUMBER(10);\n\n  -- PRAGMA AUTONOMOUS_TRANSACTION;\n  ---\n  cursor c1 is\n    select a.*\n      from ad_org a\n     where a.encerramento = 'N'\n       and a.ad_org_id not in\n           (11, 12, 1000085, 1000086, 1000097, 1000125, 1000134);\n  R1 C1%rowtype;\n  ---\n\n  cursor c2 is\n    select N.*\n      from BEG_FAT_NFS N\n     where N.IND_MANIFESTO = 'N'\n       AND N.DIE_MAN_TRANSPORTE_ID IS NULL\n       and N.BEG_VW_PESSOA_ENTREGA_ID = :NEW.BEG_VW_PESSOA_ENTREGA_ID;\n  R2 C2%rowtype;\n\n  ---\n  CURSOR C3 IS\n    SELECT COUNT(M.DIE_MAN_TRANSPORTE_ID) QTDE\n     FROM DIE_MAN_TRANSPORTE M\n   WHERE M.BEG_VW_PESSOA_ENTREGA_ID = :NEW.BEG_VW_PESSOA_ENTREGA_ID\n     AND M.DOCSTATUS = 'WC';\n  R3 C3%ROWTYPE;\n\nBEGIN\n  --\n  IF INSERTING THEN\n     \n         :NEW.DOCSTATUS := 'WC';\n    open C3;\n    fetch C3\n      into R3;\n    close C3;\n\n        IF R3.QTDE >0 THEN\n          RAISE_APPLICATION_ERROR(-20502,'Ja existe romaneio em digitacao para esta filial');\n        END IF;\n\n  END IF;\n  \n  IF DELETING THEN \n    \n    IF :OLD.DOCSTATUS = 'CA' OR :OLD.DOCSTATUS = 'CO' OR :OLD.DOCSTATUS = 'AP' THEN\n      \n      RAISE_APPLICATION_ERROR(-20502,'Romaneio em andamento nao pode ser excluido ');\n\n    END IF;  \n  END IF;\n  \n  IF UPDATING THEN \n    \n     IF :OLD.BEG_VW_PESSOA_ENTREGA_ID <> :NEW.BEG_VW_PESSOA_ENTREGA_ID THEN \n       RAISE_APPLICATION_ERROR(-20502,'Nao permite alteracao de filial destino quando processo ja iniciado ');\n     END IF;\n   \n  END IF;\n      \n  \nEND DIE_TRG_BI_MAN_TRANSPORTE;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AIUD_MAN_TRANSPORTE { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  V_ID NUMBER(10);\n\n  -- PRAGMA AUTONOMOUS_TRANSACTION;\n  ---\n  cursor c1 is\n    select a.*\n      from ad_org a\n     where a.encerramento = 'N'\n       and a.ad_org_id not in\n           (11, 12, 1000085, 1000086, 1000097, 1000125, 1000134);\n  R1 C1%rowtype;\n  ---\n\n  cursor c2 is\n    select N.*\n      from BEG_FAT_NFS N,\n           BEG_EST_TP_ESPECIE TS\n     where N.IND_MANIFESTO = 'N'\n       AND N.BEG_EST_TP_ESPECIE_ID = TS.BEG_EST_TP_ESPECIE_ID\n       AND N.AD_ORG_ID = 1000016 --COMENTAR ESTA LINHA PARA LIBERAR INCLUSAO DAS NOTAS DAS DEMAIS FILIAIS\n       AND TS.IND_MANIFESTO = 'Y'\n       AND N.DIE_MAN_TRANSPORTE_ID IS NULL\n       AND NVL(N.CANCELADA ,'N')= 'N'\n       and N.BEG_VW_PESSOA_ENTREGA_ID = :NEW.BEG_VW_PESSOA_ENTREGA_ID;\n  R2 C2%rowtype;\n\n  ---\n\n\nBEGIN\n  --\n  IF INSERTING THEN\n    \n   \n    open C2;\n    fetch C2\n      into R2;\n    close C2;\n    FOR R2 IN C2 LOOP\n      V_ID := beg_fnc_ad_sequence('DIE_MAN_TRANSPORTE_NF');\n    \n      INSERT INTO DIE_MAN_TRANSPORTE_NF\n        (DIE_MAN_TRANSPORTE_NF_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         DIE_MAN_TRANSPORTE_ID,\n         BEG_FAT_NFS_ID,\n         VL_TOTAL_NFS,\n         OBS,\n         DT_EMISSAO,\n         DOCSTATUS,\n         PESO_BRUTO,\n         BEG_FILIAL_ID\n         )\n      VALUES\n        (V_ID,\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'N',\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         :NEW.DIE_MAN_TRANSPORTE_ID,\n         R2.BEG_FAT_NFS_ID,\n         R2.VL_TOTAL_NFS,\n         :NEW.OBS,\n         R2.DT_EMISSAO,\n         'WC',\n         NVL(R2.PESO_BRUTO,0),\n         :NEW.AD_ORG_ID\n         );\n    \n    END LOOP;\n  END IF;\n\nEND DIE_TRG_AIUD_MAN_TRANSPORTE;\n"}`;
    
    }
}
