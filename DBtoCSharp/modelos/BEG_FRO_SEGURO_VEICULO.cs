
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_SEGURO_VEICULO
    {

        [NotMapped]
        public string Trigger_TRG_AIUD_BEG_FRO_SEG_VEIC { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\nbegin\n  if INSERTING then\n    update BEG_FRO_SEGURO S\n       set S.VL_SEGURO = NVL(S.VL_SEGURO, 0) + :new.VL_SEGURO\n     where S.BEG_FRO_SEGURO_ID = :new.BEG_FRO_SEGURO_ID;\n  end if;\n  --\n  if UPDATING then\n    update BEG_FRO_SEGURO BFS\n       set BFS.VL_SEGURO = NVL(BFS.VL_SEGURO, 0) - :old.VL_SEGURO +\n                           :new.VL_SEGURO\n     where BFS.BEG_FRO_SEGURO_ID = :new.BEG_FRO_SEGURO_ID;\n  end if;\n  --\n  if DELETING then\n    update BEG_FRO_SEGURO BFS\n       set BFS.VL_SEGURO = NVL(BFS.VL_SEGURO, 0) - :old.VL_SEGURO\n     where BFS.BEG_FRO_SEGURO_ID = :old.BEG_FRO_SEGURO_ID\n       and BFS.VL_SEGURO >= :old.VL_SEGURO;\n  end if;\n  --\nend TRG_AIUD_BEG_FRO_SEG_VEIC;\n"}`;
    
    }
}
