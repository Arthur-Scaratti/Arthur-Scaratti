
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class R_REQUEST
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int R_REQUEST_ID { get; set; }
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
        public string DOCUMENTNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int R_REQUESTTYPE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_GROUP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_CATEGORY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_STATUS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_RESOLUTION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_REQUESTRELATED_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PRIORITY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PRIORITYUSER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DUETYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string SUMMARY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CONFIDENTIALTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISESCALATED { get; set; }
            [Required]
        /// <summary>
        /// Was entered and/or can be edited by user via Self Service
        /// </summary>
        public string ISSELFSERVICE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALESREP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ROLE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATELASTACTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATELASTALERT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LASTRESULT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISINVOICED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CAMPAIGN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ORDER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYMENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int A_ASSET_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_INOUT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_RMA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TABLE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RECORD_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int REQUESTAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_MAILTEXT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RESULT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CONFIDENTIALTYPEENTRY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_STANDARDRESPONSE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NEXTACTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATENEXTACTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string STARTTIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ENDTIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTYSPENT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTYINVOICED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCTSPENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ACTIVITY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string STARTDATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CLOSEDATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICEREQUEST_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_CHANGEREQUEST_ID { get; set; }

    }
}
