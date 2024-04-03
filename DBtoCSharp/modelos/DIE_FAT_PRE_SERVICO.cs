
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_PRE_SERVICO
    {
        
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
        public int DIE_FAT_PRE_NFS_ITEM_ID { get; set; }
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
        public int DIE_FAT_PRE_NFS_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_PRE_SERVICO_ID { get; set; }
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
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_SERVICO { get; set; }

        [NotMapped]
        public string Trigger_DIE_BI_FAT_PRE_SERVICO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n \n  cursor c1 is\n  select value \n   from ad_org a\n   where a.ad_org_id = :new.ad_org_id ;\n   \n   r1 c1%rowtype;\n   \n\n\nbegin\n\n   OPEN C1;\n  FETCH C1 INTO R1;\n  CLOSE C1;\n  \n  :new.value := R1.VALUE;\n\n  :new.value  := :new.value ||beg_fnc_retorna_parametro(1000000--:NEW.AD_CLIENT_ID\n                                                ,:NEW.AD_ORG_ID\n                                                ,'Vendas'\n                                                ,'Faturamento'\n                                                ,'NRO_CERTIFICADO');\n    --\n    UPDATE BEG_PARAMETRO_SISTEMA S\n       SET S.NUMERO = S.NUMERO + 1\n     WHERE S.NAME = 'NRO_CERTIFICADO'\n       AND S.AD_ORG_ID = :NEW.AD_ORG_ID;\n\n\nend DIE_BI_FAT_PRE_SERVICO;\n"}`;
    
    }
}
