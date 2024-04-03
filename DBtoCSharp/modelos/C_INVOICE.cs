
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_INVOICE
    {
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
        public string ISSOTRX { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCACTION { get; set; }
        
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
        public string POSTED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_DOCTYPE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_DOCTYPETARGET_ID { get; set; }
        
        /// <summary>
        /// Will only be filled if 1:1 Relationship
        /// </summary>
        public int C_ORDER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISAPPROVED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISTRANSFERRED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPRINTED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALESREP_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATEINVOICED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEPRINTED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATEACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_LOCATION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string POREFERENCE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDISCOUNTPRINTED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEORDERED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PAYMENTRULE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYMENTTERM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CHARGE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CHARGEAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TOTALLINES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int GRANDTOTAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_PRICELIST_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISTAXINCLUDED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CAMPAIGN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ACTIVITY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPAID { get; set; }
        
        /// <summary>
        /// Temporary
        /// </summary>
        public int C_PAYMENT_ID { get; set; }
        
        /// <summary>
        /// Temporary
        /// </summary>
        public int C_CASHLINE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATEFROM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string GENERATETO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string SENDEMAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string COPYFROM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSELFSERVICE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORGTRX_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int USER1_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int USER2_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CONVERSIONTYPE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPAYSCHEDULEVALID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int REF_INVOICE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISINDISPUTE { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NATUREZA_OPERACAO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICE_ID { get; set; }
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

    }
}
