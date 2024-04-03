
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PCE_LOTE_COB_TIT
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BU_PCE_LOTE_COB_TIT { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  cursor C1(PID number) is\n    select DOCSTATUS\n      from BEG_PCE_LOTE_COBRANCA L\n     where L.BEG_PCE_LOTE_COBRANCA_ID = :new.BEG_PCE_LOTE_COBRANCA_ID;\n  --\n  VPID    number(10);\n  VSTATUS varchar2(2);\n  --\nbegin\n  --\n  -- Verificar se pode ser realizado alteracao de valores\n  --\n  open C1(VPID);\n  fetch C1\n    into VSTATUS;\n  close C1;\n  if NVL(VSTATUS, 'XX') != 'WC' then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'N?o mais e permitido realizar alterac?es');\n  end if;\n  --\n  if :new.ISACTIVE = 'N' then\n    update BEG_PCE_LOTE_COBRANCA LC\n       set LC.VLR_LOTE = LC.VLR_LOTE - :new.VLR_ABERTO\n     where LC.BEG_PCE_LOTE_COBRANCA_ID = :new.BEG_PCE_LOTE_COBRANCA_ID;\n  else\n    update BEG_PCE_LOTE_COBRANCA LC\n       set LC.VLR_LOTE = LC.VLR_LOTE + :new.VLR_ABERTO\n     where LC.BEG_PCE_LOTE_COBRANCA_ID = :new.BEG_PCE_LOTE_COBRANCA_ID;\n  end if;\n  --\nend BEG_TRG_BU_PCE_LOTE_COB_TIT;\n"}`;
    
    }
}
