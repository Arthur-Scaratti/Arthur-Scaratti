
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_COMMISSION
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_COMMISSION_ID { get; set; }
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
            [Required]
        /// <summary>
        /// SalesRep
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
            [Required]
        /// <summary>
        /// AD_Reference_ID=225 - Weekly,Monthly,Quarterly
        /// </summary>
        public string FREQUENCYTYPE { get; set; }
            [Required]
        /// <summary>
        /// AD_Reference_ID=224 - Order, Invoice, Receipt
        /// </summary>
        public string DOCBASISTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string LISTDETAILS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATELASTRUN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATEFROM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CHARGE_ID { get; set; }

    }
}
