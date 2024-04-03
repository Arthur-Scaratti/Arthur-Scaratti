
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_INOUT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_INOUT_ID { get; set; }
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
        public string DOCACTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string POSTED { get; set; }
        
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
        public int C_DOCTYPE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ORDER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEORDERED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPRINTED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string MOVEMENTTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string MOVEMENTDATE { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_WAREHOUSE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string POREFERENCE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DELIVERYRULE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string FREIGHTCOSTRULE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FREIGHTAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DELIVERYVIARULE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_SHIPPER_ID { get; set; }
        
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
        public string PRIORITYRULE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEPRINTED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICE_ID { get; set; }
        
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
        public int SALESREP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NOPACKAGES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PICKDATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SHIPDATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TRACKINGNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORGTRX_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CAMPAIGN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ACTIVITY_ID { get; set; }
        
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
        public string DATERECEIVED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISINTRANSIT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int REF_INOUT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATECONFIRM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATEPACKAGE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISAPPROVED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISINDISPUTE { get; set; }

    }
}
