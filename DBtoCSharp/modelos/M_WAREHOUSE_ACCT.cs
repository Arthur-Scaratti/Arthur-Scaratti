
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_WAREHOUSE_ACCT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_WAREHOUSE_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_ACCTSCHEMA_ID { get; set; }
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
        public int W_INVENTORY_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int W_INVACTUALADJUST_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int W_DIFFERENCES_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int W_REVALUATION_ACCT { get; set; }

    }
}
