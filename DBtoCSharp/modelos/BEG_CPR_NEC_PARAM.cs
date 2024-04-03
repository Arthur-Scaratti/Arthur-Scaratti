
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPR_NEC_PARAM
    {

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00020 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n\n\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CPR_NEC_PARAM { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  /*---------------------------------------------------------------------------------------\n  Objetivo(s)..: Valida os parametros informados para gerac?o de necessidades de compras.\n  Modulo.......: CPR - Compras\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  12/10/2006  Tiago Gabriel  Criac?o.\n  ---------------------------------------------------------------------------------------*/\n  VC_MSG_ERRO             varchar2(200);\n  VN_BEG_CPR_COMPRADOR_ID BEG_SUP_FORNECEDOR.BEG_CPR_COMPRADOR_ID%type;\n\nbegin\n  -- Se esta excluindo os parametros, verifica se ja gerou ordens e exclui os filhos\n  if DELETING then\n    delete from BEG_CPR_NEC_PARAM_ORG\n     where BEG_CPR_NEC_PARAM_ID = :old.BEG_CPR_NEC_PARAM_ID;\n  \n    delete from BEG_CPR_NEC_PARAM_INTERV\n     where BEG_CPR_NEC_PARAM_ID = :old.BEG_CPR_NEC_PARAM_ID;\n  \n    delete from BEG_CPR_NECESSIDADE\n     where BEG_CPR_NEC_PARAM_ID = :old.BEG_CPR_NEC_PARAM_ID;\n  \n    goto FIM;\n  \n  end if;\n\n  -- Busca o comprador padr?o\n  if :new.BEG_VW_FORNECEDOR_ID is not null then\n    begin\n      select BEG_CPR_COMPRADOR_ID\n        into VN_BEG_CPR_COMPRADOR_ID\n        from BEG_SUP_FORNECEDOR\n       where AD_ORG_ID =\n             BEG_FNC_SUP_AD_ORG(:new.AD_ORG_ID, :new.BEG_VW_FORNECEDOR_ID)\n         and ISACTIVE = 'Y'\n         and BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID;\n    \n      if VN_BEG_CPR_COMPRADOR_ID is null then\n        VC_MSG_ERRO := 'Comprador deve ser informado!';\n        goto FIM;\n      end if;\n    \n    exception\n      when NO_DATA_FOUND then\n        VC_MSG_ERRO := 'Informac?es de suprimento de fornecedor n?o encontradas para a filial (*)!';\n        goto FIM;\n      \n      when TOO_MANY_ROWS then\n        VC_MSG_ERRO := 'Informac?es de suprimento de fornecedor duplicadas!';\n        goto FIM;\n      \n    end;\n  end if;\n\n  if :new.BEG_CPR_COMPRADOR_ID is null then\n    :new.BEG_CPR_COMPRADOR_ID := VN_BEG_CPR_COMPRADOR_ID;\n  end if;\n\n  if ((NVL(:new.BEG_CPR_COMPRADOR_ID, 0) <>\n     NVL(:old.BEG_CPR_COMPRADOR_ID, 0) or\n     NVL(:new.BEG_VW_FORNECEDOR_ID, 0) <>\n     NVL(:old.BEG_VW_FORNECEDOR_ID, 0)))\n     and\n     BEG_FNC_RETORNA_PARAM_GERAL('Compras',\n                                 null,\n                                 'CONSISTE_COMPRADOR_FORNECEDOR') = 'Y'\n     and :new.BEG_CPR_COMPRADOR_ID <> VN_BEG_CPR_COMPRADOR_ID then\n    VC_MSG_ERRO := 'Comprador deste fornecedor divergente do selecionado! Para inicializar deixar em branco.';\n    goto FIM;\n  \n  end if;\n\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend BEG_TRG_BIUD_CPR_NEC_PARAM;\n"}`;
    
    }
}
