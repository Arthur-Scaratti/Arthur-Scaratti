
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPR_NECESSIDADE_ORG
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_CPR_NEC_ORG { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  /*---------------------------------------------------------------------------------------\n  Objetivo(s)..: Valida os dados gerados para necessidades de compra.\n  Modulo.......: CPR - Compras\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  24/10/2006  Tiago Gabriel  Criac?o.\n  ---------------------------------------------------------------------------------------*/\n  if INSERTING then\n    if :new.QTD_SUGERIDA <= 0\n       or :new.QTD_EMBALAGEM = 0 then\n      :new.QTD_SOLICITADA := 0;\n    else\n      :new.QTD_SOLICITADA := ROUND(:new.QTD_SUGERIDA / :new.QTD_EMBALAGEM) *\n                             :new.QTD_EMBALAGEM;\n    end if;\n  end if;\n\n  if :new.QTD_SOLICITADA > 0 then\n    :new.ISACTIVE := 'Y';\n  else\n    :new.ISACTIVE := 'N';\n  end if;\n\n  :new.QTD_MEDIA_VENDIDA   := :new.QTD_VENDIDA / :new.NRO_MESES_MEDIA;\n  :new.QTD_MEDIA_FALTANTE  := :new.QTD_FALTANTE / :new.NRO_MESES_MEDIA;\n  :new.QTD_MEDIA_ESTOQUE   := :new.QTD_ESTOQUE / :new.NRO_MESES_MEDIA;\n  :new.QTD_MEDIA_COMPRADA  := :new.QTD_COMPRADA / :new.NRO_MESES_MEDIA;\n  :new.QTD_MEDIA_BLOQUEADA := :new.QTD_BLOQUEADA / :new.NRO_MESES_MEDIA;\n\nend BEG_TRG_BIU_CPR_NEC_ORG;\n"}`;
    
    }
}
