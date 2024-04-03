
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CHQ_REMESSA_CHEQUE
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CHQ_REM_CHQ { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"BEGIN\n  IF inserting THEN\n  UPDATE BEG_CHQ_REMESSA a\n    SET  A.total_remessa = nvl(A.total_remessa,0) + :NEW.valor,\n         A.total_cheques = nvl(A.total_cheques,0) + :NEW.valor,\n         A.nro_cheques = nvl(A.nro_cheques,0) + 1\n  WHERE  BEG_CHQ_REMESSA_ID       = :new.beg_chq_remessa_id;\n\n  elsif updating THEN \n  UPDATE BEG_CHQ_REMESSA a\n    SET  A.total_remessa = nvl(A.total_remessa,0) + :NEW.valor - :OLD.valor,\n         A.total_cheques = nvl(A.total_cheques,0) + :NEW.valor - :old.valor\n  WHERE  BEG_CHQ_REMESSA_ID       = :NEW.beg_chq_remessa_id;\n  ELSE\n  UPDATE BEG_CHQ_REMESSA A\n    SET  A.total_remessa = nvl(A.total_remessa,0) - :OLD.valor,\n         A.total_cheques = nvl(A.total_cheques,0) - :old.valor,\n         A.nro_cheques = nvl(A.nro_cheques,0) - 1\n  WHERE  BEG_CHQ_REMESSA_ID       = :old.beg_chq_remessa_id;\n  end if;\nEND;\n"}`;
    
    }
}
