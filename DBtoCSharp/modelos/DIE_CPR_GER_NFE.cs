
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CPR_GER_NFE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CPR_GER_NFE_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AI_CPR_GER_NFE { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n\n  CURSOR C2 IS\n    SELECT NF.*, IT.VL_UNITARIO\n      FROM BEG_FAT_NFS NV, BEG_HST_NOTA_FISCAL NF, BEG_FAT_NFS_ITEM IT\n     WHERE NV.BEG_FAT_NFS_ID = NF.BEG_FAT_NFS_ID\n       AND NV.BEG_FAT_NFS_ID = IT.BEG_FAT_NFS_ID\n       AND NF.BEG_FAT_NFS_ITEM_ID = IT.BEG_FAT_NFS_ITEM_ID       \n       AND NV.BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID\n       AND NF.QTD_FALTANTE > 0\n       AND NV.BEG_EST_TP_ESPECIE_ID = 2000021;\n  --     R2 C2%ROWTYPE;\n\nBEGIN\n\n  IF INSERTING THEN\n\n    FOR X IN C2 LOOP\n\n      INSERT INTO DIE_CPR_GER_NFE_ITEM\n        (DIE_CPR_GER_NFE_ITEM_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         SEQUENCIA,\n         QTD,\n         VLR_UNITARIO,\n         VLR_TOTAL,\n         ALQ_ICMS,\n         ALQ_OUTROS_ICMS,\n         ALQ_ICMS_SUBST,\n         VLR_BASE_ICMS,\n         VLR_BASE_OUTROS_ICMS,\n         VLR_BASE_ICMS_SUBST,\n         VLR_BASE_ISENTO_ICMS,\n         VLR_ICMS,\n         VLR_ICMS_SUBST,\n         OBS,\n         DIE_CPR_GER_NFE_ID,\n         BEG_PRODUTO_ID,\n         BEG_PRD_SKU_ID,\n         BEG_EST_ALMOXARIFADO_ID,\n         BEG_TIPO_NF_ID,\n         QTD_ATENDIDA,\n         BEG_HST_NOTA_FISCAL_ID)\n      VALUES\n        (BEG_FNC_AD_SEQUENCE('DIE_CPR_GER_NFE_ITEM'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'Y', --ISACTIVE,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         0, --SEQUENCIA,\n         X.QTD_FALTANTE, --QTD,\n         X.VL_UNITARIO,\n         (X.QTD_FALTANTE*X.VL_UNITARIO) ,--VLR_TOTAL,\n         0, --ALQ_ICMS,\n         0, --ALQ_OUTROS_ICMS,\n         0, --ALQ_ICMS_SUBST,\n         0, --VLR_BASE_ICMS,\n         0, --VLR_BASE_OUTROS_ICMS,\n         0, --VLR_BASE_ICMS_SUBST,\n         0, --VLR_BASE_ISENTO_ICMS,\n         0, --VLR_ICMS,\n         0, --VLR_ICMS_SUBST,\n         NULL, --OBS,\n         :NEW.DIE_CPR_GER_NFE_ID,\n         x.BEG_PRODUTO_ID,\n         x.BEG_PRD_SKU_ID,\n         null, --BEG_EST_ALMOXARIFADO_ID,\n         null, --BEG_TIPO_NF_ID,\n         X.QTD_FALTANTE , --QTD_ATENDIDA,\n         X.BEG_HST_NOTA_FISCAL_ID\n\n         );\n\n    END LOOP;\n\n  END IF;\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BI_CPR_GER_NFE { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n  CURSOR C1 IS\n    SELECT N.*\n      FROM BEG_FAT_NFS N\n     WHERE N.BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID;\n\n  R1 C1%ROWTYPE;\n\n  CURSOR C2 IS\n    SELECT SUM(H.QTD_DEVOLVIDA) QTDE_DEVOL\n      FROM BEG_HST_NOTA_FISCAL H\n     WHERE H.BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID;\n\n  R2 C2%ROWTYPE;\n\nBEGIN\n\n  IF INSERTING THEN\n  \n    OPEN C2;\n    FETCH C2\n      INTO R2;\n    CLOSE C2;\n  \n  IF R2.QTDE_DEVOL > 0 THEN\n    \nRAISE_APPLICATION_ERROR(-20501,\n                        'NOTA JA ATENDIDA PARCIALMENTE NAO PERMITE GERAR NF DE RETORNO. VERIFIQUE!!');\n    \nEND IF;\n  \n    OPEN C1;\n    FETCH C1\n      INTO R1;\n    CLOSE C1;\n  \n    :NEW.VLR_TOTAL_PRODUTOS   := R1.VL_TOTAL_NFS;\n    :NEW.DT_EMISSAO           := TRUNC(SYSDATE);\n    :NEW.VLR_TOTAL_NOTA       := R1.VL_TOTAL_NFS;\n    :NEW.DT_ENTRADA           := TRUNC(SYSDATE);\n    :NEW.CHAVE_NFE            := R1.CHAVE;\n    :NEW.OBS                  := R1.OBS ||\n                                 '  RETORNO REFERENTE NF DE REMESSA : ' ||\n                                 R1.NRO_NFS || '  DO DIA: ' ||\n                                 R1.DT_EMISSAO;\n    :NEW.BEG_VW_FORNECEDOR_ID := R1.BEG_VW_PESSOA_ENTREGA_ID;\n  \n  END IF;\n\nEND;\n"}`;
    
    }
}
