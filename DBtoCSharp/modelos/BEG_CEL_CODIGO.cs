
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CEL_CODIGO
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do vínculo de código de celulares
        /// </summary>
        public int BEG_CEL_CODIGO_ID { get; set; }
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
        /// Código do celular para o fabricante
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Quantidade disponível de seriais para movimentação no status IP e VO
        /// </summary>
        public int QTD_DISPONIVEL { get; set; }
            [Required]
    [StringLength(255)]
        /// <summary>
        /// Descrição do celular para o fabricante
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// ID do produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do SKU
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do layout
        /// </summary>
        public int BEG_CEL_LAYOUT_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_CEL_CODIGO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  /*------------------------------------------------------------------------------------------------\n    Objetivo(s)..: Trigger que troca o campo de descrição para upper case\n    Módulo.......: CEL - Celulares\n    Analista.....: Tiago Gabriel\n    Alterações:\n    Data        Desenvolvedor  Alteração\n    31/10/2007  Tiago Gabriel  Criação.\n    ------------------------------------------------------------------------------------------------*/\n  :new.description := Upper( :new.description );\n\nend BEG_TRG_BIU_CEL_CODIGO;\n"}`;
    
    }
}
