
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class T_REPORTSTATEMENT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PINSTANCE_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int FACT_ACCT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LEVELNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATEACCT { get; set; }
        
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
        public int AMTACCTDR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AMTACCTCR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BALANCE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTY { get; set; }

    }
}
