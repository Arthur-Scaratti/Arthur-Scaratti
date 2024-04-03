
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_ACCTSCHEMA
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISTRADEDISCOUNTPOSTED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDISCOUNTCORRECTSTAX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_COSTTYPE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string COSTINGLEVEL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISADJUSTCOGS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORGONLY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPOSTSERVICES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISEXPLICITCOSTADJUSTMENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string COMMITMENTTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_ACCTSCHEMA_ID { get; set; }
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
        public string GAAP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISACCRUAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string COSTINGMETHOD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string AUTOPERIODCONTROL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PERIOD_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERIOD_OPENHISTORY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERIOD_OPENFUTURE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string SEPARATOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string HASALIAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string HASCOMBINATION { get; set; }

    }
}
