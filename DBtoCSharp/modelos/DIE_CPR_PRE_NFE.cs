
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CPR_PRE_NFE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CPR_PRE_NFE_ID { get; set; }
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
        /// 
        /// </summary>
        public int NUMERO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTRADA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ISENTO_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PER_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PER_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_PRODUTOS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_NOTA { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(2000)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CFOP_ENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CFOP_SAI_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE_NFE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_GERA_NFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TIPO_TITULO_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AI_CPR_PRE_NFE { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n\n  CURSOR C2 IS\n    SELECT NF.*, IT.VL_UNITARIO\n      FROM BEG_FAT_NFS NV, BEG_HST_NOTA_FISCAL NF, BEG_FAT_NFS_ITEM IT\n     WHERE NV.BEG_FAT_NFS_ID = NF.BEG_FAT_NFS_ID\n       AND NV.BEG_FAT_NFS_ID = IT.BEG_FAT_NFS_ID\n       AND NF.AD_ORG_ID = :NEW.AD_ORG_ID\n       AND NF.BEG_FAT_NFS_ITEM_ID = IT.BEG_FAT_NFS_ITEM_ID       \n       AND NF.QTD_FALTANTE > 0\n       AND NV.CANCELADA = 'N'\n       AND NV.BEG_VW_PESSOA_ENTREGA_ID = :NEW.BEG_VW_FORNECEDOR_ID\n       AND NV.BEG_EST_TP_ESPECIE_ID = 2000021;\n  --     R2 C2%ROWTYPE;\n\nBEGIN\n\n  IF INSERTING THEN\n\n    FOR X IN C2 LOOP\n\n      INSERT INTO DIE_CPR_PRE_NFE_ITEM\n        (DIE_CPR_PRE_NFE_ITEM_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         SEQUENCIA,\n         QTD,\n         VLR_UNITARIO,\n         VLR_TOTAL,\n         ALQ_ICMS,\n         ALQ_OUTROS_ICMS,\n         ALQ_ICMS_SUBST,\n         VLR_BASE_ICMS,\n         VLR_BASE_OUTROS_ICMS,\n         VLR_BASE_ICMS_SUBST,\n         VLR_BASE_ISENTO_ICMS,\n         VLR_ICMS,\n         VLR_ICMS_SUBST,\n         OBS,\n         DIE_CPR_PRE_NFE_ID,\n         BEG_PRODUTO_ID,\n         BEG_PRD_SKU_ID,\n         BEG_EST_ALMOXARIFADO_ID,\n         BEG_TIPO_NF_ID,\n         QTD_ATENDIDA,\n         BEG_HST_NOTA_FISCAL_ID)\n      VALUES\n        (BEG_FNC_AD_SEQUENCE('DIE_CPR_PRE_NFE_ITEM'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'N', --ISACTIVE,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         0, --SEQUENCIA,\n         X.QTD_FALTANTE, --QTD,\n         X.VL_UNITARIO,\n         0, --VLR_TOTAL,\n         0, --ALQ_ICMS,\n         0, --ALQ_OUTROS_ICMS,\n         0, --ALQ_ICMS_SUBST,\n         0, --VLR_BASE_ICMS,\n         0, --VLR_BASE_OUTROS_ICMS,\n         0, --VLR_BASE_ICMS_SUBST,\n         0, --VLR_BASE_ISENTO_ICMS,\n         0, --VLR_ICMS,\n         0, --VLR_ICMS_SUBST,\n         NULL, --OBS,\n         :NEW.DIE_CPR_PRE_NFE_ID,\n         x.BEG_PRODUTO_ID,\n         x.BEG_PRD_SKU_ID,\n         null, --BEG_EST_ALMOXARIFADO_ID,\n         null, --BEG_TIPO_NF_ID,\n         0, --QTD_ATENDIDA,\n         X.BEG_HST_NOTA_FISCAL_ID\n\n         );\n\n    END LOOP;\n\n  END IF;\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BI_CPR_PRE_NFE { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n  CURSOR C1 IS\n    SELECT N.*\n      FROM BEG_CPR_PRE_NFE N\n     WHERE N.CHAVE_NFE = NVL(trim(:NEW.CHAVE_NFE), N.CHAVE_NFE)\n       AND N.AD_ORG_ID = :NEW.AD_ORG_ID\n--       AND N.SITUACAO <> 'CO'\n--       AND N.DOCSTATUS <> 'CO'\n       AND N.NUMERO = NVL(trim(:NEW.NUMERO), N.NUMERO)\n       AND N.BEG_VW_FORNECEDOR_ID =\n           NVL(:NEW.BEG_VW_FORNECEDOR_ID, N.BEG_VW_FORNECEDOR_ID);\n  R1 C1%ROWTYPE;\n\nBEGIN\n\n  IF INSERTING THEN\n  \n    :NEW.CHAVE_NFE := REPLACE(:NEW.CHAVE_NFE, ' ', '');\n    :NEW.DOCSTATUS := 'WC';\n  \n    IF LENGTH(:NEW.CHAVE_NFE) < 44 THEN\n    \n      RAISE_APPLICATION_ERROR(-20501,\n                              'Chave informada com menos de 44 caracteres. Verifique');\n    \n    END IF;\n  \n    OPEN C1;\n    FETCH C1\n      INTO R1;\n    CLOSE C1;\n  \n    if R1.NUMERO IS NULL then\n      RAISE_APPLICATION_ERROR(-20501,\n                              'Nota fiscal nao localizada. Verifique');\n    end if;\n    \n    if R1.DOCSTATUS = 'CO' then\n      RAISE_APPLICATION_ERROR(-20501,\n                              'Nota ja lancada. Verifique');\n    end if;\n    \n  \n    :NEW.DT_EMISSAO     := R1.DT_EMISSAO;\n    :NEW.VLR_TOTAL_NOTA := R1.VLR_TOTAL_NOTA;\n    :NEW.DT_ENTRADA     := TRUNC(SYSDATE);\n    :NEW.OBS := R1.MSG_INF_FISCAL;    \n    :NEW.BEG_VW_FORNECEDOR_ID := R1.BEG_VW_FORNECEDOR_ID;\n    :NEW.NUMERO               := R1.NUMERO;\n  \n  \n  END IF;\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BD_CPR_PRE_NFE { get; set; } = `{"triggering_event":"DELETE","trigger_body":"BEGIN\n\n  if :old.docstatus = 'CO'  then\n      RAISE_APPLICATION_ERROR(-20501, 'Nota ja confirmada nao permite exclusao');\n    end if;\n\n  end;\n"}`;
    
    }
}
