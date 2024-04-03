
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_REDISTRIBUICAO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BUD_FIN_REDISTRIBUICAO { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  --\nbegin\n  if UPDATING then\n    if :old.DOCSTATUS = 'CO' then\n      -- Completed\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Procedimento de redistribuicao concluido, n?o permite alterac?o');\n    \n    end if;\n  end if;\n  if DELETING then\n    -- Naum permite a eliminac?o do lote apos completado todas as etapas\n    if :old.DOCSTATUS = 'AP' then\n      RAISE_APPLICATION_ERROR(-20002,\n                              'Este procedimento de redistribuicao de titulos n?o pode ser eliminado');\n    \n    end if;\n    --\n    -- Enquanto estiver aguardando por confirmacao os registros poderao ser eliminados\n    --\n    if :old.DOCSTATUS = 'WC' then\n      delete BEG_FIN_REDIST_TITULO RT\n       where RT.BEG_FIN_REDISTRIBUICAO_ID = :old.BEG_FIN_REDISTRIBUICAO_ID;\n    end if;\n  end if;\nend BEG_TRG_BUD_FIN_REDISTRIBUICAO;\n"}`;
    
    }
}
