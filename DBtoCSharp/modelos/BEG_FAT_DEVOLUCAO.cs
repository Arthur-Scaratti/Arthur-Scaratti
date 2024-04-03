
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FAT_DEVOLUCAO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_COFINS { get; set; }
        
        /// <summary>
        /// Indicativo de nova compra pelo cliente
        /// </summary>
        public string IND_NOVA_VENDA { get; set; }
        
        /// <summary>
        /// ID do Novo Pedido
        /// </summary>
        public int DIE_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// Indica se havera devolucao de valores para o cliente
        /// </summary>
        public string IND_DEVOLUCAO_VALORES { get; set; }
        
        /// <summary>
        /// ID da tabela Motivo Devolucao
        /// </summary>
        public int DIE_MOTIVO_DEVOL_ID { get; set; }
            [StringLength(300)]
        /// <summary>
        /// Detalhamento do motivo da devolucao
        /// </summary>
        public string MOTIVO_DEVOLUCAO { get; set; }
        
        /// <summary>
        /// Indica se o produto da primeira compra esta lacrado
        /// </summary>
        public string IND_PROD_LACRADO { get; set; }
        
        /// <summary>
        /// Indica se o produto ficara na loja
        /// </summary>
        public string IND_PROD_LOJA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica se e-mail de autorizacao de emissao foi enviado
        /// </summary>
        public string IND_EMAIL_ENV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_TIPO_FRETE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_TIPO_PEDIDO_ID { get; set; }
            [StringLength(44)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE_NF_REFERENCIADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
        
        /// <summary>
        /// Id do almoxarifado
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PREPOSTO_ID { get; set; }
        
        /// <summary>
        /// ID da nota saida
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_DEVOLUCAO_ID { get; set; }
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
        /// 
        /// </summary>
        public int NRO_NFS { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE_NFS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NRO_DUPLICATA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ISENTA_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_OUTRAS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ISENTA_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_OUTRAS_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_FRETE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_SEGURO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOTAL_PROD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOTAL_NFS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PLACA_VEICULO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string UF_VEICULO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PLACA_VEICULO_REDES { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string UF_VEICULO_REDES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_CUSTO_FINANCEIRO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NRO_CUPON_FISCAL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE_MAQUINA { get; set; }
            [StringLength(300)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COMISSAO_PEDIDO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string INTEGRADO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string FATURAVEL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_SAIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTHR_ADORG { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_DESP_FINANCEIRA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string GERADO_ARQ_EDI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PESSOA_ENTREGA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_REPRESENTANTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TRANSPORTADORA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_REDESPACHO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CFOP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMISSAO_VENDEDOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMISSAO_TELEVENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_VOLUME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PESO_LIQUIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PESO_BRUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CANCELAMENTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CANCELADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESC_SUFRAMA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ACEITE_ENTRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string REGERAR_NFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DEVOLUCAO_INTEGRAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// Padrao = 'N'. Para reabrir no portal deve ser  = 'G'. Concluido  = 'Y'
        /// </summary>
        public string IND_CONVERTIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NF_ENTRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_TRANSF_SC { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BI_FAT_DEVOL { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  -- local variables here\n  cursor BUSCA_NF is\n    select N.BEG_FAT_NFS_ID,\n           N.AD_ORG_ID,\n           N.NRO_DUPLICATA,\n           N.PERC_ICMS,\n           N.VL_BASE_CALCULO_ICMS,\n           N.VL_BASE_ISENTA_ICMS,\n           N.VL_BASE_OUTRAS_ICMS,\n           N.VL_ICMS,\n           N.VL_BASE_CALCULO_IPI,\n           N.VL_BASE_ISENTA_IPI,\n           N.VL_BASE_OUTRAS_IPI,\n           N.VL_IPI,\n           N.VL_BASE_ICMS_SUBST,\n           N.VL_ICMS_SUBST,\n           N.VL_FRETE,\n           N.VL_SEGURO,\n           N.VL_OUTRAS_DESPESAS,\n           N.PERC_DESCONTO,\n           N.VL_TOTAL_PROD - NVL(N.VL_SEGUROS, 0) VL_TOTAL_PROD,\n           N.VL_TOTAL_NFS - NVL(N.VL_SEGUROS, 0) - NVL(N.VL_GARANTIA, 0) VL_TOTAL_NFS,\n           N.VL_TOTAL_NFS VL_TOTAL_GER,\n           N.PLACA_VEICULO,\n           N.UF_VEICULO,\n           N.PLACA_VEICULO_REDES,\n           N.UF_VEICULO_REDES,\n           N.VL_CUSTO_FINANCEIRO,\n           N.NRO_CUPON_FISCAL,\n           N.SERIE_MAQUINA,\n           N.OBS,\n           N.PERC_COMISSAO_PEDIDO,\n           N.INTEGRADO,\n           N.FATURAVEL,\n           N.DT_SAIDA,\n           N.DTHR_ADORG_ID,\n           N.VL_DESP_FINANCEIRA,\n           N.GERADO_ARQ_EDI,\n           N.BEG_VW_PESSOA_ENTREGA_ID,\n           N.BEG_VW_REPRESENTANTE_ID,\n           N.BEG_VW_TRANSPORTADORA_ID,\n           N.BEG_VW_REDESPACHO_ID,\n           N.BEG_CONDICAO_PAGAMENTO_ID,\n           N.BEG_BANCO_ID,\n           N.BEG_CFOP_ID,\n           N.BEG_EST_TP_ESPECIE_ID,\n           N.COMISSAO_VENDEDOR,\n           N.COMISSAO_TELEVENDA,\n           N.QTDE_VOLUME,\n           N.PESO_LIQUIDO,\n           N.PESO_BRUTO,\n           N.DT_CANCELAMENTO,\n           N.CANCELADA,\n           N.BEG_VEN_PEDIDO_ID,\n           N.DESC_SUFRAMA,\n           N.ACEITE_ENTRADA,\n           N.REGERAR_NFE,\n           N.SERIE_NFS,\n           N.NRO_NFS,\n           N.DT_EMISSAO,\n           P.BEG_VW_PREPOSTO_ID,\n           N.VL_PIS,\n           N.VL_COFINS,\n           N.VL_BASE_CALCULO_PIS,\n           N.VL_BASE_CALCULO_COFINS,\n           P.BEG_VW_UF_ID UF_ID_CLI,\n           PF.BEG_VW_UF_ID UF_ID_FIL,\n           N.DIE_GER_VENDEDOR_ID,\n           n.vlr_desconto,\n           N.DIE_CRC_RECIBO_ID,\n           N.CHAVE\n      from BEG_FAT_NFS    N,\n           BEG_VEN_PEDIDO P,\n           --  BEG_VW_PESSOA_ENTREGA PE,\n           BEG_PESSOA      P,\n           BEG_DADO_FILIAL DF,\n           BEG_PESSOA      PF\n     where P.BEG_VEN_PEDIDO_ID(+) = N.BEG_VEN_PEDIDO_ID\n       AND N.BEG_VW_PESSOA_ENTREGA_ID = P.BEG_PESSOA_ID ---PE.BEG_VW_PESSOA_ENTREGA_ID\n          --    AND PE.beg_pessoa_id = P.BEG_PESSOA_ID\n       AND N.AD_ORG_ID = DF.AD_ORG_ID\n       AND PF.BEG_PESSOA_ID = DF.BEG_PESSOA_ID\n       AND N.BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID;\n  V_NOTA BUSCA_NF%rowtype;\n  -----\n  V_ID NUMBER;\n  CURSOR C_RECIBO IS\n    SELECT R.NRRECIBO\n      FROM DIE_CRC_RECIBO R\n     WHERE R.DIE_CRC_RECIBO_ID = V_ID;\n  R_RECIBO C_RECIBO%ROWTYPE;\n\n  -- aok - 25/06/2013 ----------------------------------------------------------\n  cursor CNFSQTD is\n    select sum(I.QTDE) QTDE\n      from BEG_FAT_NFS_ITEM I\n     where I.BEG_FAT_NFS_ID = V_NOTA.BEG_FAT_NFS_ID;\n  VN_QTD_NFSAI number := 0;\n  --\n  cursor CQTDDEV is\n    select sum(DI.QTD_DEVOLVIDA) QTD_DEVOL\n      from BEG_HST_NOTA_FISCAL DI\n     where DI.BEG_FAT_NFS_ITEM_ID in\n           (select BEG_FAT_NFS_ITEM_ID\n              from BEG_FAT_NFS_ITEM NI\n             where NI.BEG_FAT_NFS_ID = V_NOTA.BEG_FAT_NFS_ID);\n  VN_QTD_JA_DEVOL number := 0;\n\n  CURSOR C_USER IS\n    SELECT NVL(P.BEG_VEN_TIPO_PEDIDO_ID, 1) PEDIDO_ID\n      FROM DIE_USER_TP_PEDIDO P\n     WHERE P.AD_USER_ID = :NEW.CREATEDBY\n       AND P.BEG_VEN_TIPO_PEDIDO_ID = :NEW.BEG_VEN_TIPO_PEDIDO_ID\n       AND P.ISACTIVE = 'Y';\n  R_USER C_USER%ROWTYPE;\n\n  ------------------------------------------------------------------------------\nbegin\n  --\n\n\n  IF :NEW.IND_CONVERTIDA IS NULL THEN\n    :NEW.IND_CONVERTIDA := 'G';\n  END IF;\n\n  --\n  open BUSCA_NF;\n  fetch BUSCA_NF\n    into V_NOTA;\n  if BUSCA_NF%notfound then\n    RAISE_APPLICATION_ERROR(-20501, 'Nota fiscal de saida inexistente');\n  end if;\n  close BUSCA_NF;\n  -------\n  IF V_NOTA.AD_ORG_ID <> :NEW.AD_ORG_ID THEN\n\n    RAISE_APPLICATION_ERROR(-20501,\n                            'Filial informada diferente da filial emissora da nf de venda');\n\n  END IF;\n\n  -- AOK - 09/05/2013 ----------------------------------------------------------\n  if V_NOTA.CANCELADA = 'Y' then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Nota fiscal de saida esta cancelada em ' ||\n                            TO_CHAR(V_NOTA.DT_CANCELAMENTO, 'dd/mm/rrrr'));\n  end if;\n  -- aok - 25/06/2013 ----------------------------------------------------------\n -- if NVL(V_NOTA.BEG_FAT_NFS_ID, 0) > 0 then\n    open CNFSQTD;\n    fetch CNFSQTD\n      into VN_QTD_NFSAI;\n    if CNFSQTD%notfound then\n      RAISE_APPLICATION_ERROR(-20002,\n                              'Erro ao buscar os itens da Nota fiscal Saida.');\n    end if;\n    close CNFSQTD;\n    --\n    open CQTDDEV;\n    fetch CQTDDEV\n      into VN_QTD_JA_DEVOL;\n    close CQTDDEV;\n    --\n    if NVL(VN_QTD_JA_DEVOL, 0) > 0 and :new.devolucao_integral = 'Y' then\n       RAISE_APPLICATION_ERROR(-20001,\n                              'Nota Fiscal Saida ja foi devolvida parcialmente e marcado como devolucao total. Verifique!');\n\n    end if;\n\n    if NVL(VN_QTD_JA_DEVOL, 0) = VN_QTD_NFSAI then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Nota Fiscal Saida ja foi totalmente devolvida');\n    end if;\n\n    if VN_QTD_NFSAI = 1 then\n\n      :NEW.DEVOLUCAO_INTEGRAL := 'Y';\n\n    end if;\n\n--  end if;\n  ------------------------------------------------------------------------------\n  if V_NOTA.UF_ID_CLI <> V_NOTA.UF_ID_FIL THEN\n    :NEW.BEG_VEN_TIPO_PEDIDO_ID := 2000038;\n    :NEW.CHAVE_NF_REFERENCIADA  := TRIM(V_NOTA.CHAVE);\n  else\n    :NEW.BEG_VEN_TIPO_PEDIDO_ID := 2000017;\n  end if;\n-----\n  IF INSERTING AND :NEW.CREATEDBY <> 1000000 AND\n     :NEW.AD_ORG_ID IN (1000016, 1000134) THEN\n\n    open C_USER;\n    fetch C_USER\n      into R_USER;\n    close C_USER;\n\n    if NVL(R_USER.PEDIDO_ID, 1) = 1 then\n      RAISE_APPLICATION_ERROR(-20501,\n                              'Usuario sem autorização para emitir devolucao!!');\n    end if;\n\n  END IF;\n\n\n-----\n  :NEW.NRO_DUPLICATA := V_NOTA.NRO_DUPLICATA;\n  :NEW.PERC_ICMS     := V_NOTA.PERC_ICMS;\n  if :NEW.DEVOLUCAO_INTEGRAL = 'Y' then\n    :NEW.VL_TOTAL_PROD          := V_NOTA.VL_TOTAL_PROD;\n    :NEW.VL_TOTAL_NFS           := V_NOTA.VL_TOTAL_NFS;\n    :NEW.VL_BASE_CALCULO_ICMS   := V_NOTA.VL_BASE_CALCULO_ICMS;\n    :NEW.VL_BASE_ISENTA_ICMS    := V_NOTA.VL_BASE_ISENTA_ICMS;\n    :NEW.VL_BASE_OUTRAS_ICMS    := V_NOTA.VL_BASE_OUTRAS_ICMS;\n    :NEW.VL_ICMS                := V_NOTA.VL_ICMS;\n    :NEW.VL_BASE_CALCULO_IPI    := V_NOTA.VL_BASE_CALCULO_IPI;\n    :NEW.VL_BASE_ISENTA_IPI     := V_NOTA.VL_BASE_ISENTA_IPI;\n    :NEW.VL_BASE_OUTRAS_IPI     := V_NOTA.VL_BASE_OUTRAS_IPI;\n    :NEW.VL_IPI                 := V_NOTA.VL_IPI;\n    :NEW.VL_BASE_ICMS_SUBST     := V_NOTA.VL_BASE_ICMS_SUBST;\n    :NEW.VL_ICMS_SUBST          := V_NOTA.VL_ICMS_SUBST;\n    :NEW.VL_FRETE               := V_NOTA.VL_FRETE;\n    :NEW.VL_SEGURO              := V_NOTA.VL_SEGURO;\n    :NEW.VL_OUTRAS_DESPESAS     := V_NOTA.VL_OUTRAS_DESPESAS;\n    :NEW.PERC_DESCONTO          := V_NOTA.PERC_DESCONTO;\n    :NEW.VL_PIS                 := V_NOTA.VL_PIS;\n    :NEW.VL_COFINS              := V_NOTA.VL_COFINS;\n    :NEW.VL_BASE_CALCULO_PIS    := V_NOTA.VL_BASE_CALCULO_PIS;\n    :NEW.VL_BASE_CALCULO_COFINS := V_NOTA.VL_BASE_CALCULO_COFINS;\n    :NEW.VL_CUSTO_FINANCEIRO    := V_NOTA.VL_CUSTO_FINANCEIRO;\n    :NEW.VL_DESCONTO            := V_NOTA.VLR_DESCONTO;\n  else\n    :NEW.VL_TOTAL_PROD        := 0;\n    :NEW.VL_TOTAL_NFS         := 0;\n    :NEW.VL_BASE_CALCULO_ICMS := 0;\n    :NEW.VL_BASE_ISENTA_ICMS  := 0;\n    :NEW.VL_BASE_OUTRAS_ICMS  := 0;\n    :NEW.VL_ICMS              := 0;\n    :NEW.VL_BASE_CALCULO_IPI  := 0;\n    :NEW.VL_BASE_ISENTA_IPI   := 0;\n    :NEW.VL_BASE_OUTRAS_IPI   := 0;\n    :NEW.VL_IPI               := 0;\n    :NEW.VL_BASE_ICMS_SUBST   := 0;\n    :NEW.VL_ICMS_SUBST        := 0;\n    :NEW.VL_FRETE             := 0;\n    :NEW.VL_SEGURO            := 0;\n    :NEW.VL_OUTRAS_DESPESAS   := 0;\n    :NEW.PERC_DESCONTO        := 0;\n    :NEW.VL_CUSTO_FINANCEIRO :=  0;\n    :NEW.VL_DESCONTO          := 0;\n  end if;\n  :NEW.PLACA_VEICULO       := V_NOTA.PLACA_VEICULO;\n  :NEW.UF_VEICULO          := V_NOTA.UF_VEICULO;\n  :NEW.PLACA_VEICULO_REDES := V_NOTA.PLACA_VEICULO_REDES;\n  :NEW.UF_VEICULO_REDES    := V_NOTA.UF_VEICULO_REDES;\n  :NEW.NRO_CUPON_FISCAL    := V_NOTA.NRO_CUPON_FISCAL;\n  :NEW.SERIE_MAQUINA       := V_NOTA.SERIE_MAQUINA;\n  :NEW.SERIE_NFS           := V_NOTA.SERIE_NFS;\n  :NEW.NRO_NFS             := V_NOTA.NRO_NFS;\n  :NEW.DT_EMISSAO          := V_NOTA.DT_EMISSAO;\n  IF :NEW.AD_ORG_ID IN (1000016, 1000134) THEN\n    :NEW.OBS := 'Devolucao referente nf: ' || :new.nro_nfs || ' do dia :' ||\n                :new.dt_emissao || '  ' || TRIM(V_NOTA.OBS);\n  ELSE\n    IF :NEW.DEVOLUCAO_INTEGRAL = 'Y' THEN\n      IF V_NOTA.DIE_CRC_RECIBO_ID IS NULL THEN\n        :NEW.OBS := SUBSTR('Devolucao Total referente nf: ' || :new.nro_nfs ||\n                           ' do dia :' || :new.dt_emissao ||\n                           ' Valor Total Devolvido NF+Garantia+Protecao+Seguros+TF:  R$' ||\n                           TO_CHAR(V_NOTA.VL_TOTAL_GER, '999g999d00') /*|| '  ' ||\n                                               TRIM(V_NOTA.OBS)*/,\n                           1,\n                           300);\n      ELSE\n        V_ID := V_NOTA.DIE_CRC_RECIBO_ID;\n\n        open C_RECIBO;\n        fetch C_RECIBO\n          into R_RECIBO;\n        close C_RECIBO;\n\n        :NEW.OBS := SUBSTR('Devolucao Total referente nf: ' || :new.nro_nfs ||\n                           ' do dia :' || :new.dt_emissao ||\n                           ' Valor Total Devolvido NF+Garantia+Protecao+Seguros+TF:  R$' ||\n                           TO_CHAR(V_NOTA.VL_TOTAL_GER, '999g999d00') ||\n                           ' Pago com o recibo n.: ' || R_RECIBO.NRRECIBO /*|| '  ' ||\n                                               TRIM(V_NOTA.OBS)*/,\n                           1,\n                           300);\n      END IF;\n    ELSE\n      :NEW.OBS := 'Devolucao Parcial referente nf: ' || :new.nro_nfs ||\n                  ' do dia :' || :new.dt_emissao /*|| '  ' ||\n                        TRIM(V_NOTA.OBS)*/\n       ;\n    END IF;\n  END IF;\n  :NEW.PERC_COMISSAO_PEDIDO      := V_NOTA.PERC_COMISSAO_PEDIDO;\n  :NEW.INTEGRADO                 := 'N';\n  :NEW.FATURAVEL                 := V_NOTA.FATURAVEL;\n  :NEW.DTHR_ADORG                := sysdate;\n  :NEW.VL_DESP_FINANCEIRA        := V_NOTA.VL_DESP_FINANCEIRA;\n  :NEW.GERADO_ARQ_EDI            := 'N';\n  :NEW.BEG_VW_PESSOA_ENTREGA_ID  := V_NOTA.BEG_VW_PESSOA_ENTREGA_ID;\n  :NEW.BEG_VW_REPRESENTANTE_ID   := V_NOTA.BEG_VW_REPRESENTANTE_ID;\n  :NEW.BEG_VW_TRANSPORTADORA_ID  := V_NOTA.BEG_VW_TRANSPORTADORA_ID;\n  :NEW.BEG_VW_REDESPACHO_ID      := V_NOTA.BEG_VW_REDESPACHO_ID;\n  :NEW.BEG_CONDICAO_PAGAMENTO_ID := V_NOTA.BEG_CONDICAO_PAGAMENTO_ID;\n  :NEW.BEG_BANCO_ID              := V_NOTA.BEG_BANCO_ID;\n  :NEW.COMISSAO_VENDEDOR         := 0;\n  :NEW.COMISSAO_TELEVENDA        := 0;\n  :NEW.QTDE_VOLUME               := 0;\n  :NEW.PESO_LIQUIDO              := 0;\n  :NEW.PESO_BRUTO                := 0;\n  :NEW.DT_CANCELAMENTO           := null;\n  :NEW.CANCELADA                 := 'N';\n  :NEW.BEG_VEN_PEDIDO_ID         := V_NOTA.BEG_VEN_PEDIDO_ID;\n  :NEW.DESC_SUFRAMA              := V_NOTA.DESC_SUFRAMA;\n  :NEW.ACEITE_ENTRADA            := V_NOTA.ACEITE_ENTRADA;\n  :NEW.REGERAR_NFE               := 'N';\n  :NEW.BEG_VW_PREPOSTO_ID        := V_NOTA.BEG_VW_PREPOSTO_ID;\n  :NEW.DIE_GER_VENDEDOR_ID       := V_NOTA.DIE_GER_VENDEDOR_ID;\n  :NEW.BEG_EST_TP_ESPECIE_ID     := 2000013;\n  :NEW.BEG_TIPO_NF_ID            := 1000004;\n  --:NEW.BEG_FAT_NFS_ID            := V_NOTA.BEG_FAT_NFS_ID; -- aok - 25/06/2013\n  --\nend BEG_TRG_BI_FAT_DEVOL;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BD_FAT_DEV_CLIENTE { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  -- local variables here\nbegin\n  --\n  if :OLD.IND_CONVERTIDA = 'Y' then\n    RAISE_APPLICATION_ERROR(-20001, 'Processo ja foi converido!');\n  end if;\n  --\n  delete from BEG_FAT_DEVOLUCAO_ITEM X\n   where X.BEG_FAT_DEVOLUCAO_ID = :OLD.BEG_FAT_DEVOLUCAO_ID;\n  --\nend BEG_TRG_BD_FAT_DEV_CLIENTE;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_AI_FAT_DEV { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  -- local variables here\n\n  V_PRODUTO_ID          NUMBER(10);\n  v_VL_BASE_CALCULO_PIS number(18, 2) := 0;\n  V_ALIQ_PIS            number(18, 2) := 0;\n  v_VL_PIS              number(18, 2) := 0;\n  V_ALIQ_COFINS         number(18, 2) := 0;\n  v_VL_COFINS           number(18, 2) := 0;\n  v_seq                 number:=0;\n\n  --\n  cursor busca_item is\n    select distinct i.ad_client_id,\n                    i.ad_org_id,\n                    i.isactive,\n                    i.value,\n                    i.created,\n                    i.createdby,\n                    i.updated,\n                    i.updatedby,\n                    i.nro_nfs,\n                    i.serie_nfs,\n                    i.dt_emissao,\n                    i.qtde,\n                    i.vl_unitario,\n                    i.vl_custo_produto,\n                    i.vl_custo_financeiro,\n                    i.perc_comissao,\n                    i.nro_nfs_entrega_fut,\n                    i.linha_nfs_entrega_fut,\n                    i.vl_desconto,\n                    nvl(trim(i.desc_tecnica_item), p.desc_resumida) desc_tecnica_item,\n                    i.nro_patrimonio,\n                    i.entregue,\n                    i.gera_reserva,\n                    i.obs_linha_nfs,\n                    i.perc_icms,\n                    i.perc_reducao,\n                    i.vl_icms,\n                    i.vl_base_calculo_icms,\n                    i.vl_base_isenta_icms,\n                    i.vl_base_outras_icms,\n                    i.perc_ipi,\n                    i.vl_ipi,\n                    i.vl_base_calculo_ipi,\n                    i.vl_base_isenta_ipi,\n                    i.vl_base_outras_ipi,\n                    i.vl_icms_subst,\n                    i.vl_base_subst_trib,\n                    --i.p aliq_icms_subst ,\n                    i.vl_frete_item,\n                    nvl(i.beg_fis_origem_merc_id, pc.beg_fis_origem_merc_id) beg_fis_origem_merc_id,\n                    i.beg_fat_nfs_id,\n                    i.beg_fat_nfs_item_id, -- AOK - 25/06/2013\n                    i.beg_est_movto_estoque_id,\n                    i.beg_produto_id,\n                    i.beg_fis_trib_icms_id,\n                    i.beg_prd_sku_id,\n                    i.beg_cfop_id,\n                    i.icms_frete,\n                    --i.beg_fis_matriz_tributaria_id,\n                    i.cst_pis,\n                    i.Cst_Cofins,\n                    t.cod_trib_icms cst,\n                    NVL(I.VL_PIS, 0) VL_PIS,\n                    NVL(I.VL_COFINS, 0) VL_COFINS,\n                    NVL(I.VL_BASE_CALCULO_PIS, 0) VL_BASE_CALCULO_PIS,\n                    NVL(I.VL_BASE_CALCULO_COFINS, 0) VL_BASE_CALCULO_COFINS,\n                    p.die_cod_estruturado\n\n      from beg_fat_nfs_item  i,\n           beg_prd_contabil  pc,\n           beg_produto       p,\n           BEG_FIS_TRIB_ICMS t\n    /*,\n    beg_fat_pre_nfs_item pi,\n    beg_fis_matriz_tributaria ua*/\n     where i.beg_fat_nfs_id = :new.beg_fat_nfs_id -- aok - 25/06/2013\n       and PC.BEG_PRODUTO_ID = I.BEG_PRODUTO_ID\n       and i.beg_produto_id = p.beg_produto_id\n       and p.die_cod_estruturado not like 'S%'\n       and i.beg_fis_trib_icms_id = t.beg_fis_trib_icms_id(+)\n    --   and pi.beg_fat_pre_nfs_id = i.beg_fat_nfs_id -- aok - 25/06/2013\n    --   and PI.BEG_PRODUTO_ID     = I.BEG_PRODUTO_ID\n    --   and PI.BEG_PRD_SKU_ID     = I.BEG_PRD_SKU_ID\n    --   and PI.QTDE               = I.QTDE\n    --   and ua.beg_fis_matriz_tributaria_id = pi.beg_fis_matriz_tributaria_id\n    ;\n  --\n  v_item busca_item%rowtype;\n  ------\n\n  cursor BUSCA_PESSOA_UF is\n  /*select C.BEG_UF_ID,\n             'S' CONTRIBUINTE,\n             PE.IND_CONSUMIDOR CONSUMIDOR,\n             --P.PESO,\n             P.BEG_VEN_TIPO_PEDIDO_ID,\n             CL.SUFRAMA,\n             PF.BEG_VW_UF_ID UF_ORIGEM,\n             'N' CLIENTE_OPTANTE_SIMPLES\n        from DIE_PEDIDO P,\n             BEG_CIDADE     C,\n             BEG_CLIENTE    CL,\n             BEG_UF         UF,\n             BEG_PESSOA     PE,\n   --          BEG_FRO_ROTA    RT,\n             BEG_DADO_FILIAL F, -- Filial do pedido\n             BEG_PESSOA      PF, -- Uf ref. filial do pedido\n             BEG_DADO_FILIAL F1, -- Filial da nota\n             BEG_PESSOA      PF1 -- Uf ref. filial da nota\n       where P.DIE_PEDIDO_ID = VREG1.BEG_VEN_PEDIDO_ID\n         and C.BEG_CIDADE_ID = PE.BEG_CIDADE_ID\n         and UF.BEG_UF_ID = C.BEG_UF_ID\n         and CL.BEG_PESSOA_ID(+) = P.BEG_PESSOA_ID\n         and PE.BEG_PESSOA_ID = P.BEG_PESSOA_ID\n  --       and RT.BEG_FRO_ROTA_ID(+) = P.BEG_FRO_ROTA_ID\n         and F.AD_ORG_ID = P.AD_ORG_ID\n         and PF.BEG_PESSOA_ID = F.BEG_PESSOA_ID\n         and F1.AD_ORG_ID = :new.ad_org_id\n         and PF1.BEG_PESSOA_ID = F1.BEG_PESSOA_ID\n      union*/\n    select C.BEG_UF_ID,\n           'S' CONTRIBUINTE,\n           PE.IND_CONSUMIDOR CONSUMIDOR,\n           -- 0 PESO,\n           --VREG1.BEG_VEN_TIPO_PEDIDO_ID BEG_VEN_TIPO_PEDIDO_ID,\n           CL.SUFRAMA,\n           PF.BEG_VW_UF_ID UF_ORIGEM,\n           'N'\n      from BEG_CIDADE            C,\n           BEG_PESSOA            PE,\n           BEG_CLIENTE           CL,\n           BEG_UF                UF,\n           BEG_DADO_FILIAL       F, -- Filial do pedido\n           BEG_PESSOA            PF, -- Uf ref. filial do pedido\n           BEG_DADO_FILIAL       F1, -- Filial da nota\n           BEG_PESSOA            PF1, -- Uf ref. filial da nota\n           BEG_VW_PESSOA_ENTREGA PEN\n     where C.BEG_CIDADE_ID = PE.BEG_CIDADE_ID\n       and UF.BEG_UF_ID = C.BEG_UF_ID\n       and PE.BEG_PESSOA_ID = PEN.beg_pessoa_id\n       and PEN.BEG_VW_PESSOA_ENTREGA_ID = :NEW.BEG_VW_PESSOA_ENTREGA_ID\n       and CL.BEG_PESSOA_ID(+) = PE.BEG_PESSOA_ID\n       and F.AD_ORG_ID = :NEW.AD_ORG_ID\n       and PF.BEG_PESSOA_ID = F.BEG_PESSOA_ID\n       and F1.AD_ORG_ID = :NEW.AD_ORG_ID\n       and PF1.BEG_PESSOA_ID = F1.BEG_PESSOA_ID\n    /* union\n    select VREG1.BEG_UF_ID BEG_UF_ID,\n           'S' CONTRIBUINTE,\n           PE.IND_CONSUMIDOR CONSUMIDOR,\n          -- 0 PESO,\n           --VREG1.BEG_VEN_TIPO_PEDIDO_ID,\n           CL.SUFRAMA,\n           PF1.BEG_VW_UF_ID UF_ORIGEM,\n           'N'\n      from BEG_PESSOA      PE,\n           BEG_CLIENTE     CL,\n           BEG_DADO_FILIAL F1, -- Filial da nota\n           BEG_PESSOA      PF1 -- Uf ref. filial da nota\n     where PE.BEG_PESSOA_ID = VREG1.BEG_VW_FORNECEDOR_ID\n       and CL.BEG_PESSOA_ID(+) = PE.BEG_PESSOA_ID\n       and F1.AD_ORG_ID = VREG1.AD_ORG_ID\n       and PF1.BEG_PESSOA_ID = F1.BEG_PESSOA_ID\n       and NVL(:NEW.TP_LANCTO_CONTABIL, 'S') = 'E'*/\n    ;\n  --\n  VREG2 BUSCA_PESSOA_UF%rowtype;\n  --\n  cursor SELECIONA_MATRIZ_ESTADO is\n    select PN.PERC_IPI IPI_NCM,\n           M.PERC_IPI,\n           m.perc_icm,\n           M.PERC_PIS,\n           M.PERC_COFINS,\n           M.PERC_ISSQN,\n           M.PERC_IRRF,\n           M.PERC_IPI_DIFERIDO,\n           M.PERC_FUNRURAL,\n           M.TP_TRIB_ICMS,\n           M.TP_TRIB_IPI,\n           T.REDUCAO,\n           D.PERC_REDUCAO PERC_REDUCAO,\n           C.BEG_CFOP_ID,\n           O.BEG_FIS_ORIGEM_MERC_ID,\n           T.BEG_FIS_TRIB_ICMS_ID,\n           O.COD_ORIG_MERC || T.COD_TRIB_ICMS CST,\n           M.DESC_SUFRAMA,\n           M.BEG_FIS_MATRIZ_TRIBUTARIA_ID,\n           N.BEG_PRODUTO_ID,\n           D.PERC_REDUCAO RE_ICMS,\n           M.PERC_ICM_SUBSTITUICAO,\n           DECODE(VREG2.UF_ORIGEM, -- Origem\n                  VREG2.BEG_UF_ID, -- Destino\n                  NVL(NU.PERC_MVAO, M.PERC_MARGEM_SUBSTITUICAO),\n                  (BEG_FNC_FIS_MVAA2(VREG2.BEG_UF_ID, -- Destino\n                                     NVL(NU1.PERC_MVAO, -- %MVAO Destino\n                                         M.PERC_MARGEM_SUBSTITUICAO),\n                                     M.PERC_ICM, ---icms interestadual\n                                     NU1.ALIQ_ICMS_INTERNA ----- icms no estado de destino\n                                     ) * 100)) PERC_MARGEM_SUBSTITUICAO, -- aok - 10/09/2012\n           M.MVA_CLIENTE_OPTANTE_SIMPLES,\n           M.BEG_FIS_CST_COFINS_ID,\n           M.BEG_FIS_CST_PIS_ID,\n           M.BEG_FIS_CST_IPI_ID,\n           CO.VALUE CST_COFINS,\n           CP.VALUE CST_PIS,\n           CI.VALUE CST_IPI,\n           nvl(CO.IND_CALCULA, 'N') IND_CALC_PIS,\n           nvl(CP.IND_CALCULA, 'N') IND_CALC_COFINS,\n           P.BEG_PRD_NCM_ID,\n           M.VALUE COD_MATRIZ\n      from BEG_PRD_CONTABIL          P,\n           BEG_FIS_NCM               N,\n           BEG_PRD_NCM_UF            NU, -- Origem\n           BEG_PRD_NCM_UF            NU1, -- Destino\n           BEG_PRD_NCM               PN,\n           BEG_FIS_CFOP              C,\n           BEG_FIS_TRIB_ICMS         T,\n           BEG_FIS_MATRIZ_TRIBUTARIA M,\n           BEG_FIS_CST_COFINS        CO,\n           BEG_FIS_CST_PIS           CP,\n           BEG_FIS_CST_IPI           CI,\n           BEG_FIS_ORIGEM_MERC       O,\n           BEG_FIS_DISPOSITIVO_LEGAL D,\n           BEG_FIS_MTZ_DISPOSITIVO   MD\n     where P.BEG_PRODUTO_ID = V_PRODUTO_ID\n       and PN.BEG_PRD_NCM_ID = P.BEG_PRD_NCM_ID\n       and N.BEG_PRD_NCM_ID = P.BEG_PRD_NCM_ID\n       and N.ISACTIVE = 'Y'\n       and (NVL(N.BEG_PRODUTO_ID, V_PRODUTO_ID) = V_PRODUTO_ID)\n       and NU.BEG_PRD_NCM_ID(+) = PN.BEG_PRD_NCM_ID\n       and NU.BEG_UF_ID(+) = VREG2.UF_ORIGEM -- Origem\n       and NU1.BEG_PRD_NCM_ID(+) = PN.BEG_PRD_NCM_ID\n       and NU1.BEG_UF_ID(+) = VREG2.BEG_UF_ID -- Destino\n       and M.BEG_FIS_MATRIZ_TRIBUTARIA_ID = N.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n       and M.BEG_VW_UF_ID = VREG2.UF_ORIGEM\n       and M.BEG_UF_ID = VREG2.BEG_UF_ID\n       and M.BEG_VEN_TIPO_PEDIDO_ID = :new.beg_ven_tipo_pedido_id --V_TP_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID\n       and M.ISACTIVE = 'Y'\n       and CO.BEG_FIS_CST_COFINS_ID(+) = M.BEG_FIS_CST_COFINS_ID\n       and CP.BEG_FIS_CST_PIS_ID(+) = M.BEG_FIS_CST_PIS_ID\n       and CI.BEG_FIS_CST_IPI_ID(+) = M.BEG_FIS_CST_IPI_ID\n       and T.BEG_FIS_TRIB_ICMS_ID = M.BEG_FIS_TRIB_ICMS_ID\n       and C.BEG_FIS_MATRIZ_TRIBUTARIA_ID = M.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n       and O.BEG_FIS_ORIGEM_MERC_ID = M.BEG_FIS_ORIGEM_MERC_ID\n       and MD.BEG_FIS_MATRIZ_TRIBUTARIA_ID(+) =\n           M.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n       and D.BEG_FIS_DISPOSITIVO_LEGAL_ID(+) = MD.BEG_VW_FIS_DISP_ICMS_ID\n       and (C.IND_CONSUMIDOR = NVL(VREG2.CONSUMIDOR, 'N') or not exists\n            (select 1\n               from BEG_FIS_MATRIZ_TRIBUTARIA MT,\n                    BEG_FIS_CFOP              BC,\n                    BEG_PRD_CONTABIL          BPC,\n                    BEG_FIS_NCM               BFN\n              where BPC.BEG_PRODUTO_ID = V_PRODUTO_ID\n                and BFN.BEG_PRD_NCM_ID = BPC.BEG_PRD_NCM_ID\n                and BFN.ISACTIVE = 'Y'\n                and MT.ISACTIVE = 'Y'\n                and (NVL(BFN.BEG_PRODUTO_ID, V_PRODUTO_ID) = V_PRODUTO_ID)\n                and MT.BEG_FIS_MATRIZ_TRIBUTARIA_ID =\n                    BFN.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n                and MT.BEG_UF_ID = VREG2.BEG_UF_ID\n                and MT.BEG_VW_UF_ID = VREG2.UF_ORIGEM\n                and MT.BEG_VEN_TIPO_PEDIDO_ID = :new.beg_ven_tipo_pedido_id\n                   --V_TP_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID\n                and BC.BEG_FIS_MATRIZ_TRIBUTARIA_ID =\n                    MT.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n                and BC.IND_CONSUMIDOR = NVL(VREG2.CONSUMIDOR, 'N')))\n     order by NVL(N.BEG_PRODUTO_ID, 9999999999);\n  --\n  cursor SELECIONA_MATRIZ_GERAL is\n    select PN.PERC_IPI IPI_NCM,\n           M.PERC_IPI,\n           m.perc_icm,\n           M.PERC_PIS,\n           M.PERC_COFINS,\n           M.PERC_ISSQN,\n           M.PERC_IRRF,\n           M.PERC_IPI_DIFERIDO,\n           M.PERC_FUNRURAL,\n           M.TP_TRIB_ICMS,\n           M.TP_TRIB_IPI,\n           T.REDUCAO,\n           D.PERC_REDUCAO PERC_REDUCAO,\n           C.BEG_CFOP_ID,\n           O.BEG_FIS_ORIGEM_MERC_ID,\n           T.BEG_FIS_TRIB_ICMS_ID,\n           O.COD_ORIG_MERC || T.COD_TRIB_ICMS CST,\n           M.DESC_SUFRAMA,\n           M.BEG_FIS_MATRIZ_TRIBUTARIA_ID,\n           N.BEG_PRODUTO_ID,\n           D.PERC_REDUCAO RE_ICMS,\n           M.PERC_ICM_SUBSTITUICAO,\n           DECODE(VREG2.UF_ORIGEM, -- Origem\n                  VREG2.BEG_UF_ID, -- Destino\n                  NVL(NU.PERC_MVAO, M.PERC_MARGEM_SUBSTITUICAO),\n                  (BEG_FNC_FIS_MVAA2(VREG2.BEG_UF_ID, -- Destino\n                                     NVL(NU1.PERC_MVAO, -- %MVAO Destino\n                                         M.PERC_MARGEM_SUBSTITUICAO),\n                                     M.PERC_ICM, ---icms interestadual\n                                     NU1.ALIQ_ICMS_INTERNA ----- icms no estado de destino\n                                     ) * 100)) PERC_MARGEM_SUBSTITUICAO,\n           M.MVA_CLIENTE_OPTANTE_SIMPLES,\n           M.BEG_FIS_CST_COFINS_ID,\n           M.BEG_FIS_CST_PIS_ID,\n           M.BEG_FIS_CST_IPI_ID,\n           CO.VALUE CST_COFINS,\n           CP.VALUE CST_PIS,\n           CI.VALUE CST_IPI,\n           nvl(CO.IND_CALCULA, 'N') IND_CALC_PIS,\n           NVL(CP.IND_CALCULA, 'N') IND_CALC_COFINS,\n           P.BEG_PRD_NCM_ID,\n           M.VALUE COD_MATRIZ\n      from BEG_PRD_CONTABIL          P,\n           BEG_FIS_NCM               N,\n           BEG_PRD_NCM_UF            NU, -- Origem\n           BEG_PRD_NCM_UF            NU1, -- Destino\n           BEG_PRD_NCM               PN,\n           BEG_FIS_CFOP              C,\n           BEG_FIS_TRIB_ICMS         T,\n           BEG_FIS_MATRIZ_TRIBUTARIA M,\n           BEG_FIS_CST_COFINS        CO,\n           BEG_FIS_CST_PIS           CP,\n           BEG_FIS_CST_IPI           CI,\n           BEG_FIS_ORIGEM_MERC       O,\n           BEG_FIS_DISPOSITIVO_LEGAL D,\n           BEG_FIS_MTZ_DISPOSITIVO   MD\n     where P.BEG_PRODUTO_ID = V_PRODUTO_ID\n       and PN.BEG_PRD_NCM_ID = P.BEG_PRD_NCM_ID\n       and N.BEG_PRD_NCM_ID = P.BEG_PRD_NCM_ID\n       and (NVL(N.BEG_PRODUTO_ID, V_PRODUTO_ID) = V_PRODUTO_ID)\n       and NU.BEG_PRD_NCM_ID(+) = PN.BEG_PRD_NCM_ID\n       and NU.BEG_UF_ID(+) = VREG2.UF_ORIGEM -- Origem\n       and NU1.BEG_PRD_NCM_ID(+) = PN.BEG_PRD_NCM_ID\n       and NU1.BEG_UF_ID(+) = VREG2.BEG_UF_ID -- Destino\n       and M.BEG_FIS_MATRIZ_TRIBUTARIA_ID = N.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n       and M.BEG_VW_UF_ID = VREG2.UF_ORIGEM\n       and M.BEG_UF_ID is null\n       and M.BEG_VEN_TIPO_PEDIDO_ID = :new.beg_ven_tipo_pedido_id --V_TP_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID\n       and M.ISACTIVE = 'Y'\n       and N.ISACTIVE = 'Y'\n       and CO.BEG_FIS_CST_COFINS_ID(+) = M.BEG_FIS_CST_COFINS_ID\n       and CP.BEG_FIS_CST_PIS_ID(+) = M.BEG_FIS_CST_PIS_ID\n       and CI.BEG_FIS_CST_IPI_ID(+) = M.BEG_FIS_CST_IPI_ID\n       and T.BEG_FIS_TRIB_ICMS_ID = M.BEG_FIS_TRIB_ICMS_ID\n       and C.BEG_FIS_MATRIZ_TRIBUTARIA_ID = M.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n       and O.BEG_FIS_ORIGEM_MERC_ID = M.BEG_FIS_ORIGEM_MERC_ID\n       and MD.BEG_FIS_MATRIZ_TRIBUTARIA_ID(+) =\n           M.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n       and D.BEG_FIS_DISPOSITIVO_LEGAL_ID(+) = MD.BEG_VW_FIS_DISP_ICMS_ID\n       and (C.IND_CONSUMIDOR = NVL(VREG2.CONSUMIDOR, 'N') or not exists\n            (select 1\n               from BEG_FIS_MATRIZ_TRIBUTARIA MT,\n                    BEG_FIS_CFOP              BC,\n                    BEG_PRD_CONTABIL          BPC,\n                    BEG_FIS_NCM               BFN\n              where BPC.BEG_PRODUTO_ID = V_PRODUTO_ID\n                and BFN.BEG_PRD_NCM_ID = BPC.BEG_PRD_NCM_ID\n                and BFN.ISACTIVE = 'Y'\n                and (NVL(BFN.BEG_PRODUTO_ID, V_PRODUTO_ID) = V_PRODUTO_ID)\n                and MT.BEG_FIS_MATRIZ_TRIBUTARIA_ID =\n                    BFN.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n                and M.BEG_VW_UF_ID = VREG2.UF_ORIGEM\n                and M.BEG_UF_ID is null\n                and MT.BEG_VEN_TIPO_PEDIDO_ID = :new.beg_ven_tipo_pedido_id\n                   --V_TP_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID\n                and BC.BEG_FIS_MATRIZ_TRIBUTARIA_ID =\n                    MT.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n                and BC.IND_CONSUMIDOR = NVL(VREG2.CONSUMIDOR, 'N')))\n     order by NVL(N.BEG_PRODUTO_ID, 9999999999);\n  --\n  VREG3 SELECIONA_MATRIZ_ESTADO%rowtype;\n\n  ------\n\n  CURSOR BUSCA_HST IS\n    SELECT N.BEG_FAT_NFS_ITEM_ID\n      FROM BEG_HST_NOTA_FISCAL N\n     WHERE N.BEG_FAT_NFS_ITEM_ID = v_item.beg_fat_nfs_item_id;\n\n  R_HST BUSCA_HST%rowtype;\n\n  ------\n  ------\n  -- aok - 25/06/2013 ----------------------------------------------------------\n  cursor CQTDIDEV is\n    select NVL(sum(DI.QTD_DEVOLVIDA), 0) QTD_DEVOL\n      from BEG_HST_NOTA_FISCAL DI\n     where DI.BEG_FAT_NFS_ITEM_ID = v_item.BEG_FAT_NFS_ITEM_ID;\n  VN_QTD_ITM_JA_DEVOL number := 0;\n  ------------------------------------------------------------------------------\nbegin\n\n  open busca_item;\n  loop\n    fetch busca_item\n      into v_item;\n    exit when busca_item%notfound;\n\n    v_seq :=v_seq +1;\n\n    V_PRODUTO_ID := v_item.BEG_PRODUTO_ID;\n    open BUSCA_PESSOA_UF;\n    fetch BUSCA_PESSOA_UF\n      into VREG2;\n    close BUSCA_PESSOA_UF;\n    open SELECIONA_MATRIZ_ESTADO;\n    fetch SELECIONA_MATRIZ_ESTADO\n      into VREG3;\n    if SELECIONA_MATRIZ_ESTADO%notfound then\n      open SELECIONA_MATRIZ_GERAL;\n      fetch SELECIONA_MATRIZ_GERAL\n        into VREG3;\n      if SELECIONA_MATRIZ_GERAL%notfound then\n        RAISE_APPLICATION_ERROR(-20300,\n                                'Nao existe matriz tributaria para este item. ' ||\n                                /*V_PRODUTO_ID*/V_ITEM.DIE_COD_ESTRUTURADO || ' UF O.: ' ||\n                                VREG2.UF_ORIGEM || ' UF D: ' ||\n                                VREG2.BEG_UF_ID || ' TP: ' ||\n                                :new.BEG_VEN_TIPO_PEDIDO_ID || ' CONS: ' ||\n                                VREG2.CONSUMIDOR);\n      end if;\n      close SELECIONA_MATRIZ_GERAL;\n    end if;\n    close SELECIONA_MATRIZ_ESTADO;\n\n    IF NVL(V_ITEM.VL_PIS, 0) > 0 THEN\n      V_VL_BASE_CALCULO_PIS := V_ITEM.VL_BASE_CALCULO_PIS;\n      V_VL_PIS              := V_ITEM.VL_PIS;\n      V_VL_COFINS           := V_ITEM.VL_COFINS;\n\n    ELSE\n      IF NVL(VREG3.PERC_PIS, 0) > 0 THEN\n\n        --\n        v_VL_BASE_CALCULO_PIS := (v_item.qtde * v_item.vl_unitario) -\n                                 v_item.vl_desconto + V_ITEM.VL_FRETE_ITEM;\n        V_ALIQ_PIS            := NVL(VREG3.PERC_PIS, 0);\n        v_VL_PIS              := ROUND((NVL(v_VL_BASE_CALCULO_PIS, 0) *\n                                       NVL(V_ALIQ_PIS, 0)) / 100,\n                                       2);\n        --\n      END IF;\n      --\n      IF NVL(VREG3.PERC_COFINS, 0) > 0 THEN\n        --\n\n        v_ALIQ_COFINS := NVL(VREG3.PERC_COFINS, 0);\n        v_VL_COFINS   := ROUND((NVL(v_VL_BASE_CALCULO_PIS, 0) *\n                               NVL(v_ALIQ_COFINS, 0)) / 100,\n                               2);\n        --\n      END IF;\n    END IF;\n\n    -- aok - 25/06/2013 --------------------------------------------------------\n    open CQTDIDEV;\n    fetch CQTDIDEV\n      into VN_QTD_ITM_JA_DEVOL;\n    close CQTDIDEV;\n    ----------------------------------------------------------------------------\n    insert into beg_fat_devolucao_item\n      (BEG_FAT_DEVOLUCAO_ITEM_ID, --\n       ad_client_id, --\n       ad_org_id, --\n       isactive, --\n       value, --\n       created, --\n       createdby, --\n       updated, --\n       updatedby, --\n       nro_nfs, --\n       serie_nfs, --\n       dt_emissao, --\n       qtde, --\n       vl_unitario, --\n       vl_custo_produto, --\n       vl_custo_financeiro, --\n       perc_comissao, --\n       nro_nfs_entrega_fut, --\n       linha_nfs_entrega_fut, --\n       vl_desconto, --\n       desc_tecnica_item, --\n       nro_patrimonio, --\n       entregue, --\n       gera_reserva, --\n       obs_linha_nfs, --\n       perc_icms, --\n       perc_reducao, --\n       vl_icms, --\n       vl_base_calculo_icms, --\n       vl_base_isenta_icms, --\n       vl_base_outras_icms, --\n       perc_ipi, --\n       vl_ipi, --\n       vl_base_calculo_ipi, --\n       vl_base_isenta_ipi, --\n       vl_base_outras_ipi, --\n       vl_icms_subst, --\n       vl_base_subst_trib, --\n       vl_frete_item, --\n       beg_fis_origem_merc_id, --\n       Beg_Fat_Devolucao_ID, --\n       beg_est_movto_estoque_id, --\n       beg_produto_id, ---\n       beg_fis_trib_icms_id, --\n       beg_prd_sku_id, --\n       beg_cfop_id, --\n       icms_frete, --\n       beg_fis_matriz_tributaria_id, --\n       cst_pis, --\n       cst_cofins, --\n       cst_icms, --\n       QTD_DEVOLVIDA, --\n       beg_fat_nfs_item_id, -- 53 -- AOK - 25/06/2013\n       --perc_icms_st,\n       VL_PIS,\n       VL_COFINS,\n       VL_BASE_CALCULO_PIS,\n       VL_BASE_CALCULO_COFINS,\n       nr_item) --\n    VALUES\n      (beg_fnc_ad_sequence('BEG_FAT_DEVOLUCAO_ITEM'), --1.\n       v_item.ad_client_id, --2.\n       v_item.ad_org_id, --3.\n       --V_ITEM.ISACTIVE, --4. -- aok - 25/06/2013\n       case when V_ITEM.QTDE <= nvl(VN_QTD_ITM_JA_DEVOL, 0) then 'N' else\n       v_item.isactive end, -- 4 -- aok 25/06/2013\n       V_ITEM.VALUE, --5.\n       sysdate, --6.\n       V_ITEM.CREATEDBY, --7.\n       sysdate, --8.\n       V_ITEM.UPDATEDBY, --9.\n       V_ITEM.NRO_NFS, --10.\n       V_ITEM.SERIE_NFS, --11.\n       V_ITEM.DT_EMISSAO, --12.\n       --V_ITEM.QTDE, --13. -- aok - 25/06/2013\n       V_ITEM.QTDE /*- nvl(VN_QTD_ITM_JA_DEVOL,0)*/, --13. -- aok - 25/06/2013\n       v_item.vl_unitario, --14.\n       v_item.vl_custo_produto, --15.\n       v_item.vl_custo_financeiro, --16.\n       v_item.perc_comissao, --17.\n       v_item.nro_nfs_entrega_fut, --18.\n       v_item.linha_nfs_entrega_fut, --19.\n       v_item.vl_desconto, --20.\n       v_item.desc_tecnica_item, --21.\n       v_item.nro_patrimonio, --22.\n       v_item.entregue, --23.\n       v_item.gera_reserva, --24.\n       v_item.obs_linha_nfs, --25.\n       v_item.perc_icms, --26.\n       v_item.perc_reducao, --27.\n       v_item.vl_icms, --28.\n       v_item.vl_base_calculo_icms, --29.\n       v_item.vl_base_isenta_icms, --30.\n       v_item.vl_base_outras_icms, --31.\n       v_item.perc_ipi, --32.\n       v_item.vl_ipi, --33.\n       v_item.vl_base_calculo_ipi, --34.\n       v_item.vl_base_isenta_ipi, --35.\n       v_item.vl_base_outras_ipi, --36.\n       v_item.vl_icms_subst, --37.\n       v_item.vl_base_subst_trib, --38\n       v_item.vl_frete_item, --39\n       v_item.beg_fis_origem_merc_id, --40.\n       :NEW.BEG_FAT_DEVOLUCAO_ID, --41\n       NULL, --42.\n       v_item.beg_produto_id, --43.\n       v_item.beg_fis_trib_icms_id, --44.\n       v_item.beg_prd_sku_id, --45.\n       VREG3.beg_cfop_id, --46\n       v_item.icms_frete, --47\n       VREG3.beg_fis_matriz_tributaria_id, --48\n       VREG3.cst_pis, --49\n       VREG3.cst_cofins, --50\n       VREG3.CST, --51\n       --DECODE(:NEW.DEVOLUCAO_INTEGRAL, 'Y', V_ITEM.QTDE, 0)) --52\n       DECODE(:NEW.DEVOLUCAO_INTEGRAL,\n              'Y',\n              (V_ITEM.QTDE - nvl(VN_QTD_ITM_JA_DEVOL, 0)),\n              0), --52\n       v_item.beg_fat_nfs_item_id, -- 53 -- AOK - 25/06/2013\n       --v_item.aliq_icms_subst,\n       V_VL_PIS,\n       V_VL_COFINS,\n       V_VL_BASE_CALCULO_PIS,\n       V_VL_BASE_CALCULO_PIS,\n       v_seq);\n\n    -----  INSERE NO HISTORICO DE NOTAS\n    open BUSCA_HST;\n    fetch BUSCA_HST\n      into R_HST;\n    close BUSCA_HST;\n\n    IF R_HST.BEG_FAT_NFS_ITEM_ID IS NULL THEN\n      INSERT INTO BEG_HST_NOTA_FISCAL\n        (BEG_HST_NOTA_FISCAL_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         BEG_FAT_NFS_ID,\n         BEG_FAT_NFS_ITEM_ID,\n         BEG_CPR_NFE_ID,\n         BEG_CPR_NFE_ITEM_ID,\n         QTD_TOTAL,\n         QTD_DEVOLVIDA,\n         QTD_FALTANTE,\n         BEG_PRODUTO_ID,\n         BEG_PRD_SKU_ID)\n      VALUES\n        (beg_fnc_ad_sequence('BEG_HST_NOTA_FISCAL'),\n         v_item.AD_CLIENT_ID,\n         v_item.AD_ORG_ID,\n         'Y',\n         SYSDATE,\n         v_item.CREATEDBY,\n         SYSDATE,\n         v_item.UPDATEDBY,\n         v_item.BEG_FAT_NFS_ID,\n         v_item.BEG_FAT_NFS_ITEM_ID,\n         NULL, --BEG_CPR_NFE_ID         ,\n         NULL, --BEG_CPR_NFE_ITEM_ID    ,\n         v_item.QTDE, --QTD_TOTAL              ,\n         0, --QTD_DEVOLVIDA          ,\n         v_item.QTDE, --QTD_FALTANTE           ,\n         v_item.BEG_PRODUTO_ID,\n         v_item.BEG_PRD_SKU_ID);\n\n    END IF;\n\n    ----\n  end loop;\n  close busca_item;\n  --\nend BEG_TRG_AI_FAT_DEV;\n"}`;
    
    }
}
