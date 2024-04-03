
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_FLU_CONTA
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_FIN_FLUXO_CONTA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\n  OMENSAGEM varchar2(250);\n  --\n  VC_MASCARA BEG_PARAMETRO_SISTEMA.CARACTER%type;\n\nbegin\n  -- Busca a mascara dos parametros\n  VC_MASCARA := BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n                                          :new.AD_ORG_ID,\n                                          'Geral',\n                                          null,\n                                          'FLUXO_CONTA');\n\n  if VC_MASCARA is null then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Mascara n?o parametrizada para o fluxo de conta!');\n  end if;\n\n  --\n  -- Procedure para validac?o - ver beg_parametro_sistema.\n  --\n  /*\n  OMENSAGEM := null;\n  BEG_VALIDA_CONTAS(:new.AD_CLIENT_ID, -- PADCLIENT\n                    :new.AD_ORG_ID, -- PADORG\n                    :new.value,\n                    'FLUXO_CONTA',\n                    :new.TP_CONTA,\n                    :new.NIVEL_CONTA,\n                    OMENSAGEM);*/\n\n  -- Altera a chamada da procedure\n  BEG_VALIDA_CONTAS(:new.value,\n                    VC_MASCARA,\n                    :new.TP_CONTA,\n                    :new.NIVEL_CONTA,\n                    OMENSAGEM);\n\n  --\n  if OMENSAGEM is not null then\n    RAISE_APPLICATION_ERROR(-20001, OMENSAGEM);\n  end if;\n  --\nend BEG_TRG_BIU_FIN_FLUXO_CONTA;\n"}`;
    
    }
}
