
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_COTACAO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_COTACAO { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  -- local variables here\n  cursor Busca_Tipo is\n    select t.Reserva  Atual,\n           T1.Reserva Anterior\n    from   Beg_Ven_Tipo_Pedido t,\n           Beg_Ven_Tipo_Pedido T1\n    where  t.Beg_Ven_Tipo_Pedido_Id = :new.Beg_Ven_Tipo_Pedido_Id\n    and    T1.Beg_Ven_Tipo_Pedido_Id = :old.Beg_Ven_Tipo_Pedido_Id;\n  --\n  Vreg1 Busca_Tipo%rowtype;\n  --\nbegin\n  if :new.Beg_Ven_Tipo_Pedido_Id <> :old.Beg_Ven_Tipo_Pedido_Id then\n    open Busca_Tipo;\n    fetch Busca_Tipo\n      into Vreg1;\n    close Busca_Tipo;\n    if Vreg1.Atual <> Vreg1.Anterior then\n      Beg_Prc_Acerta_Res_Cotacao(:new.Ad_Org_Id,\n                                 :new.Ad_Client_Id,\n                                 :new.value,\n                                 :new.Beg_Ven_Cotacao_Id,\n                                 Vreg1.Atual);\n    end if;\n  end if;\nend Beg_Trg_Cotacao;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BUR_COTACAO_TRANSF { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  if :old.DOCSTATUS = 'CL' then\n    RAISE_APPLICATION_ERROR(-20501, 'Pedido ja convertido. ');\n  end if;\n  if :new.DOCSTATUS = 'CO'\n     and :new.BEG_VEN_TIPO_PEDIDO_ID =\n     BEG_FNC_RETORNA_PARAM_GERAL('Pedidos', null, 'TIPO_PEDIDO_VENDA') then\n    if :new.TP_FRETE = 'C' then\n      :new.VLR_FRETE := 0;\n    end if;\n    if :new.RETIRA = 'Y' then\n      :new.BEG_FRO_ROTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Vendas',\n                                                          'Faturamento',\n                                                          'ROTA_RETIRA');\n    end if;\n    BEG_PRC_CONVERTE_COTACAO(:new.BEG_VEN_COTACAO_ID);\n    :new.DOCSTATUS := 'CL';\n  end if;\nend BEG_TRG_BUR_COTACAO_TRANSF;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_APEX_002 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  V_RESULT boolean;\n  cursor BUSCA_TAB_VENDA is\n    select *\n      from BEG_VEN_TABELA_PRECO T\n     where TO_DATE(sysdate, 'RRRR-MM-DD HH24:MI:SS') between T.DT_INICIO and\n           NVL(T.DT_FIM, TO_DATE(sysdate, 'RRRR-MM-DD HH24:MI:SS'));\n  --\n  VTAB_VENDA BUSCA_TAB_VENDA%rowtype;\n  --\\\n  cursor busca_vendedor is\n    select *\n    from   beg_apex_user a\n    where  a.value = :new.app_user;\n  --\n  vvendedor     busca_vendedor%rowtype;\n  --\nbegin\n    open busca_vendedor;\n    fetch busca_vendedor into vvendedor;\n    close busca_vendedor;\n    :new.beg_apex_user_id := vvendedor.beg_apex_user_id;\n  if INSERTING then\n    if :new.BEG_VEN_COTACAO_ID is null then\n      :new.BEG_VEN_COTACAO_ID := BEG_FNC_AD_SEQUENCE('BEG_VEN_COTACAO');\n    end if;\n    :new.ISACTIVE           := 'Y';\n    V_RESULT := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TABLE(P_APP_USER     => :new.APP_USER,\n                                                         P_AD_CLIENT_ID => :new.AD_CLIENT_ID,\n                                                         P_AD_ORG_ID    => :new.AD_ORG_ID,\n                                                         P_CREATED      => :new.CREATED,\n                                                         P_CREATEDBY    => :new.CREATEDBY,\n                                                         P_UPDATED      => :new.UPDATED,\n                                                         P_UPDATEDBY    => :new.UPDATEDBY);\n    --\n    open BUSCA_TAB_VENDA;\n    fetch BUSCA_TAB_VENDA\n      into VTAB_VENDA;\n    if BUSCA_TAB_VENDA%notfound then\n      RAISE_APPLICATION_ERROR(-20532,\n                              'Nao existe tabela de preco ativa para este dia');\n    end if;\n    close BUSCA_TAB_VENDA;\n    :new.BEG_VEN_TABELA_PRECO_ID := VTAB_VENDA.BEG_VEN_TABELA_PRECO_ID;\n    --\n  end if;\n\n  /*BEG_PCK_TELEVENDA.PRC_GRAVA_COMPRADOR(:new.BEG_VW_CLIENTE_ID,\n  :new.NOME_COMPRADOR,\n  :new.BEG_VW_CLIENTE_COMPRADOR_ID,\n  :new.EMAIL,\n  :new.RAMAL);*/\n\nend TRG_APEX_002;\n"}`;
    
    }
}
