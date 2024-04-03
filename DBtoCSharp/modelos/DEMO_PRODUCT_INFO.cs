
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DEMO_PRODUCT_INFO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int PRODUCT_ID { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string PRODUCT_NAME { get; set; }
            [StringLength(2000)]
        /// <summary>
        /// 
        /// </summary>
        public string PRODUCT_DESCRIPTION { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string CATEGORY { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string PRODUCT_AVAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LIST_PRICE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] PRODUCT_IMAGE { get; set; }
            [StringLength(255)]
        /// <summary>
        /// 
        /// </summary>
        public string MIMETYPE { get; set; }
            [StringLength(400)]
        /// <summary>
        /// 
        /// </summary>
        public string FILENAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IMAGE_LAST_UPDATE { get; set; }

        [NotMapped]
        public string Trigger_INSERT_DEMO_PROD { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n  prod_id number;\nBEGIN\n  SELECT demo_prod_seq.nextval\n    INTO prod_id\n    FROM dual;\n  :new.PRODUCT_ID := prod_id;\nEND;"}`;
    
    }
}
