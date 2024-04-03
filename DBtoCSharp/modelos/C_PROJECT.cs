
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_PROJECT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
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
        public string VALUE { get; set; }
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
        public string NOTE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSUMMARY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_LOCATION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string POREFERENCE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYMENTTERM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRICELIST_VERSION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CAMPAIGN_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCOMMITMENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PLANNEDAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PLANNEDQTY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PLANNEDMARGINAMT { get; set; }
            [Required]
        /// <summary>
        /// Business Partner Commitment
        /// </summary>
        public int COMMITTEDAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATECONTRACT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEFINISH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string GENERATETO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALESREP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string COPYFROM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECTTYPE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COMMITTEDQTY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int INVOICEDAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int INVOICEDQTY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PROJECTBALANCEAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PHASE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCOMMITCEILING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_WAREHOUSE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTCATEGORY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNERSR_ID { get; set; }

    }
}
