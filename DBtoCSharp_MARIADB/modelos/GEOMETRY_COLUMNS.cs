
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class GEOMETRY_COLUMNS
    {
            [Required]
    [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string F_TABLE_CATALOG { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string F_TABLE_SCHEMA { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string F_TABLE_NAME { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string F_GEOMETRY_COLUMN { get; set; }
            [Required]
    [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string G_TABLE_CATALOG { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string G_TABLE_SCHEMA { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string G_TABLE_NAME { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string G_GEOMETRY_COLUMN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int STORAGE_TYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int GEOMETRY_TYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COORD_DIMENSION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MAX_PPR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public short SRID { get; set; }

}
}
