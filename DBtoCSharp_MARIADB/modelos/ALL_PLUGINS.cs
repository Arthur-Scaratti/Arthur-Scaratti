
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ALL_PLUGINS
    {
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string PLUGIN_NAME { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PLUGIN_VERSION { get; set; }
            [Required]
    [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string PLUGIN_STATUS { get; set; }
            [Required]
    [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string PLUGIN_TYPE { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PLUGIN_TYPE_VERSION { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string PLUGIN_LIBRARY { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PLUGIN_LIBRARY_VERSION { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string PLUGIN_AUTHOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PLUGIN_DESCRIPTION { get; set; }
            [Required]
    [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string PLUGIN_LICENSE { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string LOAD_OPTION { get; set; }
            [Required]
    [StringLength(12)]
        /// <summary>
        /// 
        /// </summary>
        public string PLUGIN_MATURITY { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string PLUGIN_AUTH_VERSION { get; set; }

}
}
