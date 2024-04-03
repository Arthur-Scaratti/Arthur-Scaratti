
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_PAYMENTPROCESSOR
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYMENTPROCESSOR_ID { get; set; }
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
        /// 
        /// </summary>
        public int C_BANKACCOUNT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_SEQUENCE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PAYPROCESSORCLASS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string USERID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PASSWORD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HOSTADDRESS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int HOSTPORT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROXYADDRESS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROXYPORT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROXYLOGON { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROXYPASSWORD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACCEPTVISA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACCEPTMC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACCEPTAMEX { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACCEPTDINERS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACCEPTDISCOVER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACCEPTCORPORATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACCEPTCHECK { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACCEPTATM { get; set; }
            [Required]
        /// <summary>
        /// Verification Cide mandatory
        /// </summary>
        public string REQUIREVV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COSTPERTRX { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COMMISSION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PARTNERID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VENDORID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MINIMUMAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACCEPTDIRECTDEBIT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACCEPTDIRECTDEPOSIT { get; set; }

    }
}
