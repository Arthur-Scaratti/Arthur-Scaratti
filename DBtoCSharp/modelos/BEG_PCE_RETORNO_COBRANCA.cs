
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PCE_RETORNO_COBRANCA
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BUD_PCE_RETORNO_COBR { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  --\nbegin\n  if UPDATING then\n    if :old.DOCSTATUS = 'CO' then\n      -- Processo de gerac?o do lote bancario ja esta finalizado\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Processo de retorno do lote bancario ja esta finalizado!');\n    end if;\n  end if;\n  --\n  if DELETING then\n    -- Naum permite a eliminac?o do lote apos completado todas as etapas\n    if :old.DOCSTATUS = 'CO' then\n      RAISE_APPLICATION_ERROR(-20002,\n                              'Este retorno de lote ja foi processado, n?o pode ser eliminado');\n    \n    else\n      -- \n      -- Desmarca os registro que pertencem ao lote que esta sendo eliminado\n      -- \n      delete BEG_PCE_LOG_RETORNO_COBR LRC\n       where LRC.BEG_PCE_RETORNO_COBRANCA_ID =\n             :old.BEG_PCE_RETORNO_COBRANCA_ID;\n      -- \n    end if;\n  end if;\nend BEG_TRG_BUD_PCE_RETORNO_COBR;\n"}`;
    
    }
}
