
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_PGTO_MANUAL_TITULO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_AU_CPG_PGTO_MANUAL_TIT { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"begin\n  if :new.ISACTIVE = 'Y' then\n    update BEG_CPG_PGTO_MANUAL\n       set VLR_TOTAL = VLR_TOTAL + :new.VLR_TITULO\n     where BEG_CPG_PGTO_MANUAL_ID = :new.BEG_CPG_PGTO_MANUAL_ID;\n  else\n    update BEG_CPG_PGTO_MANUAL\n       set VLR_TOTAL = VLR_TOTAL - :new.VLR_TITULO\n     where BEG_CPG_PGTO_MANUAL_ID = :new.BEG_CPG_PGTO_MANUAL_ID;\n  end if;\nend BEG_TRG_AU_CPG_PGTO_MANUAL_TIT;\n"}`;
    
    }
}
