
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FILE_BROWSER
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FILE_BROWSER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string MIME_TYPE { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string FILENAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public byte[] DOCUMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// Y = Indica que o usuário já acessou o arquivo. Logo, ele fica Read Only
        /// </summary>
        public string IND_ACESSO { get; set; }

    }
}
