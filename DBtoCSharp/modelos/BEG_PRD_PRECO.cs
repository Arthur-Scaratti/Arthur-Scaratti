
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_PRECO
    {
            [Required]
        /// <summary>
        /// Quantidade do produto dentro do conjunto
        /// </summary>
        public int QTD_CONJUNTO { get; set; }
            [Required]
        /// <summary>
        /// Percentual de variação do último preço
        /// </summary>
        public int PER_VARIACAO { get; set; }
            [Required]
        /// <summary>
        /// Número de prestações para promoção
        /// </summary>
        public int NRO_PRESTACOES { get; set; }
            [Required]
        /// <summary>
        /// Valor da prestação para promoção
        /// </summary>
        public int VLR_PRESTACAO { get; set; }
            [Required]
        /// <summary>
        /// Número de prestações para financiamento
        /// </summary>
        public int NRO_PRESTACOES_FIN { get; set; }
            [Required]
        /// <summary>
        /// Valor da prestação para financiamento
        /// </summary>
        public int VLR_PRESTACAO_FIN { get; set; }
            [Required]
        /// <summary>
        /// Valor do preço para financiamento
        /// </summary>
        public int VLR_PRECO_FIN { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Observação
        /// </summary>
        public string OBS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se o preço está aprovado para uso
        /// </summary>
        public string IND_APROVADO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que deve ser listado na tela de aprovação
        /// </summary>
        public string IND_LISTA_APROVACAO { get; set; }
        
        /// <summary>
        /// Data de aprovação
        /// </summary>
        public string DT_APROVACAO { get; set; }
        
        /// <summary>
        /// Data de início original
        /// </summary>
        public string DT_INICIO_ORIGINAL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica dado importado do SIAD
        /// </summary>
        public string IND_IMPORTADO { get; set; }
            [Required]
        /// <summary>
        /// ID do produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do SKU
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
        
        /// <summary>
        /// ID da promoção
        /// </summary>
        public int BEG_PRD_PROMOCAO_ID { get; set; }
        
        /// <summary>
        /// ID do conjunto
        /// </summary>
        public int BEG_PRD_CONJUNTO_ID { get; set; }
        
        /// <summary>
        /// Valor da prestação para cartão CR parcelado administradora
        /// </summary>
        public int VLR_PRES_CAR_ADM { get; set; }
        
        /// <summary>
        /// Valor do preço para cartão CR parcelado administradora
        /// </summary>
        public int VLR_PRECO_CAR_ADM { get; set; }
            [Required]
        /// <summary>
        /// Número de prestações para cartão CR parcelado estabelecimento
        /// </summary>
        public int NRO_PRES_CAR_CR { get; set; }
            [Required]
        /// <summary>
        /// Valor da prestação para cartão CR parcelado estabelecimento
        /// </summary>
        public int VLR_PRES_CAR_CR { get; set; }
            [Required]
        /// <summary>
        /// Valor do preço para cartão CR parcelado estabelecimento
        /// </summary>
        public int VLR_PRECO_CAR_CR { get; set; }
            [Required]
        /// <summary>
        /// Valor de Cashback em nova compra
        /// </summary>
        public int VLR_CASHBACK { get; set; }
            [Required]
        /// <summary>
        /// Numero de dias para resgate do cashback apos compra
        /// </summary>
        public int DIAS_CASHBACK { get; set; }
            [Required]
        /// <summary>
        /// Percentual que o cashback deve representar na nova compra
        /// </summary>
        public int PERC_CASHBACK { get; set; }
            [Required]
        /// <summary>
        /// Número de prestações para cartão de crédito
        /// </summary>
        public int NRO_PRESTACOES_CAR { get; set; }
            [Required]
        /// <summary>
        /// Valor da prestação para cartão de crédito
        /// </summary>
        public int VLR_PRESTACAO_CAR { get; set; }
            [Required]
        /// <summary>
        /// Valor do preço para cartão de crédito
        /// </summary>
        public int VLR_PRECO_CAR { get; set; }
        
        /// <summary>
        /// Data de vigência do preço de emergência
        /// </summary>
        public string DT_VIGENCIA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que deve gerar um preço novo com o valor da emergência iniciando no dia seguinte ao da vigência
        /// </summary>
        public string IND_PRECO_NOVO { get; set; }
        
        /// <summary>
        /// ID do plano para celulares
        /// </summary>
        public int BEG_CEL_PLANO_ID { get; set; }
            [Required]
        /// <summary>
        /// Número de prestações para cartão CR parcelado administradora
        /// </summary>
        public int NRO_PRES_CAR_ADM { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do preço de venda
        /// </summary>
        public int BEG_PRD_PRECO_ID { get; set; }
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
        /// Data de início da vigência do preço
        /// </summary>
        public string DT_INICIO { get; set; }
            [Required]
        /// <summary>
        /// Preço de venda
        /// </summary>
        public int VLR_PRECO { get; set; }
            [Required]
        /// <summary>
        /// Valor sugerido
        /// </summary>
        public int VLR_SUGERIDO { get; set; }
            [Required]
        /// <summary>
        /// Valor de catálogo vigente no caso de promoção ou preço de emergência
        /// </summary>
        public int VLR_CATALOGO { get; set; }
            [Required]
        /// <summary>
        /// Valor de emergência válido somente para um dia (data da vigência)
        /// </summary>
        public int VLR_EMERGENCIA { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_PRD_PRECO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  pragma autonomous_transaction;\n\n  VC_MSG_ERRO             varchar2(200);\n  VN_DUMMY                number;\n  VN_BEG_PRD_PROMOCAO_ID  BEG_PRD_PROMOCAO.BEG_PRD_PROMOCAO_ID%type;\n  VDT_FIM_PROMO           BEG_PRD_PROMOCAO.DT_FIM%type;\n  VN_AD_ORG_ID_PROMO      BEG_PRD_PROMOCAO.AD_ORG_ID%type;\n  VDT_FIM_CONJ            BEG_PRD_CONJUNTO.DT_FIM%type;\n  VN_AD_ORG_ID_CONJ       BEG_PRD_CONJUNTO.AD_ORG_ID%type;\n  VN_BEG_VW_FORNECEDOR_ID BEG_VW_FORNECEDOR.BEG_VW_FORNECEDOR_ID%type;\n  VN_BEG_PRD_PRECO_ID     BEG_PRD_PRECO.BEG_PRD_PRECO_ID%type;\n  VC_IND_PRECO            varchar2(1);\n\nbegin\n  if NVL(:new.IND_IMPORTADO, :old.IND_IMPORTADO) = 'Y'\n     and not UPDATING('ISACTIVE') then\n    VC_MSG_ERRO := 'Preços importados não permitem alteração!';\n    goto FIM;\n  end if;\n\n  if UPDATING('IND_APROVADO')\n     and not BEG_PCK_PRD_PRODUTOS.VB_PROC_VW_PENDENTE then\n    VC_MSG_ERRO := 'Atualização deve ser feita na visão!';\n    goto FIM;\n  end if;\n\n  if UPDATING\n     and not UPDATING('ISACTIVE')\n     and not UPDATING('IND_APROVADO')\n     and :new.IND_APROVADO = 'Y'\n     and not UPDATING('VLR_EMERGENCIA')\n     and not UPDATING('IND_PRECO_NOVO') then\n    VC_MSG_ERRO := 'Preços aprovados não podem ser alterados! Cadastrar preço novo ou utilizar preço de emergência.';\n    goto FIM;\n  end if;\n\n  if DELETING then\n    -- Não permite exclusão de preços vigentes e anteriores se aprovados.\n    if :old.DT_INICIO <= TRUNC(sysdate)\n       and :old.IND_APROVADO = 'Y' then\n      VC_MSG_ERRO := 'Preço vigente ou anterior já aprovado não permite exclusão!';\n    end if;\n  \n    -- Não permite exclusão de preços aprovados, independente da data.\n    if :old.IND_APROVADO = 'Y'\n       and not BEG_PCK_PRD_PRODUTOS.VB_PROC_VW_PENDENTE then\n      VC_MSG_ERRO := 'Preço já aprovado somente pode ser excluído na tela de aprovação!';\n    end if;\n  \n    goto FIM;\n  end if;\n\n  -- Valor deve ter sido informado\n  if NVL(:new.VLR_PRECO, 0) = 0 then\n    VC_MSG_ERRO := 'Preço deve ser informado!';\n    goto FIM;\n  end if;\n\n  --TS 05/05/2010 Begin\n  -- Validações Se for informado Numero de Prestações e não o valor\n  if NVL(:new.NRO_PRESTACOES, 0) > 0\n     and NVL(:new.VLR_PRESTACAO, 0) = 0\n     or NVL(:new.VLR_PRESTACAO, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o valor das prestações!');\n  end if;\n\n  -- Validações Se for informado o Valor de Prestações e não a quantidade\n  if NVL(:new.VLR_PRESTACAO, 0) > 0\n     and NVL(:new.NRO_PRESTACOES, 0) = 0\n     or NVL(:new.NRO_PRESTACOES, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar quantidade de prestações!');\n  end if;\n\n  -- Validações Se for informado o preço da financeiro e não o numero de prestações\n  if NVL(:new.VLR_PRECO_FIN, 0) > 0\n     and NVL(:new.NRO_PRESTACOES_FIN, 0) = 0\n     or NVL(:new.NRO_PRESTACOES_FIN, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o numero de Prestações para a Financeira!');\n  end if;\n\n  -- Validações Se for informado o preço da financeiro e não valor das prestações\n  if NVL(:new.VLR_PRECO_FIN, 0) > 0\n     and NVL(:new.VLR_PRESTACAO_FIN, 0) = 0\n     or NVL(:new.VLR_PRESTACAO_FIN, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o valor das Prestações para a Financeira!');\n  end if;\n\n  -- Validações Se for informado o Valor das Prestações da Financeira e não o preço\n  if NVL(:new.VLR_PRESTACAO_FIN, 0) > 0\n     and NVL(:new.VLR_PRECO_FIN, 0) = 0\n     or NVL(:new.VLR_PRECO_FIN, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o preço da Financeira!');\n  end if;\n\n  -- Validações Se for informado o valor das Prestações da Financeira e não numero\n  if NVL(:new.VLR_PRESTACAO_FIN, 0) > 0\n     and NVL(:new.NRO_PRESTACOES_FIN, 0) = 0\n     or NVL(:new.NRO_PRESTACOES_FIN, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o numero de Prestações para a Financeira!!');\n  end if;\n\n  -- Validações Se for informado o numero de prestações financeira e não o valor das prestações\n  if NVL(:new.NRO_PRESTACOES_FIN, 0) > 0\n     and NVL(:new.VLR_PRESTACAO_FIN, 0) = 0\n     or NVL(:new.VLR_PRESTACAO_FIN, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o valor das Prestações para a Financeira!');\n  end if;\n\n  -- Validações Se for informado o numero de prestações financeira e não o preço\n  if NVL(:new.NRO_PRESTACOES_FIN, 0) > 0\n     and NVL(:new.VLR_PRECO_FIN, 0) = 0\n     or NVL(:new.VLR_PRECO_FIN, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o valor da Financeira!');\n  end if;\n  --------\n  -- Validações Se for informado o preço do cartão e não o valor das prestações\n  if NVL(:new.VLR_PRECO_CAR, 0) > 0\n     and NVL(:new.VLR_PRESTACAO_CAR, 0) = 0\n     or NVL(:new.VLR_PRESTACAO_CAR, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o valor das Prestações do Cartão!');\n  end if;\n\n  -- Validações Se for informado o preço do cartão e não o numero de prestações\n  if NVL(:new.VLR_PRECO_CAR, 0) > 0\n     and NVL(:new.NRO_PRESTACOES_CAR, 0) = 0\n     or NVL(:new.NRO_PRESTACOES_CAR, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o numero de Prestações do Cartão!');\n  end if;\n\n  -- Validações Se for informado o numero de prestações do cartão e não o valor\n  if NVL(:new.NRO_PRESTACOES_CAR, 0) > 0\n     and NVL(:new.VLR_PRECO_CAR, 0) = 0\n     or NVL(:new.VLR_PRECO_CAR, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002, 'Faltou informar o Preço do Cartão!');\n  end if;\n\n  -- Validações Se for informado o numero de prestações do cartão e não o preço das prestações\n  if NVL(:new.NRO_PRESTACOES_CAR, 0) > 0\n     and NVL(:new.VLR_PRESTACAO_CAR, 0) = 0\n     or NVL(:new.VLR_PRESTACAO_CAR, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o numero de prestações do Cartão!');\n  end if;\n  \n   -- Validações Se for informado o numero de prestações do cartão e não o preço das prestações\n  if NVL(:new.NRO_PRESTACOES_CAR, 0) > 12\n     then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Informar no máximo 12 parcelas no cartao!');\n  end if;\n\n  -- Validações Se for informado o valor das prestações do cartão e não o valor\n  if NVL(:new.VLR_PRESTACAO_CAR, 0) > 0\n     and NVL(:new.VLR_PRECO_CAR, 0) = 0\n     or NVL(:new.VLR_PRECO_CAR, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002, 'Faltou informar o Preço do Cartão!');\n  end if;\n\n  -- Validações Se for informado o valor das prestações do cartão e numero de prestações\n  if NVL(:new.VLR_PRESTACAO_CAR, 0) > 0\n     and NVL(:new.NRO_PRESTACOES_CAR, 0) = 0\n     or NVL(:new.NRO_PRESTACOES_CAR, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o numero de prestações do Cartão!');\n  end if;\n\n------\n  -- Validações Se for informado o numero de prestações do cartão  CR estabelecimento e não o preço das prestações\n  if NVL(:new.NRO_PRES_CAR_CR, 0) > 15\n     then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Informar no máximo 15 parcelas no cartao CR estabelecimento!');\n  end if;\n\n  -- Validações Se for informado o valor das prestações do cartão  CR estabelecimento e não o valor\n  if NVL(:new.VLR_PRES_CAR_CR, 0) > 0\n     and NVL(:new.VLR_PRECO_CAR_CR, 0) = 0\n     or NVL(:new.VLR_PRECO_CAR_CR, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002, 'Faltou informar o Preço do Cartão CR estabelecimento!');\n  end if;\n\n  -- Validações Se for informado o valor das prestações do cartão  CR estabelecimento e numero de prestações\n  if NVL(:new.VLR_PRES_CAR_CR, 0) > 0\n     and NVL(:new.NRO_PRES_CAR_CR, 0) = 0\n     or NVL(:new.NRO_PRES_CAR_CR, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o numero de prestações do Cartão CR estabelecimento!');\n  end if;\n\n IF NVL(:new.VLR_PRECO_CAR_CR, 0) = 0 THEN\n   \n   :new.VLR_PRECO_CAR_CR := :NEW.VLR_PRECO_CAR;\n   :new.NRO_PRES_CAR_CR :=  :NEW.NRO_PRESTACOES_CAR;\n   :new.VLR_PRES_CAR_CR := :NEW.VLR_PRESTACAO_CAR;\n   \n END IF;\n\n-----\n-- Validações Se for informado o numero de prestações do cartão  CR ADM e não o preço das prestações\n  if NVL(:new.NRO_PRES_CAR_ADM, 0) > 30\n     then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Informar no máximo 30 parcelas no cartao CR ADM!');\n  end if;\n\n  -- Validações Se for informado o valor das prestações do cartão  CR ADM e não o valor\n  if NVL(:new.VLR_PRES_CAR_ADM, 0) > 0\n     and NVL(:new.VLR_PRECO_CAR_ADM, 0) = 0\n     or NVL(:new.VLR_PRECO_CAR_ADM, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002, 'Faltou informar o Preço do Cartão CR ADM!');\n  end if;\n\n  -- Validações Se for informado o valor das prestações do cartão  CR adm e numero de prestações\n  if NVL(:new.VLR_PRES_CAR_ADM, 0) > 0\n     and NVL(:new.NRO_PRES_CAR_ADM, 0) = 0\n     or NVL(:new.NRO_PRES_CAR_ADM, 0) is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o numero de prestações do Cartão CR ADM!');\n  end if;\n\n\n  IF NVL(:NEW.VLR_CASHBACK,0) > 0 AND :NEW.PERC_CASHBACK = 0 AND :NEW.DIAS_CASHBACK = 0 THEN\n    \n     RAISE_APPLICATION_ERROR(-20002,\n                            'Informado valor de Cashback e não informado percentual e dias. Verifique!');\n  \n  END IF;\n\n\n----\n  --TS 05/05/2010 end;\n\n  -- Data deve ter sido informada\n  if :new.DT_INICIO is null then\n    VC_MSG_ERRO := 'Data de início deve ser informada!';\n    goto FIM;\n  end if;\n\n  -- Atualiza o indicador de preço aprovado\n  if not BEG_PCK_PRD_PRODUTOS.VB_PROC_VW_PENDENTE then\n    :new.IND_APROVADO := BEG_FNC_RETORNA_PARAM_GERAL('Produto',\n                                                     null,\n                                                     'PRECO_APROVADO');\n    if :new.IND_APROVADO = 'N' then\n      :new.IND_LISTA_APROVACAO := 'Y';\n    end if;\n  end if;\n\n  -- Se está inativando, depois dos testes acima encerra a execução\n  if UPDATING('ISACTIVE')\n     and :new.ISACTIVE = 'N' then\n    goto FIM;\n  end if;\n\n  -- Atualiza valores acessórios\n  --comentado em 20/11/2020\n  /*begin\n    select BEG_VW_FORNECEDOR_ID\n      into VN_BEG_VW_FORNECEDOR_ID\n      from BEG_PRD_FORNECEDOR\n     where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n       and PADRAO = 'Y'\n       and isactive='Y';\n  \n    :new.VLR_SUGERIDO := BEG_FNC_SUP_VALOR(:new.AD_ORG_ID,\n                                           :new.BEG_PRODUTO_ID,\n                                           :new.BEG_PRD_SKU_ID,\n                                           VN_BEG_VW_FORNECEDOR_ID,\n                                           'S');\n  \n  exception\n    when NO_DATA_FOUND then\n      null;\n      --vc_msg_erro := 'Fornecedor padrão não informado para o produto!';\n    --goto fim;\n  \n    when TOO_MANY_ROWS then\n      VC_MSG_ERRO := 'Fornecedor padrão duplicado para o produto!';\n      goto FIM;\n    \n  end;*/\n\n  -- Novo local para consistencia do beg_prd_sku_id - aok - 22/10/2009\n  -- Verifica produto e SKU\n  if UPDATING('BEG_PRODUTO_ID')\n     or :new.BEG_PRD_SKU_ID is null then\n  \n    begin\n      select BEG_PRD_SKU_ID\n        into :new.BEG_PRD_SKU_ID\n        from BEG_PRD_SKU\n       where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n         and PADRAO = 'Y';\n    \n    exception\n      when NO_DATA_FOUND then\n        VC_MSG_ERRO := 'SKU padrão não encontrado!';\n        goto FIM;\n      \n      when TOO_MANY_ROWS then\n        VC_MSG_ERRO := 'SKU padrão duplicado!';\n        goto FIM;\n      \n    end;\n  \n  end if;\n\n  if :new.BEG_PRD_PROMOCAO_ID is not null\n     or :new.VLR_EMERGENCIA > 0 then\n  \n    :new.VLR_CATALOGO := BEG_FNC_PRD_PRECO(:new.AD_ORG_ID,\n                                           :new.BEG_PRODUTO_ID,\n                                           :new.BEG_PRD_SKU_ID,\n                                           :new.BEG_CEL_PLANO_ID,\n                                           'C',\n                                           NVL(:new.DT_VIGENCIA,\n                                               :new.DT_INICIO));\n  end if;\n\n  :new.PER_VARIACAO := BEG_FNC_GER_VARIACAO(:new.VLR_PRECO, case :new.VLR_EMERGENCIA when 0 then :new.VLR_CATALOGO else :new.VLR_EMERGENCIA end);\n\n  -- Se está aprovando, encerra a execução\n  if BEG_PCK_PRD_PRODUTOS.VB_PROC_VW_PENDENTE then\n    goto FIM;\n  end if;\n\n  if not UPDATING('ISACTIVE')\n     and not UPDATING('VLR_EMERGENCIA')\n     and not UPDATING('IND_PRECO_NOVO') then\n  \n/*    -- Data de início deve ser maior ou igual a hoje\n    if :new.DT_INICIO < TRUNC(sysdate)\n       and not UPDATING('IND_APROVADO') then\n      VC_MSG_ERRO := 'Data de início menor que hoje!';\n      goto FIM;\n    end if;*/\n  \n    -- Data deve ser maior que limite para inclusão\n    if :new.DT_INICIO >\n       TRUNC(sysdate) +\n       TO_NUMBER(BEG_FNC_RETORNA_PARAM_GERAL('Produto',\n                                             null,\n                                             'DIAS_LIMITE_PRECO')) then\n      VC_MSG_ERRO := 'Data de início maior que limite para inclusão!';\n      goto FIM;\n    end if;\n  \n    -- Preço não pode estar em promoção e conjunto ao mesmo tempo\n    if :new.BEG_PRD_PROMOCAO_ID is not null\n       and :new.BEG_PRD_CONJUNTO_ID is not null then\n      VC_MSG_ERRO := 'Produto não pode estar em promoção e conjunto ao mesmo tempo!';\n      goto FIM;\n    end if;\n  \n    -- Segundo solicitação, foi liberado o cadastramento para preços diferenciados em conjuntos e promoções.\n    if :new.BEG_PRD_PROMOCAO_ID is null\n       and :new.BEG_PRD_CONJUNTO_ID is null then\n      -- Valida inclusão de preços somente para produtos \"pai\"\n      if :new.BEG_PRODUTO_ID <> BEG_FNC_PRD_PAI(:new.BEG_PRODUTO_ID) then\n        VC_MSG_ERRO := 'Preço deve ser cadastrado somente para produto pai!';\n        goto FIM;\n      end if;\n    end if;\n  \n    -- Filial deve ter sido informada\n    --if :new.ad_org_id = 0 then\n    --  VC_MSG_ERRO := 'Filial deve ser informada!';\n    --  goto FIM;\n    --end if;\n  \n    :new.AD_ORG_ID := NVL(:new.AD_ORG_ID, 0);\n  \n    -- aok -- 22/01/2009 - Desativado deste ponto, movido mais para cima\n    -- Verifica produto e SKU\n    --if UPDATING('BEG_PRODUTO_ID')\n    --   or :new.BEG_PRD_SKU_ID is null then\n    --  begin\n    --    select BEG_PRD_SKU_ID\n    --      into :new.BEG_PRD_SKU_ID\n    --      from BEG_PRD_SKU\n    --     where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n    --       and PADRAO = 'Y';\n    --  exception\n    --    when NO_DATA_FOUND then\n    --      VC_MSG_ERRO := 'SKU padrão não encontrado!';\n    --      goto FIM;\n    --    \n    --    when TOO_MANY_ROWS then\n    --      VC_MSG_ERRO := 'SKU padrão duplicado!';\n    --      goto FIM;\n    --    \n    --  end;\n    --end if;\n  end if;\n\n  VN_BEG_PRD_PRECO_ID := BEG_FNC_PRD_PRECO(:new.AD_ORG_ID,\n                                           :new.BEG_PRODUTO_ID,\n                                           :new.BEG_PRD_SKU_ID,\n                                           :new.BEG_CEL_PLANO_ID,\n                                           'VI');\n\n  if UPDATING\n     and not UPDATING('ISACTIVE') then\n  \n    if not UPDATING('VLR_EMERGENCIA')\n       and not UPDATING('IND_PRECO_NOVO') then\n    \n      -- Não permite alterações nos preços vigentes.\n      if :new.BEG_PRD_PRECO_ID = VN_BEG_PRD_PRECO_ID then\n        VC_MSG_ERRO := 'Preço vigente não permite alteração!';\n        goto FIM;\n      end if;\n    \n      -- Não permite alterações nos preços anteriores.\n      if :old.DT_INICIO < TRUNC(sysdate)\n         and :old.IND_APROVADO = 'Y' then\n        VC_MSG_ERRO := 'Preço anterior não permite alteração!';\n        goto FIM;\n      end if;\n    \n    end if;\n  \n  end if;\n\n  if INSERTING\n     or ((not UPDATING('ISACTIVE') and not UPDATING('IND_APROVADO') and\n     :new.IND_APROVADO = 'Y') and not UPDATING('IND_LISTA_APROVACAO') and\n     :new.VLR_EMERGENCIA = 0) then\n    -- Data de inicio deve ser maior que hoje (sysdate).\n  \n    -- JT 21/12/2009 obrigar valor de prestação sempre que numero de prestações for maior que 0\n    if NVL(:new.NRO_PRESTACOES, 0) > 0\n       and NVL(:new.VLR_PRESTACAO, 0) = 0 then\n      VC_MSG_ERRO := 'Informe o valor da prestação!';\n      goto FIM;\n    elsif NVL(:new.NRO_PRESTACOES_FIN, 0) > 0\n          and NVL(:new.VLR_PRESTACAO_FIN, 0) = 0 then\n      VC_MSG_ERRO := 'Informe o valor da prestação financeira!';\n      goto FIM;\n    elsif NVL(:new.NRO_PRESTACOES_CAR, 0) > 0\n          and NVL(:new.VLR_PRESTACAO_CAR, 0) = 0 then\n      VC_MSG_ERRO := 'Informe o valor da prestação cartão!';\n      goto FIM;\n    end if;\n    --\n  \n    if :new.DT_INICIO < TRUNC(sysdate) then\n      VC_MSG_ERRO := 'Data de início não pode ser menor que hoje!';\n      goto FIM;\n    elsif :new.DT_INICIO = TRUNC(sysdate) AND :NEW.BEG_PRD_PROMOCAO_ID IS NULL then\n      -- Se data e hoje, verifica se existe preço para o produto\n      select count(1)\n        into VN_DUMMY\n        from BEG_PRD_PRECO\n       where AD_ORG_ID = :new.AD_ORG_ID\n         and BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n         and BEG_PRD_SKU_ID = :new.BEG_PRD_SKU_ID\n         and NVL(BEG_CEL_PLANO_ID, 0) = NVL(:new.BEG_CEL_PLANO_ID, 0)\n         and BEG_PRD_PRECO_ID <> VN_BEG_PRD_PRECO_ID\n         and ROWNUM = 1;\n    \n      if VN_DUMMY > 0 then\n        VC_MSG_ERRO := 'Já existe preço para o produto. Data de início deve ser maior que hoje!';\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  -- Se o produto corrente esta em promoção, verifica o final da promoção\n  if :new.BEG_PRD_PROMOCAO_ID is not null then\n    begin\n      select AD_ORG_ID,\n             DT_FIM\n        into VN_AD_ORG_ID_PROMO,\n             VDT_FIM_PROMO\n        from BEG_PRD_PROMOCAO\n       where BEG_PRD_PROMOCAO_ID = :new.BEG_PRD_PROMOCAO_ID\n         and ISACTIVE = 'Y';\n    \n      if NVL(VDT_FIM_PROMO, :new.DT_INICIO) < :new.DT_INICIO then\n        VC_MSG_ERRO := 'Promoção já encerrada!';\n        goto FIM;\n      end if;\n    \n      if :new.DT_INICIO > NVL(VDT_FIM_PROMO, :new.DT_INICIO) then\n        VC_MSG_ERRO := 'Data de início maior que o término da promoção!';\n        goto FIM;\n      end if;\n    \n      if VN_AD_ORG_ID_PROMO <> 0\n         and VN_AD_ORG_ID_PROMO <> :new.AD_ORG_ID then\n        VC_MSG_ERRO := 'Filial do preço difere da capa da promoção!';\n        goto FIM;\n      end if;\n    \n    exception\n      when NO_DATA_FOUND then\n        VC_MSG_ERRO := 'Promoção inexistente ou inativa!';\n        goto FIM;\n      \n      when TOO_MANY_ROWS then\n        VC_MSG_ERRO := 'Promoção duplicada!';\n        goto FIM;\n      \n    end;\n  \n    -- Verifica se o item não esta vinculado a nenhuma outra promoção\n    -- bloqueada esta validacao no simulador novo permite mais de uma promocaopor produto\n  /*  VN_BEG_PRD_PROMOCAO_ID := TO_NUMBER(BEG_FNC_PRD_PROMOCAO(:new.AD_ORG_ID,\n                                                             :new.BEG_PRODUTO_ID,\n                                                             :new.BEG_PRD_SKU_ID,\n                                                             :new.BEG_CEL_PLANO_ID,\n                                                             'ID',\n                                                             :new.DT_INICIO,\n                                                             'Y',\n                                                             'Y',\n                                                             'Y',\n                                                             'Y'));\n  \n    if NVL(VN_BEG_PRD_PROMOCAO_ID, :new.BEG_PRD_PROMOCAO_ID) <>\n       :new.BEG_PRD_PROMOCAO_ID then\n      VC_MSG_ERRO := 'Produto vinculado a promoção ' ||\n                     BEG_FNC_PRD_PROMOCAO(:new.AD_ORG_ID,\n                                          :new.BEG_PRODUTO_ID,\n                                          :new.BEG_PRD_SKU_ID,\n                                          :new.BEG_CEL_PLANO_ID,\n                                          'NC',\n                                          :new.DT_INICIO,\n                                          'Y',\n                                          'Y',\n                                          'Y',\n                                          'Y') || '-'|| :new.beg_produto_id ||'!';\n      goto FIM;\n    end if;*/\n  \n  end if;\n\n  -- Se o produto corrente esta em conjunto, verifica o final do conjunto\n  if :new.BEG_PRD_CONJUNTO_ID is not null then\n    begin\n      select AD_ORG_ID,\n             DT_FIM\n        into VN_AD_ORG_ID_CONJ,\n             VDT_FIM_CONJ\n        from BEG_PRD_CONJUNTO\n       where BEG_PRD_CONJUNTO_ID = :new.BEG_PRD_CONJUNTO_ID\n         and ISACTIVE = 'Y';\n    \n      if NVL(VDT_FIM_CONJ, :new.DT_INICIO) < :new.DT_INICIO then\n        VC_MSG_ERRO := 'Conjunto já encerrado!';\n        goto FIM;\n      end if;\n    \n      if :new.DT_INICIO > NVL(VDT_FIM_CONJ, :new.DT_INICIO) then\n        VC_MSG_ERRO := 'Data final maior que o término do conjunto!';\n        goto FIM;\n      end if;\n    \n      if VN_AD_ORG_ID_CONJ <> 0\n         and VN_AD_ORG_ID_CONJ <> :new.AD_ORG_ID then\n        VC_MSG_ERRO := 'Filial do preço difere do conjunto!';\n        goto FIM;\n      end if;\n    \n    exception\n      when NO_DATA_FOUND then\n        VC_MSG_ERRO := 'Conjunto inexistente ou inativo!';\n        goto FIM;\n      \n      when TOO_MANY_ROWS then\n        VC_MSG_ERRO := 'Conjunto duplicado!';\n        goto FIM;\n      \n    end;\n  \n    if NVL(:new.QTD_CONJUNTO, 0) = 0 then\n      VC_MSG_ERRO := 'Quantidade no conjunto deve ser informada!';\n      goto FIM;\n    end if;\n  \n  end if;\n\n  -- Se o produto corrente tem plano de celularv alida vínculo\n  if :new.BEG_CEL_PLANO_ID is not null then\n    if BEG_FNC_CEL_PLANO(:new.AD_ORG_ID,\n                         :new.BEG_PRODUTO_ID,\n                         :new.BEG_CEL_PLANO_ID,\n                         :new.DT_INICIO) = 'N' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Vínculo de produto e plano de celular inativo!');\n    end if;\n  end if;\n\n  -- Se não esta sendo alterado o valor de emergencia e se este não existe, valida a alteração do preço\n  if not UPDATING('VLR_EMERGENCIA')\n     and not UPDATING('IND_PRECO_NOVO')\n     and :new.VLR_EMERGENCIA = 0 then\n  \n    if :new.IND_APROVADO = 'Y' then\n      if :new.BEG_PRD_PROMOCAO_ID is null then\n        VC_IND_PRECO := 'C';\n      else\n        VC_IND_PRECO := 'P';\n      end if;\n    \n      -- Valida se o preço foi alterado\n      if :new.VLR_PRECO =\n         BEG_FNC_PRD_PRECO(:new.AD_ORG_ID,\n                           :new.BEG_PRODUTO_ID,\n                           :new.BEG_PRD_SKU_ID,\n                           :new.BEG_CEL_PLANO_ID,\n                           VC_IND_PRECO,\n                           :new.DT_INICIO) then\n        VC_MSG_ERRO := 'Preço não teve alteração!';\n        goto FIM;\n      end if;\n    end if;\n  \n    :new.DT_VIGENCIA := null;\n  \n  else\n  \n    -- Somente permite a primeira inclusão do preço de emergencia\n    if UPDATING('VLR_EMERGENCIA')\n       and NVL(:old.VLR_EMERGENCIA, 0) > 0\n       and not UPDATING('IND_PRECO_NOVO') then\n      VC_MSG_ERRO := 'Preço de emergência já informado!';\n      goto FIM;\n    end if;\n  \n    -- So permite manutenção de emergencia no preço vigente.\n    if :new.BEG_PRD_PRECO_ID <> VN_BEG_PRD_PRECO_ID then\n      VC_MSG_ERRO := 'Preço corrente não e o vigente!';\n      goto FIM;\n    end if;\n  \n    -- Preço de emergencia deve ser diferente do preço vigente\n    if :new.VLR_EMERGENCIA = :new.VLR_PRECO then\n      VC_MSG_ERRO := 'Preço de emergência igual ao preço vigente!';\n      goto FIM;\n    end if;\n  \n    :new.DT_VIGENCIA := TRUNC(sysdate);\n  \n    if NVL(VDT_FIM_PROMO, :new.DT_VIGENCIA) < :new.DT_VIGENCIA then\n      VC_MSG_ERRO := 'Promoção já encerrada!';\n      goto FIM;\n    end if;\n  \n    if NVL(VDT_FIM_CONJ, :new.DT_VIGENCIA) < :new.DT_VIGENCIA then\n      VC_MSG_ERRO := 'Conjunto já encerrado!';\n      goto FIM;\n    end if;\n  \n    -- Valida inclusão do preço novo\n    if UPDATING('IND_PRECO_NOVO')\n       and NVL(:new.IND_PRECO_NOVO, '^') = 'N' then\n      VC_MSG_ERRO := 'Impossível desmarcar a geração. Exclua o preço gerado!';\n      goto FIM;\n    end if;\n  \n  end if;\n\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend TRG_BIUD_BEG_PRD_PRECO;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_AIU_BEG_PRD_PRECO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que insere o novo preco quando e solicitado no cadastramento da emergencia.\n   Módulo.......: PRD - Produtos\n   Analista.....: Tiago Gabriel\n   Alterações:\n   Data        Desenvolvedor  Alteração\n   04/04/2007  Tiago Gabriel  Criação.\n   30/11/2007  Tiago Gabriel  Implementada busca do preço pelo plano padrão de habilitação de\n                              celulares.\n  --------------------------------------------------------------------------------------------------- */\n  pragma autonomous_transaction;\n\n  VDT_FIM_PROMO       BEG_PRD_PROMOCAO.DT_FIM%type;\n  VN_DUMMY            number;\n  VN_BEG_CEL_PLANO_ID BEG_PRODUTO.BEG_CEL_PLANO_ID%type;\n\nbegin\n  -- Busca plano padrão para habilitação de celulares\n  select BEG_CEL_PLANO_ID\n    into VN_BEG_CEL_PLANO_ID\n    from BEG_PRODUTO\n   where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n\n  VDT_FIM_PROMO := TO_DATE(BEG_FNC_PRD_PROMOCAO(:new.AD_ORG_ID,\n                                                :new.BEG_PRODUTO_ID,\n                                                :new.BEG_PRD_SKU_ID,\n                                                VN_BEG_CEL_PLANO_ID,\n                                                'DF',\n                                                :new.DT_VIGENCIA + 1),\n                           'dd/mm/rrrr');\n\n  select count(1)\n    into VN_DUMMY\n    from BEG_PRD_PRECO\n   where AD_CLIENT_ID = :new.AD_CLIENT_ID\n     and AD_ORG_ID = :new.AD_ORG_ID\n     and DT_INICIO = :new.DT_VIGENCIA + 1\n     and VLR_PRECO = :new.VLR_EMERGENCIA\n     and BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n     and BEG_PRD_SKU_ID = :new.BEG_PRD_SKU_ID\n     and NVL(BEG_CEL_PLANO_ID, 0) = NVL(VN_BEG_CEL_PLANO_ID, 0)\n     and NVL(BEG_PRD_PROMOCAO_ID, 0) =\n         DECODE(SIGN((:new.DT_VIGENCIA + 1) -\n                     NVL(VDT_FIM_PROMO, :new.DT_VIGENCIA + 1)),\n                1,\n                0,\n                :new.BEG_PRD_PROMOCAO_ID)\n     and NVL(BEG_PRD_CONJUNTO_ID, 0) = NVL(:new.BEG_PRD_CONJUNTO_ID, 0);\n\n  if VN_DUMMY = 0 then\n    insert into BEG_PRD_PRECO P\n      (P.BEG_PRD_PRECO_ID,\n       P.AD_CLIENT_ID,\n       P.AD_ORG_ID,\n       P.CREATEDBY,\n       P.UPDATEDBY,\n       P.DT_INICIO,\n       P.VLR_PRECO,\n       P.BEG_PRODUTO_ID,\n       P.BEG_PRD_SKU_ID,\n       P.BEG_PRD_PROMOCAO_ID,\n       P.BEG_PRD_CONJUNTO_ID,\n       P.BEG_CEL_PLANO_ID)\n    values\n      (BEG_FNC_AD_SEQUENCE('BEG_PRD_PRECO') -- beg_prd_preco_id\n      ,\n       :new.AD_CLIENT_ID -- ad_client_id\n      ,\n       :new.AD_ORG_ID -- ad_org_id\n      ,\n       :new.UPDATEDBY -- createdby\n      ,\n       :new.UPDATEDBY -- updatedby\n      ,\n       :new.DT_VIGENCIA + 1 -- dt_inicio\n      ,\n       :new.VLR_EMERGENCIA -- vlr_preco\n      ,\n       :new.BEG_PRODUTO_ID -- beg_produto_id\n      ,\n       :new.BEG_PRD_SKU_ID -- beg_prd_sku_id\n      ,\n       DECODE(SIGN((:new.DT_VIGENCIA + 1) -\n                   NVL(VDT_FIM_PROMO, :new.DT_VIGENCIA + 1)),\n              1,\n              null -- Caso a data de vigencia seja maior que a data final da promoção, o preço fica fora dela\n             ,\n              :new.BEG_PRD_PROMOCAO_ID) -- beg_prd_promocao_id\n      ,\n       :new.BEG_PRD_CONJUNTO_ID -- beg_prd_conjunto_id\n      ,\n       VN_BEG_CEL_PLANO_ID); -- beg_cel_plano_id\n  \n    commit;\n  \n  end if;\n\nend TRG_AIU_BEG_PRD_PRECO;\n"}`;
    
    }
}
