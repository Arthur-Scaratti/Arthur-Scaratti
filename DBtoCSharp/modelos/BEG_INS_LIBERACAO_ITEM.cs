
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_INS_LIBERACAO_ITEM
    {

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_INS_LIB_ITEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /*-----------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que valida a quantidade a ser liberada no item.\n  Modulo.......: CPR - Compras\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  18/07/2006  Tiago Gabriel  Criac?o.\n  -----------------------------------------------------------------------------------------------------*/\n  VC_MSG_ERRO  varchar2(200);\n  VN_QTD_SALDO BEG_INS_NFE_ITEM.QTD_SALDO%type;\n\nbegin\n  if NVL(:new.QTD_LIBERAR, 0) <= 0 then\n    VC_MSG_ERRO := 'Quantidade a liberar zerada ou negativa!';\n    goto ERRO;\n  end if;\n\n  -- Busca o saldo atualizado da quantidade bloqueada para o item\n  select QTD_SALDO\n    into VN_QTD_SALDO\n    from BEG_INS_NFE_ITEM\n   where BEG_INS_NFE_ITEM_ID = :new.BEG_INS_NFE_ITEM_ID;\n\n  if :new.QTD_LIBERAR > VN_QTD_SALDO then\n    VC_MSG_ERRO := 'Quantidade a liberar maior que o saldo!';\n    goto ERRO;\n  end if;\n\n  goto FIM;\n\n  <<ERRO>>\n  RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n\n  <<FIM>>\n  return;\n\nend TRG_BIU_BEG_INS_LIB_ITEM;\n"}`;
    
    }
}
