
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CEL_ATRIBUTO
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do atributo para telefonia.
        /// </summary>
        public int BEG_CEL_ATRIBUTO_ID { get; set; }
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
        /// Código do atributo.
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// Nome do atributo.
        /// </summary>
        public string NAME { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_CEL_ATRIBUTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  /*------------------------------------------------------------------------------------------------\n    Objetivo(s)..: Trigger que troca o campo de descrição para upper case\n    Módulo.......: CEL - Celulares\n    Analista.....: Tiago Gabriel\n    Alterações:\n    Data        Desenvolvedor  Alteração\n    31/10/2007  Tiago Gabriel  Criação.\n    ------------------------------------------------------------------------------------------------*/\n  :new.name := Upper( :new.name );\n\nend BEG_TRG_BIU_CEL_ATRIBUTO;\n"}`;
    
    }
}
