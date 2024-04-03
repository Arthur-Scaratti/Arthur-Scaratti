
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_GER_DESENV
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_DESENV_ID { get; set; }
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
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// Desenvolvedor
        /// </summary>
        public string IND_DESENVOLVEDOR { get; set; }
        
        /// <summary>
        /// Testador
        /// </summary>
        public string IND_TESTADOR { get; set; }
        
        /// <summary>
        /// Homologador
        /// </summary>
        public string IND_HOMOLOGADOR { get; set; }
            [StringLength(50)]
        /// <summary>
        /// endereco de e-mail
        /// </summary>
        public string EMAIL { get; set; }

    }
}
