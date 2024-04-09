
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class EVENTS
    {
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string EVENT_CATALOG { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string EVENT_SCHEMA { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string EVENT_NAME { get; set; }
            [Required]
    [StringLength(384)]
        /// <summary>
        /// 
        /// </summary>
        public string DEFINER { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TIME_ZONE { get; set; }
            [Required]
    [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string EVENT_BODY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string EVENT_DEFINITION { get; set; }
            [Required]
    [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string EVENT_TYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EXECUTE_AT { get; set; }
            [StringLength(256)]
        /// <summary>
        /// 
        /// </summary>
        public string INTERVAL_VALUE { get; set; }
            [StringLength(18)]
        /// <summary>
        /// 
        /// </summary>
        public string INTERVAL_FIELD { get; set; }
            [Required]
    [StringLength(8192)]
        /// <summary>
        /// 
        /// </summary>
        public string SQL_MODE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string STARTS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ENDS { get; set; }
            [Required]
    [StringLength(18)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }
            [Required]
    [StringLength(12)]
        /// <summary>
        /// 
        /// </summary>
        public string ON_COMPLETION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string LAST_ALTERED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LAST_EXECUTED { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string EVENT_COMMENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ORIGINATOR { get; set; }
            [Required]
    [StringLength(32)]
        /// <summary>
        /// 
        /// </summary>
        public string CHARACTER_SET_CLIENT { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string COLLATION_CONNECTION { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string DATABASE_COLLATION { get; set; }

}
}
