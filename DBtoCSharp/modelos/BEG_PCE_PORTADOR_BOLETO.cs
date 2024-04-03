
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PCE_PORTADOR_BOLETO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_AIUD_FIN_PORT_BOL { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\nbegin\n  if INSERTING then\n    update BEG_FIN_PORTADOR\n       set IND_BOLETO = 'Y'\n     where BEG_FIN_PORTADOR_ID = :new.BEG_FIN_PORTADOR_ID;\n  end if;\n  --\n  if DELETING then\n    update BEG_FIN_PORTADOR\n       set IND_BOLETO = 'N'\n     where BEG_FIN_PORTADOR_ID = :old.BEG_FIN_PORTADOR_ID;\n  end if;\n  --\n  if UPDATING then\n    if :new.ISACTIVE != :old.ISACTIVE then\n      update BEG_FIN_PORTADOR\n         set IND_BOLETO = :new.ISACTIVE\n       where BEG_FIN_PORTADOR_ID = :new.BEG_FIN_PORTADOR_ID;\n    end if;\n  end if;\nend BEG_TRG_AIUD_FIN_PORT_BOL;\n"}`;
    
    }
}
