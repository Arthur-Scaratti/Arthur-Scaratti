
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_PRE_NFS
    {
        
        /// <summary>
        /// Valor de saldo de recibo para vincular mais de um ao pagamento da nf
        /// </summary>
        public int VLR_SALDO_REC { get; set; }
        
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
        /// Impressora de notas da matriz conforme cadastrado nos parametros sistema 
        /// </summary>
        public string IMPRESSORA_NF { get; set; }
        
        /// <summary>
        /// id do pedido de devolucao
        /// </summary>
        public int BEG_FAT_DEVOLUCAO_ID { get; set; }
        
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
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_PRE_NFS_ID { get; set; }
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
        /// Numero da Nota fiscal de Saida(Controle)
        /// </summary>
        public int NRO_NFS { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Serie da Nota Fiscal
        /// </summary>
        public string SERIE_NFS { get; set; }
        
        /// <summary>
        /// Data de emissao
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// Valor de base de calculo do icms
        /// </summary>
        public int VL_BASE_CALCULO_ICMS { get; set; }
        
        /// <summary>
        /// Valor da base isenta de icms
        /// </summary>
        public int VL_BASE_ISENTA_ICMS { get; set; }
        
        /// <summary>
        /// Valor da base outras icms
        /// </summary>
        public int VL_BASE_OUTRAS_ICMS { get; set; }
        
        /// <summary>
        /// Valor do ICMS
        /// </summary>
        public int VL_ICMS { get; set; }
        
        /// <summary>
        /// Valor da base de calculo do IPI
        /// </summary>
        public int VL_BASE_CALCULO_IPI { get; set; }
        
        /// <summary>
        /// Valor base de isentos do IPI
        /// </summary>
        public int VL_BASE_ISENTA_IPI { get; set; }
        
        /// <summary>
        /// Valor base outras do IPI
        /// </summary>
        public int VL_BASE_OUTRAS_IPI { get; set; }
        
        /// <summary>
        /// Valor do IPI
        /// </summary>
        public int VL_IPI { get; set; }
        
        /// <summary>
        /// Valor total dos produtos
        /// </summary>
        public int VL_TOTAL_PROD { get; set; }
        
        /// <summary>
        /// Valor total do frete
        /// </summary>
        public int VL_FRETE { get; set; }
        
        /// <summary>
        /// Valor do seguro
        /// </summary>
        public int VL_SEGURO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// tipo fi do pedido (1-avista, 2-parc. estab., 3-parc. adm)
        /// </summary>
        public string TIPOFI { get; set; }
        
        /// <summary>
        /// Valor de outras despesas
        /// </summary>
        public int VL_OUTRAS_DESPESAS { get; set; }
        
        /// <summary>
        /// Valor base do icms substituic?o tributaria
        /// </summary>
        public int VL_BASE_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// Valor do ICMS substituic?o tributaria
        /// </summary>
        public int VL_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// Valor total da Nota fiscal de saida
        /// </summary>
        public int VL_TOTAL_NFS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Placa do veiculo
        /// </summary>
        public string PLACA_VEICULO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Unidade federativa _ estado
        /// </summary>
        public string UF_VEICULO { get; set; }
        
        /// <summary>
        /// Valor do custo financeiro
        /// </summary>
        public int VL_CUSTO_FINANCEIRO { get; set; }
        
        /// <summary>
        /// ECF ou NFCE
        /// </summary>
        public int NRO_CUPOM_FISCAL { get; set; }
        
        /// <summary>
        /// Numero de serie do ECF
        /// </summary>
        public string SERIE_MAQUINA { get; set; }
            [StringLength(300)]
        /// <summary>
        /// Observac?es
        /// </summary>
        public string OBS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Integrado (s/n)
        /// </summary>
        public string INTEGRADO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Faturavel ('N' venda so de serviços 'Y' demais)
        /// </summary>
        public string FATURAVEL { get; set; }
        
        /// <summary>
        /// Data e hora da saida
        /// </summary>
        public string DT_SAIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTHR_ADORG_ID { get; set; }
        
        /// <summary>
        /// Valor da despesa financeira
        /// </summary>
        public int VL_DESP_FINANCEIRA { get; set; }
        
        /// <summary>
        /// Cliente/fornecedor (beg_pessoa)
        /// </summary>
        public int BEG_VW_PESSOA_ENTREGA_ID { get; set; }
        
        /// <summary>
        /// Codigo da Transportadora (beg_pessoa)
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
        /// Quantidade de volume
        /// </summary>
        public int QTD_VOLUME { get; set; }
        
        /// <summary>
        /// Peso Liquido
        /// </summary>
        public int PESO_LIQUIDO { get; set; }
        
        /// <summary>
        /// Peso bruto
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
        /// Tipo de pedido para a localizacao da matriz tributaria
        /// </summary>
        public int BEG_VEN_TIPO_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// cidade onde sera entregue a mercadoria
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
        
        /// <summary>
        /// Valor da base do ISSQN
        /// </summary>
        public int BASE_ISSQN { get; set; }
        
        /// <summary>
        /// Aliquota do ISSQN
        /// </summary>
        public int ALIQ_ISSQN { get; set; }
        
        /// <summary>
        /// Valor a ser retido do ISSQN e a ser descontado na emissao do titulo
        /// </summary>
        public int VALOR_ISSQN { get; set; }
        
        /// <summary>
        /// Valor da base do IRRF
        /// </summary>
        public int BASE_IRRF { get; set; }
        
        /// <summary>
        /// Aliquota do IRRF
        /// </summary>
        public int ALIQ_IRRF { get; set; }
        
        /// <summary>
        /// Valor do IRRF
        /// </summary>
        public int VALOR_IRRF { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Endereco onde sera efetuada a entrega
        /// </summary>
        public string ENDERECO_ENTREGA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Bairro onde sera efetuada a entrega
        /// </summary>
        public string BAIRRO_ENTREGA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Tipo de frete
        /// </summary>
        public string TP_FRETE { get; set; }
        
        /// <summary>
        /// Valor do desconto 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// Valor do inss a ser descontado na emissao do titulo
        /// </summary>
        public int VLR_INSS { get; set; }
        
        /// <summary>
        /// valor da base do inss
        /// </summary>
        public int BASE_INSS { get; set; }
        
        /// <summary>
        /// aliq do inss
        /// </summary>
        public int ALIQ_INSS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TRANSPORTADORA { get; set; }
        
        /// <summary>
        /// Almoxarifado
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// Especie Volume
        /// </summary>
        public int BEG_FAT_ESPECIE_VOLUME_ID { get; set; }
        
        /// <summary>
        /// Rota
        /// </summary>
        public int BEG_FRO_ROTA_ID { get; set; }
        
        /// <summary>
        /// Tipo frete
        /// </summary>
        public int BEG_GER_TIPO_FRETE_ID { get; set; }
        
        /// <summary>
        /// Tipo de transporte
        /// </summary>
        public int BEG_GER_TIPO_TRANSP_ID { get; set; }
        
        /// <summary>
        /// Tipo de nota fiscal
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// Unidade Federativa Endereco entrega
        /// </summary>
        public int BEG_UF_ID { get; set; }
        
        /// <summary>
        /// Forma de cobranca
        /// </summary>
        public int BEG_VEN_FORMA_COBRANCA_ID { get; set; }
        
        /// <summary>
        /// Forma de Pagamento
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// Plano de Venda
        /// </summary>
        public int BEG_VEN_PLANO_VENDA_ID { get; set; }
        
        /// <summary>
        /// Cidade / Importacao
        /// </summary>
        public int BEG_VW_CIDADE_ID { get; set; }
        
        /// <summary>
        /// Codigo modelo fiscal
        /// </summary>
        public int BEG_VW_FIS_COD_MODELO_ID { get; set; }
        
        /// <summary>
        /// Fornecedor / Entradas
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// Unidade federativa local embarque / Importacao
        /// </summary>
        public int BEG_VW_UF_ID { get; set; }
            [StringLength(9)]
        /// <summary>
        /// Cep Endereco de entrega
        /// </summary>
        public string CEP_ENDERECO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Botao para calculo/recalculo nota
        /// </summary>
        public string BT_CALCULO { get; set; }
            [StringLength(44)]
        /// <summary>
        /// Chave eletronica NF Referenciada
        /// </summary>
        public string CHAVE_NF_REFERENCIADA { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Complemento endereco entrega
        /// </summary>
        public string COMPLEMENTO_END { get; set; }
            [StringLength(10)]
        /// <summary>
        /// numero endereco entrega
        /// </summary>
        public string NUMERO { get; set; }
            [Required]
        /// <summary>
        /// Tipo de lacamento (E)ntrada / (S)aida
        /// </summary>
        public string TP_LANCTO_CONTABIL { get; set; }
            [Required]
        /// <summary>
        /// Valor COFINS
        /// </summary>
        public int VL_COFINS { get; set; }
            [Required]
        /// <summary>
        /// Valor PIS
        /// </summary>
        public int VL_PIS { get; set; }
        
        /// <summary>
        /// Nota fiscal de entrada relacionada
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// Nota fiscal de saida relacionada
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
        /// Status da nf 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// Pedido de venda
        /// </summary>
        public int DIE_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// financeira
        /// </summary>
        public int DIE_FIN_FINANCEIRA_ID { get; set; }
        
        /// <summary>
        /// Codigo Convenio
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// VEndedor
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
        
        /// <summary>
        /// Valor seguro AP premiado
        /// </summary>
        public int VLR_SEGUROS { get; set; }
        
        /// <summary>
        /// Valor garantia estendida
        /// </summary>
        public int VLR_GARANTIA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// descricao do tipo de pedido
        /// </summary>
        public string NATOPERACAO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// numero da nota referente
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
        /// Finalidade da nota fiscal 1.Nomal 2.Complementar 3.Ajuste 4-devolucao
        /// </summary>
        public int FIN_NFE { get; set; }
        
        /// <summary>
        /// 55 NFe, 65-NFCe
        /// </summary>
        public int TP_NFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TP_PAGTO { get; set; }
            [Required]
        /// <summary>
        /// indicativo de utilizacao e aprovacao da nf ( 0-Pendente, 1-Utilizada)
        /// </summary>
        public int IND_BLOQUEADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDEPARC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOT_TRIB_APROX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_RECIBO_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BU_DIE_FAT_PRE_NFS { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n\n  CURSOR C1 IS\n    SELECT *\n      FROM DIE_FAT_PRE_NFS N\n     WHERE N.DIE_CRC_RECIBO_ID = :NEW.DIE_CRC_RECIBO_ID\n       AND N.AD_ORG_ID = :NEW.AD_ORG_ID;\n  R1 C1%ROWTYPE;\n\n  CURSOR BUSCA_RECIBO IS\n    SELECT SUM(N.VALOR) VALOR\n      FROM DIE_CRC_RECIBO N\n     WHERE N.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n\n  R_RECIBO BUSCA_RECIBO%ROWTYPE;\n\nBEGIN\n\n  IF UPDATING THEN\n  \n    IF :OLD.DIE_CRC_RECIBO_ID IS NULL AND :NEW.DIE_CRC_RECIBO_ID IS NOT NULL THEN\n    \n      UPDATE DIE_ITEPED IP\n         SET IP.VALUE = IP.VALUE\n       WHERE IP.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n    \n     /* OPEN BUSCA_RECIBO;\n      FETCH BUSCA_RECIBO\n        INTO R_RECIBO;\n      CLOSE BUSCA_RECIBO;\n    \n      IF R_RECIBO.VALOR <> :NEW.VL_TOTAL_NFS AND\n         :NEW.BEG_EST_TP_ESPECIE_ID NOT IN (2000002, 2000005) THEN\n      \n        RAISE_APPLICATION_ERROR(-20001,\n                                'Valor do recibo diferente do valor total da nota !!  Verifique!');\n      \n      END IF;*/\n    \n    END IF;\n  \n    IF :NEW.DOCSTATUS = 'CA' THEN\n    \n      :NEW.IND_BLOQUEADO := 1;\n    \n    END IF;\n  \n    IF :NEW.VLR_SALDO_REC > 0 AND :NEW.VL_TOTAL_NFS = :NEW.VLR_SALDO_REC AND :NEW.VLR_SALDO_REC <> :OLD.VLR_SALDO_REC AND :NEW.BEG_EST_TP_ESPECIE_ID NOT IN (2000005,2000002) THEN\n    \n      :NEW.IND_BLOQUEADO := 0;\n    \n    END IF;\n  \n    IF :NEW.VLR_SALDO_REC > 0 AND :NEW.VL_TOTAL_NFS <> :NEW.VLR_SALDO_REC AND :NEW.BEG_EST_TP_ESPECIE_ID NOT IN (2000005,2000002) THEN\n    \n      :NEW.IND_BLOQUEADO := 1;\n    \n    END IF;\n  \n  END IF;\n\nEND;\n"}`;
    
    }
}
