
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_REDIST_TITULO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BU_FIN_REDIST_TITULO { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  cursor C1(PID number) is\n    select DOCSTATUS\n      from BEG_FIN_REDISTRIBUICAO R\n     where R.BEG_FIN_REDISTRIBUICAO_ID = :new.BEG_FIN_REDISTRIBUICAO_ID;\n  --\n  VPID    number(10);\n  VSTATUS varchar2(2);\n  --\nbegin\n  --\n  -- Verificar se pode ser realizado alteracao de valores\n  --\n  open C1(VPID);\n  fetch C1\n    into VSTATUS;\n  close C1;\n  if NVL(VSTATUS, 'XX') != 'WC' then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'N?o mais e permitido realizar alterac?es');\n  end if;\n  --\n  if :new.ISACTIVE = 'N' then\n    update BEG_FIN_REDISTRIBUICAO R\n       set R.VLR_REDISTRIBUICAO = R.VLR_REDISTRIBUICAO - :new.VLR_ABERTO\n     where R.BEG_FIN_REDISTRIBUICAO_ID = :new.BEG_FIN_REDISTRIBUICAO_ID;\n  else\n    update BEG_FIN_REDISTRIBUICAO R\n       set R.VLR_REDISTRIBUICAO = R.VLR_REDISTRIBUICAO + :new.VLR_ABERTO\n     where R.BEG_FIN_REDISTRIBUICAO_ID = :new.BEG_FIN_REDISTRIBUICAO_ID;\n  end if;\n  --\nend BEG_TRG_BU_FIN_REDIST_TITULO;\n"}`;
    
    }
}
