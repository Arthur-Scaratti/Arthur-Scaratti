
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_APEX_APPLICATION_ACCESS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_APEX_APPLICATION_ACCESS_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Perfil
        /// </summary>
        public int AD_ROLE_ID { get; set; }
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
        public string ISREADWRITE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Aplicação APEX.
        /// </summary>
        public int BEG_APEX_APPLICATION_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Tab da Aplicação APEX.
        /// </summary>
        public int BEG_APEX_APPLICATION_TAB_ID { get; set; }

    }
}
