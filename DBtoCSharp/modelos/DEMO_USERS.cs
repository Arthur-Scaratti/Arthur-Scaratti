
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DEMO_USERS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int USER_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string USER_NAME { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string PASSWORD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED_ON { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QUOTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PRODUCTS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EXPIRES_ON { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ADMIN_USER { get; set; }

        [NotMapped]
        public string Trigger_DEMO_USERS_T1 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n:NEW.user_name := upper(:NEW.user_name);\nend;"}`;
    
        [NotMapped]
        public string Trigger_BI_DEMO_USERS { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\nbegin\n  for c1 in (\n    select DEMO_USERS_SEQ.nextval next_val\n    from dual\n  ) loop\n    :new.USER_ID :=  c1.next_val;\n    :new.admin_user := 'N';\n    :new.created_on := sysdate;\n  end loop;\nend;\nend;"}`;
    
    }
}
