
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PA_REPORTLINE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int PA_REPORTLINE_ID { get; set; }
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
        public int PA_REPORTLINESET_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int PARENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSUMMARY { get; set; }
            [Required]
        /// <summary>
        /// (C)alculation (S)egmentValue
        /// </summary>
        public string LINETYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CALCULATIONTYPE { get; set; }
        
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
        public string POSTINGTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int GL_BUDGET_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string AMOUNTTYPE { get; set; }

    }
}
