
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPR_NECESSIDADE
    {

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00001 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n\n\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CPR_NECESSIDADE { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"begin\n  /*---------------------------------------------------------------------------------------\n  Objetivo(s)..: Valida os dados gerados para necessidades de compra.\n  Modulo.......: CPR - Compras\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  24/10/2006  Tiago Gabriel  Criac?o.\n  ---------------------------------------------------------------------------------------*/\n  -- Se esta excluindo as necessidades, exclui os filhos\n  if DELETING then\n    delete from BEG_CPR_NECESSIDADE_ORG\n     where BEG_CPR_NECESSIDADE_ID = :old.BEG_CPR_NECESSIDADE_ID;\n\n  else\n\n    if INSERTING then\n      if :new.QTD_SUGERIDA_SC <= 0\n         or :new.QTD_EMBALAGEM = 0 then\n        :new.QTD_SOLICITADA_SC := 0;\n      else\n        :new.QTD_SOLICITADA_SC := ROUND(:new.QTD_SUGERIDA_SC /\n                                        :new.QTD_EMBALAGEM) *\n                                  :new.QTD_EMBALAGEM;\n      end if;\n\n      if :new.QTD_SUGERIDA_RS <= 0\n         or :new.QTD_EMBALAGEM = 0 then\n        :new.QTD_SOLICITADA_RS := 0;\n      else\n        :new.QTD_SOLICITADA_RS := ROUND(:new.QTD_SUGERIDA_RS /\n                                        :new.QTD_EMBALAGEM) *\n                                  :new.QTD_EMBALAGEM;\n      end if;\n\n    end if;\n\n    if :new.QTD_SOLICITADA_SC > 0 then\n      :new.ISACTIVE_SC := 'Y';\n    else\n      :new.ISACTIVE_SC := 'N';\n    end if;\n\n    if :new.QTD_SOLICITADA_RS > 0 then\n      :new.ISACTIVE_RS := 'Y';\n    else\n      :new.ISACTIVE_RS := 'N';\n    end if;\n\n    :new.QTD_TOTAL_SUGERIDA := :new.QTD_SUGERIDA_SC + :new.QTD_SUGERIDA_RS;\n\n    :new.QTD_TOTAL_SOLICITADA := :new.QTD_SOLICITADA_SC +\n                                 :new.QTD_SOLICITADA_RS;\n    if :new.QTD_TOTAL_SOLICITADA > 0 then\n      :new.ISACTIVE := 'Y';\n    else\n      :new.ISACTIVE := 'N';\n    end if;\n\n    -- Caso contrario, calcula as medias\n    :new.QTD_MEDIA_VENDIDA   := :new.QTD_TOTAL_VENDIDA /\n                                :new.NRO_MESES_MEDIA;\n    :new.QTD_MEDIA_FALTANTE  := :new.QTD_TOTAL_FALTANTE /\n                                :new.NRO_MESES_MEDIA;\n    :new.QTD_MEDIA_ESTOQUE   := :new.QTD_TOTAL_ESTOQUE /\n                                :new.NRO_MESES_MEDIA;\n    :new.QTD_MEDIA_COMPRADA  := :new.QTD_TOTAL_COMPRADA /\n                                :new.NRO_MESES_MEDIA;\n    :new.QTD_MEDIA_BLOQUEADA := :new.QTD_TOTAL_BLOQUEADA /\n                                :new.NRO_MESES_MEDIA;\n\n  end if;\n\nend BEG_TRG_BIUD_CPR_NECESSIDADE;"}`;
    
    }
}
