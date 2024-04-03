
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_TITULO
    {
        
        /// <summary>
        /// Data original do vencimento antes de ser prorrogado ou com promessa de pagamento
        /// </summary>
        public string DT_VCTO_ORIGINAL { get; set; }
        
        /// <summary>
        /// valor original do titulo renegociado
        /// </summary>
        public int VLR_ORIGINAL { get; set; }
        
        /// <summary>
        /// Data base para geracao do aviso
        /// </summary>
        public string DT_GERA_AVISO { get; set; }
        
        /// <summary>
        /// Valor seguros ap e residencial
        /// </summary>
        public int VLR_SEGUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PGTO { get; set; }
        
        /// <summary>
        /// Indica se ja foi enviado para cobrador
        /// </summary>
        public string IND_COBRADOR { get; set; }
        
        /// <summary>
        /// Data de pagamento na assessoria
        /// </summary>
        public string DT_PGTO_COBRANCA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_NEW_PDV { get; set; }
        
        /// <summary>
        /// Valor reajuste sofrido na compra programada
        /// </summary>
        public int VLR_REAJUSTE { get; set; }
        
        /// <summary>
        /// Diementz - sera substituido pelo tipo de titulo
        /// </summary>
        public string SRDUP { get; set; }
        
        /// <summary>
        /// Diementz - sera substituido pelo tipo de titulo
        /// </summary>
        public string CLASSIF { get; set; }
        
        /// <summary>
        /// Id do cobrador - AOK - 30/03/2007
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
        
        /// <summary>
        /// Diementz para identificar a data de previsao de pagamento por parte do cliente
        /// </summary>
        public string DT_AVISO_PGTO { get; set; }
        
        /// <summary>
        /// Diementz para identificar o numero da nota fiscal de devolucao
        /// </summary>
        public int NUM_NF_DEVOL { get; set; }
        
        /// <summary>
        /// Diementz para identificar o tipo da devolucao - (P)arcial ou (T)otal
        /// </summary>
        public string TIPO_DEVOL { get; set; }
        
        /// <summary>
        /// Diementz para identificar a data da nf de devolucao
        /// </summary>
        public string DATA_DEVOL { get; set; }
        
        /// <summary>
        /// Id do aviso pessoa
        /// </summary>
        public int BEG_COB_AVISO_PESSOA_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
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
        /// parcela do titulo
        /// </summary>
        public int PARCELA { get; set; }
            [Required]
        /// <summary>
        /// data de emissao do titulo
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// data de vencimento
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// Valor do titulo
        /// </summary>
        public int VLR_TITULO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MULTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_JUROS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo de cobranca carne ou bancaria
        /// </summary>
        public string TP_COBRANCA { get; set; }
            [StringLength(30)]
        /// <summary>
        /// numero do titulo no banco
        /// </summary>
        public string NUMERO_TITULO_BANCO { get; set; }
            [StringLength(500)]
        /// <summary>
        /// observacao
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// valor da despesa de cobranca.
        /// </summary>
        public int VLR_DESPESA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_NF_SAIDA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENVIO_BCO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEQ_ENVIO_BCO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_RENEGOCIACAO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IMPRESSO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COB_AVISO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_LOTE_COB_ESCR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PCE_LOTE_COBRANCA_ID { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string LINHA_DIGITAVEL { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO_BARRAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PCE_COMANDO_REM_COB_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PCE_INSTRUCAO_COBRANCA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PCE_INSTR_COBR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
            [Required]
        /// <summary>
        /// Valor do seguro (Protecao Financeira)
        /// </summary>
        public int VLR_SEGURO { get; set; }
            [Required]
        /// <summary>
        /// Valor referente a garantia estendida
        /// </summary>
        public int VLR_GARANTIA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TX_FINANCEIRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_LOCALIZACAO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PREPOSTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TELEVENDA_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BI_TIT_TOT { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n\n  V_TOT NUMBER(18, 2);\n\n  CURSOR C1 IS\n  /*select NVL(SUM(nvl(T.VLR_TITULO, 0)) - sum(nvl(t.vlr_seguro, 0)) -\n             sum(nvl(t.vlr_garantia, 0)) - sum(nvl(t.vlr_seguros, 0)),0) VALOR\n      \n        from BEG_CRC_TITULO T, AD_ORG O\n       where O.AD_ORG_ID = T.AD_ORG_ID\n         and t.BEG_TIPO_TITULO_ID not in (2500015, 2500012, 2500020)\n         and nvl(t.num_nf_devol, 0) = 0\n         and t.data_devol is null\n         and T.DT_EMISSAO = TRUNC(SYSDATE);*/\n    SELECT SUM(TABELA.VALOR) VALOR\n      FROM (select (SUM(nvl(T.VL_TOTAL_NFS, 0)) - sum(nvl(t.vl_seguro, 0)) -\n                   sum(nvl(t.vl_garantia, 0)) - sum(nvl(t.Vl_Seguros, 0)) -\n                   sum(nvl(t.vl_frete, 0))) Valor\n              from BEG_FAT_NFS T, BEG_EST_TP_ESPECIE TS, AD_ORG O\n             where O.AD_ORG_ID = T.AD_ORG_ID\n               AND T.BEG_EST_TP_ESPECIE_ID = TS.BEG_EST_TP_ESPECIE_ID\n               AND TS.IND_FATURAMENTO = 'Y'\n               AND T.CANCELADA = 'N'\n               AND t.BEG_EST_TP_ESPECIE_ID NOT IN (2000025)\n                  -- and  o.value not in ('052','058') \n               and T.DT_EMISSAO = trunc(sysdate)\n--               and t.beg_fat_nfs_id <> :new.beg_fat_nfs_id\n            \n            union\n            select -nvl((SUM(NVL(NE.VLR_TOTAL_PRODUTOS - NE.VLR_DESCONTO +\n                                 NE.VLR_ACRESCIMO,\n                                 0))),\n                        0)\n              FROM BEG_CPR_NFE NE, ad_org o\n             WHERE NE.BEG_EST_TP_ESPECIE_ID = 2000013\n               AND NE.DOCSTATUS <> 'CA'\n                  --         and    o.value not in ('052','058')\n               AND NE.DT_EMISSAO = trunc(sysdate)\n               AND NE.AD_ORG_ID = O.AD_ORG_ID\n            \n            ) TABELA;\n           \n           R1 C1%ROWTYPE;\n\nBEGIN\n\n  IF :NEW.Beg_Tipo_Titulo_Id NOT IN (2500015, 2500012, 2500020) /*and :new.ad_org_id not in (1000016,1000134)*/\n   THEN\n  \n    open C1;\n    fetch C1\n      into R1;\n    close C1;\n  \n    V_TOT := NVL(R1.VALOR, 0) /*+\n             (:NEW.VLR_TITULO - nvl(:NEW.vlr_seguro, 0) -\n              nvl(:NEW.vlr_garantia, 0) - nvl(:NEW.vlr_seguros, 0))*/;\n  \n    INSERT INTO DIE_CRC_TIT_TOT\n    \n      (DIE_CRC_TIT_TOT_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       VALUE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       VLR_TITULO,\n       VLR_TIT_TOT)\n    VALUES\n    \n      (:NEW.BEG_CRC_TITULO_ID,\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID,\n       :NEW.ISACTIVE,\n       :NEW.VALUE,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       :NEW.VLR_TITULO,\n       V_TOT);\n  \n  END IF;\n\nEND DIE_TRG_BI_TIT_TOT;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIUD_CRC_TIT_ENCERRAMENTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n     cursor C_FECH_CONT is\n   select MAX(C.DT_FINAL) DT_FINAL\n      from BEG_FECH_CONTABIL C\n      WHERE C.IND_ESCRITA = 'N';\n  --\n  R_FECH_CONT C_FECH_CONT%rowtype;\n  --\n    cursor C_FECH_CONT1 is\n    select ind_escrita from BEG_FECH_CONTABIL C where c.dt_final = R_FECH_CONT.DT_FINAL;\n  --\n  R_FECH_CONT1 C_FECH_CONT1%rowtype;\n\n  begin\n      if (updating\n      and :new.DT_EMISSAO <> :old.DT_EMISSAO)\n       or inserting  or deleting\n       then\n    open C_FECH_CONT;\n    fetch C_FECH_CONT into R_FECH_CONT;\n    close C_FECH_CONT;\n    open C_FECH_CONT1;\n    fetch C_FECH_CONT1\n      into R_FECH_CONT1;\n    close C_FECH_CONT1;\n    if R_FECH_CONT.DT_FINAL >= :new.Dt_Emissao then\n      if nvl(r_FECH_CONT1.ind_escrita,'N') ='N' then\n      raise_application_error(-20501,'Movimento ja encerrado!'||:new.Dt_Emissao);\n      END IF;\n    end if;\n  end if;\n  end trg_biud_crc_his_encerramento;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BI_CRC_TITULOS { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n\n  cursor CTITULO_RENEG is\n    select X.*,\n           Z.IND_ATUACAO\n      from DIE_CRC_RENEGOCIACAO X,\n           BEG_COBRADOR         Z\n     where/* X.AD_CLIENT_ID = :new.AD_CLIENT_ID\n       and*/ X.AD_ORG_ID = :new.AD_ORG_ID\n       and X.value = :new.value\n       and Z.BEG_COBRADOR_ID = X.BEG_COBRADOR_ID;\n  RTITULO_RENEG CTITULO_RENEG%rowtype;\n\n  cursor CPESSOA is\n    select P.FUNCIONARIO,\n           P.TP_PESSOA,\n           P.BEG_CIDADE_ID\n      from BEG_PESSOA P\n     where P.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  RPESSOA CPESSOA%rowtype;\n\nbegin\n\n  if :new.BEG_TIPO_TITULO_ID in (2500012, 2500015)\n   /*  BEG_FNC_RETORNA_PARAM_GERAL('Vendas', null, 'RENEGOCIACAO')*/ then\n    open CTITULO_RENEG;\n    fetch CTITULO_RENEG\n      into RTITULO_RENEG;\n    if CTITULO_RENEG%found then\n      open CPESSOA;\n      fetch CPESSOA\n        into RPESSOA;\n      close CPESSOA;\n      :new.BEG_COBRADOR_ID := RTITULO_RENEG.BEG_COBRADOR_ID;\n      insert into BEG_TITULO_COBRADOR\n        (BEG_TITULO_COBRADOR_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         DT_EMISSAO,\n         DT_VCTO,\n         VLR_ABERTO,\n         DT_ENVIO,\n         DT_COBRANCA,\n         IND_BAIXA_COBRANCA,\n         IND_ENVIADO,\n         DT_PAGTO,\n         VLR_PAGTO,\n         BEG_FILIAL_ID,\n         BEG_PESSOA_ID,\n         BEG_CRC_TITULO_ID,\n         IND_RENEGOCIADO,\n         BEG_COB_LOTE_COBR_ID,\n         CONTRATO,\n         DT_BAIXA_COBRANCA,\n         DESC_MOTIVO,\n         IND_ABERTO,\n         FUNCIONARIO,\n         TP_PESSOA,\n         IND_RELATORIO,\n         BEG_COBRADOR_ID,\n         BEG_CIDADE_ID,\n         BEG_CRC_TPMOV_ID,\n         BEG_TIPO_TITULO_ID,\n         IND_BAIXA_CONTRATO,\n         DT_PAGTO_ANT,\n         ID_MOTIVO_ANT)\n      values\n        (BEG_FNC_AD_SEQUENCE('BEG_TITULO_COBRADOR'),\n         :new.AD_CLIENT_ID,\n         :new.AD_ORG_ID,\n         :new.ISACTIVE,\n         :new.CREATED,\n         :new.CREATEDBY,\n         :new.UPDATED,\n         :new.UPDATEDBY,\n         :new.DT_EMISSAO,\n         :new.DT_VCTO,\n         :new.VLR_ABERTO,\n         -- Quando renegociado , considerar como data de envio para cobrador o vencimento - AOK - 02/10/2008\n         case when RTITULO_RENEG.IND_ATUACAO = 'A' then null else\n         :new.DT_VCTO end, -- :new.dt_emissao end, -- dt_envio\n         null, -- dt_cobranca\n         'N', -- ind_baixa_cobranca\n         case when RTITULO_RENEG.IND_ATUACAO = 'A' then 'N' else 'Y' end, -- ind_enviado\n         -- 'Y', -- Ind_enviado  -- AOK -- 25/08/2008\n         null, -- dt_pagto\n         null, -- vlr_pagto\n         NVL(RTITULO_RENEG.BEG_FILIAL_ID, :new.AD_ORG_ID), -- beg_filial_id\n         :new.BEG_PESSOA_ID,\n         :new.BEG_CRC_TITULO_ID,\n         'N', -- ind_renegociado\n         null, -- beg_cob_lote_cobr_id\n         TO_NUMBER(:new.value), -- contrato\n         null, -- dt_baixa_cobranca\n         null, -- desc_motivo\n         :new.IND_ABERTO,\n         RPESSOA.FUNCIONARIO, -- funcionario\n         RPESSOA.TP_PESSOA, -- tp_pessoa\n         case when RTITULO_RENEG.IND_ATUACAO = 'A' then 'Y' else 'N' end, -- ind_relatorio\n         RTITULO_RENEG.BEG_COBRADOR_ID,\n         RPESSOA.BEG_CIDADE_ID,\n         null, -- beg_crc_tpmov_id\n         :new.BEG_TIPO_TITULO_ID,\n         'N', -- ind_baixa_contrato\n         null, -- dt_pagto_ant\n         null -- id_motivo_ant\n         );\n    end if;\n  end if;\nend DIE_TRG_BI_CRC_TITULOS;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_AUR_CRC_TITULOS { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n/*------------------------------------------------------------------------------\nObjetivo: Atualiza informacoes financeiras\nAnalista: ??\nAlteracoes\n13/05/2009 - Aroldo O. Krul - inserido baixa de restricoes automaticas quando \n             quita dividas.\n------------------------------------------------------------------------------*/\n  V_ID_INF_PES number(18);\n  cursor CPOS_CLI is\n    select *\n      from BEG_FIN_INF_PESSOA IP\n     where IP.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  RPOS_CLI CPOS_CLI%rowtype;\n\nbegin\n  update BEG_FIN_INF_PESSOA F\n     set F.TOT_CRC_ABERTO  = F.TOT_CRC_ABERTO -\n                             (:old.VLR_ABERTO - :new.VLR_ABERTO),\n         F.TOT_CRC_VENCIDO = F.TOT_CRC_VENCIDO -\n                             (DECODE(SIGN(:new.DT_VCTO - TRUNC(sysdate)),\n                                     -1,\n                                     (:old.VLR_ABERTO - :new.VLR_ABERTO),\n                                     0))\n   where F.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  if sql%notfound then\n   -- AD_SEQUENCE_NEXT('BEG_FIN_INF_PESSOA', 0, V_ID_INF_PES);\n    \n    insert into BEG_FIN_INF_PESSOA\n      (BEG_FIN_INF_PESSOA_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       BEG_PESSOA_ID,\n       LIMITE_CREDITO,\n       CREDIT_SCORE,\n       TOT_CRC_ABERTO,\n       TOT_CRC_VENCIDO,\n       MEDIA_ATRASO_CRC,\n       TOT_CPG_ABERTO,\n       TOT_CPG_VENCIDO,\n       QTD_ANO,\n       VLR_CRC_TOTAL)\n    values\n      (beg_fnc_ad_sequence('BEG_FIN_INF_PESSOA'),\n       :new.AD_CLIENT_ID,\n       0, --:new.AD_ORG_ID,\n       :new.ISACTIVE,\n       :new.CREATED,\n       :new.CREATEDBY,\n       :new.UPDATED,\n       :new.UPDATEDBY,\n       :new.BEG_PESSOA_ID,\n       0,\n       0,\n       :new.VLR_ABERTO,\n       DECODE(SIGN(:new.DT_VCTO - TRUNC(sysdate)), -1, :new.VLR_ABERTO, 0),\n       0, -- media_atraso_crc\n       0, -- tot_cpg_aberto\n       0, -- tot_cpg_vencido\n       0, -- qtd_ano -- 15/10/07 - AOK\n       :new.VLR_ABERTO); -- vlr_crc_total -- 15/10/07 - AOK\n  end if;\n\n  -- AOK - 14/05/2009\n  if :new.vlr_aberto = 0 then\n    open CPOS_CLI;\n    fetch CPOS_CLI\n      into RPOS_CLI;\n    if CPOS_CLI%found\n       and RPOS_CLI.TOT_CRC_ABERTO = 0 then\n      update BEG_PESSOA_RESTRICAO PR\n         set PR.DT_SAIDA            = sysdate,\n             PR.BEG_MOTIVO_BAIXA_ID = BEG_FNC_RETORNA_PARAM_GERAL('Cobranca',\n                                                                  null,\n                                                                  'BAIXA_PADRAO') --2000000\n       where PR.BEG_PESSOA_ID = RPOS_CLI.BEG_PESSOA_ID\n         and PR.IND_AUTOMATICA = 'Y'\n         and PR.DT_SAIDA is null\n         and PR.BEG_ORGAO_GERADOR_ID =\n             BEG_FNC_RETORNA_PARAM_GERAL('Cobranca',\n                                         null,\n                                         'MSG_AUT_SISTEMA') --2000004\n         and PR.BEG_RESTRICAO_ID =\n             BEG_FNC_RETORNA_PARAM_GERAL('Financeiro', null, 'NAO_VENDER') --2000003;\n      ;\n    end if;\n  end if;\n\nend BEG_TRG_AUR_CRC_TITULOS;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_CRC_TITULOS_ABERTOS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"begin\n  if INSERTING and :new.IND_ABERTO = 'Y' then\n    insert into BEG_CRC_TITULO_ABERTO_ORG\n      (BEG_CRC_TITULO_ABERTO_ORG_ID,\n       BEG_CRC_TITULO_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       value,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       PARCELA,\n       DT_EMISSAO,\n       DT_VCTO,\n       VLR_TITULO,\n       VLR_MULTA,\n       VLR_JUROS,\n       VLR_DESCONTO,\n       VLR_ABERTO,\n       TP_COBRANCA,\n       NUMERO_TITULO_BANCO,\n       OBS,\n       VLR_DESPESA,\n       BEG_TIPO_TITULO_ID,\n       BEG_PESSOA_ID,\n       BEG_MOEDA_ID,\n       BEG_CONVENIO_ID,\n       BEG_BANCO_ID,\n       SERIE,\n       NUM_NF_SAIDA,\n       IND_ABERTO,\n       DT_ENVIO_BCO,\n       SEQ_ENVIO_BCO,\n       BEG_FILIAL_ID,\n       BEG_CRC_RENEGOCIACAO_ID,\n       IMPRESSO,\n       BEG_COB_AVISO_ID,\n       BEG_FIN_PORTADOR_ID,\n       IND_LOTE_COB_ESCR,\n       BEG_PCE_LOTE_COBRANCA_ID,\n       LINHA_DIGITAVEL,\n       CODIGO_BARRAS,\n       BEG_PCE_COMANDO_REM_COB_ID,\n       BEG_PCE_INSTRUCAO_COBRANCA_ID,\n       BEG_VW_PCE_INSTR_COBR_ID,\n       COMISSAO,\n       BEG_VEN_PEDIDO_ID,\n       BEG_FAT_NFS_ID,\n       VLR_REAJUSTE,\n       VLR_SEGURO,\n       VLR_GARANTIA,\n       VLR_TX_FINANCEIRA,\n       SRDUP,\n       CLASSIF,\n       DT_AVISO_PGTO,\n       NUM_NF_DEVOL,\n       TIPO_DEVOL,\n       DATA_DEVOL,\n       beg_cob_aviso_pessoa_id,\n       beg_cobrador_id)\n    values\n      (:new.BEG_CRC_TITULO_ID,\n       :new.BEG_CRC_TITULO_ID,\n       :new.AD_CLIENT_ID,\n       :new.AD_ORG_ID,\n       :new.ISACTIVE,\n       :new.value,\n       :new.CREATED,\n       :new.CREATEDBY,\n       :new.UPDATED,\n       :new.UPDATEDBY,\n       :new.PARCELA,\n       :new.DT_EMISSAO,\n       :new.DT_VCTO,\n       :new.VLR_TITULO,\n       :new.VLR_MULTA,\n       :new.VLR_JUROS,\n       :new.VLR_DESCONTO,\n       :new.VLR_ABERTO,\n       :new.TP_COBRANCA,\n       :new.NUMERO_TITULO_BANCO,\n       :new.OBS,\n       :new.VLR_DESPESA,\n       :new.BEG_TIPO_TITULO_ID,\n       :new.BEG_PESSOA_ID,\n       :new.BEG_MOEDA_ID,\n       :new.BEG_CONVENIO_ID,\n       :new.BEG_BANCO_ID,\n       :new.SERIE,\n       :new.NUM_NF_SAIDA,\n       :new.IND_ABERTO,\n       :new.DT_ENVIO_BCO,\n       :new.SEQ_ENVIO_BCO,\n       :new.BEG_FILIAL_ID,\n       :new.BEG_CRC_RENEGOCIACAO_ID,\n       :new.IMPRESSO,\n       :new.BEG_COB_AVISO_ID,\n       :new.BEG_FIN_PORTADOR_ID,\n       :new.IND_LOTE_COB_ESCR,\n       :new.BEG_PCE_LOTE_COBRANCA_ID,\n       :new.LINHA_DIGITAVEL,\n       :new.CODIGO_BARRAS,\n       :new.BEG_PCE_COMANDO_REM_COB_ID,\n       :new.BEG_PCE_INSTRUCAO_COBRANCA_ID,\n       :new.BEG_VW_PCE_INSTR_COBR_ID,\n       :new.COMISSAO,\n       :new.BEG_VEN_PEDIDO_ID,\n       :new.BEG_FAT_NFS_ID,\n       :new.VLR_REAJUSTE,\n       :new.VLR_SEGURO,\n       :new.VLR_GARANTIA,\n       :new.VLR_TX_FINANCEIRA,\n       :new.SRDUP,\n       :new.CLASSIF,\n       :new.DT_AVISO_PGTO,\n       :new.NUM_NF_DEVOL,\n       :new.TIPO_DEVOL,\n       :new.DATA_DEVOL,\n       :new.beg_cob_aviso_pessoa_id,\n       :new.beg_cobrador_id);\n  end if;\n\n  if UPDATING and :new.IND_ABERTO = 'Y' then\n    if :old.IND_ABERTO = 'Y' then\n      update BEG_CRC_TITULO_ABERTO_ORG\n         set (BEG_CRC_TITULO_ABERTO_ORG_ID --\n            , BEG_CRC_TITULO_ID --\n            , AD_CLIENT_ID --\n            , AD_ORG_ID --\n            , ISACTIVE --\n            , value --\n            , CREATED --\n            , CREATEDBY --\n            , UPDATED --\n            , UPDATEDBY --\n            , PARCELA --\n            , DT_EMISSAO --\n            , DT_VCTO --\n            , VLR_TITULO --\n            , VLR_MULTA --\n            , VLR_JUROS --\n            , VLR_DESCONTO --\n            , VLR_ABERTO --\n            , TP_COBRANCA --\n            , NUMERO_TITULO_BANCO --\n            , OBS --\n            , VLR_DESPESA --\n            , BEG_TIPO_TITULO_ID --\n            , BEG_PESSOA_ID --\n            , BEG_MOEDA_ID --\n            , BEG_CONVENIO_ID --\n            , BEG_BANCO_ID --\n            , SERIE --\n            , NUM_NF_SAIDA --\n            , IND_ABERTO --\n            , DT_ENVIO_BCO --\n            , SEQ_ENVIO_BCO --\n            , BEG_FILIAL_ID --\n            , BEG_CRC_RENEGOCIACAO_ID --\n            , IMPRESSO --\n            , BEG_COB_AVISO_ID --\n            , BEG_FIN_PORTADOR_ID --\n            , IND_LOTE_COB_ESCR --\n            , BEG_PCE_LOTE_COBRANCA_ID --\n            , LINHA_DIGITAVEL --\n            , CODIGO_BARRAS --\n            , BEG_PCE_COMANDO_REM_COB_ID --\n            , BEG_PCE_INSTRUCAO_COBRANCA_ID --\n            , BEG_VW_PCE_INSTR_COBR_ID --\n            , COMISSAO --\n            , BEG_VEN_PEDIDO_ID --\n            , BEG_FAT_NFS_ID --\n            , VLR_REAJUSTE --\n            , VLR_SEGURO --\n            , VLR_GARANTIA --\n            , VLR_TX_FINANCEIRA --\n            , SRDUP --\n            , CLASSIF --\n            , DT_AVISO_PGTO --\n            , NUM_NF_DEVOL --\n            , TIPO_DEVOL --\n            , DATA_DEVOL -- \n            , beg_cob_aviso_pessoa_id --\n            , beg_cobrador_id) = (select :new.BEG_CRC_TITULO_ID,\n                                          :new.BEG_CRC_TITULO_ID,\n                                          :new.AD_CLIENT_ID,\n                                          :new.AD_ORG_ID,\n                                          :new.ISACTIVE,\n                                          :new.value,\n                                          :new.CREATED,\n                                          :new.CREATEDBY,\n                                          :new.UPDATED,\n                                          :new.UPDATEDBY,\n                                          :new.PARCELA,\n                                          :new.DT_EMISSAO,\n                                          :new.DT_VCTO,\n                                          :new.VLR_TITULO,\n                                          :new.VLR_MULTA,\n                                          :new.VLR_JUROS,\n                                          :new.VLR_DESCONTO,\n                                          :new.VLR_ABERTO,\n                                          :new.TP_COBRANCA,\n                                          :new.NUMERO_TITULO_BANCO,\n                                          :new.OBS,\n                                          :new.VLR_DESPESA,\n                                          :new.BEG_TIPO_TITULO_ID,\n                                          :new.BEG_PESSOA_ID,\n                                          :new.BEG_MOEDA_ID,\n                                          :new.BEG_CONVENIO_ID,\n                                          :new.BEG_BANCO_ID,\n                                          :new.SERIE,\n                                          :new.NUM_NF_SAIDA,\n                                          :new.IND_ABERTO,\n                                          :new.DT_ENVIO_BCO,\n                                          :new.SEQ_ENVIO_BCO,\n                                          :new.BEG_FILIAL_ID,\n                                          :new.BEG_CRC_RENEGOCIACAO_ID,\n                                          :new.IMPRESSO,\n                                          :new.BEG_COB_AVISO_ID,\n                                          :new.BEG_FIN_PORTADOR_ID,\n                                          :new.IND_LOTE_COB_ESCR,\n                                          :new.BEG_PCE_LOTE_COBRANCA_ID,\n                                          :new.LINHA_DIGITAVEL,\n                                          :new.CODIGO_BARRAS,\n                                          :new.BEG_PCE_COMANDO_REM_COB_ID,\n                                          :new.BEG_PCE_INSTRUCAO_COBRANCA_ID,\n                                          :new.BEG_VW_PCE_INSTR_COBR_ID,\n                                          :new.COMISSAO,\n                                          :new.BEG_VEN_PEDIDO_ID,\n                                          :new.BEG_FAT_NFS_ID,\n                                          :new.VLR_REAJUSTE,\n                                          :new.VLR_SEGURO,\n                                          :new.VLR_GARANTIA,\n                                          :new.VLR_TX_FINANCEIRA,\n                                          :new.SRDUP,\n                                          :new.CLASSIF,\n                                          :new.DT_AVISO_PGTO,\n                                          :new.NUM_NF_DEVOL,\n                                          :new.TIPO_DEVOL,\n                                          :new.DATA_DEVOL,\n                                          :new.beg_cob_aviso_pessoa_id,\n                                          :new.beg_cobrador_id\n                                     from DUAL)\n       where BEG_CRC_TITULO_ABERTO_ORG_ID = :new.BEG_CRC_TITULO_ID;\n    end if;\n    if :old.IND_ABERTO = 'N' then\n      update BEG_CRC_TITULO_ABERTO_ORG\n         set (BEG_CRC_TITULO_ABERTO_ORG_ID, --\n             BEG_CRC_TITULO_ID, --\n             AD_CLIENT_ID, --\n             AD_ORG_ID, --\n             ISACTIVE, --\n             value, --\n             CREATED, --\n             CREATEDBY, --\n             UPDATED, --\n             UPDATEDBY, --\n             PARCELA, --\n             DT_EMISSAO, --\n             DT_VCTO, --\n             VLR_TITULO, --\n             VLR_MULTA, --\n             VLR_JUROS, --\n             VLR_DESCONTO, --\n             VLR_ABERTO, --\n             TP_COBRANCA, --\n             NUMERO_TITULO_BANCO, --\n             OBS, --\n             VLR_DESPESA, --\n             BEG_TIPO_TITULO_ID, --\n             BEG_PESSOA_ID, --\n             BEG_MOEDA_ID, --\n             BEG_CONVENIO_ID, --\n             BEG_BANCO_ID, --\n             SERIE, --\n             NUM_NF_SAIDA, --\n             IND_ABERTO, --\n             DT_ENVIO_BCO, --\n             SEQ_ENVIO_BCO, --\n             BEG_FILIAL_ID, --\n             BEG_CRC_RENEGOCIACAO_ID, --\n             IMPRESSO, --\n             BEG_COB_AVISO_ID, --\n             BEG_FIN_PORTADOR_ID, --\n             IND_LOTE_COB_ESCR, --\n             BEG_PCE_LOTE_COBRANCA_ID, --\n             LINHA_DIGITAVEL, --\n             CODIGO_BARRAS, --\n             BEG_PCE_COMANDO_REM_COB_ID, --\n             BEG_PCE_INSTRUCAO_COBRANCA_ID, --\n             BEG_VW_PCE_INSTR_COBR_ID, --\n             COMISSAO, --\n             BEG_VEN_PEDIDO_ID, --\n             BEG_FAT_NFS_ID, --\n             VLR_REAJUSTE, --\n             VLR_SEGURO, --\n             VLR_GARANTIA, --\n             VLR_TX_FINANCEIRA, --\n             SRDUP, --\n             CLASSIF, --\n             DT_AVISO_PGTO, --\n             NUM_NF_DEVOL, --\n             TIPO_DEVOL, --\n             DATA_DEVOL, --\n             beg_cob_aviso_pessoa_id, --\n             beg_cobrador_id) = (select :new.BEG_CRC_TITULO_ID,\n                                        :new.BEG_CRC_TITULO_ID,\n                                        :new.AD_CLIENT_ID,\n                                        :new.AD_ORG_ID,\n                                        :new.ISACTIVE,\n                                        :new.value,\n                                        :new.CREATED,\n                                        :new.CREATEDBY,\n                                        :new.UPDATED,\n                                        :new.UPDATEDBY,\n                                        :new.PARCELA,\n                                        :new.DT_EMISSAO,\n                                        :new.DT_VCTO,\n                                        :new.VLR_TITULO,\n                                        :new.VLR_MULTA,\n                                        :new.VLR_JUROS,\n                                        :new.VLR_DESCONTO,\n                                        :new.VLR_ABERTO,\n                                        :new.TP_COBRANCA,\n                                        :new.NUMERO_TITULO_BANCO,\n                                        :new.OBS,\n                                        :new.VLR_DESPESA,\n                                        :new.BEG_TIPO_TITULO_ID,\n                                        :new.BEG_PESSOA_ID,\n                                        :new.BEG_MOEDA_ID,\n                                        :new.BEG_CONVENIO_ID,\n                                        :new.BEG_BANCO_ID,\n                                        :new.SERIE,\n                                        :new.NUM_NF_SAIDA,\n                                        :new.IND_ABERTO,\n                                        :new.DT_ENVIO_BCO,\n                                        :new.SEQ_ENVIO_BCO,\n                                        :new.BEG_FILIAL_ID,\n                                        :new.BEG_CRC_RENEGOCIACAO_ID,\n                                        :new.IMPRESSO,\n                                        :new.BEG_COB_AVISO_ID,\n                                        :new.BEG_FIN_PORTADOR_ID,\n                                        :new.IND_LOTE_COB_ESCR,\n                                        :new.BEG_PCE_LOTE_COBRANCA_ID,\n                                        :new.LINHA_DIGITAVEL,\n                                        :new.CODIGO_BARRAS,\n                                        :new.BEG_PCE_COMANDO_REM_COB_ID,\n                                        :new.BEG_PCE_INSTRUCAO_COBRANCA_ID,\n                                        :new.BEG_VW_PCE_INSTR_COBR_ID,\n                                        :new.COMISSAO,\n                                        :new.BEG_VEN_PEDIDO_ID,\n                                        :new.BEG_FAT_NFS_ID,\n                                        :new.VLR_REAJUSTE,\n                                        :new.VLR_SEGURO,\n                                        :new.VLR_GARANTIA,\n                                        :new.VLR_TX_FINANCEIRA,\n                                        :new.SRDUP,\n                                        :new.CLASSIF,\n                                        :new.DT_AVISO_PGTO,\n                                        :new.NUM_NF_DEVOL,\n                                        :new.TIPO_DEVOL,\n                                        :new.DATA_DEVOL,\n                                        :new.beg_cob_aviso_pessoa_id,\n                                        :new.beg_cobrador_id\n                                   from DUAL)\n       where BEG_CRC_TITULO_ABERTO_ORG_ID = :new.BEG_CRC_TITULO_ID;\n    end if;\n    if :old.IND_ABERTO = 'N' then\n      insert into BEG_CRC_TITULO_ABERTO_ORG\n        (BEG_CRC_TITULO_ABERTO_ORG_ID,\n         BEG_CRC_TITULO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         value,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         PARCELA,\n         DT_EMISSAO,\n         DT_VCTO,\n         VLR_TITULO,\n         VLR_MULTA,\n         VLR_JUROS,\n         VLR_DESCONTO,\n         VLR_ABERTO,\n         TP_COBRANCA,\n         NUMERO_TITULO_BANCO,\n         OBS,\n         VLR_DESPESA,\n         BEG_TIPO_TITULO_ID,\n         BEG_PESSOA_ID,\n         BEG_MOEDA_ID,\n         BEG_CONVENIO_ID,\n         BEG_BANCO_ID,\n         SERIE,\n         NUM_NF_SAIDA,\n         IND_ABERTO,\n         DT_ENVIO_BCO,\n         SEQ_ENVIO_BCO,\n         BEG_FILIAL_ID,\n         BEG_CRC_RENEGOCIACAO_ID,\n         IMPRESSO,\n         BEG_COB_AVISO_ID,\n         BEG_FIN_PORTADOR_ID,\n         IND_LOTE_COB_ESCR,\n         BEG_PCE_LOTE_COBRANCA_ID,\n         LINHA_DIGITAVEL,\n         CODIGO_BARRAS,\n         BEG_PCE_COMANDO_REM_COB_ID,\n         BEG_PCE_INSTRUCAO_COBRANCA_ID,\n         BEG_VW_PCE_INSTR_COBR_ID,\n         COMISSAO,\n         BEG_VEN_PEDIDO_ID,\n         BEG_FAT_NFS_ID,\n         VLR_REAJUSTE,\n         VLR_SEGURO,\n         VLR_GARANTIA,\n         VLR_TX_FINANCEIRA,\n         SRDUP,\n         CLASSIF,\n         DT_AVISO_PGTO,\n         NUM_NF_DEVOL,\n         TIPO_DEVOL,\n         DATA_DEVOL,\n         beg_cob_aviso_pessoa_id,\n         beg_cobrador_id)\n      values\n        (:new.BEG_CRC_TITULO_ID,\n         :new.BEG_CRC_TITULO_ID,\n         :new.AD_CLIENT_ID,\n         :new.AD_ORG_ID,\n         :new.ISACTIVE,\n         :new.value,\n         :new.CREATED,\n         :new.CREATEDBY,\n         :new.UPDATED,\n         :new.UPDATEDBY,\n         :new.PARCELA,\n         :new.DT_EMISSAO,\n         :new.DT_VCTO,\n         :new.VLR_TITULO,\n         :new.VLR_MULTA,\n         :new.VLR_JUROS,\n         :new.VLR_DESCONTO,\n         :new.VLR_ABERTO,\n         :new.TP_COBRANCA,\n         :new.NUMERO_TITULO_BANCO,\n         :new.OBS,\n         :new.VLR_DESPESA,\n         :new.BEG_TIPO_TITULO_ID,\n         :new.BEG_PESSOA_ID,\n         :new.BEG_MOEDA_ID,\n         :new.BEG_CONVENIO_ID,\n         :new.BEG_BANCO_ID,\n         :new.SERIE,\n         :new.NUM_NF_SAIDA,\n         :new.IND_ABERTO,\n         :new.DT_ENVIO_BCO,\n         :new.SEQ_ENVIO_BCO,\n         :new.BEG_FILIAL_ID,\n         :new.BEG_CRC_RENEGOCIACAO_ID,\n         :new.IMPRESSO,\n         :new.BEG_COB_AVISO_ID,\n         :new.BEG_FIN_PORTADOR_ID,\n         :new.IND_LOTE_COB_ESCR,\n         :new.BEG_PCE_LOTE_COBRANCA_ID,\n         :new.LINHA_DIGITAVEL,\n         :new.CODIGO_BARRAS,\n         :new.BEG_PCE_COMANDO_REM_COB_ID,\n         :new.BEG_PCE_INSTRUCAO_COBRANCA_ID,\n         :new.BEG_VW_PCE_INSTR_COBR_ID,\n         :new.COMISSAO,\n         :new.BEG_VEN_PEDIDO_ID,\n         :new.BEG_FAT_NFS_ID,\n         :new.VLR_REAJUSTE,\n         :new.VLR_SEGURO,\n         :new.VLR_GARANTIA,\n         :new.VLR_TX_FINANCEIRA,\n         :new.SRDUP,\n         :new.CLASSIF,\n         :new.DT_AVISO_PGTO,\n         :new.NUM_NF_DEVOL,\n         :new.TIPO_DEVOL,\n         :new.DATA_DEVOL,\n         :new.beg_cob_aviso_pessoa_id,\n         :new.beg_cobrador_id);\n    end if;\n  end if;\n\n  if UPDATING and :new.IND_ABERTO = 'N' then\n    delete from BEG_CRC_TITULO_ABERTO_ORG\n     where BEG_CRC_TITULO_ABERTO_ORG_ID = :old.BEG_CRC_TITULO_ID;\n  \n  end if;\n\n  if DELETING then\n    delete from BEG_CRC_TITULO_ABERTO_ORG\n     where BEG_CRC_TITULO_ABERTO_ORG_ID = :old.BEG_CRC_TITULO_ID;\n  end if;\n\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_AI_CRC_TITULOS { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n\n  IF NVL(:NEW.IND_NEW_PDV, 'N') = 'N' THEN\n    insert into BEG_CRC_HISTORICO\n      (BEG_CRC_HISTORICO_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       value,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       VLR_MOVTO,\n       VLR_JUROS,\n       VLR_MULTA,\n       VLR_DESCONTO,\n       RECIBO_PAGTO,\n       BEG_CRC_TPMOV_ID,\n       BEG_CRC_TITULO_ID)\n    values\n      (BEG_FNC_AD_SEQUENCE('BEG_CRC_HISTORICO'),\n       :new.AD_CLIENT_ID,\n       :new.AD_ORG_ID,\n       :new.ISACTIVE,\n       1,\n       :new.CREATED, --sysdate, -- AOK -- 24/09/2007\n       :new.CREATEDBY,\n       :new.UPDATED, --sysdate, -- AOK -- 24/09/2007\n       :new.UPDATEDBY,\n       :new.VLR_TITULO,\n       0,\n       0,\n       0,\n       null,\n       1000001,\n       :new.BEG_CRC_TITULO_ID);\n  END IF;\n\n  --\n  -- AOK - 15/03/2007 - processo desabilitado\n  -- AOK - 24/09/2007 - Processo Reabilitado\n  update BEG_FIN_INF_PESSOA F\n     set F.TOT_CRC_ABERTO = F.TOT_CRC_ABERTO + :new.VLR_TITULO,\n         F.VLR_CRC_TOTAL  = F.VLR_CRC_TOTAL + :new.VLR_TITULO\n   where F.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  --\n  if sql%notfound then\n    insert into BEG_FIN_INF_PESSOA\n      (BEG_FIN_INF_PESSOA_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       BEG_PESSOA_ID,\n       LIMITE_CREDITO,\n       CREDIT_SCORE,\n       TOT_CRC_ABERTO,\n       TOT_CRC_VENCIDO,\n       MEDIA_ATRASO_CRC,\n       TOT_CPG_ABERTO,\n       TOT_CPG_VENCIDO,\n       QTD_ANO,\n       VLR_CRC_TOTAL)\n    values\n      (BEG_FNC_AD_SEQUENCE('BEG_FIN_INF_PESSOA'),\n       :new.AD_CLIENT_ID,\n       0, --:new.AD_ORG_ID,\n       :new.ISACTIVE,\n       :new.CREATED,\n       :new.CREATEDBY,\n       :new.UPDATED,\n       :new.UPDATEDBY,\n       :new.BEG_PESSOA_ID,\n       0, -- limite_credito\n       0, -- credit_score\n       :new.VLR_TITULO, -- TOT_CRC_ABERTO\n       0, -- tot_crc_vencido\n       0, -- media_atraso_crc\n       0, -- tot_cpg_aberto\n       0, -- tot_cpg_vencido\n       0, -- qtd_ano\n       :new.VLR_TITULO); -- vlr_crc_total\n  end if;\n\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIUR_CRC_TITULO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  cursor C_BEG_VEN_PEDIDO is\n    select BEG_VW_VEN_PEDIDO_ID\n      from BEG_VEN_PEDIDO A\n     where A.BEG_VEN_PEDIDO_ID = :new.BEG_VEN_PEDIDO_ID\n       and A.COMPLEMENTAR = 'Y';\n  V_BEG_VEN_PEDIDO_ID BEG_VEN_PEDIDO.BEG_VEN_PEDIDO_ID%type;\n\n  -- AOK - 29/09/2008 - Verifica avisos não impressos\n  cursor CAVISO(PBEG_COB_AVISO_PESSOA_ID number) is\n    select *\n      from BEG_COB_AVISO_PESSOA AP\n     where AP.BEG_COB_AVISO_PESSOA_ID = PBEG_COB_AVISO_PESSOA_ID\n       and AP.IND_ENVIAR = 'Y'\n       and AP.IND_IMPRESSO = 'N';\n  RAVISO CAVISO%rowtype;\n\n  -- AOK -- 23/05/2008\n  /*  cursor CPARAM is\n      select *\n        from BEG_COB_PARAMETRO PA\n       where PA.AD_CLIENT_ID = :new.AD_CLIENT_ID\n         and PA.AD_ORG_ID = 0;\n    RPARAM CPARAM%rowtype;\n  */\n  --\n  cursor C_SPC IS\n    select *\n      from BEG_COB_TITULO_SPC S\n     WHERE S.DT_BAIXA_SPC IS NULL\n       AND S.IND_ABERTO = 'Y'\n       AND S.BEG_CRC_TITULO_ID = :NEW.BEG_CRC_TITULO_ID\n       AND S.IND_ENVIAR_SPC = 'Y';\n\n  R_SPC C_SPC%ROWTYPE;\n\nbegin\n  ---- VERIFICAR SE CLIENTE EM SPC QUANDO ALTERAR DATA VENCIMENTO\n  \n  IF UPDATING AND :NEW.DT_VCTO<>:OLD.DT_VCTO THEN\n    OPEN C_SPC;\n    FETCH C_SPC\n    INTO R_SPC;\n    CLOSE C_SPC;\n    IF R_SPC.BEG_COB_TITULO_SPC_ID IS NOT NULL THEN \n       RAISE_APPLICATION_ERROR(-20001,\n                                'Cliente com registro de  SPC nesta parcela do contrato. Revisar registro antes de alterar!');\n    END IF;\n    \n  \n  END IF;  \n\n\n\n  --Acertando pedido pai no titulo\n  if INSERTING then\n    open C_BEG_VEN_PEDIDO;\n    fetch C_BEG_VEN_PEDIDO\n      into V_BEG_VEN_PEDIDO_ID;\n  \n    if C_BEG_VEN_PEDIDO%found then\n      :new.BEG_VEN_PEDIDO_ID := V_BEG_VEN_PEDIDO_ID;\n    end if;\n  \n    close C_BEG_VEN_PEDIDO;\n  \n  end if;\n  --\n  if INSERTING then\n    :new.VLR_ABERTO := :new.VLR_TITULO;\n    /*    if :new.BEG_VEN_PEDIDO_ID is not null then\n      --Gerando comissoes de previs?o do titulo\n      BEG_PCK_VEN_COMISSOES.PRC_GERA_COMISSAO_TITULO(P_AD_CLIENT_ID      => :new.AD_CLIENT_ID,\n                                                     P_AD_ORG_ID         => :new.AD_ORG_ID,\n                                                     P_CREATED           => :new.CREATED,\n                                                     P_CREATEDBY         => :new.CREATEDBY,\n                                                     P_BEG_CRC_TITULO_ID => :new.BEG_CRC_TITULO_ID,\n                                                     P_BEG_VEN_PEDIDO_ID => :new.BEG_VEN_PEDIDO_ID,\n                                                     P_COMISSAO          => :new.COMISSAO);\n    end if;*/\n  end if;\n  if :new.VLR_ABERTO = 0 then\n    :new.IND_ABERTO := 'N'; -- TITULO_ABERTO := 0;\n    -- Neste momento verificar se existe titulo no spc e alterar o ind_aberto\n    -- AOK - 04/10/2007\n    update BEG_COB_TITULO_SPC TS\n       set TS.IND_ABERTO     = 'N',\n           TS.IND_ENVIAR_SPC = 'Y',\n           ts.dt_envio_spc = case\n                               when TS.DT_ENVIO_SPC is null then\n                                trunc(ts.created)\n                               else\n                                ts.dt_envio_spc\n                             end,\n           ts.ind_rejeitado  = 'N'\n     where TS.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID;\n    --\n    update BEG_COB_CARTORIO C\n       set C.IND_ABERTO = 'N', C.DOCSTATUS = 'FB' -- Pago / baixar - AOK - 29/05/2008\n    -- c.docstatus  = 'PA' -- Pago / baixar - AOK - 11/08/2008\n     where C.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID;\n  \n    -- AOK -- 29/09/2008 - Verificar avisos a enviar e não impressos\n    if NVL(:new.BEG_COB_AVISO_PESSOA_ID, 0) > 0 then\n      open CAVISO(:new.BEG_COB_AVISO_PESSOA_ID);\n      fetch CAVISO\n        into RAVISO;\n      if CAVISO%found then\n        if replace(RAVISO.CONTRATOS, ',') = :new.value then\n          update BEG_COB_AVISO_PESSOA AP\n             set AP.IND_ENVIAR = 'N',\n                 AP.OBS        = AP.OBS ||\n                                 ' MSG Automática - Parcela de um ou mais contrato foi quitada!'\n           where AP.BEG_COB_AVISO_PESSOA_ID = :new.BEG_COB_AVISO_PESSOA_ID;\n        else\n          update BEG_COB_AVISO_PESSOA AP\n             set AP.CONTRATOS = replace(replace(AP.CONTRATOS, :new.value),\n                                        ',,',\n                                        ',')\n           where AP.BEG_COB_AVISO_PESSOA_ID = :new.BEG_COB_AVISO_PESSOA_ID;\n        end if;\n      end if;\n      close CAVISO;\n    end if;\n    --\n  else\n    :new.IND_ABERTO := 'Y'; --TITULO_ABERTO := 1;\n    -- AOK - 28/01/2009 - Inserido teste de updating + :old.vlr_aberto = 0\n    if UPDATING then\n      if :old.VLR_ABERTO = 0 then\n        -- AOK -- 01/07/2008  - Titulo pode ter sido reaberto - Estorno ....\n        update BEG_COB_TITULO_SPC TS\n           set TS.IND_ABERTO     = 'Y',\n               TS.IND_ENVIAR_SPC = case\n                                     when TS.DT_ENVIO_SPC is null then\n                                      'Y'\n                                     else\n                                      TS.IND_ENVIAR_SPC\n                                   end,\n               TS.OBS            = case\n                                     when TS.OBS is null then\n                                      'Titulo reaberto'\n                                     else\n                                      TS.OBS || ' -' || 'Titulo reaberto'\n                                   end,\n               TS.UPDATED        = sysdate,\n               TS.UPDATEDBY      = 0\n         where TS.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID\n           and TS.DT_BAIXA_SPC is null\n           and TS.IND_ABERTO = 'N';\n        --\n        update BEG_COB_CARTORIO C\n           set C.IND_ABERTO = 'Y',\n               C.UPDATED    = sysdate,\n               C.UPDATEDBY  = 0,\n               C.DOCSTATUS  = 'EC',\n               C.OBSERVACAO = case\n                                when C.OBSERVACAO is null then\n                                 'Titulo reaberto'\n                                else\n                                 C.OBSERVACAO || ' -' || 'Titulo reaberto'\n                              end -- AOK -- 29/05/2008\n         where C.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID\n           and C.DT_SAI_CARTORIO is null\n           and C.DOCSTATUS = 'FB' -- Baixar\n           and C.IND_ABERTO = 'N';\n        --\n      elsif UPDATING('NUM_NF_DEVOL') then\n        -- Registro no SPC - Devolucao mercadoria -- aok - 29/01/2009\n        BEG_PCK_COB_SPC.VC_EXECUTA_TRIGGER := 'N';\n        update BEG_COB_TITULO_SPC TS\n           set TS.IND_BAIXA_MANUAL = case\n                                       when NVL(:new.NUM_NF_DEVOL, 0) > 0 then\n                                        'Y'\n                                       else\n                                        'N'\n                                     end,\n               TS.OBS = case\n                          when NVL(:new.NUM_NF_DEVOL, 0) > 0 then\n                           'Forcado baixa devido a devolucao da mercadoria' --\n                          else\n                           replace(TS.OBS,\n                                   'Forcado baixa devido a devolucao da mercadoria')\n                        end,\n               TS.IND_DEVOLVIDO = case\n                                    when NVL(:new.NUM_NF_DEVOL, 0) > 0 then\n                                     'Y'\n                                    else\n                                     'N'\n                                  end,\n               TS.UPDATED          = sysdate,\n               TS.UPDATEDBY        = 0,\n               ts.ind_rejeitado    = 'N',\n               ts.dt_envio_spc     = case\n                                      when TS.DT_ENVIO_SPC is null then\n                                         trunc(ts.created)\n                                      else\n                                         ts.dt_envio_spc\n                                      end\n         where TS.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID\n              --  and TS.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n          -- and TS.DT_ENVIO_SPC is not null\n           and TS.DT_BAIXA_SPC is null;\n        BEG_PCK_COB_SPC.VC_EXECUTA_TRIGGER := 'Y';\n      \n        -- Registro no cartorio - Devolucao mercadoria -- aok - 29/01/2009\n        update BEG_COB_CARTORIO C\n           set C.UPDATED       = sysdate,\n               C.UPDATEDBY     = 0,\n               C.IND_DEVOLVIDO = case\n                                   when NVL(:new.NUM_NF_DEVOL, 0) > 0 then\n                                    'Y'\n                                   else\n                                    'N'\n                                 end,\n               C.OBSERVACAO = case\n                                when NVL(:new.NUM_NF_DEVOL, 0) > 0 then\n                                 'Baixar devido a devolucao da mercadoria' --\n                                else\n                                 replace(C.OBSERVACAO,\n                                         'Baixar devido a devolucao da mercadoria')\n                              end\n         where C.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID\n           and C.DT_SAI_CARTORIO is null\n           and C.DOCSTATUS in ('EC', 'FB')\n           and C.IND_ABERTO = 'Y';\n      end if;\n    end if;\n  end if;\n\n  -- 21/05/2008 - AOK\n  if UPDATING then\n    if :new.DT_AVISO_PGTO is not null then\n      if :new.DT_AVISO_PGTO < :new.DT_VCTO and :new.IND_ABERTO = 'Y' then\n        -- AOK - 15/07/2008\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Data aviso inferior a data vencimento!');\n        --   if :old.dt_aviso_pgto is null then\n        --     :new.dt_aviso_pgto := null;\n        --   else\n        --     :new.dt_aviso_pgto := :old.dt_aviso_pgto;\n        --   end if;\n      end if;\n    end if;\n  end if;\n  -- AOK -- 27/08/2007\n  if UPDATING and :new.IND_ABERTO = 'N' then\n    update BEG_COB_CONTATO W\n       set W.BEG_COB_SIT_CONTATO_ID = BEG_FNC_RETORNA_PARAM_GERAL('Cobranca',\n                                                                  null,\n                                                                  'CONTATO_SUCESSO'),\n           W.DOCSTATUS              = 'CO',\n           W.OBSERVACAO             = 'Msg auto.- Titulo(s) do contato foi(ram) baixado(s)'\n     where W.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n       and W.DOCSTATUS = 'IP';\n  end if;\n\n  -- aok -- 08/07/2008\n  if UPDATING then\n    if :new.DT_AVISO_PGTO <> :old.DT_AVISO_PGTO or\n       :new.VLR_ABERTO <> :old.VLR_ABERTO or\n       :new.beg_cobrador_id <> :old.beg_cobrador_id then\n      -- AOK - 16/06/2009\n      update BEG_COB_TITULO_TMP TMP\n         set TMP.DT_AVISO_PGTO   = :new.DT_AVISO_PGTO,\n             TMP.VLR_ABERTO      = :new.VLR_ABERTO, -- AOK -- 16/06/2009\n             tmp.beg_cobrador_id = :new.beg_cobrador_id -- AOK - 16/06/2009\n       where TMP.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID;\n    end if;\n  end if;\n\n  -- AOK - 01/10/2008 - indicar quando o titulo foi enviado alguma vez para cobrador\n  if :new.BEG_COBRADOR_ID is not null and :new.IND_COBRADOR = 'N' then\n    :new.IND_COBRADOR := 'Y';\n  end if;\n\n  -- AOK -- 31/10/2008 \n\n  if :new.DT_VCTO < :new.DT_EMISSAO then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Data de vencimento não pode ser inferior a data de emissão!');\n  end if;\n  if UPDATING('dt_vcto') then\n    if NVL(:new.BEG_COB_AVISO_ID, 0) > 0 and :new.UPDATEDBY <> 1000000 -- BegAdmin -- AOK - 10/11/2008\n     then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Já gerou avisos para este vencimento! ' ||\n                              :new.UPDATEDBY);\n    end if;\n  end if;\n\nend TRG_BIUR_CRC_TITULO;\n"}`;
    
    }
}
