
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_PAYMENTTERM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYMENTTERM_ID { get; set; }
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
        public string DOCUMENTNOTE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string AFTERDELIVERY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDUEFIXED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NETDAYS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int GRACEDAYS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FIXMONTHCUTOFF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FIXMONTHDAY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FIXMONTHOFFSET { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DISCOUNTDAYS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DISCOUNT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DISCOUNTDAYS2 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DISCOUNT2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISNEXTBUSINESSDAY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISDEFAULT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NETDAY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISVALID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }

    }
}
