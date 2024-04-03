
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_RFQLINEQTY
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_RFQLINEQTY_ID { get; set; }
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
        public int C_RFQLINE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_UOM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MARGIN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPURCHASEQTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BESTRESPONSEAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISOFFERQTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OFFERAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BENCHMARKPRICE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISRFQQTY { get; set; }

    }
}
