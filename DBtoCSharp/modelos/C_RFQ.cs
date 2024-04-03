
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_RFQ
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_RFQ_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_RFQ_TOPIC_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATERESPONSE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISRFQRESPONSEACCEPTED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEWORKSTART { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DELIVERYDAYS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEWORKCOMPLETE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string QUOTETYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISQUOTETOTALAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISQUOTEALLQTY { get; set; }
            [Required]
        /// <summary>
        /// Was entered and/or can be edited by user via Self Service
        /// </summary>
        public string ISSELFSERVICE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISINVITEDVENDORSONLY { get; set; }
        
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
        public int AD_USER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SALESREP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MARGIN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATESO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATEPO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PUBLISHRFQ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ORDER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string COPYLINES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RANKRFQ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTNO { get; set; }

    }
}
