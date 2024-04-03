
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CEL_DESTINO
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do destino
        /// </summary>
        public int BEG_CEL_DESTINO_ID { get; set; }
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
        /// Código do destino
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que a informação deve ser complementada
        /// </summary>
        public string IND_COMPLEMENTO { get; set; }
            [Required]
    [StringLength(255)]
        /// <summary>
        /// Descrição do destino
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que filial deve ser informada
        /// </summary>
        public string IND_FILIAL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que operadora deve ser informada
        /// </summary>
        public string IND_OPERADORA { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_CEL_DESTINO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  /*------------------------------------------------------------------------------------------------\n    Objetivo(s)..: Trigger que troca o campo de descrição para upper case\n    Módulo.......: CEL - Celulares\n    Analista.....: Tiago Gabriel\n    Alterações:\n    Data        Desenvolvedor  Alteração\n    31/10/2007  Tiago Gabriel  Criação.\n    ------------------------------------------------------------------------------------------------*/\n  :new.description := Upper( :new.description );\n\nend BEG_TRG_BIU_CEL_DESTINO;\n"}`;
    
    }
}
