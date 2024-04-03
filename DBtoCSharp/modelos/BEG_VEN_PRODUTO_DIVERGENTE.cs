
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_PRODUTO_DIVERGENTE
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_VEN_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_ITEPED_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_NOVO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_TIPO_PEDIDO_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_PED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_LINHA_PEDIDO_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PRODUTO_DIVERGENTE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PEDIDO_CONFERIDO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_PEDIDO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00021 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n  v_id number(11);\n  V_OK char(2);\n\n  CURSOR C_PRODUTO IS\n    SELECT C.BEG_VEN_PEDIDO_ID\n      FROM BEG_VEN_PEDIDO_CONFERIDO C\n     WHERE C.BEG_VEN_PEDIDO_CONFERIDO_ID = :NEW.BEG_VEN_PEDIDO_CONFERIDO_ID;\n  --\n  R_PRODUTO C_PRODUTO%ROWTYPE;\n  --\n  CURSOR C_ITEM(P_BEG_VEN_PEDIDO_ID   NUMBER,\n                P_BEG_VW_PRD_PRECO_ID NUMBER,\n                P_BEG_PRD_SKU_ID      NUMBER) IS\n    SELECT LP.QUANTIDADE\n      FROM BEG_VEN_LINHA_PEDIDO LP\n     WHERE LP.BEG_VEN_PEDIDO_ID = P_BEG_VEN_PEDIDO_ID\n       AND LP.BEG_VW_PRD_PRECO_ID = P_BEG_VW_PRD_PRECO_ID\n       AND LP.BEG_PRD_SKU_ID = P_BEG_PRD_SKU_ID;\n\n  cursor busca_pedido is\n    select p.*, pe.email\n      from beg_ven_pedido p, BEG_VEN_PEDIDO_CONFERIDO PC, beg_pessoa pe\n     where p.beg_ven_pedido_id = PC.BEG_VEN_PEDIDO_ID\n       AND pe.beg_pessoa_id = p.beg_vw_cliente_id\n       AND PC.BEG_VEN_PEDIDO_CONFERIDO_ID =\n           :new.beg_ven_pedido_conferido_id;\n  ---\n  V_PEDIDO BUSCA_PEDIDO%ROWTYPE;\n\n  cursor busca_pedido2 is\n    select p.beg_ven_pedido_id\n      from beg_ven_pedido p\n     where p.beg_vw_cliente_id = V_PEDIDO.BEG_VW_CLIENTE_ID\n       and p.dt_entrega = :NEW.DT_NOVO\n       and p.beg_ven_tipo_pedido_id = V_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID\n       and p.beg_ger_divisao_pedido_id = V_PEDIDO.BEG_GER_DIVISAO_PEDIDO_ID\n       and p.IMPRESSO = 'N'\n       AND NVL(p.DOCSTATUS, 'IP') <> 'CO'\n       and not exists\n     (select 1\n              from beg_ven_pedido_conferido pc\n             where pc.beg_ven_pedido_id = p.beg_ven_pedido_id);\n  V_PEDIDO2 BUSCA_PEDIDO2%ROWTYPE;\n\n  ---\n  cursor c_prod is\n    select PR.*\n      from beg_produto pr\n     where pr.beg_produto_id = :new.beg_produto_id;\n  R_PROD C_PROD%rowtype;\n  --\n  cursor busca_pedido3 is\n    select P.DT_ENTREGA\n      from beg_ven_pedido p\n     where p.beg_ven_pedido_id = :NEW.BEG_VW_VEN_PEDIDO_ID;\n  V_PEDIDO3 busca_pedido3%rowtype;\n\n  ---\n  cursor c_ite is\n    select it.*\n      from die_iteped it\n     where it.die_iteped_id = :NEW.DIE_ITEPED_ID;\n  R_ITE C_ITE%rowtype;\n\n  --\nbegin\n  --\n  IF (UPDATING AND :OLD.ISACTIVE='N' AND :NEW.ISACTIVE ='Y') or (inserting and :new.isactive='Y') THEN\n    \n    OPEN C_PRODUTO;\n    FETCH C_PRODUTO\n      INTO R_PRODUTO;\n    CLOSE C_PRODUTO;\n    OPEN C_ITEM(R_PRODUTO.BEG_VEN_PEDIDO_ID,\n                :NEW.BEG_PRODUTO_ID,\n                :NEW.BEG_PRD_SKU_ID);\n    FETCH C_ITEM\n      INTO :NEW.QTD_PEDIDO;\n    CLOSE C_ITEM;\n  \n    --\n    if :new.qtd > 0 then\n    \n      OPEN C_PRODUTO;\n      FETCH C_PRODUTO\n        INTO R_PRODUTO;\n      CLOSE C_PRODUTO;\n    \n      OPEN BUSCA_PEDIDO;\n      FETCH BUSCA_PEDIDO\n        INTO V_PEDIDO;\n      CLOSE BUSCA_PEDIDO;\n    \n      if NVL(:NEW.beg_ven_tipo_pedido_id,V_PEDIDO.beg_ven_tipo_pedido_id) <> 2000019 /*and\n         :new.qtd <= :new.qtd_pedido*/ then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Tipo de pedido so permite transferir a data da entrega. Para exclusao solicite ajuda a setor de TI ');\n      end if;\n\n    end if;\n    \n      IF :NEW.BEG_VW_VEN_PEDIDO_ID IS NULL AND :NEW.DT_NOVO IS NULL AND NVL(:NEW.beg_ven_tipo_pedido_id,V_PEDIDO.beg_ven_tipo_pedido_id) <> 2000019 THEN\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Faltou informar numero novo pedido ou data novo pedido '); \n      END IF;\n    --        \n      IF :NEW.BEG_VW_VEN_PEDIDO_ID IS NOT NULL AND :NEW.DT_NOVO IS NOT NULL AND NVL(:NEW.beg_ven_tipo_pedido_id,V_PEDIDO.beg_ven_tipo_pedido_id) <> 2000019 THEN\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Informar somente uma das opçoes numero novo pedido ou data novo pedido '); \n      END IF;\n    --\n    IF :NEW.BEG_VW_VEN_PEDIDO_ID IS NOT NULL AND :NEW.DT_NOVO IS NULL THEN\n    \n      OPEN C_ITE;\n      FETCH C_ITE\n        INTO R_ITE;\n      CLOSE c_ite;\n    \n      if :new.die_iteped_id is null and\n         NVL(:NEW.beg_ven_tipo_pedido_id,V_PEDIDO.beg_ven_tipo_pedido_id) <> 2000019 then\n        RAISE_APPLICATION_ERROR(-20002,\n                                'Favor informar o numero do pedido original da loja.');\n      end if;\n      --\n      OPEN C_PRODUTO;\n      FETCH C_PRODUTO\n        INTO R_PRODUTO;\n      CLOSE C_PRODUTO;\n      --\n      OPEN C_PROD;\n      FETCH C_PROD\n        INTO R_PROD;\n      CLOSE C_PROD;\n    \n      --\n      OPEN BUSCA_PEDIDO;\n      FETCH BUSCA_PEDIDO\n        INTO V_PEDIDO;\n      CLOSE BUSCA_PEDIDO;\n      --\n      OPEN BUSCA_PEDIDO3;\n      FETCH BUSCA_PEDIDO3\n        INTO V_PEDIDO3;\n      CLOSE BUSCA_PEDIDO3;\n    \n      UPDATE BEG_VEN_LINHA_PEDIDO LP\n         SET LP.BEG_VEN_PEDIDO_ID = :NEW.BEG_VW_VEN_PEDIDO_ID\n       WHERE /*LP.BEG_VEN_PEDIDO_ID = R_PRODUTO.BEG_VEN_PEDIDO_ID\n         AND LP.BEG_VW_PRD_PRECO_ID = :NEW.BEG_PRODUTO_ID\n         AND LP.BEG_PRD_SKU_ID = :NEW.BEG_PRD_SKU_ID\n            --     AND LP.UPDATEDBY = :NEW.UPDATEDBY\n         and nvl(lp.die_iteped_id, 0) = nvl(:new.die_iteped_id, 0)*/\n         lp.beg_ven_linha_pedido_id = :new.beg_ven_linha_pedido_id;\n    \n      beg_prc_mail('reservas.f15@diementz.com.br',\n                   /*'replicacao@diementz.com.br',--*/\n                   V_PEDIDO.EMAIL,\n                   'Produto faltante ',\n                   'O produto  ' || r_prod.die_cod_estruturado ||\n                   ' do pedido de venda numero: ' || R_ITE.VALUE ||\n                   ' do dia  ' || R_ITE.dtemissao ||\n                   ' com previsao de entrega p/ ' || r_ite.preventreg ||\n                   ' foi transferido a entrega para o dia ' ||\n                   V_PEDIDO3.DT_ENTREGA ||\n                   '  por indisponibilidade em estoque. ' || CHR(13) ||\n                   CHR(13) || 'Em caso de duvidas contatar o deposito.' ||\n                   CHR(13) || CHR(13) || 'Atenciosamente' || CHR(13) ||\n                   'Equipe deposito',\n                   V_OK);\n    end if;\n  \n    if :NEW.BEG_VW_VEN_PEDIDO_ID is null AND :NEW.DT_NOVO IS NOT NULL THEN\n    \n      if :new.dt_novo <= trunc(sysdate) then\n        RAISE_APPLICATION_ERROR(-20002,\n                                'Data do novo pedido tem que ser maior que data do dia.');\n      end if;\n    \n      OPEN BUSCA_PEDIDO;\n      FETCH BUSCA_PEDIDO\n        INTO V_PEDIDO;\n      CLOSE BUSCA_PEDIDO;\n    \n      --------\n      OPEN BUSCA_PEDIDO2;\n      FETCH BUSCA_PEDIDO2\n        INTO V_PEDIDO2;\n    \n      if :new.die_iteped_id is null and\n         NVL(:NEW.beg_ven_tipo_pedido_id,V_PEDIDO.beg_ven_tipo_pedido_id) <> 2000019 then\n        RAISE_APPLICATION_ERROR(-20002,\n                                'Favor informar o numero do pedido original da loja.');\n      end if;\n    \n      IF BUSCA_PEDIDO2%FOUND THEN\n        RAISE_APPLICATION_ERROR(-20002,\n                                'Já existe pedido para este dia favor informar o pedido e nao a data.');\n      END IF;\n      CLOSE BUSCA_PEDIDO2;\n      ----------\n    \n      --\n      -- INSERE PEDIDO\n      --\n    \n      v_id := beg_fnc_ad_sequence('BEG_VEN_PEDIDO');\n      insert into beg_ven_pedido\n        (beg_ven_pedido_id,\n         ad_client_id,\n         ad_org_id,\n         isactive,\n         value,\n         created,\n         createdby,\n         updated,\n         updatedby,\n         dt_emissao,\n         dt_entrega,\n         obs,\n         beg_ven_tipo_pedido_id,\n         beg_ven_forma_cobranca_id,\n         beg_ven_tabela_preco_id,\n         beg_ven_forma_pagamento_id,\n         beg_condicao_pagamento_id,\n         beg_ven_plano_venda_id,\n         beg_vw_pessoa_entrega_id,\n         beg_vw_pessoa_cobranca_id,\n         beg_vw_transportadora_id,\n         beg_vw_representante_id,\n         beg_vw_cliente_id,\n         plano_editavel,\n         docstatus,\n         tp_frete,\n         vlr_frete,\n         impresso,\n         serie,\n         num_nf,\n         faturado,\n         nf_emitida,\n         beg_vw_preposto_id,\n         partes,\n         num_volumes,\n         beg_vw_ven_pedido_id,\n         beg_vw_televenda_id,\n         beg_cidade_id,\n         bairro,\n         endereco,\n         cep,\n         complementar,\n         peso,\n         msg_erro_aprovacao,\n         responsavel_venda,\n         endereco_entrega,\n         pessoa_cobranca,\n         vlr_total,\n         beg_fro_rota_id,\n         pedido_externo,\n         obs_credito,\n         tp_cadastro,\n         ind_cliente_filial,\n         beg_ven_com_regra_id,\n         comissao,\n         nro_ordem_compra,\n         representante_padrao,\n         televendedor_padrao,\n         msg_obs,\n         beg_ger_divisao_pedido_id)\n      values\n        (v_id,\n         1000000,\n         1000016,\n         'Y',\n         SEQ_PEDIDO.NEXTVAL, --:NEW.VALUE,\n         SYSDATE,\n         1000000,\n         SYSDATE,\n         1000000,\n         TRUNC(SYSDATE),\n         :NEW.DT_NOVO,\n         NULL,\n         V_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID,\n         2000001,\n         NULL,\n         2000013,\n         2000001,\n         NULL,\n         V_PEDIDO.BEG_VW_CLIENTE_ID,\n         V_PEDIDO.BEG_VW_CLIENTE_ID,\n         NULL,\n         NULL,\n         V_PEDIDO.BEG_VW_CLIENTE_ID,\n         'N',\n         'AP',\n         'F',\n         0,\n         'Y',\n         NULL,\n         NULL,\n         'N',\n         'N',\n         NULL,\n         1,\n         NULL,\n         NULL,\n         NULL,\n         V_PEDIDO.beg_cidade_id,\n         V_PEDIDO.bairro,\n         V_PEDIDO.endereco,\n         V_PEDIDO.cep,\n         'N', -- complementar\n         0,\n         NULL,\n         NULL,\n         'N',\n         'N',\n         0,\n         NULL,\n         NULL,\n         NULL,\n         'P', -- tp_cadastro\n         'N',\n         NULL,\n         0,\n         NULL,\n         NULL,\n         NULL,\n         NULL,\n         V_PEDIDO.beg_ger_divisao_pedido_id);\n      NULL;\n    \n      OPEN C_PRODUTO;\n      FETCH C_PRODUTO\n        INTO R_PRODUTO;\n      CLOSE C_PRODUTO;\n      --\n      OPEN C_PROD;\n      FETCH C_PROD\n        INTO R_PROD;\n      CLOSE C_PROD;\n    \n      --\n      OPEN BUSCA_PEDIDO3;\n      FETCH BUSCA_PEDIDO3\n        INTO V_PEDIDO3;\n      CLOSE BUSCA_PEDIDO3;\n      --\n      OPEN C_ITE;\n      FETCH C_ITE\n        INTO R_ITE;\n      CLOSE c_ite;\n      --\n      UPDATE BEG_VEN_LINHA_PEDIDO LP\n         SET LP.BEG_VEN_PEDIDO_ID = v_id\n       WHERE /*LP.BEG_VEN_PEDIDO_ID = R_PRODUTO.BEG_VEN_PEDIDO_ID\n         AND LP.BEG_VW_PRD_PRECO_ID = :NEW.BEG_PRODUTO_ID\n         AND LP.BEG_PRD_SKU_ID = :NEW.BEG_PRD_SKU_ID\n            --       AND LP.UPDATEDBY = :NEW.UPDATEDBY\n         and nvl(lp.die_iteped_id, 0) = nvl(:new.die_iteped_id, 0)*/\n         lp.beg_ven_linha_pedido_id = :NEW.BEG_VEN_LINHA_PEDIDO_ID\n      /*AND NVL(LP.DIE_ITEPED_ID,-1) = NVL(:NEW.DIE_ITEPED_ID,-1)*/\n      ;\n    \n      ---\n      beg_prc_mail('reservas.f15@diementz.com.br',\n                   /*'replicacao@diementz.com.br',--*/\n                   V_PEDIDO.EMAIL,\n                   'Produto faltante ',\n                   'O produto  ' || r_prod.die_cod_estruturado ||\n                   ' do pedido de venda numero: ' || R_ITE.VALUE ||\n                   ' do dia ' || R_ITE.dtemissao ||\n                   ' com previsao de entrega p/ ' || r_ite.preventreg ||\n                   ' foi transferido a entrega para o dia ' || :new.dt_novo ||\n                   '  por indisponibilidade em estoque. ' || CHR(13) ||\n                   CHR(13) || 'Em caso de duvidas contatar o deposito.' ||\n                   CHR(13) || CHR(13) || 'Atenciosamente' || CHR(13) ||\n                   'Equipe deposito',\n                   V_OK);\n      ---\n    END IF;\n  \n  END IF;\n  --\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n"}`;
    
    }
}
