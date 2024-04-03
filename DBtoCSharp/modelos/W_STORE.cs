
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class W_STORE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int W_STORE_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string WSTOREEMAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WSTOREUSER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WSTOREUSERPW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WEBINFO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WEBPARAM1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WEBPARAM2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WEBPARAM3 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WEBPARAM4 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WEBPARAM5 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WEBPARAM6 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMENUASSETS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMENUORDERS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMENUINVOICES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMENUSHIPMENTS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMENUPAYMENTS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMENURFQS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMENUREQUESTS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMENUINTERESTS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMENUREGISTRATIONS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMENUCONTACT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EMAILHEADER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EMAILFOOTER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SALESREP_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_WAREHOUSE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_PRICELIST_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string WEBCONTEXT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WEBORDEREMAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYMENTTERM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDEFAULT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string URL { get; set; }

    }
}
