
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_USER
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string PASSWORD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SUPERVISOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PA_GOAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PA_GOALPRIVATE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EMAILUSER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EMAILUSERPW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_LOCATION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_GREETING_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TITLE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string COMMENTS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PHONE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PHONE2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string FAX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LASTCONTACT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LASTRESULT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string BIRTHDAY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORGTRX_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EMAILVERIFY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EMAILVERIFYDATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NOTIFICATIONTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISFULLBPACCESS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_JOB_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LDAPUSER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CONNECTIONPROFILE { get; set; }

    }
}
