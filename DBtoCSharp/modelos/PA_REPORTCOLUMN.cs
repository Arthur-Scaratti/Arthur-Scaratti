
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PA_REPORTCOLUMN
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PA_REPORTCOLUMNSET_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SEQNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPRINTED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string POSTINGTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int GL_BUDGET_ID { get; set; }
            [Required]
        /// <summary>
        /// (R)elativePeriod - (C)alculation - (S)egmentElementType
        /// </summary>
        public string COLUMNTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RELATIVEPERIOD { get; set; }
        
        /// <summary>
        /// (S)ource or (A)ccounted
        /// </summary>
        public string CURRENCYTYPE { get; set; }
        
        /// <summary>
        /// (A)dd - (S)ubtract - (P)ercentage 
        /// </summary>
        public string CALCULATIONTYPE { get; set; }
        
        /// <summary>
        /// (D)r only - (C)r only - (B)alance
        /// </summary>
        public string AMOUNTTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISADHOCCONVERSION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OPER_1_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OPER_2_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ELEMENTTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ELEMENTVALUE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CAMPAIGN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_LOCATION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_SALESREGION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ACTIVITY_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int PA_REPORTCOLUMN_ID { get; set; }
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

    }
}
