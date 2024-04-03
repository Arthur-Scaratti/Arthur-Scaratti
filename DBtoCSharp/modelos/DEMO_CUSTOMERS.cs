
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DEMO_CUSTOMERS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int CUSTOMER_ID { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CUST_FIRST_NAME { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CUST_LAST_NAME { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string CUST_STREET_ADDRESS1 { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string CUST_STREET_ADDRESS2 { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string CUST_CITY { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CUST_STATE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CUST_POSTAL_CODE { get; set; }
            [StringLength(25)]
        /// <summary>
        /// 
        /// </summary>
        public string PHONE_NUMBER1 { get; set; }
            [StringLength(25)]
        /// <summary>
        /// 
        /// </summary>
        public string PHONE_NUMBER2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREDIT_LIMIT { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string CUST_EMAIL { get; set; }

        [NotMapped]
        public string Trigger_INSERT_DEMO_CUST { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n  cust_id number;\nBEGIN\n  SELECT demo_cust_seq.nextval\n    INTO cust_id\n    FROM dual;\n  :new.CUSTOMER_ID := cust_id;\nEND;"}`;
    
    }
}
