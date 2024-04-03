
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VW_PROD_XMLS_ENT_VM
    {
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DIE_COD_ESTRUTURADO { get; set; }
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
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_DETALHADA { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string PROD { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string EAN { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string CEST { get; set; }

    }
}
