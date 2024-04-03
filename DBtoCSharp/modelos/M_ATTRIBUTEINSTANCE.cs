
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_ATTRIBUTEINSTANCE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_ATTRIBUTESETINSTANCE_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_ATTRIBUTE_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int M_ATTRIBUTEVALUE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALUENUMBER { get; set; }

    }
}
