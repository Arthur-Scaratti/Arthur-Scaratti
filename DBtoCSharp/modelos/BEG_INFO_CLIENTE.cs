
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_INFO_CLIENTE
    {
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
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MEDIO_TITULOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_CARTA_AVISO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PONTUACAO_CREDITO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COMPRAS_AVISTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_RENEGOCIACOES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_RESTRICOES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COMPRA_ULT_ANO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MEDIA_ATRASO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COMPRAS_APRAZO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MAIOR_COMPRA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_RESTRICAO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ATRASO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ATUALIZAR { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string RESTRINGE_TP_COBR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIMITE_INADIMPL { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_INFO_CLIENTE_ID { get; set; }
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

    }
}
