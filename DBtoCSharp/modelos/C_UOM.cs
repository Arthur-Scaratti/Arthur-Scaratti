
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_UOM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_UOM_ID { get; set; }
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
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// EDI X12 Data Element 355 (Unit or Basis for Measurement)
        /// </summary>
        public string X12DE355 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UOMSYMBOL { get; set; }
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
        public int STDPRECISION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COSTINGPRECISION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDEFAULT { get; set; }

    }
}
