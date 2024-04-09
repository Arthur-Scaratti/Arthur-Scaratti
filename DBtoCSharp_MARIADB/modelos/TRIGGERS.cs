
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TRIGGERS
    {
            [Required]
    [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string TRIGGER_CATALOG { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TRIGGER_SCHEMA { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TRIGGER_NAME { get; set; }
            [Required]
    [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string EVENT_MANIPULATION { get; set; }
            [Required]
    [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string EVENT_OBJECT_CATALOG { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string EVENT_OBJECT_SCHEMA { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string EVENT_OBJECT_TABLE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ACTION_ORDER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ACTION_CONDITION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACTION_STATEMENT { get; set; }
            [Required]
    [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string ACTION_ORIENTATION { get; set; }
            [Required]
    [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string ACTION_TIMING { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string ACTION_REFERENCE_OLD_TABLE { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string ACTION_REFERENCE_NEW_TABLE { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string ACTION_REFERENCE_OLD_ROW { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string ACTION_REFERENCE_NEW_ROW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
            [Required]
    [StringLength(8192)]
        /// <summary>
        /// 
        /// </summary>
        public string SQL_MODE { get; set; }
            [Required]
    [StringLength(384)]
        /// <summary>
        /// 
        /// </summary>
        public string DEFINER { get; set; }
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
