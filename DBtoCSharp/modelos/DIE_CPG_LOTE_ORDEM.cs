
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CPG_LOTE_ORDEM
    {

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_CPG_LOTE_ORDEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n\nBEGIN\n\n  IF :NEW.VLR_APAGAR > :NEW.VLR_TOTAL_ORDEM THEN\n\n     RAISE_APPLICATION_ERROR(-20501,\n                                    'Valor informado a pagar maior que valor em aberto da OC!');\n\n  END IF;\n\n\nEND;\n"}`;
    
    }
}
