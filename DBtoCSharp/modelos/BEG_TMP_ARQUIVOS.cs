
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_TMP_ARQUIVOS
    {
            [Required]
        /// <summary>
        /// Sequencia das linhas listadas
        /// </summary>
        public int SEQ { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Linha retornada pelo comando de listagem
        /// </summary>
        public string TEXTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se o arquivo foi importado corretamente
        /// </summary>
        public string ISOK { get; set; }
            [StringLength(200)]
        /// <summary>
        /// Erro ocorrido no processamento
        /// </summary>
        public string ERRO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BI_TMP_ARQUIVOS { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  /*---------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger para inicializar a sequencia das linhas da tabela.\n  Modulo.......: TMP - Temporario\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  17/01/2007  Tiago Gabriel  Criac?o.\n  ---------------------------------------------------------------------------------------------------*/\nbegin\n  if NVL(:new.SEQ, 0) = 0 then\n    select BEG_TMP_ARQUIVOS_SEQ.nextval into :new.SEQ from DUAL;\n  end if;\n\nend BEG_TRG_BI_TMP_ARQUIVOS;\n"}`;
    
    }
}
