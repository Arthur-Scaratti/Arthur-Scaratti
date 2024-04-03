
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_TIPO_FRETE
    {
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
    [StringLength(40)]
        /// <summary>
        /// Descricao
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// Indicador sped do do tipo de frete 
        /// </summary>
        public int IND_FRETE_SPED { get; set; }
        
        /// <summary>
        /// Indicador tipo frete na nota fiscal saida
        /// </summary>
        public int IND_FRETE_NF { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do registro - Tipo de Frete
        /// </summary>
        public int BEG_GER_TIPO_FRETE_ID { get; set; }
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
            [StringLength(20)]
        /// <summary>
        /// Codigo
        /// </summary>
        public string VALUE { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_TP_FRETE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\nbegin\n--\n  :NEW.NAME := UPPER(:NEW.NAME);\n--\nend BEG_TRG_BIU_TP_FRETE;\n"}`;
    
    }
}
