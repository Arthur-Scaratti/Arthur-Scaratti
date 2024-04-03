
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_MOTOR_ESPEC
    {

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FRO_MOTOR_ESPEC { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  :new.DESC_ESPECIALIZACAO := UPPER(:new.DESC_ESPECIALIZACAO);\nend BEG_FRO_BIU_MOTOR_ESPEC;\n"}`;
    
    }
}
