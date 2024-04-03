
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FAT_PRE_NFS_ITEM
    {
        
        /// <summary>
        /// Percentual de diferimento do ICMS
        /// </summary>
        public int PDIF { get; set; }
        
        /// <summary>
        /// Valor do ICMS diferido
        /// </summary>
        public int VICMSDIF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VICMSSTRET { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Codigo do beneficio Fiscal da ST
        /// </summary>
        public string CBENEF { get; set; }
        
        /// <summary>
        /// Valor do ICMS da operacao
        /// </summary>
        public int VICMSOP { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_PRE_NFS_ITEM_ID { get; set; }
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
        
        /// <summary>
        /// Numero da nota fiscal de saida
        /// </summary>
        public int NRO_NFS { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Serie da nota fiscal de saida
        /// </summary>
        public string SERIE_NFS { get; set; }
        
        /// <summary>
        /// Data de emiss?o
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// Quantidade do item
        /// </summary>
        public int QTDE { get; set; }
        
        /// <summary>
        /// Valor do item
        /// </summary>
        public int VL_UNITARIO { get; set; }
        
        /// <summary>
        /// Custo do produto na data de venda
        /// </summary>
        public int VL_CUSTO_PRODUTO { get; set; }
        
        /// <summary>
        /// Custo financeiro
        /// </summary>
        public int VL_CUSTO_FINANCEIRO { get; set; }
        
        /// <summary>
        /// Percentual de comiss?o do item
        /// </summary>
        public int PERC_COMISSAO { get; set; }
        
        /// <summary>
        /// Valor de desconto proporcional do item
        /// </summary>
        public int VL_DESCONTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Descric?o tecnica do item. N?o necessariamente sera igual a do item
        /// </summary>
        public string DESC_TECNICA_ITEM { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Nro do patrimonio
        /// </summary>
        public string NRO_PATRIMONIO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Entregue (s/n)
        /// </summary>
        public string ENTREGUE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Gera reserva do estroque (s;n)
        /// </summary>
        public string GERA_RESERVA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Observac?o
        /// </summary>
        public string OBS_LINHA_NFS { get; set; }
        
        /// <summary>
        /// Percentual do icms
        /// </summary>
        public int PERC_ICMS { get; set; }
        
        /// <summary>
        /// Percentual de reduc?o
        /// </summary>
        public int PERC_REDUCAO { get; set; }
        
        /// <summary>
        /// Valor do icms do item
        /// </summary>
        public int VL_ICMS { get; set; }
        
        /// <summary>
        /// Valor de base de calculo do ICMS
        /// </summary>
        public int VL_BASE_CALCULO_ICMS { get; set; }
        
        /// <summary>
        /// Valor de base isenc?o ICMS
        /// </summary>
        public int VL_BASE_ISENTA_ICMS { get; set; }
        
        /// <summary>
        /// Valor de base outros icms
        /// </summary>
        public int VL_BASE_OUTRAS_ICMS { get; set; }
        
        /// <summary>
        /// Percentual de IPI
        /// </summary>
        public int PERC_IPI { get; set; }
        
        /// <summary>
        /// Valor do IPI
        /// </summary>
        public int VL_IPI { get; set; }
        
        /// <summary>
        /// Valor de base calculo IPI
        /// </summary>
        public int VL_BASE_CALCULO_IPI { get; set; }
        
        /// <summary>
        /// Valor de base isenta IPI
        /// </summary>
        public int VL_BASE_ISENTA_IPI { get; set; }
        
        /// <summary>
        /// Valor de base outras IPI
        /// </summary>
        public int VL_BASE_OUTRAS_IPI { get; set; }
        
        /// <summary>
        /// Valor do icms por subtituicao tributaria
        /// </summary>
        public int VL_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// Valor base da substituic?o tributaria
        /// </summary>
        public int VL_BASE_SUBST_TRIB { get; set; }
        
        /// <summary>
        /// Valor proporcional do frete para o item
        /// </summary>
        public int VL_FRETE_ITEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_MOVTO_ESTOQUE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_ORIGEM_MERC_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_PRE_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_TRIB_ICMS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CFOP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_MATRIZ_TRIBUTARIA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SERVICO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string LETRA_NCM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_NCM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ALTERA_DESCRICAO { get; set; }
            [StringLength(2000)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO_SERVICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NFS_ENTREGA_FUT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LINHA_NFS_ENTREGA_FUT { get; set; }
        
        /// <summary>
        /// Aliquota do Cofins
        /// </summary>
        public int ALIQ_COFINS { get; set; }
        
        /// <summary>
        /// Aliquota icms subst
        /// </summary>
        public int ALIQ_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// Aliquota do Pis
        /// </summary>
        public int ALIQ_PIS { get; set; }
        
        /// <summary>
        /// Almoxarifado
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// Adicao Importacao
        /// </summary>
        public int BEG_FAT_PRE_ADIC_IMPORT_ID { get; set; }
        
        /// <summary>
        /// Cidade
        /// </summary>
        public int BEG_VW_CIDADE_ID { get; set; }
        
        /// <summary>
        /// Fornecedor
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// Unidade Federacao
        /// </summary>
        public int BEG_VW_UF_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// CST COFINS
        /// </summary>
        public string CST_COFINS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// CST PIS
        /// </summary>
        public string CST_PIS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// CST IPI
        /// </summary>
        public string CST_IPI { get; set; }
        
        /// <summary>
        /// Data Desembaracao Aduana
        /// </summary>
        public string DT_DESEMBARACO_ADUANA { get; set; }
        
        /// <summary>
        /// Data Registro DI
        /// </summary>
        public string DT_REGISTRO_DI { get; set; }
            [StringLength(60)]
        /// <summary>
        /// Local Desembaraco
        /// </summary>
        public string LOCAL_DESEMBARACO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Nro Drawback
        /// </summary>
        public string NRO_ACDRABACK { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Nro Documento Importacao (DI)
        /// </summary>
        public string NRO_DOC_IMPORTACAO { get; set; }
        
        /// <summary>
        /// Peso Bruto
        /// </summary>
        public int PESO_BRUTO { get; set; }
        
        /// <summary>
        /// Peso Liquido
        /// </summary>
        public int PESO_LIQUIDO { get; set; }
        
        /// <summary>
        /// Valor Funrural
        /// </summary>
        public int VLR_FUNRURAL { get; set; }
        
        /// <summary>
        /// Valor base calculo COFINS
        /// </summary>
        public int VL_BASE_CALCULO_COFINS { get; set; }
        
        /// <summary>
        /// Valor base calculo PIS
        /// </summary>
        public int VL_BASE_CALCULO_PIS { get; set; }
        
        /// <summary>
        /// Valor COFINS
        /// </summary>
        public int VL_COFINS { get; set; }
        
        /// <summary>
        /// Valor PIS
        /// </summary>
        public int VL_PIS { get; set; }
        
        /// <summary>
        /// Valor Bruto item
        /// </summary>
        public int VL_BRUTO_ITEM { get; set; }
        
        /// <summary>
        /// Valor despesa Acessorias Importacao item
        /// </summary>
        public int VL_DESP_ACESS_IMP_ITEM { get; set; }
        
        /// <summary>
        /// Valor ICMS Frete item
        /// </summary>
        public int VL_ICMS_FRETE { get; set; }
        
        /// <summary>
        /// Valor ICMS Seguro item
        /// </summary>
        public int VL_ICMS_SEGURO { get; set; }
        
        /// <summary>
        /// Valor Imposto Importacao item
        /// </summary>
        public int VL_IMPOSTO_IMPORTACAO_ITEM { get; set; }
        
        /// <summary>
        /// Valor Seguro Item
        /// </summary>
        public int VL_SEGURO_ITEM { get; set; }
        
        /// <summary>
        /// Valor Siscomex Item
        /// </summary>
        public int VL_SISCOMEX_ITEM { get; set; }
        
        /// <summary>
        /// Valor unitario Dolar
        /// </summary>
        public int VL_UNITARIO_DOLAR { get; set; }
            [StringLength(40)]
        /// <summary>
        /// codigo fci
        /// </summary>
        public string COD_FCI { get; set; }
        
        /// <summary>
        /// % coeficiente importacao
        /// </summary>
        public int PERC_CI { get; set; }
        
        /// <summary>
        /// % MVA Original
        /// </summary>
        public int PERC_MVAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_CTRL_NF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VBCUFDEST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PFCPUDEST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PICMSUFDEST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PICMSINTER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PICMSINTERPART { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VFCPUFDEST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VICMSUFDEST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VICMSUFREMET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_ITEPED_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VBCSTRET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VICMSSUBSTITUTO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00006 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  CURSOR BUSCA_PRECO IS \n    SELECT NVL(P.TIPO_PRECO,-2) TIPO_PRECO\n         , N.BEG_VEN_PEDIDO_ID\n         , NVL(N.IND_CIAP,'N') IND_CIAP\n         , n.beg_est_tp_especie_id \n    FROM   BEG_VEN_TIPO_PEDIDO P\n          ,BEG_FAT_PRE_NFS N\n    WHERE  N.BEG_FAT_PRE_NFS_ID = :NEW.BEG_FAT_PRE_NFS_ID\n    AND    P.BEG_VEN_TIPO_PEDIDO_ID = N.BEG_VEN_TIPO_PEDIDO_ID;\n  --\n  v_preco busca_preco%rowtype;\n  --\n  CURSOR BUSCA_SITUACAO IS \n    SELECT 1\n    FROM   BEG_PRD_SKU_DETALHE D\n    WHERE  D.BEG_PRD_SKU_ID = :NEW.BEG_PRD_SKU_ID\n    AND    D.BEG_PRD_SITUACAO_ID = 2000004;\n  --\n  V_SITUACAO VARCHAR2(1);\n  --\n  CURSOR BUSCA_PRODUTO IS\n    SELECT P.CONTROLA_COR,\n           p.die_vw_prd_pai_id\n    FROM   BEG_PRODUTO P\n    WHERE  P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n  --\n  v_COR CHAR(1);\n  v_pai number(10);\n\n\nbegin\n\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    if :new.beg_produto_id is null then\n      raise_application_error(-20001,'Não possui Produto!!!');\n    elsif :new.BEG_PRD_SKU_ID is null then\n     raise_application_error(-20001,'Não possui SKU!!!');\n    end if;\n    RAISE_APPLICATION_ERROR(-20001, :NEW.BEG_PRODUTO_ID||' SKU INVÁLIDO PARA O PRODUTO ! ! ! ID:'||:NEW.BEG_PRODUTO_ID);\n  end if;\n  OPEN BUSCA_SITUACAO;\n  FETCH BUSCA_SITUACAO INTO V_SITUACAO;\n  IF BUSCA_SITUACAO%FOUND THEN\n    RAISE_APPLICATION_ERROR(-20001, 'Produto liquidado Movimento não permitido');\n  END IF;\n  CLOSE BUSCA_SITUACAO;\n  open busca_produto;\n  fetch busca_produto into v_cor,v_pai;\n  close busca_produto;\n  if nvl(v_cor,'N') = 'Y'\n    and v_pai is null then\n    RAISE_APPLICATION_ERROR(-20001, 'Produto controla cor Movimento não permitido');\n  end if;\n  IF INSERTING and :new.ad_org_id <> 1000134 THEN\n    if beg_pck_util.vb_total_nfs_item then\n      open busca_preco;\n      fetch busca_preco into v_preco;\n      close busca_preco;\n      if v_preco.beg_ven_pedido_id is null and v_preco.BEG_EST_TP_ESPECIE_ID not in (2000020,2000027,2000013,2000007)  then\n        :new.vl_unitario := 0;\n        IF NVL(:NEW.VL_UNITARIO,0) = 0 THEN\n          if v_preco.tipo_preco = 2 then\n            :new.vl_unitario := round(beg_fnc_cst_valor(:new.ad_org_id,:new.beg_produto_id,:new.beg_prd_sku_id)*1.3,2);---acrescentado *1.3 para ajuste nos valores de custo de transf \n            IF :NEW.VL_UNITARIO = 0 THEN\n              :new.vl_unitario := round(beg_fnc_prd_preco(:new.ad_org_id,:NEW.BEG_PRODUTO_ID,:new.beg_prd_sku_id)*.7,2);\n            END IF;\n          elsif v_preco.tipo_preco = 1 then\n            :new.vl_unitario := round(beg_fnc_prd_preco(:new.ad_org_id,:NEW.BEG_PRODUTO_ID,:new.beg_prd_sku_id/*, NULL,'CV'*/),2);\n          end if;\n          --\n          IF v_preco.IND_CIAP = 'N' THEN \n            IF NVL(:NEW.VL_UNITARIO,0) = 0 THEN\n              RAISE_APPLICATION_ERROR(-20001,'Item '||:new.desc_tecnica_item||' Com Vlr Unitario 0');\n            ELSIF NVL(:NEW.QTDE,0) = 0 THEN\n              RAISE_APPLICATION_ERROR(-20001,'Item '||:new.desc_tecnica_item||' Com quantidade igual 0');\n            END IF;\n          END IF;\n          --\n        END IF;\n      end if;\n    END IF;\n  END IF;\n  if beg_pck_util.vb_total_nfs_item then\n    :NEW.VL_UNITARIO := ROUND(:NEW.VL_UNITARIO,2);\n  end if;\n\n\n--               raise_application_error(-20501,'preco '||:new.vl_unitario );\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_PRE_NFS_ITEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\n  V_BEG_FAT_PRE_NFS_ID number(10);\n  V_PRODUTO_ID         number(10);\n  V_TOTAL_ITEM         number := 0; -- aok - 20/02/2013 -- (20, 9);\n  V_DESCONTO_SUFRAMA   number(18, 4);\n  V_PRODUTO_CODIGO     varchar(10);\n  --v_Uf_Codigo        VARCHAR(10);\n  V_BASE_ICMS          number(18, 4);\n  V_BASE_SUBST         number(18, 4);\n  V_ICMS_SUBST         number(18, 4);\n  V_BASE_INICIAL_SUBST number(18, 4);\n  V_PESO               number(18, 4);\n  --vn_vl_thc          number := 0; -- aok - 19/02/2013\n  VN_VL_UNITARIO number(19, 6) := 0; -- aok - 21/08/2013\n  --VN_VL_UNITARIO     number := 0; -- aok - 16/05/2013 --20/02/2013\n  --VN_VL_UNITARIO     BEG_FAT_PRE_NFS_ITEM.VL_UNITARIO%type := 0; -- aok - 16/05/2013 --27/03/2013\n  VN_VLR_DESCONTO BEG_FAT_PRE_NFS.VLR_DESCONTO%type := 0; -- aok - 16/01/2013\n  --V_PESO_TOTAL         number(18, 4); -- aok - 17/08/2012\n  --\n  V_TIPOPED NUMBER(10);\n  V_UF_ID   NUMBER(10);\n  V_ALMOX   NUMBER(10);\n\n  cursor BUSCA_DADOS_NOTA is\n    select N.*, TS.BAIXA_RESERVA\n      from BEG_FAT_PRE_NFS N, BEG_EST_TP_ESPECIE TS\n     where N.BEG_FAT_PRE_NFS_ID = V_BEG_FAT_PRE_NFS_ID\n       AND N.BEG_EST_TP_ESPECIE_ID = TS.BEG_EST_TP_ESPECIE_ID; --\n  VREG1 BUSCA_DADOS_NOTA%rowtype;\n  /*  -- aok - 14/03/2013 - Criado ind_importacao na beg_fat_pre_nfs\n    select N.*,\n             NVL(T.IND_ENTRADA, 'N') IND_ENTRADA, -- aok - 31/01/2013\n             NVL(T.IND_SAIDA, 'N') IND_SAIDA, -- aok - 31/01/2013\n             NVL(T.IND_IMPORTACAO, 'N') IND_IMPORTACAO, -- aok - 31/01/2013\n             NVL(T.IND_NOTA_AVULSA, 'N') IND_NOTA_AVULSA -- aok - 31/01/2013\n        from BEG_FAT_PRE_NFS N,\n             BEG_TIPO_NF     T -- aok - 31/01/2013\n       where N.BEG_FAT_PRE_NFS_ID = V_BEG_FAT_PRE_NFS_ID\n         and T.BEG_TIPO_NF_ID(+) = N.BEG_TIPO_NF_ID; --\n  */\n  -- Irã - 09/04/2010\n  cursor BUSCA_TIPO_PEDIDO is\n    select BEG_VEN_TIPO_PEDIDO_ID\n      from BEG_VEN_TIPO_PEDIDO T\n    -- comentado em 22/09/2015 por Marcelo  pois deve puxar pelo tipo de pedido da pre-nfs\n    --     where T.BEG_EST_TP_ESPECIE_ID = VREG1.BEG_EST_TP_ESPECIE_ID;\n     where T.BEG_VEN_TIPO_PEDIDO_ID = VREG1.BEG_VEN_TIPO_PEDIDO_ID;\n  V_TP_PEDIDO BUSCA_TIPO_PEDIDO%rowtype;\n\n  --\n  cursor BUSCA_PESSOA_UF is\n    select C.BEG_UF_ID,\n           'S' CONTRIBUINTE,\n           PE.IND_CONSUMIDOR CONSUMIDOR,\n           P.PESO,\n           P.BEG_VEN_TIPO_PEDIDO_ID,\n           CL.SUFRAMA,\n           PF.BEG_VW_UF_ID UF_ORIGEM, -- AOK - 27/04/2010\n           'N' CLIENTE_OPTANTE_SIMPLES,\n           case\n             when pe.inscricao = 'ISENTO' then\n              'N'\n             else\n              'Y'\n           end inscrito\n      from BEG_VEN_PEDIDO P,\n           BEG_CIDADE     C,\n           BEG_CLIENTE    CL,\n           BEG_UF         UF,\n           BEG_PESSOA     PE,\n           -- BEG_VEN_TIPO_PEDIDO TP, -- aok - 18/01/2013\n           BEG_FRO_ROTA    RT,\n           BEG_DADO_FILIAL F, -- Filial do pedido\n           BEG_PESSOA      PF, -- Uf ref. filial do pedido\n           BEG_DADO_FILIAL F1, -- Filial da nota\n           BEG_PESSOA      PF1 -- Uf ref. filial da nota\n     where P.BEG_VEN_PEDIDO_ID = VREG1.BEG_VEN_PEDIDO_ID\n       and C.BEG_CIDADE_ID = P.BEG_CIDADE_ID\n       and UF.BEG_UF_ID = C.BEG_UF_ID\n       and CL.BEG_PESSOA_ID(+) = P.BEG_VW_CLIENTE_ID\n       and PE.BEG_PESSOA_ID = P.BEG_VW_CLIENTE_ID\n          -- and TP.BEG_VEN_TIPO_PEDIDO_ID = P.BEG_VEN_TIPO_PEDIDO_ID -- aok - 18/01/2013\n       and RT.BEG_FRO_ROTA_ID(+) = P.BEG_FRO_ROTA_ID -- Ira - 22/04/2010\n       and F.AD_ORG_ID = P.AD_ORG_ID\n       and PF.BEG_PESSOA_ID = F.BEG_PESSOA_ID\n       and F1.AD_ORG_ID = VREG1.AD_ORG_ID\n       and PF1.BEG_PESSOA_ID = F1.BEG_PESSOA_ID\n    union\n    select C.BEG_UF_ID,\n           'S' CONTRIBUINTE,\n           PE.IND_CONSUMIDOR CONSUMIDOR,\n           0 PESO,\n           VREG1.BEG_VEN_TIPO_PEDIDO_ID BEG_VEN_TIPO_PEDIDO_ID,\n           CL.SUFRAMA,\n           PF.BEG_VW_UF_ID UF_ORIGEM, -- AOK - 27/04/2010\n           'N',\n           case\n             when pe.inscricao = 'ISENTO' then\n              'N'\n             else\n              'Y'\n           end inscrito\n      from BEG_CIDADE      C,\n           BEG_PESSOA      PE,\n           BEG_CLIENTE     CL,\n           BEG_UF          UF,\n           BEG_DADO_FILIAL F, -- Filial do pedido\n           BEG_PESSOA      PF, -- Uf ref. filial do pedido\n           BEG_DADO_FILIAL F1, -- Filial da nota\n           BEG_PESSOA      PF1 -- Uf ref. filial da nota\n     where C.BEG_CIDADE_ID = VREG1.BEG_CIDADE_ID\n       and UF.BEG_UF_ID = C.BEG_UF_ID\n       and PE.BEG_PESSOA_ID = VREG1.BEG_VW_CLIENTE_ID\n       and CL.BEG_PESSOA_ID(+) = PE.BEG_PESSOA_ID\n       and F.AD_ORG_ID = VREG1.AD_ORG_ID\n       and PF.BEG_PESSOA_ID = F.BEG_PESSOA_ID\n       and F1.AD_ORG_ID = VREG1.AD_ORG_ID\n       and PF1.BEG_PESSOA_ID = F1.BEG_PESSOA_ID\n    union\n    select VREG1.BEG_UF_ID BEG_UF_ID,\n           'S' CONTRIBUINTE,\n           PE.IND_CONSUMIDOR CONSUMIDOR,\n           0 PESO,\n           VREG1.BEG_VEN_TIPO_PEDIDO_ID,\n           CL.SUFRAMA,\n           PF1.BEG_VW_UF_ID UF_ORIGEM,\n           'N',\n           case\n             when pe.inscricao = 'ISENTO' then\n              'N'\n             else\n              'Y'\n           end inscrito\n      from BEG_PESSOA      PE,\n           BEG_CLIENTE     CL,\n           BEG_DADO_FILIAL F1, -- Filial da nota\n           BEG_PESSOA      PF1 -- Uf ref. filial da nota\n     where PE.BEG_PESSOA_ID = VREG1.BEG_VW_FORNECEDOR_ID\n       and CL.BEG_PESSOA_ID(+) = PE.BEG_PESSOA_ID\n       and F1.AD_ORG_ID = VREG1.AD_ORG_ID\n       and PF1.BEG_PESSOA_ID = F1.BEG_PESSOA_ID\n       and NVL(VREG1.TP_LANCTO_CONTABIL, 'S') = 'E';\n  --\n  VREG2 BUSCA_PESSOA_UF%rowtype;\n  --\n  cursor SELECIONA_MATRIZ_ESTADO is\n    select PN.PERC_IPI IPI_NCM,\n           M.PERC_IPI,\n           m.perc_icm,\n           M.PERC_PIS,\n           M.PERC_COFINS,\n           M.PERC_ISSQN,\n           M.PERC_IRRF,\n           M.PERC_IPI_DIFERIDO,\n           M.PERC_FUNRURAL,\n           M.TP_TRIB_ICMS,\n           M.TP_TRIB_IPI,\n           T.REDUCAO,\n           D.PERC_REDUCAO PERC_REDUCAO,\n           C.BEG_CFOP_ID,\n           O.BEG_FIS_ORIGEM_MERC_ID, -- aok - 04/03/2013\n           T.BEG_FIS_TRIB_ICMS_ID, -- aok - 04/03/2013\n           O.COD_ORIG_MERC || T.COD_TRIB_ICMS CST,\n           M.DESC_SUFRAMA,\n           M.BEG_FIS_MATRIZ_TRIBUTARIA_ID,\n           N.BEG_PRODUTO_ID,\n           D.PERC_REDUCAO RE_ICMS,\n           D.PERC_DIF,\n           M.PERC_ICM_SUBSTITUICAO,\n           DECODE(VREG2.UF_ORIGEM, -- Origem\n                  VREG2.BEG_UF_ID, -- Destino\n                  NVL(NU.PERC_MVAO, M.PERC_MARGEM_SUBSTITUICAO),\n                  (BEG_FNC_FIS_MVAA2(VREG2.BEG_UF_ID, -- Destino\n                                     --   NVL(NU.PERC_MVAO, -- %MVAO Origem -- aok - 09/05/2013\n                                     NVL(NU1.PERC_MVAO, -- %MVAO Destino\n                                         M.PERC_MARGEM_SUBSTITUICAO),\n                                     M.PERC_ICM, ---icms interestadual\n                                     NU1.ALIQ_ICMS_INTERNA ----- icms no estado de destino\n                                     ) * 100)) PERC_MARGEM_SUBSTITUICAO, -- aok - 10/09/2012\n           --decode(vreg2.uf_origem,vreg2.beg_uf_id, NVL(NU.PERC_MVAO, M.PERC_MARGEM_SUBSTITUICAO),\n           --(beg_fnc_fis_mvaas(NVL(NU.PERC_MVAO, M.PERC_MARGEM_SUBSTITUICAO))*100)) PERC_MARGEM_SUBSTITUICAO, -- aok - 10/09/2012\n           M.MVA_CLIENTE_OPTANTE_SIMPLES,\n           /*TP*/\n           M.BEG_FIS_CST_COFINS_ID, -- aok - 04/03/2013 --29/01/2013\n           /*TP*/\n           M.BEG_FIS_CST_PIS_ID, -- aok - 04/03/2013 --29/01/2013\n           /*TP*/\n           M.BEG_FIS_CST_IPI_ID, -- aok - 04/03/2013 --29/01/2013\n           CO.VALUE CST_COFINS, -- aok - 29/01/2013\n           CP.VALUE CST_PIS, -- aok - 29/01/2013\n           CI.VALUE CST_IPI, -- aok - 29/01/2013\n           nvl(CO.IND_CALCULA, 'N') IND_CALC_PIS, -- aok - 29/01/2013\n           nvl(CP.IND_CALCULA, 'N') IND_CALC_COFINS, -- aok - 29/01/2013\n           P.BEG_PRD_NCM_ID, -- aok - 06/02/2013\n           M.VALUE COD_MATRIZ, -- aok - 18/02/2013\n           C.DIFAL\n      from BEG_PRD_CONTABIL          P,\n           BEG_FIS_NCM               N,\n           BEG_PRD_NCM_UF            NU, -- Origem\n           BEG_PRD_NCM_UF            NU1, -- Destino\n           BEG_PRD_NCM               PN,\n           BEG_FIS_CFOP              C,\n           BEG_FIS_TRIB_ICMS         T,\n           BEG_FIS_MATRIZ_TRIBUTARIA M,\n           --BEG_VEN_TIPO_PEDIDO       TP, -- aok - 04/03/2013 --29/01/2013\n           BEG_FIS_CST_COFINS        CO, -- aok - 29/01/2013\n           BEG_FIS_CST_PIS           CP, -- aok - 29/01/2013\n           BEG_FIS_CST_IPI           CI, -- aok - 29/01/2013\n           BEG_FIS_ORIGEM_MERC       O,\n           BEG_FIS_DISPOSITIVO_LEGAL D,\n           BEG_FIS_MTZ_DISPOSITIVO   MD\n     where P.BEG_PRODUTO_ID = V_PRODUTO_ID\n       and PN.BEG_PRD_NCM_ID = P.BEG_PRD_NCM_ID\n       and N.BEG_PRD_NCM_ID = P.BEG_PRD_NCM_ID\n       and N.ISACTIVE = 'Y'\n       and (NVL(N.BEG_PRODUTO_ID, V_PRODUTO_ID) = V_PRODUTO_ID) --Incluido por GSC\n       and NU.BEG_PRD_NCM_ID(+) = PN.BEG_PRD_NCM_ID\n       and NU.BEG_UF_ID(+) = VREG2.UF_ORIGEM -- Origem\n       and NU1.BEG_PRD_NCM_ID(+) = PN.BEG_PRD_NCM_ID\n       and NU1.BEG_UF_ID(+) = VREG2.BEG_UF_ID -- Destino\n       and M.BEG_FIS_MATRIZ_TRIBUTARIA_ID = N.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n       and M.BEG_VW_UF_ID = VREG2.UF_ORIGEM\n       and M.BEG_UF_ID = VREG2.BEG_UF_ID\n       and M.BEG_VEN_TIPO_PEDIDO_ID = V_TP_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID -- Irã - 09/04/2010\n       and M.ISACTIVE = 'Y'\n       and CO.BEG_FIS_CST_COFINS_ID(+) = /*TP*/\n           M.BEG_FIS_CST_COFINS_ID -- aok - 18/01/2013\n       and CP.BEG_FIS_CST_PIS_ID(+) = /*TP*/\n           M.BEG_FIS_CST_PIS_ID -- aok - 18/01/2013\n       and CI.BEG_FIS_CST_IPI_ID(+) = /*TP*/\n           M.BEG_FIS_CST_IPI_ID -- aok - 18/01/2013\n       and T.BEG_FIS_TRIB_ICMS_ID = M.BEG_FIS_TRIB_ICMS_ID\n       and C.BEG_FIS_MATRIZ_TRIBUTARIA_ID = M.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n       and O.BEG_FIS_ORIGEM_MERC_ID = M.BEG_FIS_ORIGEM_MERC_ID\n       and MD.BEG_FIS_MATRIZ_TRIBUTARIA_ID(+) =\n           M.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n       and D.BEG_FIS_DISPOSITIVO_LEGAL_ID(+) = MD.BEG_VW_FIS_DISP_ICMS_ID\n       and c.ind_inscrito = VREG2.INSCRITO\n       and (C.IND_CONSUMIDOR = NVL(VREG2.CONSUMIDOR, 'N') /*or not exists\n                                                                                                    (select 1\n                                                                                                       from BEG_FIS_MATRIZ_TRIBUTARIA MT,\n                                                                                                            BEG_FIS_CFOP              BC,\n                                                                                                            BEG_PRD_CONTABIL          BPC,\n                                                                                                            BEG_FIS_NCM               BFN\n                                                                                                      where BPC.BEG_PRODUTO_ID = V_PRODUTO_ID\n                                                                                                        and BFN.BEG_PRD_NCM_ID = BPC.BEG_PRD_NCM_ID\n                                                                                                        and BFN.ISACTIVE = 'Y'\n                                                                                                        and MT.ISACTIVE = 'Y'\n                                                                                                        and (NVL(BFN.BEG_PRODUTO_ID, V_PRODUTO_ID) = V_PRODUTO_ID) --Incluido por GSC\n                                                                                                        and MT.BEG_FIS_MATRIZ_TRIBUTARIA_ID =\n                                                                                                            BFN.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n                                                                                                        and MT.BEG_UF_ID = VREG2.BEG_UF_ID\n                                                                                                        and MT.BEG_VW_UF_ID = VREG2.UF_ORIGEM\n                                                                                                        and MT.BEG_VEN_TIPO_PEDIDO_ID =\n                                                                                                            V_TP_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID -- AOK - 12/04/2010\n                                                                                                        and BC.BEG_FIS_MATRIZ_TRIBUTARIA_ID =\n                                                                                                            MT.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n                                                                                                        and BC.IND_CONSUMIDOR = NVL(VREG2.CONSUMIDOR, 'N'))*/\n           )\n     order by NVL(N.BEG_PRODUTO_ID, 9999999999);\n  --\n  cursor SELECIONA_MATRIZ_GERAL is\n    select PN.PERC_IPI IPI_NCM,\n           M.PERC_IPI,\n           m.perc_icm,\n           M.PERC_PIS,\n           M.PERC_COFINS,\n           M.PERC_ISSQN,\n           M.PERC_IRRF,\n           M.PERC_IPI_DIFERIDO,\n           M.PERC_FUNRURAL,\n           M.TP_TRIB_ICMS,\n           M.TP_TRIB_IPI,\n           T.REDUCAO,\n           D.PERC_REDUCAO PERC_REDUCAO,\n           C.BEG_CFOP_ID,\n           O.BEG_FIS_ORIGEM_MERC_ID, -- aok - 04/03/2013\n           T.BEG_FIS_TRIB_ICMS_ID, -- aok - 04/03/2013\n           O.COD_ORIG_MERC || T.COD_TRIB_ICMS CST,\n           M.DESC_SUFRAMA,\n           M.BEG_FIS_MATRIZ_TRIBUTARIA_ID,\n           N.BEG_PRODUTO_ID,\n           D.PERC_REDUCAO RE_ICMS,\n           D.PERC_DIF,\n           M.PERC_ICM_SUBSTITUICAO,\n           DECODE(VREG2.UF_ORIGEM, -- Origem\n                  VREG2.BEG_UF_ID, -- Destino\n                  NVL(NU.PERC_MVAO, M.PERC_MARGEM_SUBSTITUICAO),\n                  (BEG_FNC_FIS_MVAA2(VREG2.BEG_UF_ID, -- Destino\n                                     --   NVL(NU.PERC_MVAO, -- %MVAO Origem -- aok - 09/05/2013\n                                     NVL(NU1.PERC_MVAO, -- %MVAO Destino\n                                         M.PERC_MARGEM_SUBSTITUICAO),\n                                     M.PERC_ICM, ---icms interestadual\n                                     NU1.ALIQ_ICMS_INTERNA ----- icms no estado de destino\n                                     ) * 100)) PERC_MARGEM_SUBSTITUICAO, -- aok - 10/09/2012\n           M.MVA_CLIENTE_OPTANTE_SIMPLES,\n           M.BEG_FIS_CST_COFINS_ID, -- aok - 29/01/2013\n           M.BEG_FIS_CST_PIS_ID, -- aok - 29/01/2013\n           M.BEG_FIS_CST_IPI_ID, -- aok - 29/01/2013\n           CO.VALUE CST_COFINS, -- aok - 29/01/2013\n           CP.VALUE CST_PIS, -- aok - 29/01/2013\n           CI.VALUE CST_IPI, -- aok - 29/01/2013\n           nvl(CO.IND_CALCULA, 'N') IND_CALC_PIS, -- aok - 29/01/2013\n           NVL(CP.IND_CALCULA, 'N') IND_CALC_COFINS, -- aok - 29/01/2013\n           P.BEG_PRD_NCM_ID, -- aok - 06/02/2013\n           M.VALUE COD_MATRIZ, -- aok - 18/02/2013\n           C.DIFAL\n    \n      from BEG_PRD_CONTABIL          P,\n           BEG_FIS_NCM               N,\n           BEG_PRD_NCM_UF            NU, -- Origem\n           BEG_PRD_NCM_UF            NU1, -- Destino\n           BEG_PRD_NCM               PN,\n           BEG_FIS_CFOP              C,\n           BEG_FIS_TRIB_ICMS         T,\n           BEG_FIS_MATRIZ_TRIBUTARIA M,\n           -- BEG_VEN_TIPO_PEDIDO       TP, -- aok - 04/03/2013 --18/01/2013\n           BEG_FIS_CST_COFINS        CO, -- aok - 29/01/2013\n           BEG_FIS_CST_PIS           CP, -- aok - 29/01/2013\n           BEG_FIS_CST_IPI           CI, -- aok - 29/01/2013\n           BEG_FIS_ORIGEM_MERC       O,\n           BEG_FIS_DISPOSITIVO_LEGAL D,\n           BEG_FIS_MTZ_DISPOSITIVO   MD\n     where P.BEG_PRODUTO_ID = V_PRODUTO_ID\n       and PN.BEG_PRD_NCM_ID = P.BEG_PRD_NCM_ID\n       and N.BEG_PRD_NCM_ID = P.BEG_PRD_NCM_ID\n       and (NVL(N.BEG_PRODUTO_ID, V_PRODUTO_ID) = V_PRODUTO_ID) --Incluido por GSC\n       and NU.BEG_PRD_NCM_ID(+) = PN.BEG_PRD_NCM_ID\n       and NU.BEG_UF_ID(+) = VREG2.UF_ORIGEM -- Origem\n       and NU1.BEG_PRD_NCM_ID(+) = PN.BEG_PRD_NCM_ID\n       and NU1.BEG_UF_ID(+) = VREG2.BEG_UF_ID -- Destino\n       and M.BEG_FIS_MATRIZ_TRIBUTARIA_ID = N.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n       and M.BEG_VW_UF_ID = VREG2.UF_ORIGEM\n       and M.BEG_UF_ID is null\n       and M.BEG_VEN_TIPO_PEDIDO_ID = V_TP_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID -- Irã - 09/04/2010\n       and M.ISACTIVE = 'Y'\n       and N.ISACTIVE = 'Y' -- aok - 21/02/2013\n       and CO.BEG_FIS_CST_COFINS_ID(+) = /*TP*/\n           M.BEG_FIS_CST_COFINS_ID -- aok - 29/01/2013\n       and CP.BEG_FIS_CST_PIS_ID(+) = /*TP*/\n           M.BEG_FIS_CST_PIS_ID -- aok - 29/01/2013\n       and CI.BEG_FIS_CST_IPI_ID(+) = /*TP*/\n           M.BEG_FIS_CST_IPI_ID -- aok - 29/01/2013\n       and T.BEG_FIS_TRIB_ICMS_ID = M.BEG_FIS_TRIB_ICMS_ID\n       and C.BEG_FIS_MATRIZ_TRIBUTARIA_ID = M.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n       and O.BEG_FIS_ORIGEM_MERC_ID = M.BEG_FIS_ORIGEM_MERC_ID\n       and MD.BEG_FIS_MATRIZ_TRIBUTARIA_ID(+) =\n           M.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n       and D.BEG_FIS_DISPOSITIVO_LEGAL_ID(+) = MD.BEG_VW_FIS_DISP_ICMS_ID\n       and c.ind_inscrito = VREG2.INSCRITO\n       and (C.IND_CONSUMIDOR = NVL(VREG2.CONSUMIDOR, 'N') /*or not exists\n                                                                                                    (select 1\n                                                                                                       from BEG_FIS_MATRIZ_TRIBUTARIA MT,\n                                                                                                            BEG_FIS_CFOP              BC,\n                                                                                                            BEG_PRD_CONTABIL          BPC,\n                                                                                                            BEG_FIS_NCM               BFN\n                                                                                                      where BPC.BEG_PRODUTO_ID = V_PRODUTO_ID\n                                                                                                        and BFN.BEG_PRD_NCM_ID = BPC.BEG_PRD_NCM_ID\n                                                                                                        and BFN.ISACTIVE = 'Y'\n                                                                                                        and (NVL(BFN.BEG_PRODUTO_ID, V_PRODUTO_ID) = V_PRODUTO_ID) --Incluido por GSC\n                                                                                                        and MT.BEG_FIS_MATRIZ_TRIBUTARIA_ID =\n                                                                                                            BFN.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n                                                                                                        and M.BEG_VW_UF_ID = VREG2.UF_ORIGEM -- Irã - 27/04/2010\n                                                                                                        and M.BEG_UF_ID is null -- Irã - 27/04/2010\n                                                                                                        and MT.BEG_VEN_TIPO_PEDIDO_ID =\n                                                                                                            V_TP_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID -- AOK - 12/04/2010\n                                                                                                        and BC.BEG_FIS_MATRIZ_TRIBUTARIA_ID =\n                                                                                                            MT.BEG_FIS_MATRIZ_TRIBUTARIA_ID\n                                                                                                        and BC.IND_CONSUMIDOR = NVL(VREG2.CONSUMIDOR, 'N'))*/\n           )\n     order by NVL(N.BEG_PRODUTO_ID, 9999999999);\n  --\n  VREG3 SELECIONA_MATRIZ_ESTADO%rowtype;\n  --\n  cursor C_PRODUTO is\n    select P.DIE_COD_ESTRUTURADO, L.PESO\n      from BEG_PRODUTO P, BEG_PRD_LOGISTICA L\n     where P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID\n       and L.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n\n  -- MF 05/07/2016\n  /*  cursor C_PROD1 is\n    select P1.*\n      from BEG_PRODUTO P1\n     where P1.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n     C_PROD1 R_PROD%rowtype;\n  --*/\n\n  -- aok - 31/01/2013\n  cursor CADIMP is\n    select *\n      from BEG_FAT_PRE_ADIC_IMPORT X\n     where X.BEG_FAT_PRE_ADIC_IMPORT_ID = :NEW.BEG_FAT_PRE_ADIC_IMPORT_ID;\n  RADIMP CADIMP%rowtype;\n  --\n  CURSOR C_VALIDA_CIAP IS\n    SELECT NVL(X.IND_CIAP, 'N') IND_CIAP\n      FROM BEG_FAT_PRE_NFS X\n     WHERE BEG_FAT_PRE_NFS_ID = :NEW.BEG_FAT_PRE_NFS_ID;\n  --\n  VC_IND_CIAP VARCHAR2(1);\n  --\n  ----CURSORES PARA CALCULO DIFAL MF 18/08/2016\n  CURSOR C_TPPEDIDO IS\n    SELECT TP.*\n      FROM BEG_VEN_TIPO_PEDIDO TP\n     WHERE TP.BEG_VEN_TIPO_PEDIDO_ID = V_TIPOPED;\n  R_TPPED C_TPPEDIDO%ROWTYPE;\n\n  CURSOR C_UF IS\n    SELECT U.* FROM BEG_UF U WHERE U.BEG_UF_ID = V_UF_ID;\n  R_UF C_UF%ROWTYPE;\n\n  CURSOR C_PERC IS\n    SELECT P.*\n      FROM DIE_DIFAL_ALIQ P\n     WHERE P.ANO = TO_CHAR(TRUNC(SYSDATE), 'YYYY');\n  R_PERC C_PERC%ROWTYPE;\n\n  cursor BUSCA_ESTOQUE is\n    select P.BEG_PRODUTO_ID,\n           P.DIE_COD_ESTRUTURADO,\n           E.QTD,\n           E.QTD_RESERVADA,\n           PL.ACEITA_NEGATIVO,\n           PL.CONTROLA_ESTOQUE_RESERVA,\n           F.CONTROLA_RESERVA\n      from BEG_ESTOQUE        E,\n           BEG_PRODUTO        P,\n           BEG_PRD_LOGISTICA  PL,\n           BEG_PRD_FABRICANTE F\n     WHERE E.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID\n       and BEG_EST_ALMOXARIFADO_ID =\n           NVL(:NEW.BEG_EST_ALMOXARIFADO_ID, V_ALMOX)\n       AND E.BEG_PRODUTO_ID = P.BEG_PRODUTO_ID\n       AND P.BEG_PRD_FABRICANTE_ID = F.BEG_PRD_FABRICANTE_ID\n       AND P.BEG_PRODUTO_ID = PL.BEG_PRODUTO_ID;\n  --\n  R_EST BUSCA_ESTOQUE%rowtype;\n\n  cursor C_ALMOX is\n    select A.*\n      from BEG_EST_ALMOXARIFADO A\n     where A.AD_ORG_ID = :NEW.AD_ORG_ID\n       AND A.IND_DISPONIVEL = 'Y';\n  --           and a.isactive ='Y';\n  --\n  R_ALMOX C_ALMOX%rowtype;\n\n  -------------------------------------------------------------------------------------------------------\nbegin\n\n  if inserting or updating then\n  \n    if NVL(:NEW.QTDE, 0) = 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Quantidade nao pode ser zero.Caso queira retirar este item exclua o mesmo');\n    end if;\n  \n    if NVL(:NEW.QTDE, 0) < 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Quantidade nao pode ser menor que zero.Verifique!!');\n    end if;\n  \n    IF UPDATING AND :OLD.BEG_PRODUTO_ID <> :NEW.BEG_PRODUTO_ID THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Nao permitido alterar codigo de produto, fazer exclusao do item errado.');\n    \n    END IF;\n  \n    V_BEG_FAT_PRE_NFS_ID := :NEW.BEG_FAT_PRE_NFS_ID;\n  \n    open C_PRODUTO;\n    fetch C_PRODUTO\n      into V_PRODUTO_CODIGO, V_PESO;\n    close C_PRODUTO;\n  \n    open BUSCA_DADOS_NOTA;\n    fetch BUSCA_DADOS_NOTA\n      into VREG1;\n    close BUSCA_DADOS_NOTA;\n  \n    if V_PRODUTO_CODIGO like 'D%' and\n       vreg1.beg_ven_tipo_pedido_id not in\n       (2000015, 2000014, 2000031, 2000044, 2000018) then\n      raise_application_error(-20501,\n                              'Produtos do grupo D nao podem ser emitidos para este tipo de pedido');\n    end if;\n  \n    if V_PRODUTO_CODIGO NOT like 'D%' and\n       vreg1.beg_ven_tipo_pedido_id in (2000015, 2000014) then\n      raise_application_error(-20501,\n                              'Produtos diferente do grupo D nao podem ser emitidos para este tipo de pedido');\n    end if;\n  \n    -----  se nota de servico quantidade não pode ser diferente de 1\n    if NVL(:NEW.QTDE, 0) <> 1 and vreg1.beg_ven_tipo_pedido_id in (2000020) then --- 2000020 VENDA DE SERVICOS\n      raise_application_error(-20501,\n                              'Quantidade diferente de 1 não permitida para este tipo de pedido');\n    end if;\n    --  end if;\n  \n    -- IF INSERTING OR UPDATING THEN\n  \n    IF :NEW.BEG_EST_ALMOXARIFADO_ID IS NULL AND V_ALMOX IS NULL THEN\n    \n      IF :NEW.AD_ORG_ID = 1000134 THEN\n      \n        V_ALMOX := 2000093;\n      \n      ELSE\n        OPEN C_ALMOX;\n        FETCH C_ALMOX\n          INTO R_ALMOX;\n        CLOSE C_ALMOX;\n      \n        V_ALMOX := R_ALMOX.BEG_EST_ALMOXARIFADO_ID;\n      END IF;\n    END IF;\n  \n    ----- comentado em 01/02/2022 para liberar estoque negativo  \n    /*IF VREG1.TP_LANCTO_CONTABIL = 'S' THEN\n      open BUSCA_ESTOQUE;\n      fetch BUSCA_ESTOQUE\n        into R_EST;\n      if BUSCA_ESTOQUE%notfound OR\n         R_EST.QTD - R_EST.QTD_RESERVADA < :new.Qtde AND\n         R_EST.ACEITA_NEGATIVO = 'N' AND VREG1.BEG_VEN_PEDIDO_ID IS NULL then\n        RAISE_APPLICATION_ERROR(-20501,\n                                'Qtde em estoque nao pode ser negativa ou o produto nao esta inicializado no estoque desta filial. Qtde em estoque: ' ||\n                                R_EST.QTD || ' Qtde Reservada: ' ||\n                                R_EST.QTD_RESERVADA || ' Qtde Disponivel: ' ||\n                                TO_CHAR(R_EST.QTD - R_EST.QTD_RESERVADA));\n      end if;\n     \n      close BUSCA_ESTOQUE;\n    END IF;*/\n  END IF;\n  --\n  OPEN C_VALIDA_CIAP;\n  FETCH C_VALIDA_CIAP\n    INTO VC_IND_CIAP;\n  CLOSE C_VALIDA_CIAP;\n  --\n  IF VC_IND_CIAP = 'Y' THEN\n    NULL;\n    GOTO FIM;\n  END IF;\n  --\n\n  --\n  if BEG_PCK_UTIL.VC_PROCESSA -- aok - 16/01/2013\n   then\n    if not beg_pck_util.vb_total_nfs_item -- aok - 25/06/2013\n     then\n      --if :NEW.BEG_CFOP_ID is not null\n      --   and :NEW.BEG_CFOP_ID not in (400, 401, 496, 535) then\n      -- RAISE_APPLICATION_ERROR(-20001, 'Estou aqui');\n      V_TOTAL_ITEM := ROUND(:NEW.QTDE * NVL(:NEW.VL_UNITARIO, 0), 2);\n      update BEG_FAT_PRE_NFS P\n         set P.VL_BASE_CALCULO_ICMS = NVL(P.VL_BASE_CALCULO_ICMS, 0) +\n                                      NVL(:NEW.VL_BASE_CALCULO_ICMS, 0),\n             P.VL_ICMS              = NVL(P.VL_ICMS, 0) +\n                                      round(NVL(:NEW.VL_ICMS, 0), 2),\n             P.VL_BASE_ISENTA_ICMS  = NVL(P.VL_BASE_ISENTA_ICMS, 0) +\n                                      NVL(:NEW.VL_BASE_ISENTA_ICMS, 0),\n             P.VL_BASE_OUTRAS_ICMS  = NVL(P.VL_BASE_OUTRAS_ICMS, 0) +\n                                      NVL(:NEW.VL_BASE_OUTRAS_ICMS, 0),\n             P.VL_BASE_ICMS_SUBST   = NVL(P.VL_BASE_ICMS_SUBST, 0) +\n                                      NVL(:NEW.VL_BASE_SUBST_TRIB, 0),\n             P.VL_ICMS_SUBST        = NVL(P.VL_ICMS_SUBST, 0) +\n                                      NVL(:NEW.VL_ICMS_SUBST, 0),\n             P.VL_IPI               = NVL(P.VL_IPI, 0) + :NEW.VL_IPI,\n             P.VL_BASE_CALCULO_IPI  = NVL(P.VL_BASE_CALCULO_IPI, 0) +\n                                      :NEW.VL_BASE_CALCULO_IPI,\n             P.VL_BASE_ISENTA_IPI   = NVL(P.VL_BASE_ISENTA_IPI, 0) +\n                                      :NEW.VL_BASE_ISENTA_IPI,\n             P.VL_BASE_OUTRAS_IPI   = NVL(P.VL_BASE_OUTRAS_IPI, 0) +\n                                      :NEW.VL_BASE_OUTRAS_IPI,\n             P.VL_TOTAL_PROD        = NVL(P.VL_TOTAL_PROD, 0) + V_TOTAL_ITEM,\n             P.DESC_SUFRAMA         = NVL(P.DESC_SUFRAMA, 0),\n             P.VL_TOTAL_NFS         = NVL(P.VL_TOTAL_NFS, 0) + V_TOTAL_ITEM +\n                                      NVL(:NEW.VL_IPI, 0) +\n                                      NVL(:NEW.VL_OUTRAS_DESPESAS, 0) +\n                                      NVL(:NEW.VL_ICMS_SUBST, 0) -\n                                      NVL(:NEW.VL_DESCONTO, 0),\n             P.VL_PIS               = NVL(P.VL_PIS, 0) + NVL(:NEW.VL_PIS, 0), -- aok - 19/09/2012\n             P.VL_COFINS            = NVL(P.VL_COFINS, 0) +\n                                      NVL(:NEW.VL_COFINS, 0), -- aok - 19/09/2012\n             P.VLR_DESCONTO = case\n                                when VREG1.PERC_DESCONTO > 0 or\n                                     NVL(:NEW.VLR_FUNRURAL, 0) > 0 then\n                                 P.VLR_DESCONTO +\n                                 (VN_VLR_DESCONTO + NVL(:NEW.VLR_FUNRURAL, 0))\n                                else\n                                 P.VLR_DESCONTO\n                              end,\n             P.VL_OUTRAS_DESPESAS   = NVL(P.VL_OUTRAS_DESPESAS, 0) +\n                                      NVL(:NEW.VL_OUTRAS_DESPESAS, 0), --- mf 25/04/2016\n             P.BT_CALCULO           = 'N', -- AOK - 27/02/2012,\n             P.VFCPUFDEST           = NVL(P.VFCPUFDEST, 0) + :NEW.VFCPUFDEST,\n             P.VICMSUFDEST          = NVL(P.VICMSUFDEST, 0) +\n                                      :NEW.VICMSUFDEST,\n             P.VICMSUFREMET         = NVL(P.VICMSUFREMET, 0) +\n                                      :NEW.VICMSUFREMET\n       where P.BEG_FAT_PRE_NFS_ID = :NEW.BEG_FAT_PRE_NFS_ID;\n    else\n      -- aok - 10/05/2013 ---------------------------------------------\n      if not DELETING then\n        V_BEG_FAT_PRE_NFS_ID := :NEW.BEG_FAT_PRE_NFS_ID;\n      else\n        V_BEG_FAT_PRE_NFS_ID := :OLD.BEG_FAT_PRE_NFS_ID;\n      end if;\n      --\n      open BUSCA_DADOS_NOTA;\n      fetch BUSCA_DADOS_NOTA\n        into VREG1;\n      close BUSCA_DADOS_NOTA;\n    \n      if (inserting or updating) and vreg1.tp_lancto_contabil = 'S' -- Saida\n         and :new.vl_unitario <= 0 then\n      \n        open C_PRODUTO;\n        fetch C_PRODUTO\n          into V_PRODUTO_CODIGO, V_PESO;\n        close C_PRODUTO;\n      \n        raise_application_error(-20501,\n                                'Preço menor ou igual a zero ' ||\n                                :new.vl_unitario || ' codigo produto ' ||\n                                V_PRODUTO_CODIGO);\n      end if;\n    \n      if deleting and vreg1.impresso = 'Y' then\n        raise_application_error(-20501,\n                                'Pre nota ja faturada nao permite exclusao');\n      end if;\n      ------------------------------------------------------------------\n      --\n      DBMS_OUTPUT.PUT_LINE('entrou aqui biud_pre_nfs_item');\n      --\n      if not DELETING then\n        -- V_BEG_FAT_PRE_NFS_ID := :NEW.BEG_FAT_PRE_NFS_ID;\n        V_PRODUTO_ID := :NEW.BEG_PRODUTO_ID;\n      \n        open C_PRODUTO;\n        fetch C_PRODUTO\n          into V_PRODUTO_CODIGO, V_PESO;\n        close C_PRODUTO;\n      else\n        --  V_BEG_FAT_PRE_NFS_ID := :OLD.BEG_FAT_PRE_NFS_ID;\n        V_PRODUTO_ID := :OLD.BEG_PRODUTO_ID;\n      end if;\n      --\n      V_DESCONTO_SUFRAMA := 0;\n      --  open BUSCA_DADOS_NOTA;\n      --  fetch BUSCA_DADOS_NOTA\n      --    into VREG1;\n      --  close BUSCA_DADOS_NOTA;\n      -- aok - 16/01/2013 --------------------------------------------------------\n      VN_VLR_DESCONTO := 0;\n      if UPDATING or DELETING then\n        V_TOTAL_ITEM := ROUND(:OLD.QTDE * NVL(:OLD.VL_UNITARIO, 0), 2); -- aok - 10/10/2012\n        -- Tratamento de percentual de desconto informado - aok - 07/12/2011 -------\n        if VREG1.PERC_DESCONTO > 0 then\n          VN_VLR_DESCONTO := ROUND(V_TOTAL_ITEM * VREG1.PERC_DESCONTO / 100,\n                                   2);\n        end if;\n        ----------------------------------------------------------------------------\n        update BEG_FAT_PRE_NFS P\n           set P.VL_BASE_CALCULO_ICMS = NVL(P.VL_BASE_CALCULO_ICMS, 0) -\n                                        :OLD.VL_BASE_CALCULO_ICMS,\n               P.VL_ICMS              = NVL(P.VL_ICMS, 0) -\n                                        round(:OLD.VL_ICMS, 2),\n               P.VL_BASE_ISENTA_ICMS  = NVL(P.VL_BASE_ISENTA_ICMS, 0) -\n                                        :OLD.VL_BASE_ISENTA_ICMS,\n               P.VL_BASE_OUTRAS_ICMS  = NVL(P.VL_BASE_OUTRAS_ICMS, 0) -\n                                        :OLD.VL_BASE_OUTRAS_ICMS,\n               P.VL_BASE_ICMS_SUBST   = NVL(P.VL_BASE_ICMS_SUBST, 0) -\n                                        :OLD.VL_BASE_SUBST_TRIB,\n               P.VL_ICMS_SUBST        = NVL(P.VL_ICMS_SUBST, 0) -\n                                        :OLD.VL_ICMS_SUBST,\n               P.VL_IPI               = NVL(P.VL_IPI, 0) - :OLD.VL_IPI,\n               P.VL_BASE_CALCULO_IPI  = NVL(P.VL_BASE_CALCULO_IPI, 0) -\n                                        :OLD.VL_BASE_CALCULO_IPI,\n               P.VL_BASE_ISENTA_IPI   = NVL(P.VL_BASE_ISENTA_IPI, 0) -\n                                        :OLD.VL_BASE_ISENTA_IPI,\n               P.VL_BASE_OUTRAS_IPI   = NVL(P.VL_BASE_OUTRAS_IPI, 0) -\n                                        :OLD.VL_BASE_OUTRAS_IPI,\n               P.VL_TOTAL_PROD        = NVL(P.VL_TOTAL_PROD, 0) -\n                                        V_TOTAL_ITEM,\n               P.VL_TOTAL_NFS         = NVL(P.VL_TOTAL_NFS, 0) -\n                                        V_TOTAL_ITEM - :OLD.VL_IPI,\n               P.PESO_LIQUIDO = case\n                                  when NVL(VREG1.IND_IMPORTACAO, 'N') = 'N' then\n                                   NVL(P.PESO_LIQUIDO, 0) - :OLD.PESO_LIQUIDO\n                                  else\n                                   P.PESO_LIQUIDO\n                                end, -- aok - 19/03/2013\n               P.PESO_BRUTO = case\n                                when NVL(VREG1.IND_IMPORTACAO, 'N') = 'N' then\n                                 NVL(P.PESO_BRUTO, 0) - :OLD.PESO_BRUTO\n                                else\n                                 P.PESO_BRUTO\n                              end, -- aok - 19/03/2013\n               P.VL_PIS               = NVL(P.VL_PIS, 0) -\n                                        NVL(:OLD.VL_PIS, 0), -- aok - 12/09/2013\n               P.VL_COFINS            = NVL(P.VL_COFINS, 0) -\n                                        NVL(:OLD.VL_COFINS, 0), -- aok - 12/03/20132\n               P.VLR_DESCONTO = case\n                                  when VREG1.PERC_DESCONTO > 0 or\n                                       NVL(:NEW.VLR_FUNRURAL, 0) > 0 then\n                                   P.VLR_DESCONTO -\n                                   (VN_VLR_DESCONTO +\n                                   NVL(:OLD.VLR_FUNRURAL, 0))\n                                  else\n                                   P.VLR_DESCONTO\n                                end,\n               P.BT_CALCULO           = 'N',\n               p.vl_outras_despesas   = nvl(p.vl_outras_despesas, 0) -\n                                        :OLD.VL_OUTRAS_DESPESAS,\n               P.VFCPUFDEST           = NVL(P.VFCPUFDEST, 0) -\n                                        :OLD.VFCPUFDEST,\n               P.VICMSUFDEST          = NVL(P.VICMSUFDEST, 0) -\n                                        :OLD.VICMSUFDEST,\n               P.VICMSUFREMET         = NVL(P.VICMSUFREMET, 0) -\n                                        :OLD.VICMSUFREMET\n         where P.BEG_FAT_PRE_NFS_ID = VREG1.BEG_FAT_PRE_NFS_ID;\n        --\n      end if;\n      --\n      --if UPDATING('QTDE')\n      --   or UPDATING('VL_UNITARIO') then\n      --  delete BEG_PRE_CRC_TITULO T\n      --   where T.BEG_FAT_PRE_NFS_ID = :NEW.BEG_FAT_PRE_NFS_ID;\n      --end if;\n      ----------------------------------------------------------------------------\n      if not DELETING then\n        -- aok - 16/01/2013\n      \n        -- Irã - 09/04/2010\n        open BUSCA_TIPO_PEDIDO;\n        fetch BUSCA_TIPO_PEDIDO\n          into V_TP_PEDIDO;\n        close BUSCA_TIPO_PEDIDO;\n        --\n        if V_TP_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID is null then\n          V_TP_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID := VREG1.BEG_VEN_TIPO_PEDIDO_ID;\n        end if;\n        --\n        open BUSCA_PESSOA_UF;\n        fetch BUSCA_PESSOA_UF\n          into VREG2;\n        close BUSCA_PESSOA_UF;\n        open SELECIONA_MATRIZ_ESTADO;\n        fetch SELECIONA_MATRIZ_ESTADO\n          into VREG3;\n        if SELECIONA_MATRIZ_ESTADO%notfound then\n          open SELECIONA_MATRIZ_GERAL;\n          fetch SELECIONA_MATRIZ_GERAL\n            into VREG3;\n          if SELECIONA_MATRIZ_GERAL%notfound then\n            RAISE_APPLICATION_ERROR(-20300,\n                                    'Nao existe matriz tributaria para este item. ' ||\n                                    V_PRODUTO_CODIGO || ' UF O.: ' ||\n                                    VREG2.UF_ORIGEM || ' UF D: ' ||\n                                    VREG2.BEG_UF_ID || ' TP: ' ||\n                                    V_TP_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID ||\n                                    ' CONS: ' || VREG2.CONSUMIDOR);\n          end if;\n          close SELECIONA_MATRIZ_GERAL;\n        end if;\n        close SELECIONA_MATRIZ_ESTADO;\n        :NEW.BEG_FIS_MATRIZ_TRIBUTARIA_ID := VREG3.BEG_FIS_MATRIZ_TRIBUTARIA_ID;\n        --\n        IF NVL(VREG3.PERC_PIS, 0) > 0 THEN\n          --\n          :NEW.VL_BASE_CALCULO_PIS := V_TOTAL_ITEM;\n          :NEW.ALIQ_PIS            := NVL(VREG3.PERC_PIS, 0);\n          :NEW.VL_PIS              := ROUND((NVL(:NEW.VL_BASE_CALCULO_PIS,\n                                                 0) *\n                                            NVL(:NEW.ALIQ_PIS, 0)) / 100,\n                                            2);\n          --\n        END IF;\n        --\n        IF NVL(VREG3.PERC_COFINS, 0) > 0 THEN\n          --\n          :NEW.VL_BASE_CALCULO_COFINS := V_TOTAL_ITEM;\n          :NEW.ALIQ_COFINS            := NVL(VREG3.PERC_COFINS, 0);\n          :NEW.VL_COFINS              := ROUND((NVL(:NEW.VL_BASE_CALCULO_COFINS,\n                                                    0) *\n                                               NVL(:NEW.ALIQ_COFINS, 0)) / 100,\n                                               2);\n          --\n        END IF;\n        --\n      \n        -- aok - 19/02/2013 ----------------------------------------------------\n        if VREG1.IND_IMPORTACAO = 'Y' then\n          if NVL(:NEW.VL_UNITARIO_DOLAR, 0) = 0 then\n            RAISE_APPLICATION_ERROR(-20001,\n                                    'Faltou informar o valor unitario em dolar. Verifique!');\n          end if;\n          if NVL(:NEW.PESO_LIQUIDO, 0) = 0 then\n            RAISE_APPLICATION_ERROR(-20002,\n                                    'Faltou informar o peso liquido do item. Verifique!');\n          end if;\n          -- aok - 18/03/2013 --------------------------------------------------\n          if INSERTING then\n            for RPESO in (select sum(A.PESO_LIQ_ADIC) PESO_TOT_LIQ_ADIC\n                            from BEG_FAT_PRE_ADIC_IMPORT A\n                           where A.BEG_FAT_PRE_NFS_ID =\n                                 VREG1.BEG_FAT_PRE_NFS_ID) loop\n              if RPESO.PESO_TOT_LIQ_ADIC <> VREG1.PESO_LIQUIDO then\n                RAISE_APPLICATION_ERROR(-20003,\n                                        'Somatorio do peso liquido da(s) adicao(oes) não confere com a capa da nota. Verifique!');\n              end if;\n            end loop;\n          end if;\n          ----------------------------------------------------------------------\n          VN_VL_UNITARIO := (:NEW.QTDE * :NEW.VL_UNITARIO_DOLAR *\n                            VREG1.VL_DOLAR +\n                            ((VREG1.VL_ACRESCIMO_INTERNACIONAL +\n                            VREG1.VL_SEGURO_INTERNACIONAL + VREG1.VL_THC +\n                            VREG1.VLR_ACR_TRIBUTO +\n                            VREG1.VL_FRETE_INTERNACIONAL) *\n                            :NEW.PESO_LIQUIDO / VREG1.PESO_LIQUIDO)) /\n                            :NEW.QTDE;\n        \n          V_TOTAL_ITEM       := ROUND(:NEW.QTDE * VN_VL_UNITARIO, 2);\n          :NEW.VL_UNITARIO   := VN_VL_UNITARIO; -- aok - 20/02/2013\n          :NEW.VL_BRUTO_ITEM := V_TOTAL_ITEM;\n          -- raise_application_error(-20001, vn_vl_unitario ||' / ' || V_TOTAL_ITEM ||' / ' || :new.vl_bruto_item);\n        else\n          -- aok - 12/03/2013 --------------------\n          if NVL(:NEW.PESO_LIQUIDO, 0) = 0 or UPDATING('QTDE') then\n            :NEW.PESO_LIQUIDO := V_PESO * :NEW.QTDE;\n          end if;\n          if NVL(:NEW.PESO_BRUTO, 0) = 0 or UPDATING('QTDE') then\n            :NEW.PESO_BRUTO := V_PESO * :NEW.QTDE;\n          end if;\n          ----------------------------------------\n          V_TOTAL_ITEM       := ROUND(:NEW.QTDE * NVL(:NEW.VL_UNITARIO, 0),\n                                      2);\n          :NEW.VL_BRUTO_ITEM := V_TOTAL_ITEM; -- aok - 18/01/2013\n        end if;\n        ------------------------------------------------------------------------\n        :NEW.BEG_PRD_NCM_ID := VREG3.BEG_PRD_NCM_ID; -- aok - 06/02/2013\n        --\n        V_BASE_ICMS := V_TOTAL_ITEM;\n        -- AOK / Ira - 27/09/2012-Alterado posicao do calculo para antes do icms\n        -- IPI -----------------------------------------------------------------\n        if VREG3.TP_TRIB_IPI = 'T' then\n          :NEW.VL_BASE_CALCULO_IPI := V_TOTAL_ITEM;\n          :NEW.PERC_IPI            := VREG3.PERC_IPI; -- aok - 28/01/2013\n          :NEW.VL_IPI              := round((V_TOTAL_ITEM * VREG3.PERC_IPI) / 100,\n                                            2); --- ajsutado para 2 casas em 24/3/14 ium\n        elsif VREG3.TP_TRIB_IPI = 'I' then\n          :NEW.VL_BASE_ISENTA_IPI := V_TOTAL_ITEM;\n          :NEW.VL_BASE_OUTRAS_IPI := 0; -- aok - 19/03/2013\n        else\n          :NEW.VL_BASE_OUTRAS_IPI := V_TOTAL_ITEM; -- aok - 18/11/2011\n          :NEW.VL_BASE_ISENTA_IPI := 0;\n          -- :NEW.VL_BASE_ISENTA_IPI := V_TOTAL_ITEM;  -- aok -- 18/11/2011\n        end if;\n        --\n        if NVL(VREG3.RE_ICMS, 0) > 0 then\n          :NEW.PERC_REDUCAO := VREG3.RE_ICMS;\n          V_BASE_ICMS       := V_BASE_ICMS -\n                               (V_BASE_ICMS * (VREG3.RE_ICMS / 100));\n        end if;\n        --\n        :NEW.CST_IPI := VREG3.CST_IPI; -- aok - 18/01/2013\n      \n        -- ICMS\n        if VREG3.TP_TRIB_ICMS in ('T', 'S') -- (T)ributa e (S)ituacao tributaria\n         then\n          if VREG3.REDUCAO = 'TN' -- Base Tributacao normal\n           then\n            :NEW.VL_BASE_CALCULO_ICMS := V_BASE_ICMS;\n            :NEW.VL_ICMS              := round((V_BASE_ICMS *\n                                               NVL(VREG3.PERC_ICM, 0)) / 100,\n                                               2);\n            :NEW.PERC_ICMS            := VREG3.PERC_ICM;\n          elsif VREG3.REDUCAO = 'BC' -- Redução de base\n           then\n            :NEW.VL_BASE_CALCULO_ICMS := V_BASE_ICMS;\n            :NEW.VL_ICMS              := round((V_BASE_ICMS *\n                                               NVL(VREG3.PERC_ICM, 0)) / 100,\n                                               2);\n            :NEW.PERC_ICMS            := VREG3.PERC_ICM;\n          elsif VREG3.REDUCAO = 'IS' -- Isento\n           then\n            :NEW.VL_BASE_ISENTA_ICMS := V_BASE_ICMS;\n            :NEW.VL_ICMS             := 0;\n          elsif VREG3.REDUCAO = 'ST' -- Situacao tributaria\n           then\n            :NEW.VL_BASE_CALCULO_ICMS := V_BASE_ICMS;\n            :NEW.VL_ICMS              := round((V_BASE_ICMS *\n                                               NVL(VREG3.PERC_ICM, 0)) / 100,\n                                               2);\n            :NEW.PERC_ICMS            := VREG3.PERC_ICM;\n            V_BASE_INICIAL_SUBST      := ROUND(:NEW.QTDE *\n                                               NVL(:NEW.VL_UNITARIO, 0),\n                                               2) + NVL(:NEW.VL_IPI, 0); -- aok / Ira - 27/09/2012\n            if NVL(VREG2.CLIENTE_OPTANTE_SIMPLES, 'N') = 'N' then\n              V_BASE_SUBST := NVL(V_BASE_INICIAL_SUBST, 0) +\n                              ((NVL(V_BASE_INICIAL_SUBST, 0) *\n                               NVL(VREG3.PERC_MARGEM_SUBSTITUICAO, 0)) / 100);\n            elsif NVL(VREG2.CLIENTE_OPTANTE_SIMPLES, 'Y') = 'Y' and\n                  NVL(VREG3.MVA_CLIENTE_OPTANTE_SIMPLES, 0) > 0 then\n              V_BASE_SUBST := NVL(V_BASE_INICIAL_SUBST, 0) +\n                              ((NVL(V_BASE_INICIAL_SUBST, 0) *\n                               (NVL(VREG3.PERC_MARGEM_SUBSTITUICAO, 0) *\n                               (NVL(VREG3.MVA_CLIENTE_OPTANTE_SIMPLES, 0) / 100))) / 100);\n            else\n              V_BASE_SUBST := NVL(V_BASE_INICIAL_SUBST, 0) +\n                              ((NVL(V_BASE_INICIAL_SUBST, 0) *\n                               NVL(VREG3.PERC_MARGEM_SUBSTITUICAO, 0)) / 100);\n            end if;\n            V_ICMS_SUBST            := (NVL(V_BASE_SUBST, 0) *\n                                       NVL(VREG3.PERC_ICM_SUBSTITUICAO, 0)) / 100;\n            :NEW.VL_BASE_SUBST_TRIB := NVL(V_BASE_SUBST, 0);\n            :NEW.VL_ICMS_SUBST      := round(NVL(V_ICMS_SUBST, 0) -\n                                             round(((NVL(V_BASE_INICIAL_SUBST,\n                                                         0) -\n                                                   NVL(:NEW.VL_IPI, 0)) *\n                                                   (NVL(VREG3.PERC_ICM, 0) / 100)),\n                                                   2),\n                                             2);\n            :NEW.PERC_ICMS          := VREG3.PERC_ICM;\n          else\n            -- Base outros\n            :NEW.VL_BASE_OUTRAS_ICMS := V_BASE_ICMS;\n            :NEW.VL_ICMS             := 0;\n          end if;\n        elsif VREG3.TP_TRIB_ICMS = 'I' -- (I)sento\n         then\n          :NEW.VL_BASE_ISENTA_ICMS := V_BASE_ICMS;\n          :NEW.VL_ICMS             := 0;\n        elsif VREG3.TP_TRIB_ICMS = 'O' -- (O)utros\n         then\n          :NEW.VL_BASE_OUTRAS_ICMS := V_BASE_ICMS;\n          :NEW.VL_ICMS             := 0;\n        else\n          -- substituicao tributaria\n          null;\n        end if;\n      \n        IF NVL(VREG3.PERC_DIF, 0) > 0 THEN\n        \n          :NEW.VL_BASE_CALCULO_ICMS := V_BASE_ICMS;\n          :NEW.PDIF                 := VREG3.PERC_DIF;\n          :NEW.VICMSOP              := round((V_BASE_ICMS *\n                                             NVL(VREG3.PERC_ICM, 0)) / 100,\n                                             2);\n          :NEW.PERC_ICMS            := VREG3.PERC_ICM;\n          :NEW.VICMSDIF             := round((((V_BASE_ICMS *\n                                             NVL(VREG3.PERC_ICM, 0)) / 100) *\n                                             :NEW.PDIF) / 100,\n                                             2);\n          :NEW.VL_ICMS              := :NEW.VICMSOP - :NEW.VICMSDIF;\n        \n        END IF;\n      \n        :NEW.CST                    := VREG3.CST;\n        :NEW.BEG_FIS_TRIB_ICMS_ID   := VREG3.BEG_FIS_TRIB_ICMS_ID; -- aok - 04/03/2013\n        :NEW.BEG_FIS_ORIGEM_MERC_ID := VREG3.BEG_FIS_ORIGEM_MERC_ID; -- aok - 04/03//2013\n        ----------------------------------------------------------------------------\n        if VREG3.BEG_CFOP_ID is null then\n          RAISE_APPLICATION_ERROR(-20533, 'Cfop nao pode ser nulo.');\n        end if;\n        :NEW.BEG_CFOP_ID := VREG3.BEG_CFOP_ID;\n        --  Raise_Application_Error(-20501, 'ERRO');\n        if VREG2.SUFRAMA is not null then\n          if VREG3.DESC_SUFRAMA is not null and VREG3.DESC_SUFRAMA > 0 then\n            V_DESCONTO_SUFRAMA := ((V_TOTAL_ITEM * VREG3.DESC_SUFRAMA) / 100);\n          else\n            V_DESCONTO_SUFRAMA := 0;\n          end if;\n        end if;\n        if :NEW.AD_CLIENT_ID = 1000001 then\n          :NEW.VL_ICMS_SUBST := 0;\n        end if;\n        --\n        -- :NEW.VL_BRUTO_ITEM := V_TOTAL_ITEM; -- aok - 20/02/2013 --29/01/2013\n        -- :NEW.VL_BRUTO_ITEM := V_TOTAL_ITEM + :NEW.VL_IPI -\n        --                       V_DESCONTO_SUFRAMA +\n        --                       NVL(:NEW.VL_ICMS_SUBST, 0); -- aok - 29/01/2013\n        -- aok - 18/01/2013 -------------------------------------------------------\n        if VREG3.CST_PIS <> VREG3.CST_COFINS then\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Revisar o CST de PIS / COFINS - não podem ser diferentes!');\n        end if;\n        -- PIS -----------------------------------------------------------------\n        -- :NEW.CST_PIS       := VREG2.CST_PIS;\n        -- if VREG2.CST_PIS = '01' then\n        --   :NEW.ALIQ_PIS            := VREG3.PERC_PIS;\n        --   :NEW.VL_BASE_CALCULO_PIS := :NEW.QTDE * :NEW.VL_UNITARIO;\n        --   :NEW.VL_PIS              := ((:NEW.QTDE * :NEW.VL_UNITARIO) *\n        --                               (VREG3.PERC_PIS / 100));\n        -- else\n        --   :NEW.ALIQ_PIS            := null;\n        --   :NEW.VL_BASE_CALCULO_PIS := null;\n        --   :NEW.VL_PIS              := null;\n        -- end if;\n        :NEW.ALIQ_PIS            := 0; --null;\n        :NEW.VL_BASE_CALCULO_PIS := 0; --null;\n        :NEW.VL_PIS              := 0; --null;\n        if VREG3.IND_CALC_PIS = 'Y' then\n          :NEW.ALIQ_PIS            := VREG3.PERC_PIS;\n          :NEW.VL_BASE_CALCULO_PIS := ROUND(:NEW.QTDE * :NEW.VL_UNITARIO, 2); -- aok - 10/10/2012\n          :NEW.VL_PIS              := (ROUND(:NEW.QTDE * :NEW.VL_UNITARIO,\n                                             2) * (VREG3.PERC_PIS / 100));\n          -- else\n          --   :NEW.ALIQ_PIS            := 0; --null;\n          --   :NEW.VL_BASE_CALCULO_PIS := 0; --null;\n          --   :NEW.VL_PIS              := 0; --null;\n          --   vreg3.cst_pis            := '09'; -- IUM\n        end if;\n        :NEW.CST_PIS := VREG3.CST_PIS;\n      \n        -- COFINS --------------------------------------------------------------\n        --:NEW.CST_COFINS := VREG2.CST_COFINS;\n        --if VREG2.CST_COFINS = '01' then\n        --  :NEW.ALIQ_COFINS            := VREG3.PERC_COFINS;\n        --  :NEW.VL_BASE_CALCULO_COFINS := :NEW.QTDE * :NEW.VL_UNITARIO;\n        --  :NEW.VL_COFINS              := ((:NEW.QTDE * :NEW.VL_UNITARIO) *\n        --                                 (VREG3.PERC_COFINS / 100));\n        --else\n        --  :NEW.ALIQ_COFINS            := null;\n        --  :NEW.VL_BASE_CALCULO_COFINS := null;\n        --  :NEW.VL_COFINS              := null;\n        --end if;\n        :NEW.ALIQ_COFINS            := 0; --null;\n        :NEW.VL_BASE_CALCULO_COFINS := 0; --null;\n        :NEW.VL_COFINS              := 0; --null;\n        if VREG3.IND_CALC_COFINS = 'Y' then\n          :NEW.ALIQ_COFINS            := VREG3.PERC_COFINS;\n          :NEW.VL_BASE_CALCULO_COFINS := ROUND(:NEW.QTDE * :NEW.VL_UNITARIO,\n                                               2); -- aok - 10/10/2012\n          :NEW.VL_COFINS              := (ROUND(:NEW.QTDE *\n                                                :NEW.VL_UNITARIO,\n                                                2) *\n                                         (VREG3.PERC_COFINS / 100));\n          --else\n          --  :NEW.ALIQ_COFINS            := 0; --null;\n          --  :NEW.VL_BASE_CALCULO_COFINS := 0; --null;\n          --  :NEW.VL_COFINS              := 0; --null;\n          --  vreg3.cst_cofins            := '09'; -- IUM\n        end if;\n        :NEW.CST_COFINS := VREG3.CST_COFINS;\n        ----------------------------------------------------------------------------\n        ---comentado em 01/12/2015 por Marcelo para poder emitir nota de venda pelo atacado\n        --\n        /*if NVL(V_TOTAL_ITEM, 0) = 0 then\n          RAISE_APPLICATION_ERROR(-20512,\n                                  'Valor total do item nao pode ser zero.' ||\n                                  V_PRODUTO_CODIGO); --|| '-' || VREG2.VALUE);\n        end if;*/\n        -- aok - 31/01/2013 ----------------------------------------------------\n        if VREG1.IND_IMPORTACAO = 'Y' then\n          if NVL(:NEW.BEG_FAT_PRE_ADIC_IMPORT_ID, 0) = 0 then\n            RAISE_APPLICATION_ERROR(-20001,\n                                    'Faltou informar Numero da Adicao da DI');\n          end if;\n          open CADIMP;\n          fetch CADIMP\n            into RADIMP;\n          close CADIMP;\n          :NEW.BEG_VW_FORNECEDOR_ID := NVL(RADIMP.BEG_VW_FORNECEDOR_ID,\n                                           VREG1.BEG_VW_FORNECEDOR_ID); -- aok - 04/03/2013 --06/02/2013\n          if RADIMP.BEG_PRD_NCM_ID <> :NEW.BEG_PRD_NCM_ID then\n            RAISE_APPLICATION_ERROR(-20001,\n                                    'Não conincide a NCM da Adicao com a do Produto');\n          end if;\n          -- Usara da adicao\n          -- if NVL(RADIMP.PERC_TEC, 0) > 0\n          --    and NVL(VREG3.PERC_TEC, 0) = 0 then\n          --   RAISE_APPLICATION_ERROR(-20001,\n          --                           'Percentual da TEC da NCM do produto não informado');\n          -- end if;\n          -- if RADIMP.PERC_TEC <> VREG3.PERC_TEC then\n          --   RAISE_APPLICATION_ERROR(-20001,\n          --                           'Percentual da TEC da NCM do produto difere da adição da DI');\n          -- end if;\n          if not (RADIMP.PERC_IPI = :NEW.PERC_IPI) then\n            RAISE_APPLICATION_ERROR(-20001,\n                                    'Percentual de ipi da Matriz Trib.' ||\n                                    VREG3.COD_MATRIZ || ' (' ||\n                                    :NEW.PERC_IPI ||\n                                    '),  difere da adição da DI (' ||\n                                    RADIMP.PERC_IPI || ')');\n          end if;\n          if not (RADIMP.PERC_PIS = :NEW.ALIQ_PIS) then\n            RAISE_APPLICATION_ERROR(-20001,\n                                    '% PIS da Matriz Trib ' ||\n                                    VREG3.COD_MATRIZ || ' (' ||\n                                    :NEW.ALIQ_PIS ||\n                                    '). difere da adição da DI (' ||\n                                    RADIMP.PERC_PIS || ')');\n          end if;\n          if not (RADIMP.PERC_COFINS = :NEW.ALIQ_COFINS) then\n            RAISE_APPLICATION_ERROR(-20001,\n                                    :NEW.DESC_TECNICA_ITEM || ' ' ||\n                                    '% COFINS da Matriz Trib. ' ||\n                                    VREG3.COD_MATRIZ || ' (' ||\n                                    :NEW.ALIQ_COFINS ||\n                                    ') difere da adição da DI (' ||\n                                    RADIMP.PERC_COFINS || ')');\n          end if;\n          --V_PESO := 0;\n        end if;\n        -----DIFAL  MF 18/08/2016 ---------------------------------------------------------\n        V_TIPOPED := VREG1.BEG_VEN_TIPO_PEDIDO_ID;\n      \n        OPEN C_TPPEDIDO;\n        FETCH C_TPPEDIDO\n          INTO R_TPPED;\n        CLOSE C_TPPEDIDO;\n      \n        --        IF R_TPPED.DIFAL = 'Y' and :new.ad_org_id = 1000134 THEN\n        IF VREG3.DIFAL = 'Y' and :new.ad_org_id = 1000134 THEN\n        \n          V_UF_ID := VREG1.BEG_UF_ID;\n        \n          OPEN C_UF;\n          FETCH C_UF\n            INTO R_UF;\n          CLOSE C_UF;\n        \n          OPEN C_PERC;\n          FETCH C_PERC\n            INTO R_PERC;\n          CLOSE C_PERC;\n        \n          :NEW.VBCUFDEST := :NEW.VL_BASE_CALCULO_ICMS;\n        \n          :NEW.PFCPUDEST      := R_UF.ALIQ_FUNDO;\n          :NEW.PICMSUFDEST    := R_UF.ALIQ_INTERNA;\n          :NEW.PICMSINTER     := R_UF.ALIQ_INTEREST;\n          :NEW.PICMSINTERPART := R_PERC.PERC_DESTINO;\n          :NEW.VFCPUFDEST     := ROUND((:NEW.VBCUFDEST * :NEW.PFCPUDEST) / 100,\n                                       2);\n        \n          :NEW.VICMSUFDEST  := ROUND((ROUND(((:NEW.VBCUFDEST *\n                                            (:NEW.PICMSUFDEST -\n                                            :NEW.PICMSINTER)) / 100),\n                                            2) * :NEW.PICMSINTERPART) / 100,\n                                     2);\n          :NEW.VICMSUFREMET := ROUND((ROUND(((:NEW.VBCUFDEST *\n                                            (:NEW.PICMSUFDEST -\n                                            :NEW.PICMSINTER)) / 100),\n                                            2) * R_PERC.PERC_ORIGEM) / 100,\n                                     2);\n        \n        END IF;\n      \n        --         IF R_TPPED.DIFAL = 'Y' AND  :new.ad_org_id <> 1000134 and R_TPPED.IND_VENDA='Y' AND VREG1.BEG_UF_ID <> 1000000   THEN\n        IF VREG3.DIFAL = 'Y' AND :new.ad_org_id <> 1000134 and\n           R_TPPED.IND_VENDA = 'Y' AND VREG1.BEG_UF_ID <> 1000000 THEN\n          V_UF_ID := VREG1.BEG_UF_ID;\n        \n          OPEN C_UF;\n          FETCH C_UF\n            INTO R_UF;\n          CLOSE C_UF;\n        \n          OPEN C_PERC;\n          FETCH C_PERC\n            INTO R_PERC;\n          CLOSE C_PERC;\n        \n          IF VREG1.IND_PRESENCA = 'Y' THEN\n          \n            :NEW.VBCUFDEST := 0;\n          \n            :NEW.PFCPUDEST      := R_UF.ALIQ_FUNDO;\n            :NEW.PICMSUFDEST    := R_UF.ALIQ_INTERNA;\n            :NEW.PICMSINTER     := R_UF.ALIQ_INTEREST;\n            :NEW.PICMSINTERPART := R_PERC.PERC_DESTINO;\n            :NEW.VFCPUFDEST     := 0;\n          \n            :NEW.VICMSUFDEST  := 0;\n            :NEW.VICMSUFREMET := 0;\n          \n          ELSE\n          \n            :NEW.VBCUFDEST := :NEW.VL_BASE_CALCULO_ICMS;\n          \n            :NEW.PFCPUDEST      := R_UF.ALIQ_FUNDO;\n            :NEW.PICMSUFDEST    := R_UF.ALIQ_INTERNA;\n            :NEW.PICMSINTER     := R_UF.ALIQ_INTEREST;\n            :NEW.PICMSINTERPART := R_PERC.PERC_DESTINO;\n            :NEW.VFCPUFDEST     := ROUND((:NEW.VBCUFDEST * :NEW.PFCPUDEST) / 100,\n                                         2);\n          \n            :NEW.VICMSUFDEST  := ROUND((ROUND(((:NEW.VBCUFDEST *\n                                              (:NEW.PICMSUFDEST -\n                                              :NEW.PICMSINTER)) / 100),\n                                              2) * :NEW.PICMSINTERPART) / 100,\n                                       2);\n            :NEW.VICMSUFREMET := ROUND((ROUND(((:NEW.VBCUFDEST *\n                                              (:NEW.PICMSUFDEST -\n                                              :NEW.PICMSINTER)) / 100),\n                                              2) * R_PERC.PERC_ORIGEM) / 100,\n                                       2);\n          \n          END IF;\n        \n        END IF;\n      \n        ------- FIM DIFAL =================================================================\n        ------------------------------------------------------------------------\n        update BEG_FAT_PRE_NFS P\n           set P.VL_BASE_CALCULO_ICMS = NVL(P.VL_BASE_CALCULO_ICMS, 0) +\n                                        NVL(:NEW.VL_BASE_CALCULO_ICMS, 0),\n               P.VL_ICMS              = NVL(P.VL_ICMS, 0) +\n                                        NVL(:NEW.VL_ICMS, 0),\n               P.VL_BASE_ISENTA_ICMS  = NVL(P.VL_BASE_ISENTA_ICMS, 0) +\n                                        NVL(:NEW.VL_BASE_ISENTA_ICMS, 0),\n               P.VL_BASE_OUTRAS_ICMS  = NVL(P.VL_BASE_OUTRAS_ICMS, 0) +\n                                        NVL(:NEW.VL_BASE_OUTRAS_ICMS, 0),\n               P.VL_BASE_ICMS_SUBST   = NVL(P.VL_BASE_ICMS_SUBST, 0) +\n                                        NVL(:NEW.VL_BASE_SUBST_TRIB, 0),\n               P.VL_ICMS_SUBST        = NVL(P.VL_ICMS_SUBST, 0) +\n                                        NVL(:NEW.VL_ICMS_SUBST, 0),\n               P.VL_IPI               = NVL(P.VL_IPI, 0) + :NEW.VL_IPI,\n               P.VL_BASE_CALCULO_IPI  = NVL(P.VL_BASE_CALCULO_IPI, 0) +\n                                        :NEW.VL_BASE_CALCULO_IPI,\n               P.VL_BASE_ISENTA_IPI   = NVL(P.VL_BASE_ISENTA_IPI, 0) +\n                                        :NEW.VL_BASE_ISENTA_IPI,\n               P.VL_BASE_OUTRAS_IPI   = NVL(P.VL_BASE_OUTRAS_IPI, 0) +\n                                        :NEW.VL_BASE_OUTRAS_IPI,\n               P.VL_TOTAL_PROD        = NVL(P.VL_TOTAL_PROD, 0) +\n                                        V_TOTAL_ITEM,\n               P.DESC_SUFRAMA         = NVL(P.DESC_SUFRAMA, 0) +\n                                        V_DESCONTO_SUFRAMA,\n               P.VL_TOTAL_NFS         = NVL(P.VL_TOTAL_NFS, 0) +\n                                        V_TOTAL_ITEM +\n                                        NVL(:NEW.VL_OUTRAS_DESPESAS, 0) +\n                                        NVL(:NEW.VL_IPI, 0) -\n                                        NVL(:NEW.VL_DESCONTO, 0) -\n                                        NVL(V_DESCONTO_SUFRAMA, 0) +\n                                        NVL(:NEW.VL_ICMS_SUBST, 0) -\n                                        NVL(:OLD.VL_OUTRAS_DESPESAS, 0) -\n                                        NVL(:OLD.VL_IPI, 0) +\n                                        NVL(:NEW.VL_DESCONTO, 0) -\n                                        NVL(:OLD.VL_ICMS_SUBST, 0),\n               P.PESO_LIQUIDO = case\n                                  when VREG1.IND_IMPORTACAO = 'N' then\n                                   NVL(P.PESO_LIQUIDO, 0) + :NEW.PESO_LIQUIDO\n                                --(NVL(V_PESO, 0) * :NEW.QTDE)\n                                  else\n                                   P.PESO_LIQUIDO\n                                end,\n               P.PESO_BRUTO = case\n                                when VREG1.IND_IMPORTACAO = 'N' then\n                                 NVL(P.PESO_BRUTO, 0) + :NEW.PESO_BRUTO\n                              -- (NVL(V_PESO, 0) * :NEW.QTDE)\n                                else\n                                 P.PESO_BRUTO\n                              end,\n               P.VL_PIS               = NVL(P.VL_PIS, 0) +\n                                        NVL(:NEW.VL_PIS, 0), -- aok - 12/09/2013\n               P.VL_COFINS            = NVL(P.VL_COFINS, 0) +\n                                        NVL(:NEW.VL_COFINS, 0), -- aok - 12/03/20132\n               P.BT_CALCULO           = 'N',\n               p.vl_outras_despesas   = NVl(p.vl_outras_despesas, 0) +\n                                        NVL(:NEW.VL_OUTRAS_DESPESAS, 0),\n               P.VFCPUFDEST           = NVL(P.VFCPUFDEST, 0) +\n                                        :NEW.VFCPUFDEST,\n               P.VICMSUFDEST          = NVL(P.VICMSUFDEST, 0) +\n                                        :NEW.VICMSUFDEST,\n               P.VICMSUFREMET         = NVL(P.VICMSUFREMET, 0) +\n                                        :NEW.VICMSUFREMET\n        \n         where P.BEG_FAT_PRE_NFS_ID = VREG1.BEG_FAT_PRE_NFS_ID;\n        --\n        :new.beg_est_almoxarifado_id := nvl(:new.beg_est_almoxarifado_id,\n                                            vreg1.beg_est_almoxarifado_id); -- aok - 10/05/2013\n      end if; -- if not DELETING then\n      --\n      --end if; --  if :NEW.BEG_CFOP_ID is null or :NEW.BEG_CFOP_ID not in (400, 401, 496, 535) then\n      --\n    end if; -- beg_pck_util.vb_total_nfs_item\n    --\n  end if; --   if BEG_PCK_UTIL.VC_PROCESSA -- aok - 16/01/2013\n  --\n  <<FIM>>\n--\n  NULL;\n  --\nend TRG_BIUD_BEG_PRE_NFS_ITEM;\n"}`;
    
    }
}
