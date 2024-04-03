
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_SERVICO_RET
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DIE_COD_ESTRUTURADO { get; set; }
            [StringLength(55)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_RESUMIDA { get; set; }
            [StringLength(55)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_GARANTIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IOF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PREMIO_LIQ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MAX_INDENIZA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NR_PEDIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_UNITARIO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// nome do vendedor
        /// </summary>
        public string VENDEDOR { get; set; }
        
        /// <summary>
        /// tempo da garantia estendida
        /// </summary>
        public int GAR_EST { get; set; }
        
        /// <summary>
        /// tempo garantia fabricante
        /// </summary>
        public int GAR_FAB { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NR_RECIBO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_APOLICE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_BILHETE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CODPROD { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_SERVICO_RET_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CANCELAMENTO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_AUT_DEVOLUCAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PRECO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_SERIE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_TIPO_VENDA { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_SERVICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENVIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_NFS_ITEM_RETORNO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PRODUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_GARANTIA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_RECIBO_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTADO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPORISCO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRSORTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int APOLICEGAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int APOLICEPF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int APOLICERES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_NFS_RET_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_DIE_SERV_RET { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\nBEGIN\n  IF NVL(:NEW.COD_SERVICO, 'A') <> 'PFIN' THEN\n  \n    :NEW.APOLICEPF := NULL;\n  \n  END IF;\n\n  IF :NEW.DT_INICIO IS NULL THEN\n  \n    :NEW.DT_INICIO := TRUNC(SYSDATE);\n  \n  END IF;\n\n  IF NVL(:NEW.COD_SERVICO, 'A') = 'PFIN' THEN\n  \n    :NEW.DT_INICIO := TRUNC(SYSDATE);\n  \n  END IF;\n\nEND;\n"}`;
    
    }
}
