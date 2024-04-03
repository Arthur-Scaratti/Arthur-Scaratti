
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_LOCATION
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_LOCATION_ID { get; set; }
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
        public string ADDRESS1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ADDRESS2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CITY { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string POSTAL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string POSTAL_ADD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_COUNTRY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_REGION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CITY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string REGIONNAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ADDRESS3 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ADDRESS4 { get; set; }

    }
}
