
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAIXA_MOVIMENTO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_ISSQN_SUBITEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ACUMULADO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS { get; set; }
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
        public int VLR_BASE_IPI { get; set; }
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
        public int VLR_TOTAL_NOTA { get; set; }
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
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_CALCULO_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_CALCULO_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_PISCOFINS { get; set; }
            [StringLength(44)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE_NFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NFS { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE_NFS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// Tipo de lancamento: A - Automatico / M - Manual
        /// </summary>
        public string TP_LANCTO { get; set; }
        
        /// <summary>
        /// Tipo de movimento: D - Desconta / S - Soma / T - Transfere
        /// </summary>
        public string TP_MOVTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_HISTORICO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_PREVISTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_REALIZADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MOVIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string FECHADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PESSOA_OBRIGATORIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TITULO_CRC_OBRIGATORIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TITULO_CPG_OBRIGATORIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CONTA_CORRENTE_OBRIGATORIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL_ORIGEM_OBRIGATORIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CONTA_CORRENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTO_OBRIGATORIO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CC_MOVIMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LOTE_CPG_OBRIGATORIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_SALDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CRC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CPG { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CONFIRMACAO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string BEG_VW_FIN_CAIXA_HISTORICO_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica prestacao de servico
        /// </summary>
        public string P_SERVICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_CAIXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_CONV_REC_FAT_LOT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAIXA_DESPESA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAIXA_MOVIMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_ID { get; set; }

        [NotMapped]
        public string Trigger_ACC_TRG_BIUD_CAIXA_MOVIMENTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  cursor c_conta_new is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :NEW.BEG_CPG_CONTA_ID;\n   r_conta_new c_conta_new%rowtype;\n\n   cursor c_conta_old is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :OLD.BEG_CPG_CONTA_ID;\n   r_conta_old c_conta_old%rowtype;\n\nBEGIN\n\n  if inserting and :NEW.BEG_CPG_CONTA_ID IS NOT NULL THEN\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_new.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a inclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if deleting  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    if r_conta_old.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if updating and :NEW.BEG_CPG_CONTA_ID <> :OLD.BEG_CPG_CONTA_ID  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_old.ind_rj ='Y' and r_conta_new.ind_rj ='N' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n\n\nEND ACC_TRG_BIUD_CAIXA_MOVIMENTO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BU_DIE_DESP_INTEGRA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  v_id       number(10);\n  v_caixa_id number(10);\n  VNNF_ID    number(10);\n  \n  cursor c1 is\n  select s.*\n  from beg_fin_caixa_saldo s\n  where s.beg_fin_caixa_saldo_id = :new.beg_fin_caixa_saldo_id;\n  r1 c1%rowtype;\n  \n\n\nBEGIN\n  \n  if updating and :old.ind_confirmacao = 'Y' AND :NEW.IND_CONFIRMACAO ='N' AND :OLD.BEG_FIN_CAIXA_SALDO_ID IS NOT NULL THEN\n\n    RAISE_APPLICATION_ERROR(-20001,'Registro ja integrado nao permite alteração.');\n\n  END IF;\n\n  if updating and :new.ind_confirmacao = 'Y' and :OLD.BEG_FIN_CAIXA_SALDO_ID is null then\n\n    if :new.p_servico = 'Y' then\n       VNNF_ID := beg_fnc_ad_sequence('BEG_CPR_NFE');\n\n      INSERT INTO BEG_CPR_NFE\n        (BEG_CPR_NFE_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         NUMERO,\n         SERIE,\n         DT_ENTRADA,\n         DT_EMISSAO,\n         OBS,\n         BEG_VW_FORNECEDOR_ID,\n         VLR_BASE_ICMS,\n         VLR_BASE_OUTROS_ICMS,\n         VLR_BASE_ICMS_SUBST,\n         VLR_BASE_ISENTO_ICMS,\n         VLR_ICMS,\n         VLR_OUTROS_ICMS,\n         VLR_ICMS_SUBST,\n         VLR_BASE_IPI,\n         VLR_BASE_OUTROS_IPI,\n         VLR_BASE_ISENTO_IPI,\n         VLR_IPI,\n         VLR_OUTROS_IPI,\n         ALQ_IR,\n         VLR_BASE_IR,\n         VLR_IR,\n         ALQ_INSS,\n         VLR_BASE_INSS,\n         VLR_INSS,\n         ALQ_ISSQN,\n         VLR_BASE_ISSQN,\n         VLR_ISSQN,\n         VLR_FRETE,\n         VLR_SEGURO,\n         VLR_DESPESAS_FINANCEIRAS,\n         VLR_OUTRAS_DESPESAS,\n         PER_DESCONTO,\n         VLR_DESCONTO,\n         PER_ACRESCIMO,\n         VLR_ACRESCIMO,\n         VLR_TOTAL_PRODUTOS,\n         VLR_TOTAL_NOTA,\n         VLR_TOTAL_FATURADO,\n         VLR_COTACAO,\n         NRO_FATURA,\n         QTD_PARCELAS,\n         DIAS_VENCIMENTO,\n         BEG_VW_CFOP_ENT_ID,\n         BEG_VW_CFOP_SAI_ID,\n         BEG_EST_TP_ESPECIE_ID,\n         BEG_CPG_CONTA_ID,\n         VLR_BASE_CALCULO_PIS,\n         VLR_PIS,\n         VLR_BASE_CALCULO_COFINS,\n         VLR_COFINS,\n         VLR_TOTAL_PISCOFINS,\n         CHAVE_NFE,\n         BEG_CPG_TIPO_TITULO_ID,\n         DIE_ISSQN_SUBITEM_ID\n         )\n         VALUES\n         (VNNF_ID,\n         :new.AD_CLIENT_ID,\n         :new.beg_filial_id,\n         :new.ISACTIVE,\n         :new.CREATED,\n         :new.CREATEDBY,\n         :new.UPDATED,\n         :new.UPDATEDBY,\n         :new.NRO_NFS,\n         :new.SERIE_NFS,\n         trunc(sysdate),\n         :new.DT_EMISSAO,\n         :new.historico,\n         :new.BEG_VW_FORNECEDOR_ID,\n         :new.VLR_BASE_ICMS,\n         :new.VLR_BASE_OUTROS_ICMS,\n         :new.VLR_BASE_ICMS_SUBST,\n         :new.VLR_BASE_ISENTO_ICMS,\n         :new.VLR_ICMS,\n         :new.VLR_OUTROS_ICMS,\n         :new.VLR_ICMS_SUBST,\n         :new.VLR_BASE_IPI,\n         :new.VLR_BASE_OUTROS_IPI,\n         :new.VLR_BASE_ISENTO_IPI,\n         :new.VLR_IPI,\n         :new.VLR_OUTROS_IPI,\n         :new.ALQ_IR,\n         :new.VLR_BASE_IR,\n         :new.VLR_IR,\n         :new.ALQ_INSS,\n         :new.VLR_BASE_INSS,\n         :new.VLR_INSS,\n         :new.ALQ_ISSQN,\n         :new.VLR_BASE_ISSQN,\n         :new.VLR_ISSQN,\n         :new.VLR_FRETE,\n         :new.VLR_SEGURO,\n         :new.VLR_DESPESAS_FINANCEIRAS,\n         :new.VLR_OUTRAS_DESPESAS,\n         :new.PER_DESCONTO,\n         :new.VLR_DESCONTO,\n         :new.PER_ACRESCIMO,\n         :new.VLR_ACRESCIMO,\n         :new.vlr_movimento,\n         :new.vlr_movimento,\n         :new.vlr_movimento,\n         :new.VLR_COTACAO,\n         :new.NRO_NFS,\n         :new.QTD_PARCELAS,\n         :new.DIAS_VENCIMENTO,\n         :new.BEG_VW_CFOP_ENT_ID,\n         :new.BEG_VW_CFOP_SAI_ID,\n         :new.BEG_EST_TP_ESPECIE_ID,\n         :new.BEG_CPG_CONTA_ID,\n         :new.VLR_BASE_CALCULO_PIS,\n         :new.VLR_PIS,\n         :new.VLR_BASE_CALCULO_COFINS,\n         :new.VLR_COFINS,\n         :new.VLR_TOTAL_PISCOFINS,\n         :new.CHAVE_NFE,\n         :new.BEG_CPG_TIPO_TITULO_ID,\n         :new.DIE_ISSQN_SUBITEM_ID\n         );\n\n--         COMMIT;\n        INSERT INTO BEG_CPR_NFE_ITEM\n        (BEG_CPR_NFE_ITEM_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         BEG_CPR_NFE_ID,\n         BEG_PRODUTO_ID,\n         QTD,\n         VLR_UNITARIO,\n         SEQUENCIA)\n         VALUES\n         (beg_fnc_ad_sequence('BEG_CPR_NFE_ITEM'),\n         :new.AD_CLIENT_ID,\n         :new.beg_filial_id,\n         :new.ISACTIVE,\n         :new.CREATED,\n         :new.CREATEDBY,\n         :new.UPDATED,\n         :new.UPDATEDBY,\n         VNNF_ID,\n         2025748,\n         1,\n         :new.vlr_movimento,\n         1);\n\n\n\n    else\n      OPEN C1;\n  FETCH C1 INTO R1;\n  close c1;\n    v_caixa_id:=(beg_fnc_ad_sequence('BEG_FIN_CAIXA_MOVIMENTO'));\n    insert into BEG_FIN_CAIXA_MOVIMENTO\n      (BEG_FIN_CAIXA_MOVIMENTO_ID,\n       BEG_FIN_CAIXA_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       TP_LANCTO,\n       TP_MOVTO,\n       BEG_PESSOA_ID,\n       BEG_FIN_CAIXA_HISTORICO_ID,\n       BEG_FIN_CAIXA_CONTA_ID,\n       BEG_FILIAL_ID,\n       HISTORICO,\n       BEG_CRC_TITULO_ID,\n       BEG_CPG_TITULO_ID,\n       DATA_PREVISTA,\n       DATA_REALIZADA,\n       VLR_MOVIMENTO,\n       FECHADO,\n       PESSOA_OBRIGATORIA,\n       TITULO_CRC_OBRIGATORIO,\n       TITULO_CPG_OBRIGATORIO,\n       CONTA_CORRENTE_OBRIGATORIA,\n       FILIAL_ORIGEM_OBRIGATORIA,\n       BEG_FIN_CONTA_CORRENTE_ID,\n       DOCUMENTO_OBRIGATORIO,\n       DOCUMENTO,\n       BEG_FIN_CC_MOVIMENTO_ID,\n       LOTE_CPG_OBRIGATORIO,\n       DOCSTATUS,\n       BEG_FIN_CAIXA_SALDO_ID,\n       IND_CRC,\n       IND_CPG,\n       IND_CONFIRMACAO,\n       BEG_VW_FIN_CAIXA_HISTORICO_ID,\n       P_SERVICO,\n       BEG_VW_FIN_CAIXA_ID,\n       BEG_VEN_CONV_REC_FAT_LOT_ID,\n       IND_INTEGRADO\n       )\n    values\n      (v_caixa_id,\n       2000070,\n       :NEW.AD_CLIENT_ID,\n       0,--:NEW.AD_ORG_ID,\n       :NEW.ISACTIVE,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       :NEW.TP_LANCTO,\n       :NEW.TP_MOVTO,\n       :NEW.BEG_PESSOA_ID,\n       :NEW.BEG_FIN_CAIXA_HISTORICO_ID,\n       :NEW.BEG_FIN_CAIXA_CONTA_ID,\n       :NEW.BEG_FILIAL_ID,\n       :NEW.HISTORICO,\n       :NEW.BEG_CRC_TITULO_ID,\n       :NEW.BEG_CPG_TITULO_ID,\n        r1.DATA,\n        r1.DATA,\n       :NEW.VLR_MOVIMENTO,\n       :NEW.FECHADO,\n       :NEW.PESSOA_OBRIGATORIA,\n       :NEW.TITULO_CRC_OBRIGATORIO,\n       :NEW.TITULO_CPG_OBRIGATORIO,\n       :NEW.CONTA_CORRENTE_OBRIGATORIA,\n       :NEW.FILIAL_ORIGEM_OBRIGATORIA,\n       :NEW.BEG_FIN_CONTA_CORRENTE_ID,\n       :NEW.DOCUMENTO_OBRIGATORIO,\n       :NEW.DOCUMENTO,\n       :NEW.BEG_FIN_CC_MOVIMENTO_ID,\n       :NEW.LOTE_CPG_OBRIGATORIO,\n       :NEW.DOCSTATUS,\n       :NEW.BEG_FIN_CAIXA_SALDO_ID,\n       :NEW.IND_CRC,\n       :NEW.IND_CPG,\n       :NEW.IND_CONFIRMACAO,\n       :NEW.BEG_VW_FIN_CAIXA_HISTORICO_ID,\n       :NEW.P_SERVICO,\n       :NEW.BEG_VW_FIN_CAIXA_ID,\n       :NEW.BEG_VEN_CONV_REC_FAT_LOT_ID,\n       'Y'\n        );\n    end if;\n  end if;\nend die_trg_bu_die_desp_integra;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_CAIXA_MOVIMENTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\nBEGIN\n   \n IF :NEW.P_SERVICO = 'Y' THEN\n   IF :NEW.DT_EMISSAO > :NEW.DATA_REALIZADA THEN\n     RAISE_APPLICATION_ERROR(-20001,'Data de emissao da nf nao pode ser maior que a data do lote');\n   END IF;   \n \n   IF :NEW.DT_EMISSAO > trunc(sysdate) THEN\n     RAISE_APPLICATION_ERROR(-20001,'Data de emissao nao pode ser maior que o dia de hoje.');\n   END IF; \n \n END IF;\n  \n IF :NEW.P_SERVICO = 'Y' AND :NEW.DIE_ISSQN_SUBITEM_ID IS NULL THEN\n   RAISE_APPLICATION_ERROR(-20001,'Faltou informar a Descricao do Servico');\n END IF;\n\nIF INSERTING THEN\n  UPDATE DIE_CAIXA_DESPESA A SET\n     A.SALDO_REALIZADO = A.SALDO_REALIZADO + :NEW.VLR_MOVIMENTO\n  WHERE A.DIE_CAIXA_DESPESA_ID = :NEW.DIE_CAIXA_DESPESA_ID;\n\nEND IF;\n\nIF DELETING AND :OLD.DOCSTATUS <>'CO' THEN\n  UPDATE DIE_CAIXA_DESPESA A SET\n     A.SALDO_REALIZADO = A.SALDO_REALIZADO - :OLD.VLR_MOVIMENTO\n  WHERE A.DIE_CAIXA_DESPESA_ID = :OLD.DIE_CAIXA_DESPESA_ID;\nEND IF;\nIF DELETING AND :OLD.DOCSTATUS ='CO' THEN\n  RAISE_APPLICATION_ERROR(-20001,'Lote ja encerrado não permite exclusão');\nEND IF;\n\nIF UPDATING THEN\n  UPDATE DIE_CAIXA_DESPESA A SET\n     A.SALDO_REALIZADO = A.SALDO_REALIZADO + :NEW.VLR_MOVIMENTO - :OLD.VLR_MOVIMENTO\n  WHERE A.DIE_CAIXA_DESPESA_ID = :NEW.DIE_CAIXA_DESPESA_ID;\n\nEND IF;\n\n\nEND DIE_TRG_BIUD_CAIXA_MOVIMENTO;\n"}`;
    
    }
}
