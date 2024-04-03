
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_SALDO_INV_TOTAIS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_EST_VENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_DISPONIVEL { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_SALDO_INV_TOTAIS_ID { get; set; }
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
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_EST_SEM_MOVTO { get; set; }

    }
}
