
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_TABELA_PRECO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_VEN_TABELA_PRECO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  pragma autonomous_transaction;\n  VN_DUMMY number;\n\nbegin\n  if TRUNC(NVL(:new.DT_FIM, sysdate)) < TRUNC(sysdate) then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Tabela de precos ja finalizada n?o permite alterac?o!');\n  end if;\n\n  if :new.DT_INICIO is null then\n    RAISE_APPLICATION_ERROR(-20001, 'Data de inicio deve ser informada!');\n  end if;\n\n  -- Verifica intervalo\n  if :new.DT_INICIO > NVL(:new.DT_FIM, :new.DT_INICIO) then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Data de inicio deve ser menor que data de fim ou esta deve estar em branco!');\n  end if;\n\n  -- Verifica se existem listas abertas\n  select count(1)\n    into VN_DUMMY\n    from BEG_VEN_TABELA_PRECO\n   where (:new.DT_INICIO between TRUNC(DT_INICIO) and\n         NVL(TRUNC(DT_FIM), :new.DT_INICIO) or\n         (TRUNC(DT_INICIO) > :new.DT_INICIO and\n         NVL(:new.DT_FIM, TRUNC(NVL(DT_FIM, sysdate))) >=\n         TRUNC(NVL(DT_FIM, sysdate)))\n         /*  or NVL(:new.DT_FIM, TRUNC(NVL(DT_FIM, sysdate))) >= TRUNC(DT_INICIO) */ -- aok -- 09/10/2006\n         )\n     and BEG_VEN_TABELA_PRECO_ID <> NVL(:new.BEG_VEN_TABELA_PRECO_ID, 0);\n  --\n  if VN_DUMMY > 0 then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Ja existem listas vigentes para o periodo informado!');\n  end if;\n\nend BEG_TRG_BIU_VEN_TABELA_PRECO;\n"}`;
    
    }
}
