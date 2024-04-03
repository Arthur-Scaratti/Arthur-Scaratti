
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_AUTORIZACAO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00042 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n\n\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_AIU_VEN_AUTORIZACAO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n\n  BEG_PCK_VEN_COMISSOES.V_VEN_AUTORIZACAO := 'Y';\n\n  update BEG_VEN_LINHA_PEDIDO A\n     set A.VLR_UNIT_SUGERIDO = :new.VLR_UNIT_AUTORIZADO\n   where A.BEG_VEN_PEDIDO_ID = :new.BEG_VEN_PEDIDO_ID\n     and A.BEG_VW_PRD_PRECO_ID = :new.BEG_PRODUTO_ID\n     and A.BEG_PRD_SKU_ID = :new.BEG_PRD_SKU_ID;\n\n  BEG_PCK_VEN_COMISSOES.V_VEN_AUTORIZACAO := 'N';\n\nend BEG_TRG_BIU_VEN_AUTORIZACAO;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_VEN_AUTORIZACAO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  cursor C_PEDIDO is\n    select DOCSTATUS\n      from BEG_VEN_PEDIDO       P,\n           BEG_VEN_LINHA_PEDIDO L\n     where P.BEG_VEN_PEDIDO_ID = :new.BEG_VEN_PEDIDO_ID\n       and P.BEG_VEN_PEDIDO_ID = L.BEG_VEN_PEDIDO_ID\n       and L.BEG_VW_PRD_PRECO_ID = :new.BEG_PRODUTO_ID\n       and L.BEG_PRD_SKU_ID = :new.BEG_PRD_SKU_ID;\n  --\n  R_PEDIDO C_PEDIDO%rowtype;\n\nbegin\n  if :new.DATA is null then\n    :new.DATA := sysdate;\n  end if;\n\n  if :new.BEG_PRD_SKU_ID is null then\n  \n    begin\n      select BEG_PRD_SKU_ID\n        into :new.BEG_PRD_SKU_ID\n        from BEG_PRD_SKU\n       where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n         and PADRAO = 'Y';\n    \n    exception\n      when NO_DATA_FOUND then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'SKU n?o informado e padr?o n?o encontrado!');\n      when TOO_MANY_ROWS then\n        RAISE_APPLICATION_ERROR(-20002, 'SKU duplicado.');\n    end;\n  end if;\n\n  open C_PEDIDO;\n  fetch C_PEDIDO\n    into R_PEDIDO;\n\n  if C_PEDIDO%notfound\n     and :new.BEG_VEN_PEDIDO_ID is not null then\n    close C_PEDIDO;\n    RAISE_APPLICATION_ERROR(-20001, 'Pedido n?o possui este item e SKU !');\n  end if;\n  close C_PEDIDO;\n\n  /* Tiago Gabriel em 01/12/2006\n     Passou a validar somente pedidos completos e cancelados.  \n  if R_PEDIDO.DOCSTATUS <> 'IP' then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Pedido ja aprovado n?o pode sofrer alterac?o de preco !');\n  end if;\n  */\n\n  if R_PEDIDO.DOCSTATUS = 'CO' then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Pedido completo n?o pode sofrer alterac?o de preco !');\n  elsif R_PEDIDO.DOCSTATUS = 'CA' then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Pedido cancelado n?o pode sofrer alterac?o de preco !');\n  \n  end if;\n\nend BEG_TRG_BIU_VEN_AUTORIZACAO;\n"}`;
    
    }
}
