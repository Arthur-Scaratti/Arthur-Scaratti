
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_INOUTLINECONFIRM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_INOUTLINECONFIRM_ID { get; set; }
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
        public int M_INOUTCONFIRM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_INOUTLINE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TARGETQTY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CONFIRMEDQTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIFFERENCEQTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SCRAPPEDQTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_INVENTORYLINE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICELINE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CONFIRMATIONNO { get; set; }

    }
}
