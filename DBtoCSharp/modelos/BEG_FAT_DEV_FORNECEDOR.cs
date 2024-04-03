
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FAT_DEV_FORNECEDOR
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_TIPO_FRETE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FINNFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_ESPECIE_VOLUME_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_DEV_FORNECEDOR_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NFE { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE_NFE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_DUPLICATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ISENTA_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_OUTRAS_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ISENTA_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_OUTRAS_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_SEGURO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_OUTRAS_DESPESAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOTAL_PROD { get; set; }
        
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
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_CUSTO_FINANCEIRO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_CUPON_FISCAL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE_MAQUINA { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COMISSAO_PEDIDO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string INTEGRADO { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_DESP_FINANCEIRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string GERADO_ARQ_EDI { get; set; }
        
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
        public string REGERAR_NFS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DEVOLUCAO_INTEGRAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CONVERTIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NFS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TP_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_ENTRADA { get; set; }
        
        /// <summary>
        /// Id do almoxarifado
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_DEV_FORN { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  IF :NEW.BEG_VW_TRANSPORTADORA_ID IS NOT NULL THEN\n  \n    IF :NEW.BEG_GER_TIPO_FRETE_ID IS NULL THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Informado tranpostadora deve ser informado tipo de frete!');\n    END IF;\n  \n    IF nvl(:NEW.Qtde_Volume, 0) = 0 THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Informado tranpostadora deve ser informado quantidade de volumes!');\n    END IF;\n  \n    IF nvl(:NEW.PESO_BRUTO, 0) = 0 THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Informado tranpostadora deve ser informado peso bruto!');\n    END IF;\n  \n    IF nvl(:NEW.PESO_LIQUIDO, 0) = 0 THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Informado tranpostadora deve ser informado peso liquido!');\n    END IF;\n  \n    IF :NEW.BEG_FAT_ESPECIE_VOLUME_ID IS NULL THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Informado tranpostadora deve ser informado tipo de volumes!');\n    END IF;\n  \n  END IF;\n\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BI_DEV_FORN { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  -- local variables here\n  V_VL_BASE_CALCULO_ICMS number(18, 4) := 0;\n  V_VL_BASE_ISENTA_ICMS  number(18, 4) := 0;\n  V_VL_BASE_OUTRAS_ICMS  number(18, 4) := 0;\n  V_VL_ICMS              number(18, 4) := 0;\n  V_VL_BASE_CALCULO_IPI  number(18, 4) := 0;\n  V_VL_BASE_ISENTA_IPI   number(18, 4) := 0;\n  V_VL_BASE_OUTRAS_IPI   number(18, 4) := 0;\n  V_VL_IPI               number(18, 4) := 0;\n  V_VL_BASE_ICMS_SUBST   number(18, 4) := 0;\n  V_VL_ICMS_SUBST        number(18, 4) := 0;\n  V_CONTADOR_ITEM        BINARY_INTEGER := 0;\n  --\n  cursor VALIDA_NOTA is\n    select N.*\n      from BEG_CPR_NFE N\n     where N.AD_ORG_ID = :NEW.AD_ORG_ID\n       AND N.DT_ENTRADA = :NEW.DT_ENTRADA\n       AND N.BEG_VW_FORNECEDOR_ID = :NEW.BEG_VW_FORNECEDOR_ID\n       AND N.NUMERO = :NEW.NRO_NFE;\n\n  --N.BEG_CPR_NFE_ID = :NEW.BEG_CPR_NFE_ID;\n  --\n  V_VALIDA VALIDA_NOTA%rowtype;\n  --\n  cursor BUSCA_ITENS is\n    select *\n      from BEG_CPR_NFE_ITEM I\n     where I.BEG_CPR_NFE_ID = :NEW.BEG_CPR_NFE_ID;\n  ---\n  V_ITEM BUSCA_ITENS%rowtype;\n  -- aok - 31/10/2011\n  cursor CTRANSP is\n    select NVL(P.TRANSPORTADORA, 'N')\n      from BEG_PESSOA P\n     where P.BEG_PESSOA_ID = :NEW.BEG_VW_FORNECEDOR_ID;\n  VC_IND_TRANSP char(1) := 'N'; -- aok - 31/10/2011\n  --\n  CURSOR C_USUARIO IS\n    SELECT * FROM AD_USER WHERE AD_USER_ID = :NEW.CREATEDBY;\n  --\n  R_USUARIO C_USUARIO%ROWTYPE;\n  --\n  CURSOR C_USER IS\n    SELECT NVL(P.BEG_VEN_TIPO_PEDIDO_ID, 1) PEDIDO_ID\n      FROM DIE_USER_TP_PEDIDO P\n     WHERE P.AD_USER_ID = :NEW.CREATEDBY\n       AND P.BEG_VEN_TIPO_PEDIDO_ID = 2000018\n       AND P.ISACTIVE = 'Y';\n  R_USER C_USER%ROWTYPE;\n\nbegin\n\n  IF INSERTING AND :NEW.CREATEDBY <> 1000000 THEN\n  \n    open C_USER;\n    fetch C_USER\n      into R_USER;\n    close C_USER;\n  \n    if NVL(R_USER.PEDIDO_ID, 1) = 1 then\n      RAISE_APPLICATION_ERROR(-20501,\n                              'Usuario sem autorização para emitir devolucao!!');\n    end if;\n  \n  END IF;\n\n  open VALIDA_NOTA;\n  fetch VALIDA_NOTA\n    into V_VALIDA;\n  if VALIDA_NOTA%notfound then\n    RAISE_APPLICATION_ERROR(-20501,\n                            'Nota fiscal de entrada nao pertence a esta unidade e fornecedor.');\n  end if;\n  close VALIDA_NOTA;\n  /*--\n  :NEW.BEG_VW_FORNECEDOR_ID := V_VALIDA.BEG_VW_FORNECEDOR_ID;\n  --:NEW.AD_ORG_ID            := V_VALIDA.AD_ORG_ID;\n  :NEW.DT_ENTRADA           := V_VALIDA.DT_ENTRADA;\n  :NEW.SERIE_NFE            := V_VALIDA.SERIE;\n  :NEW.NRO_NFE              := V_VALIDA.NUMERO;\n  --*/\n  :NEW.BEG_CPR_NFE_ID := V_VALIDA.BEG_CPR_NFE_ID;\n  --\n  V_CONTADOR_ITEM := 0;\n  open BUSCA_ITENS;\n  loop\n    fetch BUSCA_ITENS\n      into V_ITEM;\n    exit when BUSCA_ITENS%notfound;\n    V_CONTADOR_ITEM := V_CONTADOR_ITEM + 1;\n    insert into BEG_FAT_DEV_FORNECEDOR_ITEM\n      (BEG_FAT_DEV_FORNECEDOR_ITEM_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       value,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       BEG_VW_FORNECEDOR_ID,\n       NRO_NFE,\n       SERIE_NFE,\n       DT_ENTRADA,\n       QTDE,\n       VL_UNITARIO,\n       VL_CUSTO_PRODUTO,\n       VL_CUSTO_FINANCEIRO,\n       PERC_COMISSAO,\n       NRO_NFS_ENTREGA_FUT,\n       LINHA_NFS_ENTREGA_FUT,\n       VL_DESCONTO,\n       DESC_TECNICA_ITEM,\n       NRO_PATRIMONIO,\n       ENTREGUE,\n       GERA_RESERVA,\n       OBS_LINHA_NFS,\n       PERC_ICMS,\n       PERC_REDUCAO,\n       VL_ICMS,\n       VL_BASE_CALCULO_ICMS,\n       VL_BASE_ISENTA_ICMS,\n       VL_BASE_OUTRAS_ICMS,\n       PERC_IPI,\n       VL_IPI,\n       VL_BASE_CALCULO_IPI,\n       VL_BASE_ISENTA_IPI,\n       VL_BASE_OUTRAS_IPI,\n       VL_ICMS_SUBST,\n       VL_BASE_SUBST_TRIB,\n       VL_FRETE_ITEM,\n       BEG_FIS_ORIGEM_MERC_ID,\n       BEG_FAT_DEV_FORNECEDOR_ID,\n       BEG_EST_MOVTO_ESTOQUE_ID,\n       BEG_PRODUTO_ID,\n       BEG_FIS_TRIB_ICMS_ID,\n       BEG_PRD_SKU_ID,\n       BEG_CFOP_ID,\n       ICMS_FRETE,\n       QTD_DEVOLVIDA,\n       BEG_FIS_MATRIZ_TRIBUTARIA_ID,\n       BEG_CPR_NFE_ITEM_ID,\n       CST_PIS,\n       CST_COFINS,\n       CST_ICMS,\n       BEG_FAT_NFS_ITEM_ID,\n       ALIQ_ICMS_SUBST,\n       VLR_BASE_PIS,\n       VLR_BASE_COFINS,\n       VLR_PIS,\n       VLR_COFINS,\n       VBCSTRET,\n       PST,\n       VICMSSUBSTITUTO,\n       VICMSSTRET)\n    values\n      (BEG_FNC_AD_SEQUENCE('BEG_FAT_DEV_FORNECEDOR_ITEM'),\n       V_ITEM.AD_CLIENT_ID,\n       V_ITEM.AD_ORG_ID,\n       V_ITEM.ISACTIVE,\n       V_CONTADOR_ITEM,\n       V_ITEM.CREATED,\n       V_ITEM.CREATEDBY,\n       V_ITEM.UPDATED,\n       V_ITEM.UPDATEDBY,\n       :new.BEG_VW_FORNECEDOR_ID,\n       :new.NRO_NFE,\n       :new.SERIE_NFE,\n       :new.DT_ENTRADA,\n       V_ITEM.QTD,\n       f_extrai_num_expressao(V_ITEM.VLR_UNITARIO),\n       0, --V_ITEM.VL_CUSTO_PRODUTO,\n       f_extrai_num_expressao(V_ITEM.VLR_OUTRAS_DESPESAS),\n       0, --V_ITEM.PERC_COMISSAO,\n       0, --V_ITEM.NRO_NFS_ENTREGA_FUT,\n       0, --V_ITEM.LINHA_NFS_ENTREGA_FUT,\n       f_extrai_num_expressao(V_ITEM.VLR_DESCONTO),\n       V_ITEM.DES_ITEM_FORNECEDOR,\n       null, --V_ITEM.NRO_PATRIMONIO,\n       'Y', --V_ITEM.ENTREGUE,\n       'N', --V_ITEM.GERA_RESERVA,\n       null, --V_ITEM.OBS_LINHA_NFS,\n       V_ITEM.ALQ_ICMS,\n       0, --V_ITEM.PERC_REDUCAO,\n       f_extrai_num_expressao(V_ITEM.VLR_ICMS_CALC),\n       f_extrai_num_expressao(V_ITEM.VLR_BASE_ICMS_CALC),\n       f_extrai_num_expressao(V_ITEM.VLR_BASE_ISENTO_ICMS),\n       f_extrai_num_expressao(V_ITEM.VLR_BASE_OUTROS_ICMS),\n       V_ITEM.ALQ_IPI,\n       f_extrai_num_expressao(V_ITEM.VLR_IPI_CALC),\n       f_extrai_num_expressao(V_ITEM.VLR_BASE_IPI_CALC),\n       f_extrai_num_expressao(V_ITEM.VLR_BASE_ISENTO_IPI),\n       f_extrai_num_expressao(V_ITEM.VLR_BASE_OUTROS_IPI),\n       f_extrai_num_expressao(V_ITEM.VLR_ICMS_SUBST),\n       f_extrai_num_expressao(V_ITEM.VLR_BASE_ICMS_SUBST),\n       f_extrai_num_expressao(V_ITEM.VLR_FRETE),\n       V_ITEM.BEG_FIS_ORIGEM_MERC_ID,\n       :new.BEG_FAT_DEV_FORNECEDOR_ID,\n       null, --V_ITEM.BEG_EST_MOVTO_ESTOQUE_ID,\n       V_ITEM.BEG_PRODUTO_ID,\n       V_ITEM.BEG_FIS_TRIB_ICMS_ID,\n       V_ITEM.BEG_PRD_SKU_ID,\n       V_ITEM.BEG_VW_CFOP_ENT_ID,\n       null, --v_item.icms_frete,\n       --0, -- qtd devolvida -- aok - 08/05/2013\n       DECODE(:NEW.DEVOLUCAO_INTEGRAL, 'Y', V_ITEM.QTD, 0), -- qtd devolvida -- aok - 08/05/2013\n       null, --v_item.beg_fis_matriz_tributaria_id,\n       V_ITEM.BEG_CPR_NFE_ITEM_ID,\n       v_item.cst_pis,\n       v_item.cst_cofins,\n       v_item.cst_icms,\n       null,\n       V_ITEM.ALQ_ICMS_SUBST,\n       0, --V_ITEM.VLR_BASE_PIS,\n       0, --V_ITEM.VLR_BASE_COFINS,\n       0, --V_ITEM.VLR_PIS,\n       0, --V_ITEM.VLR_COFINS\n       v_item.VBCSTRET,\n       v_item.PST,\n       v_item.VICMSSUBSTITUTO,\n       v_item.VICMSSTRET);\n    V_VL_BASE_CALCULO_ICMS := NVL(V_VL_BASE_CALCULO_ICMS, 0) +\n                              f_extrai_num_expressao(V_ITEM.VLR_BASE_ICMS_CALC);\n    V_VL_BASE_ISENTA_ICMS  := NVL(V_VL_BASE_ISENTA_ICMS, 0) +\n                              f_extrai_num_expressao(V_ITEM.VLR_BASE_ISENTO_ICMS);\n    V_VL_BASE_OUTRAS_ICMS  := NVL(V_VL_BASE_OUTRAS_ICMS, 0) +\n                              f_extrai_num_expressao(V_ITEM.VLR_BASE_OUTROS_ICMS);\n    V_VL_ICMS              := NVL(V_VL_ICMS, 0) +\n                              f_extrai_num_expressao(V_ITEM.VLR_ICMS);\n    V_VL_BASE_CALCULO_IPI  := NVL(V_VL_BASE_CALCULO_IPI, 0) +\n                              f_extrai_num_expressao(V_ITEM.VLR_BASE_IPI);\n    V_VL_BASE_ISENTA_IPI   := NVL(V_VL_BASE_ISENTA_IPI, 0) +\n                              f_extrai_num_expressao(V_ITEM.VLR_BASE_ISENTO_IPI);\n    V_VL_BASE_OUTRAS_IPI   := NVL(V_VL_BASE_OUTRAS_IPI, 0) +\n                              f_extrai_num_expressao(V_ITEM.VLR_BASE_OUTROS_IPI);\n    V_VL_IPI               := NVL(V_VL_IPI, 0) +\n                              f_extrai_num_expressao(V_ITEM.VLR_IPI);\n    V_VL_BASE_ICMS_SUBST   := NVL(V_VL_BASE_ICMS_SUBST, 0) +\n                              f_extrai_num_expressao(V_ITEM.VLR_BASE_ICMS_SUBST_CALC);\n    V_VL_ICMS_SUBST        := NVL(V_VL_ICMS_SUBST, 0) +\n                              f_extrai_num_expressao(V_ITEM.VLR_ICMS_SUBST);\n  end loop;\n  close BUSCA_ITENS;\n  /*  :new.VL_BASE_CALCULO_ICMS := NVL(:new.VL_BASE_CALCULO_ICMS, 0) +\n                                 V_VL_BASE_CALCULO_ICMS;\n    :new.VL_BASE_ISENTA_ICMS  := NVL(:new.VL_BASE_ISENTA_ICMS, 0) +\n                                 V_VL_BASE_ISENTA_ICMS;\n    :new.VL_BASE_OUTRAS_ICMS  := NVL(:new.VL_BASE_OUTRAS_ICMS, 0) +\n                                 V_VL_BASE_OUTRAS_ICMS;\n    :new.VL_ICMS              := NVL(:new.VL_ICMS, 0) + V_VL_ICMS;\n    :new.VL_BASE_CALCULO_IPI  := NVL(:new.VL_BASE_CALCULO_IPI, 0) +\n                                 V_VL_BASE_CALCULO_IPI;\n    :new.VL_BASE_ISENTA_IPI   := NVL(:new.VL_BASE_ISENTA_IPI, 0) +\n                                 V_VL_BASE_ISENTA_IPI;\n    :new.VL_BASE_OUTRAS_IPI   := NVL(:new.VL_BASE_OUTRAS_IPI, 0) +\n                                 V_VL_BASE_OUTRAS_IPI;\n    :new.VL_IPI               := NVL(:new.VL_IPI, 0) + V_VL_IPI;\n    :new.VL_BASE_ICMS_SUBST   := NVL(:new.VL_BASE_ICMS_SUBST, 0) +\n                                 V_VL_BASE_ICMS_SUBST;\n    :new.VL_ICMS_SUBST        := NVL(:new.VL_ICMS_SUBST, 0) + V_VL_ICMS_SUBST;\n  */ --\n  -- AOK - 31/10/2011 - Testa para ver se fornecedor não é transportador\n  open CTRANSP;\n  fetch CTRANSp\n    into VC_IND_TRANSP;\n  close CTRANSP;\n  if VC_IND_TRANSP = 'N' then\n    update BEG_PESSOA P\n       set P.TRANSPORTADORA = 'Y'\n     where P.BEG_PESSOA_ID = :NEW.BEG_VW_FORNECEDOR_ID;\n  end if;\n  --  update BEG_PESSOA P\n  --   set P.TRANSPORTADORA = 'Y'\n  -- where P.BEG_PESSOA_ID = :new.BEG_VW_FORNECEDOR_ID;\n  --\n  /*  IF NVL(:NEW.VL_IPI,0) > 0 THEN\n    :NEW.OBS := 'Valor do IPI lancado em outras despesas nao aproveitado : '||:new.vl_ipi;\n  END IF;*/\n  --\n  OPEN C_USUARIO;\n  FETCH C_USUARIO\n    INTO R_USUARIO;\n  CLOSE C_USUARIO;\n  --\n  :new.DT_EMISSAO_ENTRADA := V_VALIDA.DT_EMISSAO;\n  :NEW.OBS                := :NEW.OBS ||\n                             ' Devolucao referente a Nota Fiscal ' ||\n                             :NEW.NRO_NFE || ' de ' ||\n                             TO_CHAR(:NEW.DT_EMISSAO_ENTRADA, 'DD/MM/RRRR') ||\n                             ',   Emitida por: ' || R_USUARIO.NAME || '  ';\n  --\n\nend BEG_TRG_BI_DEV_FORN;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BD_DEV_FORN { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  -- local variables here\nbegin\n  --\n  if :OLD.IND_CONVERTIDA = 'Y' then\n    RAISE_APPLICATION_ERROR(-20001, 'Processo ja foi convertido!');\n  end if;\n  --\n  delete from BEG_FAT_DEV_FORNECEDOR_ITEM X\n   where X.BEG_FAT_DEV_FORNECEDOR_ID = :OLD.BEG_FAT_DEV_FORNECEDOR_ID;\n  --\nend BEG_TRG_BD_DEV_FORN;\n"}`;
    
    }
}
