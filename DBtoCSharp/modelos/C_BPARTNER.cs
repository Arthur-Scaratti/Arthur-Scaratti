
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_BPARTNER
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int SALESVOLUME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUMBEREMPLOYEES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NAICS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string FIRSTSALE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ACQUSITIONCOST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int POTENTIALLIFETIMEVALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ACTUALLIFETIMEVALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SHAREOFCUSTOMER { get; set; }
        
        /// <summary>
        /// Check, BACS, Letter of Credit
        /// </summary>
        public string PAYMENTRULE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SO_CREDITLIMIT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SO_CREDITUSED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYMENTTERM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRICELIST_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_DISCOUNTSCHEMA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_DUNNING_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISDISCOUNTPRINTED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SO_DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string POREFERENCE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PAYMENTRULEPO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PO_PRICELIST_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PO_DISCOUNTSCHEMA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PO_PAYMENTTERM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DOCUMENTCOPIES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_GREETING_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string INVOICERULE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DELIVERYRULE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string FREIGHTCOSTRULE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DELIVERYVIARULE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALESREP_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string SENDEMAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BPARTNER_PARENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int INVOICE_PRINTFORMAT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SOCREDITSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SHELFLIFEMINPCT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORGBP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FLATDISCOUNT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTALOPENBALANCE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
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
        public string NAME2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSUMMARY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_BP_GROUP_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISONETIME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPROSPECT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISVENDOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCUSTOMER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISEMPLOYEE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSALESREP { get; set; }
        
        /// <summary>
        /// Own Custoner or Vendor Number at the Business Partner
        /// </summary>
        public string REFERENCENO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DUNS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string URL { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string AD_LANGUAGE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string TAXID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISTAXEXEMPT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICESCHEDULE_ID { get; set; }
        
        /// <summary>
        /// Payment, Delivery Performance, Strategic Partner
        /// </summary>
        public string RATING { get; set; }

    }
}
