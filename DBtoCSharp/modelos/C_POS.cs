
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_POS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_POS_ID { get; set; }
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
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HELP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SALESREP_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_PRICELIST_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CASHBOOK_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_WAREHOUSE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PRINTERNAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_POSKEYLAYOUT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMODIFYPRICE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNERCASHTRX_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_DOCTYPE_ID { get; set; }

    }
}
