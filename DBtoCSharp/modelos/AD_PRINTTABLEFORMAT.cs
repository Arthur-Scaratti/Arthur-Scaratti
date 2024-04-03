
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_PRINTTABLEFORMAT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTTABLEFORMAT_ID { get; set; }
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
        public int HDR_PRINTFONT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int HDRTEXTFG_PRINTCOLOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int HDRTEXTBG_PRINTCOLOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int HDRLINE_PRINTCOLOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FUNCT_PRINTFONT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FUNCTBG_PRINTCOLOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FUNCTFG_PRINTCOLOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LINE_PRINTCOLOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPAINTBOUNDARYLINES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPAINTHLINES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPAINTVLINES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPRINTFUNCTIONSYMBOLS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDEFAULT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IMAGEURL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HEADERLEFT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HEADERCENTER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HEADERRIGHT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string FOOTERLEFT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string FOOTERCENTER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string FOOTERRIGHT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IMAGEISATTACHED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int HDRSTROKE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LINESTROKE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HDRSTROKETYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LINESTROKETYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPAINTHEADERLINES { get; set; }

    }
}
