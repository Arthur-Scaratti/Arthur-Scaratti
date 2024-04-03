
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_DESP_VIAGEM
    {

        [NotMapped]
        public string Trigger_TRG_AIUD_BEG_FRO_DESP_VIAGEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\nbegin\n  --\n  if INSERTING then\n    if :new.BEG_FRO_VIAGEM_ID is not null then\n      update BEG_FRO_VIAGEM V\n         set V.VLR_DESPESAS = V.VLR_DESPESAS + :new.TOT_DESPESA,\n             V.VLR_ACERTO   = V.VLR_ANTECIPADO - :new.TOT_DESPESA\n       where V.BEG_FRO_VIAGEM_ID = :new.BEG_FRO_VIAGEM_ID;\n    else\n      update BEG_FRO_VIAGEM V\n         set V.VLR_DESPESAS = V.VLR_DESPESAS - :old.TOT_DESPESA +\n                              :new.TOT_DESPESA,\n             V.VLR_ACERTO   = V.VLR_ACERTO + :old.TOT_DESPESA -\n                              :new.TOT_DESPESA\n       where V.BEG_FRO_VIAGEM_ID = :new.BEG_FRO_VIAGEM_ID;\n    end if;\n  end if;\n  --\n  if DELETING then\n    update BEG_FRO_VIAGEM V\n       set V.VLR_DESPESAS = V.VLR_DESPESAS - :old.TOT_DESPESA,\n           V.VLR_ACERTO   = V.VLR_ACERTO + :old.TOT_DESPESA\n     where V.BEG_FRO_VIAGEM_ID = :old.BEG_FRO_VIAGEM_ID;\n  end if;\n  --\n  -- FIM\n  --\nend TRG_AIUD_BEG_FRO_DESP_VIAGEM;\n"}`;
    
    }
}
