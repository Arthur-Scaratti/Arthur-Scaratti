
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPR_PRE_NFE
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ISSQN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ISSQN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FRETE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_FRETE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string PLACA_VEICULO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FRETE_RDP { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_FRETE_RDP { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string PLACA_VEICULO_RDP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTD_VOLUMES { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DES_VOLUMES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_VOLUMES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PESO_BRUTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PESO_LIQUIDO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGURO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESPESAS_FINANCEIRAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PER_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PER_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_PRODUTOS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_PRODUTOS_CALC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_NOTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_NOTA_CALC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_FATURADO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COTACAO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_FATURA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_PARCELAS { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DIAS_VENCIMENTO { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// WC - Pendente, CO - Completo, CA - Cancelado pelo Emitente
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_TITULO_CPG { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_AUT_PGTO_CPG { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ESPECIAL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_FRETE_NOTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_NFE_ORDEM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NRO_VIA_IMPRESSA { get; set; }
            [StringLength(2000)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS_OUTRAS_DESPESAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CFOP_ENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CFOP_SAI_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TRANSPORTADORA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_UNIDADE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_REDESPACHO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_UF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_UF_RDP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CPR_CND_PGTO_NFE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_DESCONTO_NOTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ACRESCIMO_NOTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_DESCONTO_BASE_ICMS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ACRESCIMO_BASE_ICMS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_DESCONTO_BASE_IPI { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ACRESCIMO_BASE_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CST_CALCULO_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXCLUI_TODOS_ITENS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXCLUI_ITENS_INATIVOS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_BAIXA_ESTOQUE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CANCELA_ORDEM { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CANCELA_SALDO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CANCELA_TITULO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CANCELA_AUT_PGTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string BTN_CANCELA_NFE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_NFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TP_TRANSP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TP_TRANSP_RDP { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE_NFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_COD_MODELO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_GNRE_ID { get; set; }
            [StringLength(2000)]
        /// <summary>
        /// 
        /// </summary>
        public string MSG_INF_FISCAL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TP_LANCTO_CONTABIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_EMITIDA_FATURAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_PRE_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_DESP_ACES_IMP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_IMPOSTO_IMPORTACAO { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL_DESEMBARACO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NF_PRODUTOR_RURAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SERIE_PRODUTOR_RURAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_PRODUTOR_RURAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIS_COD_MODELO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FUNRURAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_GERADA_XML { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_ORDEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_ICMS_TOTAL_NOTA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// INDICA SE A NOTA FOI INTEGRADA NA ENTRADA ( Y )
        /// </summary>
        public string IND_GERA_NFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFE_XML_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_PRE_NFE_ID { get; set; }
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
        public int NUMERO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTRADA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS_CALC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS_SUBST_CALC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ISENTO_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ICMS_CALC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ICMS_SUBST_CALC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_IPI_CALC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_OUTROS_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ISENTO_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IPI_CALC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTROS_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_IR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_IR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_INSS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_INSS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_INSS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_ISSQN { get; set; }

        [NotMapped]
        public string Trigger_TRG_BUID_BEG_CPR_PRE_NFE { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n\nCURSOR C_CFOP IS\n    SELECT *\n      FROM BEG_CFOP_ENT_SAI c\n    WHERE c.beg_vw_cfop_ent_id = :NEW.BEG_VW_CFOP_ENT_ID\n      AND C.BEG_VW_CFOP_SAI_ID = :NEW.BEG_VW_CFOP_SAI_ID;\n    R_CFOP C_CFOP%ROWTYPE;\n\nBEGIN\n\n      open C_CFOP;\n    fetch C_CFOP\n      into R_CFOP;\n    CLOSE C_CFOP;\n\n   :NEW.BEG_EST_TP_ESPECIE_ID := R_CFOP.BEG_EST_TP_ESPECIE_ID;\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_ACC_TRG_BIUD_CPR_PRE_NFE { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  cursor c_conta_new is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :NEW.BEG_CPG_CONTA_ID;\n   r_conta_new c_conta_new%rowtype;\n\n   cursor c_conta_old is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :OLD.BEG_CPG_CONTA_ID;\n   r_conta_old c_conta_old%rowtype;\n\nBEGIN\n\n  if inserting and :NEW.BEG_CPG_CONTA_ID IS NOT NULL THEN\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_new.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a inclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if deleting  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    if r_conta_old.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if updating and :NEW.BEG_CPG_CONTA_ID <> :OLD.BEG_CPG_CONTA_ID  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_old.ind_rj ='Y' and r_conta_new.ind_rj ='N' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n\n\nEND ACC_TRG_BIUD_CPR_PRE_NFE;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_CPR_PRE_NFE { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  --\n  VC_MSG_ERRO    varchar2(200);\n  VN_AUX_ALQ     number(18, 4);\n  VN_AUX_BASE    number(18, 4);\n  VN_AUX_CALC    number(18, 4);\n  VN_VLR_RATEADO number(18, 4);\n  VN_DUMMY       number;\n  V_PADRAO       varchar2(1);\n  VN_TESTE2       number(18, 4);\n  --v_vlr_pedagio              number(18,2);\n  VN_BEG_EST_ALMOXARIFADO_ID BEG_EST_ALMOXARIFADO.BEG_EST_ALMOXARIFADO_ID%type;\n  --\n  cursor CFOP is\n    select NVL(:NEW.BEG_VW_CFOP_SAI_ID, BEG_VW_CFOP_SAI_ID),\n           NVL(:NEW.BEG_VW_CFOP_ENT_ID, BEG_VW_CFOP_ENT_ID),\n           IND_PADRAO\n      from BEG_CFOP_ENT_SAI\n     where BEG_VW_CFOP_ENT_ID =\n           NVL(:NEW.BEG_VW_CFOP_ENT_ID, BEG_VW_CFOP_ENT_ID)\n       and BEG_VW_CFOP_SAI_ID =\n           NVL(:NEW.BEG_VW_CFOP_SAI_ID, BEG_VW_CFOP_SAI_ID)\n       and ISACTIVE = 'Y'\n     order by 3 desc; -- AOK - 02/11/2010\n  --  v_cfop cfop%rowtype;\n\n  -- aok - 07/04/2011\n /* cursor CGNRE is\n    select *\n      from BEG_FIS_GNRE G\n     where G.AD_CLIENT_ID = :NEW.AD_CLIENT_ID\n       and G.AD_ORG_ID = :NEW.AD_ORG_ID\n       and TRUNC(G.DT_EMISSAO) = TRUNC(:NEW.DT_EMISSAO)\n       and G.BEG_VW_FORNECEDOR_ID = :NEW.BEG_VW_FORNECEDOR_ID\n       and G.NRO_DOC_ORIGEM = :NEW.NUMERO\n       and NVL(G.SERIE_DOC_ORIGEM, '^') = NVL(:NEW.SERIE, '^');\n\n  RGNRE CGNRE%rowtype;*/\n\n  -- aok - 18/04/2011\n  --cursor CTIPO_NF is\n  --  select T.*,\n  --         SUBSTR(T.VALUE, 1, 3) DESC_RESUMIDA\n  --    from BEG_TIPO_NF T\n  --   where T.BEG_TIPO_NF_ID = :NEW.BEG_TIPO_NF_ID;\n  --RTIPO_NF CTIPO_NF%rowtype;\n\n  -- AOK - 29/05/2011 - valida se codigo modelo documento fiscal obriga chave de acesso\n  cursor CMODNF is\n    select *\n      from BEG_FIS_COD_MODELO CM\n     where CM.BEG_FIS_COD_MODELO_ID = :NEW.BEG_FIS_COD_MODELO_ID;\n  RMODNF CMODNF%rowtype;\n  -- aok - 11/07/2011\n  --cursor CCHV is\n  --  select 1\n  --    from BEG_CPR_NFE_FISCAL X\n  --   where X.CHAVE_NFE = :NEW.CHAVE_NFE\n  --     and X.BEG_CPR_NFE_FISCAL_ID <> :NEW.BEG_CPR_NFE_ID;\n  --\n  cursor BUSCA_CHAVE is\n    select C.BEG_FAT_CTE_XML_ID\n      from BEG_FAT_CTE_XML C\n     where C.CHAVE_ACESSO = :NEW.CHAVE_NFE;\n  --\n  V_CHAVE BUSCA_CHAVE%rowtype;\n  -- Ira -----------------------------------------------------------------------\n  cursor BUSCA_CHAVE_NFE is\n    select C.BEG_FAT_NFE_XML_ID\n      from BEG_FAT_NFE_XML C\n     where C.CHAVE_ACESSO = :NEW.CHAVE_NFE\n       and C.BEG_FAT_NFS_ID is null; -- aok - 03/06/2013\n  V_CHAVE_NFE BUSCA_CHAVE_NFE%rowtype;\n  ------------------------------------------------------------------------------\n  cursor CBUSCA_DADOS_CTE is\n        select EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/ide/nCT',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') NUMERO,\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/ide/serie',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') SERIE,\n               TO_DATE(SUBSTR(EXTRACTVALUE(X.ARQUIVO_XML,\n                                           '/cteProc/CTe/infCte/ide/dhEmi',\n                                           'xmlns=\"http://www.portalfiscal.inf.br/cte\"'),\n                              1,\n                              10),\n                       'rrrr-mm-dd') DT_EMISSAO,\n               F.BEG_VW_FORNECEDOR_ID,\n               /*           EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/emit/CNPJ',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CNPJ_EMITENTE,\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/rem/CNPJ',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CNPJ_REMETENTE,\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/dest/CNPJ',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CNPJ_DESTINATARIO, -- aok - 19/12/2013\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/receb/CNPJ',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CNPJ_RECEBEDOR, -- aok - 18/12/2013\n               */ -- DF.AD_ORG_ID, -- aok - 19/12/2013\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/ide/CFOP',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CFOP,\n               C.BEG_CFOP_ID,\n               ES.BEG_VW_CFOP_ENT_ID,\n               CES.BEG_FIS_CST_IPI_ID,\n               CES.BEG_FIS_CST_PIS_ID,\n               CES.BEG_FIS_CST_COFINS_ID,\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/ide/mod',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') MODELO,\n               M.BEG_FIS_COD_MODELO_ID,\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/protCTe/infProt/chCTe',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CHAVE,\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/vPrest/vTPrest',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') VLR_TOTAL,\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/imp/ICMS/ICMS00/CST',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CST_ICMS,\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/imp/ICMS/ICMS00/vBC',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') BASE_ICMS,\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/imp/ICMS/ICMS00/pICMS',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') ALIQ_ICMS,\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/compl/xObs',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') OBS,\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/imp/ICMS/ICMS00/vICMS',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"') VLR_ICMS\n          from BEG_FAT_CTE_XML   X,\n               BEG_VW_FORNECEDOR F,\n               -- BEG_DADO_FILIAL    DF,  -- aok - 19/12/2013\n               -- BEG_PESSOA         P,   -- aok - 19/12/2013\n               BEG_CFOP           C,\n               BEG_CFOP_ENT_SAI   ES,\n               BEG_CFOP           CES,\n               BEG_FIS_COD_MODELO M\n         where X.BEG_FAT_CTE_XML_ID = V_CHAVE.BEG_FAT_CTE_XML_ID\n           and F.CPFCNPJ =\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/emit/CNPJ',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n              /*-- AOK _ 19/12/2013 ----------------------------------------------------\n              and P.CPFCNPJ =\n                  EXTRACTVALUE(X.ARQUIVO_XML,\n                               '/cteProc/CTe/infCte/rem/CNPJ',\n                               'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n              and DF.BEG_PESSOA_ID = P.BEG_PESSOA_ID\n              and DF.AD_CLIENT_ID = 1000000\n              -----------------------------------------------------------------------*/\n           and C.CFOP =\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/ide/CFOP',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n           and CES.BEG_CFOP_ID = ES.BEG_VW_CFOP_ENT_ID\n           and ES.BEG_VW_CFOP_SAI_ID(+) = C.BEG_CFOP_ID\n           and ES.ISACTIVE(+) = 'Y' -- aok - 19/12/2013\n           and M.VALUE =\n               EXTRACTVALUE(X.ARQUIVO_XML,\n                            '/cteProc/CTe/infCte/ide/mod',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"');\n\n  V_DADO_CTE CBUSCA_DADOS_CTE%rowtype;\n  -- Ira Ubirajara -------------------------------------------------------------\n  cursor BUSCA_DADOS_NFE is\n    select EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/ide/nNF',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') NUMERO,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/ide/serie',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') SERIE,\n           nvl(TO_DATE(SUBSTR(EXTRACTVALUE(X.ARQUIVO_XML,\n                                       '/nfeProc/NFe/infNFe/ide/dEmi',\n                                       'xmlns=\"http://www.portalfiscal.inf.br/nfe\"'),\n                          1,\n                          10),\n                   'rrrr-mm-dd'),TO_DATE(SUBSTR(EXTRACTVALUE(X.ARQUIVO_XML,\n                                       '/nfeProc/NFe/infNFe/ide/dhEmi',\n                                       'xmlns=\"http://www.portalfiscal.inf.br/nfe\"'),\n                          1,\n                          10),\n                   'rrrr-mm-dd'))  DT_EMISSAO,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/emit/CNPJ',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') CNPJ_EMITENTE,\n           F.BEG_PESSOA_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/dest/CNPJ',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') CNPJ_DESTINATARIO,\n           DF.AD_ORG_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/ide/CFOP',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') CFOP,\n           C.BEG_CFOP_ID,\n           ES.BEG_VW_CFOP_ENT_ID,\n           CES.BEG_FIS_CST_IPI_ID,\n           CES.BEG_FIS_CST_PIS_ID,\n           CES.BEG_FIS_CST_COFINS_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/ide/mod',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') MODELO,\n           M.BEG_FIS_COD_MODELO_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/protNFe/infProt/chNFe',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') CHAVE,\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vNF',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') VLR_TOTAL, --,'.',','), 0)\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vProd',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') VLR_PROD, --,'.',','), 0)\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vFrete',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') VLR_FRETE, --,'.',','), 0)\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vSeg',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') VLR_SEG, --,'.',','), 0)\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vDesc',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') VLR_DESC, --,'.',','), 0)\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vII',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') VLR_II, --,'.',','), 0)\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vIPI',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') VLR_IPI, --,'.',','), 0)\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vPIS',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') VLR_PIS, --,'.',','), 0)\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vCOFINS',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') VLR_COFINS, --,'.',','), 0)\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vOutro',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') VLR_OUTROS, --,'.',','), 0)\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vBC',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') --,'.',','), 0)\n           BASE_ICMS,\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vICMS',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') VLR_ICMS, --,'.',','), 0)\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vBCST',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') BASE_ICMS_ST, --,'.',','), 0)\n           --nvl(replace(\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/total/ICMSTot/vST',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') VLR_ICMS_ST, --,'.',','), 0)\n           T.BEG_PESSOA_ID TRANSP,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/transp/transporta/xNome',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') TRANSPORTADORA,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/transp/veicTransp/placa',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') PLACA,\n           BEG_UF_ID UFPLACA,\n           --EXTRACTVALUE(x.arquivo_xml,'/nfeProc/NFe/infNFe/transp/vol/nVol','xmlns=\"http://www.portalfiscal.inf.br/nfe\"') numVolumes,\n           --EXTRACTVALUE(x.arquivo_xml,'/nfeProc/NFe/infNFe/transp/vol/qVol','xmlns=\"http://www.portalfiscal.inf.br/nfe\"') qvol,\n           --EXTRACTVALUE(x.arquivo_xml,'/nfeProc/NFe/infNFe/transp/transporta/pesloL','xmlns=\"http://www.portalfiscal.inf.br/nfe\"') PesoL,\n           --EXTRACTVALUE(x.arquivo_xml,'/nfeProc/NFe/infNFe/transp/transporta/pesoB','xmlns=\"http://www.portalfiscal.inf.br/nfe\"') PesoB,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/infAdic/infCpl',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') INFCOMPL,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/infAdic/infAdFisco',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') INFFISCO,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/compl/xObs',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') OBS,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/compra/xPed',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"') OC\n      from BEG_FAT_NFE_XML    X,\n           BEG_PESSOA         F, --- fornecedor\n           BEG_DADO_FILIAL    DF,\n          -- BEG_PESSOA         P, ---- fiial\n           BEG_CFOP           C,\n           BEG_CFOP_ENT_SAI   ES,\n           BEG_CFOP           CES,\n           BEG_FIS_COD_MODELO M,\n           BEG_PESSOA         T, -- transportadora\n           BEG_UF             UF\n     where X.BEG_FAT_NFE_XML_ID = V_CHAVE_NFE.BEG_FAT_NFE_XML_ID\n       and DF.AD_ORG_ID = 1000016--X.AD_ORG_ID -- aok - 29/05/2013\n       and F.CPFCNPJ(+) =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/emit/CNPJ',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"')\n          --and P.CPFCNPJ(+) =\n          --    EXTRACTVALUE(X.ARQUIVO_XML,\n          --                 '/nfeProc/NFe/infNFe/dest/CNPJ',\n          --                 'xmlns=\"http://www.portalfiscal.inf.br/nfe\"')\n          --and DF.BEG_PESSOA_ID(+) = P.BEG_PESSOA_ID\n          --  AND   df.ad_client_id(+) = 1000069\n       and C.CFOP(+) =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/ide/CFOP',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"')\n       and CES.BEG_CFOP_ID(+) = ES.BEG_VW_CFOP_ENT_ID\n       and ES.BEG_VW_CFOP_SAI_ID(+) = C.BEG_CFOP_ID\n       and M.VALUE(+) =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/ide/mod',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"')\n       and UF.ABREVIATURA(+) =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/transp/veicTransp/UF',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"')\n       and T.CPFCNPJ(+) =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/nfeProc/NFe/infNFe/transp/transporta/CNPJ',\n                        'xmlns=\"http://www.portalfiscal.inf.br/nfe\"');\n  V_DADO_NFE BUSCA_DADOS_NFE%rowtype;\n  ------------------------------------------------------------------------------\n  -- AOK - 25/02/2013 - Valida localizacao fornecedor com chave de acesso quando informada\n  cursor CVALIDA_FORNEC(PBEG_VW_FORNECEDOR_ID number) is\n    select UFOR.ABREVIATURA UF_FOR,\n           case\n             when SUBSTR(:NEW.CHAVE_NFE, 1, 2) is null then\n              'OK'\n             when UFOR.UF_IBGE = SUBSTR(:NEW.CHAVE_NFE, 1, 2) then\n              'OK'\n             else\n              'NOK'\n           end UF_CHV_VALIDA,\n           UCHV.ABREVIATURA UF_CHV,\n           P.CPFCNPJ\n      from BEG_PESSOA P,\n           BEG_UF     UFOR,\n           BEG_UF     UCHV\n     where P.BEG_PESSOA_ID = PBEG_VW_FORNECEDOR_ID\n       and UFOR.BEG_UF_ID = P.BEG_VW_UF_ID\n       and UCHV.UF_IBGE(+) = SUBSTR(:NEW.CHAVE_NFE, 1, 2);\n  RVALIDA_FORNEC CVALIDA_FORNEC%rowtype;\n  -- aok - 25/02/2013 -- Verificar o tipo da nota ------------------------------\n  cursor CTIPO_NF is\n    select T.*\n      from BEG_TIPO_NF T\n     where T.BEG_TIPO_NF_ID = :NEW.BEG_TIPO_NF_ID;\n  RTIPO_NF CTIPO_NF%rowtype;\n  -- aok - 19/12/2013 ----------------------------------------------------------\n  --cursor CORG_CTE(PCPFCNPJ BEG_PESSOA.CPFCNPJ%type) is\n  --  select DF.AD_ORG_ID\n  --    from BEG_DADO_FILIAL DF,\n  --         BEG_PESSOA      P\n  --   where P.CPFCNPJ = PCPFCNPJ\n  --     and DF.AD_CLIENT_ID = 1000000\n  --     and DF.BEG_PESSOA_ID = P.BEG_PESSOA_ID;\n  ------------------------------------------------------------------------------\nbegin\n  -- Se esta excluindo uma nota, exclui tambem os itens.\n  /*  if INSERTING\n     or UPDATING then\n    if :NEW.TIPO_NFE not in ('F', 'T', 'D', 'O') then\n      :NEW.TIPO_NFE := 'F';\n    end if;\n  end if;*/\n  --\n  -- buscando dados do xml\n  --\n  IF :NEW.BEG_CPR_NFE_ID IS NOT NULL THEN\n    GOTO FIM;\n  END IF;\n  --\n /* IF DELETING THEN\n    --BEG_CPG_PRE_TITULO\n    DELETE FROM BEG_CPG_PRE_TITULO WHERE BEG_CPR_PRE_NFE_ID = :OLD.BEG_CPR_PRE_NFE_ID;\n    --\n    DELETE FROM BEG_CPR_PRE_NFE_ITEM WHERE BEG_CPR_PRE_NFE_ID = :OLD.BEG_CPR_PRE_NFE_ID;\n    --\n  END IF;*/\n  --\n  if UPDATING then\n    :NEW.SITUACAO := :NEW.DOCSTATUS;\n  elsif INSERTING then\n    :NEW.VLR_TOTAL_PRODUTOS_CALC := 0; -- Iraubi - 14/10/2013\n    -- aok - 23/10/2013 ----------------------------------------------\n    :NEW.VLR_BASE_ICMS_CALC       := 0;\n    :NEW.VLR_BASE_ICMS_SUBST_CALC := 0;\n    :NEW.VLR_ICMS_CALC            := 0;\n    :NEW.VLR_ICMS_SUBST_CALC      := 0;\n    :NEW.VLR_IPI_CALC             := 0;\n    :NEW.VLR_TOTAL_NOTA_CALC      := 0;\n    :NEW.VLR_BASE_IPI_CALC        := 0;\n    ------------------------------------------------------------------\n  end if;\n  --\n  if INSERTING\n     and :NEW.CHAVE_NFE is not null\n     and\n     :NEW.BEG_TIPO_NF_ID =\n     BEG_FNC_RETORNA_PARAM_GERAL('Geral', null, 'CONHECIMENTO_FRETE', null) then\n    open BUSCA_CHAVE;\n    fetch BUSCA_CHAVE\n      into V_CHAVE;\n    if BUSCA_CHAVE%notfound then\n      RAISE_APPLICATION_ERROR(-20501, '1. XML ainda nao carregado');\n    end if;\n    close BUSCA_CHAVE;\n    --\n    open CBUSCA_DADOS_CTE;\n    fetch CBUSCA_DADOS_CTE\n      into V_DADO_CTE;\n    if CBUSCA_DADOS_CTE%found then\n      :NEW.NUMERO                   := V_DADO_CTE.NUMERO;\n      :NEW.SERIE                    := V_DADO_CTE.SERIE;\n      :NEW.DT_EMISSAO               := V_DADO_CTE.DT_EMISSAO;\n      :NEW.VLR_BASE_ICMS            := NVL(V_DADO_CTE.BASE_ICMS, 0);\n      :NEW.VLR_ICMS                 := NVL(V_DADO_CTE.VLR_ICMS, 0);\n      :NEW.VLR_TOTAL_PRODUTOS       := V_DADO_CTE.VLR_TOTAL;\n      :NEW.VLR_TOTAL_PRODUTOS_CALC  := V_DADO_CTE.VLR_TOTAL;\n      :NEW.VLR_TOTAL_NOTA           := V_DADO_CTE.VLR_TOTAL;\n      :NEW.VLR_TOTAL_NOTA_CALC      := V_DADO_CTE.VLR_TOTAL;\n      :NEW.VLR_TOTAL_FATURADO       := V_DADO_CTE.VLR_TOTAL;\n      :NEW.BEG_VW_FORNECEDOR_ID     := V_DADO_CTE.BEG_VW_FORNECEDOR_ID;\n      :NEW.BEG_VW_CFOP_ENT_ID       := V_DADO_CTE.BEG_VW_CFOP_ENT_ID;\n      :NEW.BEG_VW_CFOP_SAI_ID       := V_DADO_CTE.BEG_CFOP_ID;\n      :NEW.BEG_VW_TRANSPORTADORA_ID := V_DADO_CTE.BEG_VW_FORNECEDOR_ID;\n      :NEW.BEG_FIS_COD_MODELO_ID    := V_DADO_CTE.BEG_FIS_COD_MODELO_ID;\n      :NEW.OBS                      := V_DADO_CTE.OBS;\n      --:NEW.vlr_outras_despesas := v_vlr_pedagio;\n    end if;\n    -- IRA UBIRAJARA -------------------------------------------------------------\n  elsif INSERTING\n        and :NEW.CHAVE_NFE is not null then\n    open BUSCA_CHAVE_NFE;\n    fetch BUSCA_CHAVE_NFE\n      into V_CHAVE_NFE;\n    -- if BUSCA_CHAVE_NFE%notfound then\n    --   RAISE_APPLICATION_ERROR(-20501, '2. XML ainda nao carregado');\n    -- else\n    if BUSCA_CHAVE_NFE%found then\n\n      -- aok - 29/04/2013\n      open BUSCA_DADOS_NFE;\n      fetch BUSCA_DADOS_NFE\n        into V_DADO_NFE;\n      if BUSCA_DADOS_NFE%found then\n        :NEW.BEG_TIPO_NF_ID := 1000001; -- AOK - 31/05/2013 - Compra\n        :NEW.BEG_MOEDA_ID   := 1000000;\n        :NEW.NUMERO         := V_DADO_NFE.NUMERO;\n        :NEW.SERIE          := V_DADO_NFE.SERIE;\n        :NEW.DT_EMISSAO     := V_DADO_NFE.DT_EMISSAO;\n        --:NEW.vlr_outras_despesas := v_vlr_pedagio;\n        :NEW.VLR_TOTAL_PRODUTOS      := /*REPLACE(*/F_EXTRAI_NUM_EXPRESSAO(V_DADO_NFE.VLR_PROD)/*,'.',',')*/;\n        :NEW.VLR_TOTAL_PRODUTOS_CALC := 0; -- aok - 31/05/2013\n        --:NEW.VLR_TOTAL_PRODUTOS_CALC := V_DADO_NFE.VLR_PROD; -- aok - 24/09/2013 - 31/05/2013\n        :NEW.VLR_TOTAL_NOTA      := /*REPLACE(*/F_EXTRAI_NUM_EXPRESSAO(V_DADO_NFE.VLR_TOTAL)/*,'.',',')*/;\n        :NEW.VLR_TOTAL_NOTA_CALC := 0; -- aok - 24/09/2013\n        --:NEW.VLR_TOTAL_NOTA_CALC      := V_DADO_NFE.VLR_TOTAL; -- aok - 24/09/2013\n        :NEW.VLR_TOTAL_FATURADO       := /*REPLACE(*/F_EXTRAI_NUM_EXPRESSAO(V_DADO_NFE.VLR_TOTAL)/*,'.',',')*/;\n        :NEW.VLR_FRETE                := /*REPLACE(*/F_EXTRAI_NUM_EXPRESSAO(V_DADO_NFE.VLR_FRETE)/*,'.',',')*/;\n        --:NEW.VLR_FRETE                := 0;\n        :NEW.IND_FRETE_NOTA := case when /*REPLACE(*/F_EXTRAI_NUM_EXPRESSAO(V_DADO_NFE.VLR_FRETE)/*,'.',',')*/ > 0 then 'Y' else 'N' end; -- aok - 25/09/2013\n        --:NEW.IND_FRETE_NOTA           := 'N';\n        :NEW.VLR_SEGURO               := /*REPLACE(*/F_EXTRAI_NUM_EXPRESSAO(V_DADO_NFE.VLR_SEG)/*,'.',',')*/;\n        :NEW.VLR_DESCONTO             := /*REPLACE(*/F_EXTRAI_NUM_EXPRESSAO(V_DADO_NFE.VLR_DESC)/*,'.',',')*/;\n        --:NEW.VLR_IPI                  := 0;-- aok - 25/09/2013\n        :NEW.VLR_IPI_CALC             := 0; -- aok - 25/09/2013\n        --:NEW.VLR_BASE_IPI             := 0;\n        :NEW.VLR_BASE_IPI_CALC        := 0;\n        --:NEW.VLR_ICMS                 := 0; -- aok - 25/09/2013\n        :NEW.VLR_ICMS_CALC            := 0; -- aok - 25/09/2013\n        --:NEW.VLR_ICMS_SUBST           := 0; -- aok - 25/09/2013\n        :NEW.VLR_ICMS_SUBST_CALC      := 0; -- aok - 25/09/2013\n        --:NEW.VLR_BASE_ICMS            := 0; -- aok - 25/09/2013\n        :NEW.VLR_BASE_ICMS_CALC       := 0; -- aok - 25/09/2013\n        --:NEW.VLR_BASE_ICMS_SUBST      := 0; -- aok - 25/09/2013\n        :NEW.VLR_BASE_ICMS_SUBST_CALC := 0; -- aok - 25/09/2013\n        :NEW.VLR_OUTROS_ICMS          := 0; -- aok - 25/09/2013\n        :NEW.VLR_IPI                  := /*REPLACE(*/F_EXTRAI_NUM_EXPRESSAO(V_DADO_NFE.VLR_IPI)/*,'.',',')*/;-- aok - 25/09/2013\n        --:NEW.VLR_IPI_CALC             := V_DADO_NFE.VLR_IPI; -- aok - 25/09/2013\n        :NEW.VLR_ICMS                 := /*REPLACE(*/F_EXTRAI_NUM_EXPRESSAO(V_DADO_NFE.VLR_ICMS)/*,'.',',')*/; -- aok - 25/09/2013\n        --:NEW.VLR_ICMS_CALC            := V_DADO_NFE.VLR_ICMS; -- aok - 25/09/2013\n        :NEW.VLR_ICMS_SUBST           := /*REPLACE(*/F_EXTRAI_NUM_EXPRESSAO(V_DADO_NFE.VLR_ICMS_ST)/*,'.',',')*/; -- aok - 25/09/2013\n        --:NEW.VLR_ICMS_SUBST_CALC      := V_DADO_NFE.VLR_ICMS_ST; -- aok - 25/09/2013\n        :NEW.VLR_BASE_ICMS            := /*REPLACE(*/F_EXTRAI_NUM_EXPRESSAO(V_DADO_NFE.BASE_ICMS)/*,'.',',')*/;\n        --:NEW.VLR_BASE_ICMS_CALC       := V_DADO_NFE.BASE_ICMS;\n        :NEW.VLR_BASE_ICMS_SUBST      := /*REPLACE(*/F_EXTRAI_NUM_EXPRESSAO(V_DADO_NFE.BASE_ICMS_ST)/*,'.',',')*/;\n        --:NEW.VLR_BASE_ICMS_SUBST_CALC := V_DADO_NFE.BASE_ICMS_ST;\n        :NEW.Vlr_Outras_Despesas          := /*REPLACE(*/F_EXTRAI_NUM_EXPRESSAO(V_DADO_NFE.VLR_OUTROS)/*,'.',',')*/;\n        --  :new.vlr_base_isento_icms := 0;\n        --\n        :NEW.BEG_VW_FORNECEDOR_ID := V_DADO_NFE.BEG_PESSOA_ID;\n        --\n        :NEW.BEG_VW_TRANSPORTADORA_ID := V_DADO_NFE.TRANSP;\n        --      :new.qtd_volumes := nvl(v_dado_nfe.numvolumes,0);\n        :NEW.PLACA_VEICULO := V_DADO_NFE.PLACA;\n        :NEW.BEG_UF_ID     := V_DADO_NFE.UFPLACA;\n        --\n        :NEW.BEG_FIS_COD_MODELO_ID     := V_DADO_NFE.BEG_FIS_COD_MODELO_ID;\n        :NEW.IND_BAIXA_ESTOQUE         := 'N';\n        :NEW.IND_EXCLUI_TODOS_ITENS    := 'N';\n        :NEW.IND_EXCLUI_ITENS_INATIVOS := 'N';\n        :NEW.IND_CANCELA_ORDEM         := 'N';\n        :NEW.IND_CANCELA_SALDO         := 'N';\n        :NEW.IND_CANCELA_TITULO        := 'N';\n        :NEW.IND_CANCELA_AUT_PGTO      := 'N';\n        :NEW.IND_GERADA_XML            := 'Y'; -- aok - 29/05/2013\n        :NEW.DT_ENTRADA                := TRUNC(sysdate); -- aok - 31/05/2013\n        :new.obs                       := SUBSTR(V_DADO_NFE.Infcompl,1,2000); -- aok - 21/01/2014\n        :new.msg_inf_fiscal            := V_DADO_NFE.Inffisco; -- aok - 21/01/2014\n        --\n      end if;\n      close BUSCA_DADOS_NFE;\n    end if;\n    close BUSCA_CHAVE_NFE;\n    ----------------------------------------------------------------------------\n  end if;\n  --\n  VN_TESTE2 := :NEW.VLR_IPI;\n  --\n  -- aok - 28/02/2011\n  if BEG_PCK_CPR_COMPRAS.VB_PROC_ACERTO_ESPECIAL\n     or UPDATING('BEG_CPR_ORDEM_ID') then\n    goto FIM;\n  end if;\n  --\n  if DELETING then\n\n    -- Verifica o status da nota\n    if :OLD.DOCSTATUS in ('CA', 'WC') then\n      -- aok - 21/02/2013\n      -- Verifica o status da nota\n      --  if :OLD.DOCSTATUS <> 'WC' then\n      --    VC_MSG_ERRO := 'Somente e possivel excluir notas ainda nao processadas!';\n      --    goto FIM;\n      --  end if;\n\n      -- Verifica os titulos vinculados\n      select count(1)\n        into VN_DUMMY\n        from BEG_CPG_TITULO\n       where BEG_CPR_NFE_ID = :OLD.BEG_CPR_PRE_NFE_ID\n         and ISACTIVE = 'Y';\n\n      if VN_DUMMY > 0 then\n        VC_MSG_ERRO := 'Existem ' || TO_CHAR(VN_DUMMY) ||\n                       ' titulo(s) a pagar vinculado(s) a esta nota que devem ser inativados!';\n        goto FIM;\n      end if;\n\n      delete from BEG_CPG_PRE_TITULO\n       where BEG_CPR_NFE_ID = :OLD.BEG_CPR_PRE_NFE_ID;\n\n      BEG_PCK_CPR_COMPRAS.VB_PROC_NFE := true;\n\n      -- Exclui os itens\n      delete from BEG_CPR_PRE_NFE_ITEM\n       where BEG_CPR_PRE_NFE_ID = :OLD.BEG_CPR_PRE_NFE_ID;\n\n      BEG_PCK_CPR_COMPRAS.VB_PROC_NFE := false;\n\n      -- Exclui os registros de impress?o eventualmente gerados\n/*      delete from BEG_GER_IMPRESSAO\n       where NVL(BEG_CPR_NFE_ID, 0) = :OLD.BEG_CPR_PRE_NFE_ID\n          or NVL(BEG_VW_CPR_NFE_ESPECIAL_ID, 0) = :OLD.BEG_CPR_PRE_NFE_ID;*/\n\n      goto FIM;\n    end if;\n  end if;\n\n  if BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_HIST then\n    if :OLD.DOCSTATUS <> 'WP' then\n      VC_MSG_ERRO := 'Nota nao encontra-se aguardando pagamento!';\n    end if;\n    goto FIM;\n  end if;\n\n  -- aok - 25/02/2013 ----------------------------------------------------------\n  BEG_PCK_CPR_COMPRAS.VC_IND_FATURAMENTO := :NEW.IND_EMITIDA_FATURAMENTO;\n  --\n  if not DELETING then\n    if :NEW.DOCSTATUS <> 'CA' then\n      :NEW.TP_LANCTO_CONTABIL := 'E';\n      if :NEW.CHAVE_NFE is not null then\n        :NEW.BEG_FIS_COD_MODELO_ID := BEG_FNC_BUSCA_ID_MODFISCAL(SUBSTR(:NEW.CHAVE_NFE,\n                                                                        21,\n                                                                        2));\n        --if SUBSTR(:NEW.CHAVE_NFE, 21, 2) = '55' then\n        --  :NEW.BEG_FIS_COD_MODELO_ID := 1000031;\n        --elsif SUBSTR(:NEW.CHAVE_NFE, 21, 2) = '57' then\n        --  :NEW.BEG_FIS_COD_MODELO_ID := 1000034;\n        --end if;\n      end if;\n      if NVL(:NEW.BEG_FIS_COD_MODELO_ID, 0) > 0 then\n        open CMODNF;\n        fetch CMODNF\n          into RMODNF;\n        close CMODNF;\n        if RMODNF.IND_CHAVE_ACESSO = 'Y' then\n          /*if LENGTH(:NEW.CHAVE_NFE) <> 44 then\n            VC_MSG_ERRO := 'Modelo fiscal obriga Chave Acesso de 44 posições';\n            goto FIM;\n          end if;*/\n          --\n          if :NEW.NUMERO is null then\n            :NEW.NUMERO := SUBSTR(:NEW.CHAVE_NFE, 26, 9);\n          end if;\n          if :NEW.SERIE is null then\n            :NEW.SERIE := TO_NUMBER(SUBSTR(:NEW.CHAVE_NFE, 23, 3));\n          end if;\n         /* if :NEW.BEG_VW_FORNECEDOR_ID is null then\n            :NEW.BEG_VW_FORNECEDOR_ID := BEG_FNC_BUSCA_ID_PESSOA(SUBSTR(:NEW.CHAVE_NFE,\n                                                                        7,\n                                                                        14));\n          end if;*/\n          --\n          if SUBSTR(:NEW.CHAVE_NFE, 26, 9) <> :NEW.NUMERO then\n            VC_MSG_ERRO := 'Número documento na Chave Acesso não confere com o número do documento informado no documento fiscal. ';\n            goto FIM;\n          end if;\n          --\n          if :NEW.SERIE is null then\n            VC_MSG_ERRO := 'Série documento não foi informado ';\n            goto FIM;\n          end if;\n          if TO_NUMBER(SUBSTR(:NEW.CHAVE_NFE, 23, 3)) <> :NEW.SERIE then\n            VC_MSG_ERRO := 'Série documento na Chave Acesso não confere com a série do documento informado no documento fiscal. ';\n            goto FIM;\n          end if;\n          if not (RMODNF.VALUE = SUBSTR(:NEW.CHAVE_NFE, 21, 2)) then\n            VC_MSG_ERRO := 'Codigo da modelo da chave de acesso não coincide com a informada! ';\n            goto FIM;\n          end if;\n          ---------------------------------------------------------------------------------------\n        else\n          if :NEW.CHAVE_NFE is not null then\n            VC_MSG_ERRO := 'Modelo fiscal não obriga Chave de Acesso';\n            goto FIM;\n          end if;\n        end if;\n        --\n        if NVL(RMODNF.BEG_TIPO_NF_ID, 0) > 0 then\n          :NEW.BEG_TIPO_NF_ID := RMODNF.BEG_TIPO_NF_ID;\n        end if;\n      else\n        null;\n        --VC_MSG_ERRO := 'Faltou informar Código Modelo Fiscal';\n        --goto FIM;\n      end if;\n      --\n\n      open CTIPO_NF;\n      fetch CTIPO_NF\n        into RTIPO_NF;\n      if CTIPO_NF%notfound then\n        VC_MSG_ERRO := 'Faltou informar o tipo da nota';\n        close CTIPO_NF;\n        goto FIM;\n      end if;\n      close CTIPO_NF;\n      --\n    end if; -- if :NEW.DOCSTATUS <> 'CA'\n  end if; -- if not DELETING\n  ------------------------------------------------------------------------------\n\n  -- AOK - 03/06/2011 - Valida data de emissao com a data atual\n  if TRUNC(:NEW.DT_EMISSAO) > TRUNC(sysdate) then\n    VC_MSG_ERRO := 'Data entrada inválida. Deveria ser menor ou igual a data atual!';\n    goto FIM;\n  end if;\n\n  -- AOK - 11/04/2011 - Valida data de emissao com a da entrada da nota fiscal\n  if TRUNC(:NEW.DT_EMISSAO) > TRUNC(:NEW.DT_ENTRADA) then\n    VC_MSG_ERRO :=  --TRUNC(:NEW.DT_EMISSAO) ||' > '|| TRUNC(:NEW.DT_ENTRADA) ||' '||\n     'Data entrada inválida. Informar data maior ou igual à data de emissão do documento fiscal.!';\n    goto FIM;\n  end if;\n\n  -- AOK - 29/05/2011 - Valida a existencia da chave eletronica\n  -- aok - 13/06/2011 - Passa a ser obrigatorio informar o cod.modelo da nota\n  if not deleting then\n  if :NEW.BEG_FIS_COD_MODELO_ID is null then\n    VC_MSG_ERRO := 'Faltou informar o Modelo Fiscal!';\n    goto FIM;\n  else\n    open CMODNF;\n    fetch CMODNF\n      into RMODNF;\n    close CMODNF;\n    if RMODNF.IND_CHAVE_ACESSO = 'Y' then\n      if LENGTH(:NEW.CHAVE_NFE) <> 44 then\n        VC_MSG_ERRO := 'Modelo fiscal obriga Chave Acesso de 44 posições';\n        goto FIM;\n      end if;\n      -- AOK - 17/05/2011 --------------------------------------------------------------------------------------------------------\n      --      if SUBSTR(:NEW.CHAVE_NFE, 26, 9) <> :NEW.NUMERO then\n      --        VC_MSG_ERRO := 'Número documento na Chave Acesso não confere com o número do documento informado no documento fiscal. ';\n      --        goto FIM;\n      --      end if;\n      --\n      if :NEW.SERIE is null then\n        VC_MSG_ERRO := 'Série documento não foi informado ';\n        goto FIM;\n      end if;\n      if TO_NUMBER(SUBSTR(:NEW.CHAVE_NFE, 23, 3)) <> :NEW.SERIE then\n        VC_MSG_ERRO := 'Série documento na Chave Acesso não confere com a série do documento informado no documento fiscal. ';\n        goto FIM;\n      end if;\n      ----------------------------------------------------------------------------------------------------------------------------\n    else\n      if :NEW.CHAVE_NFE is not null then\n        VC_MSG_ERRO := 'Modelo fiscal não obriga Chave de Acesso';\n        goto FIM;\n      end if;\n    end if;\n  end if;\n  -- aok - 29/05/2013 ----------------------------------------------------------\n  if :NEW.NUMERO is null then\n    VC_MSG_ERRO := 'Numero nota fiscal deve ser informado!';\n    goto FIM;\n  end if;\n  end if;\n\n  if NVL(:OLD.NRO_VIA_IMPRESSA, :NEW.NRO_VIA_IMPRESSA) <>\n     :NEW.NRO_VIA_IMPRESSA then\n    goto FIM;\n  end if;\n\n  if :NEW.IND_EXCLUI_TODOS_ITENS = 'Y'\n     or :NEW.IND_EXCLUI_ITENS_INATIVOS = 'Y' then\n    BEG_PCK_CPR_COMPRAS.VB_PROC_NFE := true;\n\n    -- Atualiza os valores na nota\n    select ROUND(:NEW.VLR_BASE_ICMS_CALC - sum(VLR_BASE_ICMS_CALC), 2),\n           :NEW.VLR_BASE_OUTROS_ICMS - sum(VLR_BASE_OUTROS_ICMS),\n           ROUND(:NEW.VLR_BASE_ICMS_SUBST_CALC -\n                 sum(VLR_BASE_ICMS_SUBST_CALC),\n                 2),\n           :NEW.VLR_BASE_ISENTO_ICMS - sum(VLR_BASE_ISENTO_ICMS),\n           ROUND(:NEW.VLR_ICMS_CALC - sum(VLR_ICMS_CALC), 2),\n           :NEW.VLR_OUTROS_ICMS - sum(VLR_OUTROS_ICMS),\n           ROUND(:NEW.VLR_ICMS_SUBST_CALC - sum(VLR_ICMS_SUBST_CALC), 2),\n           ROUND(:NEW.VLR_BASE_IPI_CALC - sum(VLR_BASE_IPI_CALC), 2),\n           :NEW.VLR_BASE_OUTROS_IPI - sum(VLR_BASE_OUTROS_IPI),\n           :NEW.VLR_BASE_ISENTO_IPI - sum(VLR_BASE_ISENTO_IPI),\n           ROUND(:NEW.VLR_IPI_CALC - sum(VLR_IPI_CALC), 2),\n           :NEW.VLR_OUTROS_IPI - sum(VLR_OUTROS_IPI),\n           :NEW.VLR_BASE_ISSQN - sum(VLR_BASE_ISSQN),\n           :NEW.VLR_ISSQN - sum(VLR_ISSQN),\n           :NEW.QTD_VOLUMES - sum(QTD_VOLUMES),\n           :NEW.PESO_BRUTO - sum(PESO_BRUTO),\n           :NEW.PESO_LIQUIDO - sum(PESO_LIQUIDO),\n           :NEW.VLR_SEGURO - sum(VLR_SEGURO),\n           ROUND(:NEW.VLR_TOTAL_PRODUTOS_CALC - sum(VLR_TOTAL_CALC), 2),\n           ROUND(:NEW.VLR_TOTAL_NOTA_CALC -\n                 sum(VLR_TOTAL_CALC + VLR_DESPESAS_FINANCEIRAS +\n                     VLR_OUTRAS_DESPESAS + DECODE(IND_FRETE_NOTA,\n                                                  'Y',\n                                                  (VLR_FRETE + VLR_FRETE_RDP),\n                                                  0)),\n                 2)\n      into :NEW.VLR_BASE_ICMS_CALC,\n           :NEW.VLR_BASE_OUTROS_ICMS,\n           :NEW.VLR_BASE_ICMS_SUBST_CALC,\n           :NEW.VLR_BASE_ISENTO_ICMS,\n           :NEW.VLR_ICMS_CALC,\n           :NEW.VLR_OUTROS_ICMS,\n           :NEW.VLR_ICMS_SUBST_CALC,\n           :NEW.VLR_BASE_IPI_CALC,\n           :NEW.VLR_BASE_OUTROS_IPI,\n           :NEW.VLR_BASE_ISENTO_IPI,\n           :NEW.VLR_IPI_CALC,\n           :NEW.VLR_OUTROS_IPI,\n           :NEW.VLR_BASE_ISSQN,\n           :NEW.VLR_ISSQN,\n           :NEW.QTD_VOLUMES,\n           :NEW.PESO_BRUTO,\n           :NEW.PESO_LIQUIDO,\n           :NEW.VLR_SEGURO,\n           :NEW.VLR_TOTAL_PRODUTOS_CALC,\n           :NEW.VLR_TOTAL_NOTA_CALC\n      from BEG_CPR_PRE_NFE_ITEM\n     where BEG_CPR_PRE_NFE_ID = :NEW.BEG_CPR_PRE_NFE_ID\n       and ISACTIVE = case\n             when :NEW.IND_EXCLUI_TODOS_ITENS = 'Y' then\n              ISACTIVE\n             when :NEW.IND_EXCLUI_ITENS_INATIVOS = 'Y' then\n              'N'\n             else\n              '^'\n           end;\n\n    -- Exclui os itens\n    delete from BEG_CPR_PRE_NFE_ITEM\n     where BEG_CPR_PRE_NFE_ID = :NEW.BEG_CPR_PRE_NFE_ID\n       and ISACTIVE = case\n             when :NEW.IND_EXCLUI_TODOS_ITENS = 'Y' then\n              ISACTIVE\n             when :NEW.IND_EXCLUI_ITENS_INATIVOS = 'Y' then\n              'N'\n             else\n              '^'\n           end;\n\n    :NEW.IND_EXCLUI_TODOS_ITENS    := 'N';\n    :NEW.IND_EXCLUI_ITENS_INATIVOS := 'N';\n\n    BEG_PCK_CPR_COMPRAS.VB_PROC_NFE := false;\n\n  end if;\n\n  if not BEG_PCK_CPR_COMPRAS.VB_PROC_NFE_IT then\n\n    -- Verifica filial\n/*    if NVL(:NEW.AD_ORG_ID, 0) = 0 then\n      VC_MSG_ERRO := 'Deve ser selecionada uma filial para a nota!';\n      goto FIM;\n    end if;*/\n    -- Valor faturado\n    if NVL(:NEW.VLR_TOTAL_FATURADO, 0) < 0 then\n      VC_MSG_ERRO := 'Valor faturado negativo!';\n      goto FIM;\n    end if;\n\n    -- Valida o CFOP informado\n    if NVL(:NEW.BEG_VW_CFOP_SAI_ID, 0) > 0\n       or NVL(:NEW.BEG_VW_CFOP_ENT_ID, 0) > 0 then\n      open CFOP;\n      fetch CFOP\n        into :NEW.BEG_VW_CFOP_SAI_ID,\n             :NEW.BEG_VW_CFOP_ENT_ID,\n             V_PADRAO;\n      if CFOP%notfound then\n        VC_MSG_ERRO := 'CFOPs sem relacao cadastrada ou verifique padrão!'; -- 03/11/2010\n        goto FIM;\n      end if;\n    end if;\n\n      begin\n        --NVL2( valor, retorno_if_NOT_null, retorno_if_null )\n        select F.TP_FRETE,\n              /* DECODE(*/NVL(:NEW.VLR_FRETE, 0)--,\n                     /* 0,\n                      NVL(:NEW.VLR_TOTAL_PRODUTOS, 0) * NVL(F.PER_FRETE, 0) / 100,\n                      :NEW.VLR_FRETE)*/,\n               DECODE(NVL(:NEW.VLR_DESPESAS_FINANCEIRAS, 0),\n                      0,\n                      NVL(:NEW.VLR_TOTAL_PRODUTOS, 0) *\n                      NVL(F.PER_DESPESAS_FINANCEIRAS, 0) / 100,\n                      :NEW.VLR_DESPESAS_FINANCEIRAS),\n               DECODE(NVL(:NEW.VLR_OUTRAS_DESPESAS, 0),\n                      0,\n                      NVL(:NEW.VLR_TOTAL_PRODUTOS, 0) *\n                      NVL(F.PER_OUTRAS_DESPESAS, 0) / 100,\n                      :NEW.VLR_OUTRAS_DESPESAS),\n               :NEW.OBS_OUTRAS_DESPESAS || F.OBS_OUTRAS_DESPESAS,\n               NVL2(:NEW.BEG_CONDICAO_PAGAMENTO_ID,\n                    :NEW.BEG_CONDICAO_PAGAMENTO_ID,\n                    F.BEG_CONDICAO_PAGAMENTO_ID),\n               NVL2(:NEW.BEG_VW_TRANSPORTADORA_ID,\n                    :NEW.BEG_VW_TRANSPORTADORA_ID,\n                    F.BEG_VW_TRANSPORTADORA_ID)\n          into :NEW.TP_FRETE,\n               :NEW.VLR_FRETE,\n               :NEW.VLR_DESPESAS_FINANCEIRAS,\n               :NEW.VLR_OUTRAS_DESPESAS,\n               :NEW.OBS_OUTRAS_DESPESAS,\n               :NEW.BEG_CONDICAO_PAGAMENTO_ID,\n               :NEW.BEG_VW_TRANSPORTADORA_ID\n          from BEG_SUP_FORNECEDOR F\n         where F.BEG_VW_FORNECEDOR_ID = :NEW.BEG_VW_FORNECEDOR_ID\n           and F.AD_ORG_ID =\n               (select max(FF.AD_ORG_ID)\n                  from BEG_SUP_FORNECEDOR FF,\n                       BEG_GER_FILIAL     FL\n                 where FF.AD_CLIENT_ID = FL.AD_CLIENT_ID\n                   and FF.BEG_VW_FORNECEDOR_ID = F.BEG_VW_FORNECEDOR_ID\n                   and FF.ISACTIVE = 'Y'\n                   and FF.AD_ORG_ID in (FL.AD_ORG_ID_GERAL, :NEW.AD_ORG_ID))\n           and F.ISACTIVE = 'Y';\n\n      exception\n        when NO_DATA_FOUND then\n          null;\n\n      end;\n\n      if :NEW.BEG_VW_TRANSPORTADORA_ID is null\n         and :NEW.TP_FRETE = 'F' then\n        :NEW.BEG_VW_TRANSPORTADORA_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAMETRO(:NEW.AD_CLIENT_ID,\n                                                                             :NEW.AD_ORG_ID,\n                                                                             'Compras',\n                                                                             null,\n                                                                             'TRANSP_PADRAO_COMPRA'));\n      end if;\n\n    end if;\n\n  \n  -- Valor total da nota\n  if NVL(:NEW.VLR_TOTAL_NOTA, 0) < 0 then\n    VC_MSG_ERRO := 'Valor total da nota negativo!';\n    goto FIM;\n  end if;\n\n  -- Valor total dos produtos\n  if NVL(:NEW.VLR_TOTAL_PRODUTOS, 0) < 0 then\n    VC_MSG_ERRO := 'Valor total dos produtos negativo!';\n    goto FIM;\n  end if;\n\n  if NVL(:OLD.IND_ACRESCIMO_NOTA, 'N') = 'Y' then\n    :NEW.VLR_TOTAL_NOTA_CALC := ROUND(:NEW.VLR_TOTAL_NOTA_CALC -\n                                      NVL(:OLD.VLR_ACRESCIMO, 0),\n                                      2);\n  end if;\n\n  if NVL(:OLD.IND_DESCONTO_NOTA, 'N') = 'Y' then\n    :NEW.VLR_TOTAL_NOTA_CALC := ROUND(:NEW.VLR_TOTAL_NOTA_CALC +\n                                      NVL(:OLD.VLR_DESCONTO, 0),\n                                      2);\n  end if;\n\n  if NVL(:OLD.IND_FRETE_NOTA, 'N') = 'Y' then\n    :NEW.VLR_TOTAL_NOTA_CALC := ROUND(:NEW.VLR_TOTAL_NOTA_CALC -\n                                      (NVL(:OLD.VLR_FRETE, 0) +\n                                      NVL(:OLD.VLR_FRETE_RDP, 0)),\n                                      2);\n  end if;\n\n  -- Desconto\n  if (NVL(:OLD.VLR_TOTAL_NOTA, 0) <> NVL(:NEW.VLR_TOTAL_NOTA, 0) or\n     NVL(:OLD.VLR_TOTAL_NOTA_CALC, 0) <> NVL(:NEW.VLR_TOTAL_NOTA_CALC, 0) or\n     NVL(:OLD.PER_DESCONTO, 0) <> NVL(:NEW.PER_DESCONTO, 0) or\n     NVL(:OLD.VLR_DESCONTO, 0) <> NVL(:NEW.VLR_DESCONTO, 0))\n     and (NVL(:NEW.PER_DESCONTO, 0) > 0 or NVL(:NEW.VLR_DESCONTO, 0) > 0) then\n\n    if NVL(:NEW.VLR_TOTAL_NOTA, 0) = 0\n       and NVL(:NEW.VLR_TOTAL_NOTA_CALC, 0) = 0 then\n\n      if NVL(:NEW.VLR_DESCONTO, 0) > 0 then\n        :NEW.PER_DESCONTO := 0;\n      end if;\n\n    else\n\n      if :NEW.VLR_TOTAL_NOTA = 0 then\n        VN_AUX_BASE := :NEW.VLR_TOTAL_NOTA_CALC;\n      else\n        VN_AUX_BASE := :NEW.VLR_TOTAL_NOTA;\n      end if;\n\n      if NVL(:OLD.PER_DESCONTO, 0) <> NVL(:NEW.PER_DESCONTO, 0)\n         or NVL(:NEW.VLR_DESCONTO, 0) = 0 then\n        VN_AUX_ALQ  := :NEW.PER_DESCONTO;\n        VN_AUX_CALC := 0;\n      else\n        VN_AUX_ALQ  := 0;\n        VN_AUX_CALC := :NEW.VLR_DESCONTO;\n      end if;\n\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                             VN_AUX_BASE,\n                                             VN_AUX_CALC);\n\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do desconto!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do desconto!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de desconto diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :NEW.PER_DESCONTO := VN_AUX_ALQ;\n        :NEW.VLR_DESCONTO := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  -- Acrescimo\n  if (NVL(:OLD.VLR_TOTAL_NOTA, 0) <> NVL(:NEW.VLR_TOTAL_NOTA, 0) or\n     NVL(:OLD.VLR_TOTAL_NOTA_CALC, 0) <> NVL(:NEW.VLR_TOTAL_NOTA_CALC, 0) or\n     NVL(:OLD.PER_ACRESCIMO, 0) <> NVL(:NEW.PER_ACRESCIMO, 0) or\n     NVL(:OLD.VLR_ACRESCIMO, 0) <> NVL(:NEW.VLR_ACRESCIMO, 0))\n     and (NVL(:NEW.PER_ACRESCIMO, 0) > 0 or NVL(:NEW.VLR_ACRESCIMO, 0) > 0) then\n\n    if NVL(:NEW.VLR_TOTAL_NOTA, 0) = 0\n       and NVL(:NEW.VLR_TOTAL_NOTA_CALC, 0) = 0 then\n\n      if NVL(:NEW.VLR_ACRESCIMO, 0) > 0 then\n        :NEW.PER_ACRESCIMO := 0;\n      end if;\n\n    else\n\n      if :NEW.VLR_TOTAL_NOTA = 0 then\n        VN_AUX_BASE := :NEW.VLR_TOTAL_NOTA_CALC;\n      else\n        VN_AUX_BASE := :NEW.VLR_TOTAL_NOTA;\n      end if;\n\n      if NVL(:OLD.PER_ACRESCIMO, 0) <> NVL(:NEW.PER_ACRESCIMO, 0)\n         or NVL(:NEW.VLR_ACRESCIMO, 0) = 0 then\n        VN_AUX_ALQ  := :NEW.PER_ACRESCIMO;\n        VN_AUX_CALC := 0;\n      else\n        VN_AUX_ALQ  := 0;\n        VN_AUX_CALC := :NEW.VLR_ACRESCIMO;\n      end if;\n\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                             VN_AUX_BASE,\n                                             VN_AUX_CALC);\n\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do acrescimo!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do acrescimo!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de acrescimo diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :NEW.PER_ACRESCIMO := VN_AUX_ALQ;\n        :NEW.VLR_ACRESCIMO := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  if NVL(:NEW.VLR_FRETE, 0) = 0\n     and NVL(:NEW.VLR_FRETE_RDP, 0) = 0 then\n    :NEW.IND_FRETE_NOTA := 'N';\n  end if;\n\n  if NVL(:NEW.VLR_DESCONTO, 0) = 0 then\n    :NEW.IND_DESCONTO_NOTA      := 'N';\n    :NEW.IND_DESCONTO_BASE_ICMS := 'N';\n    :NEW.IND_DESCONTO_BASE_IPI  := 'N';\n  ELSIF NVL(:NEW.VLR_DESCONTO, 0) > 0 then\n    :NEW.IND_DESCONTO_NOTA      := 'Y';\n  end if;\n\n  if NVL(:NEW.VLR_BASE_ICMS_CALC, 0) = 0\n     and NVL(:NEW.VLR_BASE_ICMS_SUBST_CALC, 0) = 0 then\n    :NEW.IND_DESCONTO_BASE_ICMS := 'N';\n  end if;\n\n  if NVL(:NEW.VLR_ACRESCIMO, 0) = 0 then\n    :NEW.IND_ACRESCIMO_NOTA      := 'N';\n    :NEW.IND_ACRESCIMO_BASE_ICMS := 'N';\n    :NEW.IND_ACRESCIMO_BASE_IPI  := 'N';\n  end if;\n\n  if NVL(:NEW.VLR_BASE_IPI_CALC, 0) = 0 then\n    :NEW.IND_ACRESCIMO_BASE_IPI := 'N';\n  end if;\n\n  if :NEW.IND_ACRESCIMO_NOTA = 'Y' then\n    :NEW.VLR_TOTAL_NOTA_CALC := :NEW.VLR_TOTAL_NOTA_CALC +\n                                :NEW.VLR_ACRESCIMO;\n  end if;\n\n  if :NEW.IND_DESCONTO_NOTA = 'Y' then\n    :NEW.VLR_TOTAL_NOTA_CALC := :NEW.VLR_TOTAL_NOTA_CALC -\n                                :NEW.VLR_DESCONTO;\n  end if;\n\n  if :NEW.IND_FRETE_NOTA = 'Y' then\n    :NEW.VLR_TOTAL_NOTA_CALC := ROUND(:NEW.VLR_TOTAL_NOTA_CALC +\n                                      NVL(:NEW.VLR_FRETE, 0) +\n                                      NVL(:NEW.VLR_FRETE_RDP, 0),\n                                      2);\n  end if;\n\n  -- Atualiza ICMS e IPI quendo o frete, arescimo ou desconto s?o na na nota\n  if :NEW.IND_FRETE_NOTA = 'Y' then\n    BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE := :NEW.VLR_FRETE +\n                                            :NEW.VLR_FRETE_RDP;\n  else\n    BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE := 0;\n  end if;\n\n  if :NEW.IND_ACRESCIMO_BASE_ICMS = 'Y' then\n    BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE := :NEW.VLR_ACRESCIMO;\n  else\n    BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE := 0;\n  end if;\n\n  if :NEW.IND_DESCONTO_BASE_ICMS = 'Y' then\n    BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE := :NEW.VLR_DESCONTO;\n  else\n    BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE := 0;\n  end if;\n\n  if :NEW.IND_ACRESCIMO_BASE_IPI = 'Y' then\n    BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_IPI_NFE := :NEW.VLR_ACRESCIMO;\n  else\n    BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_IPI_NFE := 0;\n  end if;\n\n  if NVL(:NEW.IND_DESCONTO_BASE_IPI, '^') <>\n     NVL(:OLD.IND_DESCONTO_BASE_IPI, '^') then\n    if :NEW.IND_DESCONTO_BASE_IPI = 'Y' then\n      BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_IPI_NFE := :NEW.VLR_DESCONTO;\n    else\n      BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_IPI_NFE := 0;\n    end if;\n  else\n    BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_IPI_NFE := 0;\n  end if;\n\n  if BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE > 0\n     or BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE > 0\n     or BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE > 0\n     or BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_IPI_NFE > 0\n     or BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_IPI_NFE > 0 then\n    BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS := :NEW.VLR_TOTAL_PRODUTOS_CALC;\n  else\n    BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS := 0;\n  end if;\n\n  if NVL(:NEW.IND_EMITIDA_FATURAMENTO, 'N') = 'N' -- aok - 25/02/2013\n     and NVL(:NEW.IND_GERADA_XML, 'N') = 'N' -- aok - 31/05/2013\n   then\n    if not BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM then\n\n      if not BEG_PCK_CPR_COMPRAS.VB_PROC_NFE_IT then\n\n        BEG_PCK_CPR_COMPRAS.VB_PROC_NFE := true;\n\n        :NEW.VLR_BASE_ICMS_CALC       := 0;\n        :NEW.VLR_ICMS_CALC            := 0;\n        :NEW.VLR_BASE_ICMS_SUBST_CALC := 0;\n        :NEW.VLR_ICMS_SUBST_CALC      := 0;\n        :NEW.VLR_BASE_IPI_CALC        := 0;\n        :NEW.VLR_IPI_CALC             := 0;\n\n        for R_ITENS in (select BEG_CPR_PRE_NFE_ITEM_ID,\n                               VLR_TOTAL_CALC,\n                               ALQ_ICMS,\n                               VLR_BASE_ICMS_CALC,\n                               VLR_ICMS_CALC,\n                               ALQ_ICMS_SUBST,\n                               VLR_BASE_ICMS_SUBST_CALC,\n                               VLR_ICMS_SUBST_CALC,\n                               ALQ_IPI,\n                               VLR_BASE_IPI_CALC,\n                               VLR_IPI_CALC\n                          from BEG_CPR_PRE_NFE_ITEM IT\n                         where BEG_CPR_PRE_NFE_ID = :NEW.BEG_CPR_PRE_NFE_ID\n                           and (ALQ_ICMS > 0 or ALQ_IPI > 0 or\n                               ALQ_ICMS_SUBST > 0)\n                           and NVL(:NEW.IND_EMITIDA_FATURAMENTO, 'N') = 'N'\n                        union -- aok - 25/02/2013\n                        select BEG_CPR_NFE_ITEM_ID,\n                               DECODE(VLR_TOTAL,\n                                      0,\n                                      VLR_TOTAL_CALC,\n                                      VLR_TOTAL) VLR_TOTAL_CALC,\n                               ALQ_ICMS,\n                               DECODE(VLR_BASE_ICMS,\n                                      0,\n                                      VLR_BASE_ICMS_CALC,\n                                      VLR_BASE_ICMS) VLR_BASE_ICMS_CALC,\n                               DECODE(VLR_ICMS, 0, VLR_ICMS_CALC, VLR_ICMS) VLR_ICMS_CALC,\n                               ALQ_ICMS_SUBST,\n                               DECODE(VLR_BASE_ICMS_SUBST,\n                                      0,\n                                      VLR_BASE_ICMS_SUBST_CALC,\n                                      VLR_BASE_ICMS_SUBST) VLR_BASE_ICMS_SUBST_CALC,\n                               DECODE(VLR_ICMS_SUBST,\n                                      0,\n                                      VLR_ICMS_SUBST_CALC,\n                                      VLR_ICMS_SUBST) VLR_ICMS_SUBST_CALC,\n                               ALQ_IPI,\n                               DECODE(VLR_BASE_IPI,\n                                      0,\n                                      VLR_BASE_IPI_CALC,\n                                      VLR_BASE_IPI) VLR_BASE_IPI_CALC,\n                               DECODE(VLR_IPI, 0, VLR_IPI_CALC, VLR_IPI) VLR_IPI_CALC\n                          from BEG_CPR_NFE_ITEM IT\n                         where BEG_CPR_NFE_ID = :NEW.BEG_CPR_PRE_NFE_ID\n                           and (ALQ_ICMS > 0 or ALQ_IPI > 0 or\n                               ALQ_ICMS_SUBST > 0)\n                           and NVL(:NEW.IND_EMITIDA_FATURAMENTO, 'N') = 'Y')\n        loop\n          -- ICMS\n          if NVL(R_ITENS.ALQ_ICMS, 0) > 0 then\n            VN_VLR_RATEADO := 0;\n\n            if NVL(:NEW.IND_FRETE_NOTA, '^') <>\n               NVL(:OLD.IND_FRETE_NOTA, '^') then\n              if :NEW.IND_FRETE_NOTA = 'Y' then\n                VN_VLR_RATEADO := VN_VLR_RATEADO + :NEW.VLR_FRETE +\n                                  :NEW.VLR_FRETE_RDP;\n              else\n                VN_VLR_RATEADO := VN_VLR_RATEADO -\n                                  (:OLD.VLR_FRETE + :OLD.VLR_FRETE_RDP);\n              end if;\n            end if;\n\n            if NVL(:NEW.IND_ACRESCIMO_BASE_ICMS, '^') <>\n               NVL(:OLD.IND_ACRESCIMO_BASE_ICMS, '^') then\n              if :NEW.IND_ACRESCIMO_BASE_ICMS = 'Y' then\n                VN_VLR_RATEADO := VN_VLR_RATEADO + :NEW.VLR_ACRESCIMO;\n              else\n                VN_VLR_RATEADO := VN_VLR_RATEADO - :OLD.VLR_ACRESCIMO;\n              end if;\n            end if;\n\n            if NVL(:NEW.IND_DESCONTO_BASE_ICMS, '^') <>\n               NVL(:OLD.IND_DESCONTO_BASE_ICMS, '^') then\n              if :NEW.IND_DESCONTO_BASE_ICMS = 'Y' then\n                VN_VLR_RATEADO := VN_VLR_RATEADO - :NEW.VLR_DESCONTO;\n              else\n                VN_VLR_RATEADO := VN_VLR_RATEADO + :OLD.VLR_DESCONTO;\n              end if;\n            end if;\n\n            R_ITENS.VLR_BASE_ICMS_CALC := ROUND(R_ITENS.VLR_BASE_ICMS_CALC +\n                                                (VN_VLR_RATEADO /\n                                                :NEW.VLR_TOTAL_PRODUTOS_CALC *\n                                                R_ITENS.VLR_TOTAL_CALC),\n                                                2);\n\n            VN_AUX_CALC := 0;\n            BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(R_ITENS.ALQ_ICMS,\n                                                   R_ITENS.VLR_BASE_ICMS_CALC,\n                                                   VN_AUX_CALC);\n\n            if VN_AUX_CALC = -1 then\n              VC_MSG_ERRO := 'Valores negativos no calculo do ICMS dos itens!';\n            elsif VN_AUX_CALC = -2 then\n              VC_MSG_ERRO := 'Impossivel apurar valor do ICMS dos itens!';\n            elsif VN_AUX_CALC = -3 then\n              VC_MSG_ERRO := 'Valor apurado de ICMS dos itens diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n            else\n              R_ITENS.VLR_ICMS_CALC := ROUND(VN_AUX_CALC, 2);\n            end if;\n            if VC_MSG_ERRO is not null then\n              goto FIM;\n            end if;\n          end if;\n\n          -- ICMS substituic?o\n          if NVL(R_ITENS.ALQ_ICMS_SUBST, 0) > 0 then\n            VN_VLR_RATEADO := 0;\n\n            if NVL(:NEW.IND_FRETE_NOTA, '^') <>\n               NVL(:OLD.IND_FRETE_NOTA, '^') then\n              if :NEW.IND_FRETE_NOTA = 'Y' then\n                VN_VLR_RATEADO := VN_VLR_RATEADO + :NEW.VLR_FRETE +\n                                  :NEW.VLR_FRETE_RDP;\n              else\n                VN_VLR_RATEADO := VN_VLR_RATEADO -\n                                  (:OLD.VLR_FRETE + :OLD.VLR_FRETE_RDP);\n              end if;\n            end if;\n\n            if NVL(:NEW.IND_ACRESCIMO_BASE_ICMS, '^') <>\n               NVL(:OLD.IND_ACRESCIMO_BASE_ICMS, '^') then\n              if :NEW.IND_ACRESCIMO_BASE_ICMS = 'Y' then\n                VN_VLR_RATEADO := VN_VLR_RATEADO + :NEW.VLR_ACRESCIMO;\n              else\n                VN_VLR_RATEADO := VN_VLR_RATEADO - :OLD.VLR_ACRESCIMO;\n              end if;\n            end if;\n\n            if NVL(:NEW.IND_DESCONTO_BASE_ICMS, '^') <>\n               NVL(:OLD.IND_DESCONTO_BASE_ICMS, '^') then\n              if :NEW.IND_DESCONTO_BASE_ICMS = 'Y' then\n                VN_VLR_RATEADO := VN_VLR_RATEADO - :NEW.VLR_DESCONTO;\n              else\n                VN_VLR_RATEADO := VN_VLR_RATEADO + :OLD.VLR_DESCONTO;\n              end if;\n            end if;\n\n            R_ITENS.VLR_BASE_ICMS_SUBST_CALC := ROUND(R_ITENS.VLR_BASE_ICMS_SUBST_CALC +\n                                                      (VN_VLR_RATEADO /\n                                                      :NEW.VLR_TOTAL_PRODUTOS_CALC *\n                                                      R_ITENS.VLR_TOTAL_CALC),\n                                                      2);\n\n            VN_AUX_CALC := 0;\n            BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(R_ITENS.ALQ_ICMS_SUBST,\n                                                   R_ITENS.VLR_BASE_ICMS_SUBST_CALC,\n                                                   VN_AUX_CALC);\n            -- teste aok - 23/10/2013 ------------------------------------------\n            DBMS_OUTPUT.PUT_LINE('1.TRG_BIUD_BEG_CPR_NFE: ' ||\n                                 R_ITENS.ALQ_ICMS_SUBST || ' ' ||\n                                 R_ITENS.VLR_BASE_ICMS_SUBST_CALC || ' ' ||\n                                 VN_AUX_CALC);\n            --------------------------------------------------------------------\n            if VN_AUX_CALC = -1 then\n              VC_MSG_ERRO := 'Valores negativos no calculo do ICMS da substituic?o dos itens!';\n            elsif VN_AUX_CALC = -2 then\n              VC_MSG_ERRO := 'Impossivel apurar valor do ICMS da substituic?o dos itens!';\n            elsif VN_AUX_CALC = -3 then\n              VC_MSG_ERRO := 'Valor apurado de ICMS da substituic?o dos itens diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n            else\n              R_ITENS.VLR_ICMS_SUBST_CALC := ROUND(VN_AUX_CALC, 2);\n            end if;\n            if VC_MSG_ERRO is not null then\n              goto FIM;\n            end if;\n          end if;\n\n          -- IPI\n          if NVL(R_ITENS.ALQ_IPI, 0) > 0 then\n            VN_VLR_RATEADO := 0;\n\n            if NVL(:NEW.IND_FRETE_NOTA, '^') <>\n               NVL(:OLD.IND_FRETE_NOTA, '^') then\n              if :NEW.IND_FRETE_NOTA = 'Y' then\n                VN_VLR_RATEADO := VN_VLR_RATEADO + :NEW.VLR_FRETE +\n                                  :NEW.VLR_FRETE_RDP;\n              else\n                VN_VLR_RATEADO := VN_VLR_RATEADO -\n                                  (:OLD.VLR_FRETE + :OLD.VLR_FRETE_RDP);\n              end if;\n            end if;\n\n            if NVL(:NEW.IND_ACRESCIMO_BASE_IPI, '^') <>\n               NVL(:OLD.IND_ACRESCIMO_BASE_IPI, '^') then\n              if :NEW.IND_ACRESCIMO_BASE_IPI = 'Y' then\n                VN_VLR_RATEADO := VN_VLR_RATEADO + :NEW.VLR_ACRESCIMO;\n              else\n                VN_VLR_RATEADO := VN_VLR_RATEADO - :OLD.VLR_ACRESCIMO;\n              end if;\n            end if;\n\n            if NVL(:NEW.IND_DESCONTO_BASE_IPI, '^') <>\n               NVL(:OLD.IND_DESCONTO_BASE_IPI, '^') then\n              if :NEW.IND_DESCONTO_BASE_IPI = 'Y' then\n                VN_VLR_RATEADO := VN_VLR_RATEADO - :NEW.VLR_DESCONTO;\n              else\n                VN_VLR_RATEADO := VN_VLR_RATEADO + :OLD.VLR_DESCONTO;\n              end if;\n            end if;\n\n            R_ITENS.VLR_BASE_IPI_CALC := ROUND(R_ITENS.VLR_BASE_IPI_CALC +\n                                               (VN_VLR_RATEADO /\n                                               :NEW.VLR_TOTAL_PRODUTOS_CALC *\n                                               R_ITENS.VLR_TOTAL_CALC),\n                                               2);\n\n            VN_AUX_CALC := 0;\n            BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(R_ITENS.ALQ_IPI,\n                                                   R_ITENS.VLR_BASE_IPI_CALC,\n                                                   VN_AUX_CALC);\n\n            if VN_AUX_CALC = -1 then\n              VC_MSG_ERRO := 'Valores negativos no calculo do IPI dos itens!';\n            elsif VN_AUX_CALC = -2 then\n              VC_MSG_ERRO := 'Impossivel apurar valor do IPI dos itens!';\n            elsif VN_AUX_CALC = -3 then\n              VC_MSG_ERRO := '(Capa)Valor apurado de IPI dos itens diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n            else\n              R_ITENS.VLR_IPI_CALC := ROUND(VN_AUX_CALC, 2);\n            end if;\n            if VC_MSG_ERRO is not null then\n              goto FIM;\n            end if;\n\n          end if;\n\n          update BEG_CPR_PRE_NFE_ITEM\n             set VLR_BASE_ICMS_CALC       = R_ITENS.VLR_BASE_ICMS_CALC,\n                 VLR_ICMS_CALC            = R_ITENS.VLR_ICMS_CALC,\n                 VLR_BASE_ICMS_SUBST_CALC = R_ITENS.VLR_BASE_ICMS_SUBST_CALC,\n                 VLR_ICMS_SUBST_CALC      = R_ITENS.VLR_ICMS_SUBST_CALC,\n                 VLR_BASE_IPI_CALC        = R_ITENS.VLR_BASE_IPI_CALC,\n                 VLR_IPI_CALC             = R_ITENS.VLR_IPI_CALC\n           where BEG_CPR_PRE_NFE_ITEM_ID = R_ITENS.BEG_CPR_PRE_NFE_ITEM_ID;\n\n          :NEW.VLR_BASE_ICMS_CALC := :NEW.VLR_BASE_ICMS_CALC +\n                                     R_ITENS.VLR_BASE_ICMS_CALC;\n          :NEW.VLR_ICMS_CALC      := :NEW.VLR_ICMS_CALC +\n                                     R_ITENS.VLR_ICMS_CALC;\n          -- teste - aok - 23/10/2013 --------------------------------------------\n          DBMS_OUTPUT.PUT_LINE('2.trg_biud_cpr_nfe:' ||\n                               :NEW.VLR_BASE_ICMS_SUBST_CALC || ' + ' ||\n                               R_ITENS.VLR_BASE_ICMS_SUBST_CALC);\n          ------------------------------------------------------------------------\n          :NEW.VLR_BASE_ICMS_SUBST_CALC := :NEW.VLR_BASE_ICMS_SUBST_CALC +\n                                           R_ITENS.VLR_BASE_ICMS_SUBST_CALC;\n          :NEW.VLR_ICMS_SUBST_CALC      := :NEW.VLR_ICMS_SUBST_CALC +\n                                           R_ITENS.VLR_ICMS_SUBST_CALC;\n          :NEW.VLR_BASE_IPI_CALC        := :NEW.VLR_BASE_IPI_CALC +\n                                           R_ITENS.VLR_BASE_IPI_CALC;\n          :NEW.VLR_IPI_CALC             := :NEW.VLR_IPI_CALC +\n                                           R_ITENS.VLR_IPI_CALC;\n          --\n        end loop;\n        --\n        BEG_PCK_CPR_COMPRAS.VB_PROC_NFE := false;\n        --\n      end if; -- if not BEG_PCK_CPR_COMPRAS.VB_PROC_NFE_IT then\n      --\n    end if; -- if not BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM then\n    --\n  end if; -- if NVL(:NEW.IND_EMITIDA_FATURAMENTO, 'N') = 'N' then\n\n  --DBMS_OUTPUT.PUT_LINE(  NVL(:NEW.VLR_TOTAL_NOTA_CALC, 0)  ||' - '||\n  --                                 NVL(:OLD.VLR_DESPESAS_FINANCEIRAS, 0) ||' + '||\n  --                                 NVL(:OLD.VLR_OUTRAS_DESPESAS, 0)  ||' + '||\n  --                                 NVL(:OLD.VLR_IPI_CALC, 0)         ||' + ' ||\n  --                                 NVL(:OLD.VLR_ICMS_SUBST_CALC, 0)  ||' + '||\n  --                                 NVL(:NEW.VLR_DESPESAS_FINANCEIRAS, 0) ||' + ' ||\n  --                                 NVL(:NEW.VLR_OUTRAS_DESPESAS, 0)  ||' + ' ||\n  --                                 NVL(:NEW.VLR_IPI_CALC, 0)         ||' + ' ||\n  --                                 NVL(:NEW.VLR_ICMS_SUBST_CALC, 0));\n\n  -- Atualiza valor total da nota\n  if UPDATING -- aok - 31/05/2013 --\n   then\n    dbms_output.put_line('TRG_BIUD_BEG_CPR_NFE');\n    dbms_output.put_line('L1603: vlr_total_nota_calc new:' || :NEW.VLR_TOTAL_NOTA_CALC);\n    :NEW.VLR_TOTAL_NOTA_CALC := ROUND(NVL(:NEW.VLR_TOTAL_NOTA_CALC, 0) -\n                                      (NVL(:OLD.VLR_DESPESAS_FINANCEIRAS, 0) +\n                                       NVL(:OLD.VLR_OUTRAS_DESPESAS, 0) +\n                                       NVL(:OLD.VLR_IPI_CALC, 0) +\n                                       NVL(:OLD.VLR_ICMS_SUBST_CALC, 0)) +\n                                      (NVL(:NEW.VLR_DESPESAS_FINANCEIRAS, 0) +\n                                       NVL(:NEW.VLR_OUTRAS_DESPESAS, 0) +\n                                       NVL(:NEW.VLR_IPI_CALC, 0) +\n                                       NVL(:NEW.VLR_ICMS_SUBST_CALC, 0)),\n                                      2);\n    dbms_output.put_line('L1614: vlr_total_nota_calc new:' || :NEW.VLR_TOTAL_NOTA_CALC);\n  end if;\n  -- Valor faturado frente valor da nota\n  if NVL(:NEW.VLR_TOTAL_FATURADO, 0) > 0 then\n    if NVL(:NEW.VLR_TOTAL_FATURADO, 0) > NVL(:NEW.VLR_TOTAL_NOTA_CALC, 0)\n       and NVL(:NEW.VLR_TOTAL_FATURADO, 0) > NVL(:NEW.VLR_TOTAL_NOTA, 0) then\n      VC_MSG_ERRO := 'Valor total faturado maior que o valor total da nota!';\n      goto FIM;\n    end if;\n  end if;\n\n  -- Isento de ICMS\n  if NVL(:NEW.VLR_BASE_ISENTO_ICMS, 0) < 0 then\n    VC_MSG_ERRO := 'Valor da base isenta de ICMS negativo!';\n    goto FIM;\n  end if;\n\n  -- Isento de IPI\n  if NVL(:NEW.VLR_BASE_ISENTO_IPI, 0) < 0 then\n    VC_MSG_ERRO := 'Valor da base isenta de IPI negativo!';\n    goto FIM;\n  end if;\n\n  -- IR\n  VN_AUX_CALC := :NEW.VLR_IR;\n  BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:NEW.ALQ_IR,\n                                         :NEW.VLR_BASE_IR,\n                                         VN_AUX_CALC);\n  if VN_AUX_CALC = -1 then\n    VC_MSG_ERRO := 'Valores negativos no calculo do IR!';\n  elsif VN_AUX_CALC = -2 then\n    VC_MSG_ERRO := 'Impossivel apurar valor do IR!';\n  elsif VN_AUX_CALC = -3 then\n    VC_MSG_ERRO := 'Valor apurado de IR diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n  else\n    if NVL(:NEW.VLR_IR, 0) = 0 then\n      :NEW.VLR_ISSQN := VN_AUX_CALC;\n    end if;\n  end if;\n  if VC_MSG_ERRO is not null then\n    goto FIM;\n  end if;\n\n  -- INSS\n  VN_AUX_CALC := :NEW.VLR_INSS;\n  BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:NEW.ALQ_INSS,\n                                         :NEW.VLR_BASE_INSS,\n                                         VN_AUX_CALC);\n  if VN_AUX_CALC = -1 then\n    VC_MSG_ERRO := 'Valores negativos no calculo do INSS!';\n  elsif VN_AUX_CALC = -2 then\n    VC_MSG_ERRO := 'Impossivel apurar valor do INSS!';\n  elsif VN_AUX_CALC = -3 then\n    VC_MSG_ERRO := 'Valor apurado de INSS diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n  else\n    if NVL(:NEW.VLR_INSS, 0) = 0 then\n      :NEW.VLR_ISSQN := VN_AUX_CALC;\n    end if;\n  end if;\n  if VC_MSG_ERRO is not null then\n    goto FIM;\n  end if;\n  --\n\n  --\n  -- ISSQN\n  VN_AUX_CALC := :NEW.VLR_ISSQN;\n  BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:NEW.ALQ_ISSQN,\n                                         :NEW.VLR_BASE_ISSQN,\n                                         VN_AUX_CALC);\n  if VN_AUX_CALC = -1 then\n    VC_MSG_ERRO := 'Valores negativos no calculo do ISSQN!';\n  elsif VN_AUX_CALC = -2 then\n    VC_MSG_ERRO := 'Impossivel apurar valor do ISSQN!';\n  elsif VN_AUX_CALC = -3 then\n    VC_MSG_ERRO := 'Valor apurado de ISSQN diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n  else\n    if NVL(:NEW.VLR_ISSQN, 0) = 0 then\n      :NEW.VLR_ISSQN := VN_AUX_CALC;\n    end if;\n  end if;\n  if VC_MSG_ERRO is not null then\n    goto FIM;\n  end if;\n\n  -- aok - 07/04/2011\n/*  if not DELETING then\n    if NVL(:NEW.BEG_FIS_GNRE_ID, 0) = 0 then\n      open CGNRE;\n      fetch CGNRE\n        into RGNRE;\n      if CGNRE%found then\n        :NEW.BEG_FIS_GNRE_ID := RGNRE.BEG_FIS_GNRE_ID;\n      end if;\n    end if;\n  end if;\n  --*/\n\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend TRG_BIUD_BEG_CPR_NFE;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BU_CPR_PRE_NFE { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  --\n  VN_CONTA NUMBER(10) := 0;\n  --\n  cursor CORD is\n    select *\n      from BEG_CPR_ORDEM O\n     where O.BEG_CPR_ORDEM_ID = :NEW.BEG_CPR_ORDEM_ID;\n  RORD CORD%rowtype;\n  ------------------------------------------------------------------------------\n  cursor COC is\n    select OI.BEG_CPR_ORDEM_ID,\n           OI.BEG_CPR_ORDEM_ITEM_ID,\n           OI.ALQ_ICMS_SUBST,\n           OI.VLR_unitario,\n           NI.BEG_CPR_PRE_NFE_ID,\n           NI.BEG_CPR_PRE_NFE_ITEM_ID,\n           OI.QTD_SALDO,\n           NI.QTD\n      from BEG_CPR_ORDEM_ITEM OI, BEG_CPR_PRE_NFE_ITEM NI\n     where OI.BEG_CPR_ORDEM_ID = :NEW.BEG_CPR_ORDEM_ID\n       and NI.BEG_CPR_PRE_NFE_ID = :NEW.BEG_CPR_PRE_NFE_ID\n       and NI.BEG_PRODUTO_ID = OI.BEG_PRODUTO_ID\n       and NI.BEG_PRD_SKU_ID = OI.BEG_PRD_SKU_ID\n       and NI.QTD <= OI.QTD_SALDO\n       and NOT EXISTS\n     (SELECT COUNT(BEG_PRODUTO_ID), BEG_PRODUTO_ID, BEG_CPR_PRE_NFE_ID\n              FROM BEG_CPR_PRE_NFE_ITEM\n             WHERE BEG_CPR_PRE_NFE_ID = :NEW.BEG_CPR_PRE_NFE_ID\n             GROUP BY BEG_PRODUTO_ID, BEG_CPR_PRE_NFE_ID\n            HAVING COUNT(BEG_PRODUTO_ID) > 1);\n  --\n  CURSOR C1 IS\n    select T.BEG_CPG_CONTA_ID\n      from BEG_CPG_TIPO_TITULO t\n     where BEG_CPG_TIPO_TITULO_ID = :NEW.BEG_CPG_TIPO_TITULO_ID;\n  R1 C1%rowtype;\n\nbegin\n  --  \n  open C1;\n  fetch C1\n    into R1;\n  close C1;\n\n  IF R1.BEG_CPG_CONTA_ID <> :NEW.BEG_CPG_CONTA_ID THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Tipo título diferente da conta contabil. Verifique!');\n  END IF;\n\n  --\n  IF :new.BEG_CPR_ORDEM_ID IS not NULL and :new.docstatus <> 'CO' THEN\n    --\n    open CORD;\n    fetch CORD\n      into RORD;\n    close CORD;\n    --\n    IF RORD.AD_ORG_ID <> :NEW.AD_ORG_ID THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Ordem de compra não pertence a essa Filial!');\n    END IF;\n    --\n    :NEW.BEG_CONDICAO_PAGAMENTO_ID  := RORD.BEG_CONDICAO_PAGAMENTO_ID;\n    :NEW.BEG_VEN_FORMA_PAGAMENTO_ID := RORD.BEG_VEN_FORMA_PAGAMENTO_ID;\n    ------------------------------------------------------------------------------\n    BEG_PCK_CPR_COMPRAS.VB_PROC_ACERTO_ESPECIAL := true;\n    --\n    for ROC in COC loop\n      update BEG_CPR_PRE_NFE_ITEM NI\n         set NI.BEG_CPR_ORDEM_ID      = ROC.BEG_CPR_ORDEM_ID,\n             ni.qtd_ordem             = roc.qtd_saldo,\n             ni.perc_st_oc            = ROC.ALQ_ICMS_SUBST,\n             NI.VLR_ITEM_ORDEM_COMPRA = ROC.VLR_unitario\n       where NI.BEG_CPR_PRE_NFE_ITEM_ID = ROC.BEG_CPR_PRE_NFE_ITEM_ID;\n      VN_CONTA := VN_CONTA + 1;\n    end loop;\n    --\n    BEG_PCK_CPR_COMPRAS.VB_PROC_ACERTO_ESPECIAL := FALSE;\n    --\n  END IF;\n  --\nend;\n"}`;
    
    }
}
