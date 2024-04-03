
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_NFS_RET
    {
            [StringLength(14)]
        /// <summary>
        /// Cnpj da loja emitente da nf
        /// </summary>
        public string CPFCNPJ_EMIT { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Inscricao Estadual da loja emitente da nf
        /// </summary>
        public string IE_EMIT { get; set; }
            [StringLength(1)]
        /// <summary>
        /// tipo fi do pedido (1-avista, 2-parc. estab., 3-parc. adm)
        /// </summary>
        public string TIPOFI { get; set; }
            [StringLength(40)]
        /// <summary>
        /// tipo de volumes das mercadorias
        /// </summary>
        public string TP_VOL { get; set; }
            [StringLength(60)]
        /// <summary>
        /// Transportadora
        /// </summary>
        public string TRANSP { get; set; }
            [StringLength(14)]
        /// <summary>
        /// CNPJ TRANSPORTADORA
        /// </summary>
        public string CNPJ_TRANSP { get; set; }
            [StringLength(20)]
        /// <summary>
        /// INSCRICAO ESTADUAL TRANSPORTADORA
        /// </summary>
        public string INSCRICAO_TRANSP { get; set; }
            [StringLength(100)]
        /// <summary>
        /// ENDERECO TRANSPORTADORA
        /// </summary>
        public string ENDERECO_TRANSP { get; set; }
            [StringLength(100)]
        /// <summary>
        /// CIDADE TRANSPORTADORA
        /// </summary>
        public string CIDADE_TRANSP { get; set; }
            [StringLength(2)]
        /// <summary>
        /// ESTADO TRANSPORTADORA
        /// </summary>
        public string UF_TRANSP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_DEV_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CIAP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_PARCELA_CIAP { get; set; }
            [StringLength(60)]
        /// <summary>
        /// Impressora de notas da matriz conforme cadastrado nos parametros sistema 
        /// </summary>
        public string IMPRESSORA_NF { get; set; }
        
        /// <summary>
        /// Indicativo para o robo do pdv aprovar a nota automatico
        /// </summary>
        public string IND_DESTINO_ROBO { get; set; }
        
        /// <summary>
        /// Indicativo de destino da NF
        /// </summary>
        public int IDDEST { get; set; }
            [StringLength(60)]
        /// <summary>
        /// Razao Social da loja emitente da nf
        /// </summary>
        public string NOME_EMIT { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Numero filial emitente da nf
        /// </summary>
        public string NR_FILIAL_EMIT { get; set; }
            [StringLength(60)]
        /// <summary>
        /// Nome fantasia da loja emitente da nf
        /// </summary>
        public string NOME_FANTASIA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Telefone da loja emitente da nf
        /// </summary>
        public string FONE_EMIT { get; set; }
            [StringLength(9)]
        /// <summary>
        /// Cep da loja emitente da nf
        /// </summary>
        public string CEP_EMIT { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Edereco da loja emitente da nf
        /// </summary>
        public string ENDERECO_EMIT { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Numero predio da loja emitente da nf
        /// </summary>
        public string NUMERO_EMIT { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Complemento endereço da loja emitente da nf
        /// </summary>
        public string COMPLEMENTO_EMIT { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Bairro da loja emitente da nf
        /// </summary>
        public string BAIRRO_EMIT { get; set; }
            [StringLength(100)]
        /// <summary>
        /// cidade da loja emitente da nf
        /// </summary>
        public string CIDADE_EMIT { get; set; }
        
        /// <summary>
        /// Codigo do ibge da cidade da loja emitente da nf
        /// </summary>
        public int IBGE_CID_EMIT { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Estado da loja emitente da nf
        /// </summary>
        public string UF_EMIT { get; set; }
        
        /// <summary>
        /// Codigo do ibge do estado da loja emitente da nf
        /// </summary>
        public int IBGE_UF_EMIT { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Inscricao municipal da loja emitente da nf
        /// </summary>
        public string INSC_MUNIC_EMIT { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CNAE_CPFCNPJ_EMIT { get; set; }
            [StringLength(60)]
        /// <summary>
        /// Nome vendedor
        /// </summary>
        public string NOME_VEND { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Codigo do Vendedor
        /// </summary>
        public string COD_VEND { get; set; }
        
        /// <summary>
        /// Vlr. da entrada do contrato se parcelado
        /// </summary>
        public int VLR_ENTRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int INDFINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_INSS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASE_INSS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQ_INSS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TRANSPORTADORA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_ESPECIE_VOLUME_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_ROTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_TIPO_FRETE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_TIPO_TRANSP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_UF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_FORMA_COBRANCA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PLANO_VENDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CIDADE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIS_COD_MODELO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_UF_ID { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP_ENDERECO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string BT_CALCULO { get; set; }
            [StringLength(44)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE_NF_REFERENCIADA { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPLEMENTO_END { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string TP_LANCTO_CONTABIL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_COFINS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
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
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_FINANCEIRA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_GARANTIA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NATOPERACAO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NFREF { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string MESANOREF { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CNPJREF { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFREF { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string IEREF { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string MODELOREF { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIEREF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TP_IMPRESSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FIN_NFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TP_NFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TP_PAGTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOT_SEM_SERVICOS { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string INSCRICAO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string RG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_NASCIMENTO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string E_MAIL { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IBGE_CIDADE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IBGE_UF { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_NOTA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string INDIEDEST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TP_PESSOA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE { get; set; }
        
        /// <summary>
        /// 100-aprovado, 135-Cancelado, 102-Inutilizado
        /// </summary>
        public int STATUS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string PROTOCOLO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE { get; set; }
            [StringLength(400)]
        /// <summary>
        /// 
        /// </summary>
        public string RETORNOMOTIVO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DIGESTVALUENFE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOT_PROD_SEM_SERVICOS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SIGLA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRPEDIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_EVENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOT_TRIB_APROX { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string QRCODE { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_FORMA_PGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_RECIBO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRRECIBO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO_REC { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_NFS_RET_ID { get; set; }
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
        /// Nr do CF aprovado na SEFAZ. ou Nr da NFe
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
        public int VL_TOTAL_PROD { get; set; }
        
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
        public int VL_BASE_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS_SUBST { get; set; }
        
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
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_CUSTO_FINANCEIRO { get; set; }
        
        /// <summary>
        /// Nr do Controle interno para uso no sistema psts vendas NFCe ( Contrato)
        /// </summary>
        public int NRO_CUPOM_FISCAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SERIE_MAQUINA { get; set; }
            [StringLength(300)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
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
        public string DTHR_ADORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_DESP_FINANCEIRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PESSOA_ENTREGA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TRANSPORTADORA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_VOLUME { get; set; }
        
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
        public int BEG_VW_CLIENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESC_SUFRAMA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_TIPO_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASE_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQ_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASE_IRRF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQ_IRRF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_IRRF { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO_ENTREGA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO_ENTREGA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_FRETE { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_DIE_NFS_RET { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  pragma autonomous_transaction;\n\n  X_ID                      NUMBER(10);\n  V_ID_ITEM                 NUMBER(10);\n  V_ID_CPR                  NUMBER(10) := 0;\n  V_ID_PED                  NUMBER(10);\n  V_TIT_ID                  NUMBER(10);\n  V_SEQ                     NUMBER(10);\n  V_SALDO                   VARCHAR2(20);\n  V_PROD                    VARCHAR2(10);\n  V_ID_SAI                  NUMBER(10);\n  V_ID_ENT                  NUMBER(10);\n  V_ID_CFOP                 NUMBER(10);\n  V_RESULT                  VARCHAR2(1000);\n  V_ALMOX2_ID               NUMBER(10);\n  V_ALMOX3_ID               NUMBER(10);\n  V_ID_IT_DEV               NUMBER(10);\n  V_ID_IT_VEN               NUMBER(10);\n  V_ALMOXARIFADO_ID         number(10);\n  VN_BEG_CPG_TIPO_TITULO_ID NUMBER(10);\n  VN_BEG_CPG_CONTA_ID       NUMBER(10);\n\n  CURSOR C_ITEM IS\n    SELECT IT.*, IP.DIE_GER_VENDEDOR_ID, P.DIE_COD_ESTRUTURADO DIE_PRODUTO\n      FROM DIE_FAT_NFS_ITEM_RETORNO IT, DIE_ITEPED IP, BEG_PRODUTO P\n     WHERE IT.DIE_FAT_PRE_NFS_ID = :NEW.DIE_FAT_NFS_RET_ID\n       AND IT.BEG_PRODUTO_ID = P.BEG_PRODUTO_ID\n       AND IT.DIE_ITEPED_ID = IP.DIE_ITEPED_ID(+)\n    /*AND IT.NRO_NFS = :NEW.NRO_NFS*/\n    ;\n\n  R_ITEM C_ITEM%ROWTYPE;\n\n  CURSOR C_SERV IS\n    SELECT S.*\n      FROM DIE_FAT_SERVICO_RET S\n     WHERE S.DIE_FAT_NFS_RET_ID = :NEW.DIE_FAT_NFS_RET_ID\n       AND S.DIE_FAT_NFS_ITEM_RETORNO_ID = X_ID;\n\n  R_SERV C_SERV%ROWTYPE;\n\n  CURSOR C_PARC IS\n    SELECT T.*\n      FROM DIE_CRC_TITULO_RETORNO T\n     WHERE T.DIE_FAT_PRE_NFS_ID = :NEW.DIE_FAT_NFS_RET_ID\n    /*AND T.NUM_NF_SAIDA = :NEW.NRO_NFS*/\n    ;\n\n  R_PARC C_PARC%ROWTYPE;\n\n  CURSOR C_PED IS\n    SELECT P.*\n      FROM DIE_PEDIDO P\n     WHERE P.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n\n  R_PED C_PED%ROWTYPE;\n\n  CURSOR C_PITEM IS\n    SELECT COUNT(*) QTD, I.DTMONTAGEM DT_PREVISAO\n      FROM DIE_ITEPED I\n     WHERE I.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID\n       AND NVL(I.MONTAGEM, 'N') in ('S', 'Y')\n     GROUP BY I.DTMONTAGEM;\n  R_PITEM C_PITEM%ROWTYPE;\n\n  CURSOR C_DEV IS\n    SELECT D.DEVOLUCAO_INTEGRAL\n      FROM BEG_FAT_DEVOLUCAO D, DIE_FAT_PRE_NFS N\n     WHERE N.DIE_FAT_PRE_NFS_ID = :NEW.DIE_FAT_NFS_RET_ID\n       AND D.AD_ORG_ID = N.AD_ORG_ID\n       AND D.BEG_FAT_DEVOLUCAO_ID = N.NRO_NFS;\n  R_DEV C_DEV%ROWTYPE;\n\n  CURSOR C_DEV_IT IS\n    SELECT IT.BEG_FAT_NFS_ITEM_ID\n      FROM BEG_FAT_DEVOLUCAO_ITEM IT\n     WHERE /*it.BEG_FAT_DEVOLUCAO_ID = :NEW.DIE_FAT_NFS_RET_ID\n                                   AND */\n     IT.BEG_FAT_DEVOLUCAO_ITEM_ID = V_ID_IT_DEV;\n  R_DEV_IT C_DEV_IT%ROWTYPE;\n\n  CURSOR BUSCA_HST IS\n    SELECT N.BEG_HST_NOTA_FISCAL_ID\n      FROM BEG_HST_NOTA_FISCAL N\n     WHERE N.BEG_FAT_NFS_ITEM_ID = V_ID_IT_VEN;\n\n  R_HST BUSCA_HST%rowtype;\n\n  CURSOR C_CLIENTE IS\n    SELECT P.BEG_VW_UF_ID\n      FROM BEG_PESSOA P\n     WHERE P.BEG_PESSOA_ID = :NEW.BEG_VW_PESSOA_ENTREGA_ID;\n\n  R_CLIENTE C_CLIENTE%ROWTYPE;\n\n  CURSOR C_LOJA IS\n    SELECT PE.BEG_VW_UF_ID\n      FROM BEG_DADO_FILIAL D, BEG_PESSOA PE\n     WHERE D.BEG_PESSOA_ID = PE.BEG_PESSOA_ID\n       AND D.AD_ORG_ID = :NEW.AD_ORG_ID;\n  R_LOJA C_LOJA%ROWTYPE;\n\n  CURSOR C_CFOP IS\n    SELECT *\n      FROM BEG_CFOP_ENT_SAI CF\n     WHERE CF.BEG_VW_CFOP_ENT_ID = V_ID_CFOP\n       AND CF.IND_PADRAO = 'Y';\n  R_CFOP C_CFOP%ROWTYPE;\n\n  cursor busca_almox is\n    select *\n      from beg_est_almoxarifado al\n     where al.ad_org_id = :new.ad_org_id\n       AND AL.AD_ORG_ID <> 1000016\n       and al.descricao like 'ASSISTENCIA EXTERNA FILIAL%'\n       and al.isactive = 'Y'\n    union\n    select *\n      from beg_est_almoxarifado al\n     where al.ad_org_id = :new.ad_org_id\n       AND AL.AD_ORG_ID = 1000016\n       and al.descricao like 'ASSISTENCIA INTERNA%'\n       and al.isactive = 'Y';\n  R_ALMOX BUSCA_ALMOX%ROWTYPE;\n\n  cursor busca_almox1 is\n    select *\n      from beg_est_almoxarifado al\n     where al.ad_org_id = :new.ad_org_id\n       and al.isactive = 'Y'\n       and al.descricao like 'DEPOSITO%';\n  R_ALMOX1 BUSCA_ALMOX1%ROWTYPE;\n\n  CURSOR C_RET IS\n    SELECT IT.BEG_HST_NOTA_FISCAL_ID\n      FROM DIE_CPR_GER_NFE_ITEM IT\n     WHERE IT.DIE_FAT_NFS_ITEM_RETORNO_ID = V_ID_IT_VEN;\n  R_RET C_RET%ROWTYPE;\n\n  cursor BUSCA_ITENS is\n    select *\n      from BEG_CPR_NFE_ITEM I\n     where I.BEG_CPR_NFE_ID = :NEW.BEG_CPR_NFE_ID;\n  --\n  VREG2 BUSCA_ITENS%rowtype;\n\n  CURSOR C_MONTA IS\n    SELECT M.DIE_FAT_MONTAGEM_ID\n      FROM DIE_FAT_MONTAGEM M\n     WHERE M.BEG_FAT_NFS_ID = :NEW.DIE_FAT_NFS_RET_ID;\n\n  R_MONTA C_MONTA%ROWTYPE;\n\n  CURSOR C_CPR_NFE IS\n    SELECT C.*\n      FROM BEG_CPR_NFE C, BEG_CPG_TITULO T, BEG_FAT_DEV_FORNECEDOR DF\n     WHERE C.BEG_CPR_NFE_ID = T.BEG_CPR_NFE_ID\n       AND C.BEG_CPR_NFE_ID = DF.BEG_CPR_NFE_ID\n       AND DF.BEG_FAT_DEV_FORNECEDOR_ID = :NEW.BEG_FAT_DEV_FORNECEDOR_ID;\n  --\n  R_CPR_NFE C_CPR_NFE%ROWTYPE;\n\nBEGIN\n  --Nota: Para a NF subir, o campo BEG_FAT_NFS_ID deve estar nulo.\n  --Depois que a NF é carregada,a trigger preenche este campo para fechamento.\n  --Assim, qualquer update na NF nao dispara o processo de integração.\n  IF :NEW.STATUS in (100, 150) AND :NEW.SERIE_NFS IN ('NE') AND\n     :NEW.PROTOCOLO IS NULL THEN\n  \n    RAISE_APPLICATION_ERROR(-20501,\n                            'NAO permitido atualizar status para 100 com o numero protocolo em branco');\n  \n  END IF;\n\n  IF :NEW.STATUS in (100, 150) AND :NEW.BEG_FAT_NFS_ID IS NULL AND\n     :NEW.BEG_EST_TP_ESPECIE_ID NOT IN (2000013, 2000022) AND\n     :NEW.DOCSTATUS = 'WC' AND :NEW.TP_LANCTO_CONTABIL = 'S' THEN\n  \n    OPEN BUSCA_ALMOX;\n    FETCH BUSCA_ALMOX\n      INTO R_ALMOX;\n    CLOSE BUSCA_ALMOX;\n  \n    OPEN BUSCA_ALMOX1;\n    FETCH BUSCA_ALMOX1\n      INTO R_ALMOX1;\n    CLOSE BUSCA_ALMOX1;\n  \n    V_ALMOX2_ID := R_ALMOX1.BEG_EST_ALMOXARIFADO_ID;\n    V_ALMOX3_ID := R_ALMOX.BEG_EST_ALMOXARIFADO_ID;\n  \n    INSERT INTO BEG_FAT_NFS\n      (BEG_FAT_NFS_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       NRO_NFS,\n       SERIE_NFS,\n       DT_EMISSAO,\n       NRO_DUPLICATA,\n       PERC_ICMS,\n       VL_BASE_CALCULO_ICMS,\n       VL_BASE_ISENTA_ICMS,\n       VL_BASE_OUTRAS_ICMS,\n       VL_ICMS,\n       VL_BASE_CALCULO_IPI,\n       VL_BASE_ISENTA_IPI,\n       VL_BASE_OUTRAS_IPI,\n       VL_IPI,\n       VL_BASE_ICMS_SUBST,\n       VL_ICMS_SUBST,\n       VL_FRETE,\n       VL_SEGURO,\n       VL_OUTRAS_DESPESAS,\n       PERC_DESCONTO,\n       VL_TOTAL_PROD,\n       VL_TOTAL_NFS,\n       PLACA_VEICULO,\n       UF_VEICULO,\n       -- PLACA_VEICULO_REDES       ,\n       -- UF_VEICULO_REDES          ,\n       VL_CUSTO_FINANCEIRO,\n       NRO_CUPON_FISCAL,\n       SERIE_MAQUINA,\n       OBS,\n       PERC_COMISSAO_PEDIDO,\n       INTEGRADO,\n       FATURAVEL,\n       DT_SAIDA,\n       DTHR_ADORG_ID,\n       VL_DESP_FINANCEIRA,\n       GERADO_ARQ_EDI,\n       BEG_VW_PESSOA_ENTREGA_ID,\n       --  BEG_VW_REPRESENTANTE_ID   ,\n       BEG_VW_TRANSPORTADORA_ID,\n       --  BEG_VW_REDESPACHO_ID      ,\n       BEG_CONDICAO_PAGAMENTO_ID,\n       --  BEG_BANCO_ID              ,\n       --  BEG_CFOP_ID               ,\n       BEG_EST_TP_ESPECIE_ID,\n       --  COMISSAO_VENDEDOR         ,\n       --  COMISSAO_TELEVENDA        ,\n       --  QTDE_VOLUME               ,\n       --  PESO_LIQUIDO              ,\n       --  PESO_BRUTO                ,\n       --  DT_CANCELAMENTO           ,\n       CANCELADA,\n       BEG_VEN_PEDIDO_ID,\n       DESC_SUFRAMA,\n       --  BEG_VW_PREPOSTO_ID        ,\n       VLR_DESCONTO,\n       DIE_FIN_FINANCEIRA_ID,\n       BEG_CONVENIO_ID,\n       DIE_GER_VENDEDOR_ID,\n       --  NRO_ASSOCIADO             ,\n       VL_GARANTIA,\n       --  TP_DEVOLUCAO              ,\n       --  DT_LIBERACAO              ,\n       --  BEG_APEX_USER_ID          ,\n       LIBERADO,\n       VL_BASE_CALCULO_PIS,\n       VL_PIS,\n       VL_BASE_CALCULO_COFINS,\n       VL_COFINS,\n       PROTOCOLO,\n       BEG_CPG_TPMOV_ID,\n       VL_SEGUROS,\n       BEG_VEN_TIPO_PEDIDO_ID,\n       VLR_INSS,\n       VALOR_IRRF,\n       ALIQ_IRRF,\n       BASE_IRRF,\n       VALOR_ISSQN,\n       ALIQ_ISSQN,\n       BASE_ISSQN,\n       BEG_FRO_ROTA_ID,\n       BEG_VEN_PLANO_VENDA_ID,\n       BEG_EST_ALMOXARIFADO_ID,\n       IND_ISSQN_RETIDO,\n       REGERAR_NFE,\n       ACEITE_ENTRADA,\n       BEG_TIPO_NF_ID,\n       VLR_INFORMADO,\n       DIE_CRC_RECIBO_ID,\n       VFCPUFDEST,\n       VICMSUFDEST,\n       VICMSUFREMET,\n       IND_MANIFESTO,\n       DIE_MAN_TRANSPORTE_ID,\n       DIE_PEDIDO_ID,\n       CHAVE)\n    VALUES\n      (:NEW.DIE_FAT_NFS_RET_ID, --BEG_FAT_NFS_ID          ,\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID,\n       :NEW.ISACTIVE,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       case when :new.tp_nota = '55' or :new.tp_nfe = 9 then :NEW.NRO_NFS else\n       :new.nro_cupom_fiscal end, --:NEW.NRO_NFS,\n       :NEW.SERIE_NFS,\n       trunc(:NEW.DT_EMISSAO),\n       case when :new.tp_nota = '55' or :new.tp_nfe = 9 then :NEW.NRO_NFS else\n       :new.nro_cupom_fiscal end, --:NEW.NRO_NFS, --NRO_DUPLICATA             ,\n       0, --:NEW.PERC_ICMS                 ,\n       :NEW.VL_BASE_CALCULO_ICMS,\n       :NEW.VL_BASE_ISENTA_ICMS,\n       :NEW.VL_BASE_OUTRAS_ICMS,\n       :NEW.VL_ICMS,\n       :NEW.VL_BASE_CALCULO_IPI,\n       :NEW.VL_BASE_ISENTA_IPI,\n       :NEW.VL_BASE_OUTRAS_IPI,\n       :NEW.VL_IPI,\n       :NEW.VL_BASE_ICMS_SUBST,\n       :NEW.VL_ICMS_SUBST,\n       :NEW.VL_FRETE,\n       :NEW.VL_SEGURO,\n       :NEW.VL_OUTRAS_DESPESAS,\n       0, --:NEW.PERC_DESCONTO             ,\n       :NEW.VL_TOTAL_PROD,\n       :NEW.VL_TOTAL_NFS,\n       :NEW.PLACA_VEICULO,\n       :NEW.UF_VEICULO,\n       --:NEW.PLACA_VEICULO_REDES       ,\n       --:NEW.UF_VEICULO_REDES          ,\n       :NEW.VL_CUSTO_FINANCEIRO,\n       case when :new.tp_nota = '55' or :new.tp_nfe = 9 then 0 else\n       :new.nro_nfs end, --NVL(:NEW.NRO_CUPOM_FISCAL, 0),\n       :NEW.SERIE_MAQUINA,\n       :NEW.OBS,\n       0, --  :NEW.PERC_COMISSAO_PEDIDO      ,\n       NVL(:NEW.INTEGRADO, 'N'),\n       NVL(:NEW.FATURAVEL, 'S'),\n       :NEW.DT_SAIDA,\n       :NEW.DTHR_ADORG_ID,\n       NVL(:NEW.VL_DESP_FINANCEIRA, 0),\n       'N', --  :NEW.GERADO_ARQ_EDI            ,\n       :NEW.BEG_VW_PESSOA_ENTREGA_ID,\n       --  :NEW.BEG_VW_REPRESENTANTE_ID   ,\n       :NEW.BEG_VW_TRANSPORTADORA_ID,\n       --  :NEW.BEG_VW_REDESPACHO_ID      ,\n       :NEW.BEG_CONDICAO_PAGAMENTO_ID,\n       --:NEW.BEG_BANCO_ID              ,\n       --  :NEW.BEG_CFOP_ID               ,\n       :NEW.BEG_EST_TP_ESPECIE_ID,\n       --  :NEW.COMISSAO_VENDEDOR         ,\n       --  :NEW.COMISSAO_TELEVENDA        ,\n       --  :NEW.QTDE_VOLUME               ,\n       --  :NEW.PESO_LIQUIDO              ,\n       --  :NEW.PESO_BRUTO                ,\n       --  :NEW.DT_CANCELAMENTO           ,\n       'N', --CANCELADA                 ,\n       :NEW.BEG_VEN_PEDIDO_ID,\n       :NEW.DESC_SUFRAMA,\n       --  :NEW.BEG_VW_PREPOSTO_ID        ,\n       :NEW.VLR_DESCONTO,\n       :NEW.DIE_FIN_FINANCEIRA_ID,\n       CASE WHEN :NEW.BEG_CONVENIO_ID = 0 THEN NULL ELSE\n       :NEW.BEG_CONVENIO_ID END,\n       :NEW.DIE_GER_VENDEDOR_ID,\n       --  :NEW.NRO_ASSOCIADO             ,\n       :NEW.VLR_GARANTIA, --VL_GARANTIA               ,\n       --:NEW.TP_DEVOLUCAO              ,\n       --  :NEW.DT_LIBERACAO              ,\n       --  :NEW.BEG_APEX_USER_ID          ,\n       'N', --- LIBERADO                  ,\n       :new.vl_base_calculo_icms + :new.vl_base_isenta_icms, --VL_BASE_CALCULO_PIS       ,\n       :NEW.VL_PIS,\n       :new.vl_base_calculo_icms + :new.vl_base_isenta_icms, --VL_BASE_CALCULO_COFINS    ,\n       :NEW.VL_COFINS,\n       :NEW.PROTOCOLO,\n       null, --  :NEW.BEG_CPG_TPMOV_ID          ,\n       :NEW.VLr_SEGUROS,\n       :NEW.BEG_VEN_TIPO_PEDIDO_ID,\n       :NEW.VLR_INSS,\n       :NEW.VALOR_IRRF,\n       :NEW.ALIQ_IRRF,\n       :NEW.BASE_IRRF,\n       :NEW.VALOR_ISSQN,\n       :NEW.ALIQ_ISSQN,\n       :NEW.BASE_ISSQN,\n       :NEW.BEG_FRO_ROTA_ID,\n       :NEW.BEG_VEN_PLANO_VENDA_ID,\n       case when\n       :new.beg_est_tp_especie_id = 2000021 and :new.ad_org_id <> 1000016 then\n       V_ALMOX3_ID else :NEW.BEG_EST_ALMOXARIFADO_ID end,\n       'N', --IND_ISSQN_RETIDO          ,\n       NULL, --REGERAR_NFE               ,\n       NULL, --:NEW.ACEITE_ENTRADA            ,\n       :NEW.BEG_TIPO_NF_ID,\n       NULL, --:NEW.VLR_INFORMADO             ,\n       :NEW.DIE_CRC_RECIBO_ID,\n       :NEW.VFCPUFDEST,\n       :NEW.VICMSUFDEST,\n       :NEW.VICMSUFREMET,\n       case when :new.ad_org_id = 1000016 then 'N' ELSE 'Y' END, --:NEW.IND_MANIFESTO             ,\n       NULL, --:NEW.DIE_MAN_TRANSPORTE_ID     ,\n       :NEW.DIE_PEDIDO_ID,\n       :NEW.CHAVE);\n  \n    FOR R_ITEM IN C_ITEM LOOP\n    \n      V_PROD := R_ITEM.DIE_PRODUTO;\n      --      V_SALDO := BKN_PRC_INICIALIZA_ESTOQUE(V_PROD, :NEW.AD_ORG_ID);\n    \n      V_ID_ITEM := beg_fnc_ad_sequence('BEG_FAT_NFS_ITEM');\n      INSERT INTO BEG_FAT_NFS_ITEM\n        (BEG_FAT_NFS_ITEM_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         VALUE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         NRO_NFS,\n         SERIE_NFS,\n         DT_EMISSAO,\n         QTDE,\n         VL_UNITARIO,\n         VL_CUSTO_PRODUTO,\n         VL_CUSTO_FINANCEIRO,\n         PERC_COMISSAO,\n         BEG_VW_NF_ORIGEM_ID,\n         BEG_VW_NF_ORIGEM_ITEM_ID,\n         VL_DESCONTO,\n         DESC_TECNICA_ITEM,\n         NRO_PATRIMONIO,\n         ENTREGUE,\n         GERA_RESERVA,\n         OBS_LINHA_NFS,\n         PERC_ICMS,\n         PERC_REDUCAO,\n         VL_ICMS,\n         VL_BASE_CALCULO_ICMS,\n         VL_BASE_ISENTA_ICMS,\n         VL_BASE_OUTRAS_ICMS,\n         PERC_IPI,\n         VL_IPI,\n         VL_BASE_CALCULO_IPI,\n         VL_BASE_ISENTA_IPI,\n         VL_BASE_OUTRAS_IPI,\n         VL_ICMS_SUBST,\n         VL_BASE_SUBST_TRIB,\n         VL_FRETE_ITEM,\n         BEG_FIS_ORIGEM_MERC_ID,\n         BEG_FAT_NFS_ID,\n         BEG_EST_MOVTO_ESTOQUE_ID,\n         BEG_PRODUTO_ID,\n         BEG_FIS_TRIB_ICMS_ID,\n         BEG_PRD_SKU_ID,\n         BEG_CFOP_ID,\n         IND_BRINDE,\n         DIE_VEN_CONTRATO_CP_ID,\n         CST_PIS,\n         VL_BASE_CALCULO_PIS,\n         PERC_PIS,\n         VL_PIS,\n         CST_COFINS,\n         VL_BASE_CALCULO_COFINS,\n         PERC_COFINS,\n         VL_COFINS,\n         CST_ICMS,\n         PERC_MVAO,\n         BEG_EST_ALMOXARIFADO_ID,\n         BEG_FAT_CTRL_NF_ID,\n         --  LINHA_NFS_ENTREGA_FUT    ,\n         --  NRO_NFS_ENTREGA_FUT      ,\n         ICMS_FRETE,\n         VL_OUTRAS_DESPESAS,\n         VBCUFDEST,\n         PFCPUDEST,\n         PICMSUFDEST,\n         PICMSINTER,\n         PICMSINTERPART,\n         VFCPUFDEST,\n         VICMSUFDEST,\n         VICMSUFREMET,\n         DIE_GER_VENDEDOR_ID,\n         PREDBCEFET,\n         VBCEFET,\n         PICMSEFET,\n         VICMSEFET,\n         VICMSOP,\n         PDIF,\n         VICMSDIF)\n      VALUES\n        (V_ID_ITEM, --R_ITEM.DIE_FAT_NFS_ITEM_RETORNO_ID,\n         R_ITEM.AD_CLIENT_ID,\n         R_ITEM.AD_ORG_ID,\n         R_ITEM.ISACTIVE,\n         R_ITEM.NR_ITEM,\n         R_ITEM.CREATED,\n         R_ITEM.CREATEDBY,\n         R_ITEM.UPDATED,\n         R_ITEM.UPDATEDBY,\n         case when :new.tp_nota = '55' or :new.tp_nfe = 9 then :NEW.NRO_NFS else\n         :new.nro_cupom_fiscal end, --:NEW.NRO_NFS,\n         NVL(:NEW.SERIE_NFS, 'CE'),\n         R_ITEM.DT_EMISSAO,\n         CASE WHEN R_ITEM.DIE_COD_ESTRUTURADO IN\n         ('S-000-001', 'S-000-002', 'S-000-015') THEN 0 ELSE R_ITEM.QTDE END,\n         CASE WHEN R_ITEM.DIE_COD_ESTRUTURADO IN\n         ('S-000-001', 'S-000-002', 'S-000-015') THEN 0 ELSE\n         R_ITEM.VL_UNITARIO END,\n         R_ITEM.VL_CUSTO_PRODUTO,\n         R_ITEM.VL_CUSTO_FINANCEIRO,\n         0, --R_ITEM.PERC_COMISSAO            ,\n         NULL, --R_ITEM.BEG_VW_NF_ORIGEM_ID      ,\n         NULL, --R_ITEM.BEG_VW_NF_ORIGEM_ITEM_ID ,\n         R_ITEM.VL_DESCONTO,\n         R_ITEM.DESC_TECNICA_ITEM,\n         NULL, --R_ITEM.NRO_PATRIMONIO           ,\n         'S', --R_ITEM.ENTREGUE                 ,\n         'N', --R_ITEM.GERA_RESERVA,\n         R_ITEM.OBS_LINHA_NFS,\n         R_ITEM.PERC_ICMS,\n         R_ITEM.PERC_REDUCAO,\n         R_ITEM.VL_ICMS,\n         R_ITEM.VL_BASE_CALCULO_ICMS,\n         R_ITEM.VL_BASE_ISENTA_ICMS,\n         R_ITEM.VL_BASE_OUTRAS_ICMS,\n         R_ITEM.PERC_IPI,\n         R_ITEM.VL_IPI,\n         R_ITEM.VL_BASE_CALCULO_IPI,\n         R_ITEM.VL_BASE_ISENTA_IPI,\n         R_ITEM.VL_BASE_OUTRAS_IPI,\n         R_ITEM.VL_ICMS_SUBST,\n         R_ITEM.VL_BASE_SUBST_TRIB,\n         R_ITEM.VL_FRETE_ITEM,\n         R_ITEM.BEG_FIS_ORIGEM_MERC_ID,\n         :NEW.DIE_FAT_NFS_RET_ID, ---BEG_FAT_NFS_ID           ,\n         NULL, --R_ITEM.BEG_EST_MOVTO_ESTOQUE_ID ,\n         R_ITEM.BEG_PRODUTO_ID,\n         R_ITEM.BEG_FIS_TRIB_ICMS_ID,\n         R_ITEM.BEG_PRD_SKU_ID,\n         R_ITEM.BEG_CFOP_ID,\n         'N', --R_ITEM.IND_BRINDE               ,\n         NULL, --R_ITEM.DIE_VEN_CONTRATO_CP_ID   ,\n         R_ITEM.CST_PIS,\n         R_ITEM.VL_BASE_CALCULO_PIS,\n         R_ITEM.PERC_PIS,\n         R_ITEM.VL_PIS,\n         R_ITEM.CST_COFINS,\n         R_ITEM.VL_BASE_CALCULO_COFINS,\n         R_ITEM.ALIQ_COFINS,\n         R_ITEM.VL_COFINS,\n         CASE WHEN LENGTH(R_ITEM.CST) = 3 THEN SUBSTR(R_ITEM.CST, 2, 2) ELSE\n         R_ITEM.CST END,\n         R_ITEM.PERC_MVAO,\n         case when\n         :new.beg_est_tp_especie_id = 2000021 and :new.ad_org_id <> 1000016 then\n         V_ALMOX3_ID else :NEW.BEG_EST_ALMOXARIFADO_ID end, --R_ITEM.BEG_EST_ALMOXARIFADO_ID,\n         R_ITEM.BEG_FAT_CTRL_NF_ID,\n         --  R_ITEM.LINHA_NFS_ENTREGA_FUT    ,\n         --  R_ITEM.NRO_NFS_ENTREGA_FUT      ,\n         R_ITEM.vl_icms_frete, --ICMS_FRETE               ,\n         R_ITEM.VL_OUTRAS_DESPESAS,\n         R_ITEM.VBCUFDEST,\n         R_ITEM.PFCPUDEST,\n         R_ITEM.PICMSUFDEST,\n         R_ITEM.PICMSINTER,\n         R_ITEM.PICMSINTERPART,\n         R_ITEM.VFCPUFDEST,\n         R_ITEM.VICMSUFDEST,\n         R_ITEM.VICMSUFREMET,\n         R_ITEM.DIE_GER_VENDEDOR_ID,\n         R_ITEM.PREDBCEFET,\n         R_ITEM.VBCEFET,\n         R_ITEM.PICMSEFET,\n         R_ITEM.VICMSEFET,\n         R_ITEM.VICMSOP,\n         R_ITEM.PDIF,\n         R_ITEM.VICMSDIF);\n    \n      X_ID := R_ITEM.DIE_FAT_NFS_ITEM_RETORNO_ID;\n    \n      FOR R_SERV IN C_SERV LOOP\n        INSERT INTO DIE_FAT_SERVICO\n          (DIE_FAT_SERVICO_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           VALUE,\n           DT_INICIO,\n           DT_FIM,\n           DT_CANCELAMENTO,\n           NRO_AUT_DEVOLUCAO,\n           VLR_PRECO,\n           NRO_SERIE,\n           IND_TIPO_VENDA,\n           COD_SERVICO,\n           DT_ENVIO,\n           BEG_PRODUTO_ID,\n           BEG_PRD_SKU_ID,\n           BEG_FAT_NFS_ITEM_ID,\n           DIE_GER_VENDEDOR_ID,\n           VLR_PRODUTO,\n           DIE_PRD_GARANTIA_ID,\n           BEG_CPR_NFE_ID,\n           DIE_CRC_RECIBO_ID,\n           OBSERVACAO,\n           DATA,\n           CEP,\n           ENDERECO,\n           NUMERO,\n           BAIRRO,\n           CIDADE,\n           ESTADO,\n           TIPORISCO,\n           NRSORTE,\n           APOLICEGAR,\n           APOLICEPF,\n           APOLICERES,\n           BEG_FAT_NFS_ID,\n           NR_RECIBO,\n           BEG_PESSOA_ID,\n           NRO_NOTA,\n           SERIE_NOTA)\n        VALUES\n          (R_SERV.DIE_FAT_SERVICO_RET_ID,\n           R_SERV.AD_CLIENT_ID,\n           R_SERV.AD_ORG_ID,\n           R_SERV.ISACTIVE,\n           R_SERV.CREATED,\n           R_SERV.CREATEDBY,\n           R_SERV.UPDATED,\n           R_SERV.UPDATEDBY,\n           R_SERV.VALUE,\n           trunc(R_SERV.DT_INICIO),\n           trunc(R_SERV.DT_FIM),\n           R_SERV.DT_CANCELAMENTO,\n           R_SERV.NRO_AUT_DEVOLUCAO,\n           R_SERV.VLR_PRECO,\n           null, --R_SERV.NRO_SERIE,\n           R_SERV.IND_TIPO_VENDA,\n           R_SERV.COD_SERVICO,\n           R_SERV.DT_ENVIO,\n           R_SERV.BEG_PRODUTO_ID,\n           R_SERV.BEG_PRD_SKU_ID,\n           V_ID_ITEM, ---BEG_FAT_NFS_ITEM_ID ,\n           R_SERV.DIE_GER_VENDEDOR_ID,\n           R_SERV.VLR_PRODUTO,\n           R_SERV.DIE_PRD_GARANTIA_ID,\n           R_SERV.BEG_CPR_NFE_ID,\n           R_SERV.DIE_CRC_RECIBO_ID,\n           R_SERV.OBSERVACAO,\n           trunc(:NEW.DT_EMISSAO), --R_SERV.DATA,\n           R_SERV.CEP,\n           R_SERV.ENDERECO,\n           R_SERV.NUMERO,\n           R_SERV.BAIRRO,\n           R_SERV.CIDADE,\n           R_SERV.ESTADO,\n           R_SERV.TIPORISCO,\n           R_SERV.NRSORTE,\n           R_SERV.APOLICEGAR,\n           R_SERV.APOLICEPF,\n           R_SERV.APOLICERES,\n           :NEW.DIE_FAT_NFS_RET_ID, --BEG_FAT_NFS_ID      ,\n           R_SERV.NR_RECIBO,\n           :NEW.BEG_VW_PESSOA_ENTREGA_ID,\n           :NEW.NRO_NFS,\n           :NEW.SERIE_NFS);\n      \n        IF R_SERV.NRSORTE IS NOT NULL AND R_SERV.COD_SERVICO IS NULL THEN\n        \n          INSERT INTO DIE_CONTROLE_AP\n            (DIE_CLIENTE_ID,\n             CPF,\n             NRO_SORTE,\n             DATA,\n             CONTADOR,\n             BEG_FAT_NFS_ID,\n             ISACTIVE)\n          VALUES\n            (:NEW.BEG_VW_PESSOA_ENTREGA_ID,\n             :NEW.CPFCNPJ,\n             R_SERV.NRSORTE,\n             trunc(:NEW.DT_EMISSAO),\n             1,\n             :NEW.DIE_FAT_NFS_RET_ID,\n             'Y'\n             \n             );\n        \n        END IF;\n      \n      END LOOP;\n      ------ insere movimento de estoque no almoxarifado de assistencia quando remessa de conserto\n      if :new.beg_est_tp_especie_id = 2000021 AND :NEW.AD_ORG_ID <> 1000016 then\n      \n        insert into BEG_EST_MOVTO_ESTOQUE\n          (BEG_EST_MOVTO_ESTOQUE_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           BEG_EST_TP_ESPECIE_ID,\n           BEG_PRD_SKU_ID,\n           BEG_EST_VW_ALMOX_DESTINO_ID,\n           VLR_MOVTO,\n           QTD_MOVTO,\n           BEG_PRODUTO_ID,\n           DOCUMENTO,\n           BEG_EST_ALMOXARIFADO_ID)\n        values\n          (BEG_FNC_AD_SEQUENCE('BEG_EST_MOVTO_ESTOQUE'),\n           R_ITEM.AD_CLIENT_ID,\n           R_ITEM.AD_ORG_ID,\n           'Y',\n           R_ITEM.CREATED,\n           R_ITEM.CREATEDBY,\n           R_ITEM.UPDATED,\n           R_ITEM.UPDATEDBY,\n           2000019,\n           R_ITEM.BEG_PRD_SKU_ID,\n           V_ALMOX3_ID, --V_ALMOXARIFADO_ID,\n           R_ITEM.VL_UNITARIO,\n           R_ITEM.QTDE,\n           R_ITEM.BEG_PRODUTO_ID,\n           'REM CONSERTO NF: ' || :NEW.NRO_NFS,\n           V_ALMOX2_ID);\n      \n      END IF;\n    \n    END LOOP;\n    --    commit;\n  \n    FOR R_PARC IN C_PARC LOOP\n    \n      -- V_TIT_ID := BEG_FNC_AD_SEQUENCE('BEG_CRC_TITULO');\n      INSERT INTO BEG_CRC_TITULO\n      \n        (\n         \n         BEG_CRC_TITULO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         VALUE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         PARCELA,\n         DT_EMISSAO,\n         DT_VCTO,\n         VLR_TITULO,\n         VLR_MULTA,\n         VLR_JUROS,\n         VLR_DESCONTO,\n         VLR_ABERTO,\n         TP_COBRANCA,\n         NUMERO_TITULO_BANCO,\n         OBS,\n         VLR_DESPESA,\n         BEG_TIPO_TITULO_ID,\n         BEG_PESSOA_ID,\n         BEG_MOEDA_ID,\n         BEG_CONVENIO_ID,\n         BEG_BANCO_ID,\n         SERIE,\n         NUM_NF_SAIDA,\n         IND_ABERTO,\n         DT_ENVIO_BCO,\n         SEQ_ENVIO_BCO,\n         BEG_FILIAL_ID,\n         BEG_CRC_RENEGOCIACAO_ID,\n         IMPRESSO,\n         BEG_COB_AVISO_ID,\n         BEG_FIN_PORTADOR_ID,\n         IND_LOTE_COB_ESCR,\n         BEG_PCE_LOTE_COBRANCA_ID,\n         LINHA_DIGITAVEL,\n         CODIGO_BARRAS,\n         BEG_PCE_COMANDO_REM_COB_ID,\n         BEG_PCE_INSTRUCAO_COBRANCA_ID,\n         BEG_VW_PCE_INSTR_COBR_ID,\n         COMISSAO,\n         BEG_VEN_PEDIDO_ID,\n         BEG_FAT_NFS_ID,\n         VLR_SEGURO,\n         VLR_GARANTIA,\n         VLR_TX_FINANCEIRA,\n         BEG_CRC_LOCALIZACAO_ID,\n         BEG_VW_PREPOSTO_ID,\n         BEG_VW_TELEVENDA_ID,\n         VLR_REAJUSTE,\n         SRDUP,\n         CLASSIF,\n         DT_AVISO_PGTO,\n         NUM_NF_DEVOL,\n         TIPO_DEVOL,\n         DATA_DEVOL,\n         BEG_COB_AVISO_PESSOA_ID,\n         BEG_COBRADOR_ID,\n         VLR_ORIGINAL,\n         DT_GERA_AVISO,\n         IND_COBRADOR,\n         DT_PGTO_COBRANCA,\n         VLR_SEGUROS,\n         DT_PGTO,\n         IND_NEW_PDV)\n      VALUES\n        (\n         \n         --V_TIT_ID,\n         R_PARC.DIE_CRC_TITULO_RETORNO_ID,\n         R_PARC.AD_CLIENT_ID,\n         R_PARC.AD_ORG_ID,\n         R_PARC.ISACTIVE,\n         case\n           when :new.tp_nota = '55' or :new.tp_nfe = 9 then\n            :NEW.NRO_NFS\n           else\n            :new.nro_cupom_fiscal\n         end, --:new.nro_nfs, --R_PARC.VALUE,\n         R_PARC.CREATED,\n         R_PARC.CREATEDBY,\n         R_PARC.UPDATED,\n         R_PARC.UPDATEDBY,\n         R_PARC.PARCELA,\n         trunc(:NEW.DT_EMISSAO),\n         CASE\n           WHEN R_PARC.DT_VCTO < trunc(:NEW.DT_EMISSAO) THEN\n            trunc(:NEW.DT_EMISSAO)\n           ELSE\n            R_PARC.DT_VCTO\n         END,\n         R_PARC.VLR_TITULO,\n         0, --R_PARC.VLR_MULTA                     ,\n         0, -- R_PARC.VLR_JUROS                     ,\n         0, --R_PARC.VLR_DESCONTO                  ,\n         R_PARC.VLR_TITULO,\n         R_PARC.TP_COBRANCA,\n         NULL, --R_PARC.NUMERO_TITULO_BANCO           ,\n         R_PARC.OBS,\n         0, --R_PARC.VLR_DESPESA                   ,\n         R_PARC.BEG_TIPO_TITULO_ID,\n         R_PARC.BEG_PESSOA_ID,\n         R_PARC.BEG_MOEDA_ID,\n         CASE\n           WHEN R_PARC.BEG_CONVENIO_ID = 0 THEN\n            NULL\n           ELSE\n            R_PARC.BEG_CONVENIO_ID\n         END,\n         NULL, --R_PARC.BEG_BANCO_ID                  ,\n         :NEW.SERIE_NFS,\n         case\n           when :new.tp_nota = '55' or :new.tp_nfe = 9 then\n            :NEW.NRO_NFS\n           else\n            :new.nro_cupom_fiscal\n         end, --:new.nro_nfs,\n         'Y', --R_PARC.IND_ABERTO                    ,\n         NULL, --R_PARC.DT_ENVIO_BCO                  ,\n         NULL, --R_PARC.SEQ_ENVIO_BCO                 ,\n         R_PARC.BEG_FILIAL_ID,\n         NULL, --R_PARC.BEG_CRC_RENEGOCIACAO_ID       ,\n         NULL, --R_PARC.IMPRESSO                      ,\n         NULL, --R_PARC.BEG_COB_AVISO_ID              ,\n         NULL, --R_PARC.BEG_FIN_PORTADOR_ID           ,\n         'N', --R_PARC.IND_LOTE_COB_ESCR             ,\n         NULL, --R_PARC.BEG_PCE_LOTE_COBRANCA_ID      ,\n         NULL, --R_PARC.LINHA_DIGITAVEL               ,\n         NULL, --R_PARC.CODIGO_BARRAS                 ,\n         NULL, --R_PARC.BEG_PCE_COMANDO_REM_COB_ID    ,\n         NULL, --R_PARC.BEG_PCE_INSTRUCAO_COBRANCA_ID ,\n         NULL, --R_PARC.BEG_VW_PCE_INSTR_COBR_ID      ,\n         0, --R_PARC.COMISSAO                      ,\n         NULL, --R_PARC.BEG_VEN_PEDIDO_ID             ,\n         :NEW.DIE_FAT_NFS_RET_ID, --R_PARC.BEG_FAT_NFS_ID                ,\n         R_PARC.VLR_SEGURO,\n         R_PARC.VLR_GARANTIA,\n         R_PARC.VLR_TX_FINANCEIRA,\n         NULL, --R_PARC.BEG_CRC_LOCALIZACAO_ID        ,\n         NULL, --R_PARC.BEG_VW_PREPOSTO_ID            ,\n         NULL, --R_PARC.BEG_VW_TELEVENDA_ID           ,\n         0, --R_PARC.VLR_REAJUSTE                  ,\n         R_PARC.SRDUP,\n         R_PARC.CLASSIF,\n         NULL, --R_PARC.DT_AVISO_PGTO                 ,\n         NULL, --R_PARC.NUM_NF_DEVOL                  ,\n         NULL, --R_PARC.TIPO_DEVOL                    ,\n         NULL, --R_PARC.DATA_DEVOL                    ,\n         NULL, --R_PARC.BEG_COB_AVISO_PESSOA_ID       ,\n         NULL, --R_PARC.BEG_COBRADOR_ID               ,\n         0, --R_PARC.VLR_ORIGINAL                  ,\n         NULL, --R_PARC.DT_GERA_AVISO                 ,\n         'N', --R_PARC.IND_COBRADOR                  ,\n         NULL, --R_PARC.DT_PGTO_COBRANCA              ,\n         R_PARC.VLR_SEGUROS,\n         NULL, --  R_PARC.DT_PGTO\n         'Y')\n      \n      ;\n      --    COMMIT;\n      ------------------\n      insert into BEG_CRC_HISTORICO\n        (BEG_CRC_HISTORICO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         value,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         VLR_MOVTO,\n         VLR_JUROS,\n         VLR_MULTA,\n         VLR_DESCONTO,\n         RECIBO_PAGTO,\n         BEG_CRC_TPMOV_ID,\n         BEG_CRC_TITULO_ID)\n      values\n        (BEG_FNC_AD_SEQUENCE('BEG_CRC_HISTORICO'),\n         :new.AD_CLIENT_ID,\n         :new.AD_ORG_ID,\n         :new.ISACTIVE,\n         1,\n         :new.CREATED, --sysdate, -- AOK -- 24/09/2007\n         :new.CREATEDBY,\n         :new.UPDATED, --sysdate, -- AOK -- 24/09/2007\n         :new.UPDATEDBY,\n         R_PARC.VLR_TITULO,\n         0,\n         0,\n         0,\n         null,\n         1000001,\n         R_PARC.DIE_CRC_TITULO_RETORNO_ID);\n    \n      ------------------\n      commit;\n      IF R_PARC.BEG_TIPO_TITULO_ID NOT IN\n         (2500008, 2500004, 2500010, 2500009, 2500014, 2500018) THEN\n        INSERT INTO BEG_CRC_HISTORICO\n          (BEG_CRC_HISTORICO_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           VALUE,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           VLR_MOVTO,\n           VLR_JUROS,\n           VLR_MULTA,\n           VLR_DESCONTO,\n           RECIBO_PAGTO,\n           BEG_CRC_TPMOV_ID,\n           BEG_CRC_TITULO_ID,\n           BEG_PESSOA_COBRADOR_ID,\n           BEG_PESSOA_CAIXA_ID,\n           BEG_BANCO_ID,\n           BEG_FILIAL_PGTO_ID,\n           DT_PGTO,\n           COMISSAO,\n           SEQ_PGTO,\n           VLR_DESPESA,\n           VLR_REAJUSTE,\n           NRO_CAIXA,\n           OBS,\n           LOTE_MANUAL,\n           BEG_VEN_CONV_REC_FAT_LOT_ID,\n           IND_RENEGOCIACAO)\n        VALUES\n          (BEG_FNC_AD_SEQUENCE('BEG_CRC_HISTORICO'),\n           R_PARC.AD_CLIENT_ID,\n           R_PARC.AD_ORG_ID,\n           'Y', --ISACTIVE                    ,\n           '2', --VALUE                       ,\n           R_PARC.CREATED,\n           R_PARC.CREATEDBY,\n           R_PARC.UPDATED,\n           R_PARC.UPDATEDBY,\n           R_PARC.VLR_TITULO, --VLR_MOVTO                   ,\n           0, --VLR_JUROS                   ,\n           0, --VLR_MULTA                   ,\n           0, --VLR_DESCONTO                ,\n           NULL, --RECIBO_PAGTO                ,\n           1000006, --BEG_CRC_TPMOV_ID            ,\n           R_PARC.DIE_CRC_TITULO_RETORNO_ID, --BEG_CRC_TITULO_ID           ,\n           NULL, --BEG_PESSOA_COBRADOR_ID      ,\n           NULL, --BEG_PESSOA_CAIXA_ID         ,\n           NULL, --BEG_BANCO_ID                ,\n           R_PARC.AD_ORG_ID, --BEG_FILIAL_PGTO_ID          ,\n           trunc(:NEW.DT_EMISSAO), --DT_PGTO                     ,\n           NULL, --COMISSAO                    ,\n           NULL, --SEQ_PGTO                    ,\n           0, ---VLR_DESPESA                 ,\n           0, --VLR_REAJUSTE                ,\n           0, --NRO_CAIXA                   ,\n           NULL, --OBS                         ,\n           NULL, --LOTE_MANUAL                 ,\n           NULL, --BEG_VEN_CONV_REC_FAT_LOT_ID ,\n           'N' ---IND_RENEGOCIACAO\n           );\n      \n      END IF;\n      IF R_PARC.BEG_TIPO_TITULO_ID IN\n         (2500008, 2500004, 2500010, 2500009, 2500014, 2500018) AND\n         R_PARC.PARCELA = 0 THEN\n      \n        /* OPEN C_PED;\n        FETCH C_PED\n          INTO R_PED;\n        CLOSE C_PED;*/\n      \n        IF /*NVL(R_PED.RECIENTR, 0)*/\n         :new.die_crc_recibo_id > 0 THEN\n        \n          INSERT INTO BEG_CRC_HISTORICO\n            (BEG_CRC_HISTORICO_ID,\n             AD_CLIENT_ID,\n             AD_ORG_ID,\n             ISACTIVE,\n             VALUE,\n             CREATED,\n             CREATEDBY,\n             UPDATED,\n             UPDATEDBY,\n             VLR_MOVTO,\n             VLR_JUROS,\n             VLR_MULTA,\n             VLR_DESCONTO,\n             RECIBO_PAGTO,\n             BEG_CRC_TPMOV_ID,\n             BEG_CRC_TITULO_ID,\n             BEG_PESSOA_COBRADOR_ID,\n             BEG_PESSOA_CAIXA_ID,\n             BEG_BANCO_ID,\n             BEG_FILIAL_PGTO_ID,\n             DT_PGTO,\n             COMISSAO,\n             SEQ_PGTO,\n             VLR_DESPESA,\n             VLR_REAJUSTE,\n             NRO_CAIXA,\n             OBS,\n             LOTE_MANUAL,\n             BEG_VEN_CONV_REC_FAT_LOT_ID,\n             IND_RENEGOCIACAO)\n          VALUES\n            (BEG_FNC_AD_SEQUENCE('BEG_CRC_HISTORICO'),\n             R_PARC.AD_CLIENT_ID,\n             R_PARC.AD_ORG_ID,\n             'Y', --ISACTIVE                    ,\n             '2', --VALUE                       ,\n             R_PARC.CREATED,\n             R_PARC.CREATEDBY,\n             R_PARC.UPDATED,\n             R_PARC.UPDATEDBY,\n             R_PARC.VLR_TITULO, --VLR_MOVTO                   ,\n             0, --VLR_JUROS                   ,\n             0, --VLR_MULTA                   ,\n             0, --VLR_DESCONTO                ,\n             :new.nrrecibo, --RECIBO_PAGTO                ,\n             1000006, --BEG_CRC_TPMOV_ID            ,\n             R_PARC.DIE_CRC_TITULO_RETORNO_ID, --BEG_CRC_TITULO_ID           ,\n             NULL, --BEG_PESSOA_COBRADOR_ID      ,\n             NULL, --BEG_PESSOA_CAIXA_ID         ,\n             NULL, --BEG_BANCO_ID                ,\n             R_PARC.AD_ORG_ID, --BEG_FILIAL_PGTO_ID          ,\n             trunc(:NEW.DT_EMISSAO), --DT_PGTO                     ,\n             NULL, --COMISSAO                    ,\n             NULL, --SEQ_PGTO                    ,\n             0, ---VLR_DESPESA                 ,\n             0, --VLR_REAJUSTE                ,\n             0, --NRO_CAIXA                   ,\n             NULL, --OBS                         ,\n             NULL, --LOTE_MANUAL                 ,\n             NULL, --BEG_VEN_CONV_REC_FAT_LOT_ID ,\n             'N' ---IND_RENEGOCIACAO\n             );\n        END IF;\n      \n        IF R_PARC.VLR_PAGO > 0 and :new.die_crc_recibo_id is null THEN\n        \n          INSERT INTO BEG_CRC_HISTORICO\n            (BEG_CRC_HISTORICO_ID,\n             AD_CLIENT_ID,\n             AD_ORG_ID,\n             ISACTIVE,\n             VALUE,\n             CREATED,\n             CREATEDBY,\n             UPDATED,\n             UPDATEDBY,\n             VLR_MOVTO,\n             VLR_JUROS,\n             VLR_MULTA,\n             VLR_DESCONTO,\n             RECIBO_PAGTO,\n             BEG_CRC_TPMOV_ID,\n             BEG_CRC_TITULO_ID,\n             BEG_PESSOA_COBRADOR_ID,\n             BEG_PESSOA_CAIXA_ID,\n             BEG_BANCO_ID,\n             BEG_FILIAL_PGTO_ID,\n             DT_PGTO,\n             COMISSAO,\n             SEQ_PGTO,\n             VLR_DESPESA,\n             VLR_REAJUSTE,\n             NRO_CAIXA,\n             OBS,\n             LOTE_MANUAL,\n             BEG_VEN_CONV_REC_FAT_LOT_ID,\n             IND_RENEGOCIACAO)\n          VALUES\n            (BEG_FNC_AD_SEQUENCE('BEG_CRC_HISTORICO'),\n             R_PARC.AD_CLIENT_ID,\n             R_PARC.AD_ORG_ID,\n             'Y', --ISACTIVE                    ,\n             '2', --VALUE                       ,\n             R_PARC.CREATED,\n             R_PARC.CREATEDBY,\n             R_PARC.UPDATED,\n             R_PARC.UPDATEDBY,\n             R_PARC.VLR_TITULO, --VLR_MOVTO                   ,\n             0, --VLR_JUROS                   ,\n             0, --VLR_MULTA                   ,\n             0, --VLR_DESCONTO                ,\n             NULL, --RECIBO_PAGTO                ,\n             1000006, --BEG_CRC_TPMOV_ID            ,\n             R_PARC.DIE_CRC_TITULO_RETORNO_ID, --BEG_CRC_TITULO_ID           ,\n             NULL, --BEG_PESSOA_COBRADOR_ID      ,\n             NULL, --BEG_PESSOA_CAIXA_ID         ,\n             NULL, --BEG_BANCO_ID                ,\n             R_PARC.AD_ORG_ID, --BEG_FILIAL_PGTO_ID          ,\n             trunc(:NEW.DT_EMISSAO), --DT_PGTO                     ,\n             NULL, --COMISSAO                    ,\n             NULL, --SEQ_PGTO                    ,\n             0, ---VLR_DESPESA                 ,\n             0, --VLR_REAJUSTE                ,\n             0, --NRO_CAIXA                   ,\n             NULL, --OBS                         ,\n             NULL, --LOTE_MANUAL                 ,\n             NULL, --BEG_VEN_CONV_REC_FAT_LOT_ID ,\n             'N' ---IND_RENEGOCIACAO\n             );\n        END IF;\n      \n      END IF;\n      COMMIT;\n    END LOOP;\n  \n    OPEN C_PITEM;\n    FETCH C_PITEM\n      INTO R_PITEM;\n    CLOSE C_PITEM;\n  \n    IF R_PITEM.QTD > 0 THEN\n      INSERT INTO DIE_FAT_MONTAGEM\n        (DIE_FAT_MONTAGEM_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         BEG_FAT_NFS_ID,\n         BEG_PESSOA_ID,\n         DT_PREVISAO,\n         DT_BAIXA,\n         OBSERVACAO,\n         NRMONTAGEM,\n         DOCSTATUS)\n      VALUES\n        (BEG_FNC_AD_SEQUENCE('DIE_FAT_MONTAGEM'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         :NEW.ISACTIVE,\n         SYSDATE, --CREATED             ,\n         :NEW.CREATEDBY,\n         SYSDATE, --UPDATED             ,\n         :NEW.UPDATEDBY,\n         :NEW.DIE_FAT_NFS_RET_ID, --BEG_FAT_NFS_ID      ,\n         :NEW.BEG_VW_PESSOA_ENTREGA_ID, --BEG_PESSOA_ID       ,\n         case\n           when (R_PITEM.DT_PREVISAO) < trunc(sysdate) then\n            trunc(sysdate)\n           else\n            R_PITEM.DT_PREVISAO\n         end,\n         NULL,\n         NULL, --OBSERVACAO          ,\n         NULL, --NRMONTAGEM          ,\n         'WC');\n    \n    END IF;\n  \n    ---- INSERE TITULO NA CPG QUANDO DEVOLUCAO DE FORNECEDOR\n    IF :NEW.BEG_EST_TP_ESPECIE_ID = 2000016 THEN\n      OPEN C_CPR_NFE;\n      FETCH C_CPR_NFE\n        INTO R_CPR_NFE;\n      IF C_CPR_NFE%FOUND THEN\n        VN_BEG_CPG_TIPO_TITULO_ID := beg_fnc_retorna_param_geral('Faturamento',\n                                                                 null,\n                                                                 'CPG_TIPO_TITULO_DEV_FORN',\n                                                                 null);\n        VN_BEG_CPG_CONTA_ID       := beg_fnc_retorna_param_geral('Faturamento',\n                                                                 null,\n                                                                 'CPG_CONTA_DEV_FORN',\n                                                                 null);\n        insert into BEG_CPG_TITULO\n          (BEG_CPG_TITULO_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           CREATEDBY,\n           UPDATEDBY,\n           value,\n           PARCELA,\n           DT_EMISSAO,\n           DT_RECEBIMENTO,\n           DT_VCTO,\n           VLR_TITULO,\n           OBS,\n           BEG_PESSOA_ID,\n           BEG_CPG_TIPO_TITULO_ID,\n           BEG_FAT_NFS_ID,\n           BEG_BANCO_ID,\n           BEG_MOEDA_ID,\n           BEG_CPG_CONTA_ID,\n           BEG_VEN_FORMA_PAGAMENTO_ID,\n           BEG_VW_FORNECEDOR_ID)\n        values\n          (BEG_FNC_AD_SEQUENCE('BEG_CPG_TITULO'), -- beg_cpg_titulo_id\n           :NEW.AD_CLIENT_ID, -- ad_client_id\n           :NEW.AD_ORG_ID, -- ad_org_id\n           1000000, -- createdby\n           1000000, -- updatedby\n           :NEW.NRO_NFS, --V_NOTA.NRO_NFS, -- numero\n           1, -- parcela\n           TRUNC(SYSDATE), --V_NOTA.DT_ENTRADA, -- dt_emissao\n           TRUNC(SYSDATE), --V_NOTA.DT_ENTRADA, -- dt_recebimento\n           TRUNC(SYSDATE), --V_NOTA.DT_ENTRADA, -- dt_vcto -- aok - 08/11/2010\n           :NEW.VL_TOTAL_NFS, -- vlr_titulo\n           'TITULO GERADO POR NOTA DEVOLUCAO FORNECEDOR ' ||\n           TO_CHAR(R_CPR_NFE.NUMERO), -- obs\n           R_CPR_NFE.BEG_VW_FORNECEDOR_ID, -- beg_pessoa_id\n           VN_BEG_CPG_TIPO_TITULO_ID, --R_NFE.BEG_CPG_TIPO_TITULO_ID, --VN_BEG_CPG_TIPO_TITULO_ID, -- beg_cpg_tipo_titulo_id\n           :NEW.DIE_FAT_NFS_RET_ID, -- BEG_FAT_NFS_ID\n           R_CPR_NFE.BEG_BANCO_ID, -- beg_banco_id\n           R_CPR_NFE.BEG_MOEDA_ID, -- beg_moeda_id\n           VN_BEG_CPG_CONTA_ID, --R_NFE.BEG_CPG_CONTA_ID, --VN_BEG_CPG_CONTA_ID, -- beg_cpg_conta_id\n           NULL, --R_NFE.BEG_VEN_FORMA_PAGAMENTO_ID, -- beg_ven_forma_pagamento_id\n           R_CPR_NFE.BEG_VW_FORNECEDOR_ID);\n      END IF;\n    END IF;\n    ---------\n    ---- INSERE TITULO NA CPG QUANDO CIAP COM INDICACAO DE GERAR TITULO\n    IF NVL(:NEW.IND_CIAP, 'N') = 'Y' AND\n       NVL(:NEW.IND_PARCELA_CIAP, 'N') = 'Y' THEN\n    \n      VN_BEG_CPG_TIPO_TITULO_ID := beg_fnc_retorna_param_geral('Faturamento',\n                                                               null,\n                                                               'CPG_TIPO_TITULO_DEV_FORN',\n                                                               null);\n      VN_BEG_CPG_CONTA_ID       := beg_fnc_retorna_param_geral('Faturamento',\n                                                               null,\n                                                               'CPG_CONTA_DEV_FORN',\n                                                               null);\n      insert into BEG_CPG_TITULO\n        (BEG_CPG_TITULO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         CREATEDBY,\n         UPDATEDBY,\n         value,\n         PARCELA,\n         DT_EMISSAO,\n         DT_RECEBIMENTO,\n         DT_VCTO,\n         VLR_TITULO,\n         OBS,\n         BEG_PESSOA_ID,\n         BEG_CPG_TIPO_TITULO_ID,\n         BEG_FAT_NFS_ID,\n         BEG_BANCO_ID,\n         BEG_MOEDA_ID,\n         BEG_CPG_CONTA_ID,\n         BEG_VEN_FORMA_PAGAMENTO_ID,\n         BEG_VW_FORNECEDOR_ID)\n      values\n        (BEG_FNC_AD_SEQUENCE('BEG_CPG_TITULO'), -- beg_cpg_titulo_id\n         :NEW.AD_CLIENT_ID, -- ad_client_id\n         :NEW.AD_ORG_ID, -- ad_org_id\n         1000000, -- createdby\n         1000000, -- updatedby\n         :NEW.NRO_NFS, --V_NOTA.NRO_NFS, -- numero\n         1, -- parcela\n         TRUNC(SYSDATE), --V_NOTA.DT_ENTRADA, -- dt_emissao\n         TRUNC(SYSDATE), --V_NOTA.DT_ENTRADA, -- dt_recebimento\n         TRUNC(SYSDATE), --V_NOTA.DT_ENTRADA, -- dt_vcto -- aok - 08/11/2010\n         :NEW.VL_TOTAL_NFS, -- vlr_titulo\n         'TITULO GERADO POR NOTA DEVOLUCAO FORNECEDOR ' ||\n         TO_CHAR(R_CPR_NFE.NUMERO), -- obs\n         :new.beg_vw_pessoa_entrega_id, -- beg_pessoa_id\n         VN_BEG_CPG_TIPO_TITULO_ID, --R_NFE.BEG_CPG_TIPO_TITULO_ID, --VN_BEG_CPG_TIPO_TITULO_ID, -- beg_cpg_tipo_titulo_id\n         :NEW.DIE_FAT_NFS_RET_ID, -- BEG_FAT_NFS_ID\n         R_CPR_NFE.BEG_BANCO_ID, -- beg_banco_id\n         R_CPR_NFE.BEG_MOEDA_ID, -- beg_moeda_id\n         VN_BEG_CPG_CONTA_ID, --R_NFE.BEG_CPG_CONTA_ID, --VN_BEG_CPG_CONTA_ID, -- beg_cpg_conta_id\n         NULL, --R_NFE.BEG_VEN_FORMA_PAGAMENTO_ID, -- beg_ven_forma_pagamento_id\n         :new.beg_vw_pessoa_entrega_id);\n    \n    END IF;\n  \n    :NEW.BEG_FAT_NFS_ID := :NEW.DIE_FAT_NFS_RET_ID;\n    :NEW.DOCSTATUS      := 'CO';\n  \n    UPDATE DIE_PEDIDO\n       SET DOCSTATUS = 'CO'\n     WHERE DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n  \n    UPDATE DIE_PEDIDO_TEMP\n       SET DOCSTATUS = 'CO'\n     WHERE DIE_PEDIDO_TEMP_ID = :NEW.DIE_PEDIDO_ID;\n  \n    UPDATE DIE_ITEPED IP\n       SET IP.VALUE = IP.VALUE\n     WHERE IP.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n  \n    UPDATE DIE_CRC_RECIBO\n       SET DOCSTATUS = 'CO', VLR_SALDO = 0\n     WHERE DIE_FAT_PRE_NFS_ID = :NEW.DIE_FAT_NFS_RET_ID;\n  \n    UPDATE DIE_PES_BONUS_VENDA\n       SET ISACTIVE = 'Y'\n     WHERE DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n  \n    COMMIT;\n  \n  END IF;\n\n  -------- insert de nota denegada\n  IF :NEW.STATUS in (110) AND :NEW.BEG_FAT_NFS_ID IS NULL AND\n     :NEW.TP_LANCTO_CONTABIL = 'S' AND :NEW.DOCSTATUS = 'WC' THEN\n  \n    INSERT INTO BEG_FAT_NFS\n      (BEG_FAT_NFS_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       NRO_NFS,\n       SERIE_NFS,\n       DT_EMISSAO,\n       NRO_DUPLICATA,\n       PERC_ICMS,\n       VL_BASE_CALCULO_ICMS,\n       VL_BASE_ISENTA_ICMS,\n       VL_BASE_OUTRAS_ICMS,\n       VL_ICMS,\n       VL_BASE_CALCULO_IPI,\n       VL_BASE_ISENTA_IPI,\n       VL_BASE_OUTRAS_IPI,\n       VL_IPI,\n       VL_BASE_ICMS_SUBST,\n       VL_ICMS_SUBST,\n       VL_FRETE,\n       VL_SEGURO,\n       VL_OUTRAS_DESPESAS,\n       PERC_DESCONTO,\n       VL_TOTAL_PROD,\n       VL_TOTAL_NFS,\n       PLACA_VEICULO,\n       UF_VEICULO,\n       -- PLACA_VEICULO_REDES       ,\n       -- UF_VEICULO_REDES          ,\n       VL_CUSTO_FINANCEIRO,\n       NRO_CUPON_FISCAL,\n       SERIE_MAQUINA,\n       OBS,\n       PERC_COMISSAO_PEDIDO,\n       INTEGRADO,\n       FATURAVEL,\n       DT_SAIDA,\n       DTHR_ADORG_ID,\n       VL_DESP_FINANCEIRA,\n       GERADO_ARQ_EDI,\n       BEG_VW_PESSOA_ENTREGA_ID,\n       --  BEG_VW_REPRESENTANTE_ID   ,\n       BEG_VW_TRANSPORTADORA_ID,\n       --  BEG_VW_REDESPACHO_ID      ,\n       BEG_CONDICAO_PAGAMENTO_ID,\n       --  BEG_BANCO_ID              ,\n       --  BEG_CFOP_ID               ,\n       BEG_EST_TP_ESPECIE_ID,\n       --  COMISSAO_VENDEDOR         ,\n       --  COMISSAO_TELEVENDA        ,\n       --  QTDE_VOLUME               ,\n       --  PESO_LIQUIDO              ,\n       --  PESO_BRUTO                ,\n       DT_CANCELAMENTO,\n       CANCELADA,\n       BEG_VEN_PEDIDO_ID,\n       DESC_SUFRAMA,\n       --  BEG_VW_PREPOSTO_ID        ,\n       VLR_DESCONTO,\n       DIE_FIN_FINANCEIRA_ID,\n       BEG_CONVENIO_ID,\n       DIE_GER_VENDEDOR_ID,\n       --  NRO_ASSOCIADO             ,\n       VL_GARANTIA,\n       --  TP_DEVOLUCAO              ,\n       --  DT_LIBERACAO              ,\n       --  BEG_APEX_USER_ID          ,\n       LIBERADO,\n       VL_BASE_CALCULO_PIS,\n       VL_PIS,\n       VL_BASE_CALCULO_COFINS,\n       VL_COFINS,\n       PROTOCOLO,\n       BEG_CPG_TPMOV_ID,\n       VL_SEGUROS,\n       BEG_VEN_TIPO_PEDIDO_ID,\n       VLR_INSS,\n       VALOR_IRRF,\n       ALIQ_IRRF,\n       BASE_IRRF,\n       VALOR_ISSQN,\n       ALIQ_ISSQN,\n       BASE_ISSQN,\n       BEG_FRO_ROTA_ID,\n       BEG_VEN_PLANO_VENDA_ID,\n       BEG_EST_ALMOXARIFADO_ID,\n       IND_ISSQN_RETIDO,\n       REGERAR_NFE,\n       ACEITE_ENTRADA,\n       BEG_TIPO_NF_ID,\n       VLR_INFORMADO,\n       DIE_CRC_RECIBO_ID,\n       VFCPUFDEST,\n       VICMSUFDEST,\n       VICMSUFREMET,\n       IND_MANIFESTO,\n       DIE_MAN_TRANSPORTE_ID,\n       DIE_PEDIDO_ID,\n       CHAVE)\n    VALUES\n      (:NEW.DIE_FAT_NFS_RET_ID, --BEG_FAT_NFS_ID          ,\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID,\n       :NEW.ISACTIVE,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       case\n         when :new.tp_nota = '55' or :new.tp_nfe = 9 then\n          :NEW.NRO_NFS\n         else\n          :new.nro_cupom_fiscal\n       end, --:NEW.NRO_NFS,\n       :NEW.SERIE_NFS,\n       trunc(:NEW.DT_EMISSAO),\n       case\n         when :new.tp_nota = '55' or :new.tp_nfe = 9 then\n          :NEW.NRO_NFS\n         else\n          :new.nro_cupom_fiscal\n       end, --:NEW.NRO_NFS, --NRO_DUPLICATA             ,\n       0, --:NEW.PERC_ICMS                 ,\n       :NEW.VL_BASE_CALCULO_ICMS,\n       :NEW.VL_BASE_ISENTA_ICMS,\n       :NEW.VL_BASE_OUTRAS_ICMS,\n       :NEW.VL_ICMS,\n       :NEW.VL_BASE_CALCULO_IPI,\n       :NEW.VL_BASE_ISENTA_IPI,\n       :NEW.VL_BASE_OUTRAS_IPI,\n       :NEW.VL_IPI,\n       :NEW.VL_BASE_ICMS_SUBST,\n       :NEW.VL_ICMS_SUBST,\n       :NEW.VL_FRETE,\n       :NEW.VL_SEGURO,\n       :NEW.VL_OUTRAS_DESPESAS,\n       0, --:NEW.PERC_DESCONTO             ,\n       :NEW.VL_TOTAL_PROD,\n       :NEW.VL_TOTAL_NFS,\n       :NEW.PLACA_VEICULO,\n       :NEW.UF_VEICULO,\n       --:NEW.PLACA_VEICULO_REDES       ,\n       --:NEW.UF_VEICULO_REDES          ,\n       :NEW.VL_CUSTO_FINANCEIRO,\n       case\n         when :new.tp_nota = '55' or :new.tp_nfe = 9 then\n          0\n         else\n          :new.nro_nfs\n       end, --NVL(:NEW.NRO_CUPOM_FISCAL, 0),\n       :NEW.SERIE_MAQUINA,\n       :NEW.OBS || '     ' || :new.retornomotivo,\n       0, --  :NEW.PERC_COMISSAO_PEDIDO      ,\n       NVL(:NEW.INTEGRADO, 'N'),\n       NVL(:NEW.FATURAVEL, 'S'),\n       :NEW.DT_SAIDA,\n       :NEW.DTHR_ADORG_ID,\n       NVL(:NEW.VL_DESP_FINANCEIRA, 0),\n       'N', --  :NEW.GERADO_ARQ_EDI            ,\n       :NEW.BEG_VW_PESSOA_ENTREGA_ID,\n       --  :NEW.BEG_VW_REPRESENTANTE_ID   ,\n       :NEW.BEG_VW_TRANSPORTADORA_ID,\n       --  :NEW.BEG_VW_REDESPACHO_ID      ,\n       :NEW.BEG_CONDICAO_PAGAMENTO_ID,\n       --:NEW.BEG_BANCO_ID              ,\n       --  :NEW.BEG_CFOP_ID               ,\n       :NEW.BEG_EST_TP_ESPECIE_ID,\n       --  :NEW.COMISSAO_VENDEDOR         ,\n       --  :NEW.COMISSAO_TELEVENDA        ,\n       --  :NEW.QTDE_VOLUME               ,\n       --  :NEW.PESO_LIQUIDO              ,\n       --  :NEW.PESO_BRUTO                ,\n       sysdate, --  :NEW.DT_CANCELAMENTO           ,\n       'Y', --CANCELADA                 ,\n       :NEW.BEG_VEN_PEDIDO_ID,\n       :NEW.DESC_SUFRAMA,\n       --  :NEW.BEG_VW_PREPOSTO_ID        ,\n       :NEW.VLR_DESCONTO,\n       :NEW.DIE_FIN_FINANCEIRA_ID,\n       CASE\n         WHEN :NEW.BEG_CONVENIO_ID = 0 THEN\n          NULL\n         ELSE\n          :NEW.BEG_CONVENIO_ID\n       END,\n       :NEW.DIE_GER_VENDEDOR_ID,\n       --  :NEW.NRO_ASSOCIADO             ,\n       :NEW.VLR_GARANTIA, --VL_GARANTIA               ,\n       --:NEW.TP_DEVOLUCAO              ,\n       --  :NEW.DT_LIBERACAO              ,\n       --  :NEW.BEG_APEX_USER_ID          ,\n       'N', --- LIBERADO                  ,\n       :new.vl_base_calculo_icms + :new.vl_base_isenta_icms, --VL_BASE_CALCULO_PIS       ,\n       :NEW.VL_PIS,\n       :new.vl_base_calculo_icms + :new.vl_base_isenta_icms, --VL_BASE_CALCULO_COFINS    ,\n       :NEW.VL_COFINS,\n       :NEW.PROTOCOLO,\n       null, --  :NEW.BEG_CPG_TPMOV_ID          ,\n       :NEW.VLr_SEGUROS,\n       :NEW.BEG_VEN_TIPO_PEDIDO_ID,\n       :NEW.VLR_INSS,\n       :NEW.VALOR_IRRF,\n       :NEW.ALIQ_IRRF,\n       :NEW.BASE_IRRF,\n       :NEW.VALOR_ISSQN,\n       :NEW.ALIQ_ISSQN,\n       :NEW.BASE_ISSQN,\n       :NEW.BEG_FRO_ROTA_ID,\n       :NEW.BEG_VEN_PLANO_VENDA_ID,\n       :NEW.BEG_EST_ALMOXARIFADO_ID,\n       'N', --IND_ISSQN_RETIDO          ,\n       NULL, --REGERAR_NFE               ,\n       NULL, --:NEW.ACEITE_ENTRADA            ,\n       :NEW.BEG_TIPO_NF_ID,\n       NULL, --:NEW.VLR_INFORMADO             ,\n       :NEW.DIE_CRC_RECIBO_ID,\n       :NEW.VFCPUFDEST,\n       :NEW.VICMSUFDEST,\n       :NEW.VICMSUFREMET,\n       case\n         when :new.ad_org_id = 1000016 then\n          'N'\n         ELSE\n          'Y'\n       END, --:NEW.IND_MANIFESTO             ,\n       NULL, --:NEW.DIE_MAN_TRANSPORTE_ID     ,\n       :NEW.DIE_PEDIDO_ID,\n       :NEW.CHAVE);\n  \n    :NEW.BEG_FAT_NFS_ID := :NEW.DIE_FAT_NFS_RET_ID;\n    :NEW.DOCSTATUS      := 'CO';\n  \n    UPDATE DIE_PEDIDO\n       SET DOCSTATUS = 'CO'\n     WHERE DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n  \n    UPDATE DIE_PEDIDO_TEMP\n       SET DOCSTATUS = 'CO'\n     WHERE DIE_PEDIDO_TEMP_ID = :NEW.DIE_PEDIDO_ID;\n  \n    UPDATE DIE_CRC_RECIBO\n       SET DOCSTATUS = 'CO', VLR_SALDO = 0\n     WHERE DIE_FAT_PRE_NFS_ID = :NEW.DIE_FAT_NFS_RET_ID;\n  \n    DELETE DIE_PES_BONUS_VENDA WHERE DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n  \n    COMMIT;\n  \n  END IF;\n\n  -------- insert para nota de devolucao de cliente\n\n  IF INSERTING AND :NEW.BEG_EST_TP_ESPECIE_ID = 2000013 THEN\n  \n    /*    UPDATE BEG_FAT_DEVOLUCAO D\n           SET D.IND_CONVERTIDA = 'Y'\n         WHERE D.BEG_FAT_DEVOLUCAO_ID = :NEW.DIE_FAT_NFS_RET_ID;\n    */\n    UPDATE BEG_PESSOA P\n       SET P.FORNECEDOR = 'Y'\n     WHERE P.BEG_PESSOA_ID = :NEW.BEG_VW_PESSOA_ENTREGA_ID;\n  \n    COMMIT;\n  \n  END IF;\n\n  ------Devolucao cliente\n\n  IF :NEW.STATUS in (100, 150) AND :NEW.BEG_CPR_NFE_ID IS NULL AND\n     :NEW.BEG_EST_TP_ESPECIE_ID = 2000013 AND :NEW.DOCSTATUS = 'WC' THEN\n  \n    UPDATE BEG_FAT_DEVOLUCAO D\n       SET D.IND_CONVERTIDA = 'Y'\n     WHERE D.BEG_FAT_DEVOLUCAO_ID = :NEW.DIE_FAT_NFS_RET_ID;\n  \n    SELECT DIE_PEDIDO_ID\n      INTO V_ID_PED\n      FROM BEG_FAT_NFS\n     WHERE BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID;\n  \n    DELETE DIE_PES_BONUS_VENDA WHERE DIE_PEDIDO_ID = V_ID_PED;\n  \n    V_ID_CPR := BEG_FNC_AD_SEQUENCE('BEG_CPR_NFE');\n  \n    OPEN C_CLIENTE;\n    FETCH C_CLIENTE\n      INTO R_CLIENTE;\n    CLOSE C_CLIENTE;\n  \n    OPEN C_LOJA;\n    FETCH C_LOJA\n      INTO R_LOJA;\n    CLOSE C_LOJA;\n  \n    IF R_CLIENTE.BEG_VW_UF_ID = R_LOJA.BEG_VW_UF_ID THEN\n      V_ID_SAI := 367;\n      V_ID_ENT := 118;\n    ELSE\n      V_ID_SAI := 501;\n      V_ID_ENT := 227;\n    END IF;\n  \n    INSERT INTO BEG_CPR_NFE\n      (\n       \n       BEG_CPR_NFE_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       NUMERO,\n       SERIE,\n       DT_EMISSAO,\n       DT_ENTRADA,\n       VLR_BASE_ICMS,\n       VLR_BASE_ICMS_CALC,\n       VLR_BASE_OUTROS_ICMS,\n       VLR_BASE_ICMS_SUBST,\n       VLR_BASE_ICMS_SUBST_CALC,\n       VLR_BASE_ISENTO_ICMS,\n       VLR_ICMS,\n       VLR_ICMS_CALC,\n       VLR_OUTROS_ICMS,\n       VLR_ICMS_SUBST,\n       VLR_ICMS_SUBST_CALC,\n       VLR_BASE_IPI,\n       VLR_BASE_IPI_CALC,\n       VLR_BASE_OUTROS_IPI,\n       VLR_BASE_ISENTO_IPI,\n       VLR_IPI,\n       VLR_IPI_CALC,\n       VLR_OUTROS_IPI,\n       ALQ_IR,\n       VLR_BASE_IR,\n       VLR_IR,\n       ALQ_INSS,\n       VLR_BASE_INSS,\n       VLR_INSS,\n       ALQ_ISSQN,\n       VLR_BASE_ISSQN,\n       VLR_ISSQN,\n       VLR_FRETE,\n       TP_FRETE,\n       PLACA_VEICULO,\n       VLR_FRETE_RDP,\n       TP_FRETE_RDP,\n       PLACA_VEICULO_RDP,\n       QTD_VOLUMES,\n       DES_VOLUMES,\n       NRO_VOLUMES,\n       PESO_BRUTO,\n       PESO_LIQUIDO,\n       VLR_SEGURO,\n       VLR_DESPESAS_FINANCEIRAS,\n       VLR_OUTRAS_DESPESAS,\n       PER_DESCONTO,\n       VLR_DESCONTO,\n       PER_ACRESCIMO,\n       VLR_ACRESCIMO,\n       VLR_TOTAL_PRODUTOS,\n       VLR_TOTAL_PRODUTOS_CALC,\n       VLR_TOTAL_NOTA,\n       VLR_TOTAL_NOTA_CALC,\n       VLR_TOTAL_FATURADO,\n       VLR_COTACAO,\n       NRO_FATURA,\n       QTD_PARCELAS,\n       DIAS_VENCIMENTO,\n       DOCSTATUS,\n       IND_TITULO_CPG,\n       IND_AUT_PGTO_CPG,\n       IND_ESPECIAL,\n       IND_FRETE_NOTA,\n       IND_NFE_ORDEM,\n       NRO_VIA_IMPRESSA,\n       OBS,\n       OBS_OUTRAS_DESPESAS,\n       BEG_VW_FORNECEDOR_ID,\n       BEG_VW_CFOP_ENT_ID,\n       BEG_VW_CFOP_SAI_ID,\n       BEG_EST_ALMOXARIFADO_ID,\n       BEG_VW_TRANSPORTADORA_ID,\n       BEG_PRD_UNIDADE_ID,\n       BEG_VW_REDESPACHO_ID,\n       BEG_UF_ID,\n       BEG_VW_UF_RDP_ID,\n       BEG_CONDICAO_PAGAMENTO_ID,\n       BEG_VW_CPR_CND_PGTO_NFE_ID,\n       BEG_VEN_FORMA_PAGAMENTO_ID,\n       BEG_BANCO_ID,\n       BEG_MOEDA_ID,\n       IND_DESCONTO_NOTA,\n       IND_ACRESCIMO_NOTA,\n       IND_DESCONTO_BASE_ICMS,\n       IND_ACRESCIMO_BASE_ICMS,\n       IND_DESCONTO_BASE_IPI,\n       IND_ACRESCIMO_BASE_IPI,\n       VLR_PAGO_NF_DEVOL,\n       IND_DUP_DEVOL,\n       TP_VENDA_DEVOL,\n       BEG_EST_TP_ESPECIE_ID,\n       BEG_CPG_CONTA_ID,\n       TP_DEVOLUCAO,\n       DIE_MOTIVO_DEVOL_ID,\n       DIE_GER_VENDEDOR_ID,\n       VALORPAGO,\n       PERC_REDUCAO_ICMS,\n       IND_EXCLUI_TODOS_ITENS,\n       IND_EXCLUI_ITENS_INATIVOS,\n       PROTOCOLO,\n       BEG_FAT_NFS_ID,\n       VLR_BASE_CALCULO_PIS,\n       VLR_PIS,\n       VLR_BASE_CALCULO_COFINS,\n       VLR_COFINS,\n       VLR_TOTAL_PISCOFINS,\n       CHAVE_NFE,\n       BEG_CPG_TIPO_TITULO_ID,\n       VLR_FUNRURAL,\n       P_SERVICO,\n       TARIFA_DOC,\n       BEG_FIS_COD_MODELO_ID,\n       IND_CARGA_SIAD,\n       IND_EMITIDA_FATURAMENTO,\n       IND_ICMS_TOTAL_NOTA,\n       BEG_FAT_PRE_NFS_ID,\n       TP_LANCTO_CONTABIL,\n       BEG_TIPO_NF_ID,\n       TIPO_NFE,\n       BEG_CST_CALCULO_ID,\n       BEG_VW_FIS_COD_MODELO_ID,\n       BEG_CPR_ORDEM_ID,\n       IND_GERADA_XML,\n       PERC_ST_OC,\n       VLR_INFORMADO,\n       IND_APROV_ICMS,\n       DIE_NFE_DESPESAS_ID,\n       DT_CANCELAMENTO,\n       DIE_ISSQN_SUBITEM_ID,\n       DIE_FAT_NFS_RET_ID\n       \n       )\n    VALUES\n      (V_ID_CPR,\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID,\n       :NEW.ISACTIVE,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       case when :new.tp_nota = '55' or :new.tp_nfe = 9 then :NEW.NRO_NFS else\n       :new.nro_cupom_fiscal end, --:NEW.NRO_NFS,\n       :NEW.Serie_Nfs, --SERIE,\n       trunc(:NEW.DT_EMISSAO),\n       trunc(:NEW.DT_EMISSAO), --DT_ENTRADA,\n       NVL(:NEW.Vl_Base_Calculo_Icms, 0), --VLR_BASE_ICMS,\n       NVL(:NEW.Vl_Base_Calculo_Icms, 0), --VLR_BASE_ICMS_CALC,\n       NVL(:NEW.Vl_Base_Outras_Icms, 0), --VLR_BASE_OUTROS_ICMS,\n       NVL(:NEW.Vl_Base_Icms_Subst, 0), --VLR_BASE_ICMS_SUBST,\n       NVL(:NEW.Vl_Base_Icms_Subst, 0), --VLR_BASE_ICMS_SUBST_CALC,\n       0, --NVL(:NEW.Vl_Base_Isenta_Icms, 0), --VLR_BASE_ISENTO_ICMS,\n       NVL(:NEW.VL_ICMS, 0),\n       NVL(:NEW.Vl_Icms, 0), --VLR_ICMS_CALC,\n       0, --VLR_OUTROS_ICMS,\n       NVL(:NEW.Vl_Icms_Subst, 0), --VLR_ICMS_SUBST,\n       NVL(:NEW.Vl_Icms_Subst, 0), --VLR_ICMS_SUBST_CALC,\n       NVL(:NEW.Vl_Base_Calculo_Ipi, 0), --VLR_BASE_IPI,\n       NVL(:NEW.Vl_Base_Calculo_Ipi, 0), --VLR_BASE_IPI_CALC,\n       NVL(:NEW.Vl_Base_Outras_Ipi, 0), --VLR_BASE_OUTROS_IPI,\n       NVL(:NEW.Vl_Base_Isenta_Ipi, 0), --VLR_BASE_ISENTO_IPI,\n       NVL(:NEW.VL_IPI, 0),\n       NVL(:NEW.VL_IPI, 0), --VLR_IPI_CALC,\n       0, --VLR_OUTROS_IPI,\n       0, --ALQ_IR,\n       0, --VLR_BASE_IR,\n       0, --VLR_IR,\n       0, --ALQ_INSS,\n       0, --VLR_BASE_INSS,\n       0, --VLR_INSS,\n       0, --ALQ_ISSQN,\n       0, --VLR_BASE_ISSQN,\n       0, --VLR_ISSQN,\n       NVL(:NEW.Vl_Frete, 0), -- VLR_FRETE,\n       NVL(:NEW.TP_FRETE, 'C'),\n       :NEW.PLACA_VEICULO,\n       0, --VLR_FRETE_RDP,\n       null, --:NEW.TP_FRETE_RDP,\n       null, --:NEW.PLACA_VEICULO_RDP,\n       NVL(:NEW.Qtd_Volume, 0), --QTD_VOLUMES,\n       null, --DES_VOLUMES,\n       0, --:NEW.NRO_VOLUMES,\n       NVL(:NEW.Peso_Bruto, 0), --PESO_BRUTO,\n       NVL(:NEW.PESO_LIQUIDO, 0),\n       0, --:NEW.VL_SEGURO,\n       0, --NVL(:NEW.Vl_Desp_Financeira, 0), --VLR_DESPESAS_FINANCEIRAS,\n       NVL(:NEW.VL_OUTRAS_DESPESAS, 0),\n       0, --PER_DESCONTO,\n       0, --NVL(:NEW.VLR_DESCONTO, 0),\n       0, --PER_ACRESCIMO,\n       0, --NVL(:NEW.Vl_Custo_Financeiro, 0), --VLR_ACRESCIMO,\n       NVL(:NEW.Vl_Total_Prod, 0), --VLR_TOTAL_PRODUTOS,\n       0, --VLR_TOTAL_PRODUTOS_CALC,\n       NVL(:NEW.Vl_Total_Nfs, 0) - NVL(:NEW.Vl_Custo_Financeiro, 0) -\n       NVL(:NEW.VLR_SEGUROS, 0), --VLR_TOTAL_NOTA,\n       0, --VLR_TOTAL_NOTA_CALC,\n       0, --VLR_TOTAL_FATURADO,\n       0, --VLR_COTACAO,\n       null, --NRO_FATURA,\n       null, --QTD_PARCELAS,\n       null, --DIAS_VENCIMENTO,\n       'WC', --DOCSTATUS,\n       'N', --IND_TITULO_CPG,\n       'N', --IND_AUT_PGTO_CPG,\n       'N', --IND_ESPECIAL,\n       case when :NEW.VL_FRETE > 0 then 'Y' else 'N' end, --:NEW.IND_FRETE_NOTA,\n       'N', --IND_NFE_ORDEM,\n       0, --NRO_VIA_IMPRESSA,\n       :NEW.OBS,\n       NULL, --OBS_OUTRAS_DESPESAS,\n       :NEW.BEG_VW_FORNECEDOR_ID,\n       V_ID_ENT, --BEG_VW_CFOP_ENT_ID,\n       V_ID_SAI, --BEG_VW_CFOP_SAI_ID,\n       NULL, --BEG_EST_ALMOXARIFADO_ID,\n       :NEW.BEG_VW_TRANSPORTADORA_ID,\n       NULL, --:NEW.BEG_PRD_UNIDADE_ID,\n       NULL, --:NEW.BEG_VW_REDESPACHO_ID,\n       NULL, --:NEW.BEG_UF_ID,\n       NULL, --:NEW.BEG_VW_UF_RDP_ID,\n       NULL, --:NEW.BEG_CONDICAO_PAGAMENTO_ID,\n       NULL, --:NEW.BEG_VW_CPR_CND_PGTO_NFE_ID,\n       NULL, --:NEW.BEG_VEN_FORMA_PAGAMENTO_ID,\n       NULL, --:NEW.BEG_BANCO_ID,\n       NULL, --:NEW.BEG_MOEDA_ID,\n       case when :new.vlr_desconto > 0 then 'Y' else 'N' end, --:NEW.IND_DESCONTO_NOTA,\n       'N', --:NEW.IND_ACRESCIMO_NOTA,\n       'N', --:NEW.IND_DESCONTO_BASE_ICMS,\n       'N', --:NEW.IND_ACRESCIMO_BASE_ICMS,\n       'N', --:NEW.IND_DESCONTO_BASE_IPI,\n       'N', --:NEW.IND_ACRESCIMO_BASE_IPI,\n       0, --:NEW.VLR_PAGO_NF_DEVOL,\n       'N', --:NEW.IND_DUP_DEVOL,\n       NULL, --:NEW.TP_VENDA_DEVOL,\n       :NEW.BEG_EST_TP_ESPECIE_ID,\n       2001593, --:NEW.BEG_CPG_CONTA_ID,\n       'T', ---:NEW.TP_DEVOLUCAO,\n       NULL, --:NEW.DIE_MOTIVO_DEVOL_ID,\n       :NEW.DIE_GER_VENDEDOR_ID,\n       0, --:NEW.VALORPAGO,\n       0, --PERC_REDUCAO_ICMS,\n       'N', --:NEW.IND_EXCLUI_TODOS_ITENS,\n       'N', --:NEW.IND_EXCLUI_ITENS_INATIVOS,\n       NULL, --:NEW.PROTOCOLO,\n       :NEW.BEG_FAT_NFS_ID,\n       NVL(:NEW.VL_TOT_SEM_SERVICOS, 0), --VLR_BASE_CALCULO_PIS,\n       NVL(:NEW.VL_PIS, 0),\n       NVL(:NEW.VL_TOT_SEM_SERVICOS, 0), --VLR_BASE_CALCULO_COFINS,\n       NVL(:NEW.VL_COFINS, 0),\n       0, --:NEW.VLR_TOTAL_PISCOFINS,\n       :NEW.CHAVE, --CHAVE_NFE,\n       NULL, --:NEW.BEG_CPG_TIPO_TITULO_ID,\n       0, --:NEW.VLR_FUNRURAL,\n       'N', --:NEW.P_SERVICO,\n       0, --:NEW.TARIFA_DOC,\n       NULL, --:NEW.BEG_FIS_COD_MODELO_ID,\n       'N', --:NEW.IND_CARGA_SIAD,\n       'N', --:NEW.IND_EMITIDA_FATURAMENTO,\n       'N', --:NEW.IND_ICMS_TOTAL_NOTA,\n       NULL, --:NEW.BEG_FAT_PRE_NFS_ID,\n       'E', --:NEW.TP_LANCTO_CONTABIL,\n       :NEW.BEG_TIPO_NF_ID,\n       null, --:NEW.TIPO_NFE,\n       null, --:NEW.BEG_CST_CALCULO_ID,\n       null, --:NEW.BEG_VW_FIS_COD_MODELO_ID,\n       null, --:NEW.BEG_CPR_ORDEM_ID,\n       null, --:NEW.IND_GERADA_XML,\n       0, --:NEW.PERC_ST_OC,\n       0, --:NEW.VLR_INFORMADO,\n       null, --:NEW.IND_APROV_ICMS,\n       null, --:NEW.DIE_NFE_DESPESAS_ID,\n       null, --:NEW.DT_CANCELAMENTO,\n       null, --:NEW.DIE_ISSQN_SUBITEM_ID\n       :NEW.DIE_FAT_NFS_RET_ID);\n  \n    --  COMMIT;\n  \n    UPDATE DIE_CONTROLE_AP A\n       SET A.ISACTIVE = 'N'\n     WHERE A.BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID;\n  \n    V_SEQ := 0;\n    FOR R_ITEM IN C_ITEM LOOP\n      V_ID_ITEM   := BEG_FNC_AD_SEQUENCE('BEG_CPR_NFE_ITEM');\n      V_SEQ       := V_SEQ + 1;\n      V_ID_IT_DEV := R_ITEM.BEG_FAT_DEVOLUCAO_ITEM_ID;\n    \n      V_ID_CFOP := R_ITEM.BEG_CFOP_ID;\n    \n      OPEN C_CFOP;\n      FETCH C_CFOP\n        INTO R_CFOP;\n      CLOSE C_CFOP;\n    \n      V_ID_ENT := R_CFOP.BEG_VW_CFOP_ENT_ID;\n      V_ID_SAI := R_CFOP.BEG_VW_CFOP_SAI_ID;\n    \n      INSERT INTO BEG_CPR_NFE_ITEM\n        (BEG_CPR_NFE_ITEM_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         SEQUENCIA,\n         QTD,\n         DES_ITEM_FORNECEDOR,\n         VLR_UNITARIO,\n         VLR_TOTAL,\n         VLR_TOTAL_CALC,\n         ALQ_ICMS,\n         ALQ_OUTROS_ICMS,\n         ALQ_ICMS_SUBST,\n         VLR_BASE_ICMS,\n         VLR_BASE_ICMS_CALC,\n         VLR_BASE_OUTROS_ICMS,\n         VLR_BASE_ICMS_SUBST,\n         VLR_BASE_ICMS_SUBST_CALC,\n         VLR_BASE_ISENTO_ICMS,\n         VLR_ICMS,\n         VLR_ICMS_CALC,\n         VLR_OUTROS_ICMS,\n         VLR_ICMS_SUBST,\n         VLR_ICMS_SUBST_CALC,\n         ALQ_IPI,\n         ALQ_OUTROS_IPI,\n         VLR_BASE_IPI,\n         VLR_BASE_IPI_CALC,\n         VLR_BASE_OUTROS_IPI,\n         VLR_BASE_ISENTO_IPI,\n         VLR_IPI,\n         VLR_IPI_CALC,\n         VLR_OUTROS_IPI,\n         ALQ_ISSQN,\n         VLR_BASE_ISSQN,\n         VLR_ISSQN,\n         VLR_FRETE,\n         VLR_FRETE_RDP,\n         QTD_VOLUMES,\n         PESO_BRUTO,\n         PESO_LIQUIDO,\n         VLR_SEGURO,\n         VLR_DESPESAS_FINANCEIRAS,\n         VLR_OUTRAS_DESPESAS,\n         PER_DESCONTO,\n         VLR_DESCONTO,\n         PER_ACRESCIMO,\n         VLR_ACRESCIMO,\n         IND_FRETE_NOTA,\n         OBS,\n         OBS_OUTRAS_DESPESAS,\n         BEG_CPR_NFE_ID,\n         BEG_PRODUTO_ID,\n         BEG_PRD_SKU_ID,\n         BEG_VW_CFOP_ENT_ID,\n         BEG_VW_CFOP_SAI_ID,\n         BEG_PRD_NCM_ID,\n         BEG_FIS_TRIB_ICMS_ID,\n         BEG_FIS_ORIGEM_MERC_ID,\n         BEG_EST_ALMOXARIFADO_ID,\n         IND_DESCONTO_ITEM,\n         IND_ACRESCIMO_ITEM,\n         IND_DESCONTO_BASE_ICMS,\n         IND_ACRESCIMO_BASE_ICMS,\n         IND_DESCONTO_BASE_IPI,\n         IND_ACRESCIMO_BASE_IPI,\n         BEG_CST_CALCULO_ID,\n         VLR_APURADO,\n         VLR_SUGERIDO,\n         VLR_VIGENTE,\n         ALQ_MARGEM,\n         PER_VARIACAO,\n         BEG_VW_NF_ORIGEM_ID,\n         BEG_VW_NF_ORIGEM_ITEM_ID,\n         BEG_EST_MOVTO_ESTOQUE_ID,\n         CST_PIS,\n         VLR_BASE_CALCULO_PIS,\n         PERC_PIS,\n         VLR_PIS,\n         CST_COFINS,\n         VLR_BASE_CALCULO_COFINS,\n         PERC_COFINS,\n         VLR_COFINS,\n         CST_ICMS,\n         PERC_REDUCAO_ICMS,\n         VLR_PISCOFINS,\n         NRO_ADICAO_DI,\n         VLR_DESP_ACES_IMP,\n         VL_IMPOSTO_IMPORTACAO,\n         VLR_BASE_COFINS,\n         ALQ_COFINS,\n         VLR_BASE_PIS,\n         ALQ_PIS,\n         BEG_VW_FORNECEDOR_ID,\n         BEG_VW_UF_ID,\n         LOCAL_DESEMBARACO,\n         DT_DESEMBARACO_ADUANA,\n         DT_REGISTRO_DI,\n         NRO_ACDRAWBACK,\n         NRO_DOC_IMPORTACAO,\n         BEG_FIS_CST_IPI_ID,\n         BEG_FIS_CST_PIS_ID,\n         BEG_FIS_CST_COFINS_ID,\n         BEG_TIPO_NF_ID,\n         BEG_FAT_PRE_NFS_ID,\n         BEG_FAT_PRE_NFS_ITEM_ID,\n         PER_ACRE_TMP,\n         PER_DESC_TMP,\n         PERC_MVAST,\n         PERC_REDUCAO_VLR_ICMS,\n         QTD_ORDEM,\n         PERC_ST_OC,\n         VLR_ITEM_ORDEM_COMPRA,\n         BEG_CPR_ORDEM_ID)\n      VALUES\n        (\n         \n         V_ID_ITEM,\n         R_ITEM.AD_CLIENT_ID,\n         R_ITEM.AD_ORG_ID,\n         R_ITEM.ISACTIVE,\n         R_ITEM.CREATED,\n         R_ITEM.CREATEDBY,\n         R_ITEM.UPDATED,\n         R_ITEM.UPDATEDBY,\n         V_SEQ, --R_ITEM.SEQUENCIA                ,\n         nvl(R_ITEM.QTDE, 0),\n         R_ITEM.DESC_TECNICA_ITEM,\n         nvl(R_ITEM.VL_UNITARIO, 0),\n         nvl(R_ITEM.TOTAL_BRUTO, 0),\n         nvl(R_ITEM.TOTAL_BRUTO, 0),\n         CASE WHEN nvl(R_ITEM.VL_BASE_CALCULO_ICMS, 0) = 0 THEN 0 ELSE\n         nvl(R_ITEM.PERC_ICMS, 0) END,\n         0, --R_ITEM.ALIQ_OUTRAS_ICMS          ,\n         nvl(R_ITEM.ALIQ_ICMS_SUBST, 0),\n         nvl(R_ITEM.VL_BASE_CALCULO_ICMS, 0),\n         nvl(R_ITEM.VL_BASE_CALCULO_ICMS, 0),\n         nvl(R_ITEM.VL_BASE_OUTRAS_ICMS, 0),\n         nvl(R_ITEM.VL_BASE_SUBST_TRIB, 0),\n         nvl(R_ITEM.VL_BASE_SUBST_TRIB, 0),\n         nvl(R_ITEM.VL_BASE_ISENTA_ICMS, 0),\n         nvl(R_ITEM.VL_ICMS, 0),\n         nvl(R_ITEM.VL_ICMS, 0),\n         0, --R_ITEM.VL_OUTRAS_ICMS          ,\n         nvl(R_ITEM.VL_ICMS_SUBST, 0),\n         nvl(R_ITEM.VL_ICMS_SUBST, 0),\n         0, --R_ITEM.ALIQ_IPI,\n         0, --R_ITEM.ALQ_OUTROS_IPI           ,\n         0, --R_ITEM.VL_BASE_CALCULO_IPI,\n         0, --R_ITEM.VL_BASE_CALCULO_IPI,\n         0, --R_ITEM.VL_BASE_OUTRAS_IPI,\n         0, --R_ITEM.VLR_BASE_ISENTO_IPI      ,\n         0, --R_ITEM.VL_IPI,\n         0, --R_ITEM.VL_IPI,\n         0, --R_ITEM.VL_OUTROS_IPI           ,\n         0, -- R_ITEM.ALQ_ISSQN                ,\n         0, --R_ITEM.VLR_BASE_ISSQN           ,\n         0, --R_ITEM.VLR_ISSQN                ,\n         R_ITEM.VL_FRETE_ITEM,\n         0, --R_ITEM.VLR_FRETE_RDP            ,\n         0, --R_ITEM.QTD_VOLUMES              ,\n         nvl(R_ITEM.PESO_BRUTO, 0),\n         nvl(R_ITEM.PESO_LIQUIDO, 0),\n         0, --R_ITEM.VL_SEGURO               ,\n         0, --R_ITEM.VL_DESPESAS_FINANCEIRAS ,\n         R_ITEM.VL_OUTRAS_DESPESAS,\n         0, --R_ITEM.PER_DESCONTO             ,\n         R_ITEM.VL_DESCONTO,\n         0, --R_ITEM.PER_ACRESCIMO            ,\n         0, --R_ITEM.VLR_ACRESCIMO            ,\n         CASE WHEN :NEW.VL_FRETE > 0 THEN 'Y' ELSE 'N' END, --R_ITEM.IND_FRETE_NOTA           ,\n         NULL, --R_ITEM.OBS                      ,\n         NULL, --R_ITEM.OBS_OUTRAS_DESPESAS      ,\n         V_ID_CPR, --R_ITEM.BEG_CPR_NFE_ID           ,\n         R_ITEM.BEG_PRODUTO_ID,\n         R_ITEM.BEG_PRD_SKU_ID,\n         V_ID_ENT, --R_ITEM.BEG_VW_CFOP_ENT_ID       ,\n         V_ID_SAI, --R_ITEM.BEG_CFOP_ID,\n         R_ITEM.BEG_PRD_NCM_ID,\n         R_ITEM.BEG_FIS_TRIB_ICMS_ID,\n         R_ITEM.BEG_FIS_ORIGEM_MERC_ID,\n         NULL, --R_ITEM.BEG_EST_ALMOXARIFADO_ID  ,\n         CASE WHEN R_ITEM.VL_DESCONTO > 0 THEN 'Y' ELSE 'N' END, --R_ITEM.IND_DESCONTO_ITEM        ,\n         'N', --R_ITEM.IND_ACRESCIMO_ITEM       ,\n         'N', --R_ITEM.IND_DESCONTO_BASE_ICMS   ,\n         'N', --R_ITEM.IND_ACRESCIMO_BASE_ICMS  ,\n         'N', --R_ITEM.IND_DESCONTO_BASE_IPI    ,\n         'N', --R_ITEM.IND_ACRESCIMO_BASE_IPI   ,\n         NULL, --R_ITEM.BEG_CST_CALCULO_ID       ,\n         0, --R_ITEM.VLR_APURADO              ,\n         0, --R_ITEM.VLR_SUGERIDO             ,\n         0, --R_ITEM.VLR_VIGENTE              ,\n         0, --R_ITEM.ALIQ_MARGEM               ,\n         0, --R_ITEM.PER_VARIACAO             ,\n         NULL, --R_ITEM.BEG_VW_NF_ORIGEM_ID      ,\n         NULL, --R_ITEM.BEG_VW_NF_ORIGEM_ITEM_ID ,\n         NULL, --R_ITEM.BEG_EST_MOVTO_ESTOQUE_ID ,\n         R_ITEM.CST_PIS,\n         nvl(R_ITEM.VL_BASE_CALCULO_PIS, 0),\n         nvl(R_ITEM.PERC_PIS, 0),\n         nvl(R_ITEM.VL_PIS, 0),\n         R_ITEM.CST_COFINS,\n         nvl(R_ITEM.VL_BASE_CALCULO_COFINS, 0),\n         nvl(R_ITEM.ALIQ_COFINS, 0),\n         nvl(R_ITEM.VLR_COFINS, 0),\n         R_ITEM.CST,\n         nvl(R_ITEM.PERC_REDUCAO, 0),\n         0, --R_ITEM.VL_PISCOFINS            ,\n         NULL, --R_ITEM.NRO_ADICAO_DI            ,\n         0, --R_ITEM.VLR_DESP_ACES_IMP        ,\n         0, --R_ITEM.VL_IMPOSTO_IMPORTACAO    ,\n         nvl(R_ITEM.VL_BASE_CALCULO_COFINS, 0),\n         nvl(R_ITEM.ALIQ_COFINS, 0),\n         nvl(R_ITEM.VL_BASE_CALCULO_PIS, 0),\n         nvl(R_ITEM.ALIQ_PIS, 0),\n         :NEW.BEG_VW_FORNECEDOR_ID,\n         NULL, --R_ITEM.BEG_VW_UF_ID             ,\n         NULL, --R_ITEM.LOCAL_DESEMBARACO        ,\n         NULL, --R_ITEM.DT_DESEMBARACO_ADUANA    ,\n         NULL, --R_ITEM.DT_REGISTRO_DI           ,\n         NULL, --R_ITEM.NRO_ACDRAWBACK           ,\n         NULL, --R_ITEM.NRO_DOC_IMPORTACAO       ,\n         NULL, --R_ITEM.BEG_FIS_CST_IPI_ID       ,\n         NULL, --R_ITEM.BEG_FIS_CST_PIS_ID       ,\n         NULL, --R_ITEM.BEG_FIS_CST_COFINS_ID    ,\n         NULL, --R_ITEM.BEG_TIPO_NF_ID           ,\n         NULL, --R_ITEM.BEG_FAT_PRE_NFS_ID       ,\n         NULL, --R_ITEM.BEG_FAT_PRE_NFS_ITEM_ID  ,\n         0, --R_ITEM.PER_ACRE_TMP             ,\n         0, --R_ITEM.PER_DESC_TMP             ,\n         0, --R_ITEM.PERC_MVAST               ,\n         0, --R_ITEM.PERC_REDUCAO_VLR_ICMS    ,\n         0, --R_ITEM.QTD_ORDEM                ,\n         0, --R_ITEM.PERC_ST_OC               ,\n         0, --R_ITEM.VLR_ITEM_ORDEM_COMPRA    ,\n         NULL --R_ITEM.BEG_CPR_ORDEM_ID\n         );\n    \n      OPEN C_DEV_IT;\n      FETCH C_DEV_IT\n        INTO R_DEV_IT;\n      CLOSE C_DEV_IT;\n    \n      V_ID_IT_VEN := R_DEV_IT.BEG_FAT_NFS_ITEM_ID;\n    \n      open BUSCA_HST;\n      fetch BUSCA_HST\n        into R_HST;\n      close BUSCA_HST;\n    \n      IF R_HST.BEG_HST_NOTA_FISCAL_ID IS NOT NULL THEN\n      \n        INSERT INTO BEG_HST_NF_VINCULADA\n          (BEG_HST_NF_VINCULADA_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           BEG_FAT_NFS_ID,\n           BEG_FAT_NFS_ITEM_ID,\n           BEG_CPR_NFE_ID,\n           BEG_CPR_NFE_ITEM_ID,\n           BEG_HST_NOTA_FISCAL_ID,\n           QTD)\n        VALUES\n          (BEG_FNC_AD_SEQUENCE('BEG_HST_NF_VINCULADA'),\n           :NEW.AD_CLIENT_ID,\n           :NEW.AD_ORG_ID,\n           :NEW.ISACTIVE,\n           :NEW.CREATED,\n           :NEW.CREATEDBY,\n           :NEW.UPDATED,\n           :NEW.UPDATEDBY,\n           NULL, --BEG_FAT_NFS_ID          ,\n           NULL, --BEG_FAT_NFS_ITEM_ID     ,\n           V_ID_CPR, --BEG_CPR_NFE_ID          ,\n           V_ID_ITEM, --BEG_CPR_NFE_ITEM_ID     ,\n           R_HST.BEG_HST_NOTA_FISCAL_ID,\n           R_ITEM.QTDE);\n      \n      END IF;\n    \n      UPDATE DIE_FAT_SERVICO S\n         SET S.DT_CANCELAMENTO = trunc(:NEW.DT_EMISSAO),\n             S.BEG_CPR_NFE_ID  = V_ID_CPR\n       WHERE S.BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID\n         AND S.BEG_FAT_NFS_ITEM_ID = V_ID_IT_VEN;\n    \n    END LOOP;\n  \n    :NEW.BEG_CPR_NFE_ID := V_ID_CPR;\n  \n    OPEN C_DEV;\n    FETCH C_DEV\n      INTO R_DEV;\n    CLOSE C_DEV;\n  \n    IF R_DEV.DEVOLUCAO_INTEGRAL = 'Y' THEN\n    \n      UPDATE BEG_CRC_TITULO T\n         SET T.NUM_NF_DEVOL = :NEW.NRO_NFS,\n             T.DATA_DEVOL   = trunc(:NEW.DT_EMISSAO),\n             T.TIPO_DEVOL   = 'T'\n       WHERE T.BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID\n         AND T.IND_ABERTO = 'Y';\n    ELSE\n    \n      UPDATE BEG_CPR_NFE N\n         SET N.TP_DEVOLUCAO = 'P'\n       WHERE N.BEG_CPR_NFE_ID = :NEW.BEG_CPR_NFE_ID;\n    \n    END IF;\n    :NEW.DOCSTATUS := 'CO';\n  \n    COMMIT;\n  \n    V_RESULT := BEG_FNC_APROVA_NOTA(:NEW.BEG_CPR_NFE_ID);\n  \n    COMMIT;\n  END IF;\n\n  ------Retorno Conserto\n\n  IF :NEW.STATUS in (100, 150) AND :NEW.BEG_CPR_NFE_ID IS NULL AND\n     :NEW.BEG_EST_TP_ESPECIE_ID = 2000022 AND :NEW.DOCSTATUS = 'WC' THEN\n  \n    V_ID_CPR := BEG_FNC_AD_SEQUENCE('BEG_CPR_NFE');\n  \n    OPEN BUSCA_ALMOX;\n    FETCH BUSCA_ALMOX\n      INTO R_ALMOX;\n    CLOSE BUSCA_ALMOX;\n  \n    OPEN BUSCA_ALMOX1;\n    FETCH BUSCA_ALMOX1\n      INTO R_ALMOX1;\n    CLOSE BUSCA_ALMOX1;\n  \n    V_ALMOX2_ID := R_ALMOX1.BEG_EST_ALMOXARIFADO_ID;\n    V_ALMOX3_ID := R_ALMOX.BEG_EST_ALMOXARIFADO_ID;\n  \n    OPEN C_CLIENTE;\n    FETCH C_CLIENTE\n      INTO R_CLIENTE;\n    CLOSE C_CLIENTE;\n  \n    OPEN C_LOJA;\n    FETCH C_LOJA\n      INTO R_LOJA;\n    CLOSE C_LOJA;\n  \n    IF R_CLIENTE.BEG_VW_UF_ID = R_LOJA.BEG_VW_UF_ID THEN\n      V_ID_SAI := 454;\n      V_ID_ENT := 197;\n    ELSE\n      V_ID_SAI := 585;\n      V_ID_ENT := 300;\n    END IF;\n  \n    INSERT INTO BEG_CPR_NFE\n      (\n       \n       BEG_CPR_NFE_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       NUMERO,\n       SERIE,\n       DT_EMISSAO,\n       DT_ENTRADA,\n       VLR_BASE_ICMS,\n       VLR_BASE_ICMS_CALC,\n       VLR_BASE_OUTROS_ICMS,\n       VLR_BASE_ICMS_SUBST,\n       VLR_BASE_ICMS_SUBST_CALC,\n       VLR_BASE_ISENTO_ICMS,\n       VLR_ICMS,\n       VLR_ICMS_CALC,\n       VLR_OUTROS_ICMS,\n       VLR_ICMS_SUBST,\n       VLR_ICMS_SUBST_CALC,\n       VLR_BASE_IPI,\n       VLR_BASE_IPI_CALC,\n       VLR_BASE_OUTROS_IPI,\n       VLR_BASE_ISENTO_IPI,\n       VLR_IPI,\n       VLR_IPI_CALC,\n       VLR_OUTROS_IPI,\n       ALQ_IR,\n       VLR_BASE_IR,\n       VLR_IR,\n       ALQ_INSS,\n       VLR_BASE_INSS,\n       VLR_INSS,\n       ALQ_ISSQN,\n       VLR_BASE_ISSQN,\n       VLR_ISSQN,\n       VLR_FRETE,\n       TP_FRETE,\n       PLACA_VEICULO,\n       VLR_FRETE_RDP,\n       TP_FRETE_RDP,\n       PLACA_VEICULO_RDP,\n       QTD_VOLUMES,\n       DES_VOLUMES,\n       NRO_VOLUMES,\n       PESO_BRUTO,\n       PESO_LIQUIDO,\n       VLR_SEGURO,\n       VLR_DESPESAS_FINANCEIRAS,\n       VLR_OUTRAS_DESPESAS,\n       PER_DESCONTO,\n       VLR_DESCONTO,\n       PER_ACRESCIMO,\n       VLR_ACRESCIMO,\n       VLR_TOTAL_PRODUTOS,\n       VLR_TOTAL_PRODUTOS_CALC,\n       VLR_TOTAL_NOTA,\n       VLR_TOTAL_NOTA_CALC,\n       VLR_TOTAL_FATURADO,\n       VLR_COTACAO,\n       NRO_FATURA,\n       QTD_PARCELAS,\n       DIAS_VENCIMENTO,\n       DOCSTATUS,\n       IND_TITULO_CPG,\n       IND_AUT_PGTO_CPG,\n       IND_ESPECIAL,\n       IND_FRETE_NOTA,\n       IND_NFE_ORDEM,\n       NRO_VIA_IMPRESSA,\n       OBS,\n       OBS_OUTRAS_DESPESAS,\n       BEG_VW_FORNECEDOR_ID,\n       BEG_VW_CFOP_ENT_ID,\n       BEG_VW_CFOP_SAI_ID,\n       BEG_EST_ALMOXARIFADO_ID,\n       BEG_VW_TRANSPORTADORA_ID,\n       BEG_PRD_UNIDADE_ID,\n       BEG_VW_REDESPACHO_ID,\n       BEG_UF_ID,\n       BEG_VW_UF_RDP_ID,\n       BEG_CONDICAO_PAGAMENTO_ID,\n       BEG_VW_CPR_CND_PGTO_NFE_ID,\n       BEG_VEN_FORMA_PAGAMENTO_ID,\n       BEG_BANCO_ID,\n       BEG_MOEDA_ID,\n       IND_DESCONTO_NOTA,\n       IND_ACRESCIMO_NOTA,\n       IND_DESCONTO_BASE_ICMS,\n       IND_ACRESCIMO_BASE_ICMS,\n       IND_DESCONTO_BASE_IPI,\n       IND_ACRESCIMO_BASE_IPI,\n       VLR_PAGO_NF_DEVOL,\n       IND_DUP_DEVOL,\n       TP_VENDA_DEVOL,\n       BEG_EST_TP_ESPECIE_ID,\n       BEG_CPG_CONTA_ID,\n       TP_DEVOLUCAO,\n       DIE_MOTIVO_DEVOL_ID,\n       DIE_GER_VENDEDOR_ID,\n       VALORPAGO,\n       PERC_REDUCAO_ICMS,\n       IND_EXCLUI_TODOS_ITENS,\n       IND_EXCLUI_ITENS_INATIVOS,\n       PROTOCOLO,\n       BEG_FAT_NFS_ID,\n       VLR_BASE_CALCULO_PIS,\n       VLR_PIS,\n       VLR_BASE_CALCULO_COFINS,\n       VLR_COFINS,\n       VLR_TOTAL_PISCOFINS,\n       CHAVE_NFE,\n       BEG_CPG_TIPO_TITULO_ID,\n       VLR_FUNRURAL,\n       P_SERVICO,\n       TARIFA_DOC,\n       BEG_FIS_COD_MODELO_ID,\n       IND_CARGA_SIAD,\n       IND_EMITIDA_FATURAMENTO,\n       IND_ICMS_TOTAL_NOTA,\n       BEG_FAT_PRE_NFS_ID,\n       TP_LANCTO_CONTABIL,\n       BEG_TIPO_NF_ID,\n       TIPO_NFE,\n       BEG_CST_CALCULO_ID,\n       BEG_VW_FIS_COD_MODELO_ID,\n       BEG_CPR_ORDEM_ID,\n       IND_GERADA_XML,\n       PERC_ST_OC,\n       VLR_INFORMADO,\n       IND_APROV_ICMS,\n       DIE_NFE_DESPESAS_ID,\n       DT_CANCELAMENTO,\n       DIE_ISSQN_SUBITEM_ID,\n       DIE_FAT_NFS_RET_ID\n       \n       )\n    VALUES\n      (V_ID_CPR,\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID,\n       :NEW.ISACTIVE,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       case when :new.tp_nota = '55' or :new.tp_nfe = 9 then :NEW.NRO_NFS else\n       :new.nro_cupom_fiscal end, --:NEW.NRO_NFS,\n       :NEW.Serie_Nfs, --SERIE,\n       trunc(:NEW.DT_EMISSAO),\n       trunc(:NEW.DT_EMISSAO), --DT_ENTRADA,\n       NVL(:NEW.Vl_Base_Calculo_Icms, 0), --VLR_BASE_ICMS,\n       NVL(:NEW.Vl_Base_Calculo_Icms, 0), --VLR_BASE_ICMS_CALC,\n       NVL(:NEW.Vl_Base_Outras_Icms, 0), --VLR_BASE_OUTROS_ICMS,\n       NVL(:NEW.Vl_Base_Icms_Subst, 0), --VLR_BASE_ICMS_SUBST,\n       NVL(:NEW.Vl_Base_Icms_Subst, 0), --VLR_BASE_ICMS_SUBST_CALC,\n       0, --NVL(:NEW.Vl_Base_Isenta_Icms, 0), --VLR_BASE_ISENTO_ICMS,\n       NVL(:NEW.VL_ICMS, 0),\n       NVL(:NEW.Vl_Icms, 0), --VLR_ICMS_CALC,\n       0, --VLR_OUTROS_ICMS,\n       NVL(:NEW.Vl_Icms_Subst, 0), --VLR_ICMS_SUBST,\n       NVL(:NEW.Vl_Icms_Subst, 0), --VLR_ICMS_SUBST_CALC,\n       NVL(:NEW.Vl_Base_Calculo_Ipi, 0), --VLR_BASE_IPI,\n       NVL(:NEW.Vl_Base_Calculo_Ipi, 0), --VLR_BASE_IPI_CALC,\n       NVL(:NEW.Vl_Base_Outras_Ipi, 0), --VLR_BASE_OUTROS_IPI,\n       NVL(:NEW.Vl_Base_Isenta_Ipi, 0), --VLR_BASE_ISENTO_IPI,\n       NVL(:NEW.VL_IPI, 0),\n       NVL(:NEW.VL_IPI, 0), --VLR_IPI_CALC,\n       0, --VLR_OUTROS_IPI,\n       0, --ALQ_IR,\n       0, --VLR_BASE_IR,\n       0, --VLR_IR,\n       0, --ALQ_INSS,\n       0, --VLR_BASE_INSS,\n       0, --VLR_INSS,\n       0, --ALQ_ISSQN,\n       0, --VLR_BASE_ISSQN,\n       0, --VLR_ISSQN,\n       NVL(:NEW.Vl_Frete, 0), -- VLR_FRETE,\n       NVL(:NEW.TP_FRETE, 1),\n       :NEW.PLACA_VEICULO,\n       0, --VLR_FRETE_RDP,\n       null, --:NEW.TP_FRETE_RDP,\n       null, --:NEW.PLACA_VEICULO_RDP,\n       NVL(:NEW.Qtd_Volume, 0), --QTD_VOLUMES,\n       null, --DES_VOLUMES,\n       0, --:NEW.NRO_VOLUMES,\n       NVL(:NEW.Peso_Bruto, 0), --PESO_BRUTO,\n       NVL(:NEW.PESO_LIQUIDO, 0),\n       0, --:NEW.VL_SEGURO,\n       0, --NVL(:NEW.Vl_Desp_Financeira, 0), --VLR_DESPESAS_FINANCEIRAS,\n       NVL(:NEW.VL_OUTRAS_DESPESAS, 0),\n       0, --PER_DESCONTO,\n       0, --NVL(:NEW.VLR_DESCONTO, 0),\n       0, --PER_ACRESCIMO,\n       0, --NVL(:NEW.Vl_Custo_Financeiro, 0), --VLR_ACRESCIMO,\n       NVL(:NEW.Vl_Total_Prod, 0), --VLR_TOTAL_PRODUTOS,\n       0, --VLR_TOTAL_PRODUTOS_CALC,\n       NVL(:NEW.Vl_Total_Nfs, 0) - NVL(:NEW.Vl_Custo_Financeiro, 0) -\n       NVL(:NEW.VLR_SEGUROS, 0), --VLR_TOTAL_NOTA,\n       0, --VLR_TOTAL_NOTA_CALC,\n       0, --VLR_TOTAL_FATURADO,\n       0, --VLR_COTACAO,\n       null, --NRO_FATURA,\n       null, --QTD_PARCELAS,\n       null, --DIAS_VENCIMENTO,\n       'WC', --DOCSTATUS,\n       'N', --IND_TITULO_CPG,\n       'N', --IND_AUT_PGTO_CPG,\n       'N', --IND_ESPECIAL,\n       case when :NEW.VL_FRETE > 0 then 'Y' else 'N' end, --:NEW.IND_FRETE_NOTA,\n       'N', --IND_NFE_ORDEM,\n       0, --NRO_VIA_IMPRESSA,\n       :NEW.OBS,\n       NULL, --OBS_OUTRAS_DESPESAS,\n       :NEW.BEG_VW_PESSOA_ENTREGA_ID, --BEG_VW_FORNECEDOR_ID,\n       V_ID_ENT, --BEG_VW_CFOP_ENT_ID,\n       V_ID_SAI, --BEG_VW_CFOP_SAI_ID,\n       V_ALMOX3_ID, --BEG_EST_ALMOXARIFADO_ID,\n       :NEW.BEG_VW_TRANSPORTADORA_ID,\n       NULL, --:NEW.BEG_PRD_UNIDADE_ID,\n       NULL, --:NEW.BEG_VW_REDESPACHO_ID,\n       NULL, --:NEW.BEG_UF_ID,\n       NULL, --:NEW.BEG_VW_UF_RDP_ID,\n       NULL, --:NEW.BEG_CONDICAO_PAGAMENTO_ID,\n       NULL, --:NEW.BEG_VW_CPR_CND_PGTO_NFE_ID,\n       NULL, --:NEW.BEG_VEN_FORMA_PAGAMENTO_ID,\n       NULL, --:NEW.BEG_BANCO_ID,\n       NULL, --:NEW.BEG_MOEDA_ID,\n       case when :new.vlr_desconto > 0 then 'Y' else 'N' end, --:NEW.IND_DESCONTO_NOTA,\n       'N', --:NEW.IND_ACRESCIMO_NOTA,\n       'N', --:NEW.IND_DESCONTO_BASE_ICMS,\n       'N', --:NEW.IND_ACRESCIMO_BASE_ICMS,\n       'N', --:NEW.IND_DESCONTO_BASE_IPI,\n       'N', --:NEW.IND_ACRESCIMO_BASE_IPI,\n       0, --:NEW.VLR_PAGO_NF_DEVOL,\n       'N', --:NEW.IND_DUP_DEVOL,\n       NULL, --:NEW.TP_VENDA_DEVOL,\n       :NEW.BEG_EST_TP_ESPECIE_ID,\n       2001418, --:NEW.BEG_CPG_CONTA_ID,\n       NULL, ---:NEW.TP_DEVOLUCAO,\n       NULL, --:NEW.DIE_MOTIVO_DEVOL_ID,\n       :NEW.DIE_GER_VENDEDOR_ID,\n       0, --:NEW.VALORPAGO,\n       0, --PERC_REDUCAO_ICMS,\n       'N', --:NEW.IND_EXCLUI_TODOS_ITENS,\n       'N', --:NEW.IND_EXCLUI_ITENS_INATIVOS,\n       NULL, --:NEW.PROTOCOLO,\n       :NEW.BEG_FAT_NFS_ID,\n       NVL(:NEW.VL_TOT_SEM_SERVICOS, 0), --VLR_BASE_CALCULO_PIS,\n       NVL(:NEW.VL_PIS, 0),\n       NVL(:NEW.VL_TOT_SEM_SERVICOS, 0), --VLR_BASE_CALCULO_COFINS,\n       NVL(:NEW.VL_COFINS, 0),\n       0, --:NEW.VLR_TOTAL_PISCOFINS,\n       :NEW.CHAVE, --CHAVE_NFE,\n       NULL, --:NEW.BEG_CPG_TIPO_TITULO_ID,\n       0, --:NEW.VLR_FUNRURAL,\n       'N', --:NEW.P_SERVICO,\n       0, --:NEW.TARIFA_DOC,\n       NULL, --:NEW.BEG_FIS_COD_MODELO_ID,\n       'N', --:NEW.IND_CARGA_SIAD,\n       'N', --:NEW.IND_EMITIDA_FATURAMENTO,\n       'N', --:NEW.IND_ICMS_TOTAL_NOTA,\n       NULL, --:NEW.BEG_FAT_PRE_NFS_ID,\n       'E', --:NEW.TP_LANCTO_CONTABIL,\n       :NEW.BEG_TIPO_NF_ID,\n       null, --:NEW.TIPO_NFE,\n       null, --:NEW.BEG_CST_CALCULO_ID,\n       null, --:NEW.BEG_VW_FIS_COD_MODELO_ID,\n       null, --:NEW.BEG_CPR_ORDEM_ID,\n       null, --:NEW.IND_GERADA_XML,\n       0, --:NEW.PERC_ST_OC,\n       0, --:NEW.VLR_INFORMADO,\n       null, --:NEW.IND_APROV_ICMS,\n       null, --:NEW.DIE_NFE_DESPESAS_ID,\n       null, --:NEW.DT_CANCELAMENTO,\n       null, --:NEW.DIE_ISSQN_SUBITEM_ID\n       :NEW.DIE_FAT_NFS_RET_ID);\n  \n    --  COMMIT;\n  \n    V_SEQ := 0;\n    FOR R_ITEM IN C_ITEM LOOP\n      V_ID_ITEM := BEG_FNC_AD_SEQUENCE('BEG_CPR_NFE_ITEM');\n      V_SEQ     := V_SEQ + 1;\n    \n      V_ID_CFOP := R_ITEM.BEG_CFOP_ID;\n    \n      OPEN C_CFOP;\n      FETCH C_CFOP\n        INTO R_CFOP;\n      CLOSE C_CFOP;\n    \n      V_ID_ENT := R_CFOP.BEG_VW_CFOP_ENT_ID;\n      V_ID_SAI := R_CFOP.BEG_VW_CFOP_SAI_ID;\n    \n      INSERT INTO BEG_CPR_NFE_ITEM\n        (BEG_CPR_NFE_ITEM_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         SEQUENCIA,\n         QTD,\n         DES_ITEM_FORNECEDOR,\n         VLR_UNITARIO,\n         VLR_TOTAL,\n         VLR_TOTAL_CALC,\n         ALQ_ICMS,\n         ALQ_OUTROS_ICMS,\n         ALQ_ICMS_SUBST,\n         VLR_BASE_ICMS,\n         VLR_BASE_ICMS_CALC,\n         VLR_BASE_OUTROS_ICMS,\n         VLR_BASE_ICMS_SUBST,\n         VLR_BASE_ICMS_SUBST_CALC,\n         VLR_BASE_ISENTO_ICMS,\n         VLR_ICMS,\n         VLR_ICMS_CALC,\n         VLR_OUTROS_ICMS,\n         VLR_ICMS_SUBST,\n         VLR_ICMS_SUBST_CALC,\n         ALQ_IPI,\n         ALQ_OUTROS_IPI,\n         VLR_BASE_IPI,\n         VLR_BASE_IPI_CALC,\n         VLR_BASE_OUTROS_IPI,\n         VLR_BASE_ISENTO_IPI,\n         VLR_IPI,\n         VLR_IPI_CALC,\n         VLR_OUTROS_IPI,\n         ALQ_ISSQN,\n         VLR_BASE_ISSQN,\n         VLR_ISSQN,\n         VLR_FRETE,\n         VLR_FRETE_RDP,\n         QTD_VOLUMES,\n         PESO_BRUTO,\n         PESO_LIQUIDO,\n         VLR_SEGURO,\n         VLR_DESPESAS_FINANCEIRAS,\n         VLR_OUTRAS_DESPESAS,\n         PER_DESCONTO,\n         VLR_DESCONTO,\n         PER_ACRESCIMO,\n         VLR_ACRESCIMO,\n         IND_FRETE_NOTA,\n         OBS,\n         OBS_OUTRAS_DESPESAS,\n         BEG_CPR_NFE_ID,\n         BEG_PRODUTO_ID,\n         BEG_PRD_SKU_ID,\n         BEG_VW_CFOP_ENT_ID,\n         BEG_VW_CFOP_SAI_ID,\n         BEG_PRD_NCM_ID,\n         BEG_FIS_TRIB_ICMS_ID,\n         BEG_FIS_ORIGEM_MERC_ID,\n         BEG_EST_ALMOXARIFADO_ID,\n         IND_DESCONTO_ITEM,\n         IND_ACRESCIMO_ITEM,\n         IND_DESCONTO_BASE_ICMS,\n         IND_ACRESCIMO_BASE_ICMS,\n         IND_DESCONTO_BASE_IPI,\n         IND_ACRESCIMO_BASE_IPI,\n         BEG_CST_CALCULO_ID,\n         VLR_APURADO,\n         VLR_SUGERIDO,\n         VLR_VIGENTE,\n         ALQ_MARGEM,\n         PER_VARIACAO,\n         BEG_VW_NF_ORIGEM_ID,\n         BEG_VW_NF_ORIGEM_ITEM_ID,\n         BEG_EST_MOVTO_ESTOQUE_ID,\n         CST_PIS,\n         VLR_BASE_CALCULO_PIS,\n         PERC_PIS,\n         VLR_PIS,\n         CST_COFINS,\n         VLR_BASE_CALCULO_COFINS,\n         PERC_COFINS,\n         VLR_COFINS,\n         CST_ICMS,\n         PERC_REDUCAO_ICMS,\n         VLR_PISCOFINS,\n         NRO_ADICAO_DI,\n         VLR_DESP_ACES_IMP,\n         VL_IMPOSTO_IMPORTACAO,\n         VLR_BASE_COFINS,\n         ALQ_COFINS,\n         VLR_BASE_PIS,\n         ALQ_PIS,\n         BEG_VW_FORNECEDOR_ID,\n         BEG_VW_UF_ID,\n         LOCAL_DESEMBARACO,\n         DT_DESEMBARACO_ADUANA,\n         DT_REGISTRO_DI,\n         NRO_ACDRAWBACK,\n         NRO_DOC_IMPORTACAO,\n         BEG_FIS_CST_IPI_ID,\n         BEG_FIS_CST_PIS_ID,\n         BEG_FIS_CST_COFINS_ID,\n         BEG_TIPO_NF_ID,\n         BEG_FAT_PRE_NFS_ID,\n         BEG_FAT_PRE_NFS_ITEM_ID,\n         PER_ACRE_TMP,\n         PER_DESC_TMP,\n         PERC_MVAST,\n         PERC_REDUCAO_VLR_ICMS,\n         QTD_ORDEM,\n         PERC_ST_OC,\n         VLR_ITEM_ORDEM_COMPRA,\n         BEG_CPR_ORDEM_ID)\n      VALUES\n        (\n         \n         V_ID_ITEM,\n         R_ITEM.AD_CLIENT_ID,\n         R_ITEM.AD_ORG_ID,\n         R_ITEM.ISACTIVE,\n         R_ITEM.CREATED,\n         R_ITEM.CREATEDBY,\n         R_ITEM.UPDATED,\n         R_ITEM.UPDATEDBY,\n         V_SEQ, --R_ITEM.SEQUENCIA                ,\n         nvl(R_ITEM.QTDE, 0),\n         R_ITEM.DESC_TECNICA_ITEM,\n         nvl(R_ITEM.VL_UNITARIO, 0),\n         nvl(R_ITEM.TOTAL_BRUTO, 0),\n         nvl(R_ITEM.TOTAL_BRUTO, 0),\n         nvl(R_ITEM.PERC_ICMS, 0),\n         0, --R_ITEM.ALIQ_OUTRAS_ICMS          ,\n         nvl(R_ITEM.ALIQ_ICMS_SUBST, 0),\n         nvl(R_ITEM.VL_BASE_CALCULO_ICMS, 0),\n         nvl(R_ITEM.VL_BASE_CALCULO_ICMS, 0),\n         nvl(R_ITEM.VL_BASE_OUTRAS_ICMS, 0),\n         nvl(R_ITEM.VL_BASE_SUBST_TRIB, 0),\n         nvl(R_ITEM.VL_BASE_SUBST_TRIB, 0),\n         nvl(R_ITEM.VL_BASE_ISENTA_ICMS, 0),\n         nvl(R_ITEM.VL_ICMS, 0),\n         nvl(R_ITEM.VL_ICMS, 0),\n         0, --R_ITEM.VL_OUTRAS_ICMS          ,\n         nvl(R_ITEM.VL_ICMS_SUBST, 0),\n         nvl(R_ITEM.VL_ICMS_SUBST, 0),\n         0, --R_ITEM.ALIQ_IPI,\n         0, --R_ITEM.ALQ_OUTROS_IPI           ,\n         0, --R_ITEM.VL_BASE_CALCULO_IPI,\n         0, --R_ITEM.VL_BASE_CALCULO_IPI,\n         0, --R_ITEM.VL_BASE_OUTRAS_IPI,\n         0, --R_ITEM.VLR_BASE_ISENTO_IPI      ,\n         0, --R_ITEM.VL_IPI,\n         0, --R_ITEM.VL_IPI,\n         0, --R_ITEM.VL_OUTROS_IPI           ,\n         0, -- R_ITEM.ALQ_ISSQN                ,\n         0, --R_ITEM.VLR_BASE_ISSQN           ,\n         0, --R_ITEM.VLR_ISSQN                ,\n         R_ITEM.VL_FRETE_ITEM,\n         0, --R_ITEM.VLR_FRETE_RDP            ,\n         0, --R_ITEM.QTD_VOLUMES              ,\n         nvl(R_ITEM.PESO_BRUTO, 0),\n         nvl(R_ITEM.PESO_LIQUIDO, 0),\n         0, --R_ITEM.VL_SEGURO               ,\n         0, --R_ITEM.VL_DESPESAS_FINANCEIRAS ,\n         R_ITEM.VL_OUTRAS_DESPESAS,\n         0, --R_ITEM.PER_DESCONTO             ,\n         R_ITEM.VL_DESCONTO,\n         0, --R_ITEM.PER_ACRESCIMO            ,\n         0, --R_ITEM.VLR_ACRESCIMO            ,\n         CASE WHEN :NEW.VL_FRETE > 0 THEN 'Y' ELSE 'N' END, --R_ITEM.IND_FRETE_NOTA           ,\n         NULL, --R_ITEM.OBS                      ,\n         NULL, --R_ITEM.OBS_OUTRAS_DESPESAS      ,\n         V_ID_CPR, --R_ITEM.BEG_CPR_NFE_ID           ,\n         R_ITEM.BEG_PRODUTO_ID,\n         R_ITEM.BEG_PRD_SKU_ID,\n         V_ID_ENT, --R_ITEM.BEG_VW_CFOP_ENT_ID       ,\n         V_ID_SAI, --R_ITEM.BEG_CFOP_ID,\n         R_ITEM.BEG_PRD_NCM_ID,\n         R_ITEM.BEG_FIS_TRIB_ICMS_ID,\n         R_ITEM.BEG_FIS_ORIGEM_MERC_ID,\n         NULL, --R_ITEM.BEG_EST_ALMOXARIFADO_ID  ,\n         CASE WHEN R_ITEM.VL_DESCONTO > 0 THEN 'Y' ELSE 'N' END, --R_ITEM.IND_DESCONTO_ITEM        ,\n         'N', --R_ITEM.IND_ACRESCIMO_ITEM       ,\n         'N', --R_ITEM.IND_DESCONTO_BASE_ICMS   ,\n         'N', --R_ITEM.IND_ACRESCIMO_BASE_ICMS  ,\n         'N', --R_ITEM.IND_DESCONTO_BASE_IPI    ,\n         'N', --R_ITEM.IND_ACRESCIMO_BASE_IPI   ,\n         NULL, --R_ITEM.BEG_CST_CALCULO_ID       ,\n         0, --R_ITEM.VLR_APURADO              ,\n         0, --R_ITEM.VLR_SUGERIDO             ,\n         0, --R_ITEM.VLR_VIGENTE              ,\n         0, --R_ITEM.ALIQ_MARGEM               ,\n         0, --R_ITEM.PER_VARIACAO             ,\n         NULL, --R_ITEM.BEG_VW_NF_ORIGEM_ID      ,\n         NULL, --R_ITEM.BEG_VW_NF_ORIGEM_ITEM_ID ,\n         NULL, --R_ITEM.BEG_EST_MOVTO_ESTOQUE_ID ,\n         R_ITEM.CST_PIS,\n         nvl(R_ITEM.VL_BASE_CALCULO_PIS, 0),\n         nvl(R_ITEM.PERC_PIS, 0),\n         nvl(R_ITEM.VL_PIS, 0),\n         R_ITEM.CST_COFINS,\n         nvl(R_ITEM.VL_BASE_CALCULO_COFINS, 0),\n         nvl(R_ITEM.ALIQ_COFINS, 0),\n         nvl(R_ITEM.VLR_COFINS, 0),\n         R_ITEM.CST,\n         nvl(R_ITEM.PERC_REDUCAO, 0),\n         0, --R_ITEM.VL_PISCOFINS            ,\n         NULL, --R_ITEM.NRO_ADICAO_DI            ,\n         0, --R_ITEM.VLR_DESP_ACES_IMP        ,\n         0, --R_ITEM.VL_IMPOSTO_IMPORTACAO    ,\n         nvl(R_ITEM.VL_BASE_CALCULO_COFINS, 0),\n         nvl(R_ITEM.ALIQ_COFINS, 0),\n         nvl(R_ITEM.VL_BASE_CALCULO_PIS, 0),\n         nvl(R_ITEM.ALIQ_PIS, 0),\n         :NEW.BEG_VW_FORNECEDOR_ID,\n         NULL, --R_ITEM.BEG_VW_UF_ID             ,\n         NULL, --R_ITEM.LOCAL_DESEMBARACO        ,\n         NULL, --R_ITEM.DT_DESEMBARACO_ADUANA    ,\n         NULL, --R_ITEM.DT_REGISTRO_DI           ,\n         NULL, --R_ITEM.NRO_ACDRAWBACK           ,\n         NULL, --R_ITEM.NRO_DOC_IMPORTACAO       ,\n         NULL, --R_ITEM.BEG_FIS_CST_IPI_ID       ,\n         NULL, --R_ITEM.BEG_FIS_CST_PIS_ID       ,\n         NULL, --R_ITEM.BEG_FIS_CST_COFINS_ID    ,\n         NULL, --R_ITEM.BEG_TIPO_NF_ID           ,\n         NULL, --R_ITEM.BEG_FAT_PRE_NFS_ID       ,\n         NULL, --R_ITEM.BEG_FAT_PRE_NFS_ITEM_ID  ,\n         0, --R_ITEM.PER_ACRE_TMP             ,\n         0, --R_ITEM.PER_DESC_TMP             ,\n         0, --R_ITEM.PERC_MVAST               ,\n         0, --R_ITEM.PERC_REDUCAO_VLR_ICMS    ,\n         0, --R_ITEM.QTD_ORDEM                ,\n         0, --R_ITEM.PERC_ST_OC               ,\n         0, --R_ITEM.VLR_ITEM_ORDEM_COMPRA    ,\n         NULL --R_ITEM.BEG_CPR_ORDEM_ID\n         );\n    \n      V_ID_IT_VEN := R_ITEM.DIE_FAT_NFS_ITEM_RETORNO_ID;\n    \n      open C_RET;\n      fetch C_RET\n        into R_RET;\n      close C_RET;\n    \n      IF R_RET.BEG_HST_NOTA_FISCAL_ID IS NOT NULL THEN\n      \n        INSERT INTO BEG_HST_NF_VINCULADA\n          (BEG_HST_NF_VINCULADA_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           BEG_FAT_NFS_ID,\n           BEG_FAT_NFS_ITEM_ID,\n           BEG_CPR_NFE_ID,\n           BEG_CPR_NFE_ITEM_ID,\n           BEG_HST_NOTA_FISCAL_ID,\n           QTD)\n        VALUES\n          (BEG_FNC_AD_SEQUENCE('BEG_HST_NF_VINCULADA'),\n           :NEW.AD_CLIENT_ID,\n           :NEW.AD_ORG_ID,\n           :NEW.ISACTIVE,\n           :NEW.CREATED,\n           :NEW.CREATEDBY,\n           :NEW.UPDATED,\n           :NEW.UPDATEDBY,\n           NULL, --BEG_FAT_NFS_ID          ,\n           NULL, --BEG_FAT_NFS_ITEM_ID     ,\n           V_ID_CPR, --BEG_CPR_NFE_ID          ,\n           V_ID_ITEM, --BEG_CPR_NFE_ITEM_ID     ,\n           R_RET.BEG_HST_NOTA_FISCAL_ID,\n           R_ITEM.QTDE);\n      \n      END IF;\n    \n    END LOOP;\n  \n    :NEW.BEG_CPR_NFE_ID := V_ID_CPR;\n    :NEW.DOCSTATUS      := 'CO';\n  \n    COMMIT;\n  \n    V_RESULT := BEG_FNC_APROVA_NOTA(:NEW.BEG_CPR_NFE_ID);\n  \n    COMMIT;\n  END IF;\n  ----- Demais notas de entrada\n  IF :NEW.STATUS in (100, 150) AND :NEW.BEG_CPR_NFE_ID IS NULL AND\n     :NEW.BEG_EST_TP_ESPECIE_ID NOT IN (2000013, 2000022) AND\n     :NEW.TP_LANCTO_CONTABIL = 'E' AND :NEW.DOCSTATUS = 'WC' THEN\n  \n    V_ID_CPR := BEG_FNC_AD_SEQUENCE('BEG_CPR_NFE');\n  \n    OPEN C_CLIENTE;\n    FETCH C_CLIENTE\n      INTO R_CLIENTE;\n    CLOSE C_CLIENTE;\n  \n    OPEN C_LOJA;\n    FETCH C_LOJA\n      INTO R_LOJA;\n    CLOSE C_LOJA;\n  \n    V_ID_SAI := NULL;\n    V_ID_ENT := NULL;\n  \n    INSERT INTO BEG_CPR_NFE\n      (\n       \n       BEG_CPR_NFE_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       NUMERO,\n       SERIE,\n       DT_EMISSAO,\n       DT_ENTRADA,\n       VLR_BASE_ICMS,\n       VLR_BASE_ICMS_CALC,\n       VLR_BASE_OUTROS_ICMS,\n       VLR_BASE_ICMS_SUBST,\n       VLR_BASE_ICMS_SUBST_CALC,\n       VLR_BASE_ISENTO_ICMS,\n       VLR_ICMS,\n       VLR_ICMS_CALC,\n       VLR_OUTROS_ICMS,\n       VLR_ICMS_SUBST,\n       VLR_ICMS_SUBST_CALC,\n       VLR_BASE_IPI,\n       VLR_BASE_IPI_CALC,\n       VLR_BASE_OUTROS_IPI,\n       VLR_BASE_ISENTO_IPI,\n       VLR_IPI,\n       VLR_IPI_CALC,\n       VLR_OUTROS_IPI,\n       ALQ_IR,\n       VLR_BASE_IR,\n       VLR_IR,\n       ALQ_INSS,\n       VLR_BASE_INSS,\n       VLR_INSS,\n       ALQ_ISSQN,\n       VLR_BASE_ISSQN,\n       VLR_ISSQN,\n       VLR_FRETE,\n       TP_FRETE,\n       PLACA_VEICULO,\n       VLR_FRETE_RDP,\n       TP_FRETE_RDP,\n       PLACA_VEICULO_RDP,\n       QTD_VOLUMES,\n       DES_VOLUMES,\n       NRO_VOLUMES,\n       PESO_BRUTO,\n       PESO_LIQUIDO,\n       VLR_SEGURO,\n       VLR_DESPESAS_FINANCEIRAS,\n       VLR_OUTRAS_DESPESAS,\n       PER_DESCONTO,\n       VLR_DESCONTO,\n       PER_ACRESCIMO,\n       VLR_ACRESCIMO,\n       VLR_TOTAL_PRODUTOS,\n       VLR_TOTAL_PRODUTOS_CALC,\n       VLR_TOTAL_NOTA,\n       VLR_TOTAL_NOTA_CALC,\n       VLR_TOTAL_FATURADO,\n       VLR_COTACAO,\n       NRO_FATURA,\n       QTD_PARCELAS,\n       DIAS_VENCIMENTO,\n       DOCSTATUS,\n       IND_TITULO_CPG,\n       IND_AUT_PGTO_CPG,\n       IND_ESPECIAL,\n       IND_FRETE_NOTA,\n       IND_NFE_ORDEM,\n       NRO_VIA_IMPRESSA,\n       OBS,\n       OBS_OUTRAS_DESPESAS,\n       BEG_VW_FORNECEDOR_ID,\n       BEG_VW_CFOP_ENT_ID,\n       BEG_VW_CFOP_SAI_ID,\n       BEG_EST_ALMOXARIFADO_ID,\n       BEG_VW_TRANSPORTADORA_ID,\n       BEG_PRD_UNIDADE_ID,\n       BEG_VW_REDESPACHO_ID,\n       BEG_UF_ID,\n       BEG_VW_UF_RDP_ID,\n       BEG_CONDICAO_PAGAMENTO_ID,\n       BEG_VW_CPR_CND_PGTO_NFE_ID,\n       BEG_VEN_FORMA_PAGAMENTO_ID,\n       BEG_BANCO_ID,\n       BEG_MOEDA_ID,\n       IND_DESCONTO_NOTA,\n       IND_ACRESCIMO_NOTA,\n       IND_DESCONTO_BASE_ICMS,\n       IND_ACRESCIMO_BASE_ICMS,\n       IND_DESCONTO_BASE_IPI,\n       IND_ACRESCIMO_BASE_IPI,\n       VLR_PAGO_NF_DEVOL,\n       IND_DUP_DEVOL,\n       TP_VENDA_DEVOL,\n       BEG_EST_TP_ESPECIE_ID,\n       BEG_CPG_CONTA_ID,\n       TP_DEVOLUCAO,\n       DIE_MOTIVO_DEVOL_ID,\n       DIE_GER_VENDEDOR_ID,\n       VALORPAGO,\n       PERC_REDUCAO_ICMS,\n       IND_EXCLUI_TODOS_ITENS,\n       IND_EXCLUI_ITENS_INATIVOS,\n       PROTOCOLO,\n       BEG_FAT_NFS_ID,\n       VLR_BASE_CALCULO_PIS,\n       VLR_PIS,\n       VLR_BASE_CALCULO_COFINS,\n       VLR_COFINS,\n       VLR_TOTAL_PISCOFINS,\n       CHAVE_NFE,\n       BEG_CPG_TIPO_TITULO_ID,\n       VLR_FUNRURAL,\n       P_SERVICO,\n       TARIFA_DOC,\n       BEG_FIS_COD_MODELO_ID,\n       IND_CARGA_SIAD,\n       IND_EMITIDA_FATURAMENTO,\n       IND_ICMS_TOTAL_NOTA,\n       BEG_FAT_PRE_NFS_ID,\n       TP_LANCTO_CONTABIL,\n       BEG_TIPO_NF_ID,\n       TIPO_NFE,\n       BEG_CST_CALCULO_ID,\n       BEG_VW_FIS_COD_MODELO_ID,\n       BEG_CPR_ORDEM_ID,\n       IND_GERADA_XML,\n       PERC_ST_OC,\n       VLR_INFORMADO,\n       IND_APROV_ICMS,\n       DIE_NFE_DESPESAS_ID,\n       DT_CANCELAMENTO,\n       DIE_ISSQN_SUBITEM_ID,\n       DIE_FAT_NFS_RET_ID\n       \n       )\n    VALUES\n      (V_ID_CPR,\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID,\n       :NEW.ISACTIVE,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       case when :new.tp_nota = '55' or :new.tp_nfe = 9 then :NEW.NRO_NFS else\n       :new.nro_cupom_fiscal end, --:NEW.NRO_NFS,\n       :NEW.Serie_Nfs, --SERIE,\n       trunc(:NEW.DT_EMISSAO),\n       trunc(:NEW.DT_EMISSAO), --DT_ENTRADA,\n       NVL(:NEW.Vl_Base_Calculo_Icms, 0), --VLR_BASE_ICMS,\n       NVL(:NEW.Vl_Base_Calculo_Icms, 0), --VLR_BASE_ICMS_CALC,\n       NVL(:NEW.Vl_Base_Outras_Icms, 0), --VLR_BASE_OUTROS_ICMS,\n       NVL(:NEW.Vl_Base_Icms_Subst, 0), --VLR_BASE_ICMS_SUBST,\n       NVL(:NEW.Vl_Base_Icms_Subst, 0), --VLR_BASE_ICMS_SUBST_CALC,\n       0, --NVL(:NEW.Vl_Base_Isenta_Icms, 0), --VLR_BASE_ISENTO_ICMS,\n       NVL(:NEW.VL_ICMS, 0),\n       NVL(:NEW.Vl_Icms, 0), --VLR_ICMS_CALC,\n       0, --VLR_OUTROS_ICMS,\n       NVL(:NEW.Vl_Icms_Subst, 0), --VLR_ICMS_SUBST,\n       NVL(:NEW.Vl_Icms_Subst, 0), --VLR_ICMS_SUBST_CALC,\n       NVL(:NEW.Vl_Base_Calculo_Ipi, 0), --VLR_BASE_IPI,\n       NVL(:NEW.Vl_Base_Calculo_Ipi, 0), --VLR_BASE_IPI_CALC,\n       NVL(:NEW.Vl_Base_Outras_Ipi, 0), --VLR_BASE_OUTROS_IPI,\n       NVL(:NEW.Vl_Base_Isenta_Ipi, 0), --VLR_BASE_ISENTO_IPI,\n       NVL(:NEW.VL_IPI, 0),\n       NVL(:NEW.VL_IPI, 0), --VLR_IPI_CALC,\n       0, --VLR_OUTROS_IPI,\n       0, --ALQ_IR,\n       0, --VLR_BASE_IR,\n       0, --VLR_IR,\n       0, --ALQ_INSS,\n       0, --VLR_BASE_INSS,\n       0, --VLR_INSS,\n       0, --ALQ_ISSQN,\n       0, --VLR_BASE_ISSQN,\n       0, --VLR_ISSQN,\n       NVL(:NEW.Vl_Frete, 0), -- VLR_FRETE,\n       NVL(:NEW.TP_FRETE, 1),\n       :NEW.PLACA_VEICULO,\n       0, --VLR_FRETE_RDP,\n       null, --:NEW.TP_FRETE_RDP,\n       null, --:NEW.PLACA_VEICULO_RDP,\n       NVL(:NEW.Qtd_Volume, 0), --QTD_VOLUMES,\n       null, --DES_VOLUMES,\n       0, --:NEW.NRO_VOLUMES,\n       NVL(:NEW.Peso_Bruto, 0), --PESO_BRUTO,\n       NVL(:NEW.PESO_LIQUIDO, 0),\n       0, --:NEW.VL_SEGURO,\n       0, --NVL(:NEW.Vl_Desp_Financeira, 0), --VLR_DESPESAS_FINANCEIRAS,\n       NVL(:NEW.VL_OUTRAS_DESPESAS, 0),\n       0, --PER_DESCONTO,\n       0, --NVL(:NEW.VLR_DESCONTO, 0),\n       0, --PER_ACRESCIMO,\n       0, --NVL(:NEW.Vl_Custo_Financeiro, 0), --VLR_ACRESCIMO,\n       NVL(:NEW.Vl_Total_Prod, 0), --VLR_TOTAL_PRODUTOS,\n       0, --VLR_TOTAL_PRODUTOS_CALC,\n       NVL(:NEW.Vl_Total_Nfs, 0) - NVL(:NEW.Vl_Custo_Financeiro, 0) -\n       NVL(:NEW.VLR_SEGUROS, 0), --VLR_TOTAL_NOTA,\n       0, --VLR_TOTAL_NOTA_CALC,\n       0, --VLR_TOTAL_FATURADO,\n       0, --VLR_COTACAO,\n       null, --NRO_FATURA,\n       null, --QTD_PARCELAS,\n       null, --DIAS_VENCIMENTO,\n       'WC', --DOCSTATUS,\n       'N', --IND_TITULO_CPG,\n       'N', --IND_AUT_PGTO_CPG,\n       'N', --IND_ESPECIAL,\n       case when :NEW.VL_FRETE > 0 then 'Y' else 'N' end, --:NEW.IND_FRETE_NOTA,\n       'N', --IND_NFE_ORDEM,\n       0, --NRO_VIA_IMPRESSA,\n       :NEW.OBS,\n       NULL, --OBS_OUTRAS_DESPESAS,\n       :NEW.BEG_VW_PESSOA_ENTREGA_ID, --BEG_VW_FORNECEDOR_ID,\n       V_ID_ENT, --BEG_VW_CFOP_ENT_ID,\n       V_ID_SAI, --BEG_VW_CFOP_SAI_ID,\n       :NEW.BEG_EST_ALMOXARIFADO_ID,\n       :NEW.BEG_VW_TRANSPORTADORA_ID,\n       NULL, --:NEW.BEG_PRD_UNIDADE_ID,\n       NULL, --:NEW.BEG_VW_REDESPACHO_ID,\n       NULL, --:NEW.BEG_UF_ID,\n       NULL, --:NEW.BEG_VW_UF_RDP_ID,\n       NULL, --:NEW.BEG_CONDICAO_PAGAMENTO_ID,\n       NULL, --:NEW.BEG_VW_CPR_CND_PGTO_NFE_ID,\n       NULL, --:NEW.BEG_VEN_FORMA_PAGAMENTO_ID,\n       NULL, --:NEW.BEG_BANCO_ID,\n       NULL, --:NEW.BEG_MOEDA_ID,\n       case when :new.vlr_desconto > 0 then 'Y' else 'N' end, --:NEW.IND_DESCONTO_NOTA,\n       'N', --:NEW.IND_ACRESCIMO_NOTA,\n       'N', --:NEW.IND_DESCONTO_BASE_ICMS,\n       'N', --:NEW.IND_ACRESCIMO_BASE_ICMS,\n       'N', --:NEW.IND_DESCONTO_BASE_IPI,\n       'N', --:NEW.IND_ACRESCIMO_BASE_IPI,\n       0, --:NEW.VLR_PAGO_NF_DEVOL,\n       'N', --:NEW.IND_DUP_DEVOL,\n       NULL, --:NEW.TP_VENDA_DEVOL,\n       :NEW.BEG_EST_TP_ESPECIE_ID,\n       2001418, --:NEW.BEG_CPG_CONTA_ID,\n       NULL, ---:NEW.TP_DEVOLUCAO,\n       NULL, --:NEW.DIE_MOTIVO_DEVOL_ID,\n       :NEW.DIE_GER_VENDEDOR_ID,\n       0, --:NEW.VALORPAGO,\n       0, --PERC_REDUCAO_ICMS,\n       'N', --:NEW.IND_EXCLUI_TODOS_ITENS,\n       'N', --:NEW.IND_EXCLUI_ITENS_INATIVOS,\n       NULL, --:NEW.PROTOCOLO,\n       :NEW.BEG_FAT_NFS_ID,\n       NVL(:NEW.VL_TOT_SEM_SERVICOS, 0), --VLR_BASE_CALCULO_PIS,\n       NVL(:NEW.VL_PIS, 0),\n       NVL(:NEW.VL_TOT_SEM_SERVICOS, 0), --VLR_BASE_CALCULO_COFINS,\n       NVL(:NEW.VL_COFINS, 0),\n       0, --:NEW.VLR_TOTAL_PISCOFINS,\n       :NEW.CHAVE, --CHAVE_NFE,\n       NULL, --:NEW.BEG_CPG_TIPO_TITULO_ID,\n       0, --:NEW.VLR_FUNRURAL,\n       'N', --:NEW.P_SERVICO,\n       0, --:NEW.TARIFA_DOC,\n       NULL, --:NEW.BEG_FIS_COD_MODELO_ID,\n       'N', --:NEW.IND_CARGA_SIAD,\n       'N', --:NEW.IND_EMITIDA_FATURAMENTO,\n       'N', --:NEW.IND_ICMS_TOTAL_NOTA,\n       NULL, --:NEW.BEG_FAT_PRE_NFS_ID,\n       'E', --:NEW.TP_LANCTO_CONTABIL,\n       :NEW.BEG_TIPO_NF_ID,\n       null, --:NEW.TIPO_NFE,\n       null, --:NEW.BEG_CST_CALCULO_ID,\n       null, --:NEW.BEG_VW_FIS_COD_MODELO_ID,\n       null, --:NEW.BEG_CPR_ORDEM_ID,\n       null, --:NEW.IND_GERADA_XML,\n       0, --:NEW.PERC_ST_OC,\n       0, --:NEW.VLR_INFORMADO,\n       null, --:NEW.IND_APROV_ICMS,\n       null, --:NEW.DIE_NFE_DESPESAS_ID,\n       null, --:NEW.DT_CANCELAMENTO,\n       null, --:NEW.DIE_ISSQN_SUBITEM_ID\n       :NEW.DIE_FAT_NFS_RET_ID);\n  \n    --  COMMIT;\n  \n    V_SEQ := 0;\n    FOR R_ITEM IN C_ITEM LOOP\n      V_ID_ITEM := BEG_FNC_AD_SEQUENCE('BEG_CPR_NFE_ITEM');\n      V_SEQ     := V_SEQ + 1;\n    \n      V_ID_CFOP := R_ITEM.BEG_CFOP_ID;\n    \n      OPEN C_CFOP;\n      FETCH C_CFOP\n        INTO R_CFOP;\n      CLOSE C_CFOP;\n    \n      V_ID_ENT := R_CFOP.BEG_VW_CFOP_ENT_ID;\n      V_ID_SAI := R_CFOP.BEG_VW_CFOP_SAI_ID;\n    \n      INSERT INTO BEG_CPR_NFE_ITEM\n        (BEG_CPR_NFE_ITEM_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         SEQUENCIA,\n         QTD,\n         DES_ITEM_FORNECEDOR,\n         VLR_UNITARIO,\n         VLR_TOTAL,\n         VLR_TOTAL_CALC,\n         ALQ_ICMS,\n         ALQ_OUTROS_ICMS,\n         ALQ_ICMS_SUBST,\n         VLR_BASE_ICMS,\n         VLR_BASE_ICMS_CALC,\n         VLR_BASE_OUTROS_ICMS,\n         VLR_BASE_ICMS_SUBST,\n         VLR_BASE_ICMS_SUBST_CALC,\n         VLR_BASE_ISENTO_ICMS,\n         VLR_ICMS,\n         VLR_ICMS_CALC,\n         VLR_OUTROS_ICMS,\n         VLR_ICMS_SUBST,\n         VLR_ICMS_SUBST_CALC,\n         ALQ_IPI,\n         ALQ_OUTROS_IPI,\n         VLR_BASE_IPI,\n         VLR_BASE_IPI_CALC,\n         VLR_BASE_OUTROS_IPI,\n         VLR_BASE_ISENTO_IPI,\n         VLR_IPI,\n         VLR_IPI_CALC,\n         VLR_OUTROS_IPI,\n         ALQ_ISSQN,\n         VLR_BASE_ISSQN,\n         VLR_ISSQN,\n         VLR_FRETE,\n         VLR_FRETE_RDP,\n         QTD_VOLUMES,\n         PESO_BRUTO,\n         PESO_LIQUIDO,\n         VLR_SEGURO,\n         VLR_DESPESAS_FINANCEIRAS,\n         VLR_OUTRAS_DESPESAS,\n         PER_DESCONTO,\n         VLR_DESCONTO,\n         PER_ACRESCIMO,\n         VLR_ACRESCIMO,\n         IND_FRETE_NOTA,\n         OBS,\n         OBS_OUTRAS_DESPESAS,\n         BEG_CPR_NFE_ID,\n         BEG_PRODUTO_ID,\n         BEG_PRD_SKU_ID,\n         BEG_VW_CFOP_ENT_ID,\n         BEG_VW_CFOP_SAI_ID,\n         BEG_PRD_NCM_ID,\n         BEG_FIS_TRIB_ICMS_ID,\n         BEG_FIS_ORIGEM_MERC_ID,\n         BEG_EST_ALMOXARIFADO_ID,\n         IND_DESCONTO_ITEM,\n         IND_ACRESCIMO_ITEM,\n         IND_DESCONTO_BASE_ICMS,\n         IND_ACRESCIMO_BASE_ICMS,\n         IND_DESCONTO_BASE_IPI,\n         IND_ACRESCIMO_BASE_IPI,\n         BEG_CST_CALCULO_ID,\n         VLR_APURADO,\n         VLR_SUGERIDO,\n         VLR_VIGENTE,\n         ALQ_MARGEM,\n         PER_VARIACAO,\n         BEG_VW_NF_ORIGEM_ID,\n         BEG_VW_NF_ORIGEM_ITEM_ID,\n         BEG_EST_MOVTO_ESTOQUE_ID,\n         CST_PIS,\n         VLR_BASE_CALCULO_PIS,\n         PERC_PIS,\n         VLR_PIS,\n         CST_COFINS,\n         VLR_BASE_CALCULO_COFINS,\n         PERC_COFINS,\n         VLR_COFINS,\n         CST_ICMS,\n         PERC_REDUCAO_ICMS,\n         VLR_PISCOFINS,\n         NRO_ADICAO_DI,\n         VLR_DESP_ACES_IMP,\n         VL_IMPOSTO_IMPORTACAO,\n         VLR_BASE_COFINS,\n         ALQ_COFINS,\n         VLR_BASE_PIS,\n         ALQ_PIS,\n         BEG_VW_FORNECEDOR_ID,\n         BEG_VW_UF_ID,\n         LOCAL_DESEMBARACO,\n         DT_DESEMBARACO_ADUANA,\n         DT_REGISTRO_DI,\n         NRO_ACDRAWBACK,\n         NRO_DOC_IMPORTACAO,\n         BEG_FIS_CST_IPI_ID,\n         BEG_FIS_CST_PIS_ID,\n         BEG_FIS_CST_COFINS_ID,\n         BEG_TIPO_NF_ID,\n         BEG_FAT_PRE_NFS_ID,\n         BEG_FAT_PRE_NFS_ITEM_ID,\n         PER_ACRE_TMP,\n         PER_DESC_TMP,\n         PERC_MVAST,\n         PERC_REDUCAO_VLR_ICMS,\n         QTD_ORDEM,\n         PERC_ST_OC,\n         VLR_ITEM_ORDEM_COMPRA,\n         BEG_CPR_ORDEM_ID)\n      VALUES\n        (\n         \n         V_ID_ITEM,\n         R_ITEM.AD_CLIENT_ID,\n         R_ITEM.AD_ORG_ID,\n         R_ITEM.ISACTIVE,\n         R_ITEM.CREATED,\n         R_ITEM.CREATEDBY,\n         R_ITEM.UPDATED,\n         R_ITEM.UPDATEDBY,\n         V_SEQ, --R_ITEM.SEQUENCIA                ,\n         nvl(R_ITEM.QTDE, 0),\n         R_ITEM.DESC_TECNICA_ITEM,\n         nvl(R_ITEM.VL_UNITARIO, 0),\n         nvl(R_ITEM.TOTAL_BRUTO, 0),\n         nvl(R_ITEM.TOTAL_BRUTO, 0),\n         nvl(R_ITEM.PERC_ICMS, 0),\n         0, --R_ITEM.ALIQ_OUTRAS_ICMS          ,\n         nvl(R_ITEM.ALIQ_ICMS_SUBST, 0),\n         nvl(R_ITEM.VL_BASE_CALCULO_ICMS, 0),\n         nvl(R_ITEM.VL_BASE_CALCULO_ICMS, 0),\n         nvl(R_ITEM.VL_BASE_OUTRAS_ICMS, 0),\n         nvl(R_ITEM.VL_BASE_SUBST_TRIB, 0),\n         nvl(R_ITEM.VL_BASE_SUBST_TRIB, 0),\n         nvl(R_ITEM.VL_BASE_ISENTA_ICMS, 0),\n         nvl(R_ITEM.VL_ICMS, 0),\n         nvl(R_ITEM.VL_ICMS, 0),\n         0, --R_ITEM.VL_OUTRAS_ICMS          ,\n         nvl(R_ITEM.VL_ICMS_SUBST, 0),\n         nvl(R_ITEM.VL_ICMS_SUBST, 0),\n         NVL(R_ITEM.ALIQ_IPI, 0),\n         0, --R_ITEM.ALQ_OUTROS_IPI           ,\n         R_ITEM.VL_BASE_CALCULO_IPI,\n         R_ITEM.VL_BASE_CALCULO_IPI,\n         R_ITEM.VL_BASE_OUTRAS_IPI,\n         0, --R_ITEM.VLR_BASE_ISENTO_IPI      ,\n         R_ITEM.VL_IPI,\n         R_ITEM.VL_IPI,\n         0, --R_ITEM.VL_OUTROS_IPI           ,\n         0, -- R_ITEM.ALQ_ISSQN                ,\n         0, --R_ITEM.VLR_BASE_ISSQN           ,\n         0, --R_ITEM.VLR_ISSQN                ,\n         R_ITEM.VL_FRETE_ITEM,\n         0, --R_ITEM.VLR_FRETE_RDP            ,\n         0, --R_ITEM.QTD_VOLUMES              ,\n         nvl(R_ITEM.PESO_BRUTO, 0),\n         nvl(R_ITEM.PESO_LIQUIDO, 0),\n         0, --R_ITEM.VL_SEGURO               ,\n         0, --R_ITEM.VL_DESPESAS_FINANCEIRAS ,\n         R_ITEM.VL_OUTRAS_DESPESAS,\n         0, --R_ITEM.PER_DESCONTO             ,\n         R_ITEM.VL_DESCONTO,\n         0, --R_ITEM.PER_ACRESCIMO            ,\n         0, --R_ITEM.VLR_ACRESCIMO            ,\n         CASE WHEN :NEW.VL_FRETE > 0 THEN 'Y' ELSE 'N' END, --R_ITEM.IND_FRETE_NOTA           ,\n         NULL, --R_ITEM.OBS                      ,\n         NULL, --R_ITEM.OBS_OUTRAS_DESPESAS      ,\n         V_ID_CPR, --R_ITEM.BEG_CPR_NFE_ID           ,\n         R_ITEM.BEG_PRODUTO_ID,\n         R_ITEM.BEG_PRD_SKU_ID,\n         V_ID_ENT, --R_ITEM.BEG_VW_CFOP_ENT_ID       ,\n         V_ID_SAI, --R_ITEM.BEG_CFOP_ID,\n         R_ITEM.BEG_PRD_NCM_ID,\n         R_ITEM.BEG_FIS_TRIB_ICMS_ID,\n         R_ITEM.BEG_FIS_ORIGEM_MERC_ID,\n         NULL, --R_ITEM.BEG_EST_ALMOXARIFADO_ID  ,\n         CASE WHEN R_ITEM.VL_DESCONTO > 0 THEN 'Y' ELSE 'N' END, --R_ITEM.IND_DESCONTO_ITEM        ,\n         'N', --R_ITEM.IND_ACRESCIMO_ITEM       ,\n         'N', --R_ITEM.IND_DESCONTO_BASE_ICMS   ,\n         'N', --R_ITEM.IND_ACRESCIMO_BASE_ICMS  ,\n         'N', --R_ITEM.IND_DESCONTO_BASE_IPI    ,\n         'N', --R_ITEM.IND_ACRESCIMO_BASE_IPI   ,\n         NULL, --R_ITEM.BEG_CST_CALCULO_ID       ,\n         0, --R_ITEM.VLR_APURADO              ,\n         0, --R_ITEM.VLR_SUGERIDO             ,\n         0, --R_ITEM.VLR_VIGENTE              ,\n         0, --R_ITEM.ALIQ_MARGEM               ,\n         0, --R_ITEM.PER_VARIACAO             ,\n         NULL, --R_ITEM.BEG_VW_NF_ORIGEM_ID      ,\n         NULL, --R_ITEM.BEG_VW_NF_ORIGEM_ITEM_ID ,\n         NULL, --R_ITEM.BEG_EST_MOVTO_ESTOQUE_ID ,\n         R_ITEM.CST_PIS,\n         nvl(R_ITEM.VL_BASE_CALCULO_PIS, 0),\n         nvl(R_ITEM.PERC_PIS, 0),\n         nvl(R_ITEM.VL_PIS, 0),\n         R_ITEM.CST_COFINS,\n         nvl(R_ITEM.VL_BASE_CALCULO_COFINS, 0),\n         nvl(R_ITEM.ALIQ_COFINS, 0),\n         nvl(R_ITEM.VLR_COFINS, 0),\n         R_ITEM.CST,\n         nvl(R_ITEM.PERC_REDUCAO, 0),\n         0, --R_ITEM.VL_PISCOFINS            ,\n         NULL, --R_ITEM.NRO_ADICAO_DI            ,\n         0, --R_ITEM.VLR_DESP_ACES_IMP        ,\n         0, --R_ITEM.VL_IMPOSTO_IMPORTACAO    ,\n         nvl(R_ITEM.VL_BASE_CALCULO_COFINS, 0),\n         nvl(R_ITEM.ALIQ_COFINS, 0),\n         nvl(R_ITEM.VL_BASE_CALCULO_PIS, 0),\n         nvl(R_ITEM.ALIQ_PIS, 0),\n         :NEW.BEG_VW_FORNECEDOR_ID,\n         NULL, --R_ITEM.BEG_VW_UF_ID             ,\n         NULL, --R_ITEM.LOCAL_DESEMBARACO        ,\n         NULL, --R_ITEM.DT_DESEMBARACO_ADUANA    ,\n         NULL, --R_ITEM.DT_REGISTRO_DI           ,\n         NULL, --R_ITEM.NRO_ACDRAWBACK           ,\n         NULL, --R_ITEM.NRO_DOC_IMPORTACAO       ,\n         NULL, --R_ITEM.BEG_FIS_CST_IPI_ID       ,\n         NULL, --R_ITEM.BEG_FIS_CST_PIS_ID       ,\n         NULL, --R_ITEM.BEG_FIS_CST_COFINS_ID    ,\n         NULL, --R_ITEM.BEG_TIPO_NF_ID           ,\n         NULL, --R_ITEM.BEG_FAT_PRE_NFS_ID       ,\n         NULL, --R_ITEM.BEG_FAT_PRE_NFS_ITEM_ID  ,\n         0, --R_ITEM.PER_ACRE_TMP             ,\n         0, --R_ITEM.PER_DESC_TMP             ,\n         0, --R_ITEM.PERC_MVAST               ,\n         0, --R_ITEM.PERC_REDUCAO_VLR_ICMS    ,\n         0, --R_ITEM.QTD_ORDEM                ,\n         0, --R_ITEM.PERC_ST_OC               ,\n         0, --R_ITEM.VLR_ITEM_ORDEM_COMPRA    ,\n         NULL --R_ITEM.BEG_CPR_ORDEM_ID\n         );\n    \n      V_ID_IT_VEN := R_ITEM.DIE_FAT_NFS_ITEM_RETORNO_ID;\n    \n    END LOOP;\n  \n    :NEW.BEG_CPR_NFE_ID := V_ID_CPR;\n    :NEW.DOCSTATUS      := 'CO';\n  \n    COMMIT;\n  \n    V_RESULT := BEG_FNC_APROVA_NOTA(:NEW.BEG_CPR_NFE_ID);\n  \n    COMMIT;\n  END IF;\n\n  -----Cancelamento\n\n  IF UPDATING THEN\n    IF :NEW.STATUS = 135 AND :OLD.STATUS in (100, 150) THEN\n    \n      IF :NEW.BEG_CPR_NFE_ID IS NOT NULL THEN\n      \n        UPDATE BEG_CPR_NFE NE\n           SET NE.DOCSTATUS = 'CA', NE.DT_CANCELAMENTO = TRUNC(SYSDATE)\n         WHERE NE.BEG_CPR_NFE_ID = :NEW.BEG_CPR_NFE_ID;\n      \n        UPDATE DIE_FAT_SERVICO S\n           SET S.DT_CANCELAMENTO = NULL, S.BEG_CPR_NFE_ID = NULL\n         WHERE S.BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID;\n      \n        UPDATE DIE_CONTROLE_AP A\n           SET A.ISACTIVE = 'Y'\n         WHERE A.BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID;\n      \n        DELETE BEG_HST_NF_VINCULADA V\n         WHERE V.BEG_CPR_NFE_ID = :NEW.BEG_CPR_NFE_ID;\n      \n        -- BEG_EST_TP_ESPECIE_ID=2000107 cancelamento entrada\n        open BUSCA_ITENS;\n        loop\n          fetch BUSCA_ITENS\n            into VREG2;\n          exit when BUSCA_ITENS%notfound;\n          V_ALMOXARIFADO_ID := nvl(vreg2.beg_est_almoxarifado_id,\n                                   (BEG_FNC_RETORNA_PARAMETRO(1000000,\n                                                              :NEW.AD_ORG_ID,\n                                                              'Vendas',\n                                                              'Faturamento',\n                                                              'ALMOXARIFADO FATURAMENTO')));\n          insert into BEG_EST_MOVTO_ESTOQUE\n            (BEG_EST_MOVTO_ESTOQUE_ID,\n             AD_CLIENT_ID,\n             AD_ORG_ID,\n             ISACTIVE,\n             CREATED,\n             CREATEDBY,\n             UPDATED,\n             UPDATEDBY,\n             BEG_EST_TP_ESPECIE_ID,\n             BEG_PRD_SKU_ID,\n             BEG_EST_ALMOXARIFADO_ID,\n             VLR_MOVTO,\n             QTD_MOVTO,\n             BEG_PRODUTO_ID,\n             DOCUMENTO)\n          values\n            (BEG_FNC_AD_SEQUENCE('BEG_EST_MOVTO_ESTOQUE'),\n             :NEW.AD_CLIENT_ID,\n             :NEW.AD_ORG_ID,\n             'Y',\n             SYSDATE,\n             :NEW.CREATEDBY,\n             SYSDATE,\n             :NEW.UPDATEDBY,\n             2000107,\n             VREG2.BEG_PRD_SKU_ID,\n             V_ALMOXARIFADO_ID,\n             VREG2.VLR_UNITARIO,\n             VREG2.QTD,\n             VREG2.BEG_PRODUTO_ID,\n             :NEW.NRO_NFS);\n        end loop;\n      \n        commit;\n      \n      ELSE\n      \n        DIE_PRC_CANCELA_NOTA_SAIDA(case when\n                                   :new.tp_nota = '55' or :new.tp_nfe = 9 then\n                                   :NEW.NRO_NFS else :new.nro_cupom_fiscal end, --:NEW.NRO_NFS,\n                                   :NEW.SERIE_NFS,\n                                   :NEW.AD_ORG_ID);\n      \n        UPDATE DIE_CONTROLE_AP A\n           SET A.ISACTIVE = 'N'\n         WHERE A.BEG_FAT_NFS_ID = :NEW.DIE_FAT_NFS_RET_ID;\n      \n        DELETE DIE_FAT_SERVICO S\n         WHERE S.BEG_FAT_NFS_ID = :NEW.DIE_FAT_NFS_RET_ID;\n      \n        DELETE DIE_PES_BONUS_VENDA\n         WHERE DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n      \n        FOR X IN C_MONTA LOOP\n        \n          DELETE DIE_FAT_MONTAGEM_ITEM IT\n           WHERE IT.DIE_FAT_MONTAGEM_ID = X.DIE_FAT_MONTAGEM_ID;\n        \n          DELETE DIE_FAT_MONTAGEM IT\n           WHERE IT.DIE_FAT_MONTAGEM_ID = X.DIE_FAT_MONTAGEM_ID;\n        \n        END LOOP;\n      \n        commit;\n      END IF;\n    \n    END IF;\n  END IF;\n\nEND TRG_BIU_DIE_NFS_RET;\n"}`;
    
    }
}
