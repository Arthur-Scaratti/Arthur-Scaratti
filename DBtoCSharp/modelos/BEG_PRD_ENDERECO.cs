
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_ENDERECO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00030 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n\n\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_BEG_PRD_ENDERECO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  cursor C_SKU_PADRAO is\n    select BEG_PRD_SKU_ID\n      from BEG_PRD_SKU B\n     where B.BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n       and PADRAO = 'Y';\nbegin\n  if :new.BEG_PRD_SKU_ID is null then\n    open C_SKU_PADRAO;\n    fetch C_SKU_PADRAO\n      into :new.BEG_PRD_SKU_ID;\n    close C_SKU_PADRAO;\n  end if;\n\nend;\n"}`;
    
    }
}
