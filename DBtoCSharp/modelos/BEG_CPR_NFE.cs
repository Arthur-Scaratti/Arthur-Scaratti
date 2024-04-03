
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPR_NFE
    {
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_NF_SEM_CONTRATO { get; set; }
        
        /// <summary>
        /// ID NFS RETORNO PELA EMISSAO DO PDV
        /// </summary>
        public int DIE_FAT_NFS_RET_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_CONTRATOS_ID { get; set; }
            [Required]
        /// <summary>
        /// Diementz - Indica se encontrou duplicara na devolução
        /// </summary>
        public string IND_DUP_DEVOL { get; set; }
        
        /// <summary>
        /// Diementz - valor pago pelo cliente ref. devolucao  - 07/01/2009 - AOK
        /// </summary>
        public int VLR_PAGO_NF_DEVOL { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Diementz - Tipo de venda nf devolucao
        /// </summary>
        public string TP_VENDA_DEVOL { get; set; }
        
        /// <summary>
        /// tipo da nota fiscal de entrada
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
        
        /// <summary>
        /// ID da conta contabil
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica tipo da devolução P-parcial, T-total
        /// </summary>
        public string TP_DEVOLUCAO { get; set; }
        
        /// <summary>
        /// id motivo da devolução
        /// </summary>
        public int DIE_MOTIVO_DEVOL_ID { get; set; }
        
        /// <summary>
        /// Id do vendedor da nf que esta sendo devolvida
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
        
        /// <summary>
        /// valor ref. devolucao por recolhimento, onde é abatido do total da NF ( devcli->vlpago)
        /// </summary>
        public int VALORPAGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_REDUCAO_ICMS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXCLUI_TODOS_ITENS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXCLUI_ITENS_INATIVOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROTOCOLO { get; set; }
        
        /// <summary>
        /// Para notas geradas a partir de saidas
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_CALCULO_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// ID do fornecedor
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// ID do CFOP (Codigo Fiscal de Operac?es e Prestac?es) de entrada da nota
        /// </summary>
        public int BEG_VW_CFOP_ENT_ID { get; set; }
        
        /// <summary>
        /// ID do CFOP (Codigo Fiscal de Operac?es e Prestac?es) de saida da nota
        /// </summary>
        public int BEG_VW_CFOP_SAI_ID { get; set; }
        
        /// <summary>
        /// ID do almoxarifado
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// ID da transportadora
        /// </summary>
        public int BEG_VW_TRANSPORTADORA_ID { get; set; }
        
        /// <summary>
        /// ID da unidade de medida
        /// </summary>
        public int BEG_PRD_UNIDADE_ID { get; set; }
        
        /// <summary>
        /// ID da transportadora de redespacho
        /// </summary>
        public int BEG_VW_REDESPACHO_ID { get; set; }
        
        /// <summary>
        /// ID da UF da placa do transporte de frete
        /// </summary>
        public int BEG_UF_ID { get; set; }
        
        /// <summary>
        /// ID da UF da placa do transporte de redespacho
        /// </summary>
        public int BEG_VW_UF_RDP_ID { get; set; }
        
        /// <summary>
        /// ID da condic?o de pagamento
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// ID da condic?o de pagamento para NFE especial
        /// </summary>
        public int BEG_VW_CPR_CND_PGTO_NFE_ID { get; set; }
        
        /// <summary>
        /// ID da forma de pagamento
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// ID do banco
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// ID da moeda
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o desconto diminui o total da nota
        /// </summary>
        public string IND_DESCONTO_NOTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o acrescimo aumenta o total da nota
        /// </summary>
        public string IND_ACRESCIMO_NOTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o desconto diminui a base de ICMS / ICMS subst. trib.
        /// </summary>
        public string IND_DESCONTO_BASE_ICMS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o acrescimo aumenta a base de ICMS / ICMS subst. trib.
        /// </summary>
        public string IND_ACRESCIMO_BASE_ICMS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o desconto diminui a base de IPI
        /// </summary>
        public string IND_DESCONTO_BASE_IPI { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o acrescimo aumenta a base de IPI
        /// </summary>
        public string IND_ACRESCIMO_BASE_IPI { get; set; }
        
        /// <summary>
        /// Tabela de classificacao do codigo de tributacao no municipio.
        /// </summary>
        public int DIE_ISSQN_SUBITEM_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID da nota fiscal de entrada
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
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
        /// Numero da nota fiscal de entrada
        /// </summary>
        public int NUMERO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Serie da nota fiscal de entrada
        /// </summary>
        public string SERIE { get; set; }
            [Required]
        /// <summary>
        /// Data de emiss?o da nota fiscal de entrada
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// Data de entrada da nota fiscal de entrada
        /// </summary>
        public string DT_ENTRADA { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado da base de calculo do ICMS
        /// </summary>
        public int VLR_BASE_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado da base de calculo do ICMS
        /// </summary>
        public int VLR_BASE_ICMS_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo de outros do ICMS
        /// </summary>
        public int VLR_BASE_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado da base de calculo do ICMS da substituic?o tributaria
        /// </summary>
        public int VLR_BASE_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado da base de calculo do ICMS da substituic?o tributaria
        /// </summary>
        public int VLR_BASE_ICMS_SUBST_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo isenta do ICMS
        /// </summary>
        public int VLR_BASE_ISENTO_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado do ICMS
        /// </summary>
        public int VLR_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado do ICMS
        /// </summary>
        public int VLR_ICMS_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total de outros do ICMS
        /// </summary>
        public int VLR_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado do ICMS da substituic?o tributaria
        /// </summary>
        public int VLR_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado do ICMS da substituic?o tributaria
        /// </summary>
        public int VLR_ICMS_SUBST_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado da base de calculo do IPI
        /// </summary>
        public int VLR_BASE_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado da base de calculo do IPI
        /// </summary>
        public int VLR_BASE_IPI_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo de outros do IPI
        /// </summary>
        public int VLR_BASE_OUTROS_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo isenta do IPI
        /// </summary>
        public int VLR_BASE_ISENTO_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado do IPI
        /// </summary>
        public int VLR_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado do IPI
        /// </summary>
        public int VLR_IPI_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total de outros do IPI
        /// </summary>
        public int VLR_OUTROS_IPI { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do IR
        /// </summary>
        public int ALQ_IR { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo do IR
        /// </summary>
        public int VLR_BASE_IR { get; set; }
            [Required]
        /// <summary>
        /// Valor total do IR
        /// </summary>
        public int VLR_IR { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do INSS
        /// </summary>
        public int ALQ_INSS { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo do INSS
        /// </summary>
        public int VLR_BASE_INSS { get; set; }
            [Required]
        /// <summary>
        /// Valor total do INSS
        /// </summary>
        public int VLR_INSS { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do ISSQN
        /// </summary>
        public int ALQ_ISSQN { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo do ISSQN
        /// </summary>
        public int VLR_BASE_ISSQN { get; set; }
            [Required]
        /// <summary>
        /// Valor total do ISSQN
        /// </summary>
        public int VLR_ISSQN { get; set; }
            [Required]
        /// <summary>
        /// Valor total do frete
        /// </summary>
        public int VLR_FRETE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo do frete: C - CIF / F - FOB / R - Retira / A - A Combinar
        /// </summary>
        public string TP_FRETE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Placa do veiculo do frete
        /// </summary>
        public string PLACA_VEICULO { get; set; }
            [Required]
        /// <summary>
        /// Valor total do frete de redespacho
        /// </summary>
        public int VLR_FRETE_RDP { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Tipo do frete de redespacho: C - CIF / F - FOB / R - Retira / A - A Combinar
        /// </summary>
        public string TP_FRETE_RDP { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Placa do veiculo do frete de redespacho
        /// </summary>
        public string PLACA_VEICULO_RDP { get; set; }
            [Required]
        /// <summary>
        /// Quantidade total de volumes
        /// </summary>
        public int QTD_VOLUMES { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Descric?o (marca) dos volumes
        /// </summary>
        public string DES_VOLUMES { get; set; }
        
        /// <summary>
        /// Numero dos volumes
        /// </summary>
        public int NRO_VOLUMES { get; set; }
            [Required]
        /// <summary>
        /// Peso bruto total dos volumes
        /// </summary>
        public int PESO_BRUTO { get; set; }
            [Required]
        /// <summary>
        /// Peso liquido total dos volumes
        /// </summary>
        public int PESO_LIQUIDO { get; set; }
            [Required]
        /// <summary>
        /// Valor total do seguro
        /// </summary>
        public int VLR_SEGURO { get; set; }
            [Required]
        /// <summary>
        /// Valor de despesas financeiras
        /// </summary>
        public int VLR_DESPESAS_FINANCEIRAS { get; set; }
            [Required]
        /// <summary>
        /// Valor total de outras despesas acessorias
        /// </summary>
        public int VLR_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// Percentual total de desconto
        /// </summary>
        public int PER_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// Valor total de desconto
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// Percentual total de acrescimo
        /// </summary>
        public int PER_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// Valor total de acrescimo
        /// </summary>
        public int VLR_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado dos produtos
        /// </summary>
        public int VLR_TOTAL_PRODUTOS { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado dos produtos
        /// </summary>
        public int VLR_TOTAL_PRODUTOS_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado da nota fiscal de entrada
        /// </summary>
        public int VLR_TOTAL_NOTA { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado da nota fiscal de entrada
        /// </summary>
        public int VLR_TOTAL_NOTA_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total faturado da nota fiscal de entrada
        /// </summary>
        public int VLR_TOTAL_FATURADO { get; set; }
            [Required]
        /// <summary>
        /// Valor da cotac?o da moeda
        /// </summary>
        public int VLR_COTACAO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Numero da fatura da nota fiscal de entrada
        /// </summary>
        public string NRO_FATURA { get; set; }
        
        /// <summary>
        /// Quantidade de parcelas
        /// </summary>
        public int QTD_PARCELAS { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Quantidade de dias para vencimento das parcelas
        /// </summary>
        public string DIAS_VENCIMENTO { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Status da nota fiscal de entrada: WC - Aguardando confirmac?o (Waiting Confirmation) / WP - Aguardando pagamento de TODOS os titulos/parcelas (Waiting Payment) / PA - TODOS os titulos/parcelas pagos (PAyed) / CO - Processamento completo e nota n?o possui titulos ( COmpleted) / CA - Nota cancelada (CAnceled)
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se foram gerados titulos do contas a pagar
        /// </summary>
        public string IND_TITULO_CPG { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que gerou autorizac?es de pagamento do contas a pagar
        /// </summary>
        public string IND_AUT_PGTO_CPG { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica nota fiscal especial
        /// </summary>
        public string IND_ESPECIAL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica frete na nota
        /// </summary>
        public string IND_FRETE_NOTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se a nota foi gerada por uma ou mais ordens de compra
        /// </summary>
        public string IND_NFE_ORDEM { get; set; }
            [Required]
        /// <summary>
        /// Numero da via que foi impressa
        /// </summary>
        public int NRO_VIA_IMPRESSA { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// Observac?o da nota fiscal de entrada
        /// </summary>
        public string OBS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Observac?o da despesa da nota fiscal de entrada
        /// </summary>
        public string OBS_OUTRAS_DESPESAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CST_CALCULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIS_COD_MODELO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_APROV_ICMS { get; set; }
        
        /// <summary>
        /// Id de lancamento da nota de despesa
        /// </summary>
        public int DIE_NFE_DESPESAS_ID { get; set; }
        
        /// <summary>
        /// Data de  canclamento da Nota fiscal
        /// </summary>
        public string DT_CANCELAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_ORDEM_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_GERADA_XML { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ST_OC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_INFORMADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_CALCULO_COFINS { get; set; }
        
        /// <summary>
        /// Para os valores PIS/COFINS das Obrigacoes
        /// </summary>
        public int VLR_TOTAL_PISCOFINS { get; set; }
            [StringLength(44)]
        /// <summary>
        /// chave da nota fiscal eletronica
        /// </summary>
        public string CHAVE_NFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FUNRURAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica prestacao de servico
        /// </summary>
        public string P_SERVICO { get; set; }
        
        /// <summary>
        /// Tarifa boleto
        /// </summary>
        public int TARIFA_DOC { get; set; }
        
        /// <summary>
        /// Id do modelo de documento fiscal
        /// </summary>
        public int BEG_FIS_COD_MODELO_ID { get; set; }
        
        /// <summary>
        /// Nota fiscal carregada pelo SIAD
        /// </summary>
        public string IND_CARGA_SIAD { get; set; }
        
        /// <summary>
        /// Nota emitida pelo faturamento
        /// </summary>
        public string IND_EMITIDA_FATURAMENTO { get; set; }
        
        /// <summary>
        /// Icms adicionado ao total da nota
        /// </summary>
        public string IND_ICMS_TOTAL_NOTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_PRE_NFS_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_LANCTO_CONTABIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_NFE { get; set; }

        [NotMapped]
        public string Trigger_ACC_TRG_BIUD_CPR_NFE { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  cursor c_conta_new is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :NEW.BEG_CPG_CONTA_ID;\n   r_conta_new c_conta_new%rowtype;\n\n   cursor c_conta_old is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :OLD.BEG_CPG_CONTA_ID;\n   r_conta_old c_conta_old%rowtype;\n\nBEGIN\n\n  if inserting and :NEW.BEG_CPG_CONTA_ID IS NOT NULL THEN\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_new.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a inclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if deleting  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    if r_conta_old.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if updating and :NEW.BEG_CPG_CONTA_ID <> :OLD.BEG_CPG_CONTA_ID  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_old.ind_rj ='Y' and r_conta_new.ind_rj ='N' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n\n\nEND ACC_TRG_BIUD_CPR_NFE;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_NFE_AI_CPR_NFE { get; set; } = `{"triggering_event":"INSERT OR DELETE","trigger_body":"DECLARE\n\n--PRAGMA AUTONOMOUS_TRANSACTION;\n  VN_DIE_NFE_DESPESAS_ID NUMBER(10);\n -- VN_ID                  NUMBER(10);\n  VNNF_ID                NUMBER(10);\n\n /* CURSOR C1 IS\n    SELECT *\n      FROM BEG_CPR_NFE C\n     WHERE C.BEG_CPR_NFE_ID = VN_DIE_NFE_DESPESAS_ID;\n  R1 C1%ROWTYPE;*/\n  ----\n\n  CURSOR C2 IS\n    SELECT CC.*\n      FROM BEG_CPG_CONTA CN, DIE_CTB_CONTA_CONTABIL CC\n     WHERE CC.DIE_CTB_CONTA_CONTABIL_ID = CN.DIE_CTB_CONTA_CONTABIL_ID\n       AND CN.BEG_CPG_CONTA_ID = :NEW.BEG_CPG_CONTA_ID;\n\n  R2 C2%ROWTYPE;\n  ----\n\nBEGIN\n\n  OPEN C2;\n  FETCH C2\n    INTO R2;\n  CLOSE C2;\nIF INSERTING THEN \n  IF (R2.IND_RATEIA_CP = 'Y' OR R2.IND_DESPESA = 'Y') AND :NEW.DIE_NFE_DESPESAS_ID IS NULL and :new.BEG_CPG_CONTA_ID not in (2001420,2001355) THEN\n  \n    VN_DIE_NFE_DESPESAS_ID := :NEW.BEG_CPR_NFE_ID;\n--    FOR R1 IN C1 LOOP\n    \n--      VN_ID := R1.DIE_NFE_DESPESAS_ID;\n    \n      VNNF_ID := beg_fnc_ad_sequence('DIE_NFE_DESPESAS');\n    \n      INSERT INTO DIE_NFE_DESPESAS\n        (DIE_NFE_DESPESAS_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         NRO_NFS,\n         SERIE_NFS,\n         DT_ENTRADA,\n         DT_EMISSAO,\n         OBS,\n         BEG_VW_FORNECEDOR_ID,\n         VLR_BASE_ICMS,\n         VLR_BASE_OUTROS_ICMS,\n         VLR_BASE_ICMS_SUBST,\n         VLR_BASE_ISENTO_ICMS,\n         VLR_ICMS,\n         VLR_OUTROS_ICMS,\n         VLR_ICMS_SUBST,\n         VLR_BASE_IPI,\n         VLR_BASE_OUTROS_IPI,\n         VLR_BASE_ISENTO_IPI,\n         VLR_IPI,\n         VLR_OUTROS_IPI,\n         ALQ_IR,\n         VLR_BASE_IR,\n         VLR_IR,\n         ALQ_INSS,\n         VLR_BASE_INSS,\n         VLR_INSS,\n         ALQ_ISSQN,\n         VLR_BASE_ISSQN,\n         VLR_ISSQN,\n         VLR_FRETE,\n         VLR_SEGURO,\n         VLR_DESPESAS_FINANCEIRAS,\n         VLR_OUTRAS_DESPESAS,\n         PER_DESCONTO,\n         VLR_DESCONTO,\n         PER_ACRESCIMO,\n         VLR_ACRESCIMO,\n         VLR_TOTAL_PRODUTOS,\n         VLR_TOTAL_NOTA,\n         VLR_TOTAL,\n         VLR_TOTAL_FATURADO,\n         VLR_FATURA,\n         VLR_COTACAO,\n         NRO_FATURA,\n         QTD_PARCELAS,\n         DIAS_VENCIMENTO,\n         BEG_VW_CFOP_ENT_ID,\n         BEG_VW_CFOP_SAI_ID,\n         BEG_EST_TP_ESPECIE_ID,\n         BEG_CPG_CONTA_ID,\n         VLR_BASE_CALCULO_PIS,\n         VLR_PIS,\n         VLR_BASE_CALCULO_COFINS,\n         VLR_COFINS,\n         VLR_TOTAL_PISCOFINS,\n         CHAVE_NFE,\n         BEG_CPG_TIPO_TITULO_ID,\n         BEG_CPR_NFE_ID,\n         IND_RATEIO,\n         IND_MARCADO,\n         IND_MODELO_55,\n         DIE_ISSQN_SUBITEM_ID,\n         DIE_FIN_CONTRATOS_ID)\n      VALUES\n        (VNNF_ID,\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         :NEW.ISACTIVE,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         :NEW.NUMERO,\n         :NEW.SERIE,\n         :NEW.DT_ENTRADA,\n         :NEW.DT_EMISSAO,\n         NULL, --:NEW.OBS,\n         :NEW.BEG_VW_FORNECEDOR_ID,\n         :NEW.VLR_BASE_ICMS,\n         :NEW.VLR_BASE_OUTROS_ICMS,\n         :NEW.VLR_BASE_ICMS_SUBST,\n         :NEW.VLR_BASE_ISENTO_ICMS,\n         :NEW.VLR_ICMS,\n         :NEW.VLR_OUTROS_ICMS,\n         :NEW.VLR_ICMS_SUBST,\n         :NEW.VLR_BASE_IPI,\n         :NEW.VLR_BASE_OUTROS_IPI,\n         :NEW.VLR_BASE_ISENTO_IPI,\n         :NEW.VLR_IPI,\n         :NEW.VLR_OUTROS_IPI,\n         :NEW.ALQ_IR,\n         :NEW.VLR_BASE_IR,\n         :NEW.VLR_IR,\n         :NEW.ALQ_INSS,\n         :NEW.VLR_BASE_INSS,\n         :NEW.VLR_INSS,\n         :NEW.ALQ_ISSQN,\n         :NEW.VLR_BASE_ISSQN,\n         :NEW.VLR_ISSQN,\n         :NEW.VLR_FRETE,\n         :NEW.VLR_SEGURO,\n         :NEW.VLR_DESPESAS_FINANCEIRAS,\n         :NEW.VLR_OUTRAS_DESPESAS,\n         :NEW.PER_DESCONTO,\n         :NEW.VLR_DESCONTO,\n         :NEW.PER_ACRESCIMO,\n         :NEW.VLR_ACRESCIMO,\n         :NEW.VLR_TOTAL_NOTA,\n         :NEW.VLR_TOTAL_NOTA,\n         :NEW.VLR_TOTAL_NOTA,\n         :NEW.VLR_TOTAL_NOTA,  \n         :NEW.VLR_TOTAL_NOTA,       \n         :NEW.VLR_COTACAO,\n         :NEW.NUMERO,\n         :NEW.QTD_PARCELAS,\n         :NEW.DIAS_VENCIMENTO,\n         :NEW.BEG_VW_CFOP_ENT_ID,\n         :NEW.BEG_VW_CFOP_SAI_ID,\n         :NEW.BEG_EST_TP_ESPECIE_ID,\n         :NEW.BEG_CPG_CONTA_ID,\n         :NEW.VLR_BASE_CALCULO_PIS,\n         :NEW.VLR_PIS,\n         :NEW.VLR_BASE_CALCULO_COFINS,\n         :NEW.VLR_COFINS,\n         :NEW.VLR_TOTAL_PISCOFINS,\n         :NEW.CHAVE_NFE,\n         :NEW.BEG_CPG_TIPO_TITULO_ID,\n         :NEW.BEG_CPR_NFE_ID,\n         'N',\n         'N',\n         'Y',\n         :NEW.DIE_ISSQN_SUBITEM_ID,\n         :NEW.DIE_FIN_CONTRATOS_ID);\n    \n  --            COMMIT;\n    \n    \n  :NEW.DIE_NFE_DESPESAS_ID := VNNF_ID;\n    \n--   END LOOP;\n  \n    ------\n  \n  END IF;\n  \n    /* UPDATE BEG_CPR_NFE SET\n     DIE_NFE_DESPESAS_ID = VNNF_ID\n     WHERE BEG_CPR_NFE_ID = :NEW.BEG_CPR_NFE_ID;*/\n     \n   /*  UPDATE DIE_NFE_DESPESAS SET\n     BEG_CPR_NFE_ID = :NEW.BEG_CPR_NFE_ID\n     WHERE DIE_NFE_DESPESAS_ID = VNNF_ID;*/\n     \n--    COMMIT;\n END IF;\n \n  /*IF DELETING AND :OLD.DIE_NFE_DESPESAS_ID IS NOT NULL THEN\n    \n    DELETE DIE_NFE_DESP_RATEIO \n    WHERE DIE_NFE_DESPESAS_ID = :OLD.DIE_NFE_DESPESAS_ID;\n    \n    DELETE DIE_NFE_DESPESAS \n    WHERE DIE_NFE_DESPESAS_ID = :OLD.DIE_NFE_DESPESAS_ID; \n    \n  END IF; */\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BU_BEG_CPR_NFE { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"DECLARE\n  --\n -- pragma autonomous_transaction;\n  --\n  CURSOR C1 IS\n    select n.beg_cpg_tipo_titulo_id, n.beg_cpg_conta_id\n      from beg_cpg_titulo n\n     where n.beg_cpr_nfe_id = :new.beg_cpr_nfe_id;\n  --\n  R_C1 c1%rowtype;\n  --\n  CURSOR C2 IS\n    select T.BEG_CPG_CONTA_ID\n      from BEG_CPG_TIPO_TITULO t\n     where BEG_CPG_TIPO_TITULO_ID = :NEW.BEG_CPG_TIPO_TITULO_ID;\n  R2 C2%rowtype;\n\n  --\nBEGIN\n  --\n  --\n  for r1 in c1 loop \n\n\n  IF (R_C1.beg_cpg_tipo_titulo_id <> :NEW.BEG_CPG_TIPO_TITULO_ID or R_C1.BEG_CPG_CONTA_ID <> :NEW.BEG_CPG_CONTA_ID)\n    and r_c1.beg_cpg_conta_id not in (2001403,2002204,2002209,2001405) THEN\n    RAISE_APPLICATION_ERROR(-20001,'Tipo de Titulo ou conta contabil diferente do titulo !  '||  :NEW.Numero ||' --   ');\n  END IF;\n\n\n  end loop;\n  \n open C2;\n  fetch C2\n    into R2;\n  close C2;\n\n  IF R2.BEG_CPG_CONTA_ID <> :NEW.BEG_CPG_CONTA_ID THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Tipo título diferente da conta contabil. Verifique!');\n  END IF;\n\n  \n  IF :OLD.DIE_NFE_DESPESAS_ID IS NOT NULL AND :NEW.DIE_NFE_DESPESAS_ID IS NULL THEN\n    \n   RAISE_APPLICATION_ERROR(-20001,\n                            'Nao e permitido excluir vinculo com Nf de Despesa. Verifique!');\n  \n  END IF;\n  \n  \nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_AIR_GERA_ITEM { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  --\n  VN_VLR_CUSTO_FRETE NUMBER(18,4);\n  --\n  VC_MSG_ERRO varchar2(200) := null; -- aok - 03/06/2013\n  --\n  cursor BUSCA_CHAVE is\n    select C.BEG_FAT_CTE_XML_ID\n      from BEG_FAT_CTE_XML C\n     where C.CHAVE_ACESSO = :NEW.CHAVE_NFE;\n  --\n  V_CHAVE BUSCA_CHAVE%rowtype;\n  --\n  cursor BUSCA_DADOS_ITEM is\n    select EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/ide/nCT',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') NUMERO,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/ide/serie',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') SERIE,\n           TO_DATE(SUBSTR(EXTRACTVALUE(X.ARQUIVO_XML,\n                                       '/cteProc/CTe/infCte/ide/dhEmi',\n                                       'xmlns=\"http://www.portalfiscal.inf.br/cte\"'),\n                          1,\n                          10),\n                   'rrrr-mm-dd') DT_EMISSAO,\n           F.BEG_VW_FORNECEDOR_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/ide/CFOP',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CFOP,\n           C.BEG_CFOP_ID,\n           ES.BEG_VW_CFOP_ENT_ID,\n           CES.BEG_FIS_CST_IPI_ID,\n           CES.BEG_FIS_CST_PIS_ID,\n           CES.BEG_FIS_CST_COFINS_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/ide/mod',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') MODELO,\n           M.BEG_FIS_COD_MODELO_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/protCTe/infProt/chCTe',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CHAVE,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/vPrest/vTPrest',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') VLR_TOTAL,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/imp/ICMS/ICMS00/CST',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CST_ICMS,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/imp/ICMS/ICMS00/vBC',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') BASE_ICMS,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/imp/ICMS/ICMS00/pICMS',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') ALIQ_ICMS,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/imp/ICMS/ICMS00/vICMS',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') VLR_ICMS\n      from BEG_FAT_CTE_XML    X,\n           BEG_VW_FORNECEDOR  F,\n           BEG_CFOP           C,\n           BEG_CFOP_ENT_SAI   ES,\n           BEG_CFOP           CES,\n           BEG_FIS_COD_MODELO M\n     where X.BEG_FAT_CTE_XML_ID = V_CHAVE.BEG_FAT_CTE_XML_ID\n       and F.CPFCNPJ =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/emit/CNPJ',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n       and C.CFOP =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/ide/CFOP',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n       and CES.BEG_CFOP_ID = ES.BEG_VW_CFOP_ENT_ID\n       and ES.BEG_VW_CFOP_SAI_ID(+) = C.BEG_CFOP_ID\n       and es.isactive(+) = 'Y' -- aok - 19/12/2013\n       and M.VALUE =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/ide/mod',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n       union all\n       select EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/ide/nCT',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') NUMERO,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/ide/serie',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') SERIE,\n           TO_DATE(SUBSTR(EXTRACTVALUE(X.ARQUIVO_XML,\n                                       '/cteOSProc/CTeOS/infCte/ide/dhEmi',\n                                       'xmlns=\"http://www.portalfiscal.inf.br/cte\"'),\n                          1,\n                          10),\n                   'rrrr-mm-dd') DT_EMISSAO,\n           F.BEG_VW_FORNECEDOR_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/ide/CFOP',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CFOP,\n           C.BEG_CFOP_ID,\n           ES.BEG_VW_CFOP_ENT_ID,\n           CES.BEG_FIS_CST_IPI_ID,\n           CES.BEG_FIS_CST_PIS_ID,\n           CES.BEG_FIS_CST_COFINS_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/ide/mod',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') MODELO,\n           M.BEG_FIS_COD_MODELO_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/protCTe/infProt/chCTe',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CHAVE,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/vPrest/vTPrest',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') VLR_TOTAL,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/imp/ICMS/ICMS00/CST',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CST_ICMS,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/imp/ICMS/ICMS00/vBC',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') BASE_ICMS,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/imp/ICMS/ICMS00/pICMS',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') ALIQ_ICMS,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/imp/ICMS/ICMS00/vICMS',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') VLR_ICMS\n      from BEG_FAT_CTE_XML    X,\n           BEG_VW_FORNECEDOR  F,\n           BEG_CFOP           C,\n           BEG_CFOP_ENT_SAI   ES,\n           BEG_CFOP           CES,\n           BEG_FIS_COD_MODELO M\n     where X.BEG_FAT_CTE_XML_ID = V_CHAVE.BEG_FAT_CTE_XML_ID\n       and F.CPFCNPJ =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/emit/CNPJ',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n       and C.CFOP =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/ide/CFOP',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n       and CES.BEG_CFOP_ID = ES.BEG_VW_CFOP_ENT_ID\n       and ES.BEG_VW_CFOP_SAI_ID(+) = C.BEG_CFOP_ID\n       and es.isactive(+) = 'Y' -- aok - 19/12/2013\n       and ES.IND_PADRAO = 'Y'\n       and M.VALUE =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/ide/mod',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"')                 \n                        ;\n  ------------------------------------------------------------------------------\n  V_BUSCA_DADOS_ITEM BUSCA_DADOS_ITEM%rowtype;\n  --\n  --  notas\n  ---\n  cursor BUSCA_NOTAS is\n    select EXTRACTVALUE(value(NOTAS),\n                        '/infNF/mod',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') NODELO_NF,\n           EXTRACTVALUE(value(NOTAS),\n                        '/infNF/nDoc',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') NUMERO_NF,\n           N.BEG_FAT_NFS_ID,\n           N.BEG_VW_PESSOA_ENTREGA_ID,\n           to_number(trim(replace(NVL(EXTRACTVALUE(value(NOTAS),\n                            '/infNF/vNF',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"'),\n               0),'.',',')),'9999999999999D0000') VLR_NF,\n           to_number(trim(replace(NVL(EXTRACTVALUE(value(NOTAS),\n                            '/infNF/vProd',\n                            'xmlns=\"http://www.portalfiscal.inf.br/cte\"'),\n               P.VL_TOTAL_PROD),'.',',')),'9999999999999D0000') VLR_PRODUTO,\n           TO_DATE(EXTRACTVALUE(value(NOTAS),\n                                '/infNF/dEmi',\n                                'xmlns=\"http://www.portalfiscal.inf.br/cte\"'),\n                   'rrrr-mm-dd') DT_EMISSAO\n      from BEG_FAT_CTE_XML X,\n           BEG_FAT_NFS N,\n           BEG_FAT_PRE_NFS P,\n           table(XMLSEQUENCE(EXTRACT(X.ARQUIVO_XML,\n                                     '/cteProc/CTe/infCte/rem/infNF',\n                                     'xmlns=\"http://www.portalfiscal.inf.br/cte\"'))) NOTAS\n     where X.BEG_FAT_CTE_XML_ID = V_CHAVE.BEG_FAT_CTE_XML_ID\n       and N.NRO_NFS =\n           EXTRACTVALUE(value(NOTAS),\n                        '/infNF/nDoc',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n       and N.SERIE_NFS = '1'\n       and P.BEG_FAT_PRE_NFS_ID = N.BEG_FAT_NFS_ID\n       union all\n       select '55' NODELO_NF,\n           to_char(n.nro_nfs) NUMERO_NF,\n           N.BEG_FAT_NFS_ID,\n           N.BEG_VW_PESSOA_ENTREGA_ID,\n           n.vl_total_nfs VLR_NF,\n           n.vl_total_prod VLR_PRODUTO,\n           n.dt_emissao DT_EMISSAO\n      from BEG_FAT_CTE_XML X,\n           table(XMLSEQUENCE(EXTRACT(X.ARQUIVO_XML,\n                                     '/cteProc/CTe/infCte/infCTeNorm/infDoc/infNF',\n                                     'xmlns=\"http://www.portalfiscal.inf.br/cte\"'))) NOTAS,\n           BEG_FAT_NFE_XML nx,\n           beg_fat_nfs n\n     where X.BEG_FAT_CTE_XML_ID = V_CHAVE.BEG_FAT_CTE_XML_ID\n       and N.NRO_NFS =\n           EXTRACTVALUE(value(NOTAS),\n                        '/infNF/nDoc',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n       and N.SERIE_NFS = '1'\n        and   n.beg_fat_nfs_id = nx.beg_fat_nfs_id(+)\n       union all\n       select '55' NODELO_NF,\n           to_char(n.nro_nfs) NUMERO_NF,\n           N.BEG_FAT_NFS_ID,\n           N.BEG_VW_PESSOA_ENTREGA_ID,\n           n.vl_total_nfs VLR_NF,\n           n.vl_total_prod VLR_PRODUTO,\n           n.dt_emissao DT_EMISSAO\n      from BEG_FAT_CTE_XML X,\n           table(XMLSEQUENCE(EXTRACT(X.ARQUIVO_XML,\n                                     '/cteProc/CTe/infCte/infCTeNorm/infDoc/infNFe',\n                                     'xmlns=\"http://www.portalfiscal.inf.br/cte\"'))) NOTAS,\n           BEG_FAT_NFE_XML nx,\n           beg_fat_nfs n\n     where X.BEG_FAT_CTE_XML_ID = V_CHAVE.BEG_FAT_CTE_XML_ID\n     and   nx.chave_acesso = EXTRACTVALUE(value(NOTAS),\n                                '/infNFe/chave',\n                                'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n     and   n.beg_fat_nfs_id = nx.beg_fat_nfs_id(+)\n     union\n     select '55' NODELO_NF,\n           to_char(n.nro_nfs) NUMERO_NF,\n           N.BEG_FAT_NFS_ID,\n           N.BEG_VW_PESSOA_ENTREGA_ID,\n           n.vl_total_nfs VLR_NF,\n           n.vl_total_prod VLR_PRODUTO,\n           n.dt_emissao DT_EMISSAO\n      from BEG_FAT_CTE_XML X,\n           table(XMLSEQUENCE(EXTRACT(X.ARQUIVO_XML,\n                                     '/cteProc/CTe/infCte/rem/infNFe',\n                                     'xmlns=\"http://www.portalfiscal.inf.br/cte\"'))) NOTAS,\n           BEG_FAT_NFE_XML nx,\n           beg_fat_nfs n\n     where X.BEG_FAT_CTE_XML_ID = V_CHAVE.BEG_FAT_CTE_XML_ID\n     and   nx.chave_acesso = EXTRACTVALUE(value(NOTAS),\n                                '/infNFe/chave',\n                                'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n     and   n.beg_fat_nfs_id = nx.beg_fat_nfs_id;\n  --\n  V_NOTAS BUSCA_NOTAS%rowtype;\n  --\n  cursor BUSCA_COMPLEMENTOS is\n    select EXTRACTVALUE(value(COMPOSICAO),\n                        '/Comp/xNome',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') NOME,\n           EXTRACTVALUE(value(COMPOSICAO),\n                        '/Comp/vComp',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') VLR_COMPOSICAO\n      from BEG_FAT_CTE_XML X,\n           table(XMLSEQUENCE(EXTRACT(X.ARQUIVO_XML,\n                                     '/cteProc/CTe/infCte/vPrest/Comp',\n                                     'xmlns=\"http://www.portalfiscal.inf.br/cte\"'))) COMPOSICAO\n     where X.BEG_FAT_CTE_XML_ID = V_CHAVE.BEG_FAT_CTE_XML_ID;\n  --\n  V_COMPLEMENTO BUSCA_COMPLEMENTOS%rowtype;\n  --\nbegin\n  -- aok - 03/06/2013 ----------------------------\n  if :NEW.IND_EMITIDA_FATURAMENTO = 'Y' then\n    goto FIM;\n  end if;\n  ------------------------------------------------\n  if :NEW.CHAVE_NFE is not null\n     and\n     :NEW.BEG_TIPO_NF_ID =\n     BEG_FNC_RETORNA_PARAM_GERAL('Geral', null, 'CONHECIMENTO_FRETE', null) then\n    open BUSCA_CHAVE;\n    fetch BUSCA_CHAVE\n      into V_CHAVE;\n    if BUSCA_CHAVE%found then\n      open BUSCA_DADOS_ITEM;\n      fetch BUSCA_DADOS_ITEM\n        into V_BUSCA_DADOS_ITEM;\n      close BUSCA_DADOS_ITEM;\n      -- item frete 2513041\n      --- sku 2013151\n      BEG_PCK_CPR_COMPRAS.VB_PROC_ACERTO_ESPECIAL := true;\n      insert into BEG_CPR_NFE_ITEM\n        (BEG_CPR_NFE_ITEM_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         SEQUENCIA,\n         QTD,\n         DES_ITEM_FORNECEDOR,\n         VLR_UNITARIO,\n         VLR_TOTAL,\n         VLR_TOTAL_CALC,\n         ALQ_ICMS,\n         VLR_BASE_ICMS,\n         VLR_BASE_ICMS_CALC,\n         VLR_ICMS,\n         VLR_ICMS_CALC,\n         BEG_CPR_NFE_ID,\n         BEG_PRODUTO_ID,\n         BEG_PRD_SKU_ID,\n         BEG_VW_CFOP_ENT_ID,\n         BEG_VW_CFOP_SAI_ID,\n         BEG_PRD_NCM_ID,\n         BEG_FIS_TRIB_ICMS_ID,\n         BEG_FIS_ORIGEM_MERC_ID,\n         BEG_FIS_CST_PIS_ID,\n         BEG_FIS_CST_IPI_ID,\n         BEG_FIS_CST_COFINS_ID)\n      values\n        (BEG_FNC_AD_SEQUENCE('BEG_CPR_NFE_ITEM'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'Y',\n         sysdate,\n         :NEW.CREATEDBY,\n         sysdate,\n         :NEW.UPDATEDBY,\n         1,\n         1,\n         'FRETE',\n         V_BUSCA_DADOS_ITEM.VLR_TOTAL,\n         V_BUSCA_DADOS_ITEM.VLR_TOTAL,\n         V_BUSCA_DADOS_ITEM.VLR_TOTAL,\n         NVL(V_BUSCA_DADOS_ITEM.ALIQ_ICMS, 0),\n         NVL(V_BUSCA_DADOS_ITEM.BASE_ICMS, 0),\n         NVL(V_BUSCA_DADOS_ITEM.BASE_ICMS, 0),\n         NVL(V_BUSCA_DADOS_ITEM.VLR_ICMS, 0),\n         NVL(V_BUSCA_DADOS_ITEM.VLR_ICMS, 0),\n         :NEW.BEG_CPR_NFE_ID,\n         2038667, -- BEG_PRODUTO_ID -- Item frete\n         2040189, -- BEG_PRD_SKU_ID --\n         V_BUSCA_DADOS_ITEM.BEG_VW_CFOP_ENT_ID,\n         V_BUSCA_DADOS_ITEM.BEG_CFOP_ID,\n         2000015, -- BEG_PRD_NCM_ID\n         1000000, -- BEG_FIS_TRIB_ICMS_ID\n         1000000, -- BEG_FIS_ORIGEM_MERC_ID\n         V_BUSCA_DADOS_ITEM.BEG_FIS_CST_PIS_ID,\n         V_BUSCA_DADOS_ITEM.BEG_FIS_CST_IPI_ID,\n         V_BUSCA_DADOS_ITEM.BEG_FIS_CST_COFINS_ID);\n\n    end if;\n    close BUSCA_CHAVE;\n    open BUSCA_NOTAS;\n    loop\n      fetch BUSCA_NOTAS\n        into V_NOTAS;\n      exit when BUSCA_NOTAS%notfound;\n      --\n      VN_VLR_CUSTO_FRETE := NVL(VN_VLR_CUSTO_FRETE,0) + (:NEW.VLR_TOTAL_NOTA * 9.25) / 100;\n      --\n      insert into BEG_CPR_CFR_NFE\n        (BEG_CPR_CFR_NFE_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         NUMERO,\n         SERIE,\n         DT_EMISSAO,\n         VLR_TOTAL_NOTA,\n         VLR_TOTAL_PRODUTOS,\n         NRO_VOLUMES,\n         PESO_BRUTO,\n         PESO_LIQUIDO,\n         BEG_CPR_NFE_ID,\n         BEG_VW_FORNECEDOR_ID,\n         BEG_VW_CPR_NFE_ID,\n         IND_ENTSAI,\n         BEG_VW_PESSOA_ENTREGA_ID,\n         BEG_FAT_NFS_ID,\n         VLR_CUSTO_FRETE,\n         vlr_custo)\n      values\n        (BEG_FNC_AD_SEQUENCE('BEG_CPR_CFR_NFE'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'Y',\n         sysdate,\n         :NEW.CREATEDBY,\n         sysdate,\n         :NEW.UPDATEDBY,\n         V_NOTAS.NUMERO_NF,\n         '1',\n         V_NOTAS.DT_EMISSAO,\n         V_NOTAS.VLR_NF,\n         V_NOTAS.VLR_PRODUTO,\n         0, --NRO_VOLUMES\n         0, --PESO_BRUTO\n         0, --PESO_LIQUIDO\n         :NEW.BEG_CPR_NFE_ID,\n         :NEW.BEG_VW_FORNECEDOR_ID,\n         null, ---BEG_VW_CPR_NFE_ID\n         'S', --IND_ENTSAI\n         V_NOTAS.BEG_VW_PESSOA_ENTREGA_ID,\n         V_NOTAS.BEG_FAT_NFS_ID,\n         :new.vlr_total_nota - VN_VLR_CUSTO_FRETE,\n         ((:new.vlr_total_nota - VN_VLR_CUSTO_FRETE) / V_NOTAS.VLR_NF) * 100\n         );\n\n    end loop;\n    close BUSCA_NOTAS;\n    open BUSCA_COMPLEMENTOS;\n    loop\n      fetch BUSCA_COMPLEMENTOS\n        into V_COMPLEMENTO;\n      exit when BUSCA_COMPLEMENTOS%notfound;\n      insert into BEG_CPR_COMP_FRETE\n        (BEG_CPR_COMP_FRETE_ID,\n         BEG_CPR_NFE_ID,\n         value,\n         VLR_COMPOSICAO,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         ISACTIVE)\n      values\n        (BEG_FNC_AD_SEQUENCE('BEG_CPR_COMP_FRETE'),\n         :NEW.BEG_CPR_NFE_ID,\n         V_COMPLEMENTO.NOME,\n         V_COMPLEMENTO.VLR_COMPOSICAO,\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         sysdate,\n         :NEW.CREATEDBY,\n         sysdate,\n         :NEW.UPDATEDBY,\n         'Y');\n\n    end loop;\n    close BUSCA_COMPLEMENTOS;\n    --\n    BEG_PCK_CPR_COMPRAS.VB_PROC_ACERTO_ESPECIAL := false;\n    --\n  end if;\n  --\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n  --\nend BEG_TRG_AIR_GERA_ITEM;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_CPR_NFE { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  /*---------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que valida campos da nota fiscal de entrada.\n  Modulo.......: CPR - Compras\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  04/07/2006  Tiago Gabriel  Criac?o.\n  12/07/2006  Tiago Gabriel  -> Adicionada gerac?o dos itens quando uma ordem de compra da Nacional\n                             for informada;\n                             -> Passou a disparar a delec?o para validac?o.\n   31/07/2006  Tiago Gabriel  Adicionada inicializac?o dos valores da tabela de precos de\n                              suprimento (fornecedor) para calculo do custo.\n   28/08/2006  Tiago Gabriel  Adicionada verificac?o quando a troca de CFOP de entrada pelo de saida.\n   18/09/2006  Tiago Gabriel  A gerac?o de notas por ordem de compra passou para a package\n                              BEG_PCK_CPR_COMPRAS na procedure PRC_GERA_NFE\n   15/10/2006  Tiago Gabriel  Retirado processamento de ordens de compra Nacional\n   03/11/2006  Tiago Gabriel  Adicionadas flags referente aos descontos e acrescimos.\n   10/09/2010  Aroldo O.Krul  Upper do campo de serie\n   02/12/2010  Aroldo O.Krul  Inserido teste de isactive e padrao em beg_cfop_ent_sai\n   17/02/2011  Aroldo O.Krul  Alterado a regra da montagem da data da quinzena\n   11/03/2011  Aroldo O.Krul  no cursor c2 - foi inserido no teste do valor em aberto a soma de\n                              vlr_outros_acrescimos.\n  ---------------------------------------------------------------------------------------------------*/\n  VC_MSG_ERRO                varchar2(200);\n  VN_AUX_ALQ                 number(18, 4);\n  VN_AUX_BASE                number(18, 4);\n  VN_AUX_CALC                number(18, 4);\n  VN_VLR_RATEADO             number(18, 4);\n  VN_DUMMY                   number;\n  VN_BEG_EST_ALMOXARIFADO_ID BEG_EST_ALMOXARIFADO.BEG_EST_ALMOXARIFADO_ID%type;\n  VC_CHAVE_ACESSO            VARCHAR2(44);\n  --VN_AUX_VLR_ICMS            number;\n  --vn_teste                   varchar2(10);\n  --vn_teste1                  varchar2(10);\n  --\n  --  Verifica duplicidade de nota fiscal\n  --\n  cursor C1 is\n    select 1\n      from BEG_CPR_NFE NFE\n     where NFE.NUMERO = :new.NUMERO\n       and NFE.SERIE = :new.SERIE\n       and NFE.BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID\n       and NFE.DT_EMISSAO = :new.DT_EMISSAO;\n  --\n  -- Verifica se todos os titulos vinculados a nota est¿o abertos\n  --\n  -- aok - 11/03/2011 ==>>  + t.vlr_outros_acrescimos\n  cursor C2 is\n    select 1\n      from BEG_CPG_TITULO T\n     where T.BEG_CPR_NFE_ID = :old.BEG_CPR_NFE_ID\n       and T.VLR_TITULO - T.VLR_DESCONTO + T.VLR_OUTRAS_DEDUCOES +\n           T.VLR_OUTROS_ACRESCIMOS <> T.VLR_ABERTO\n          --  and t.VLR_TITULO  <> t.VLR_ABERTO -- aok -- 14/09/2010\n       and T.DOCSTATUS <> 'WC';\n  --\n  cursor BUSCA_ITENS_ENTRADA is\n    select *\n      from BEG_CPR_NFE_ITEM\n     where BEG_CPR_NFE_ID = :old.BEG_CPR_NFE_ID;\n  --\n  V_ITENS_ENTRADA BUSCA_ITENS_ENTRADA%rowtype;\n  --\n  cursor C_FECH_CONT is\n    select max(C.DT_FINAL) DT_FINAL\n      from BEG_FECH_CONTABIL C\n     WHERE C.ISACTIVE = 'Y';\n  --\n  R_FECH_CONT C_FECH_CONT%rowtype;\n  --\n  cursor C_FECH_CONT1 is\n    select ind_escrita\n      from BEG_FECH_CONTABIL C\n     where c.dt_final = R_FECH_CONT.DT_FINAL\n       AND C.ISACTIVE = 'Y';\n  --\n  R_FECH_CONT1 C_FECH_CONT1%rowtype;\n\n  ----\n  cursor C_FECH_CONT2 is\n    select max(C.DT_FINAL) DT_FINAL\n      from BEG_FECH_CONTABIL C\n     WHERE C.ISACTIVE = 'Y'\n       and c.ind_escrita = 'N';\n  --\n  R_FECH_CONT2 C_FECH_CONT2%rowtype;\n  ----\n  cursor BUSCA_CHAVE is\n    select C.BEG_FAT_CTE_XML_ID\n      from BEG_FAT_CTE_XML C\n     where C.CHAVE_ACESSO = VC_CHAVE_ACESSO; --trim(:NEW.CHAVE_NFE);\n  --\n  V_CHAVE BUSCA_CHAVE%rowtype;\n  ---\n  cursor CBUSCA_DADOS_CTE is\n    select EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/ide/nCT',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') NUMERO,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/ide/serie',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') SERIE,\n           TO_DATE(SUBSTR(EXTRACTVALUE(X.ARQUIVO_XML,\n                                       '/cteProc/CTe/infCte/ide/dhEmi',\n                                       'xmlns=\"http://www.portalfiscal.inf.br/cte\"'),\n                          1,\n                          10),\n                   'rrrr-mm-dd') DT_EMISSAO,\n           F.BEG_VW_FORNECEDOR_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/ide/CFOP',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CFOP,\n           C.BEG_CFOP_ID,\n           ES.BEG_VW_CFOP_ENT_ID,\n           CES.BEG_FIS_CST_IPI_ID,\n           CES.BEG_FIS_CST_PIS_ID,\n           CES.BEG_FIS_CST_COFINS_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/ide/mod',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') MODELO,\n           M.BEG_FIS_COD_MODELO_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/protCTe/infProt/chCTe',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CHAVE,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/vPrest/vTPrest',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') VLR_TOTAL,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/imp/ICMS/ICMS00/CST',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CST_ICMS,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/imp/ICMS/ICMS00/vBC',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') BASE_ICMS,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/imp/ICMS/ICMS00/pICMS',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') ALIQ_ICMS,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/imp/ICMS/ICMS00/vICMS',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') VLR_ICMS,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/infCTeNorm/infCarga/vCarga',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') VCARGA\n      from BEG_FAT_CTE_XML    X,\n           BEG_VW_FORNECEDOR  F,\n           BEG_CFOP           C,\n           BEG_CFOP_ENT_SAI   ES,\n           BEG_CFOP           CES,\n           BEG_FIS_COD_MODELO M\n     where X.BEG_FAT_CTE_XML_ID = V_CHAVE.BEG_FAT_CTE_XML_ID\n       and F.CPFCNPJ =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/emit/CNPJ',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n       and C.CFOP =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/ide/CFOP',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n       and CES.BEG_CFOP_ID = ES.BEG_VW_CFOP_ENT_ID\n       and ES.BEG_VW_CFOP_SAI_ID(+) = C.BEG_CFOP_ID\n       and ES.ISACTIVE(+) = 'Y' -- aok - 19/12/2013\n       and M.VALUE =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteProc/CTe/infCte/ide/mod',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n    union all\n    select EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/ide/nCT',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') NUMERO,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/ide/serie',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') SERIE,\n           TO_DATE(SUBSTR(EXTRACTVALUE(X.ARQUIVO_XML,\n                                       '/cteOSProc/CTeOS/infCte/ide/dhEmi',\n                                       'xmlns=\"http://www.portalfiscal.inf.br/cte\"'),\n                          1,\n                          10),\n                   'rrrr-mm-dd') DT_EMISSAO,\n           F.BEG_VW_FORNECEDOR_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/ide/CFOP',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CFOP,\n           C.BEG_CFOP_ID,\n           ES.BEG_VW_CFOP_ENT_ID,\n           CES.BEG_FIS_CST_IPI_ID,\n           CES.BEG_FIS_CST_PIS_ID,\n           CES.BEG_FIS_CST_COFINS_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/ide/mod',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') MODELO,\n           M.BEG_FIS_COD_MODELO_ID,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/protCTe/infProt/chCTe',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CHAVE,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/vPrest/vTPrest',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') VLR_TOTAL,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/imp/ICMS/ICMSSN/CST',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') CST_ICMS,\n           '0' BASE_ICMS,\n           '0' ALIQ_ICMS,\n           '0' VLR_ICMS,\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/infCTeNorm/infCarga/vCarga',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"') VCARGA\n      from BEG_FAT_CTE_XML    X,\n           BEG_VW_FORNECEDOR  F,\n           BEG_CFOP           C,\n           BEG_CFOP_ENT_SAI   ES,\n           BEG_CFOP           CES,\n           BEG_FIS_COD_MODELO M\n     where X.BEG_FAT_CTE_XML_ID = V_CHAVE.BEG_FAT_CTE_XML_ID\n       and F.CPFCNPJ =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/emit/CNPJ',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n       and C.CFOP =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/ide/CFOP',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"')\n       and CES.BEG_CFOP_ID = ES.BEG_VW_CFOP_ENT_ID\n       and ES.BEG_VW_CFOP_SAI_ID(+) = C.BEG_CFOP_ID\n       and ES.ISACTIVE(+) = 'Y' -- aok - 19/12/2013\n       and ES.IND_PADRAO = 'Y'\n       and M.VALUE =\n           EXTRACTVALUE(X.ARQUIVO_XML,\n                        '/cteOSProc/CTeOS/infCte/ide/mod',\n                        'xmlns=\"http://www.portalfiscal.inf.br/cte\"');\n\n  V_DADO_CTE CBUSCA_DADOS_CTE%rowtype;\n  --\n  cursor Busca_almoxarifado is\n    select al.beg_est_tp_almoxarifado_id\n      from beg_est_almoxarifado al\n     where al.beg_est_almoxarifado_id = :new.beg_est_almoxarifado_id;\n  r_alm Busca_almoxarifado%rowtype;\n  --\n  CURSOR C_DESP IS\n    SELECT D.VLR_TOTAL_NOTA\n      FROM DIE_NFE_DESPESAS D\n     WHERE D.DIE_NFE_DESPESAS_ID = :NEW.DIE_NFE_DESPESAS_ID;\n  R_DESP C_DESP%ROWTYPE;\n  --\n  CURSOR C_CONTR IS\n    SELECT COUNT(1) QTDE\n      FROM DIE_FIN_CONTRATOS C\n     WHERE C.BEG_VW_FORNECEDOR_ID = :NEW.BEG_VW_FORNECEDOR_ID\n       AND C.BEG_CPG_TIPO_TITULO_ID = :NEW.BEG_CPG_TIPO_TITULO_ID\n       AND C.AD_ORG_ID = :NEW.AD_ORG_ID\n       AND C.ISACTIVE = 'Y'\n       AND C.DT_VCTO >= :NEW.DT_ENTRADA\n       AND C.DOCSTATUS = 'CO';\n  R_CONTR C_CONTR%ROWTYPE;\n  --  \n\nbegin\n  --\n  if INSERTING or updating then\n    --\n    open C_FECH_CONT;\n    fetch C_FECH_CONT\n      into R_FECH_CONT;\n    close C_FECH_CONT;\n    open C_FECH_CONT1;\n    fetch C_FECH_CONT1\n      into R_FECH_CONT1;\n    close C_FECH_CONT1;\n    if R_FECH_CONT.DT_FINAL >= :new.DT_ENTRADA and\n       :NEW.DIE_FIN_CONTRATOS_ID IS NULL and :new.beg_est_tp_especie_id not in (2000031) then\n      if nvl(r_FECH_CONT1.ind_escrita, 'N') = 'N' AND\n         :NEW.DOCSTATUS NOT in ('PA', 'WP') and\n         :new.beg_est_tp_especie_id not in (2000013) then\n        RAISE_APPLICATION_ERROR(-20501,\n                                'Movimento ja encerrado! NUMERO ' ||\n                                :NEW.NUMERO || ' DT_ENTRADA ' ||\n                                :NEW.DT_ENTRADA);\n      else\n        if :new.beg_est_tp_especie_id not in\n           (2000060, 2000059, 2000022, 2000013) --Obrigacoes, Retorno Conserto e Devolucao venda\n           AND :NEW.DOCSTATUS NOT in ('PA', 'WP') then\n        \n          RAISE_APPLICATION_ERROR(-20501,\n                                  'Movimento ja encerrado! NUMERO ' ||\n                                  :NEW.NUMERO || ' DT_ENTRADA ' ||\n                                  :NEW.DT_ENTRADA);\n        end if;\n        if (:new.beg_cpg_conta_id <> :old.beg_cpg_conta_id or\n           :new.beg_cpg_tipo_titulo_id <> :old.beg_cpg_tipo_titulo_id) and\n           :NEW.DOCSTATUS in ('PA', 'WP', 'CO') then\n          RAISE_APPLICATION_ERROR(-20501,\n                                  'Movimento ja encerrado! NUMERO ' ||\n                                  :NEW.NUMERO || ' DT_ENTRADA ' ||\n                                  :NEW.DT_ENTRADA);\n        end if;\n      end if;\n    end if;\n    ----\n    /*   IF :NEW.DIE_NFE_DESPESAS_ID IS NOT NULL AND UPDATING THEN\n     open C_DESP;\n    fetch C_DESP\n      into R_DESP;\n    close C_DESP; \n       IF :NEW.VLR_TOTAL_NOTA <> R_DESP.VLR_TOTAL_NOTA THEN \n          RAISE_APPLICATION_ERROR(-20501, 'Valor da Nota de entrada diferente da Nota de despesa. Favor alterar primeiro a Nota de Despesa.');         \n       END IF;\n        \n    END IF;*/\n  \n    ----\n    IF :new.beg_est_tp_especie_id in (2000060, 2000059, 2000022, 2000013) AND\n       :NEW.DOCSTATUS NOT in ('PA', 'CO', 'WP') THEN\n      open C_FECH_CONT2;\n      fetch C_FECH_CONT2\n        into R_FECH_CONT2;\n      close C_FECH_CONT2;\n      IF R_FECH_CONT2.DT_FINAL >= :new.DT_ENTRADA then\n        RAISE_APPLICATION_ERROR(-20501,\n                                'Movimento ja encerrado! NUMERO ' ||\n                                :NEW.NUMERO || ' DT_ENTRADA ' ||\n                                :NEW.DT_ENTRADA);\n      END IF;\n    \n    END IF;\n  \n    IF :new.beg_est_tp_especie_id in (2000060, 2000059, 2000022, 2000013) AND\n       (:new.beg_cpg_conta_id <> :old.beg_cpg_conta_id or\n       :new.beg_cpg_tipo_titulo_id <> :old.beg_cpg_tipo_titulo_id) and\n       :NEW.DOCSTATUS in ('PA', 'WP', 'CO') THEN\n      open C_FECH_CONT2;\n      fetch C_FECH_CONT2\n        into R_FECH_CONT2;\n      close C_FECH_CONT2;\n      IF R_FECH_CONT2.DT_FINAL >= :new.DT_ENTRADA then\n        RAISE_APPLICATION_ERROR(-20501,\n                                'Movimento ja encerrado! NUMERO ' ||\n                                :NEW.NUMERO || ' DT_ENTRADA ' ||\n                                :NEW.DT_ENTRADA);\n      END IF;\n    \n    END IF;\n  \n    -----\n   /* if inserting then\n      open C1;\n      fetch C1\n        into VN_DUMMY;\n      if C1%found then\n        --\n        RAISE_APPLICATION_ERROR(-20000,\n                                'Ja existe Nota Fiscal com mesmo Numero e Data de Emissao para o Fornecedor.');\n        --\n      end if;\n      close C1;\n    end if;*/\n    --\n  end if;\n  --\n  --- VALIDAÇÃO DE CONTRATOS ATIVOS COM A EMPRESA\n\n  IF INSERTING AND :NEW.DIE_FIN_CONTRATOS_ID IS NULL AND NVL(:NEW.IND_NF_SEM_CONTRATO,'N') = 'N'  THEN\n  \n    OPEN C_CONTR;\n    FETCH C_CONTR\n      INTO R_CONTR;\n    CLOSE C_CONTR;\n  \n    IF NVL(R_CONTR.QTDE, 0) > 0 THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Fornecedor possui contrato ativo para esta filial. Verifique!!.');\n    \n    END IF;\n  \n  END IF;\n\n  --\n  IF UPDATING THEN\n    ---  Validacao para tipo especie de retorno de conserto\n    If :new.beg_est_tp_especie_id = 2000022 and\n       :new.beg_est_almoxarifado_id is null and :new.ad_org_id = 1000016 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Falta informar de qual almoxarifado vai sair estes produtos!');\n    end if;\n  \n    If :new.beg_est_tp_especie_id = 2000022 and\n       :new.beg_est_almoxarifado_id is not null and\n       :new.ad_org_id = 1000016 then\n    \n      open Busca_almoxarifado;\n      fetch Busca_almoxarifado\n        into r_alm;\n      close Busca_almoxarifado;\n    \n      if r_alm.beg_est_tp_almoxarifado_id not in (2000003) then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Somente informar almoxarifado de assistencia para este tipo de nota!');\n      end if;\n    end if;\n  END IF;\n  ---\n  IF NVL(:NEW.IND_GERADA_XML, 'N') = 'Y' THEN\n    GOTO FIM;\n  END IF;\n  --\n  -- N¿o deixa inserir 2 notas fiscais com mesmo NUMERO, FORNECEDOR e DATA EMISS¿O\n  --\n  if INSERTING and :NEW.CHAVE_NFE is not null and\n     :NEW.BEG_TIPO_NF_ID =\n     BEG_FNC_RETORNA_PARAM_GERAL('Geral', null, 'CONHECIMENTO_FRETE', null) then\n    --\n    VC_CHAVE_ACESSO := TRIM(:NEW.CHAVE_NFE);\n    --\n    open BUSCA_CHAVE;\n    fetch BUSCA_CHAVE\n      into V_CHAVE;\n    /* if BUSCA_CHAVE%notfound then\n      RAISE_APPLICATION_ERROR(-20501, '1. XML ainda nao carregado');\n    end if;*/\n    close BUSCA_CHAVE;\n    --\n    open CBUSCA_DADOS_CTE;\n    fetch CBUSCA_DADOS_CTE\n      into V_DADO_CTE;\n    if CBUSCA_DADOS_CTE%found then\n      :NEW.NUMERO                   := V_DADO_CTE.NUMERO;\n      :NEW.SERIE                    := V_DADO_CTE.SERIE;\n      :NEW.DT_EMISSAO               := V_DADO_CTE.DT_EMISSAO;\n      :NEW.VLR_BASE_ICMS            := NVL(V_DADO_CTE.BASE_ICMS, 0);\n      :NEW.VLR_ICMS                 := NVL(V_DADO_CTE.VLR_ICMS, 0);\n      :NEW.VLR_TOTAL_PRODUTOS       := V_DADO_CTE.VLR_TOTAL;\n      :NEW.VLR_TOTAL_PRODUTOS_CALC  := V_DADO_CTE.VLR_TOTAL;\n      :NEW.VLR_TOTAL_NOTA           := V_DADO_CTE.VLR_TOTAL;\n      :NEW.VLR_TOTAL_NOTA_CALC      := V_DADO_CTE.VLR_TOTAL;\n      :NEW.VLR_TOTAL_FATURADO       := V_DADO_CTE.VLR_TOTAL;\n      :NEW.BEG_VW_FORNECEDOR_ID     := V_DADO_CTE.BEG_VW_FORNECEDOR_ID;\n      :NEW.BEG_VW_CFOP_ENT_ID       := V_DADO_CTE.BEG_VW_CFOP_ENT_ID;\n      :NEW.BEG_VW_CFOP_SAI_ID       := V_DADO_CTE.BEG_CFOP_ID;\n      :NEW.BEG_VW_TRANSPORTADORA_ID := V_DADO_CTE.BEG_VW_FORNECEDOR_ID;\n      :NEW.BEG_FIS_COD_MODELO_ID    := V_DADO_CTE.BEG_FIS_COD_MODELO_ID;\n      :NEW.OBS                      := :NEW.OBS || ' Valor total da nota: ' ||\n                                       NVL(V_DADO_CTE.VCARGA, 0);\n      --:NEW.vlr_outras_despesas := v_vlr_pedagio;\n    end if;\n  end if;\n  --\n  -- Se esta excluindo uma nota, exclui tambem os itens.\n  if DELETING then\n  \n    -- Verifica o status da nota\n    --if :old.DOCSTATUS <> 'WC' then\n    --  VC_MSG_ERRO := 'Somente e possivel excluir notas ainda n?o processadas!';\n    --  goto FIM;\n    --end if;\n    --\n    -- Verifica se titulos vinculados a nota est¿o todos abertos, caso n¿o estejam\n    -- n¿o deixa excluir a nota\n    --\n    open C2;\n    fetch C2\n      into VN_DUMMY;\n    if C2%found then\n      close C2;\n      --\n      VC_MSG_ERRO := 'Nota nao pode ser excluida, pois possui titulos pagos.';\n      --\n      goto FIM;\n    end if;\n    close C2;\n    -- Carrega variavel que libera exclus¿o dos historicos\n    BEG_PCK_CPG_CONTAS_PAGAR.V_EXCLUI_BEG_CPG_HISTORICO := 'S';\n    -- Exclui historicos\n    delete BEG_CPG_HISTORICO H\n     where H.BEG_CPG_TITULO_ID in\n           (select T.BEG_CPG_TITULO_ID\n              from BEG_CPG_TITULO T\n             where T.BEG_CPR_NFE_ID = :old.BEG_CPR_NFE_ID);\n    delete from BEG_INS_NFE_ITEM N\n     where N.BEG_CPR_NFE_ITEM_ID in\n           (select BEG_CPR_NFE_ITEM_ID\n              from BEG_CPR_NFE_ITEM\n             where BEG_CPR_NFE_ID = :old.BEG_CPR_NFE_ID);\n  \n    -- Carrega variavel que tranca exclus¿o dos historicos\n    BEG_PCK_CPG_CONTAS_PAGAR.V_EXCLUI_BEG_CPG_HISTORICO := 'N';\n    -- Exclui titulos\n    delete from BEG_CPG_TITULO where BEG_CPR_NFE_ID = :old.BEG_CPR_NFE_ID;\n    --\n    BEG_PCK_CPR_COMPRAS.VB_PROC_NFE := true;\n    -- Exclui Custo do Produto\n    delete BEG_CST_PRODUTO P\n     where P.BEG_CPR_NFE_ITEM_ID in\n           (select I.BEG_CPR_NFE_ITEM_ID\n              from BEG_CPR_NFE_ITEM I\n             where I.BEG_CPR_NFE_ID = :old.BEG_CPR_NFE_ID);\n    open BUSCA_ITENS_ENTRADA;\n    loop\n      fetch BUSCA_ITENS_ENTRADA\n        into V_ITENS_ENTRADA;\n      exit when BUSCA_ITENS_ENTRADA%notfound;\n      insert into COMPIEREPROD.BEG_EST_MOVTO_ESTOQUE\n        (BEG_EST_MOVTO_ESTOQUE_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         BEG_EST_TP_ESPECIE_ID,\n         BEG_PRD_SKU_ID,\n         BEG_EST_ALMOXARIFADO_ID,\n         BEG_EST_VW_ALMOX_DESTINO_ID,\n         VLR_MOVTO,\n         QTD_MOVTO,\n         BEG_PRODUTO_ID,\n         BEG_SKU_ID,\n         DOCUMENTO,\n         DATA)\n      values\n        (BEG_FNC_AD_SEQUENCE('BEG_EST_MOVTO_ESTOQUE'),\n         :old.AD_CLIENT_ID,\n         :old.AD_ORG_ID,\n         'Y',\n         sysdate,\n         :old.CREATEDBY,\n         sysdate,\n         :old.UPDATEDBY,\n         2000055,\n         V_ITENS_ENTRADA.BEG_PRD_SKU_ID,\n         BEG_FNC_RETORNA_PARAMETRO(:old.AD_CLIENT_ID,\n                                   :old.AD_ORG_ID,\n                                   'Vendas',\n                                   'Faturamento',\n                                   'ALMOXARIFADO FATURAMENTO'),\n         null,\n         V_ITENS_ENTRADA.VLR_UNITARIO,\n         V_ITENS_ENTRADA.QTD,\n         V_ITENS_ENTRADA.BEG_PRODUTO_ID,\n         V_ITENS_ENTRADA.BEG_PRD_SKU_ID,\n         :old.NUMERO || '_' || V_ITENS_ENTRADA.SEQUENCIA,\n         TRUNC(sysdate));\n    \n    end loop;\n    close BUSCA_ITENS_ENTRADA;\n    -- Exclui os itens\n    delete from BEG_CPR_NFE_ITEM\n     where BEG_CPR_NFE_ID = :old.BEG_CPR_NFE_ID;\n  \n    BEG_PCK_CPR_COMPRAS.VB_PROC_NFE := false;\n  \n    --\n    --\n    -- Exclui os registros de impress?o eventualmente gerados\n    delete from BEG_GER_IMPRESSAO\n     where NVL(BEG_CPR_NFE_ID, 0) = :old.BEG_CPR_NFE_ID\n        or NVL(BEG_VW_CPR_NFE_ESPECIAL_ID, 0) = :old.BEG_CPR_NFE_ID;\n  \n    goto FIM;\n  \n    IF :OLD.CHAVE_NFE IS NOT NULL THEN\n    \n      UPDATE BEG_FAT_NFE_XML N\n         SET N.BEG_CPR_NFE_ID = NULL\n       WHERE N.CHAVE_ACESSO = :OLD.CHAVE_NFE;\n    \n      UPDATE BEG_CPR_PRE_NFE NE\n         SET NE.DOCSTATUS = 'WC', NE.SITUACAO = 'WC'\n       WHERE NE.CHAVE_NFE = :OLD.CHAVE_NFE;\n    \n    END IF;\n  \n  end if;\n\n  -- aok - 01/02/2011\n  if BEG_PCK_CPG_CONTAS_PAGAR.VB_ALTERA_NRO_NFE then\n    goto FIM;\n  end if;\n  --\n  if BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_HIST then\n    --if :old.DOCSTATUS <> 'WP' then\n    --  VC_MSG_ERRO := 'Nota n?o encontra-se aguardando pagamento!';\n    --end if;\n    goto FIM;\n  end if;\n\n  -- aok - 21/11/2013 ----------------------------------------------------------\n  BEG_PCK_CPR_COMPRAS.VC_IND_FATURAMENTO := :new.IND_EMITIDA_FATURAMENTO;\n  BEG_PCK_CPR_COMPRAS.VC_IND_CARGA_SIAD  := :new.IND_CARGA_SIAD;\n  ------------------------------------------------------------------------------\n\n  -- Verifica o status da nota\n\n  if UPDATING and :old.DOCSTATUS = :new.DOCSTATUS and\n     :new.DOCSTATUS <> 'WC' and :old.chave_nfe = :new.chave_nfe then\n    if nvl(:old.ind_aprov_icms, 'B') = nvl(:new.ind_aprov_icms, 'B') then\n      VC_MSG_ERRO := 'Somente e possivel alterar notas que estao aguardando confirmacao!';\n      goto FIM;\n    end if;\n  end if;\n\n  if :new.chave_nfe is not null then\n    if :old.chave_nfe <> :new.chave_nfe then\n      VC_MSG_ERRO := 'Chave de acesso ja informada!';\n    end if;\n  \n    if length(:new.chave_nfe) <> 44 then\n      VC_MSG_ERRO := 'Chave de acesso incorreta. Verifique!';\n    end if;\n  end if;\n\n  if length(:old.chave_nfe) = 44 and :old.docstatus <> 'WC' and\n     nvl(length(:new.chave_nfe), 0) <> 44 then\n    VC_MSG_ERRO := 'Não é permitido alterar/excluir chave de acesso válida!';\n  end if;\n\n  if :new.DT_ENTRADA < :new.DT_EMISSAO then\n    VC_MSG_ERRO := 'Data de entrada menor que data de emissao!';\n    goto FIM;\n  end if;\n\n  if NVL(:old.NRO_VIA_IMPRESSA, :new.NRO_VIA_IMPRESSA) <>\n     :new.NRO_VIA_IMPRESSA then\n    goto FIM;\n  end if;\n\n  if :new.IND_EXCLUI_TODOS_ITENS = 'Y' or\n     :new.IND_EXCLUI_ITENS_INATIVOS = 'Y' then\n    BEG_PCK_CPR_COMPRAS.VB_PROC_NFE := true;\n  \n    -- Atualiza os valores na nota\n    select ROUND(:new.VLR_BASE_ICMS_CALC - sum(VLR_BASE_ICMS_CALC), 2),\n           :new.VLR_BASE_OUTROS_ICMS - sum(VLR_BASE_OUTROS_ICMS),\n           ROUND(:new.VLR_BASE_ICMS_SUBST_CALC -\n                 sum(VLR_BASE_ICMS_SUBST_CALC),\n                 2),\n           :new.VLR_BASE_ISENTO_ICMS - sum(VLR_BASE_ISENTO_ICMS),\n           ROUND(:new.VLR_ICMS_CALC - sum(VLR_ICMS_CALC), 2),\n           :new.VLR_OUTROS_ICMS - sum(VLR_OUTROS_ICMS),\n           ROUND(:new.VLR_ICMS_SUBST_CALC - sum(VLR_ICMS_SUBST_CALC), 2),\n           ROUND(:new.VLR_BASE_IPI_CALC - sum(VLR_BASE_IPI_CALC), 2),\n           :new.VLR_BASE_OUTROS_IPI - sum(VLR_BASE_OUTROS_IPI),\n           :new.VLR_BASE_ISENTO_IPI - sum(VLR_BASE_ISENTO_IPI),\n           ROUND(:new.VLR_IPI_CALC - sum(VLR_IPI_CALC), 2),\n           :new.VLR_OUTROS_IPI - sum(VLR_OUTROS_IPI),\n           :new.VLR_BASE_ISSQN - sum(VLR_BASE_ISSQN),\n           :new.VLR_ISSQN - sum(VLR_ISSQN),\n           :new.QTD_VOLUMES - sum(QTD_VOLUMES),\n           :new.PESO_BRUTO - sum(PESO_BRUTO),\n           :new.PESO_LIQUIDO - sum(PESO_LIQUIDO),\n           :new.VLR_SEGURO - sum(VLR_SEGURO),\n           ROUND(:new.VLR_TOTAL_PRODUTOS_CALC - sum(VLR_TOTAL_CALC), 2),\n           ROUND(:new.VLR_TOTAL_NOTA_CALC -\n                 sum(VLR_TOTAL_CALC + VLR_DESPESAS_FINANCEIRAS +\n                     VLR_OUTRAS_DESPESAS + VLR_ICMS_SUBST_CALC +\n                     DECODE(IND_FRETE_NOTA,\n                            'Y',\n                            (VLR_FRETE + VLR_FRETE_RDP),\n                            0)),\n                 2)\n      into :new.VLR_BASE_ICMS_CALC,\n           :new.VLR_BASE_OUTROS_ICMS,\n           :new.VLR_BASE_ICMS_SUBST_CALC,\n           :new.VLR_BASE_ISENTO_ICMS,\n           :new.VLR_ICMS_CALC,\n           :new.VLR_OUTROS_ICMS,\n           :new.VLR_ICMS_SUBST_CALC,\n           :new.VLR_BASE_IPI_CALC,\n           :new.VLR_BASE_OUTROS_IPI,\n           :new.VLR_BASE_ISENTO_IPI,\n           :new.VLR_IPI_CALC,\n           :new.VLR_OUTROS_IPI,\n           :new.VLR_BASE_ISSQN,\n           :new.VLR_ISSQN,\n           :new.QTD_VOLUMES,\n           :new.PESO_BRUTO,\n           :new.PESO_LIQUIDO,\n           :new.VLR_SEGURO,\n           :new.VLR_TOTAL_PRODUTOS_CALC,\n           :new.VLR_TOTAL_NOTA_CALC\n      from BEG_CPR_NFE_ITEM\n     where BEG_CPR_NFE_ID = :new.BEG_CPR_NFE_ID\n       and ISACTIVE = case\n             when :new.IND_EXCLUI_TODOS_ITENS = 'Y' then\n              ISACTIVE\n             when :new.IND_EXCLUI_ITENS_INATIVOS = 'Y' then\n              'N'\n             else\n              '^'\n           end;\n  \n    -- Exclui os itens\n    delete from BEG_CPR_NFE_ITEM\n     where BEG_CPR_NFE_ID = :new.BEG_CPR_NFE_ID\n       and ISACTIVE = case\n             when :new.IND_EXCLUI_TODOS_ITENS = 'Y' then\n              ISACTIVE\n             when :new.IND_EXCLUI_ITENS_INATIVOS = 'Y' then\n              'N'\n             else\n              '^'\n           end;\n  \n    :new.IND_EXCLUI_TODOS_ITENS    := 'N';\n    :new.IND_EXCLUI_ITENS_INATIVOS := 'N';\n  \n    BEG_PCK_CPR_COMPRAS.VB_PROC_NFE := false;\n  end if;\n\n  if not BEG_PCK_CPR_COMPRAS.VB_PROC_NFE_IT then\n  \n    -- Verifica filial\n    if NVL(:new.AD_ORG_ID, 0) = 0 then\n      VC_MSG_ERRO := 'Deve ser selecionada uma filial para a nota!';\n      goto FIM;\n    end if;\n  \n    /*\n      -- Valida o numero da nota\n      if NVL(:new.NUMERO, 0) <= 0 then\n        VC_MSG_ERRO := 'Numero deve ser infrmado e maior que zero!';\n        goto FIM;\n      end if;\n    \n      -- Fornecedor\n      if NVL(:new.BEG_VW_FORNECEDOR_ID, 0) <= 0 then\n        VC_MSG_ERRO := 'Fornecedor deve ser informado!';\n        goto FIM;\n      end if;\n    */\n  \n    -- Valor faturado\n    if NVL(:new.VLR_TOTAL_FATURADO, 0) < 0 then\n      VC_MSG_ERRO := 'Valor faturado negativo!';\n      goto FIM;\n    end if;\n  \n    -- Valida o CFOP informado\n    if (NVL(:new.BEG_VW_CFOP_SAI_ID, 0) > 0 or\n       NVL(:new.BEG_VW_CFOP_ENT_ID, 0) > 0) AND :NEW.DIE_FIN_CONTRATOS_ID IS NULL then\n      begin\n        select NVL(:new.BEG_VW_CFOP_SAI_ID, BEG_VW_CFOP_SAI_ID),\n               NVL(:new.BEG_VW_CFOP_ENT_ID, BEG_VW_CFOP_ENT_ID)\n          into :new.BEG_VW_CFOP_SAI_ID, :new.BEG_VW_CFOP_ENT_ID\n          from BEG_CFOP_ENT_SAI\n         where BEG_VW_CFOP_ENT_ID =\n               NVL(:new.BEG_VW_CFOP_ENT_ID, BEG_VW_CFOP_ENT_ID)\n           and BEG_VW_CFOP_SAI_ID =\n               NVL(:new.BEG_VW_CFOP_SAI_ID, BEG_VW_CFOP_SAI_ID)\n           and ind_padrao = 'Y' -- AOK - 02/12/2010\n           and ISACTIVE = 'Y'; -- AOK - 02/12/2010\n      exception\n        when TOO_MANY_ROWS then\n          VC_MSG_ERRO := 'CFOPs com relacao duplicada! capa';\n          goto FIM;\n        \n        when NO_DATA_FOUND then\n          VC_MSG_ERRO := 'CFOPs sem relacao cadastrada!';\n          goto FIM;\n        \n      end;\n    end if;\n  \n    -- Valida o almoxarifado informado. Se for zero, n?o posui inspec?o. Neste caso deve ter sido informado no item\n    /*    VN_BEG_EST_ALMOXARIFADO_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n    :new.AD_ORG_ID,\n    'Vendas',\n    'Faturamento',\n    'ALMOXARIFADO FATURAMENTO'));*/\n  \n    if NVL(VN_BEG_EST_ALMOXARIFADO_ID, 0) = 0 then\n      /*select count(1)\n          into VN_DUMMY\n          from BEG_CPR_NFE_ITEM\n         where BEG_CPR_NFE_ID = :new.BEG_CPR_NFE_ID\n           and NVL(BEG_EST_ALMOXARIFADO_ID, 0) = 0;\n        if VN_DUMMY > 0 then\n          VC_MSG_ERRO := 'n?o existe almoxarifado de bloqueio parametrizado e item n?o possui almoxarifado informado!'||:new.ad_org_id;\n          goto FIM;\n        end if;\n      else\n        if NVL(:new.BEG_EST_ALMOXARIFADO_ID, 0) > 0 then\n          VC_MSG_ERRO := 'Existe almoxarifado de bloqueio parametrizado e a nota possui almoxarifado informado!';\n          goto FIM;\n        end if;*/\n    \n      /*select count(1)\n        into VN_DUMMY\n        from BEG_CPR_NFE_ITEM\n       where BEG_CPR_NFE_ID = :new.BEG_CPR_NFE_ID\n         and NVL(BEG_EST_ALMOXARIFADO_ID, 0) > 0;\n      if VN_DUMMY > 0 then\n        VC_MSG_ERRO := 'Existe almoxarifado de bloqueio parametrizado e item possui almoxarifado informado!';\n        goto FIM;\n      end if;*/\n      null;\n    end if;\n  \n    -- Se trocou o fornecedor, verifica o vinculo dos itens e inicializa os valores\n    if :old.BEG_VW_FORNECEDOR_ID <> :new.BEG_VW_FORNECEDOR_ID then\n      /*      if BEG_FNC_RETORNA_PARAM_GERAL('Compras',\n                                     'Produto',\n                                     'CONSISTE_PRODUTO_FORNECEDOR') = 'Y' then\n      \n        select count(1)\n          into VN_DUMMY\n          from BEG_VW_SUP_FORNECEDOR PRD_FRN\n         where PRD_FRN.BEG_VW_FORNECEDOR_ID = :old.BEG_VW_FORNECEDOR_ID\n           and exists\n         (select 1\n                  from BEG_CPR_NFE_ITEM NFE_IT\n                 where NFE_IT.BEG_PRODUTO_ID = PRD_FRN.BEG_PRODUTO_ID\n                   and ROWNUM = 1);\n      \n        if VN_DUMMY > 0 then\n          VC_MSG_ERRO := 'Nota possui itens para o fornecedor anterior!';\n          goto FIM;\n        end if;\n      end if;*/\n    \n      begin\n        --NVL2( valor, retorno_if_NOT_null, retorno_if_null )\n        select F.TP_FRETE,\n               DECODE(NVL(:new.VLR_FRETE, 0),\n                      0,\n                      NVL(:new.VLR_TOTAL_PRODUTOS, 0) * NVL(F.PER_FRETE, 0) / 100,\n                      :new.VLR_FRETE),\n               DECODE(NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0),\n                      0,\n                      NVL(:new.VLR_TOTAL_PRODUTOS, 0) *\n                      NVL(F.PER_DESPESAS_FINANCEIRAS, 0) / 100,\n                      :new.VLR_DESPESAS_FINANCEIRAS),\n               DECODE(NVL(:new.VLR_OUTRAS_DESPESAS, 0),\n                      0,\n                      NVL(:new.VLR_TOTAL_PRODUTOS, 0) *\n                      NVL(F.PER_OUTRAS_DESPESAS, 0) / 100,\n                      :new.VLR_OUTRAS_DESPESAS),\n               :new.OBS_OUTRAS_DESPESAS || F.OBS_OUTRAS_DESPESAS,\n               NVL2(:new.BEG_CONDICAO_PAGAMENTO_ID,\n                    :new.BEG_CONDICAO_PAGAMENTO_ID,\n                    F.BEG_CONDICAO_PAGAMENTO_ID),\n               NVL2(:new.BEG_VW_TRANSPORTADORA_ID,\n                    :new.BEG_VW_TRANSPORTADORA_ID,\n                    F.BEG_VW_TRANSPORTADORA_ID)\n          into :new.TP_FRETE,\n               :new.VLR_FRETE,\n               :new.VLR_DESPESAS_FINANCEIRAS,\n               :new.VLR_OUTRAS_DESPESAS,\n               :new.OBS_OUTRAS_DESPESAS,\n               :new.BEG_CONDICAO_PAGAMENTO_ID,\n               :new.BEG_VW_TRANSPORTADORA_ID\n          from BEG_SUP_FORNECEDOR F\n         where F.BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID\n           and F.AD_ORG_ID =\n               (select max(FF.AD_ORG_ID)\n                  from BEG_SUP_FORNECEDOR FF, BEG_GER_FILIAL FL\n                 where FF.AD_CLIENT_ID = FL.AD_CLIENT_ID\n                   and FF.BEG_VW_FORNECEDOR_ID = F.BEG_VW_FORNECEDOR_ID\n                   and FF.ISACTIVE = 'Y'\n                   and FF.AD_ORG_ID in (FL.AD_ORG_ID_GERAL, :new.AD_ORG_ID))\n           and F.ISACTIVE = 'Y';\n      \n      exception\n        when NO_DATA_FOUND then\n          null;\n        \n      end;\n    \n      if :new.BEG_VW_TRANSPORTADORA_ID is null and :new.TP_FRETE = 'F' then\n        :new.BEG_VW_TRANSPORTADORA_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n                                                                             :new.AD_ORG_ID,\n                                                                             'Compras',\n                                                                             null,\n                                                                             'TRANSP_PADRAO_COMPRA'));\n      end if;\n    \n    end if;\n  \n  end if;\n\n--Validar se a NF é de CIAP, pula pro fim\n IF :NEW.BEG_EST_TP_ESPECIE_ID NOT IN (2000031 ) THEN\n\n  -- Valor total da nota\n  if NVL(:new.VLR_TOTAL_NOTA, 0) < 0 then\n    VC_MSG_ERRO := 'Valor total da nota negativo!';\n    goto FIM;\n  end if;\n\n  -- Valor total dos produtos\n  if NVL(:new.VLR_TOTAL_PRODUTOS, 0) < 0 then\n    VC_MSG_ERRO := 'Valor total dos produtos negativo!';\n    goto FIM;\n  end if;\n\n  if NVL(:old.IND_ACRESCIMO_NOTA, 'N') = 'Y' then\n    :new.VLR_TOTAL_NOTA_CALC := ROUND(:new.VLR_TOTAL_NOTA_CALC -\n                                      NVL(:old.VLR_ACRESCIMO, 0),\n                                      2);\n  end if;\n\n  if NVL(:old.IND_DESCONTO_NOTA, 'N') = 'Y' then\n    :new.VLR_TOTAL_NOTA_CALC := ROUND(:new.VLR_TOTAL_NOTA_CALC +\n                                      NVL(:old.VLR_DESCONTO, 0),\n                                      2);\n  end if;\n\n  if NVL(:old.IND_FRETE_NOTA, 'N') = 'Y' then\n    :new.VLR_TOTAL_NOTA_CALC := ROUND(:new.VLR_TOTAL_NOTA_CALC -\n                                      (NVL(:old.VLR_FRETE, 0) +\n                                      NVL(:old.VLR_FRETE_RDP, 0)),\n                                      2);\n  end if;\n\n  -- Desconto\n  if (NVL(:old.VLR_TOTAL_NOTA, 0) <> NVL(:new.VLR_TOTAL_NOTA, 0) or\n     NVL(:old.VLR_TOTAL_NOTA_CALC, 0) <> NVL(:new.VLR_TOTAL_NOTA_CALC, 0) or\n     NVL(:old.PER_DESCONTO, 0) <> NVL(:new.PER_DESCONTO, 0) or\n     NVL(:old.VLR_DESCONTO, 0) <> NVL(:new.VLR_DESCONTO, 0)) and\n     (NVL(:new.PER_DESCONTO, 0) > 0 or NVL(:new.VLR_DESCONTO, 0) > 0) then\n  \n    if NVL(:new.VLR_TOTAL_NOTA, 0) = 0 and\n       NVL(:new.VLR_TOTAL_NOTA_CALC, 0) = 0 then\n    \n      if NVL(:new.VLR_DESCONTO, 0) > 0 then\n        :new.PER_DESCONTO := 0;\n      end if;\n    \n    else\n    \n      if :new.VLR_TOTAL_NOTA = 0 then\n        VN_AUX_BASE := :new.VLR_TOTAL_NOTA_CALC;\n      else\n        VN_AUX_BASE := :new.VLR_TOTAL_NOTA;\n      end if;\n    \n      if NVL(:old.PER_DESCONTO, 0) <> NVL(:new.PER_DESCONTO, 0) or\n         NVL(:new.VLR_DESCONTO, 0) = 0 then\n        VN_AUX_ALQ  := :new.PER_DESCONTO;\n        VN_AUX_CALC := 0;\n      else\n        VN_AUX_ALQ  := 0;\n        VN_AUX_CALC := :new.VLR_DESCONTO;\n      end if;\n    \n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                             VN_AUX_BASE,\n                                             VN_AUX_CALC);\n      -- , VN_AUX_VLR_ICMS);\n    \n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do desconto!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do desconto!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de desconto diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.PER_DESCONTO := ROUND(VN_AUX_ALQ, 3);\n        :new.VLR_DESCONTO := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  -- Acrescimo\n  if (NVL(:old.VLR_TOTAL_NOTA, 0) <> NVL(:new.VLR_TOTAL_NOTA, 0) or\n     NVL(:old.VLR_TOTAL_NOTA_CALC, 0) <> NVL(:new.VLR_TOTAL_NOTA_CALC, 0) or\n     NVL(:old.PER_ACRESCIMO, 0) <> NVL(:new.PER_ACRESCIMO, 0) or\n     NVL(:old.VLR_ACRESCIMO, 0) <> NVL(:new.VLR_ACRESCIMO, 0)) and\n     (NVL(:new.PER_ACRESCIMO, 0) > 0 or NVL(:new.VLR_ACRESCIMO, 0) > 0) then\n  \n    if NVL(:new.VLR_TOTAL_NOTA, 0) = 0 and\n       NVL(:new.VLR_TOTAL_NOTA_CALC, 0) = 0 then\n    \n      if NVL(:new.VLR_ACRESCIMO, 0) > 0 then\n        :new.PER_ACRESCIMO := 0;\n      end if;\n    \n    else\n    \n      if :new.VLR_TOTAL_NOTA = 0 then\n        VN_AUX_BASE := :new.VLR_TOTAL_NOTA_CALC;\n      else\n        VN_AUX_BASE := :new.VLR_TOTAL_NOTA;\n      end if;\n    \n      if NVL(:old.PER_ACRESCIMO, 0) <> NVL(:new.PER_ACRESCIMO, 0) or\n         NVL(:new.VLR_ACRESCIMO, 0) = 0 then\n        VN_AUX_ALQ  := :new.PER_ACRESCIMO;\n        VN_AUX_CALC := 0;\n      else\n        VN_AUX_ALQ  := 0;\n        VN_AUX_CALC := :new.VLR_ACRESCIMO;\n      end if;\n    \n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                             VN_AUX_BASE,\n                                             VN_AUX_CALC);\n      --,  VN_AUX_VLR_ICMS);\n    \n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do acrescimo!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do acrescimo!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de acrescimo diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.PER_ACRESCIMO := VN_AUX_ALQ;\n        :new.VLR_ACRESCIMO := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  if NVL(:new.VLR_FRETE, 0) = 0 and NVL(:new.VLR_FRETE_RDP, 0) = 0 then\n    :new.IND_FRETE_NOTA := 'N';\n  end if;\n\n  if NVL(:new.VLR_DESCONTO, 0) = 0 then\n    :new.IND_DESCONTO_NOTA      := 'N';\n    :new.IND_DESCONTO_BASE_ICMS := 'N';\n    :new.IND_DESCONTO_BASE_IPI  := 'N';\n  end if;\n\n  if NVL(:new.VLR_DESCONTO, 0) > 0 then\n    :new.IND_DESCONTO_NOTA := 'Y';\n  \n  end if;\n\n  if NVL(:new.VLR_BASE_ICMS_CALC, 0) = 0 and\n     NVL(:new.VLR_BASE_ICMS_SUBST_CALC, 0) = 0 then\n    :new.IND_DESCONTO_BASE_ICMS := 'N';\n  end if;\n\n  if NVL(:new.VLR_ACRESCIMO, 0) = 0 then\n    :new.IND_ACRESCIMO_NOTA      := 'N';\n    :new.IND_ACRESCIMO_BASE_ICMS := 'N';\n    :new.IND_ACRESCIMO_BASE_IPI  := 'N';\n  end if;\n\n  if NVL(:new.VLR_BASE_IPI_CALC, 0) = 0 then\n    :new.IND_ACRESCIMO_BASE_IPI := 'N';\n  end if;\n\n  if :new.IND_ACRESCIMO_NOTA = 'Y' then\n    :new.VLR_TOTAL_NOTA_CALC := :new.VLR_TOTAL_NOTA_CALC +\n                                :new.VLR_ACRESCIMO;\n  end if;\n\n  if :new.IND_DESCONTO_NOTA = 'Y' then\n    :new.VLR_TOTAL_NOTA_CALC := :new.VLR_TOTAL_NOTA_CALC -\n                                :new.VLR_DESCONTO;\n  end if;\n\n  if :new.IND_FRETE_NOTA = 'Y' then\n    :new.VLR_TOTAL_NOTA_CALC := ROUND(:new.VLR_TOTAL_NOTA_CALC +\n                                      NVL(:new.VLR_FRETE, 0) +\n                                      NVL(:new.VLR_FRETE_RDP, 0),\n                                      2);\n  end if;\n\n  -- Atualiza ICMS e IPI quendo o frete, arescimo ou desconto s?o na na nota\n  if :new.IND_FRETE_NOTA = 'Y' then\n    BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE := :new.VLR_FRETE +\n                                            :new.VLR_FRETE_RDP;\n  else\n    BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE := 0;\n  end if;\n\n  if :new.IND_ACRESCIMO_BASE_ICMS = 'Y' then\n    BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE := :new.VLR_ACRESCIMO;\n  else\n    BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE := 0;\n  end if;\n\n  if :new.IND_DESCONTO_BASE_ICMS = 'Y' then\n    BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE := :new.VLR_DESCONTO;\n  else\n    BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE := 0;\n  end if;\n\n  if :new.IND_ACRESCIMO_BASE_IPI = 'Y' then\n    BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_IPI_NFE := :new.VLR_ACRESCIMO;\n  else\n    BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_IPI_NFE := 0;\n  end if;\n\n  if NVL(:new.IND_DESCONTO_BASE_IPI, '^') <>\n     NVL(:old.IND_DESCONTO_BASE_IPI, '^') then\n    if :new.IND_DESCONTO_BASE_IPI = 'Y' then\n      BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_IPI_NFE := :new.VLR_DESCONTO;\n    else\n      BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_IPI_NFE := 0;\n    end if;\n  else\n    BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_IPI_NFE := 0;\n  end if;\n\n  if BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE > 0 or\n     BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE > 0 or\n     BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE > 0 or\n     BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_IPI_NFE > 0 or\n     BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_IPI_NFE > 0 then\n    BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS := :new.VLR_TOTAL_PRODUTOS_CALC;\n  else\n    BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS := 0;\n  end if;\n\n  if not BEG_PCK_CPR_COMPRAS.VB_PROC_ORDEM then\n  \n    if not BEG_PCK_CPR_COMPRAS.VB_PROC_NFE_IT then\n    \n      BEG_PCK_CPR_COMPRAS.VB_PROC_NFE := true;\n    \n      :new.VLR_BASE_ICMS_CALC       := 0;\n      :new.VLR_ICMS_CALC            := 0;\n      :new.VLR_BASE_ICMS_SUBST_CALC := 0;\n      :new.VLR_ICMS_SUBST_CALC      := 0;\n      :new.VLR_BASE_IPI_CALC        := 0;\n      :new.VLR_IPI_CALC             := 0;\n    \n      for R_ITENS in (select BEG_CPR_NFE_ITEM_ID,\n                             VLR_TOTAL_CALC,\n                             ALQ_ICMS,\n                             VLR_BASE_ICMS_CALC,\n                             VLR_ICMS_CALC,\n                             ALQ_ICMS_SUBST,\n                             VLR_BASE_ICMS_SUBST_CALC,\n                             VLR_ICMS_SUBST_CALC,\n                             ALQ_IPI,\n                             VLR_BASE_IPI_CALC,\n                             VLR_IPI_CALC\n                        from BEG_CPR_NFE_ITEM IT\n                       where BEG_CPR_NFE_ID = :new.BEG_CPR_NFE_ID\n                         and (ALQ_ICMS > 0 or ALQ_IPI > 0 or\n                             ALQ_ICMS_SUBST > 0)) loop\n        -- ICMS\n        if NVL(R_ITENS.ALQ_ICMS, 0) > 0 then\n          VN_VLR_RATEADO := 0;\n          --vn_teste  := :new.ind_frete_nota;\n          --vn_teste1 := :old.ind_frete_nota;\n          if NVL(:new.IND_FRETE_NOTA, '^') <> NVL(:old.IND_FRETE_NOTA, '^') then\n            if :new.IND_FRETE_NOTA = 'Y' then\n              VN_VLR_RATEADO := VN_VLR_RATEADO + :new.VLR_FRETE +\n                                :new.VLR_FRETE_RDP;\n            else\n              VN_VLR_RATEADO := VN_VLR_RATEADO -\n                                (:old.VLR_FRETE + :old.VLR_FRETE_RDP);\n            end if;\n          end if;\n          --vn_teste  := :new.ind_acrescimo_base_icms;\n          --vn_teste1 := :old.ind_acrescimo_base_icms;\n          if NVL(:new.IND_ACRESCIMO_BASE_ICMS, '^') <>\n             NVL(:old.IND_ACRESCIMO_BASE_ICMS, '^') then\n            if :new.IND_ACRESCIMO_BASE_ICMS = 'Y' then\n              VN_VLR_RATEADO := VN_VLR_RATEADO + :new.VLR_ACRESCIMO;\n            else\n              VN_VLR_RATEADO := VN_VLR_RATEADO - :old.VLR_ACRESCIMO;\n            end if;\n          end if;\n          -- vn_teste  := :new.IND_DESCONTO_BASE_ICMS;\n          -- vn_teste1 := :old.IND_DESCONTO_BASE_ICMS;\n          if NVL(:new.IND_DESCONTO_BASE_ICMS, '^') <>\n             NVL(:old.IND_DESCONTO_BASE_ICMS, '^') then\n            if :new.IND_DESCONTO_BASE_ICMS = 'Y' then\n              VN_VLR_RATEADO := VN_VLR_RATEADO - :new.VLR_DESCONTO;\n            else\n              VN_VLR_RATEADO := VN_VLR_RATEADO + :old.VLR_DESCONTO;\n            end if;\n          end if;\n        \n          R_ITENS.VLR_BASE_ICMS_CALC := ROUND(R_ITENS.VLR_BASE_ICMS_CALC +\n                                              (VN_VLR_RATEADO /\n                                              :new.VLR_TOTAL_PRODUTOS_CALC *\n                                              R_ITENS.VLR_TOTAL_CALC),\n                                              2);\n        \n          VN_AUX_CALC := 0;\n          BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(R_ITENS.ALQ_ICMS,\n                                                 R_ITENS.VLR_BASE_ICMS_CALC,\n                                                 VN_AUX_CALC);\n          --, VN_AUX_VLR_ICMS);\n        \n          if VN_AUX_CALC = -1 then\n            VC_MSG_ERRO := 'Valores negativos no calculo do ICMS dos itens!';\n          elsif VN_AUX_CALC = -2 then\n            VC_MSG_ERRO := 'Impossivel apurar valor do ICMS dos itens!';\n          elsif VN_AUX_CALC = -3 then\n            VC_MSG_ERRO := 'Valor apurado de ICMS dos itens diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n          else\n            R_ITENS.VLR_ICMS_CALC := ROUND(VN_AUX_CALC, 2);\n          end if;\n          if VC_MSG_ERRO is not null then\n            goto FIM;\n          end if;\n        end if;\n      \n        -- ICMS substituic?o\n        if NVL(R_ITENS.ALQ_ICMS_SUBST, 0) > 0 then\n          VN_VLR_RATEADO := 0;\n        \n          if NVL(:new.IND_FRETE_NOTA, '^') <> NVL(:old.IND_FRETE_NOTA, '^') then\n            if :new.IND_FRETE_NOTA = 'Y' then\n              VN_VLR_RATEADO := VN_VLR_RATEADO + :new.VLR_FRETE +\n                                :new.VLR_FRETE_RDP;\n            else\n              VN_VLR_RATEADO := VN_VLR_RATEADO -\n                                (:old.VLR_FRETE + :old.VLR_FRETE_RDP);\n            end if;\n          end if;\n        \n          if NVL(:new.IND_ACRESCIMO_BASE_ICMS, '^') <>\n             NVL(:old.IND_ACRESCIMO_BASE_ICMS, '^') then\n            if :new.IND_ACRESCIMO_BASE_ICMS = 'Y' then\n              VN_VLR_RATEADO := VN_VLR_RATEADO + :new.VLR_ACRESCIMO;\n            else\n              VN_VLR_RATEADO := VN_VLR_RATEADO - :old.VLR_ACRESCIMO;\n            end if;\n          end if;\n        \n          if NVL(:new.IND_DESCONTO_BASE_ICMS, '^') <>\n             NVL(:old.IND_DESCONTO_BASE_ICMS, '^') then\n            if :new.IND_DESCONTO_BASE_ICMS = 'Y' then\n              VN_VLR_RATEADO := VN_VLR_RATEADO - :new.VLR_DESCONTO;\n            else\n              VN_VLR_RATEADO := VN_VLR_RATEADO + :old.VLR_DESCONTO;\n            end if;\n          end if;\n        \n          R_ITENS.VLR_BASE_ICMS_SUBST_CALC := ROUND(R_ITENS.VLR_BASE_ICMS_SUBST_CALC +\n                                                    (VN_VLR_RATEADO /\n                                                    :new.VLR_TOTAL_PRODUTOS_CALC *\n                                                    R_ITENS.VLR_TOTAL_CALC),\n                                                    2);\n        \n          VN_AUX_CALC := 0;\n          BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(R_ITENS.ALQ_ICMS_SUBST,\n                                                 R_ITENS.VLR_BASE_ICMS_SUBST_CALC,\n                                                 VN_AUX_CALC);\n          --, VN_AUX_VLR_ICMS);\n        \n          if VN_AUX_CALC = -1 then\n            VC_MSG_ERRO := 'Valores negativos no calculo do ICMS da substituic?o dos itens!';\n          elsif VN_AUX_CALC = -2 then\n            VC_MSG_ERRO := 'Impossivel apurar valor do ICMS da substituic?o dos itens!';\n          elsif VN_AUX_CALC = -3 then\n            VC_MSG_ERRO := 'Valor apurado de ICMS da substituic?o dos itens diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n          else\n            R_ITENS.VLR_ICMS_SUBST_CALC := ROUND(VN_AUX_CALC, 2);\n          end if;\n          if VC_MSG_ERRO is not null then\n            goto FIM;\n          end if;\n        end if;\n      \n        -- IPI\n        if NVL(R_ITENS.ALQ_IPI, 0) > 0 then\n          VN_VLR_RATEADO := 0;\n        \n          if NVL(:new.IND_FRETE_NOTA, '^') <> NVL(:old.IND_FRETE_NOTA, '^') then\n            if :new.IND_FRETE_NOTA = 'Y' then\n              VN_VLR_RATEADO := VN_VLR_RATEADO + :new.VLR_FRETE +\n                                :new.VLR_FRETE_RDP;\n            else\n              VN_VLR_RATEADO := VN_VLR_RATEADO -\n                                (:old.VLR_FRETE + :old.VLR_FRETE_RDP);\n            end if;\n          end if;\n        \n          if NVL(:new.IND_ACRESCIMO_BASE_IPI, '^') <>\n             NVL(:old.IND_ACRESCIMO_BASE_IPI, '^') then\n            if :new.IND_ACRESCIMO_BASE_IPI = 'Y' then\n              VN_VLR_RATEADO := VN_VLR_RATEADO + :new.VLR_ACRESCIMO;\n            else\n              VN_VLR_RATEADO := VN_VLR_RATEADO - :old.VLR_ACRESCIMO;\n            end if;\n          end if;\n        \n          if NVL(:new.IND_DESCONTO_BASE_IPI, '^') <>\n             NVL(:old.IND_DESCONTO_BASE_IPI, '^') then\n            if :new.IND_DESCONTO_BASE_IPI = 'Y' then\n              VN_VLR_RATEADO := VN_VLR_RATEADO - :new.VLR_DESCONTO;\n            else\n              VN_VLR_RATEADO := VN_VLR_RATEADO + :old.VLR_DESCONTO;\n            end if;\n          end if;\n        \n          R_ITENS.VLR_BASE_IPI_CALC := ROUND(R_ITENS.VLR_BASE_IPI_CALC +\n                                             (VN_VLR_RATEADO /\n                                             :new.VLR_TOTAL_PRODUTOS_CALC *\n                                             R_ITENS.VLR_TOTAL_CALC),\n                                             2);\n        \n          VN_AUX_CALC := 0;\n          BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(R_ITENS.ALQ_IPI,\n                                                 R_ITENS.VLR_BASE_IPI_CALC,\n                                                 VN_AUX_CALC);\n          --,  VN_AUX_VLR_ICMS);\n        \n          if VN_AUX_CALC = -1 then\n            VC_MSG_ERRO := 'Valores negativos no calculo do IPI dos itens!';\n          elsif VN_AUX_CALC = -2 then\n            VC_MSG_ERRO := 'Impossivel apurar valor do IPI dos itens!';\n          elsif VN_AUX_CALC = -3 then\n            VC_MSG_ERRO := 'Valor apurado de IPI dos itens diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n          else\n            R_ITENS.VLR_IPI_CALC := ROUND(VN_AUX_CALC, 2);\n          end if;\n          if VC_MSG_ERRO is not null then\n            goto FIM;\n          end if;\n        \n        end if;\n      \n        update BEG_CPR_NFE_ITEM\n           set VLR_BASE_ICMS_CALC       = R_ITENS.VLR_BASE_ICMS_CALC,\n               VLR_ICMS_CALC            = R_ITENS.VLR_ICMS_CALC,\n               VLR_BASE_ICMS_SUBST_CALC = R_ITENS.VLR_BASE_ICMS_SUBST_CALC,\n               VLR_ICMS_SUBST_CALC      = R_ITENS.VLR_ICMS_SUBST_CALC,\n               VLR_BASE_IPI_CALC        = R_ITENS.VLR_BASE_IPI_CALC,\n               VLR_IPI_CALC             = R_ITENS.VLR_IPI_CALC\n         where BEG_CPR_NFE_ITEM_ID = R_ITENS.BEG_CPR_NFE_ITEM_ID;\n      \n        :new.VLR_BASE_ICMS_CALC       := :new.VLR_BASE_ICMS_CALC +\n                                         R_ITENS.VLR_BASE_ICMS_CALC;\n        :new.VLR_ICMS_CALC            := :new.VLR_ICMS_CALC +\n                                         R_ITENS.VLR_ICMS_CALC;\n        :new.VLR_BASE_ICMS_SUBST_CALC := :new.VLR_BASE_ICMS_SUBST_CALC +\n                                         R_ITENS.VLR_BASE_ICMS_SUBST_CALC;\n        :new.VLR_ICMS_SUBST_CALC      := :new.VLR_ICMS_SUBST_CALC +\n                                         R_ITENS.VLR_ICMS_SUBST_CALC;\n        :new.VLR_BASE_IPI_CALC        := :new.VLR_BASE_IPI_CALC +\n                                         R_ITENS.VLR_BASE_IPI_CALC;\n        :new.VLR_IPI_CALC             := :new.VLR_IPI_CALC +\n                                         R_ITENS.VLR_IPI_CALC;\n      \n      end loop;\n    \n      BEG_PCK_CPR_COMPRAS.VB_PROC_NFE := false;\n    \n    end if;\n  \n  end if;\n\n  -- Atualiza valor total da nota\n  :new.VLR_TOTAL_NOTA_CALC := ROUND(NVL(:new.VLR_TOTAL_NOTA_CALC, 0) -\n                                    (NVL(:old.VLR_DESPESAS_FINANCEIRAS, 0) +\n                                     NVL(:old.VLR_OUTRAS_DESPESAS, 0) +\n                                     NVL(:old.VLR_IPI_CALC, 0) +\n                                     NVL(:old.VLR_ICMS_SUBST_CALC, 0)) +\n                                    (NVL(:new.VLR_DESPESAS_FINANCEIRAS, 0) +\n                                     NVL(:new.VLR_OUTRAS_DESPESAS, 0) +\n                                     NVL(:new.VLR_IPI_CALC, 0) +\n                                     NVL(:new.VLR_ICMS_SUBST_CALC, 0)),\n                                    2);\n\n  -- Valor faturado frente valor da nota\n  if NVL(:new.VLR_TOTAL_FATURADO, 0) > 0 then\n    if NVL(:new.VLR_TOTAL_FATURADO, 0) > NVL(:new.VLR_TOTAL_NOTA_CALC, 0) and\n       NVL(:new.VLR_TOTAL_FATURADO, 0) > NVL(:new.VLR_TOTAL_NOTA, 0) then\n      VC_MSG_ERRO := 'Valor total faturado maior que o valor total da nota!';\n      goto FIM;\n    end if;\n  end if;\n\n  -- Isento de ICMS\n  if NVL(:new.VLR_BASE_ISENTO_ICMS, 0) < 0 then\n    VC_MSG_ERRO := 'Valor da base isenta de ICMS negativo!';\n    goto FIM;\n  end if;\n\n  -- Isento de IPI\n  if NVL(:new.VLR_BASE_ISENTO_IPI, 0) < 0 then\n    VC_MSG_ERRO := 'Valor da base isenta de IPI negativo!';\n    goto FIM;\n  end if;\n\n  -- IR\n  /* Solicitado pela Isabel que n?o calculasse mais em 05/10/2007\n  VN_AUX_CALC := :new.VLR_IR;\n  BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:new.ALQ_IR,\n                                         :new.VLR_BASE_IR,\n                                         VN_AUX_CALC);\n  if VN_AUX_CALC = -1 then\n    VC_MSG_ERRO := 'Valores negativos no calculo do IR!';\n  elsif VN_AUX_CALC = -2 then\n    VC_MSG_ERRO := 'Impossivel apurar valor do IR!';\n  elsif VN_AUX_CALC = -3 then\n    VC_MSG_ERRO := 'Valor apurado de IR diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n  else\n    if NVL(:new.VLR_IR, 0) = 0 then\n      :new.VLR_ISSQN := VN_AUX_CALC;\n    end if;\n  end if;\n  if VC_MSG_ERRO is not null then\n    goto FIM;\n  end if;\n  */\n\n  -- INSS\n  VN_AUX_CALC := :new.VLR_INSS;\n  BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:new.ALQ_INSS,\n                                         :new.VLR_BASE_INSS,\n                                         VN_AUX_CALC);\n  --,  VN_AUX_VLR_ICMS);\n  if VN_AUX_CALC = -1 then\n    VC_MSG_ERRO := 'Valores negativos no calculo do INSS!';\n  elsif VN_AUX_CALC = -2 then\n    VC_MSG_ERRO := 'Impossivel apurar valor do INSS!';\n  elsif VN_AUX_CALC = -3 then\n    VC_MSG_ERRO := 'Valor apurado de INSS diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n  else\n    if NVL(:new.VLR_INSS, 0) = 0 then\n      :new.VLR_INSS := VN_AUX_CALC;\n    end if;\n  end if;\n  if VC_MSG_ERRO is not null then\n    goto FIM;\n  end if;\n\n  -- ISSQN\n  VN_AUX_CALC := NVL(:new.VLR_ISSQN, 0) ;\n  BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:new.ALQ_ISSQN,\n                                         :new.VLR_BASE_ISSQN,\n                                         VN_AUX_CALC);\n  --, VN_AUX_VLR_ICMS);\n  if VN_AUX_CALC = -1 then\n    VC_MSG_ERRO := 'Valores negativos no calculo do ISSQN!';\n  elsif VN_AUX_CALC = -2 then\n    VC_MSG_ERRO := 'Impossivel apurar valor do ISSQN!';\n  elsif VN_AUX_CALC = -3 then\n    VC_MSG_ERRO := 'Valor apurado de ISSQN diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n  else\n    if NVL(:new.VLR_ISSQN, 0) = 0 then\n      :new.VLR_ISSQN := VN_AUX_CALC;\n    end if;\n  end if;\n  if VC_MSG_ERRO is not null then\n    goto FIM;\n  end if;\n  --  AOK - 10/09/2010\n  if not DELETING then\n    :new.SERIE := UPPER(:new.SERIE);\n  \n    if :NEW.BEG_EST_TP_ESPECIE_ID = 2000059 then\n      :NEW.P_SERVICO := 'Y';\n    end if;\n  \n  end if;\n\nend if;  \n  \n  --\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend TRG_BIUD_BEG_CPR_NFE;\n"}`;
    
    }
}
