
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_PRODUCT_COSTING
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRICELASTINV { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TOTALINVQTY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TOTALINVAMT { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
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
        public int CURRENTCOSTPRICE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int FUTURECOSTPRICE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COSTSTANDARD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COSTSTANDARDPOQTY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COSTSTANDARDPOAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COSTSTANDARDCUMQTY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COSTSTANDARDCUMAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COSTAVERAGE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COSTAVERAGECUMQTY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COSTAVERAGECUMAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRICELASTPO { get; set; }

    }
}
