
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PRD_GRUPO
    {
            [Required]
        /// <summary>
        /// Margem padrão dos produtos deste grupo.
        /// </summary>
        public int BEG_VEN_COM_MARGEM_PRODUTO_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do grupo.
        /// </summary>
        public int DIE_PRD_GRUPO_ID { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// Descrição do grupo.
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que grupo permite cadastramento de cores.
        /// </summary>
        public string IND_PERMITE_COR { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que grupo permite cadastramento de voltagens.
        /// </summary>
        public string IND_PERMITE_VOLTAGEM { get; set; }
            [Required]
        /// <summary>
        /// Percentual máximo de desconto na venda.
        /// </summary>
        public int PERC_MAX_DESCONTO_VENDA { get; set; }
            [Required]
        /// <summary>
        /// Número máximo de parcelas na venda.
        /// </summary>
        public int NRO_MAX_PARCELA_VENDA { get; set; }
            [Required]
        /// <summary>
        /// Percentual limite extra do gerente
        /// </summary>
        public int PER_DESC_GERENTE { get; set; }
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
        /// Código do grupo.
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COMISSAO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BU_PRD_GRUPO { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"begin\n  /*---------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que não poermite alteração das flagas de cor e voltagem nos grupos.\n  Modulo.......: PRD - Produto\n  Analista.....: Tiago Gabriel\n  Alterações:\n  Data        Desenvolvedor  Alteração\n  07/08/2007  Tiago Gabriel  Criação.\n  ---------------------------------------------------------------------------------------------------*/\n  Raise_Application_Error( -20001, 'Impossível alterar indicador de voltagem e cor para os grupos!' );\n\nend DIE_TRG_BU_PRD_GRUPO;\n"}`;
    
    }
}
