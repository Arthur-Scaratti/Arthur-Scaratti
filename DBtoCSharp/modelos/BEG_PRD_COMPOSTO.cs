
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_COMPOSTO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00004 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n\n\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_PRD_COMPOSTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"begin\n  /*---------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger para delec?o da composic?o.\n  Modulo.......: PRD - Produtos\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  01/09/2006  Tiago Gabriel  Criac?o.\n  ---------------------------------------------------------------------------------------------------*/\n  if DELETING then\n    delete from BEG_PRD_COMPOSICAO\n     where BEG_PRD_COMPOSTO_ID = :old.BEG_PRD_COMPOSTO_ID;\n  else\n    select value,\n           name\n      into :new.value,\n           :new.name\n      from BEG_PRODUTO\n     where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n  end if;\n\nend TRG_BIUD_BEG_PRD_COMPOSTO;\n"}`;
    
    }
}
