
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_TIPO_TRANSP
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_TP_TRANSP { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\nbegin\n--\n  :NEW.NAME := UPPER(:NEW.NAME);\n--\nend BEG_TRG_BIU_TP_TRANSP;\n"}`;
    
    }
}
