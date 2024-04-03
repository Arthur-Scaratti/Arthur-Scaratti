
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_ATTRIBUTESET
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_ATTRIBUTESET_ID { get; set; }
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
        public string ISSERNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_SERNOCTL_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISLOT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_LOTCTL_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISGUARANTEEDATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int GUARANTEEDAYS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISINSTANCEATTRIBUTE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string MANDATORYTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISGUARANTEEDATEMANDATORY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISLOTMANDATORY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSERNOMANDATORY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SERNOCHARSOVERWRITE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LOTCHARSOVERWRITE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LOTCHAREOVERWRITE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SERNOCHAREOVERWRITE { get; set; }

    }
}
