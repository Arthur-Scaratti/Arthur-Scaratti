
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PRECO_12_03_BKP
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_PRECO_ID { get; set; }
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
        public string DT_INICIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PRECO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SUGERIDO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CATALOGO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_EMERGENCIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VIGENCIA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_PRECO_NOVO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTD_CONJUNTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PER_VARIACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NRO_PRESTACOES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PRESTACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NRO_PRESTACOES_FIN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PRESTACAO_FIN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PRECO_FIN { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_APROVADO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_LISTA_APROVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_APROVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIO_ORIGINAL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_IMPORTADO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_PROMOCAO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_CONJUNTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CEL_PLANO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NRO_PRESTACOES_CAR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PRESTACAO_CAR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PRECO_CAR { get; set; }

    }
}
