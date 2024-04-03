
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_DUNNINGLEVEL
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
        public int C_DUNNING_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PRINTNAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DAYSAFTERDUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DAYSBETWEENDUNNING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NOTE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CHARGEINTEREST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int INTERESTPERCENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CHARGEFEE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FEEAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DUNNING_PRINTFORMAT_ID { get; set; }
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
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_DUNNINGLEVEL_ID { get; set; }
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
