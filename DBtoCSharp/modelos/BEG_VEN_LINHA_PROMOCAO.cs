
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_LINHA_PROMOCAO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00043 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_VEN_LIN_PROMOCAO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  VN_DUMMY number;\n\n  cursor VALIDA_DTA_TAB is\n    select *\n      from BEG_VEN_PROMOCAO P2\n     where P2.DT_INICIO > TRUNC(sysdate)\n       and P2.DT_FIM > TRUNC(sysdate)\n       and P2.BEG_VEN_PROMOCAO_ID = :new.BEG_VEN_PROMOCAO_ID;\n\n  -- 15/10/2006 - AOK\n  cursor VALIDA_TAB is\n    select *\n      from BEG_VEN_LINHA_PROMOCAO LP\n     where LP.BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID -- 2507223\n       and LP.BEG_PRD_SKU_ID = :new.BEG_PRD_SKU_ID -- 2007223\n       and LP.BEG_VEN_PROMOCAO_ID in\n           (select P.BEG_VEN_PROMOCAO_ID\n              from BEG_VEN_PROMOCAO P\n             where (TRUNC(sysdate) between P.DT_INICIO and P.DT_FIM));\n\n  RVALIDA_TAB     VALIDA_TAB%rowtype;\n  RVALIDA_DTA_TAB VALIDA_DTA_TAB%rowtype;\n\nbegin\n\n  --  if :new.ISACTIVE = :old.ISACTIVE then\n  if INSERTING then\n    --\n    open VALIDA_DTA_TAB;\n    fetch VALIDA_DTA_TAB\n      into RVALIDA_DTA_TAB;\n    if VALIDA_DTA_TAB%notfound then\n      -- A tabela nao possui data maior que a dta atual\n      open VALIDA_TAB;\n      fetch VALIDA_TAB\n        into RVALIDA_TAB;\n      if VALIDA_TAB%found then\n        RAISE_APPLICATION_ERROR(-20002,\n                                'Produto esta contido em uma lista de promocao ativa - Verifique!!');\n      end if;\n      close VALIDA_TAB;\n    end if;\n    close VALIDA_DTA_TAB;\n  end if;\n\n  -- Valida periodo da lista para permitir alterac?o nos itens\n  select 1\n    into VN_DUMMY\n    from BEG_VEN_PROMOCAO\n   where BEG_VEN_PROMOCAO_ID =\n         NVL(:new.BEG_VEN_PROMOCAO_ID, :old.BEG_VEN_PROMOCAO_ID)\n     and TRUNC(NVL(DT_FIM, sysdate)) < TRUNC(sysdate);\n\n  RAISE_APPLICATION_ERROR(-20001,\n                          'Promoc?o ja finalizada n?o permite alterac?o!');\n\nexception\n  when NO_DATA_FOUND then\n    null;\n  \nend TRG_BIUD_BEG_VEN_LIN_PROMOCAO;\n"}`;
    
    }
}
