
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPR_CFR_NFE
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do registro do relacionamento entre os conhec. frete x notas
        /// </summary>
        public int BEG_CPR_CFR_NFE_ID { get; set; }
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
        
        /// <summary>
        /// Numero da NF entrada
        /// </summary>
        public int NUMERO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Seie da nota fiscal entrada
        /// </summary>
        public string SERIE { get; set; }
        
        /// <summary>
        /// Data emissao
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// Valor total nota
        /// </summary>
        public int VLR_TOTAL_NOTA { get; set; }
        
        /// <summary>
        /// Valor total mercadorias/produtos
        /// </summary>
        public int VLR_TOTAL_PRODUTOS { get; set; }
        
        /// <summary>
        /// Nro de volumes
        /// </summary>
        public int NRO_VOLUMES { get; set; }
        
        /// <summary>
        /// Peso Bruto
        /// </summary>
        public int PESO_BRUTO { get; set; }
        
        /// <summary>
        /// Peso Liquido
        /// </summary>
        public int PESO_LIQUIDO { get; set; }
            [Required]
        /// <summary>
        /// Id do conhecimento de frete
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// Id do fornecedor
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// Id da nota fiscal relacionada
        /// </summary>
        public int BEG_VW_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// Indica que a nota fiscal refere-se a entrada ou saida
        /// </summary>
        public string IND_ENTSAI { get; set; }
        
        /// <summary>
        /// id do cliente
        /// </summary>
        public int BEG_VW_PESSOA_ENTREGA_ID { get; set; }
        
        /// <summary>
        /// Ida da nota fiscal de saida
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CUSTO_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CUSTO { get; set; }

    }
}
