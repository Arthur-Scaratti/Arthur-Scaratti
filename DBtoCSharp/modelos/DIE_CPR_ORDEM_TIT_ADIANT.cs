
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CPR_ORDEM_TIT_ADIANT
    {

        [NotMapped]
        public string Trigger_DIE_TRG_AI_ORDEM_TIT_ADIANT { get; set; } = `{"triggering_event":"INSERT OR DELETE","trigger_body":"DECLARE\n\nBEGIN\n\n  if inserting then\n\n    update beg_cpr_ordem o\n       set o.vlr_pago   = o.vlr_pago + :new.vlr_pago_ordem,\n           o.vlr_aberto = o.vlr_aberto - :new.vlr_pago_ordem\n     where o.beg_cpr_ordem_id = :new.beg_cpr_ordem_id;\n\n  end if;\n  if deleting then\n\n    update beg_cpr_ordem o\n       set o.vlr_pago   = o.vlr_pago - :old.vlr_pago_ordem,\n           o.vlr_aberto = o.vlr_aberto + :old.vlr_pago_ordem\n     where o.beg_cpr_ordem_id = :old.beg_cpr_ordem_id;\n\n  end if;\n\nEND;\n"}`;
    
    }
}
