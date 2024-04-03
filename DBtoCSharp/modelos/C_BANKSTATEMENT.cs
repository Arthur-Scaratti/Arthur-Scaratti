
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_BANKSTATEMENT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_BANKSTATEMENT_ID { get; set; }
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
        public int C_BANKACCOUNT_ID { get; set; }
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
        public string ISMANUAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string STATEMENTDATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEGINNINGBALANCE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ENDINGBALANCE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int STATEMENTDIFFERENCE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATEFROM { get; set; }
        
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
        
        /// <summary>
        /// 
        /// </summary>
        public string EFTSTATEMENTREFERENCE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EFTSTATEMENTDATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string MATCHSTATEMENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISAPPROVED { get; set; }
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

    }
}
