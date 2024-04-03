
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_PRODUCT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
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
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// Order/Invoice/.. additional note
        /// </summary>
        public string DOCUMENTNOTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HELP { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string UPC { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string SKU { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_UOM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALESREP_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSUMMARY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSTOCKED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPURCHASED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSOLD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISBOM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISINVOICEPRINTDETAILS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPICKLISTPRINTDETAILS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISVERIFIED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_REVENUERECOGNITION_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_CATEGORY_ID { get; set; }
        
        /// <summary>
        /// ABC Classification
        /// </summary>
        public string CLASSIFICATION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VOLUME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int WEIGHT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SHELFWIDTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SHELFHEIGHT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SHELFDEPTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UNITSPERPALLET { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_TAXCATEGORY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int S_RESOURCE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DISCONTINUED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DISCONTINUEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int S_EXPENSETYPE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PRODUCTTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IMAGEURL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTIONURL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int GUARANTEEDAYS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_MAILTEXT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VERSIONNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_ATTRIBUTESET_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_ATTRIBUTESETINSTANCE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOWNLOADURL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_FREIGHTCATEGORY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_LOCATOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int GUARANTEEDAYSMIN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISWEBSTOREFEATURED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSELFSERVICE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_SUBSCRIPTIONTYPE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDROPSHIP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISEXCLUDEAUTODELIVERY { get; set; }

    }
}
