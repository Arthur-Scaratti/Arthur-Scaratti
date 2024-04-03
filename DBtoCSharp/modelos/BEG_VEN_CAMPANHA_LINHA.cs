
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_CAMPANHA_LINHA
    {

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00010 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n\n\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_VEN_CAMPANHA_LINHA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  V_PONTUACAO BEG_VEN_CAMPANHA.TP_PONTUACAO%type;\n\nbegin\n\n  if :new.BEG_PRODUTO_ID is not null\n     and :new.BEG_PRD_COMERCIAL_CLASS_ID is not null then\n    RAISE_APPLICATION_ERROR(-20003,\n                            'Voce deve informar somente o produto ou a classificac?o comercial.');\n  \n  end if;\n\n  select TP_PONTUACAO\n    into V_PONTUACAO\n    from BEG_VEN_CAMPANHA\n   where BEG_VEN_CAMPANHA_ID = :new.BEG_VEN_CAMPANHA_ID;\n\n  if V_PONTUACAO = 'P'\n     and NVL(:new.PONTUACAO, 0) = 0 then\n    RAISE_APPLICATION_ERROR(-20003, 'Voce deve informar a pontuac?o.');\n  end if;\n\n  if :new.BEG_PRD_SKU_ID is null then\n  \n    begin\n      select BEG_PRD_SKU_ID\n        into :new.BEG_PRD_SKU_ID\n        from BEG_PRD_SKU\n       where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n         and PADRAO = 'Y';\n    \n    exception\n      when NO_DATA_FOUND then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'SKU n?o informado e padr?o n?o encontrado!');\n      when TOO_MANY_ROWS then\n        RAISE_APPLICATION_ERROR(-20002, 'SKU duplicado.');\n    end;\n  end if;\n\n  --Desativando campanha para validacao\n  update BEG_VEN_CAMPANHA\n     set ISACTIVE = 'N'\n   where BEG_VEN_CAMPANHA_ID = :new.BEG_VEN_CAMPANHA_ID;\n\n  --Limpando colunas nao utilizadas\n  if :new.TP_CALCULO = 'Q' then\n    :new.QTD_INICIAL := null;\n    :new.QTD_FINAL   := null;\n    :new.VALOR       := null;\n    :new.VLR_INICIAL := null;\n    :new.VLR_FINAL   := null;\n  end if;\n\n  if :new.TP_CALCULO = 'V' then\n    :new.QTD_INICIAL := null;\n    :new.QTD_FINAL   := null;\n    :new.QUANTIDADE  := null;\n    :new.VLR_INICIAL := null;\n    :new.VLR_FINAL   := null;\n  end if;\n\n  if :new.TP_CALCULO = 'FV' then\n    :new.QTD_INICIAL := null;\n    :new.QTD_FINAL   := null;\n    :new.VALOR       := null;\n    :new.QUANTIDADE  := null;\n  end if;\n\n  if :new.TP_CALCULO = 'FQ' then\n    :new.VALOR       := null;\n    :new.QUANTIDADE  := null;\n    :new.VLR_INICIAL := null;\n    :new.VLR_FINAL   := null;\n  end if;\n\n  --Validando tipo de calculo\n  if :new.TP_CALCULO = 'Q'\n     and NVL(:new.QUANTIDADE, 0) = 0 then\n    RAISE_APPLICATION_ERROR(-20001, 'Quantidade deve ser informada !');\n  end if;\n\n  if :new.TP_CALCULO = 'V'\n     and NVL(:new.VALOR, 0) = 0 then\n    RAISE_APPLICATION_ERROR(-20001, 'Valor deve ser informado !');\n  end if;\n\n  if :new.TP_CALCULO = 'FQ'\n     and (:new.QTD_INICIAL is null or NVL(:new.QTD_FINAL, 0) = 0) then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Faixa da Quantidade deve ser informada !');\n  end if;\n\n  if :new.TP_CALCULO = 'FV'\n     and (:new.VLR_INICIAL is null or NVL(:new.VLR_FINAL, 0) = 0) then\n    RAISE_APPLICATION_ERROR(-20001, 'Faixa de Valor deve ser informada !');\n  end if;\n\nend BEG_TRG_BIU_VEN_CAMPANHA_LINHA;\n"}`;
    
    }
}
