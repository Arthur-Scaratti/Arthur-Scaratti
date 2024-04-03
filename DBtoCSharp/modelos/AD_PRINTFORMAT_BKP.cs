
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_PRINTFORMAT_BKP
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTFORMAT_ID { get; set; }
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
        public string ISTABLEBASED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISFORM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_TABLE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTPAPER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTCOLOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTFONT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSTANDARDHEADERFOOTER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int HEADERMARGIN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int FOOTERMARGIN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATECOPY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_REPORTVIEW_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTTABLEFORMAT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PRINTERNAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDEFAULT { get; set; }

    }
}
