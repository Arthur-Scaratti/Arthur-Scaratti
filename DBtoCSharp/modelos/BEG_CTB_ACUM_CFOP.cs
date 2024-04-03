
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CTB_ACUM_CFOP
    {

        [NotMapped]
        public string Trigger_BEG_TRG_CTB_ACUM_CFOP { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  if :new.AD_ORG_ID = 0 then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar a filial...... Verifique!');\n  end if;\nend BEG_TRG_CTB_ACUM_CFOP;\n"}`;
    
    }
}
