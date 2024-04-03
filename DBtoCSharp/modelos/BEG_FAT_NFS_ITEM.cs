
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FAT_NFS_ITEM
    {
            [Required]
        /// <summary>
        /// Percentual do icms
        /// </summary>
        public int PERC_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Percentual de redução
        /// </summary>
        public int PERC_REDUCAO { get; set; }
            [Required]
        /// <summary>
        /// Valor do icms do item
        /// </summary>
        public int VL_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor de base de calculo do ICMS
        /// </summary>
        public int VL_BASE_CALCULO_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor de base isenção ICMS
        /// </summary>
        public int VL_BASE_ISENTA_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor de base outros icms
        /// </summary>
        public int VL_BASE_OUTRAS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Percentual de IPI
        /// </summary>
        public int PERC_IPI { get; set; }
        
        /// <summary>
        /// Valor do IPI
        /// </summary>
        public int VL_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor de base calculo IPI
        /// </summary>
        public int VL_BASE_CALCULO_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor de base isenta IPI
        /// </summary>
        public int VL_BASE_ISENTA_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor de base outras IPI
        /// </summary>
        public int VL_BASE_OUTRAS_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor do icms por subtituicao tributaria
        /// </summary>
        public int VL_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// Valor base da substituição tributaria
        /// </summary>
        public int VL_BASE_SUBST_TRIB { get; set; }
            [Required]
        /// <summary>
        /// Valor proporcional do frete para o item
        /// </summary>
        public int VL_FRETE_ITEM { get; set; }
        
        /// <summary>
        /// Id da origem da mercadoria
        /// </summary>
        public int BEG_FIS_ORIGEM_MERC_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da nota fiscal de saida
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
        
        /// <summary>
        /// Id do movimento do estoque
        /// </summary>
        public int BEG_EST_MOVTO_ESTOQUE_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// Id da tributação do icms
        /// </summary>
        public int BEG_FIS_TRIB_ICMS_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do sku do produto
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
        
        /// <summary>
        /// Id do cfop
        /// </summary>
        public int BEG_CFOP_ID { get; set; }
            [Required]
        /// <summary>
        /// Indica a qtde retornada. Retorno de Conserto ou Devolucao de venda
        /// </summary>
        public int QTDE_RETORNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PREDBCEFET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VBCEFET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PICMSEFET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VICMSEFET { get; set; }
        
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
        
        /// <summary>
        /// Percentual de deiferimento do ICMS
        /// </summary>
        public int PDIF { get; set; }
        
        /// <summary>
        /// Valor do ICMS diferido
        /// </summary>
        public int VICMSDIF { get; set; }
        
        /// <summary>
        /// Valor da margem de contribuicao do produto
        /// </summary>
        public int VLR_MC { get; set; }
        
        /// <summary>
        /// Percentual da margem de contribuicao na venda do produto
        /// </summary>
        public int PERC_MC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_MVAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_CTRL_NF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LINHA_NFS_ENTREGA_FUT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NFS_ENTREGA_FUT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ICMS_FRETE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do item da nota fiscal de saida
        /// </summary>
        public int BEG_FAT_NFS_ITEM_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo - yes / no
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// Sequencia do registro na nota fiscal
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Data da criacao do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Id do Usuario que criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da ultima alteracao do regsitro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// id do usuario que fez a ultima alteracao no registro
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Numero da nota fiscal de saida
        /// </summary>
        public int NRO_NFS { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// Serie da nota fiscal de saida
        /// </summary>
        public string SERIE_NFS { get; set; }
            [Required]
        /// <summary>
        /// Data de emiss?o
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// Quantidade do item
        /// </summary>
        public int QTDE { get; set; }
            [Required]
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
            [Required]
        /// <summary>
        /// Percentual de comissão do item
        /// </summary>
        public int PERC_COMISSAO { get; set; }
        
        /// <summary>
        /// Id do Numero da nota fiscal de entrega futura
        /// </summary>
        public int BEG_VW_NF_ORIGEM_ID { get; set; }
        
        /// <summary>
        /// Linha da nota fiscal de entrega futura
        /// </summary>
        public int BEG_VW_NF_ORIGEM_ITEM_ID { get; set; }
            [Required]
        /// <summary>
        /// Valor de desconto proporcional do item
        /// </summary>
        public int VL_DESCONTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Descrição tecnica do item. N?o necessariamente sera igual a do item
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
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Gera reserva do estroque (s;n)
        /// </summary>
        public string GERA_RESERVA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Observação
        /// </summary>
        public string OBS_LINHA_NFS { get; set; }
        
        /// <summary>
        /// id do contrato de venda programada
        /// </summary>
        public int DIE_VEN_CONTRATO_CP_ID { get; set; }
            [Required]
        /// <summary>
        /// Item de brinde (yes ou no)
        /// </summary>
        public string IND_BRINDE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CST_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CST_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CST_ICMS { get; set; }
        
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

        [NotMapped]
        public string Trigger_BKN_TRG_BIU_COMISSAO_ITEM_NFS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"DECLARE\n  --\n  --PRAGMA AUTONOMOUS_TRANSACTION;\n  --\n  --\n  CURSOR C_VALIDA_COMISSAO IS\n    SELECT *\n      FROM BKN_COMISSAO_ITEM I\n     WHERE I.BEG_FAT_NFS_ITEM_ID = :NEW.BEG_FAT_NFS_ITEM_ID;\n  --\n  R_VALIDA_COMISSAO C_VALIDA_COMISSAO%ROWTYPE;\n  --\n  CURSOR C_COMISSAO IS\n    SELECT ROUND((NVL(:new.QTDE, 0) * NVL(:new.VL_UNITARIO, 0)) -\n                 NVL(:new.VL_DESCONTO, 0) + NVL(:new.VL_CUSTO_FINANCEIRO, 0),\n                 2) VLR_TOT_ITEM,\n           ROUND(NVL(:new.QTDE, 0) * NVL(:new.VL_UNITARIO, 0) -\n                 NVL(:new.VL_DESCONTO, 0),\n                 2) VLR_LIQUIDO,\n           NVL(:new.VL_CUSTO_FINANCEIRO, 0) VL_CUSTO_FINANCEIRO,\n           G.DIE_PRD_GRUPO_ID,\n           G.PERC_COMISSAO,\n           N.BEG_FAT_NFS_ID,\n           N.NRO_NFS,\n           N.AD_CLIENT_ID,\n           N.AD_ORG_ID,\n           N.DIE_GER_VENDEDOR_ID,\n           N.DT_EMISSAO,\n           N.BEG_EST_TP_ESPECIE_ID,\n           E.SIGLA\n      FROM BEG_FAT_NFS        N,\n           BEG_PRODUTO        P,\n           DIE_PRD_GRUPO      G,\n           BEG_EST_TP_ESPECIE E\n     WHERE N.BEG_FAT_NFS_ID = :new.BEG_FAT_NFS_ID\n       AND :new.BEG_PRODUTO_ID = P.BEG_PRODUTO_ID\n       AND P.DIE_PRD_GRUPO_ID = G.DIE_PRD_GRUPO_ID\n       AND N.BEG_EST_TP_ESPECIE_ID = E.BEG_EST_TP_ESPECIE_ID\n       AND N.DIE_GER_VENDEDOR_ID IS NOT NULL\n       AND E.SIGLA IN ('AV', 'CC', 'FI', 'AP', 'CO', 'RF');\n  --\n  R_COMISSAO C_COMISSAO%ROWTYPE;\n  --\n  VN_AVISTA       NUMBER(17, 4);\n  VN_PRAZO        NUMBER(17, 4);\n  VN_VLR_COMISSAO NUMBER(17, 4);\n  --\nBEGIN\n  --\n  IF NOT DELETING THEN\n  open C_COMISSAO;\n  fetch C_COMISSAO\n    into R_COMISSAO;\n  if C_COMISSAO%found then\n    --\n    VN_AVISTA := R_COMISSAO.VLR_LIQUIDO;\n    --\n    VN_VLR_COMISSAO := NVL(VN_VLR_COMISSAO, 0) +\n                       ((NVL(R_COMISSAO.VLR_TOT_ITEM, 0) *\n                        R_COMISSAO.PERC_COMISSAO) / 100);\n    --\n    open C_VALIDA_COMISSAO;\n    fetch C_VALIDA_COMISSAO\n      into R_VALIDA_COMISSAO;\n    if C_VALIDA_COMISSAO%found then\n      update BKN_COMISSAO_ITEM NFS\n         set NFS.VLR_ITEM         = R_COMISSAO.VLR_TOT_ITEM,\n             NFS.VLR_COMISSAO     = NVL(VN_VLR_COMISSAO, 0),\n             NFS.VLR_AVISTA       = NVL(VN_AVISTA, 0),\n             NFS.VLR_PRAZO        = NVL(VN_PRAZO, 0),\n             NFS.DIE_PRD_GRUPO_ID = R_COMISSAO.DIE_PRD_GRUPO_ID\n       where NFS.BEG_FAT_NFS_ITEM_ID = :new.BEG_FAT_NFS_ITEM_ID;\n    else\n      --\n      VN_AVISTA := R_COMISSAO.VLR_LIQUIDO;\n      --\n      VN_VLR_COMISSAO := NVL(VN_VLR_COMISSAO, 0) +\n                         ((NVL(R_COMISSAO.VLR_TOT_ITEM, 0) *\n                          R_COMISSAO.PERC_COMISSAO) / 100);\n      --\n      insert into BKN_COMISSAO_ITEM\n        (BKN_COMISSAO_ITEM_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         value,\n         DIE_GER_VENDEDOR_ID,\n         BEG_FAT_NFS_ID,\n         BEG_FAT_NFS_ITEM_ID,\n         DIE_PRD_GRUPO_ID,\n         VLR_ITEM,\n         VLR_COMISSAO,\n         PERC_COMISSAO,\n         VLR_AVISTA,\n         VLR_PRAZO,\n         VLR_TX_FINANCEIRA)\n      values\n        (BEG_FNC_AD_SEQUENCE('BKN_COMISSAO_ITEM'),\n         R_COMISSAO.AD_CLIENT_ID,\n         R_COMISSAO.AD_ORG_ID,\n         'Y',\n         sysdate,\n         1000000,\n         sysdate,\n         1000000,\n         R_COMISSAO.NRO_NFS,\n         R_COMISSAO.DIE_GER_VENDEDOR_ID,\n         :new.BEG_FAT_NFS_ID,\n         :new.BEG_FAT_NFS_ITEM_ID,\n         R_COMISSAO.DIE_PRD_GRUPO_ID,\n         R_COMISSAO.VLR_TOT_ITEM,\n         ROUND(VN_VLR_COMISSAO, 2),\n         R_COMISSAO.PERC_COMISSAO,\n         NVL(VN_AVISTA, 0),\n         NVL(VN_PRAZO, 0),\n         R_COMISSAO.VL_CUSTO_FINANCEIRO -- VALOR TAXA FINANCEIRA\n         );\n      --\n    end if;\n    close C_VALIDA_COMISSAO;\n    --\n  end if;\n  close C_COMISSAO;\n  --\n  ELSE\n    --\n    DELETE FROM bkn_comissao_item WHERE BEG_FAT_NFS_ITEM_ID = :OLD.BEG_FAT_NFS_ITEM_ID;\n    --\n  END IF;\n\n  --commit;\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BU_BEG_FAT_NFS_ITEM { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  -- local variables here\n  cursor BUSCA_NOTA is\n    select N.BEG_EST_TP_ESPECIE_ID,\n           N.NRO_NFS,\n           n.beg_vw_pessoa_entrega_id,\n           TS.IND_GERA_HST_NF,\n           ts.ind_gera_hst_vinc,\n           ts.ind_faturamento\n      from BEG_FAT_NFS N, BEG_EST_TP_ESPECIE TS\n     where N.BEG_FAT_NFS_ID = :new.BEG_FAT_NFS_ID\n       AND N.BEG_EST_TP_ESPECIE_ID = TS.BEG_EST_TP_ESPECIE_ID;\n  --\n  VREG1 BUSCA_NOTA%rowtype;\n  ---\n  CURSOR BUSCA_PRODUTO IS\n    SELECT BEG_PRD_TIPO_ID\n      FROM BEG_PRODUTO P\n     WHERE P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n  --\n  V_TIPO BUSCA_PRODUTO%ROWTYPE;\n  --\n  V_BEG_EST_ALMOXARIFADO_ID number(10);\n  V_BEG_EST_MOVTO_ESTOQUE   number(10);\n  V_BEG_FAT_NFS_ID          number(10);\n  V_AD_ORG_ESPECIAL         number(10);\n  V_ACERTO_ESPECIAL         number(10);\n  --\n  cursor busca_filial is\n    select f.value\n      from beg_dado_filial f\n     where f.beg_pessoa_id = vreg1.beg_vw_pessoa_entrega_id;\n  --\n  v_filial busca_filial%rowtype;\n\nbegin\n  --\n  OPEN BUSCA_PRODUTO;\n  FETCH BUSCA_PRODUTO\n    INTO V_TIPO;\n  CLOSE BUSCA_PRODUTO;\n  IF V_TIPO.BEG_PRD_TIPO_ID = 2000001 THEN\n    RETURN;\n  END IF;\n  V_BEG_FAT_NFS_ID := :new.BEG_FAT_NFS_ID;\n  open BUSCA_NOTA;\n  fetch BUSCA_NOTA\n    into VREG1;\n  close BUSCA_NOTA;\n\n  ---- calculo e percentual MC\n  if vreg1.ind_faturamento = 'Y'then\n\n   if NVL(:new.vl_custo_produto,0)=0 then\n    :new.vl_custo_produto := ROUND(BEG_FNC_CST_VALOR(1000016,\n                                                     :new.BEG_PRODUTO_ID,\n                                                     :new.BEG_PRD_SKU_ID,\n                                                     :new.DT_EMISSAO),\n                                   2);\n   end if;                                   \n\n    :new.vlr_mc := (((:new.qtde*:new.vl_unitario)- :NEW.VL_DESCONTO) - :new.vl_pis  - :new.vl_cofins - :new.vl_icms) - (:new.vl_custo_produto * :new.qtde);\n\n    :new.perc_mc := ROUND(:new.vlr_mc/(:new.qtde*:new.vl_unitario) * 100,2);\n--                    ROUND((A.vlr_mc/(A.qtde*A.vl_unitario)*100),4)\n\n  end if;\n\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00038 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n/*-------------------------------------------------------------------------------------\n  Objetivo(s)..: Validacao do SKU\n  Modulo.......: EST- Estoque\n  Analista.....: Guilherme Costa\n  Alteracoes:\n  Data        Desenvolvedor    Alteracao\n  16/02/2007  Guilherme Costa  Criacao.\n  -------------------------------------------------------------------------------------*/\n  CURSOR C_BUSCA_NF IS\n    SELECT NRO_NFS\n         , AD_ORG_ID\n      FROM BEG_FAT_NFS\n     WHERE BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID;\n  --\n  R_BUSCA_NF C_BUSCA_NF%ROWTYPE;\n  --\n  CURSOR C_PRODUTO IS\n    SELECT P.DIE_COD_PRODUTO\n      FROM BEG_PRODUTO P\n     WHERE P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n  --\n  R_PRODUTO C_PRODUTO%ROWTYPE;\n  --\nbegin\n  --\n  --BKN_PRC_GER_COMISSAO_NFS(:NEW.BEG_FAT_NFS_ITEM_ID);\n  --\n  OPEN C_BUSCA_NF;\n  FETCH C_BUSCA_NF INTO R_BUSCA_NF;\n  CLOSE C_BUSCA_NF;\n  --\n  OPEN C_PRODUTO;\n  FETCH C_PRODUTO INTO R_PRODUTO;\n  CLOSE C_PRODUTO;\n  --\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ID_PROD'||:new.BEG_PRODUTO_ID ||' ID_SKU'||:NEW.BEG_PRD_SKU_ID||' COD_ITEM'||R_PRODUTO.DIE_COD_PRODUTO||' NRO_NOTA '||R_BUSCA_NF.NRO_NFS||' FILIAL'||R_BUSCA_NF.AD_ORG_ID);\n  end if;\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_FAT_NFS_ITEM { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  -- local variables here\n  cursor BUSCA_NOTA is\n    select N.BEG_EST_TP_ESPECIE_ID,\n           N.NRO_NFS,\n           n.beg_vw_pessoa_entrega_id,\n           TS.IND_GERA_HST_NF,\n           ts.ind_gera_hst_vinc,\n           ts.ind_faturamento\n      from BEG_FAT_NFS N, BEG_EST_TP_ESPECIE TS\n     where N.BEG_FAT_NFS_ID = :new.BEG_FAT_NFS_ID\n       AND N.BEG_EST_TP_ESPECIE_ID = TS.BEG_EST_TP_ESPECIE_ID;\n  --\n  VREG1 BUSCA_NOTA%rowtype;\n  ---\n  CURSOR BUSCA_PRODUTO IS\n    SELECT BEG_PRD_TIPO_ID\n      FROM BEG_PRODUTO P\n     WHERE P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n  --\n  V_TIPO BUSCA_PRODUTO%ROWTYPE;\n  --\n  V_BEG_EST_ALMOXARIFADO_ID number(10);\n  V_BEG_EST_MOVTO_ESTOQUE   number(10);\n  V_BEG_FAT_NFS_ID          number(10);\n  V_AD_ORG_ESPECIAL         number(10);\n  V_ACERTO_ESPECIAL         number(10);\n  --\n  cursor busca_filial is\n    select f.value\n      from beg_dado_filial f\n     where f.beg_pessoa_id = vreg1.beg_vw_pessoa_entrega_id;\n  --\n  v_filial busca_filial%rowtype;\n\nbegin\n  --\n  OPEN BUSCA_PRODUTO;\n  FETCH BUSCA_PRODUTO\n    INTO V_TIPO;\n  CLOSE BUSCA_PRODUTO;\n  IF V_TIPO.BEG_PRD_TIPO_ID = 2000001 THEN\n    RETURN;\n  END IF;\n  V_BEG_FAT_NFS_ID := :new.BEG_FAT_NFS_ID;\n  open BUSCA_NOTA;\n  fetch BUSCA_NOTA\n    into VREG1;\n  close BUSCA_NOTA;\n  DBMS_OUTPUT.PUT_LINE('cliente ' || :new.AD_CLIENT_ID);\n  DBMS_OUTPUT.PUT_LINE('org ' || :new.AD_ORG_ID);\n  DBMS_OUTPUT.PUT_LINE('NRO NFS ' || V_BEG_FAT_NFS_ID);\n  --\n  V_AD_ORG_ESPECIAL := BEG_FNC_RETORNA_PARAM_GERAL('Vendas',\n                                                   'Faturamento',\n                                                   'ESPECIAL');\n\n  V_ACERTO_ESPECIAL := BEG_FNC_RETORNA_PARAM_GERAL('Vendas',\n                                                   'Faturamento',\n                                                   'ACERTO_ESPECIAL');\n\n  V_BEG_EST_ALMOXARIFADO_ID := BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n                                                         :new.AD_ORG_ID,\n                                                         'Vendas',\n                                                         'Faturamento',\n                                                         'ALMOXARIFADO FATURAMENTO');\n  --\n  V_BEG_EST_MOVTO_ESTOQUE       := BEG_FNC_AD_SEQUENCE('BEG_EST_MOVTO_ESTOQUE');\n  :new.BEG_EST_MOVTO_ESTOQUE_ID := V_BEG_EST_MOVTO_ESTOQUE;\n  ---- calculo e percentual MC\n  if vreg1.ind_faturamento = 'Y'then\n\n    :new.vlr_mc := (((:new.qtde*:new.vl_unitario)- :NEW.VL_DESCONTO) - :new.vl_pis  - :new.vl_cofins - :new.vl_icms) - (:new.vl_custo_produto * :new.qtde);\n\n   -- :new.perc_mc := ROUND(:new.vlr_mc/((:new.qtde*:new.vl_unitario) * 100),2);\n    :new.perc_mc := ROUND(:new.vlr_mc/(:new.qtde*:new.vl_unitario) * 100,2);\n\n  end if;\n\n\n  open busca_filial;\n  fetch busca_filial\n    into v_filial;\n  if busca_filial%notfound then\n    v_filial.value := null;\n  end if;\n  close busca_filial;\n  insert into BEG_EST_MOVTO_ESTOQUE\n    (BEG_EST_MOVTO_ESTOQUE_ID,\n     AD_CLIENT_ID,\n     AD_ORG_ID,\n     ISACTIVE,\n     CREATED,\n     CREATEDBY,\n     UPDATED,\n     UPDATEDBY,\n     BEG_EST_TP_ESPECIE_ID,\n     BEG_PRD_SKU_ID,\n     BEG_EST_ALMOXARIFADO_ID,\n     VLR_MOVTO,\n     QTD_MOVTO,\n     BEG_PRODUTO_ID,\n     DOCUMENTO)\n  values\n    (V_BEG_EST_MOVTO_ESTOQUE,\n     :new.AD_CLIENT_ID,\n     :new.AD_ORG_ID,\n     :new.ISACTIVE,\n     :new.CREATED,\n     :new.CREATEDBY,\n     :new.UPDATED,\n     :new.UPDATEDBY,\n     DECODE(V_AD_ORG_ESPECIAL,\n            :new.AD_CLIENT_ID,\n            V_ACERTO_ESPECIAL,\n            VREG1.BEG_EST_TP_ESPECIE_ID),\n     :new.BEG_PRD_SKU_ID,\n     nvl(:new.BEG_EST_ALMOXARIFADO_ID, V_BEG_EST_ALMOXARIFADO_ID),\n     (:new.QTDE * :new.VL_UNITARIO),\n     :new.QTDE,\n     :new.BEG_PRODUTO_ID,\n     VREG1.NRO_NFS ||\n     decode(v_filial.value, null, null, ' Para F-' || v_filial.value));\n\n  ------INSERÇÃO NAS TABELAS DE HISTORICO DE NOTAS\n\n  IF VREG1.IND_GERA_HST_NF = 'Y' THEN\n    INSERT INTO BEG_HST_NOTA_FISCAL\n      (BEG_HST_NOTA_FISCAL_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       BEG_FAT_NFS_ID,\n       BEG_FAT_NFS_ITEM_ID,\n       BEG_CPR_NFE_ID,\n       BEG_CPR_NFE_ITEM_ID,\n       QTD_TOTAL,\n       QTD_DEVOLVIDA,\n       QTD_FALTANTE,\n       BEG_PRODUTO_ID,\n       BEG_PRD_SKU_ID)\n    VALUES\n\n      (BEG_FNC_AD_SEQUENCE('BEG_HST_NOTA_FISCAL'), --BEG_HST_NOTA_FISCAL_ID,\n       1000000, --AD_CLIENT_ID,\n       :NEW.AD_ORG_ID, --AD_ORG_ID,\n       'Y', --ISACTIVE,\n       :NEW.CREATED, --CREATED,\n       :NEW.CREATEDBY, --CREATEDBY,\n       :NEW.UPDATED, --UPDATED,\n       :NEW.UPDATEDBY, --UPDATEDBY,\n       :NEW.BEG_FAT_NFS_ID, --BEG_FAT_NFS_ID,\n       :NEW.BEG_FAT_NFS_ITEM_ID, --BEG_FAT_NFS_ITEM_ID,\n       NULL, --BEG_CPR_NFE_ID,\n       NULL, --BEG_CPR_NFE_ITEM_ID,\n       :NEW.QTDE, --QTD_TOTAL,\n       0, --QTD_DEVOLVIDA,\n       :NEW.QTDE, --QTD_FALTANTE,\n       :NEW.BEG_PRODUTO_ID, --BEG_PRODUTO_ID,\n       :NEW.BEG_PRD_SKU_ID --BEG_PRD_SKU_ID\n       );\n\n  END IF;\n\n  ---- INSERCAO NA TABELA DE NOTAS VINCULADAS (EX: DEVOLUCAO DE FORNECEDOR)\n\n\nend BEG_FAT_NFS_ITEM;\n"}`;
    
    }
}
