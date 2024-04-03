
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_TMP_PASTAS
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BI_TMP_PASTAS { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  /*---------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger para inicializar a sequencia das linhas da tabela.\n  Modulo.......: TMP - Temporario\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  30/01/2007  Tiago Gabriel  Criac?o.\n  ---------------------------------------------------------------------------------------------------*/\nbegin\n  if NVL(:new.SEQ, 0) = 0 then\n    select BEG_TMP_PASTAS_SEQ.nextval into :new.SEQ from DUAL;\n  end if;\n\nend BEG_TRG_BI_TMP_PASTAS;\n"}`;
    
    }
}
