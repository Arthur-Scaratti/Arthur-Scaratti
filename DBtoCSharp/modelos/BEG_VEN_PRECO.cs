
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_PRECO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00024 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n\n\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_VEN_PRECO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  VN_DUMMY number;\n\nbegin\n  -- Valida periodo da lista para permitir alterac?o nos itens\n  select 1\n    into VN_DUMMY\n    from BEG_VEN_TABELA_PRECO\n   where BEG_VEN_TABELA_PRECO_ID =\n         NVL(:new.BEG_VEN_TABELA_PRECO_ID, :old.BEG_VEN_TABELA_PRECO_ID)\n     and TRUNC(NVL(DT_FIM, sysdate)) < TRUNC(sysdate);\n\n  RAISE_APPLICATION_ERROR(-20001,\n                          'Tabela de precos ja finalizada n?o permite alterac?o!');\nexception\n  when NO_DATA_FOUND then\n    null;\n  \nend BEG_TRG_BIUD_VEN_PRECO;\n"}`;
    
    }
}
