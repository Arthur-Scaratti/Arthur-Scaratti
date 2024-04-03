
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_PEDIDO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_DIVISAO_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PLANO_VENDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PESSOA_ENTREGA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PESSOA_COBRANCA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TRANSPORTADORA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_REPRESENTANTE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PLANO_EDITAVEL { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IMPRESSO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_NF { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string FATURADO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string NF_EMITIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PREPOSTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARTES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_VOLUMES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_VEN_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TELEVENDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string COMPLEMENTAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PESO { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string MSG_ERRO_APROVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RESPONSAVEL_VENDA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO_ENTREGA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PESSOA_COBRANCA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_ROTA_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string PEDIDO_EXTERNO { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS_CREDITO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string TP_CADASTRO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o cliente e uma filial
        /// </summary>
        public string IND_CLIENTE_FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_COM_REGRA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMISSAO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_ORDEM_COMPRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int REPRESENTANTE_PADRAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TELEVENDEDOR_PADRAO { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string MSG_OBS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PEDIDO_ID { get; set; }
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
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTREGA { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_TIPO_PEDIDO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_FORMA_COBRANCA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_TABELA_PRECO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_VEN_PEDIDO_TB_PRC { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que inicializa a tabela de precos. Trigger temporaria que deve ser dropada\n                  quando a coluna for dropada da tabela BEG_VEN_PEDIDO.\n   Modulo.......: VEN - Vendas\n   Analista.....: Tiago Gabriel\n   Alterac?es:\n   Data        Desenvolvedor  Alterac?o\n   26/12/2006  Tiago Gabriel  Criac?o.\n   09/10/2015  Marcelo Fritsch alteraco para validacoes de solicitacao de reposicao da loja\n  --------------------------------------------------------------------------------------------------- */\n  declare\n    cursor c1 is\n      select p.beg_pessoa_id\n        from beg_apex_user u, beg_dado_filial df, beg_pessoa p\n       where u.ad_org_id = df.ad_org_id\n         and df.beg_pessoa_id = p.beg_pessoa_id\n         and u.ad_user_id = :new.createdby;\n    rc1 c1%rowtype;\n    CURSOR BUSCA_PESSOA IS\n      SELECT *\n        FROM BEG_PESSOA P\n       WHERE P.BEG_PESSOA_ID = :NEW.BEG_VW_CLIENTE_ID;\n    --\n    V_PESSOA BUSCA_PESSOA%ROWTYPE;\n    --\n    cursor busca_filial_clie is\n      select ad_org_id\n        from beg_dado_filial f\n       where f.beg_pessoa_id = :new.beg_vw_cliente_id;\n    --\n    v_filial_clie number(10);\n    --\n    cursor BUSCA_PEDIDO IS\n      select COUNT(1) PEDIDO\n        from beg_ven_pedido p\n       where p.beg_vw_cliente_id = :NEW.BEG_VW_CLIENTE_ID\n            --and p.dt_entrega = :NEW.DT_NOVO\n         and p.beg_ven_tipo_pedido_id = 2000019 --V_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID\n         and p.beg_ger_divisao_pedido_id = :NEW.BEG_GER_DIVISAO_PEDIDO_ID\n         and p.IMPRESSO = 'N'\n         and p.isactive='Y'\n         AND NVL(p.DOCSTATUS, 'IP') <> 'CO'\n         and not exists\n       (select 1\n                from beg_ven_pedido_conferido pc\n               where pc.beg_ven_pedido_id = p.beg_ven_pedido_id);\n  \n    R_PEDIDO BUSCA_PEDIDO%ROWTYPE;\n    --            \n     CURSOR BUSCA_USU IS\n    SELECT U.IND_COMPRADOR\n      FROM BEG_APEX_USER U\n     WHERE U.AD_USER_ID = :NEW.CREATEDBY;\n\n  R_USU BUSCA_USU%ROWTYPE;\n  \n  begin\n    --\n    \n \n  \n    --\n    open c1;\n    fetch c1\n      into rc1;\n    close c1;\n  \n    :new.BEG_VEN_TABELA_PRECO_ID := 2000448;\n  \n    --- MF 09/10/2015\n    if inserting then\n      if :new.beg_ven_pedido_id is null then\n        :new.beg_ven_pedido_id := beg_fnc_ad_sequence('BEG_VEN_PEDIDO');\n      end if;\n      --IF :new.Docstatus is null then\n      :new.docstatus := 'AP';\n      :NEW.IMPRESSO  := 'N';\n      if :new.partes is null then\n        :new.partes := 1;\n      end if;\n      if :new.ad_client_id = 0 then\n        :new.ad_client_id := 1000000;\n      end if;\n      --end if;\n      if :new.value is null then\n        :new.value := beg_fnc_ad_sequence('BEG_VEN_PEDIDO');\n      end if;\n    \n      if :new.beg_vw_cliente_id is null then\n        :new.beg_vw_cliente_id         := rc1.beg_pessoa_id;\n        :new.beg_vw_pessoa_cobranca_id := rc1.beg_pessoa_id;\n      end if;\n      IF :NEW.BEG_VW_PESSOA_COBRANCA_ID IS NULL THEN\n        :NEW.BEG_VW_PESSOA_COBRANCA_ID := :NEW.BEG_VW_CLIENTE_ID;\n      END IF;\n    end if;\n    ------------------\n    \n      ---- NAO PERMITIR GRAVAR DOIS PEDIDOS PARA RESSUPRIMENTO\n      OPEN BUSCA_USU;\n    FETCH BUSCA_USU\n      INTO R_USU;\n    CLOSE BUSCA_USU;\n    \n    if inserting and :new.beg_ven_tipo_pedido_id = 2000019 and R_USU.IND_COMPRADOR = 'N' then\n      OPEN BUSCA_PEDIDO;\n      FETCH BUSCA_PEDIDO\n        INTO R_PEDIDO;\n      CLOSE BUSCA_PEDIDO;\n    \n      IF R_PEDIDO.PEDIDO > 0  THEN\n        raise_application_error(-20501,\n                                'Ja existe pedido de ressuprimento em aberto para esta divisao de pedido. Favor incluir novos produtos no mesmo.');\n      END IF;\n    \n    end if;\n    \n    \n    \n    ------------\n    open busca_filial_clie;\n    fetch busca_filial_clie\n      into v_filial_clie;\n    close busca_filial_clie;\n    if v_filial_clie = :new.ad_org_id then\n      raise_application_error(-20501,\n                              'Pedido gerado para mesma filial que o destino.');\n    end if;\n    \n    \n    -----------\n    IF :NEW.BEG_CIDADE_ID IS NULL THEN\n      OPEN BUSCA_PESSOA;\n      FETCH BUSCA_PESSOA\n        INTO V_PESSOA;\n      CLOSE BUSCA_PESSOA;\n      :NEW.BEG_CIDADE_ID := V_PESSOA.BEG_CIDADE_ID;\n      :NEW.ENDERECO      := V_PESSOA.ENDERECO;\n      :NEW.BAIRRO        := V_PESSOA.BAIRRO;\n    END IF;\n    IF :NEW.BEG_VEN_TIPO_PEDIDO_ID = 2000019 THEN\n      :NEW.BEG_VEN_FORMA_PAGAMENTO_ID := 2000013;\n    END IF;\n  end;\nend TRG_BIU_BEG_VEN_PEDIDO_TB_PRC;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIU_BEG_VEN_PEDIDO_DATAS { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que inicializa corretamente as datas do pedido.\n   Modulo.......: VEN - Vendas\n   Analista.....: Tiago Gabriel\n   Alterac?es:\n   Data        Desenvolvedor  Alterac?o\n   21/12/2006  Tiago Gabriel  Criac?o.\n  --------------------------------------------------------------------------------------------------- */\n  if INSERTING then\n    :new.CREATED := sysdate;\n  \n  end if;\n  :new.UPDATED    := sysdate;\n  :new.DT_EMISSAO := TRUNC(:new.DT_EMISSAO);\n  :new.DT_ENTREGA := TRUNC(:new.DT_ENTREGA);\n\n  IF :NEW.BEG_VEN_TIPO_PEDIDO_ID = 2000019 AND\n     :NEW.DT_ENTREGA > TRUNC(SYSDATE + 30) THEN\n    raise_application_error(-20501,\n                            'Data de entrega nao pode ser superior a 30 dias.');\n  END IF;\n\nend TRG_BIU_BEG_VEN_PEDIDO_DATAS;\n"}`;
    
    }
}
