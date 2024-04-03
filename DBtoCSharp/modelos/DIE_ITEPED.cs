
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_ITEPED
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CDGARANTIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CDVENDAGAR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRECOGAR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string MONTAGEM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VALORDESC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERCDESC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRECOFINAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPOPRECO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TPENTREGA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PREVENTREG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTMONTAGEM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(35)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTADO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_VP { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_PROC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_GARANTIA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_PROMOCAO_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// D = Disponivel no CD, P = Previsão de chegada
        /// </summary>
        public string TP_RESERVA { get; set; }
        
        /// <summary>
        /// Data de previsao de chegada do produto no cd quando tp_reserva for P
        /// </summary>
        public string DT_PREV_CHEGADA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLTF { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DESC_EXTRA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLTF_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_ITEPED_LOJA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_LINHA_PEDIDO_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string PLANO_CEL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DIE_COD_ESTRUTURADO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_ITEPED_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTDEATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLUNITARIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_COD_ESPECIAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TPGARANTIA { get; set; }

        [NotMapped]
        public string Trigger_TRG_BI_DIE_ITEPED_1 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  cursor c1 is\n  \n    SELECT DIE_FNC_CST_VALOR(1000016, P.DIE_COD_ESTRUTURADO) vlr_lista\n    \n      FROM beg_produto p\n     where p.beg_produto_id = :NEW.Beg_Produto_Id;\n\n  r1 c1%rowtype;\n\n  cursor c2 is\n  \n    select * from die_pedido p where p.die_pedido_id = :new.die_pedido_id;\n  r2 c2%rowtype;\n\n  CURSOR C3 IS\n    SELECT P.BEG_PRODUTO_ID, SD.BEG_PRD_SITUACAO_ID\n      FROM BEG_PRODUTO P, BEG_PRD_SKU_DETALHE SD\n     WHERE P.BEG_PRODUTO_ID = SD.BEG_PRODUTO_ID\n       AND SD.ISACTIVE='Y'\n       AND P.DIE_COD_ESTRUTURADO = :NEW.DIE_COD_ESTRUTURADO\n       AND P.ISACTIVE='Y';\n  R3 C3%rowtype;\n\n  CURSOR C4 IS\n    SELECT P.BEG_PRODUTO_ID\n      FROM BEG_PRODUTO P\n     WHERE P.DIE_COD_ESTRUTURADO = UPPER(:NEW.DIE_COD_ESTRUTURADO)\n       and p.die_vw_prd_pai_id is NOT null\n       AND P.ISACTIVE='Y'\n    union all\n    SELECT P.BEG_PRODUTO_ID\n      FROM BEG_PRODUTO P\n     WHERE P.DIE_COD_ESTRUTURADO = UPPER(:NEW.DIE_COD_ESTRUTURADO)\n          --       and p.controla_voltagem ='N'\n       AND P.CONTROLA_COR = 'N'\n       AND P.DIE_COD_ESTRUTURADO NOT LIKE 'D991%'\n       AND P.DIE_COD_ESTRUTURADO NOT LIKE 'D993%'\n       AND P.DIE_COD_ESTRUTURADO NOT LIKE 'D992%'\n       AND P.ISACTIVE='Y';\n\n  R4 C4%ROWTYPE;\n\nbegin\n\n  :NEW.DIE_COD_ESTRUTURADO := UPPER(:NEW.DIE_COD_ESTRUTURADO);\n\n  OPEN C3;\n  FETCH C3\n    INTO R3;\n  CLOSE C3;\n\n  IF R3.BEG_PRD_SITUACAO_ID = 2000004 THEN\n    raise_application_error(-20501,\n                            'Produto liquidado, não permite movimento. Verifique!!');\n  \n  END IF;\n\n  if inserting then\n    if :new.die_cod_estruturado is not null then\n    \n      IF :NEW.QTDE IS NULL THEN\n        :NEW.QTDE := 0;\n      END IF;\n    \n     IF :NEW.BEG_PRODUTO_ID IS NULL THEN \n       \n      OPEN C4;\n      FETCH C4\n        INTO R4;\n      CLOSE C4;\n    \n      :NEW.BEG_PRODUTO_ID := R4.BEG_PRODUTO_ID;\n      \n     END IF; \n    \n      if nvl(:new.vlunitario, 0) = 0 then\n        OPEN C1;\n        FETCH C1\n          INTO R1;\n        CLOSE C1;\n      \n        :new.vlunitario := NVL(r1.vlr_lista, 0);\n      end if;\n    \n      :new.die_cod_estruturado := UPPER(:NEW.DIE_COD_ESTRUTURADO);\n    end if;\n  end if;\n\n  /*  OPEN C2;\n  FETCH C2\n    INTO R2;\n  CLOSE C2;\n  \n  IF INSERTING THEN\n  \n    IF R2.DOCSTATUS = 'IP' THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Pedido ja aprovado, não permite incluir novo item!');\n    ELSIF R2.DOCSTATUS = 'CA' THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Pedido cancelado não permite incluir novo item!');\n    ELSIF R2.DOCSTATUS = 'CO' THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Pedido ja faturado não permite incluir novo item!');\n    END IF;\n  END IF;*/\n\n  if :new.die_cod_estruturado like 'D%' and\n     r2.beg_ven_tipo_pedido_id not in (2000015, 2000014, 2000004, 2000031) then\n  \n    raise_application_error(-20501,\n                            'Produtos do grupo D nao podem ser emitidos para este tipo de pedido. Verifique!!');\n  end if;\n\n  if :new.die_cod_estruturado like 'D%' and\n     r2.beg_ven_tipo_pedido_id in (2000015, 2000014, 2000004, 2000031) then\n  \n    if :new.die_cod_estruturado not like 'D999%' then\n      raise_application_error(-20501,\n                              'Transferencia de ativo imobilizado somente permitido nos codigos D999. Verifique!!');\n    end if;\n  \n  end if;\n\n  if :new.die_cod_estruturado not like 'D%' and\n     r2.beg_ven_tipo_pedido_id in (2000015, 2000014) then\n  \n    raise_application_error(-20501,\n                            'Produtos diferente do grupo D nao podem ser emitidos para este tipo de pedido. Verifique!!');\n  \n  end if;\n\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BI_DIE_ITEPED { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n  CURSOR C_PROD IS\n  \n    SELECT P.*\n      FROM BEG_PRODUTO P\n     WHERE P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n\n  R_PROD C_PROD%ROWTYPE;\n\n  CURSOR C_PED IS\n    SELECT PE.*\n      FROM DIE_PEDIDO PE\n     WHERE PE.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n\nBEGIN\n\n  IF INSERTING /*OR UPDATING*/ THEN\n    OPEN C_PROD;\n    FETCH C_PROD\n      INTO R_PROD;\n    CLOSE C_PROD;\n  \n    IF R_PROD.DIE_COD_ESTRUTURADO LIKE 'S%' THEN\n      UPDATE DIE_PEDIDO PE\n         SET PE.SEGUROS = nvl(pe.seguros, 0) + (:NEW.QTDE * :NEW.VLUNITARIO) -\n                          :NEW.DESCONTO\n       WHERE PE.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n    END IF;\n--Valdir wem 05/10/2022  Codigo 000 e 999\n IF  R_PROD.ind_especial = 'Y' and R_PROD.die_cod_produto in ('000','999') THEN\n  raise_application_error(-20501,\n                          'Produto cadastrado como codigo especial não permite movimento.');\nEND IF;     \n    \n  END IF;\n  \n   IF UPDATING AND NVL(:NEW.IND_PROC,'N')='N' THEN \n     UPDATE DIE_PEDIDO PE\n       SET PE.VLMERC = NVL(PE.VLMERC,0) - (NVL(:OLD.QTDE,0) * NVL(:OLD.VLUNITARIO,0)) + (NVL(:NEW.QTDE,0) * NVL(:NEW.VLUNITARIO,0)),\n          -- PE.DESCONTO = NVL(PE.DESCONTO,0) - NVL(:OLD.DESCONTO,0) + NVL(:NEW.DESCONTO,0),\n           pe.vlgarantia = nvl(pe.vlgarantia,0) - nvl(:old.precogar,0) +  nvl(:new.precogar,0)\n     WHERE PE.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n     \n   END IF;\n   \n   IF DELETING THEN \n     UPDATE DIE_PEDIDO PE\n       SET PE.VLMERC = NVL(PE.VLMERC,0) - (NVL(:OLD.QTDE,0) * NVL(:OLD.VLUNITARIO,0)) ,\n          -- PE.DESCONTO = NVL(PE.DESCONTO,0) - NVL(:OLD.DESCONTO,0) + NVL(:NEW.DESCONTO,0),\n           pe.vlgarantia = nvl(pe.vlgarantia,0) - nvl(:old.precogar,0)\n     WHERE PE.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n     \n   END IF;\n\nEND TRG_BI_DIE_ITEPED;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BID_DIE_ITEPED { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n  VC_TPENTREGA VARCHAR2(2);\n  V_SKU_ID     NUMBER(10);\n  --\n  CURSOR BUSCA_POSICAO IS\n    SELECT NVL(r.beg_ger_divisao_pedido_id, 2000000) beg_ger_divisao_pedido_id\n      FROM BEG_PRD_SKU s, BEG_PRD_SKU_DETALHE SD, Beg_Ger_Rua_Divisao r\n     WHERE S.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID\n          --AND    S.PADRAO = 'Y'\n       AND SD.BEG_PRD_SKU_ID = S.BEG_PRD_SKU_ID\n       AND SD.AD_ORG_ID = 0\n       AND SD.posicao_fisica between r.rua_inicial and\n           nvl(r.rua_final, r.rua_inicial);\n  ---\n  V_POSICAO BUSCA_POSICAO%ROWTYPE;\n  --\n  CURSOR BUSCA_CLIENTE IS\n    SELECT F.BEG_PESSOA_ID, P.CEP, P.BAIRRO, P.ENDERECO, P.BEG_CIDADE_ID\n      FROM BEG_DADO_FILIAL F, BEG_PESSOA P\n     WHERE F.AD_ORG_ID = :NEW.AD_ORG_ID\n       AND P.BEG_PESSOA_ID = F.BEG_PESSOA_ID;\n  --\n  V_CLIENTE BUSCA_CLIENTE%ROWTYPE;\n  --\n  cursor busca_pedido is\n    select p.beg_ven_pedido_id, min(p.dt_entrega)\n      from beg_ven_pedido p, beg_dado_filial df\n     where df.ad_org_id = :NEW.AD_ORG_ID\n       and p.beg_vw_cliente_id = df.beg_pessoa_id\n          --    and    p.dt_entrega = NVL(:NEW.PREVENTREG,TRUNC(SYSDATE)+1)\n          -- and p.dt_entrega >= TRUNC(SYSDATE)\n       and p.beg_ven_tipo_pedido_id =\n           DECODE(:NEW.TPENTREGA,\n                  'DE',\n                  beg_fnc_retorna_parametro(1000000,\n                                            0,\n                                            'Vendas',\n                                            null,\n                                            'PEDIDO_VENDA'),\n                  beg_fnc_retorna_parametro(1000000,\n                                            0,\n                                            'Vendas',\n                                            null,\n                                            'PEDIDO_LOJA'))\n       and p.beg_ger_divisao_pedido_id =\n           NVL(V_POSICAO.beg_ger_divisao_pedido_id, 2000000)\n       and p.dt_emissao >= to_date('01/01/2020', 'dd/mm/rrrr')\n       and p.impresso = 'N'\n       and not exists\n     (select 1\n              from beg_ven_pedido_conferido pc\n             where pc.beg_ven_pedido_id = p.beg_ven_pedido_id)\n       and not exists\n     (select 1\n              from beg_fat_nfs nf\n             where nf.beg_ven_pedido_id = p.beg_ven_pedido_id)\n     group by p.beg_ven_pedido_id\n     ORDER BY 2;\n  ---\n  V_PEDIDO BUSCA_PEDIDO%ROWTYPE;\n  --  \n  cursor busca_pedido1 is\n    select p.beg_ven_pedido_id\n      from beg_ven_pedido p, BEG_VEN_LINHA_PEDIDO L\n     where p.beg_ven_pedido_id = L.BEG_VEN_PEDIDO_ID\n       AND L.BEG_VEN_LINHA_PEDIDO_ID = :NEW.BEG_VEN_LINHA_PEDIDO_ID\n       and not exists\n     (select 1\n              from beg_ven_pedido_conferido pc\n             where pc.beg_ven_pedido_id = p.beg_ven_pedido_id);\n  ---\n  V_PEDIDO1 BUSCA_PEDIDO1%ROWTYPE;\n\n  CURSOR BUSCA_PRODUTO IS\n    SELECT P.BEG_PRODUTO_ID, S.BEG_PRD_SKU_ID, P.DESC_RESUMIDA\n      FROM BEG_PRODUTO P, BEG_PRD_SKU S\n     WHERE P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID\n       AND S.BEG_PRODUTO_ID = P.BEG_PRODUTO_ID\n       AND S.PADRAO = 'Y';\n  --\n  V_PRODUTO BUSCA_PRODUTO%ROWTYPE;\n  --\n  CURSOR BUSCA_PROPOSTA IS\n    SELECT NVL(P.SITUACAO, 'N') SITUACAO, NVL(P.LIBERADO, 'N') LIBERADO\n      FROM DIE_PEDIDO P\n     WHERE P.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n  --\n  V_SITUACAO VARCHAR2(1);\n  V_LIBERADO VARCHAR2(1);\n  --\n  CURSOR BUSCA_ESTOQUE IS\n    SELECT E.QTD - E.QTD_RESERVADA QTD_DISPONIVEL\n      FROM BEG_ESTOQUE E\n     WHERE E.BEG_EST_ALMOXARIFADO_ID =\n           beg_fnc_retorna_parametro(:NEW.AD_CLIENT_ID,\n                                     1000016,\n                                     'Vendas',\n                                     'Faturamento',\n                                     'ALMOXARIFADO FATURAMENTO')\n       AND E.BEG_PRODUTO_ID = V_PRODUTO.BEG_PRODUTO_ID\n       AND E.BEG_PRD_SKU_ID = V_PRODUTO.BEG_PRD_SKU_ID;\n  --\n  V_ESTOQUE NUMBER(18, 4);\n  --\n  cursor ver_linha is\n    select 1 linha\n      from beg_ven_linha_pedido l\n     where l.die_iteped_id = :new.die_iteped_id;\n  -- \n  v_item ver_linha%rowtype;\n  --\n  v_id_linha  number(10);\n  v_tp_ped_id number(10);\nbegin\n  IF NVL(:OLD.IND_PROC,'N') = NVL(:NEW.IND_PROC,'N') THEN\n    OPEN BUSCA_PROPOSTA;\n    FETCH BUSCA_PROPOSTA\n      INTO V_SITUACAO, V_LIBERADO;\n    CLOSE BUSCA_PROPOSTA;\n  \n    IF V_LIBERADO = 'S' AND V_SITUACAO <> 'C' THEN\n      OPEN BUSCA_POSICAO;\n      FETCH BUSCA_POSICAO\n        INTO V_POSICAO;\n      CLOSE BUSCA_POSICAO;\n      --\n      VC_TPENTREGA := :NEW.TPENTREGA;\n      --\n      IF :NEW.TPENTREGA IN ('DE', 'DR') AND :NEW.PREVENTREG > TRUNC(SYSDATE) THEN\n        OPEN BUSCA_PEDIDO;\n        FETCH BUSCA_PEDIDO\n          INTO V_PEDIDO;\n        CLOSE BUSCA_PEDIDO;\n        --  IF BUSCA_PEDIDO%notfound  THEN\n        IF V_PEDIDO.BEG_VEN_PEDIDO_ID IS NULL THEN\n        \n          OPEN BUSCA_CLIENTE;\n          FETCH BUSCA_CLIENTE\n            INTO V_CLIENTE;\n          CLOSE BUSCA_CLIENTE;\n          --\n          -- INSERE PEDIDO\n          --\n          V_PEDIDO.BEG_VEN_PEDIDO_ID := beg_fnc_ad_sequence('BEG_VEN_PEDIDO');\n          v_tp_ped_id := case\n                           when :NEW.TPENTREGA = 'DE' then\n                            beg_fnc_retorna_parametro(1000000,\n                                                      0,\n                                                      'Vendas',\n                                                      null,\n                                                      'PEDIDO_VENDA')\n                           else\n                            beg_fnc_retorna_parametro(1000000,\n                                                      0,\n                                                      'Vendas',\n                                                      null,\n                                                      'PEDIDO_LOJA')\n                         end;\n          insert into beg_ven_pedido\n            (beg_ven_pedido_id,\n             ad_client_id,\n             ad_org_id,\n             isactive,\n             value,\n             created,\n             createdby,\n             updated,\n             updatedby,\n             dt_emissao,\n             dt_entrega,\n             obs,\n             beg_ven_tipo_pedido_id,\n             beg_ven_forma_cobranca_id,\n             beg_ven_tabela_preco_id,\n             beg_ven_forma_pagamento_id,\n             beg_condicao_pagamento_id,\n             beg_ven_plano_venda_id,\n             beg_vw_pessoa_entrega_id,\n             beg_vw_pessoa_cobranca_id,\n             beg_vw_transportadora_id,\n             beg_vw_representante_id,\n             beg_vw_cliente_id,\n             plano_editavel,\n             docstatus,\n             tp_frete,\n             vlr_frete,\n             impresso,\n             serie,\n             num_nf,\n             faturado,\n             nf_emitida,\n             beg_vw_preposto_id,\n             partes,\n             num_volumes,\n             beg_vw_ven_pedido_id,\n             beg_vw_televenda_id,\n             beg_cidade_id,\n             bairro,\n             endereco,\n             cep,\n             complementar,\n             peso,\n             msg_erro_aprovacao,\n             responsavel_venda,\n             endereco_entrega,\n             pessoa_cobranca,\n             vlr_total,\n             beg_fro_rota_id,\n             pedido_externo,\n             obs_credito,\n             tp_cadastro,\n             ind_cliente_filial,\n             beg_ven_com_regra_id,\n             comissao,\n             nro_ordem_compra,\n             representante_padrao,\n             televendedor_padrao,\n             msg_obs,\n             beg_ger_divisao_pedido_id)\n          values\n            (V_PEDIDO.BEG_VEN_PEDIDO_ID,\n             :NEW.ad_client_id,\n             1000016,\n             'Y',\n             SEQ_PEDIDO.NEXTVAL, --:NEW.VALUE,\n             SYSDATE,\n             1000000,\n             SYSDATE,\n             1000000,\n             :NEW.DTEMISSAO,\n             NVL(:NEW.PREVENTREG, TRUNC(SYSDATE) + 1),\n             NULL,\n             v_tp_ped_id,\n             2000001,\n             NULL,\n             2000013,\n             2000001,\n             NULL,\n             V_CLIENTE.BEG_PESSOA_ID,\n             V_CLIENTE.BEG_PESSOA_ID,\n             NULL,\n             NULL,\n             V_CLIENTE.BEG_PESSOA_ID,\n             'N',\n             'AP',\n             'F',\n             0,\n             'Y',\n             NULL,\n             NULL,\n             'N',\n             'N',\n             NULL,\n             1,\n             NULL,\n             NULL,\n             NULL,\n             V_CLIENTE.beg_cidade_id,\n             V_CLIENTE.bairro,\n             V_CLIENTE.endereco,\n             V_CLIENTE.cep,\n             'N', -- complementar\n             0,\n             NULL,\n             NULL,\n             'N',\n             'N',\n             0,\n             NULL,\n             NULL,\n             NULL,\n             'P', -- tp_cadastro\n             'N',\n             NULL,\n             0,\n             NULL,\n             NULL,\n             NULL,\n             NULL,\n             NVL(v_POSICAO.beg_ger_divisao_pedido_id, 2000000));\n          NULL;\n        END IF;\n        --    CLOSE BUSCA_PEDIDO;\n        --\n        v_id_linha                   := beg_fnc_ad_sequence('BEG_VEN_LINHA_PEDIDO');\n        :new.beg_ven_linha_pedido_id := v_id_linha;\n        open ver_linha;\n        fetch ver_linha\n          into v_item;\n        if ver_linha%notfound then\n          OPEN BUSCA_PRODUTO;\n          FETCH BUSCA_PRODUTO\n            INTO V_PRODUTO;\n          CLOSE BUSCA_PRODUTO;\n          insert into beg_ven_linha_pedido\n            (beg_ven_linha_pedido_id,\n             ad_client_id,\n             ad_org_id,\n             isactive,\n             value,\n             created,\n             createdby,\n             updated,\n             updatedby,\n             desc_linha_pedido,\n             quantidade,\n             vl_unitario,\n             dt_entrega,\n             nro_ordem_compra,\n             obs,\n             beg_ven_pedido_id,\n             beg_prd_sku_id,\n             beg_vw_prd_preco_id,\n             altera_descricao,\n             qtd_faltante,\n             vlr_unit_sugerido,\n             comissao,\n             qtd_disponivel,\n             percentual_comissao,\n             die_iteped_id,\n             beg_ven_tipo_pedido_id,\n             tp_ped)\n          values\n            (v_id_linha,\n             :NEW.ad_client_id,\n             1000016,\n             'Y',\n             NULL,\n             SYSDATE,\n             1000000,\n             SYSDATE,\n             1000000,\n             V_PRODUTO.DESC_RESUMIDA,\n             :NEW.QTDE,\n             beg_fnc_cst_valor(1000016,\n                               V_PRODUTO.BEG_PRODUTO_ID,\n                               V_PRODUTO.BEG_PRD_SKU_ID),\n             NVL(:NEW.PREVENTREG, SYSDATE + 1),\n             NULL,\n             NULL,\n             V_PEDIDO.BEG_VEN_PEDIDO_ID,\n             V_PRODUTO.BEG_PRD_SKU_ID,\n             V_PRODUTO.BEG_PRODUTO_ID,\n             'N',\n             0,\n             0,\n             0,\n             :NEW.QTDE,\n             0,\n             :NEW.die_iteped_id,\n             v_tp_ped_id,\n             'V');\n          --\n          OPEN BUSCA_ESTOQUE;\n          FETCH BUSCA_ESTOQUE\n            INTO V_ESTOQUE;\n          --\n          IF BUSCA_ESTOQUE%NOTFOUND THEN\n            insert into beg_estoque\n              (beg_estoque_id,\n               ad_client_id,\n               ad_org_id,\n               isactive,\n               created,\n               createdby,\n               updated,\n               updatedby,\n               qtd,\n               beg_prd_sku_id,\n               beg_est_almoxarifado_id,\n               beg_produto_id,\n               qtd_reservada)\n            values\n              (BEG_FNC_AD_SEQUENCE('BEG_ESTOQUE'), --v_beg_estoque_id,\n               :NEW.ad_client_id, --v_ad_client_id,\n               1000016, --v_ad_org_id,\n               'Y', --v_isactive,\n               :NEW.CREATED, --v_created,\n               :NEW.CREATEDBY, --v_createdby,\n               :NEW.updated, --v_updated,\n               :NEW.updatedBY, --v_updatedby,\n               0, --v_qtd,\n               V_PRODUTO.BEG_PRD_SKU_ID, --v_beg_prd_sku_id,\n               beg_fnc_retorna_parametro(:NEW.AD_CLIENT_ID,\n                                         1000016,\n                                         'Vendas',\n                                         'Faturamento',\n                                         'ALMOXARIFADO FATURAMENTO'), --v_beg_est_almoxarifado_id,\n               :NEW.BEG_PRODUTO_ID, --v_beg_produto_id,\n               0 --v_qtd_reservada\n               );\n          END IF;\n          CLOSE BUSCA_ESTOQUE;\n          insert into beg_est_log_reserva\n            (beg_est_log_reserva_id,\n             ad_client_id,\n             ad_org_id,\n             isactive,\n             created,\n             createdby,\n             updated,\n             updatedby,\n             movimento,\n             beg_prd_sku_id,\n             beg_est_almoxarifado_id,\n             beg_est_vw_almox_destino_id,\n             qtd_movto,\n             beg_produto_id,\n             documento,\n             data,\n             tp_movto,\n             qtd_estoque,\n             docstatus)\n          values\n            (BEG_FNC_AD_SEQUENCE('BEG_EST_LOG_RESERVA'),\n             :NEW.AD_CLIENT_ID,\n             :NEW.AD_ORG_ID,\n             'Y',\n             SYSDATE,\n             1000000,\n             SYSDATE,\n             1000000,\n             'INCLUSAO PROPOSTA TRIGGER',\n             v_PRODUTO.beg_prd_sku_id,\n             NULL,\n             beg_fnc_retorna_parametro(:NEW.AD_CLIENT_ID,\n                                       1000016,\n                                       'Vendas',\n                                       'Faturamento',\n                                       'ALMOXARIFADO FATURAMENTO'),\n             :new.qtde,\n             v_produto.beg_produto_id,\n             'Proposta',\n             :new.dtemissao,\n             'I',\n             V_ESTOQUE,\n             'CO');\n        \n          /*        UPDATE BEG_ESTOQUE E\n            SET E.QTD_RESERVADA = E.QTD_RESERVADA + :NEW.QTDE\n          WHERE E.BEG_EST_ALMOXARIFADO_ID =\n                beg_fnc_retorna_parametro(:NEW.AD_CLIENT_ID,\n                                          1000016,\n                                          'Vendas',\n                                          'Faturamento',\n                                          'ALMOXARIFADO FATURAMENTO')\n            AND E.BEG_PRODUTO_ID = V_PRODUTO.BEG_PRODUTO_ID\n            AND E.BEG_PRD_SKU_ID = V_PRODUTO.BEG_PRD_SKU_ID;*/\n          --\n        end if;\n      END IF;\n    END IF;\n  \n    IF V_SITUACAO = 'C' and V_LIBERADO = 'S' and\n       :NEW.TPENTREGA IN ('DE', 'DR') THEN\n    \n      OPEN BUSCA_PRODUTO;\n      FETCH BUSCA_PRODUTO\n        INTO V_PRODUTO;\n      CLOSE BUSCA_PRODUTO;\n    \n      OPEN BUSCA_PEDIDO1;\n      FETCH BUSCA_PEDIDO1\n        INTO V_PEDIDO1;\n      IF BUSCA_PEDIDO1%FOUND THEN\n      \n        OPEN BUSCA_ESTOQUE;\n        FETCH BUSCA_ESTOQUE\n          INTO V_ESTOQUE;\n        CLOSE BUSCA_ESTOQUE;\n        insert into beg_est_log_reserva\n          (beg_est_log_reserva_id,\n           ad_client_id,\n           ad_org_id,\n           isactive,\n           created,\n           createdby,\n           updated,\n           updatedby,\n           movimento,\n           beg_prd_sku_id,\n           beg_est_almoxarifado_id,\n           beg_est_vw_almox_destino_id,\n           qtd_movto,\n           beg_produto_id,\n           documento,\n           data,\n           tp_movto,\n           qtd_estoque,\n           docstatus)\n        values\n          (BEG_FNC_AD_SEQUENCE('BEG_EST_LOG_RESERVA'),\n           :NEW.AD_CLIENT_ID,\n           :NEW.AD_ORG_ID,\n           'Y',\n           SYSDATE,\n           1000000,\n           SYSDATE,\n           1000000,\n           'CANCELAMENTO PROPOSTA TRIGGER',\n           v_PRODUTO.beg_prd_sku_id,\n           NULL,\n           beg_fnc_retorna_parametro(:NEW.AD_CLIENT_ID,\n                                     1000016,\n                                     'Vendas',\n                                     'Faturamento',\n                                     'ALMOXARIFADO FATURAMENTO'),\n           :new.qtde,\n           v_PRODUTO.beg_produto_id,\n           'Proposta',\n           :new.dtemissao,\n           'C',\n           V_ESTOQUE,\n           'CO');\n      \n        UPDATE BEG_ESTOQUE E\n           SET E.QTD_RESERVADA = E.QTD_RESERVADA - :NEW.QTDE\n         WHERE E.BEG_EST_ALMOXARIFADO_ID =\n               beg_fnc_retorna_parametro(:NEW.AD_CLIENT_ID,\n                                         1000016,\n                                         'Vendas',\n                                         'Faturamento',\n                                         'ALMOXARIFADO FATURAMENTO')\n           AND E.BEG_PRODUTO_ID = V_PRODUTO.BEG_PRODUTO_ID\n           AND E.BEG_PRD_SKU_ID = V_PRODUTO.BEG_PRD_SKU_ID;\n        --\n        CLOSE BUSCA_PEDIDO1;\n      END IF;\n    END IF;\n  END IF;\nend TRG_BIU_BEG_VEN_PEDIDO_DATAS;\n"}`;
    
    }
}
