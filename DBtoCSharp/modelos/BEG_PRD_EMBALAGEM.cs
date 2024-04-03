
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_EMBALAGEM
    {

        [NotMapped]
        public string Trigger_TRG_AI_BEG_PRD_EMBALAGEM { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  cursor C_PRODUTO is\n    select BEG_PRODUTO_ID\n      from BEG_PRD_FORNECEDOR\n     where BEG_PRD_FORNECEDOR_ID = :new.BEG_PRD_FORNECEDOR_ID\n       and padrao = 'Y';\nbegin\n  if :new.BEG_PRODUTO_ID is null then\n    open C_PRODUTO;\n    fetch C_PRODUTO\n      into :new.BEG_PRODUTO_ID;\n    close C_PRODUTO;\n  end if;\nend TRG_AI_BEG_PRD_EMBALAGEM;\n"}`;
    
    }
}
