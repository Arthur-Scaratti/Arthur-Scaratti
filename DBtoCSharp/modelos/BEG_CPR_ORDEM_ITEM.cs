
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPR_ORDEM_ITEM
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Sequencia do item na ordem
        /// </summary>
        public int SEQUENCIA { get; set; }
            [Required]
        /// <summary>
        /// Quantidade solicitada do item na ordem de compra
        /// </summary>
        public int QTD_SOLICITADA { get; set; }
            [Required]
        /// <summary>
        /// Quantidade atendida do item na ordem de compra
        /// </summary>
        public int QTD_ATENDIDA { get; set; }
            [Required]
        /// <summary>
        /// Quantidade cancelada do item na ordem de compra
        /// </summary>
        public int QTD_CANCELADA { get; set; }
            [Required]
        /// <summary>
        /// Quantidade saldo do item na ordem de compra
        /// </summary>
        public int QTD_SALDO { get; set; }
        
        /// <summary>
        /// Data de entrega prevista do item na ordem de compra
        /// </summary>
        public string DT_ENTREGA_PREVISTA { get; set; }
        
        /// <summary>
        /// Data de embarque / despacho prevista do item na ordem de compra
        /// </summary>
        public string DT_EMBARQUE_PREVISTA { get; set; }
            [Required]
        /// <summary>
        /// Valor unitario do item na ordem de compra
        /// </summary>
        public int VLR_UNITARIO { get; set; }
            [Required]
        /// <summary>
        /// Valor total bruto do item na ordem de compra
        /// </summary>
        public int VLR_TOTAL_PRODUTO { get; set; }
            [Required]
        /// <summary>
        /// Valor total liquido do item na ordem de compra
        /// </summary>
        public int VLR_TOTAL { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do IPI
        /// </summary>
        public int ALQ_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor total liquido do IPI do item na ordem de compra
        /// </summary>
        public int VLR_IPI { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto / abatimento do item na ordem de compra
        /// </summary>
        public int PER_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// Valor total do desconto / abatimento do item na ordem de compra
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// Percentual de acrescimo do item na ordem de compra
        /// </summary>
        public int PER_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// Valor total do acrescimo do item na ordem de compra
        /// </summary>
        public int VLR_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// Valor total das despesas financeiras do item na ordem de compra
        /// </summary>
        public int VLR_DESPESAS_FINANCEIRAS { get; set; }
            [Required]
        /// <summary>
        /// Valor total de outras despesas do item na ordem de compra
        /// </summary>
        public int VLR_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do ICMS da substituic?o tributaria
        /// </summary>
        public int ALQ_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// Valor total da substituic?o tributaria do item na ordem de compra
        /// </summary>
        public int VLR_ICMS_SUBST { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Observac?o do item na ordem de compra
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// ID da ordem de cmpra
        /// </summary>
        public int BEG_CPR_ORDEM_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do SKU do produto
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
            [Required]
        /// <summary>
        /// Quantidade adicionada do item na ordem de compra
        /// </summary>
        public int QTD_ADICIONADA { get; set; }
            [Required]
        /// <summary>
        /// Percentual de despesas financeiras do item da ordem de compra
        /// </summary>
        public int PER_DESPESAS_FINANCEIRAS { get; set; }
            [Required]
        /// <summary>
        /// Percentual de outras despesas do item da ordem de compra
        /// </summary>
        public int PER_OUTRAS_DESPESAS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Observac?o de outras despesas do item da ordem de compra
        /// </summary>
        public string OBS_OUTRAS_DESPESAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do item da ordem de compra
        /// </summary>
        public int BEG_CPR_ORDEM_ITEM_ID { get; set; }
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

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_CPR_ORDEM_ITEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n  pragma autonomous_transaction;\n  --\n  CURSOR C1 IS\n    SELECT SUM(NVL(I.QTD_ATENDIDA,0)) + SUM(NVL(I.QTD_CANCELADA,0)) QTD_TOTAL\n         , SUM(NVL(I.QTD_SOLICITADA,0)+ NVL(I.QTD_ADICIONADA,0)) QTD_SALDO\n      FROM BEG_CPR_ORDEM_ITEM I\n     WHERE I.BEG_CPR_ORDEM_ID = :NEW.BEG_CPR_ORDEM_ID\n       AND I.ISACTIVE         = 'Y'\n       AND I.BEG_CPR_ORDEM_ITEM_ID <> :NEW.BEG_CPR_ORDEM_ITEM_ID;\n  --\n  R_C1 C1%ROWTYPE;\n  --\n  --VN_ID NUMBER(10);\nBEGIN\n  --\n  --VN_ID := :NEW.BEG_CPR_ORDEM_ID;\n  --\n  OPEN C1;\n  FETCH C1 INTO R_C1;\n  CLOSE C1;\n  --\n  --RAISE_APPLICATION_ERROR(-20501,'ERRO'||(NVL(R_C1.QTD_SALDO,0) + :NEW.QTD_SOLICITADA)||'-'||(NVL(R_C1.QTD_TOTAL,0) + NVL(:NEW.QTD_ATENDIDA,0) + NVL(:NEW.QTD_CANCELADA,0)));\n  IF NVL(R_C1.QTD_SALDO,0) + :NEW.QTD_SOLICITADA +:NEW.QTD_ADICIONADA = NVL(R_C1.QTD_TOTAL,0) + NVL(:NEW.QTD_ATENDIDA,0) + NVL(:NEW.QTD_CANCELADA,0)\n    THEN\n    --QUANDO A SOMA DA QTD_CANCELA + QTD_ATENDIDA FOREM IGUAL QTD_SALDO ENCERRA A ORDEM DE COMPRA\n    UPDATE BEG_CPR_ORDEM O\n       SET O.DOCSTATUS = 'CO'\n     WHERE O.BEG_CPR_ORDEM_ID = :NEW.BEG_CPR_ORDEM_ID;\n    commit;\n    --\n    NULL;\n/*  ELSE\n    --\n    UPDATE BEG_CPR_ORDEM O\n       SET O.DOCSTATUS = 'AP'\n     WHERE O.BEG_CPR_ORDEM_ID = :NEW.BEG_CPR_ORDEM_ID;\n    commit;    \n    --\n*/  END IF;\n  --\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00013 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n\n\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CPR_ORDEM_ITEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que valida o item incluido ou atualizado em uma ordem de compra.\n  Modulo.......: CPR - Compras\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  05/09/2006  Tiago Gabriel  Criac?o.\n  20/10/2006  Tiago Gabriel  Passou a ser possivel alterar a ordem de compra depois de aprovada.\n  16/01/2007  Tiago Gabriel  Passou a buscar dados do detalhe do SKU, filtrado por filial.\n  --------------------------------------------------------------------------------------------------- */\n  VC_MSG_ERRO           varchar2(200);\n  VN_AUX_ALQ            number(18, 4);\n  VN_AUX_BASE           number(18, 4);\n  VN_AUX_CALC           NUMBER(18, 4);\n  vn_total_icms_st      NUMBER(18, 4);\n  VN_TOTAL_ICMS_PROP    NUMBER(18, 4);\n  v_aliq_icms_prop      number(18, 8);\n  VC_DOCSTATUS          BEG_CPR_NFE.DOCSTATUS%type;\n  VN_BEG_VW_FORN_ORD_ID BEG_CPR_ORDEM.BEG_VW_FORNECEDOR_ID%type;\n  VN_DUMMY              number;\n  v_id                  number;\n  --  V_VLR_ZERO            NUMBER;\n  --\n  CURSOR busca_aliqs IS\n    SELECT u.aliq_interna,\n           u.aliq_interest,\n           p.beg_vw_uf_id  uf_forn,\n           pf.beg_vw_uf_id uf_fil\n      FROM beg_pessoa p, beg_uf u, beg_dado_filial d, beg_pessoa pf\n     WHERE p.beg_pessoa_id = VN_BEG_VW_FORN_ORD_ID\n       and u.beg_uf_id = p.beg_vw_uf_id\n       AND d.ad_org_id = :NEW.ad_org_id\n       AND pf.beg_pessoa_id = d.beg_pessoa_id;\n  --\n  v_aliqs busca_aliqs%rowtype;\n  --\n  CURSOR busca_itens_lista IS\n    SELECT *\n      FROM beg_sup_lista_fornecedor l\n     WHERE l.beg_vw_fornecedor_id = :NEW.beg_vw_fornecedor_id\n       and l.beg_produto_id = :new.beg_produto_id\n       and l.beg_prd_sku_id = :new.beg_prd_sku_id\n       and l.isactive = 'Y';\n  --\n  v_lista busca_itens_lista%rowtype;\n  --\nBEGIN\n  IF BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM THEN\n    return;\n  end if;\n  \n  IF :NEW.BEG_VW_FORNECEDOR_ID IS NULL AND NOT DELETING THEN\n    \n   SELECT O.BEG_VW_FORNECEDOR_ID                      \n     INTO v_id\n    FROM BEG_CPR_ORDEM O\n    WHERE O.BEG_CPR_ORDEM_ID = :NEW.BEG_CPR_ORDEM_ID;\n    \n    :NEW.BEG_VW_FORNECEDOR_ID := v_id;\n  \n  END IF;\n  \n  \n  -- V_VLR_ZERO := 0;\n  -- Verifica se o item esta inativo\n  --if :new.ISACTIVE = 'N' then\n  --  VC_MSG_ERRO := 'Item inativo!';\n  --   goto FIM;\n  -- end if;\n\n  -- Valida o status da ordem (capa)\n  if not BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM and\n     nvl(to_char(:old.dt_entrega_prevista,'DD/MM/RRRR'),'01/01/2020') = nvl(to_char(:new.dt_entrega_prevista,'DD/MM/RRRR'),'01/01/2020') then\n\n    select BEG_VW_FORNECEDOR_ID, DOCSTATUS\n      into VN_BEG_VW_FORN_ORD_ID, VC_DOCSTATUS\n      from BEG_CPR_ORDEM\n     where BEG_CPR_ORDEM_ID =\n           NVL(:new.BEG_CPR_ORDEM_ID, :old.BEG_CPR_ORDEM_ID);\n\n    if UPDATING and (:old.BEG_PRODUTO_ID <> :new.BEG_PRODUTO_ID or\n       :old.BEG_PRD_SKU_ID <> :new.BEG_PRD_SKU_ID) then\n\n      if VC_DOCSTATUS in ('AP', 'CO') then\n        VC_MSG_ERRO := 'Somente e possivel alterar ordens que estao aguardando confirmacao ou em progresso!';\n        goto FIM;\n      end if;\n\n      if VC_DOCSTATUS = 'IP' then\n        select count(1)\n          into VN_DUMMY\n          from BEG_CPR_HISTORICO_ITEM\n         where BEG_CPR_ORDEM_ITEM_ID = :new.BEG_CPR_ORDEM_ITEM_ID\n           and BEG_CPR_NFE_ITEM_ID is not null;\n        if VN_DUMMY > 0 then\n          VC_MSG_ERRO := 'Ja existem notas geradas para este item!';\n          goto FIM;\n        end if;\n      end if;\n    end if;\n\n  end if;\n\n  -- Se esta deletando, remove o historico da ordem de compra\n  IF DELETING and :old.isactive = 'Y' then\n\n    select count(1)\n      into VN_DUMMY\n      from BEG_CPR_HISTORICO_ITEM\n     where BEG_CPR_ORDEM_ITEM_ID = :old.BEG_CPR_ORDEM_ITEM_ID;\n\n    if VN_DUMMY > 0 then\n      VC_MSG_ERRO := 'Ordem possui nota(s) vinculadas!';\n      goto FIM;\n    end if;\n\n    if not BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM then\n\n      update BEG_CPR_ORDEM\n         set VLR_TOTAL_PRODUTOS = VLR_TOTAL_PRODUTOS -\n                                  :old.VLR_TOTAL_PRODUTO,\n             VLR_IPI            = VLR_IPI - :old.VLR_IPI,\n             VLR_ICMS_SUBST     = VLR_ICMS_SUBST - :old.VLR_ICMS_SUBST\n       where BEG_CPR_ORDEM_ID = :old.BEG_CPR_ORDEM_ID;\n\n    end if;\n\n    goto FIM;\n\n  end if;\n\n  -- Quantidade\n  if not deleting then\n    if NVL(:new.QTD_SOLICITADA, 0) <= 0 then\n      VC_MSG_ERRO := 'Quantidade zerada ou negativa!';\n      goto FIM;\n    end if;\n\n    if :new.QTD_CANCELADA > 0 and :new.QTD_ADICIONADA > 0 then\n      VC_MSG_ERRO := 'Impossivel cancelar e adicionar quantidade ao mesmo tempo!';\n      goto FIM;\n    end if;\n\n    :new.QTD_SALDO := (:new.QTD_SOLICITADA - :new.QTD_ATENDIDA -\n                      :new.QTD_CANCELADA) + :new.QTD_ADICIONADA;\n\n    if :new.QTD_SALDO < 0 then\n      VC_MSG_ERRO := 'Verifique as quantidades! Saldo negativo.';\n      goto FIM;\n    end if;\n\n    -- Se esta atendendo adicionando ou cancelando item, encerra\n    if :old.QTD_SALDO <> :new.QTD_SALDO and\n       :old.QTD_SOLICITADA = :new.QTD_SOLICITADA then\n      goto FIM;\n    end if;\n\n    -- Valor unitario\n    if NVL(:new.VLR_UNITARIO, 0) <= 0 then\n      VC_MSG_ERRO := 'Valor unitario zerado ou negativo!';\n      goto FIM;\n    END IF;\n\n  END IF;\n  --\n  --\n  IF NOT deleting and nvl(to_char(:old.dt_entrega_prevista,'DD/MM/RRRR'),'01/01/2020') = nvl(to_char(:new.dt_entrega_prevista,'DD/MM/RRRR'),'01/01/2020') THEN\n    IF nvl(:NEW.ALQ_ICMS_SUBST, 0) > 0 THEN\n      OPEN busca_aliqs;\n      fetch busca_aliqs\n        INTO v_aliqs;\n      CLOSE busca_aliqs;\n      open busca_itens_lista;\n      fetch busca_itens_lista\n        into v_lista;\n      close busca_itens_lista;\n      if v_lista.alq_icms > 0 then\n        v_aliq_icms_prop := v_lista.alq_icms;\n      else\n        IF v_aliqs.uf_forn <> v_aliqs.uf_fil THEN\n          v_aliq_icms_prop := v_aliqs.aliq_interest;\n        ELSE\n          v_aliq_icms_prop := v_aliqs.aliq_interna;\n        end if;\n      end if;\n      VN_TOTAL_ICMS_PROP := :NEW.QTD_SALDO * NVL(:NEW.VLR_UNITARIO, 0);\n      VN_TOTAL_ICMS_PROP := VN_TOTAL_ICMS_PROP * (v_aliq_icms_prop / 100);\n      vn_total_icms_st   := :NEW.QTD_SALDO * NVL(:NEW.VLR_UNITARIO, 0);\n      vn_total_icms_st   := vn_total_icms_st * (1 + (:NEW.alq_ipi / 100));\n      vn_total_icms_st   := vn_total_icms_st *\n                            (1 + (:NEW.alq_icms_subst / 100));\n      vn_total_icms_st   := vn_total_icms_st * ( /*v_aliqs.aliq_interna*/\n                             18 / 100);\n      vn_total_icms_st   := vn_total_icms_st - vn_total_icms_prop;\n      --RAISE_APPLICATION_ERROR(-20501,'ICMS' ||vn_total_icms_st||' ' );\n      :new.vlr_icms_subst := vn_total_icms_st;\n    END IF;\n  end if;\n  -- Se trocou o produto, valida novamente\n  if not deleting and nvl(to_char(:old.dt_entrega_prevista,'DD/MM/RRRR'),'01/01/2020') = nvl(to_char(:new.dt_entrega_prevista,'DD/MM/RRRR'),'01/01/2020') then\n    IF NOT BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM THEN\n      if NVL(:new.BEG_PRODUTO_ID, 0) <> NVL(:old.BEG_PRODUTO_ID, 0) or\n         NVL(:new.BEG_PRD_SKU_ID, 0) <> NVL(:old.BEG_PRD_SKU_ID, 0) then\n        -- Valida produto vs. fornecedor\n        if BEG_FNC_RETORNA_PARAM_GERAL('Compras',\n                                       'Produto',\n                                       'CONSISTE_PRODUTO_FORNECEDOR') = 'Y' then\n\n          VN_DUMMY := 0;\n          FOR R_FRN IN (SELECT BEG_VW_FORNECEDOR_ID\n                          from BEG_PRD_FORNECEDOR f\n                         WHERE BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID\n                           and f.padrao = 'Y') loop\n            if R_FRN.BEG_VW_FORNECEDOR_ID = VN_BEG_VW_FORN_ORD_ID then\n              VN_DUMMY := 0;\n              exit;\n            else\n              VN_DUMMY := VN_DUMMY + 1;\n            end if;\n          end loop;\n\n          IF VN_DUMMY > 0 THEN\n            VC_MSG_ERRO := 'Produto não pertence ao fornecedor da ordem - ' ||\n                           VC_DOCSTATUS;\n            goto FIM;\n          end if;\n        END IF;\n      end if;\n      -- Atualiza campos n?o digitados\n      begin\n        select SKU.BEG_PRD_SKU_ID\n          into :new.BEG_PRD_SKU_ID\n          from BEG_PRODUTO PRD, BEG_PRD_SKU SKU\n         where PRD.BEG_PRODUTO_ID = SKU.BEG_PRODUTO_ID\n           and PRD.BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n           and SKU.PADRAO = 'Y';\n\n      exception\n        when NO_DATA_FOUND then\n          VC_MSG_ERRO := 'Produto n?o encontrado ou sem SKU padr?o cadastrado!';\n          goto FIM;\n\n      end;\n\n      -- Verifica se restaram campos obrigatorios em branco\n      if NVL(:new.BEG_PRD_SKU_ID, 0) = 0 then\n        VC_MSG_ERRO := 'SKU deve ser informado!';\n        goto FIM;\n      end if;\n\n      begin\n        select DECODE(NVL(:new.ALQ_ICMS_SUBST, 0),\n                      0,\n                      ALQ_ICMS_SUBST,\n                      :new.ALQ_ICMS_SUBST),\n               DECODE(NVL(:new.VLR_ICMS_SUBST, 0),\n                      0,\n                      VLR_ICMS_SUBST,\n                      :new.VLR_ICMS_SUBST),\n               DECODE(NVL(:new.ALQ_IPI, 0), 0, ALQ_IPI, :new.ALQ_IPI),\n               DECODE(NVL(:new.PER_DESPESAS_FINANCEIRAS, 0),\n                      0,\n                      PER_DESPESAS_FINANCEIRAS,\n                      :new.PER_DESPESAS_FINANCEIRAS),\n               DECODE(NVL(:new.PER_OUTRAS_DESPESAS, 0),\n                      0,\n                      PER_OUTRAS_DESPESAS,\n                      :new.PER_OUTRAS_DESPESAS),\n               NVL(:new.OBS_OUTRAS_DESPESAS, OBS_OUTRAS_DESPESAS),\n               DECODE(NVL(:new.VLR_UNITARIO, 0),\n                      0,\n                      VLR_LIQUIDO,\n                      :new.VLR_UNITARIO)\n          into :new.ALQ_ICMS_SUBST,\n               :new.VLR_ICMS_SUBST,\n               :new.ALQ_IPI,\n               :new.PER_DESPESAS_FINANCEIRAS,\n               :new.PER_OUTRAS_DESPESAS,\n               :new.OBS_OUTRAS_DESPESAS,\n               :new.VLR_UNITARIO\n          from BEG_VW_SUP_PRODUTO\n         where AD_VW_ORG_PRD_ID =\n               BEG_FNC_SUP_AD_ORG(:new.AD_ORG_ID,\n                                  VN_BEG_VW_FORN_ORD_ID,\n                                  :new.BEG_PRODUTO_ID,\n                                  :new.BEG_PRD_SKU_ID)\n           and AD_VW_ORG_FRN_ID =\n               BEG_FNC_SUP_AD_ORG(:new.AD_ORG_ID, VN_BEG_VW_FORN_ORD_ID)\n           and ISACTIVE_PRD = 'Y'\n           and ISACTIVE_FRN = 'Y'\n           and BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n           and BEG_PRD_SKU_ID = :new.BEG_PRD_SKU_ID\n           and BEG_VW_FORNECEDOR_ID = VN_BEG_VW_FORN_ORD_ID;\n\n      exception\n        when NO_DATA_FOUND then\n          null;\n\n      end;\n    end if;\n\n    :new.VLR_TOTAL_PRODUTO := :new.QTD_SOLICITADA * :new.VLR_UNITARIO;\n\n    -- Valida o IPI frente a aliquota padr?o cadastrada\n    if (NVL(:old.VLR_TOTAL_PRODUTO, 0) <> NVL(:new.VLR_TOTAL_PRODUTO, 0) or\n       NVL(:old.ALQ_IPI, 0) <> NVL(:new.ALQ_IPI, 0) or\n       NVL(:old.VLR_IPI, 0) <> NVL(:new.VLR_IPI, 0)) and\n       (NVL(:new.ALQ_IPI, 0) <> 0 or NVL(:new.VLR_IPI, 0) <> 0) then\n\n      if NVL(:new.VLR_TOTAL_PRODUTO, 0) = 0 or\n         (NVL(:new.ALQ_IPI, 0) = 0 and\n          NVL(:old.ALQ_IPI, 0) <> NVL(:new.ALQ_IPI, 0)) then\n        :new.VLR_IPI := 0;\n      elsif NVL(:new.VLR_IPI, 0) = 0 and\n            NVL(:old.VLR_IPI, 0) <> NVL(:new.VLR_IPI, 0) then\n        :new.ALQ_IPI := 0;\n      else\n        if NVL(:old.ALQ_IPI, 0) <> NVL(:new.ALQ_IPI, 0) or\n           NVL(:new.VLR_IPI, 0) = 0 or NVL(:new.ALQ_IPI, 0) > 0 then\n          VN_AUX_BASE := :new.VLR_TOTAL_PRODUTO;\n          VN_AUX_ALQ  := :new.ALQ_IPI;\n          VN_AUX_CALC := 0;\n        elsif NVL(:old.VLR_IPI, 0) <> NVL(:new.VLR_IPI, 0) then\n          VN_AUX_BASE := :new.VLR_TOTAL_PRODUTO;\n          VN_AUX_ALQ  := 0;\n          VN_AUX_CALC := :new.VLR_IPI;\n        end if;\n\n        BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                               VN_AUX_BASE,\n                                               VN_AUX_CALC);\n        -- V_VLR_ZERO);\n\n        if VN_AUX_CALC = -1 then\n          VC_MSG_ERRO := 'Valores negativos no calculo do IPI!';\n        elsif VN_AUX_CALC = -2 then\n          VC_MSG_ERRO := 'Impossivel apurar valor do IPI!';\n        elsif VN_AUX_CALC = -3 then\n          VC_MSG_ERRO := 'Valor apurado de IPI diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n        else\n          :new.ALQ_IPI := VN_AUX_ALQ;\n          :new.VLR_IPI := VN_AUX_CALC;\n        end if;\n        if VC_MSG_ERRO is not null then\n          goto FIM;\n        end if;\n      end if;\n    end if;\n\n    -- Valida a substituic?o de ICMS frente a aliquota padr?o cadastrada\n    if (NVL(:old.VLR_TOTAL_PRODUTO, 0) <> NVL(:new.VLR_TOTAL_PRODUTO, 0) or\n       NVL(:old.ALQ_ICMS_SUBST, 0) <> NVL(:new.ALQ_ICMS_SUBST, 0) or\n       NVL(:old.VLR_ICMS_SUBST, 0) <> NVL(:new.VLR_ICMS_SUBST, 0)) and\n       (NVL(:new.ALQ_ICMS_SUBST, 0) <> 0 or\n       NVL(:new.VLR_ICMS_SUBST, 0) <> 0) then\n\n      if NVL(:new.VLR_TOTAL_PRODUTO, 0) = 0 or\n         (NVL(:new.ALQ_ICMS_SUBST, 0) = 0 and\n          NVL(:old.ALQ_ICMS_SUBST, 0) <> NVL(:new.ALQ_ICMS_SUBST, 0)) then\n        :new.VLR_ICMS_SUBST := 0;\n      elsif NVL(:new.VLR_ICMS_SUBST, 0) = 0 and\n            NVL(:old.VLR_ICMS_SUBST, 0) <> NVL(:new.VLR_ICMS_SUBST, 0) then\n        :new.ALQ_ICMS_SUBST := 0;\n      else\n        if NVL(:old.ALQ_ICMS_SUBST, 0) <> NVL(:new.ALQ_ICMS_SUBST, 0) or\n           NVL(:new.VLR_ICMS_SUBST, 0) = 0 or\n           NVL(:new.ALQ_ICMS_SUBST, 0) > 0 then\n          VN_AUX_BASE := :new.VLR_TOTAL_PRODUTO;\n          VN_AUX_ALQ  := :new.ALQ_ICMS_SUBST;\n          VN_AUX_CALC := 0;\n        elsif NVL(:old.VLR_ICMS_SUBST, 0) <> NVL(:new.VLR_ICMS_SUBST, 0) then\n          VN_AUX_BASE := :new.VLR_TOTAL_PRODUTO;\n          VN_AUX_ALQ  := 0;\n          VN_AUX_CALC := :new.VLR_ICMS_SUBST;\n        end if;\n\n        BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                               VN_AUX_BASE,\n                                               VN_AUX_CALC);\n        --  V_VLR_ZERO);\n\n        if VN_AUX_CALC = -1 then\n          VC_MSG_ERRO := 'Valores negativos no calculo do ICMS da substituic?o!';\n        elsif VN_AUX_CALC = -2 then\n          VC_MSG_ERRO := 'Impossivel apurar valor do ICMS da substituic?o!';\n        elsif VN_AUX_CALC = -3 then\n          VC_MSG_ERRO := 'Valor apurado de ICMS da substituic?o diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n        else\n          :NEW.ALQ_ICMS_SUBST := VN_AUX_ALQ;\n          -- :new.VLR_ICMS_SUBST := VN_AUX_CALC;\n        end if;\n        if VC_MSG_ERRO is not null then\n          goto FIM;\n        end if;\n      end if;\n    end if;\n\n    -- Desconto\n    if (NVL(:old.VLR_TOTAL_PRODUTO, 0) <> NVL(:new.VLR_TOTAL_PRODUTO, 0) or\n       NVL(:old.PER_DESCONTO, 0) <> NVL(:new.PER_DESCONTO, 0) or\n       NVL(:old.VLR_DESCONTO, 0) <> NVL(:new.VLR_DESCONTO, 0)) and\n       (NVL(:new.PER_DESCONTO, 0) <> 0 or NVL(:new.VLR_DESCONTO, 0) <> 0) then\n\n      if NVL(:new.VLR_TOTAL_PRODUTO, 0) = 0 or\n         (NVL(:new.PER_DESCONTO, 0) = 0 and\n          NVL(:old.PER_DESCONTO, 0) <> NVL(:new.PER_DESCONTO, 0)) then\n        :new.VLR_DESCONTO := 0;\n      elsif NVL(:new.VLR_DESCONTO, 0) = 0 and\n            NVL(:old.VLR_DESCONTO, 0) <> NVL(:new.VLR_DESCONTO, 0) then\n        :new.PER_DESCONTO := 0;\n      else\n        if NVL(:old.PER_DESCONTO, 0) <> NVL(:new.PER_DESCONTO, 0) or\n           NVL(:new.VLR_DESCONTO, 0) = 0 or NVL(:new.PER_DESCONTO, 0) > 0 then\n          VN_AUX_BASE := :new.VLR_TOTAL_PRODUTO;\n          VN_AUX_ALQ  := :new.PER_DESCONTO;\n          VN_AUX_CALC := 0;\n        elsif NVL(:old.VLR_DESCONTO, 0) <> NVL(:new.VLR_DESCONTO, 0) then\n          VN_AUX_BASE := :new.VLR_TOTAL_PRODUTO;\n          VN_AUX_ALQ  := 0;\n          VN_AUX_CALC := :new.VLR_DESCONTO;\n        end if;\n\n        BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                               VN_AUX_BASE,\n                                               VN_AUX_CALC);\n        --   V_VLR_ZERO);\n\n        if VN_AUX_CALC = -1 then\n          VC_MSG_ERRO := 'Valores negativos no calculo do desconto!';\n        elsif VN_AUX_CALC = -2 then\n          VC_MSG_ERRO := 'Impossivel apurar valor do desconto!';\n        elsif VN_AUX_CALC = -3 then\n          VC_MSG_ERRO := 'Valor apurado de desconto diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n        else\n          :new.PER_DESCONTO := VN_AUX_ALQ;\n          :new.VLR_DESCONTO := VN_AUX_CALC;\n        end if;\n        if VC_MSG_ERRO is not null then\n          goto FIM;\n        end if;\n      end if;\n    end if;\n\n    -- Acrescimo\n    if (NVL(:old.VLR_TOTAL_PRODUTO, 0) <> NVL(:new.VLR_TOTAL_PRODUTO, 0) or\n       NVL(:old.PER_ACRESCIMO, 0) <> NVL(:new.PER_ACRESCIMO, 0) or\n       NVL(:old.VLR_ACRESCIMO, 0) <> NVL(:new.VLR_ACRESCIMO, 0)) and\n       (NVL(:new.PER_ACRESCIMO, 0) <> 0 or NVL(:new.VLR_ACRESCIMO, 0) <> 0) then\n\n      if NVL(:new.VLR_TOTAL_PRODUTO, 0) = 0 or\n         (NVL(:new.PER_ACRESCIMO, 0) = 0 and\n          NVL(:old.PER_ACRESCIMO, 0) <> NVL(:new.PER_ACRESCIMO, 0)) then\n        :new.VLR_ACRESCIMO := 0;\n      elsif NVL(:new.VLR_ACRESCIMO, 0) = 0 and\n            NVL(:old.VLR_ACRESCIMO, 0) <> NVL(:new.VLR_ACRESCIMO, 0) then\n        :new.PER_ACRESCIMO := 0;\n      else\n        if NVL(:old.PER_ACRESCIMO, 0) <> NVL(:new.PER_ACRESCIMO, 0) or\n           NVL(:new.VLR_ACRESCIMO, 0) = 0 or NVL(:new.PER_ACRESCIMO, 0) > 0 then\n          VN_AUX_BASE := :new.VLR_TOTAL_PRODUTO;\n          VN_AUX_ALQ  := :new.PER_ACRESCIMO;\n          VN_AUX_CALC := 0;\n        elsif NVL(:old.VLR_ACRESCIMO, 0) <> NVL(:new.VLR_ACRESCIMO, 0) then\n          VN_AUX_BASE := :new.VLR_TOTAL_PRODUTO;\n          VN_AUX_ALQ  := 0;\n          VN_AUX_CALC := :new.VLR_ACRESCIMO;\n        end if;\n\n        BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                               VN_AUX_BASE,\n                                               VN_AUX_CALC);\n        -- V_VLR_ZERO);\n\n        if VN_AUX_CALC = -1 then\n          VC_MSG_ERRO := 'Valores negativos no calculo do acrescimo!';\n        elsif VN_AUX_CALC = -2 then\n          VC_MSG_ERRO := 'Impossivel apurar valor do acrescimo!';\n        elsif VN_AUX_CALC = -3 then\n          VC_MSG_ERRO := 'Valor apurado de acrescimo diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n        else\n          :new.PER_ACRESCIMO := VN_AUX_ALQ;\n          :new.VLR_ACRESCIMO := VN_AUX_CALC;\n        end if;\n        if VC_MSG_ERRO is not null then\n          goto FIM;\n        end if;\n      end if;\n    end if;\n\n    -- Liquido de IPI\n    if NVL(:new.VLR_IPI, 0) < 0 then\n      VC_MSG_ERRO := 'Valor de IPI negativo!';\n      goto FIM;\n    end if;\n\n    -- Despesas Financeiras\n    if (NVL(:old.VLR_TOTAL_PRODUTO, 0) <> NVL(:new.VLR_TOTAL_PRODUTO, 0) or\n       NVL(:old.PER_DESPESAS_FINANCEIRAS, 0) <>\n       NVL(:new.PER_DESPESAS_FINANCEIRAS, 0) or\n       NVL(:old.VLR_DESPESAS_FINANCEIRAS, 0) <>\n       NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0)) and\n       (NVL(:new.PER_DESPESAS_FINANCEIRAS, 0) <> 0 or\n       NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0) <> 0) then\n\n      if NVL(:new.VLR_TOTAL_PRODUTO, 0) = 0 or\n         (NVL(:new.PER_DESPESAS_FINANCEIRAS, 0) = 0 and\n          NVL(:old.PER_DESPESAS_FINANCEIRAS, 0) <>\n          NVL(:new.PER_DESPESAS_FINANCEIRAS, 0)) then\n        :new.VLR_DESPESAS_FINANCEIRAS := 0;\n      elsif NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0) = 0 and\n            NVL(:old.VLR_DESPESAS_FINANCEIRAS, 0) <>\n            NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0) then\n        :new.PER_DESPESAS_FINANCEIRAS := 0;\n      else\n        if NVL(:old.PER_DESPESAS_FINANCEIRAS, 0) <>\n           NVL(:new.PER_DESPESAS_FINANCEIRAS, 0) or\n           NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0) = 0 or\n           NVL(:new.PER_DESPESAS_FINANCEIRAS, 0) > 0 then\n          VN_AUX_BASE := :new.VLR_TOTAL_PRODUTO;\n          VN_AUX_ALQ  := :new.PER_DESPESAS_FINANCEIRAS;\n          VN_AUX_CALC := 0;\n        elsif NVL(:old.VLR_DESPESAS_FINANCEIRAS, 0) <>\n              NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0) then\n          VN_AUX_BASE := :new.VLR_TOTAL_PRODUTO;\n          VN_AUX_ALQ  := 0;\n          VN_AUX_CALC := :new.VLR_DESPESAS_FINANCEIRAS;\n        end if;\n\n        BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                               VN_AUX_BASE,\n                                               VN_AUX_CALC);\n        --   V_VLR_ZERO);\n\n        if VN_AUX_CALC = -1 then\n          VC_MSG_ERRO := 'Valores negativos no calculo da despesa financeira!';\n        elsif VN_AUX_CALC = -2 then\n          VC_MSG_ERRO := 'Impossivel apurar valor da despesa financeira!';\n        elsif VN_AUX_CALC = -3 then\n          VC_MSG_ERRO := 'Valor apurado de despesa financeira diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n        else\n          :new.PER_DESPESAS_FINANCEIRAS := VN_AUX_ALQ;\n          :new.VLR_DESPESAS_FINANCEIRAS := VN_AUX_CALC;\n        end if;\n        if VC_MSG_ERRO is not null then\n          goto FIM;\n        end if;\n      end if;\n    end if;\n\n    -- Outras Despesas\n    if (NVL(:old.VLR_TOTAL_PRODUTO, 0) <> NVL(:new.VLR_TOTAL_PRODUTO, 0) or\n       NVL(:old.PER_OUTRAS_DESPESAS, 0) <>\n       NVL(:new.PER_OUTRAS_DESPESAS, 0) or\n       NVL(:old.VLR_OUTRAS_DESPESAS, 0) <>\n       NVL(:new.VLR_OUTRAS_DESPESAS, 0)) and\n       (NVL(:new.PER_OUTRAS_DESPESAS, 0) <> 0 or\n       NVL(:new.VLR_OUTRAS_DESPESAS, 0) <> 0) then\n\n      if NVL(:new.VLR_TOTAL_PRODUTO, 0) = 0 or\n         (NVL(:new.PER_OUTRAS_DESPESAS, 0) = 0 and\n          NVL(:old.PER_OUTRAS_DESPESAS, 0) <>\n          NVL(:new.PER_OUTRAS_DESPESAS, 0)) then\n        :new.VLR_OUTRAS_DESPESAS := 0;\n      elsif NVL(:new.VLR_OUTRAS_DESPESAS, 0) = 0 and\n            NVL(:old.VLR_OUTRAS_DESPESAS, 0) <>\n            NVL(:new.VLR_OUTRAS_DESPESAS, 0) then\n        :new.PER_OUTRAS_DESPESAS := 0;\n      else\n        if NVL(:old.PER_OUTRAS_DESPESAS, 0) <>\n           NVL(:new.PER_OUTRAS_DESPESAS, 0) or\n           NVL(:new.VLR_OUTRAS_DESPESAS, 0) = 0 or\n           NVL(:new.PER_OUTRAS_DESPESAS, 0) > 0 then\n          VN_AUX_BASE := :new.VLR_TOTAL_PRODUTO;\n          VN_AUX_ALQ  := :new.PER_OUTRAS_DESPESAS;\n          VN_AUX_CALC := 0;\n        elsif NVL(:old.VLR_OUTRAS_DESPESAS, 0) <>\n              NVL(:new.VLR_OUTRAS_DESPESAS, 0) then\n          VN_AUX_BASE := :new.VLR_TOTAL_PRODUTO;\n          VN_AUX_ALQ  := 0;\n          VN_AUX_CALC := :new.VLR_OUTRAS_DESPESAS;\n        end if;\n\n        BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                               VN_AUX_BASE,\n                                               VN_AUX_CALC);\n        -- V_VLR_ZERO);\n\n        if VN_AUX_CALC = -1 then\n          VC_MSG_ERRO := 'Valores negativos no calculo de outras despesas!';\n        elsif VN_AUX_CALC = -2 then\n          VC_MSG_ERRO := 'Impossivel apurar valor de outras despesas!';\n        elsif VN_AUX_CALC = -3 then\n          VC_MSG_ERRO := 'Valor apurado de outras despesas diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n        else\n          :new.PER_OUTRAS_DESPESAS := VN_AUX_ALQ;\n          :new.VLR_OUTRAS_DESPESAS := VN_AUX_CALC;\n        end if;\n        if VC_MSG_ERRO is not null then\n          goto FIM;\n        end if;\n      end if;\n    end if;\n\n    -- Substituic?o Tributaria\n    if NVL(:new.VLR_ICMS_SUBST, 0) < 0 then\n      VC_MSG_ERRO := 'Valor da substituic?o tributaria de ICMS negativa!';\n      goto FIM;\n    end if;\n\n    -- Calcula o valor liquido\n    :new.VLR_TOTAL := (:new.VLR_TOTAL_PRODUTO + -- Bruto\n                      :new.VLR_IPI + -- IPI\n                      :new.VLR_ACRESCIMO + -- Acrescimo\n                      :new.VLR_DESPESAS_FINANCEIRAS + -- Despesas financeiras\n                      :new.VLR_OUTRAS_DESPESAS + -- Outras despesas\n                      :new.VLR_ICMS_SUBST) - -- ICMS da substituic?o tributaria\n                      :new.VLR_DESCONTO; -- Desconto\n\n    if :new.VLR_TOTAL < 0 then\n      VC_MSG_ERRO := 'Verifique os valores! Valor liquido negativo.';\n      goto FIM;\n    end if;\n\n    -- Atualiza os campos da ordem\n    if not BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM then\n\n      if NVL(:new.VLR_TOTAL_PRODUTO, 0) <> NVL(:old.VLR_TOTAL_PRODUTO, 0) or\n         NVL(:new.VLR_IPI, 0) <> NVL(:old.VLR_IPI, 0) OR\n         NVL(:NEW.VLR_ICMS_SUBST, 0) <> NVL(:OLD.VLR_ICMS_SUBST, 0) or\n         :old.isactive <> :new.isactive then\n\n        BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM_IT := true;\n        IF :NEW.ISACTIVE = :OLD.ISACTIVE THEN\n          update BEG_CPR_ORDEM\n             SET VLR_TOTAL_PRODUTOS = VLR_TOTAL_PRODUTOS -\n                                      NVL(:old.VLR_TOTAL_PRODUTO, 0) +\n                                      NVL(:new.VLR_TOTAL_PRODUTO, 0),\n                 VLR_IPI            = VLR_IPI - NVL(:old.VLR_IPI, 0) +\n                                      NVL(:new.VLR_IPI, 0),\n                 VLR_ICMS_SUBST     = VLR_ICMS_SUBST -\n                                      NVL(:old.VLR_ICMS_SUBST, 0) +\n                                      NVL(:new.VLR_ICMS_SUBST, 0)\n           where BEG_CPR_ORDEM_ID = :new.BEG_CPR_ORDEM_ID;\n        ELSIF :NEW.ISACTIVE = 'Y' AND :OLD.ISACTIVE = 'N' THEN\n          update BEG_CPR_ORDEM\n             SET VLR_TOTAL_PRODUTOS = VLR_TOTAL_PRODUTOS +\n                                      NVL(:new.VLR_TOTAL_PRODUTO, 0),\n                 VLR_IPI            = VLR_IPI + NVL(:new.VLR_IPI, 0),\n                 VLR_ICMS_SUBST     = VLR_ICMS_SUBST +\n                                      NVL(:new.VLR_ICMS_SUBST, 0)\n           where BEG_CPR_ORDEM_ID = :new.BEG_CPR_ORDEM_ID;\n        ELSE\n          update BEG_CPR_ORDEM\n             SET VLR_TOTAL_PRODUTOS = VLR_TOTAL_PRODUTOS -\n                                      NVL(:old.VLR_TOTAL_PRODUTO, 0),\n                 VLR_IPI            = VLR_IPI - NVL(:old.VLR_IPI, 0),\n                 VLR_ICMS_SUBST     = VLR_ICMS_SUBST -\n                                      NVL(:old.VLR_ICMS_SUBST, 0)\n           where BEG_CPR_ORDEM_ID = :new.BEG_CPR_ORDEM_ID;\n        END IF;\n\n        BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM_IT := false;\n\n      end if;\n\n    END IF;\n  end if;\n  if updating and nvl(to_char(:old.dt_entrega_prevista,'DD/MM/RRRR'),'01/01/2020') = nvl(to_char(:new.dt_entrega_prevista,'DD/MM/RRRR'),'01/01/2020') then\n\n    if nvl(:new.vlr_unitario, 0) <> nvl(:old.vlr_unitario, 0) then\n\n      update beg_sup_lista_fornecedor l\n         set l.vlr_bruto                = :new.vlr_unitario,\n             l.alq_icms_subst           = :new.alq_icms_subst,\n             l.alq_ipi                  = :new.alq_ipi,\n             l.per_desconto             = :new.per_desconto,\n             l.per_despesas_financeiras = :new.per_despesas_financeiras,\n             l.per_outras_despesas      = :new.per_outras_despesas\n\n       WHERE l.beg_vw_fornecedor_id = :NEW.beg_vw_fornecedor_id\n         and l.beg_produto_id = :new.beg_produto_id\n         and l.beg_prd_sku_id = :new.beg_prd_sku_id\n         and l.isactive = 'Y';\n\n    end if;\n\n  end if;\n\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend BEG_TRG_BIUD_CPR_ORDEM_ITEM;\n"}`;
    
    }
}
