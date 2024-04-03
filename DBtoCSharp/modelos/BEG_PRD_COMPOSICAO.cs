
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_COMPOSICAO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00041 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n\n\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIU_BEG_PRD_COMPOSICAO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /*---------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que valida campos da composic?o.\n  Modulo.......: PRD - Produtos\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  01/09/2006  Tiago Gabriel  Criac?o.\n  ---------------------------------------------------------------------------------------------------*/\n  VN_DUMMY        number;\n\nbegin\n  -- Se n?o informou o produto\n  if :new.BEG_PRODUTO_ID is null then\n  \n    -- Limpa o SKU\n    :new.BEG_PRD_SKU_ID := null;\n  \n    -- Deve ter informado a operac?o\n    if :new.BEG_PRD_OPERACAO_ID is null then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Deve ser informado um insumo ou uma operac?o!');\n    end if;\n  \n  else\n    -- Caso contrario, \n  \n    -- Busca o SKU padr?o\n    if :new.BEG_PRD_SKU_ID is null then\n      select NVL(:new.BEG_PRD_SKU_ID, BEG_PRD_SKU_ID)\n        into :new.BEG_PRD_SKU_ID\n        from BEG_PRD_SKU\n       where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n         and PADRAO = 'Y';\n    end if;\n  \n    -- Verifica se o produto informado e um insumo\n    select count(1)\n      into VN_DUMMY\n      from BEG_PRD_SKU\n     where IND_INSUMO = 'Y'\n       and BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n       and BEG_PRD_SKU_ID = :new.BEG_PRD_SKU_ID;\n  \n    if VN_DUMMY = 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Produto informado deve ser estar marcado como insumo!');\n    end if;\n  \n    -- N?o pode ter informado a operac?o\n    if :new.BEG_PRD_OPERACAO_ID is not null then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Informar somente insumo ou operac?o!');\n    end if;\n  \n  end if;\n\nend TRG_BIU_BEG_PRD_COMPOSICAO;\n"}`;
    
    }
}
