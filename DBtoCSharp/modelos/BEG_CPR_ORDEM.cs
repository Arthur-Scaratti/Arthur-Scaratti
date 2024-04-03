
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPR_ORDEM
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ROLE_ID { get; set; }
        
        /// <summary>
        /// Data prevista de faturamento pelo fornecedor
        /// </summary>
        public string DT_FATURAMENTO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID da ordem de cmpra
        /// </summary>
        public int BEG_CPR_ORDEM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Codigo da ordem de compra
        /// </summary>
        public int VALUE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Codigo da ordem de compra no fornecedor
        /// </summary>
        public string COD_ORDEM_FORN { get; set; }
            [Required]
        /// <summary>
        /// Data de emiss?o da ordem de compra
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// Data da aprovac?o da ordem de compra
        /// </summary>
        public string DT_APROVACAO { get; set; }
            [Required]
        /// <summary>
        /// Valor bruto total da ordem de compra
        /// </summary>
        public int VLR_TOTAL_PRODUTOS { get; set; }
            [Required]
        /// <summary>
        /// Valor liquido total da ordem de compra
        /// </summary>
        public int VLR_TOTAL_ORDEM { get; set; }
            [Required]
        /// <summary>
        /// Valor liquido total do IPI da ordem de compra
        /// </summary>
        public int VLR_IPI { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto / abatimento da ordem de compra
        /// </summary>
        public int PER_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// Valor total do desconto / abatimento da ordem de compra
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// Percentual de acrescimo da ordem de compra
        /// </summary>
        public int PER_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// Valor total do acrescimo da ordem de compra
        /// </summary>
        public int VLR_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// Percentual de frete da ordem de compra
        /// </summary>
        public int PER_FRETE { get; set; }
            [Required]
        /// <summary>
        /// Valor total do frete da ordem de compra
        /// </summary>
        public int VLR_FRETE { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Tipo do frete da ordem de compra: C - CIF / F - FOB / R - Retira / A - A Combinar
        /// </summary>
        public string TP_FRETE { get; set; }
            [Required]
        /// <summary>
        /// Valor total do frete de redespacho da ordem de compra
        /// </summary>
        public int VLR_FRETE_RDP { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Tipo do frete de redespacho da ordem de compra: C - CIF / F - FOB / R - Retira / L - Livre
        /// </summary>
        public string TP_FRETE_RDP { get; set; }
            [Required]
        /// <summary>
        /// Percentual de despesas financeiras da ordem de compra
        /// </summary>
        public int PER_DESPESAS_FINANCEIRAS { get; set; }
            [Required]
        /// <summary>
        /// Valor total das despesas financeiras da ordem de compra
        /// </summary>
        public int VLR_DESPESAS_FINANCEIRAS { get; set; }
            [Required]
        /// <summary>
        /// Percentual de outras despesas da ordem de compra
        /// </summary>
        public int PER_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// Valor total das outras despesas da ordem de compra
        /// </summary>
        public int VLR_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// Valor total da substituic?o tributaria da ordem de compra
        /// </summary>
        public int VLR_ICMS_SUBST { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Status da ordem de compra: WC - Aguardando confirmac?o (Waiting Confirmation) / AP - Aprovada - aguardando mercadoria (APproved) / IP - Em andamento, caso necessite alterac?o (In Progress) / CO - Completa - mercadoria entregue (COmpleted)
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// Numero da via que foi impressa
        /// </summary>
        public int NRO_VIA_IMPRESSA { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Observac?o da ordem de compra
        /// </summary>
        public string OBS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Observac?o de outras despesas da ordem de compra
        /// </summary>
        public string OBS_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// ID do tipo de pre-ordem / ordem
        /// </summary>
        public int BEG_CPR_TIPO_ORDEM_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do comprador
        /// </summary>
        public int BEG_CPR_COMPRADOR_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do fornecedor
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// ID da condic?o de pagamento
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// ID da forma de pagamento
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// ID da moeda
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
        
        /// <summary>
        /// ID da transportadora
        /// </summary>
        public int BEG_VW_TRANSPORTADORA_ID { get; set; }
        
        /// <summary>
        /// ID da transportadora de redespacho
        /// </summary>
        public int BEG_VW_REDESPACHO_ID { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Mesmo conteudo do status utilizado para pesquisa no Compiere
        /// </summary>
        public string DOCSTATUS_FILTRO { get; set; }
        
        /// <summary>
        /// Data de entrega prevista da ordem
        /// </summary>
        public string DT_ENTREGA_PREVISTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo de envio da ordem de compra para o cliente: M - M-Mail / F - Fax / O - Outros
        /// </summary>
        public string TP_ENVIO { get; set; }

        [NotMapped]
        public string Trigger_TRG_AIR_BEG_CPR_ORDEM_ITENS { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n  --pragma autonomous_transaction;\n  CURSOR busca_itens_lista IS \n    SELECT l.* \n    FROM   beg_sup_lista_fornecedor l,\n           beg_produto p\n    WHERE  l.beg_vw_fornecedor_id = :NEW.beg_vw_fornecedor_id\n    and    l.beg_produto_id = p.beg_produto_id\n    and    p.controla_cor = 'N'\n    and    l.isactive = 'Y'\n    union \n    SELECT l.* \n    FROM   beg_sup_lista_fornecedor l,\n           beg_produto p\n    WHERE  l.beg_vw_fornecedor_id = :NEW.beg_vw_fornecedor_id\n    and    l.beg_produto_id = p.beg_produto_id\n    and    p.controla_cor = 'Y'\n    and    p.die_vw_prd_pai_id is not null\n    and    l.isactive = 'Y';\n  --\n  v_itens_lista    busca_itens_lista%rowtype;\n  --\n  V_SEQUENCIA NUMBER(10);\n  --\n  CURSOR busca_uf_forn IS \n    SELECT p.beg_vw_uf_id \n    FROM   beg_pessoa p\n    WHERE  p.beg_pessoa_id = :new.beg_vw_fornecedor_id;\n  --\n  v_uf      busca_uf_forn%rowtype;\n  --\n  CURSOR busca_mva IS \n    SELECT n.mva\n    FROM   beg_prd_contabil p,\n           beg_prd_ncm n\n    WHERE  p.beg_produto_id = v_itens_lista.beg_produto_id\n    AND    n.beg_prd_ncm_id = p.beg_prd_ncm_id;\n  --\n  v_mva   busca_mva%rowtype;\n  --\nBEGIN\n  --\n  BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM := true;\n  V_SEQUENCIA :=0;\n  OPEN busca_uf_forn;\n  fetch busca_uf_forn INTO v_uf;\n  close busca_uf_forn;\n  OPEN busca_itens_lista;\n  loop\n    v_itens_lista.vlr_bruto := 0;\n    fetch busca_itens_lista INTO v_itens_lista;\n    exit WHEN busca_itens_lista%notfound;\n    OPEN busca_mva;\n    fetch busca_mva INTO v_mva;\n    CLOSE buscA_mva;\n    dbms_output.put_line('produto '||v_itens_lista.beg_produto_id||' '||v_itens_lista.vlr_bruto);\n    INSERT INTO BEG_CPR_ORDEM_ITEM\n  ( BEG_CPR_ORDEM_ITEM_ID,\n    AD_CLIENT_ID,\n    AD_ORG_ID,\n    ISACTIVE,\n    CREATED,\n    CREATEDBY,\n    UPDATED,\n    UPDATEDBY,\n    SEQUENCIA,\n    QTD_SOLICITADA,\n    QTD_ATENDIDA,\n    QTD_CANCELADA,\n    QTD_SALDO,\n    DT_ENTREGA_PREVISTA,\n    DT_EMBARQUE_PREVISTA,\n    VLR_UNITARIO,\n    VLR_TOTAL_PRODUTO,\n    VLR_TOTAL,\n    ALQ_IPI,\n    VLR_IPI,\n    PER_DESCONTO,\n    VLR_DESCONTO,\n    PER_ACRESCIMO,\n    VLR_ACRESCIMO,\n    VLR_DESPESAS_FINANCEIRAS,\n    VLR_OUTRAS_DESPESAS,\n    ALQ_ICMS_SUBST,\n    VLR_ICMS_SUBST,\n    OBS,\n    BEG_CPR_ORDEM_ID,\n    BEG_PRODUTO_ID,\n    BEG_PRD_SKU_ID,\n    QTD_ADICIONADA,\n    PER_DESPESAS_FINANCEIRAS,\n    PER_OUTRAS_DESPESAS,\n    OBS_OUTRAS_DESPESAS,\n    beg_vw_fornecedor_id)\n  VALUES\n  ( beg_fnc_ad_sequence('BEG_CPR_ORDEM_ITEM'),\n    :NEW.AD_CLIENT_ID,\n    :NEW.AD_ORG_ID,\n    'N',\n    :NEW.CREATED,\n    :NEW.CREATEDBY,\n    :NEW.UPDATED,\n    :NEW.UPDATEDBY,\n    V_SEQUENCIA,\n    1,\n    0,\n    0,\n    1,\n    :NEW.dt_entrega_prevista,\n    :NEW.dt_entrega_prevista,\n    decode(nvl(v_itens_lista.vlr_bruto,0),0,1,v_itens_lista.vlr_bruto),\n    decode(nvl(v_itens_lista.vlr_bruto,0),0,1,v_itens_lista.vlr_bruto),\n    decode(nvl(v_itens_lista.vlr_bruto,0),0,1,v_itens_lista.vlr_bruto),\n    v_itens_lista.alq_ipi,\n    round(v_itens_lista.vlr_bruto * (nvl(v_itens_lista.alq_ipi,0) / 100),2),\n    v_itens_lista.per_desconto,\n    round(v_itens_lista.vlr_bruto * (nvl(v_itens_lista.per_desconto,0) / 100),2),\n    0,\n    0,\n    round(v_itens_lista.vlr_bruto * (nvl(v_itens_lista.per_despesas_financeiras,0) / 100),2),\n    round(v_itens_lista.vlr_bruto * (nvl(v_itens_lista.per_outras_despesas,0) / 100),2),\n    case when nvl(v_itens_lista.ind_monofasico,'N') = 'Y' then\n      0\n    else  \n    nvl(beg_fnc_fis_mvaaj(v_uf.beg_vw_uf_id,v_mva.mva,v_itens_lista.alq_icms),0) end ,\n    0,\n    null,\n    :new.beg_cpr_ordem_id,\n    v_itens_lista.beg_produto_id,\n    v_itens_lista.beg_prd_sku_id,\n    0,\n    v_itens_lista.per_despesas_financeiras,\n    v_itens_lista.per_outras_despesas,\n    v_itens_lista.obs_outras_despesas,\n    :new.beg_vw_fornecedor_id);\nv_sequencia := v_sequencia + 1;\n  END loop;\n  CLOSE busca_itens_lista; \n--  commit;\n  --\n  BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM := FALSE;\n/*  UPDATE beg_cpr_ordem_item i \n    SET  i.qtd_solicitada = i.qtd_solicitada\n  WHERE  i.beg_cpr_ordem_id = :NEW.beg_cpr_ordem_id;\n*/  --\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CPR_ORDEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  /*---------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que valida campos da ordem de compra.\n  Modulo.......: CPR - Compras\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  05/09/2006  Tiago Gabriel  Criac?o.\n  28/09/2006  Tiago Gabriel  Se a ordem possui liberac?o, altera a flag indicando alterac?o e cancela.\n  20/10/2006  Tiago Gabriel  Passou a ser possivel alterar a ordem de compra depois de aprovada.\n  26/10/2006  Tiago Gabriel  Busca a transportadora padr?o para compras da filial.\n  10/12/2006  Tiago Gabriel  Corrigida validac?o de comprador. Caso o comprador esteja vinculado a\n                             filial *, este pode comprar para ambas as filiais.\n  ---------------------------------------------------------------------------------------------------*/\n  VC_MSG_ERRO                    varchar2(200);\n  VN_BEG_CPR_COMPRADOR_FILIAL_ID BEG_CPR_ORDEM.BEG_CPR_COMPRADOR_ID%type;\n  VN_BEG_CPR_COMPRADOR_GERAL_ID  BEG_CPR_ORDEM.BEG_CPR_COMPRADOR_ID%type;\n  VN_AUX_ALQ                     number(18, 4);\n  VN_AUX_BASE                    number(18, 4);\n  VN_AUX_CALC                    number(18, 4);\n  VN_DUMMY                       number;\n  VC_IND_CONTROLA_ALCADA         BEG_CPR_COMPRADOR.IND_CONTROLA_ALCADA%type;\n  VN_VLR_SALDO                   BEG_CPR_COMPRADOR.VLR_SALDO%type;\n  VN_BEG_CPR_LIBERACAO_ID        BEG_CPR_LIBERACAO.BEG_CPR_LIBERACAO_ID%type;\n  VN_BEG_VW_CPR_COMPRADOR_ID     BEG_CPR_LIBERACAO.BEG_VW_CPR_COMPRADOR_ID%type;\n  V_VLR_ZERO                     NUMBER;\nbegin\n  V_VLR_ZERO := 0;\n  -- Se esta excluindo uma ordem, exclui tambem os itens.\n  if DELETING then\n  \n    -- Verifica o status da nota\n    if :old.DOCSTATUS in ('AP', 'CO') then\n      VC_MSG_ERRO := 'Somente e possivel excluir ordens aguardando confirmacao ou em progresso!';\n      goto FIM;\n    end if;\n  \n    if :new.DOCSTATUS = 'IP' then\n      select count(1)\n        into VN_DUMMY\n        from BEG_CPR_ORDEM_ITEM     I,\n             BEG_CPR_HISTORICO_ITEM H\n       where I.BEG_CPR_ORDEM_ITEM_ID = H.BEG_CPR_ORDEM_ITEM_ID\n         and I.BEG_CPR_ORDEM_ID = :new.BEG_CPR_ORDEM_ID\n         and H.BEG_CPR_NFE_ITEM_ID is not null;\n      if VN_DUMMY > 0 then\n        VC_MSG_ERRO := 'Ordem ja possui notas geradas!';\n        goto FIM;\n      end if;\n    end if;\n  \n    BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM := true;\n  \n    -- Exclui os itens\n    delete from BEG_CPR_ORDEM_ITEM\n     where BEG_CPR_ORDEM_ID = :old.BEG_CPR_ORDEM_ID;\n  \n    BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM := false;\n  \n    goto FIM;\n  end if;\n\n  :new.DOCSTATUS_FILTRO := :new.DOCSTATUS;\n\n  -- Verifica o status da ordem\n /* if UPDATING\n     and :new.DOCSTATUS = :old.DOCSTATUS\n     and :new.DOCSTATUS_FILTRO = :old.DOCSTATUS_FILTRO\n     and :new.NRO_VIA_IMPRESSA = :old.NRO_VIA_IMPRESSA\n     and :new.TP_ENVIO = :old.TP_ENVIO\n     and :new.DOCSTATUS not in ('WC', 'IP') then\n    VC_MSG_ERRO := 'Somente e possivel alterar ordens que estao aguardando confirmacao ou em progresso!';\n    goto FIM;\n  end if;\n*/\n  if :new.NRO_VIA_IMPRESSA <>\n     NVL(:old.NRO_VIA_IMPRESSA, :new.NRO_VIA_IMPRESSA)\n     or :new.TP_ENVIO <> NVL(:old.TP_ENVIO, :new.TP_ENVIO) then\n    goto FIM;\n  end if;\n\n  if not BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM_IT then\n  \n    -- Verifica filial\n    if NVL(:new.AD_ORG_ID, 0) = 0 then\n      VC_MSG_ERRO := 'Deve ser selecionada uma filial para a ordem!';\n      goto FIM;\n    end if;\n  \n    -- Valida o codigo da ordem\n    if not REGEXP_LIKE(:new.value, '^[[:digit:]]+$') then\n      VC_MSG_ERRO := 'Codigo numerico deve ser infrmado e maior que zero!';\n      goto FIM;\n    end if;\n    \n    -- Valida a data de faturamento \n    if :new.dt_faturamento < :new.dt_emissao  then\n      VC_MSG_ERRO := 'Data de faturamento nao pode ser menor que data de emissao!';\n      goto FIM;\n    end if;    \n    \n    -- Valida a data de previsao de entrega\n    if :new.dt_entrega_prevista is null and :old.dt_entrega_prevista is not null and :new.docstatus = 'AP' and :old.docstatus ='AP' then\n      VC_MSG_ERRO := 'Data de previsao de entrega ja informada nao pode ser excluida!';\n      goto FIM;\n    end if;   \n    \n    if :new.dt_entrega_prevista < :new.dt_emissao  then\n      VC_MSG_ERRO := 'Data de previsao entrega nao pode ser menor que data de emissao!';\n      goto FIM;\n    end if;  \n    \n    if :new.dt_entrega_prevista is not null and :new.dt_entrega_prevista < :new.dt_faturamento  then\n      VC_MSG_ERRO := 'Data de previsao entrega nao pode ser menor que data de previsao de faturamento!';\n      goto FIM;\n    end if; \n  \n    -- Fornecedor\n    if NVL(:new.BEG_VW_FORNECEDOR_ID, 0) <= 0 then\n      VC_MSG_ERRO := 'Fornecedor deve ser informado!';\n      goto FIM;\n    end if;\n  \n    -- Se trocou o fornecedor, verifica o vinculo dos itens\n    if NVL(:old.BEG_VW_FORNECEDOR_ID, 0) <>\n       NVL(:new.BEG_VW_FORNECEDOR_ID, 0) then\n      if :new.DOCSTATUS in ('AP', 'CO') then\n        VC_MSG_ERRO := 'Impossivel alterar fornecedor desta ordem!';\n        goto FIM;\n      end if;\n    \n      if :new.DOCSTATUS = 'IP' then\n        select count(1)\n          into VN_DUMMY\n          from BEG_CPR_ORDEM_ITEM     I,\n               BEG_CPR_HISTORICO_ITEM H\n         where I.BEG_CPR_ORDEM_ITEM_ID = H.BEG_CPR_ORDEM_ITEM_ID\n           and I.BEG_CPR_ORDEM_ID = :new.BEG_CPR_ORDEM_ID\n           and H.BEG_CPR_NFE_ITEM_ID is not null;\n        if VN_DUMMY > 0 then\n          VC_MSG_ERRO := 'Ordem ja possui notas geradas!';\n          goto FIM;\n        end if;\n      end if;\n    \n      if BEG_FNC_RETORNA_PARAM_GERAL('Compras',\n                                     'Produto',\n                                     'CONSISTE_PRODUTO_FORNECEDOR') = 'Y' then\n      \n        select count(1)\n          into VN_DUMMY\n          from BEG_PRD_FORNECEDOR PRD_FRN\n         where PRD_FRN.BEG_VW_FORNECEDOR_ID = :old.BEG_VW_FORNECEDOR_ID\n           and exists\n         (select 1\n                  from BEG_CPR_ORDEM_ITEM ORD_IT\n                 where ORD_IT.BEG_PRODUTO_ID = PRD_FRN.BEG_PRODUTO_ID\n                   and ROWNUM = 1);\n      \n        if VN_DUMMY > 0 then\n          VC_MSG_ERRO := 'Ordem possui itens para o fornecedor anterior!';\n          goto FIM;\n        end if;\n      end if;\n    \n      -- Inicializa os padr?es\n      begin\n        select TP_FRETE,\n               DECODE(TP_FRETE,\n                      'C',\n                      0,\n                      DECODE(NVL(:new.PER_FRETE, 0),\n                             0,\n                             PER_FRETE,\n                             :new.PER_FRETE)),\n               DECODE(NVL(:new.PER_DESPESAS_FINANCEIRAS, 0),\n                      0,\n                      PER_DESPESAS_FINANCEIRAS,\n                      :new.PER_DESPESAS_FINANCEIRAS),\n               DECODE(NVL(:new.PER_OUTRAS_DESPESAS, 0),\n                      0,\n                      PER_OUTRAS_DESPESAS,\n                      :new.PER_OUTRAS_DESPESAS),\n               NVL(:new.OBS_OUTRAS_DESPESAS, OBS_OUTRAS_DESPESAS),\n               DECODE(NVL(:new.BEG_VEN_FORMA_PAGAMENTO_ID, 0),\n                      0,\n                      BEG_VEN_FORMA_PAGAMENTO_ID,\n                      :new.BEG_VEN_FORMA_PAGAMENTO_ID),\n               DECODE(NVL(:new.BEG_CONDICAO_PAGAMENTO_ID, 0),\n                      0,\n                      BEG_CONDICAO_PAGAMENTO_ID,\n                      :new.BEG_CONDICAO_PAGAMENTO_ID),\n               DECODE(NVL(:new.BEG_VW_TRANSPORTADORA_ID, 0),\n                      0,\n                      BEG_VW_TRANSPORTADORA_ID,\n                      :new.BEG_VW_TRANSPORTADORA_ID),\n               BEG_CPR_COMPRADOR_ID,\n               S.BEG_CONDICAO_PAGAMENTO_ID\n          into :new.TP_FRETE,\n               :new.PER_FRETE,\n               :new.PER_DESPESAS_FINANCEIRAS,\n               :new.PER_OUTRAS_DESPESAS,\n               :new.OBS_OUTRAS_DESPESAS,\n               :new.BEG_VEN_FORMA_PAGAMENTO_ID,\n               :new.BEG_CONDICAO_PAGAMENTO_ID,\n               :new.BEG_VW_TRANSPORTADORA_ID,\n               VN_BEG_CPR_COMPRADOR_FILIAL_ID,\n               :NEW.BEG_CONDICAO_PAGAMENTO_ID\n          from BEG_SUP_FORNECEDOR S\n         where /*AD_ORG_ID =\n               BEG_FNC_SUP_AD_ORG(:new.AD_ORG_ID, :new.BEG_VW_FORNECEDOR_ID)\n           and*/ ISACTIVE = 'Y'\n           and BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID;\n      \n      exception\n        when NO_DATA_FOUND then\n          null;\n        \n        when TOO_MANY_ROWS then\n          VC_MSG_ERRO := 'Informac?es de suprimento de fornecedor duplicadas!';\n          goto FIM;\n        \n      end;\n    \n      if :new.BEG_VW_TRANSPORTADORA_ID is null\n         and :new.TP_FRETE = 'F' then\n        :new.BEG_VW_TRANSPORTADORA_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n                                                                             :new.AD_ORG_ID,\n                                                                             'Compras',\n                                                                             null,\n                                                                             'TRANSP_PADRAO_COMPRA'));\n      end if;\n    \n    end if;\n  \n    -- Verifica comprador\n    if :new.BEG_CPR_COMPRADOR_ID is null\n       and VN_BEG_CPR_COMPRADOR_FILIAL_ID is null then\n      VC_MSG_ERRO := 'Comprador deve ser informado!';\n      goto FIM;\n    end if;\n  \n    if VN_BEG_CPR_COMPRADOR_FILIAL_ID is not null then\n      :new.BEG_CPR_COMPRADOR_ID := NVL(:new.BEG_CPR_COMPRADOR_ID,\n                                       VN_BEG_CPR_COMPRADOR_FILIAL_ID);\n    \n      if BEG_FNC_RETORNA_PARAM_GERAL('Compras',\n                                     null,\n                                     'CONSISTE_COMPRADOR_FORNECEDOR') = 'Y' then\n      \n        if :new.BEG_CPR_COMPRADOR_ID <> VN_BEG_CPR_COMPRADOR_FILIAL_ID then\n          begin\n            select BEG_CPR_COMPRADOR_ID\n              into VN_BEG_CPR_COMPRADOR_GERAL_ID\n              from BEG_SUP_FORNECEDOR\n             where AD_ORG_ID = 0\n               and ISACTIVE = 'Y'\n               and BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID;\n          \n          exception\n            when NO_DATA_FOUND then\n              VN_BEG_CPR_COMPRADOR_GERAL_ID := VN_BEG_CPR_COMPRADOR_FILIAL_ID;\n            \n            when TOO_MANY_ROWS then\n              VC_MSG_ERRO := 'Informac?es de suprimento de fornecedor duplicadas!';\n              goto FIM;\n            \n          end;\n        \n          if :new.BEG_CPR_COMPRADOR_ID <> VN_BEG_CPR_COMPRADOR_GERAL_ID then\n          \n            VC_MSG_ERRO := 'Comprador deste fornecedor divergente do selecionado! Para inicializar deixar em branco.';\n            goto FIM;\n          end if;\n        end if;\n      end if;\n    end if;\n  \n    :new.BEG_MOEDA_ID := NVL(:new.BEG_MOEDA_ID, 1000000);\n  \n  end if;\n\n  -- Frete\n  if (NVL(:old.VLR_TOTAL_PRODUTOS, 0) <> NVL(:new.VLR_TOTAL_PRODUTOS, 0) or\n     NVL(:old.PER_FRETE, 0) <> NVL(:new.PER_FRETE, 0) or\n     NVL(:old.VLR_FRETE, 0) <> NVL(:new.VLR_FRETE, 0))\n     and (NVL(:new.PER_FRETE, 0) <> 0 or NVL(:new.VLR_FRETE, 0) <> 0) then\n  \n    if NVL(:new.VLR_TOTAL_PRODUTOS, 0) = 0\n       or (NVL(:new.PER_FRETE, 0) = 0 and\n           NVL(:old.PER_FRETE, 0) <> NVL(:new.PER_FRETE, 0)) then\n      :new.VLR_FRETE := 0;\n    elsif NVL(:new.VLR_FRETE, 0) = 0\n          and NVL(:old.VLR_FRETE, 0) <> NVL(:new.VLR_FRETE, 0) then\n      :new.PER_FRETE := 0;\n    else\n      if NVL(:old.PER_FRETE, 0) <> NVL(:new.PER_FRETE, 0)\n         or NVL(:new.VLR_FRETE, 0) = 0\n         or NVL(:new.PER_FRETE, 0) > 0 then\n        VN_AUX_BASE := :new.VLR_TOTAL_PRODUTOS;\n        VN_AUX_ALQ  := :new.PER_FRETE;\n        VN_AUX_CALC := 0;\n      elsif NVL(:old.VLR_FRETE, 0) <> NVL(:new.VLR_FRETE, 0) then\n        VN_AUX_BASE := :new.VLR_TOTAL_PRODUTOS;\n        VN_AUX_ALQ  := 0;\n        VN_AUX_CALC := :new.VLR_FRETE;\n      end if;\n    \n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                             VN_AUX_BASE,\n                                             VN_AUX_CALC);\n                                            -- V_VLR_ZERO);\n    \n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do frete!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do frete!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de frete diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.PER_FRETE := VN_AUX_ALQ;\n        :new.VLR_FRETE := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  -- Despesas financeiras\n  if (NVL(:old.VLR_TOTAL_PRODUTOS, 0) <> NVL(:new.VLR_TOTAL_PRODUTOS, 0) or\n     NVL(:old.PER_DESPESAS_FINANCEIRAS, 0) <>\n     NVL(:new.PER_DESPESAS_FINANCEIRAS, 0) or\n     NVL(:old.VLR_DESPESAS_FINANCEIRAS, 0) <>\n     NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0))\n     and (NVL(:new.PER_DESPESAS_FINANCEIRAS, 0) <> 0 or\n     NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0) <> 0) then\n  \n    if NVL(:new.VLR_TOTAL_PRODUTOS, 0) = 0\n       or (NVL(:new.PER_DESPESAS_FINANCEIRAS, 0) = 0 and\n           NVL(:old.PER_DESPESAS_FINANCEIRAS, 0) <>\n           NVL(:new.PER_DESPESAS_FINANCEIRAS, 0)) then\n      :new.VLR_DESPESAS_FINANCEIRAS := 0;\n    elsif NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0) = 0\n          and NVL(:old.VLR_DESPESAS_FINANCEIRAS, 0) <>\n          NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0) then\n      :new.PER_DESPESAS_FINANCEIRAS := 0;\n    else\n      if NVL(:old.PER_DESPESAS_FINANCEIRAS, 0) <>\n         NVL(:new.PER_DESPESAS_FINANCEIRAS, 0)\n         or NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0) = 0\n         or NVL(:new.PER_DESPESAS_FINANCEIRAS, 0) > 0 then\n        VN_AUX_BASE := :new.VLR_TOTAL_PRODUTOS;\n        VN_AUX_ALQ  := :new.PER_DESPESAS_FINANCEIRAS;\n        VN_AUX_CALC := 0;\n      elsif NVL(:old.VLR_DESPESAS_FINANCEIRAS, 0) <>\n            NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0) then\n        VN_AUX_BASE := :new.VLR_TOTAL_PRODUTOS;\n        VN_AUX_ALQ  := 0;\n        VN_AUX_CALC := :new.VLR_DESPESAS_FINANCEIRAS;\n      end if;\n    \n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                             VN_AUX_BASE,\n                                             VN_AUX_CALC);\n                                           --  V_VLR_ZERO);\n    \n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo das despesas financeiras!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor das despesas financeiras!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de despesas financeiras diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.PER_DESPESAS_FINANCEIRAS := VN_AUX_ALQ;\n        :new.VLR_DESPESAS_FINANCEIRAS := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  -- Outras despesas\n  if (NVL(:old.VLR_TOTAL_PRODUTOS, 0) <> NVL(:new.VLR_TOTAL_PRODUTOS, 0) or\n     NVL(:old.PER_OUTRAS_DESPESAS, 0) <> NVL(:new.PER_OUTRAS_DESPESAS, 0) or\n     NVL(:old.VLR_OUTRAS_DESPESAS, 0) <> NVL(:new.VLR_OUTRAS_DESPESAS, 0))\n     and (NVL(:new.PER_OUTRAS_DESPESAS, 0) <> 0 or\n     NVL(:new.VLR_OUTRAS_DESPESAS, 0) <> 0) then\n  \n    if NVL(:new.VLR_TOTAL_PRODUTOS, 0) = 0\n       or (NVL(:new.PER_OUTRAS_DESPESAS, 0) = 0 and\n           NVL(:old.PER_OUTRAS_DESPESAS, 0) <>\n           NVL(:new.PER_OUTRAS_DESPESAS, 0)) then\n      :new.VLR_OUTRAS_DESPESAS := 0;\n    elsif NVL(:new.VLR_OUTRAS_DESPESAS, 0) = 0\n          and NVL(:old.VLR_OUTRAS_DESPESAS, 0) <>\n          NVL(:new.VLR_OUTRAS_DESPESAS, 0) then\n      :new.PER_OUTRAS_DESPESAS := 0;\n    else\n      if NVL(:old.PER_OUTRAS_DESPESAS, 0) <>\n         NVL(:new.PER_OUTRAS_DESPESAS, 0)\n         or NVL(:new.VLR_OUTRAS_DESPESAS, 0) = 0\n         or NVL(:new.PER_OUTRAS_DESPESAS, 0) > 0 then\n        VN_AUX_BASE := :new.VLR_TOTAL_PRODUTOS;\n        VN_AUX_ALQ  := :new.PER_OUTRAS_DESPESAS;\n        VN_AUX_CALC := 0;\n      elsif NVL(:old.VLR_OUTRAS_DESPESAS, 0) <>\n            NVL(:new.VLR_OUTRAS_DESPESAS, 0) then\n        VN_AUX_BASE := :new.VLR_TOTAL_PRODUTOS;\n        VN_AUX_ALQ  := 0;\n        VN_AUX_CALC := :new.VLR_OUTRAS_DESPESAS;\n      end if;\n    \n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                             VN_AUX_BASE,\n                                             VN_AUX_CALC);\n                                            -- V_VLR_ZERO);\n    \n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo de outras despesas!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor de outras despesas!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de outras despesas diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.PER_OUTRAS_DESPESAS := VN_AUX_ALQ;\n        :new.VLR_OUTRAS_DESPESAS := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  -- Desconto\n  if (NVL(:old.VLR_TOTAL_PRODUTOS, 0) <> NVL(:new.VLR_TOTAL_PRODUTOS, 0) or\n     NVL(:old.PER_DESCONTO, 0) <> NVL(:new.PER_DESCONTO, 0) or\n     NVL(:old.VLR_DESCONTO, 0) <> NVL(:new.VLR_DESCONTO, 0))\n     and (NVL(:new.PER_DESCONTO, 0) <> 0 or NVL(:new.VLR_DESCONTO, 0) <> 0) then\n  \n    if NVL(:new.VLR_TOTAL_PRODUTOS, 0) = 0\n       or (NVL(:new.PER_DESCONTO, 0) = 0 and\n           NVL(:old.PER_DESCONTO, 0) <> NVL(:new.PER_DESCONTO, 0)) then\n      :new.VLR_DESCONTO := 0;\n    elsif NVL(:new.VLR_DESCONTO, 0) = 0\n          and NVL(:old.VLR_DESCONTO, 0) <> NVL(:new.VLR_DESCONTO, 0) then\n      :new.PER_DESCONTO := 0;\n    else\n      if NVL(:old.PER_DESCONTO, 0) <> NVL(:new.PER_DESCONTO, 0)\n         or NVL(:new.VLR_DESCONTO, 0) = 0\n         or NVL(:new.PER_DESCONTO, 0) > 0 then\n        VN_AUX_BASE := :new.VLR_TOTAL_PRODUTOS;\n        VN_AUX_ALQ  := :new.PER_DESCONTO;\n        VN_AUX_CALC := 0;\n      elsif NVL(:old.VLR_DESCONTO, 0) <> NVL(:new.VLR_DESCONTO, 0) then\n        VN_AUX_BASE := :new.VLR_TOTAL_PRODUTOS;\n        VN_AUX_ALQ  := 0;\n        VN_AUX_CALC := :new.VLR_DESCONTO;\n      end if;\n    \n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                             VN_AUX_BASE,\n                                             VN_AUX_CALC);\n                                            -- V_VLR_ZERO);\n    \n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do desconto!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do desconto!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de desconto diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.PER_DESCONTO := VN_AUX_ALQ;\n        :new.VLR_DESCONTO := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  -- Acrescimo\n  if (NVL(:old.VLR_TOTAL_PRODUTOS, 0) <> NVL(:new.VLR_TOTAL_PRODUTOS, 0) or\n     NVL(:old.PER_ACRESCIMO, 0) <> NVL(:new.PER_ACRESCIMO, 0) or\n     NVL(:old.VLR_ACRESCIMO, 0) <> NVL(:new.VLR_ACRESCIMO, 0))\n     and\n     (NVL(:new.PER_ACRESCIMO, 0) <> 0 or NVL(:new.VLR_ACRESCIMO, 0) <> 0) then\n  \n    if NVL(:new.VLR_TOTAL_PRODUTOS, 0) = 0\n       or (NVL(:new.PER_ACRESCIMO, 0) = 0 and\n           NVL(:old.PER_ACRESCIMO, 0) <> NVL(:new.PER_ACRESCIMO, 0)) then\n      :new.VLR_ACRESCIMO := 0;\n    elsif NVL(:new.VLR_ACRESCIMO, 0) = 0\n          and NVL(:old.VLR_ACRESCIMO, 0) <> NVL(:new.VLR_ACRESCIMO, 0) then\n      :new.PER_ACRESCIMO := 0;\n    else\n      if NVL(:old.PER_ACRESCIMO, 0) <> NVL(:new.PER_ACRESCIMO, 0)\n         or NVL(:new.VLR_ACRESCIMO, 0) = 0\n         or NVL(:new.PER_ACRESCIMO, 0) > 0 then\n        VN_AUX_BASE := :new.VLR_TOTAL_PRODUTOS;\n        VN_AUX_ALQ  := :new.PER_ACRESCIMO;\n        VN_AUX_CALC := 0;\n      elsif NVL(:old.VLR_ACRESCIMO, 0) <> NVL(:new.VLR_ACRESCIMO, 0) then\n        VN_AUX_BASE := :new.VLR_TOTAL_PRODUTOS;\n        VN_AUX_ALQ  := 0;\n        VN_AUX_CALC := :new.VLR_ACRESCIMO;\n      end if;\n    \n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                             VN_AUX_BASE,\n                                             VN_AUX_CALC);\n                                           --  V_VLR_ZERO);\n    \n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do acrescimo!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do acrescimo!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de acrescimo diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.PER_ACRESCIMO := VN_AUX_ALQ;\n        :new.VLR_ACRESCIMO := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  -- Calcula o valor liquido\n  :new.VLR_TOTAL_ORDEM := (:new.VLR_TOTAL_PRODUTOS + -- Bruto\n                          :new.VLR_IPI + -- IPI\n                          :new.VLR_ACRESCIMO + -- Acrescimo\n                          :new.VLR_FRETE + -- Frete\n                          :new.VLR_FRETE_RDP + -- Frete de redespacho\n                          :new.VLR_DESPESAS_FINANCEIRAS + -- Despesas financeiras\n                          :new.VLR_OUTRAS_DESPESAS + -- Outras despesas\n                          :new.VLR_ICMS_SUBST) - -- ICMS da substituic?o tributaria\n                          :new.VLR_DESCONTO; -- Desconto\n\n  if :new.VLR_TOTAL_ORDEM < 0 then\n    VC_MSG_ERRO := 'Verifique os valores! Valor liquido negativo.';\n    goto FIM;\n  end if;\n\n  -- Se esta alterando a ordem e possui liberac?o, cancela a liberac?o\n  if UPDATING\n     and :old.DOCSTATUS = :new.DOCSTATUS then\n    update BEG_CPR_LIBERACAO\n       set DT_CANCELAMENTO = TRUNC(sysdate),\n           IND_ALTERACAO   = 'Y'\n     where BEG_CPR_ORDEM_ID = :new.BEG_CPR_ORDEM_ID\n       and DT_CANCELAMENTO is null;\n  end if;\n\n  -- Busca dados do comprador\n  select IND_CONTROLA_ALCADA,\n         VLR_SALDO\n    into VC_IND_CONTROLA_ALCADA,\n         VN_VLR_SALDO\n    from BEG_CPR_COMPRADOR\n   where BEG_CPR_COMPRADOR_ID = :new.BEG_CPR_COMPRADOR_ID;\n\n  -- Verifica saldo e atualiza o saldo do comprador\n  if VC_IND_CONTROLA_ALCADA = 'Y' then\n    -- Se esta aprovando a ordem, verifica a alcada e atualiza o valor comprado\n    if :old.DOCSTATUS in ('WC', 'IP')\n       and :new.DOCSTATUS = 'AP' then\n    \n      -- Necessita liberac?o\n      if :new.VLR_TOTAL_ORDEM > VN_VLR_SALDO then\n      \n        begin\n          select BEG_CPR_LIBERACAO_ID,\n                 BEG_VW_CPR_COMPRADOR_ID\n            into VN_BEG_CPR_LIBERACAO_ID,\n                 VN_BEG_VW_CPR_COMPRADOR_ID\n            from BEG_CPR_LIBERACAO\n           where ISACTIVE = 'Y'\n             and DT_CANCELAMENTO is null\n             and BEG_CPR_ORDEM_ID = :new.BEG_CPR_ORDEM_ID;\n        \n          -- Atualiza a data de utilizac?o\n          update BEG_CPR_LIBERACAO\n             set DT_UTILIZACAO = TRUNC(sysdate)\n           where BEG_CPR_LIBERACAO_ID = VN_BEG_CPR_LIBERACAO_ID;\n        \n          -- Atualiza o saldo do supervisor que liberou\n          update BEG_CPR_COMPRADOR\n             set VLR_COMPRADO = VLR_COMPRADO +\n                                (:new.VLR_TOTAL_ORDEM - VN_VLR_SALDO)\n           where BEG_CPR_COMPRADOR_ID = VN_BEG_VW_CPR_COMPRADOR_ID;\n        \n          update BEG_CPR_COMPRADOR\n             set VLR_COMPRADO = VLR_COMPRADO + VN_VLR_SALDO,\n                 VLR_LIBERADO = VLR_LIBERADO +\n                                (:new.VLR_TOTAL_ORDEM - VN_VLR_SALDO),\n                 DT_LIBERADO  = TRUNC(sysdate),\n                 QTD_LIBERADO = QTD_LIBERADO + 1\n           where BEG_CPR_COMPRADOR_ID = :new.BEG_CPR_COMPRADOR_ID;\n        \n        exception\n        \n          when NO_DATA_FOUND then\n            VC_MSG_ERRO := 'Ordem de compra necessita uma liberac?o valida!';\n            goto FIM;\n          \n          when TOO_MANY_ROWS then\n            VC_MSG_ERRO := 'Liberac?o duplicada!';\n            goto FIM;\n          \n        end;\n      \n      else\n      \n        update BEG_CPR_COMPRADOR\n           set VLR_COMPRADO = VLR_COMPRADO + :new.VLR_TOTAL_ORDEM\n         where BEG_CPR_COMPRADOR_ID = :new.BEG_CPR_COMPRADOR_ID;\n      \n      end if;\n    \n      -- Se esta concluindo ou cancelando a ordem atualiza o valor comprado\n    elsif :old.DOCSTATUS = 'AP'\n          and :new.DOCSTATUS in ('IP', 'CO') then\n    \n      update BEG_CPR_COMPRADOR\n         set VLR_COMPRADO = VLR_COMPRADO -\n                            DECODE(SIGN(VLR_LIBERADO - :new.VLR_TOTAL_ORDEM),\n                                   1,\n                                   0,\n                                   (:new.VLR_TOTAL_ORDEM - VLR_LIBERADO)),\n             VLR_LIBERADO = DECODE(SIGN(VLR_LIBERADO - :new.VLR_TOTAL_ORDEM),\n                                   1,\n                                   (VLR_LIBERADO - :new.VLR_TOTAL_ORDEM),\n                                   0)\n       where BEG_CPR_COMPRADOR_ID = :new.BEG_CPR_COMPRADOR_ID;\n    \n    end if;\n  end if;\n  \n  if updating and :old.dt_entrega_prevista <> :new.dt_entrega_prevista then\n    \n      update BEG_CPR_ORDEM_ITEM i set\n          i.dt_entrega_prevista = :new.dt_entrega_prevista\n      where i.beg_cpr_ordem_id = :new.beg_cpr_ordem_id;\n          \n  end if; \n\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend BEG_TRG_BIUD_CPR_ORDEM;\n"}`;
    
    }
}
