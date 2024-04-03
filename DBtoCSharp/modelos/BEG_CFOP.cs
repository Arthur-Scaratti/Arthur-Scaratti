
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CFOP
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CFOP_ID { get; set; }
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
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CFOP { get; set; }
            [Required]
    [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_OPERACAO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ENT_SAI { get; set; }
        
        /// <summary>
        /// ID DO CODIGO DE ACUMULADOR PARA A DOMINIO - Nacional
        /// </summary>
        public int BEG_CTB_ACUM_DOMINIO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_IPI_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_COFINS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_PIS_ID { get; set; }
        
        /// <summary>
        /// Indicativo do aproveitamento do credito do ICMS -Marcado = Sim
        /// </summary>
        public string IND_APROV_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }

    }
}
