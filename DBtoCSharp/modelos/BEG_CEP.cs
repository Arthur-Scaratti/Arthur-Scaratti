
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CEP
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CEP_ID { get; set; }
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
            [StringLength(120)]
        /// <summary>
        /// Descric?o do Logradouro
        /// </summary>
        public string DESCR_LOGRADOURO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PAIS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BAIRRO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_UF_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_BEG_CEP { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"BEGIN\n\n  :NEW.DESCR_LOGRADOURO := UPPER(:NEW.DESCR_LOGRADOURO);\n\n\n\n\nEND DIE_TRG_BIU_BEG_CEP;\n"}`;
    
    }
}
