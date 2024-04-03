
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CHQ_INCOBRAVEIS
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BIUR_CHQ_INC { get; set; } = `{"triggering_event":"INSERT OR DELETE","trigger_body":"BEGIN\n  IF INSERTING THEN\n    INSERT INTO BEG_CHQ_HISTORICO\n    (\n      BEG_CHQ_HISTORICO_ID,\n      AD_CLIENT_ID,\n      AD_ORG_ID,\n      ISACTIVE,\n      CREATED,\n      CREATEDBY,\n      UPDATED,\n      UPDATEDBY,\n      DATA,\n      DESCRICAO,\n      BEG_CHQ_CHEQUE_ID,\n      BEG_FIN_CAIXA_ID,\n      BEG_FIN_CONTA_CORRENTE_ID,\n      DT_EMI_ENT,\n      DT_SAI_COMP\n    )\n    VALUES\n    (\n      beg_fnc_ad_sequence('BEG_CHQ_HISTORICO'),\n      :NEW.AD_CLIENT_ID,\n      :NEW.AD_ORG_ID,\n      'Y',\n      :NEW.CREATED,\n      :NEW.CREATEDBY,\n      :NEW.UPDATED,\n      :NEW.UPDATEDBY,\n      TRUNC(SYSDATE),\n      'INCOBRAVEL ',\n      :NEW.BEG_CHQ_CHEQUE_ID,\n      NULL,\n      NULL,\n      NULL,\n      NULL\n    );\n    ELSE\n  INSERT INTO BEG_CHQ_HISTORICO\n    (\n      BEG_CHQ_HISTORICO_ID,\n      AD_CLIENT_ID,\n      AD_ORG_ID,\n      ISACTIVE,\n      CREATED,\n      CREATEDBY,\n      UPDATED,\n      UPDATEDBY,\n      DATA,\n      DESCRICAO,\n      BEG_CHQ_CHEQUE_ID,\n      BEG_FIN_CAIXA_ID,\n      BEG_FIN_CONTA_CORRENTE_ID,\n      DT_EMI_ENT,\n      DT_SAI_COMP\n    )\n    VALUES\n    (\n      beg_fnc_ad_sequence('BEG_CHQ_HISTORICO'),\n      :NEW.AD_CLIENT_ID,\n      :NEW.AD_ORG_ID,\n      'Y',\n      :NEW.CREATED,\n      :NEW.CREATEDBY,\n      :NEW.UPDATED,\n      :NEW.UPDATEDBY,\n      TRUNC(SYSDATE),\n      'COBRAVEL ',\n      :NEW.BEG_CHQ_CHEQUE_ID,\n      NULL,\n      NULL,\n      NULL,\n      NULL\n    );\n    END IF;\nEND;\n"}`;
    
    }
}
