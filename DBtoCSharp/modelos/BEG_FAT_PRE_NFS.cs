
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FAT_PRE_NFS
    {
        
        /// <summary>
        /// Indicativo de destino da NF
        /// </summary>
        public int IDDEST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_DEV_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_PARCELA_CIAP { get; set; }
        
        /// <summary>
        /// abater o valor do issqn do valor da nota na hora do titulo
        /// </summary>
        public string IND_ISSQN_RETIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CIAP { get; set; }
        
        /// <summary>
        /// CIAP
        /// </summary>
        public int VLR_INFORMADO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_TP_PEDIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_RECIBO_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Identificacao de transacao realizada pelo ecommerce
        /// </summary>
        public string TID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_TAXA_ID { get; set; }
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
        /// Tabela de classificacao do codigo de tributacao no municipio.
        /// </summary>
        public int DIE_ISSQN_SUBITEM_ID { get; set; }
        
        /// <summary>
        /// ID do convênio caso a vendas seja desse tipo
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica presenca do destinatario no momento da venda
        /// </summary>
        public string IND_PRESENCA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_PRE_NFS_ID { get; set; }
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
        /// Numero da Nota fiscal de Saida
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
        /// Numero da duplicata da nota fiscal de saida
        /// </summary>
        public int NRO_DUPLICATA { get; set; }
        
        /// <summary>
        /// Percentual de icms
        /// </summary>
        public int PERC_ICMS { get; set; }
        
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
        /// Percentual de desconto
        /// </summary>
        public int PERC_DESCONTO { get; set; }
        
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
            [StringLength(20)]
        /// <summary>
        /// Placas do veiculo redespecho
        /// </summary>
        public string PLACA_VEICULO_REDES { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Unidade federativa do veiculo - redespacho
        /// </summary>
        public string UF_VEICULO_REDES { get; set; }
        
        /// <summary>
        /// Valor do custo financeiro
        /// </summary>
        public int VL_CUSTO_FINANCEIRO { get; set; }
        
        /// <summary>
        /// Numero do cupon fiscal
        /// </summary>
        public int NRO_CUPON_FISCAL { get; set; }
        
        /// <summary>
        /// Numero de serie do ECF
        /// </summary>
        public string SERIE_MAQUINA { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Observac?es
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// Percentual de comiss?o do pedido
        /// </summary>
        public int PERC_COMISSAO_PEDIDO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Integrado (s/n)
        /// </summary>
        public string INTEGRADO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Faturavel (s/n)
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
            [StringLength(1)]
        /// <summary>
        /// Gerado arquivo EDI (s/n)
        /// </summary>
        public string GERADO_ARQ_EDI { get; set; }
        
        /// <summary>
        /// Cliente/fornecedor (beg_pessoa)
        /// </summary>
        public int BEG_VW_PESSOA_ENTREGA_ID { get; set; }
        
        /// <summary>
        /// Codigo do representante (beg_pessoa)
        /// </summary>
        public int BEG_VW_REPRESENTANTE_ID { get; set; }
        
        /// <summary>
        /// Codigo da Transportadora (beg_pessoa)
        /// </summary>
        public int BEG_VW_TRANSPORTADORA_ID { get; set; }
        
        /// <summary>
        /// Codigo da transp redespacho (beg_pessoa)
        /// </summary>
        public int BEG_VW_REDESPACHO_ID { get; set; }
        
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
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CFOP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PESSOA_COBRANCA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_COBRANCA { get; set; }
        
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
        /// comissao vendedor
        /// </summary>
        public int COMISSAO_VENDEDOR { get; set; }
        
        /// <summary>
        /// comissao televendas
        /// </summary>
        public int COMISSAO_TELEVENDAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESC_SUFRAMA { get; set; }
        
        /// <summary>
        /// Utilizada quando do faturmento parcial
        /// </summary>
        public int BEG_FAT_PARCIAL_CLIENTE_ID { get; set; }
        
        /// <summary>
        /// Tipo de pedido para a localizacao da matriz tributaria
        /// </summary>
        public int BEG_VEN_TIPO_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// cidade onde sera entregue a mercadoria
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
        
        /// <summary>
        /// botao para a impressao da nota manual
        /// </summary>
        public string IMPRESSO { get; set; }
        
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
        /// botao para impreessao da nota 
        /// </summary>
        public string ROMANEIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ENTRADA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_PARCELA { get; set; }
        
        /// <summary>
        /// valor da base do inss
        /// </summary>
        public int BASE_INSS { get; set; }
        
        /// <summary>
        /// aliq do inss
        /// </summary>
        public int ALIQ_INSS { get; set; }
        
        /// <summary>
        /// Tipo de produto aceito nesta nota.
        /// </summary>
        public int BEG_PRD_TIPO_ID { get; set; }
        
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
            [StringLength(1000)]
        /// <summary>
        /// Dado adicional ao produto / exportacao
        /// </summary>
        public string DADO_ADICIONAL_PRODUTO_EXP { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Dado adicional despachante / exportacao
        /// </summary>
        public string DA_DESPACHANTE_EXP { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Dado adicional local entrraga / exportacao
        /// </summary>
        public string DA_LOCAL_ENTREGA_EXP { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Dado adicional modalidade frete / exportacao
        /// </summary>
        public string DA_MODALIDADE_FRETE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Dado adicional nro drawback / exportacao
        /// </summary>
        public string DA_NRO_DRAWBACK { get; set; }
            [Required]
        /// <summary>
        /// Dado adicional taxa utilizada / exportacao
        /// </summary>
        public int DA_TAXA_UTILIZADA_EXP { get; set; }
            [Required]
        /// <summary>
        /// Dado adicional vlr.frete externo / exportacao
        /// </summary>
        public int DA_VL_FRETE_EXTERNO { get; set; }
            [Required]
        /// <summary>
        /// Dado adicional vlr.frete interno / exportacao
        /// </summary>
        public int DA_VL_FRETE_INTERNO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Descricao Cidade endereco entrada
        /// </summary>
        public string DESCR_CIDADE { get; set; }
        
        /// <summary>
        /// Data desembaraco aduana
        /// </summary>
        public string DT_DESEMBARACO_ADUANA { get; set; }
        
        /// <summary>
        /// Data emissao nf produtor rural
        /// </summary>
        public string DT_EMISSAO_PRODUTOR_RURAL { get; set; }
        
        /// <summary>
        /// Data Registro DI
        /// </summary>
        public string DT_REGISTRO_DI { get; set; }
            [Required]
        /// <summary>
        /// Importação (Y/N)
        /// </summary>
        public string IND_IMPORTACAO { get; set; }
            [StringLength(60)]
        /// <summary>
        /// local desembaraço
        /// </summary>
        public string LOCAL_DESEMBARACO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// local entrega exportação
        /// </summary>
        public string LOCAL_ENTREGA_EXP { get; set; }
            [StringLength(25)]
        /// <summary>
        /// marca
        /// </summary>
        public string MARCA { get; set; }
        
        /// <summary>
        /// Nota fiscal produtor rural
        /// </summary>
        public int NF_PRODUTOR_RURAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Nro drawback
        /// </summary>
        public string NRO_ACDRABACK { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Nro. (D)ocumento (I)mportacao
        /// </summary>
        public string NRO_DOC_IMPORTACAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// numeracao (transporte)
        /// </summary>
        public string NUMERACAO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// numero endereco entrega
        /// </summary>
        public string NUMERO { get; set; }
        
        /// <summary>
        /// Serie nf produtor rural
        /// </summary>
        public int SERIE_PRODUTOR_RURAL { get; set; }
            [Required]
        /// <summary>
        /// Tipo de lacamento (E)ntrada / (S)aida
        /// </summary>
        public string TP_LANCTO_CONTABIL { get; set; }
        
        /// <summary>
        /// unidad Federativa local entrega Exportacao
        /// </summary>
        public string UF_ENTREGA_EXP { get; set; }
            [Required]
        /// <summary>
        /// Valor AC|R Tributo / Importacao
        /// </summary>
        public int VLR_ACR_TRIBUTO { get; set; }
            [Required]
        /// <summary>
        /// Valor funrural - produtor rural
        /// </summary>
        public int VLR_FUNRURAL { get; set; }
            [Required]
        /// <summary>
        /// Valor Acrescimo Internacional
        /// </summary>
        public int VL_ACRESCIMO_INTERNACIONAL { get; set; }
            [Required]
        /// <summary>
        /// Valor Aduaneiro Importação
        /// </summary>
        public int VL_ADUANEIRO { get; set; }
            [Required]
        /// <summary>
        /// Valor base Cofins Importacao
        /// </summary>
        public int VL_BASE_COFINS_IMP { get; set; }
            [Required]
        /// <summary>
        /// Valor base Pis Importação
        /// </summary>
        public int VL_BASE_PIS_IMP { get; set; }
            [Required]
        /// <summary>
        /// Valor COFINS
        /// </summary>
        public int VL_COFINS { get; set; }
            [Required]
        /// <summary>
        /// Valor Despesa Acessoria Importacao
        /// </summary>
        public int VL_DESP_ACES_IMP { get; set; }
            [Required]
        /// <summary>
        /// Valor dolar
        /// </summary>
        public int VL_DOLAR { get; set; }
            [Required]
        /// <summary>
        /// Valor frete Intenacional
        /// </summary>
        public int VL_FRETE_INTERNACIONAL { get; set; }
            [Required]
        /// <summary>
        /// Valor Imposto Importacao      
        /// </summary>
        public int VL_IMPOSTO_IMPORTACAO { get; set; }
            [Required]
        /// <summary>
        /// Valor PIS
        /// </summary>
        public int VL_PIS { get; set; }
            [Required]
        /// <summary>
        /// Valor Seguro Internacional
        /// </summary>
        public int VL_SEGURO_INTERNACIONAL { get; set; }
            [Required]
        /// <summary>
        /// Valor SISCOMEX
        /// </summary>
        public int VL_SISCOMEX { get; set; }
            [Required]
        /// <summary>
        /// Valor THC
        /// </summary>
        public int VL_THC { get; set; }
        
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
        /// Finalidade da nota fiscal 1.Nomal 2.Complementar 3.Ajuste 4-devolucao
        /// </summary>
        public int IND_FINALIDADE { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_FAT_PRE_NFS { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  v_id   number;\n  v_qtde number := 0;\n\n  cursor c1 is\n    select t.*\n      from beg_ven_tipo_pedido t\n     where t.beg_ven_tipo_pedido_id = :new.beg_ven_tipo_pedido_id;\n  r1 c1%rowtype;\n\n  cursor busca_fl is\n\n    select df.*\n      from beg_dado_filial df\n     where df.ad_org_id = :new.ad_org_id;\n\n  r_fl busca_fl%rowtype;\n\n  cursor busca_fl2 is\n\n    select df.ad_org_id\n      from beg_dado_filial df\n     where df.beg_pessoa_id = v_id; --:new.beg_vw_cliente_id;\n\n  r_fl2 busca_fl2%rowtype;\n\nbegin\n\n  if :new.ad_org_id is not null then\n\n    v_id := nvl(:new.beg_vw_cliente_id, :new.beg_vw_pessoa_entrega_id);\n\n    OPEN busca_fl;\n    FETCH busca_fl\n      INTO r_fl;\n    CLOSE busca_fl;\n\n    OPEN c1;\n    FETCH c1\n      INTO r1;\n    CLOSE c1;\n\n    if r1.ind_aceita_mesma_fl = 'N' and\n       r_fl.beg_pessoa_id = :new.beg_vw_cliente_id then\n      raise_application_error(-20001,\n                              'Filial destino igual filial emitente nao permitido para este tipo de pedido');\n    end if;\n\n    if r1.desc_tipo_pedido like 'TRANSF%' then\n\n      OPEN busca_fl2;\n      FETCH busca_fl2\n        INTO r_fl2;\n      CLOSE busca_fl2;\n\n      if NVL(r_fl2.ad_org_id, 1) = 1 then\n        raise_application_error(-20001,\n                                'Transferencia somente permitido para filiais. Verifique destino da NOTA!!');\n      end if;\n\n    end if;\n\n  end if;\n  if updating and\n     ((:new.beg_vw_pessoa_entrega_id <> :old.beg_vw_pessoa_entrega_id) or\n     (:new.beg_vw_cliente_id <> :old.beg_vw_cliente_id)) then\n\n    select count(1)\n      into v_qtde\n      from beg_fat_pre_nfs_item i\n     where i.beg_fat_pre_nfs_id = :new.beg_fat_pre_nfs_id;\n\n    if v_qtde > 0 then\n\n      raise_application_error(-20001,\n                              'Nota ja possui itens lancados nao permite trocar destinatário!!');\n\n    end if;\n\n  end if;\n\nend die_trg_biu_fat_pre_nfs;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_FAT_PRE_NFS { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  cursor Busca_Tipo_Pedido is\n    select p.Beg_Ven_Tipo_Pedido_Id,\n           p.Beg_Cidade_Id,\n           tp.desc_tipo_pedido,\n           tp.ind_aceita_mesma_fl\n      from Beg_Ven_Pedido p,\n           beg_ven_tipo_pedido tp\n     where p.Beg_Ven_Pedido_Id = :new.Beg_Ven_Pedido_Id\n     and   tp.beg_ven_tipo_pedido_id = p.beg_ven_tipo_pedido_id;\n  --\n  v_Tipo_Pedido Busca_Tipo_Pedido%rowtype;\n  --\n  cursor Busca_Cidade_Cliente is\n    select p.Beg_Cidade_Id\n      from Beg_Pessoa p\n     where p.Beg_Pessoa_Id = :new.Beg_Vw_Cliente_Id;\n  --\n  v_Cidade Busca_Cidade_Cliente%rowtype;\n\n  ----\n  cursor Busca_Cliente is\n    select p.*\n      from Beg_Pessoa p\n     where p.Beg_Pessoa_Id = NVL(:new.Beg_Vw_Cliente_Id,:NEW.BEG_VW_FORNECEDOR_ID);\n  --\n  v_CLIENTE Busca_Cliente%rowtype;\n\n\n  --\n  cursor Busca_almoxarifado is\n  select al.beg_est_tp_almoxarifado_id\n  from beg_est_almoxarifado al\n  where al.beg_est_almoxarifado_id = :new.beg_est_almoxarifado_id;\n   r_alm Busca_almoxarifado%rowtype;\n\n\n  --\n  cursor Busca_Num_Nf(p_serie varchar2) is\n    select Nvl(n.Num_Nf, 0) + 1 Num_Nf, n.Beg_Fat_Num_Nf_Id, n.Serie\n      from Beg_Fat_Num_Nf n\n     where Serie = p_serie\n     and   ad_org_id = decode(:new.ad_org_id,1000134,1000016,:new.ad_org_id)\n       for update;\n  --\n  Vnum_Nf Busca_Num_Nf%rowtype;\n  --\n  cursor Busca_Tp_Nf is\n    select *\n      from Beg_Ven_Tipo_Pedido p\n     where p.Beg_Ven_Tipo_Pedido_Id = :new.Beg_Ven_Tipo_Pedido_Id;\n  --\n  v_Tp_Nf   Busca_Tp_Nf%rowtype;\n  v_servico number(10);\n  v_serie   varchar2(4);\n  --\nbegin\n  --\n  IF INSERTING THEN\n\n   :NEW.CREATED := SYSDATE;\n   :NEW.UPDATED := SYSDATE;\n\n  END IF;\n\n  IF UPDATING THEN\n\n   :NEW.UPDATED := SYSDATE;\n\n  END IF;\n\n  IF INSERTING or UPDATING THEN\n\n /* IF :NEW.AD_ORG_ID = 1000134 THEN\n\n    IF :NEW.BEG_VW_TRANSPORTADORA_ID IS NULL THEN\n      RAISE_APPLICATION_ERROR(-20001,'Notas da Fl 80 sempre informar transportadora!');\n    END IF;\n\n   IF NVL(:NEW.PESO_LIQUIDO,0) = 0  THEN\n      RAISE_APPLICATION_ERROR(-20001,'Notas da Fl 80 sempre informar peso liquido!');\n    END IF;\n\n     IF NVL(:NEW.PESO_BRUTO,0) = 0 THEN\n      RAISE_APPLICATION_ERROR(-20001,'Notas da Fl 80 sempre informar peso bruto!');\n    END IF;\n\n     IF NVL(:NEW.QTD_VOLUME,0) = 0 THEN\n      RAISE_APPLICATION_ERROR(-20001,'Notas da Fl 80 sempre informar quantidade de volumes!');\n    END IF;\n\n\n\n  END IF;\n  */\n\n   IF :NEW.BEG_VW_TRANSPORTADORA_ID IS NOT NULL THEN\n     \n    IF :NEW.BEG_GER_TIPO_FRETE_ID IS NULL THEN\n      RAISE_APPLICATION_ERROR(-20001,'Informado transportadora deve ser informado tipo de frete!');\n    END IF;\n    \n    IF nvl(:NEW.QTD_VOLUME,0)=0  THEN\n      RAISE_APPLICATION_ERROR(-20001,'Informado transportadora deve ser informado quantidade de volumes!');\n    END IF;\n    \n    IF nvl(:NEW.PESO_BRUTO,0)=0  THEN\n      RAISE_APPLICATION_ERROR(-20001,'Informado transportadora deve ser informado peso bruto!');\n    END IF;\n    \n    IF nvl(:NEW.PESO_LIQUIDO,0)=0  THEN\n      RAISE_APPLICATION_ERROR(-20001,'Informado transportadora deve ser informado peso liquido!');\n    END IF;\n    \n    IF :NEW.BEG_FAT_ESPECIE_VOLUME_ID IS NULL THEN\n      RAISE_APPLICATION_ERROR(-20001,'Informado transportadora deve ser informado tipo de volumes!');\n    END IF;\n     \n   END IF;\n\n    open Busca_Cliente;\n      fetch Busca_Cliente into v_CLIENTE;\n      close Busca_Cliente;\n\n   IF V_CLIENTE.TP_PESSOA = 'J' AND V_CLIENTE.ATIVO_SINTEGRA='N' THEN\n     RAISE_APPLICATION_ERROR(-20001,'Nota para pessoa juridica inativa no sintegra, contatar suporte para revisao!');\n   END IF;\n\n  END IF;\n--Validacao tipo de pedido\n   IF V_CLIENTE.TP_PESSOA = 'J' AND :NEW.BEG_UF_ID=1000000 AND :NEW.BEG_TIPO_NF_ID=1000000 AND :NEW.BEG_VEN_TIPO_PEDIDO_ID not in (2000037,2000061) THEN\n     RAISE_APPLICATION_ERROR(-20001,'Nota de venda para pessoa juridica no estado deve ser informado o tipo de pedido : VENDA MERC. N/ESTADO PJ P/ REVENDA !');\n   END IF;  \n   \n  :new.obs := replace(REPLACE(:NEW.OBS,CHR(13),' '),CHR(10),' ');\n  :new.obs := trim((replace(REPLACE(:new.OBS,CHR(13),' '),CHR(9),' ')));\n\n\n  :new.desc_tp_pedido := UPPER(:new.desc_tp_pedido);\n\n\n  if NVL(:NEW.CHAVE_NF_REFERENCIADA,0) > 0 THEN\n\n    IF LENGTH(:NEW.CHAVE_NF_REFERENCIADA) <> 44 THEN\n      RAISE_APPLICATION_ERROR(-20001,'Verificar chave de acesso da nf referencia, não esta com 44 digitos!');\n    END IF;\n\n  END IF;\n\n\n  ---\n  IF NVL(:NEW.IND_CIAP,'N') = 'Y' THEN\n    NULL;\n    GOTO FIM;\n  END IF;\n  --\n  :new.dt_emissao := trunc(:new.dt_emissao);\n  --\n  IF :NEW.PLACA_VEICULO IS NOT NULL THEN\n    :NEW.PLACA_VEICULO := UPPER(REPLACE(REPLACE(:NEW.PLACA_VEICULO,'-',''),'.',''));\n  END IF;\n  --\n  If :new.beg_est_tp_especie_id = 2000021 and :new.beg_est_almoxarifado_id is null then\n     RAISE_APPLICATION_ERROR(-20001,'Falta informar de qual almoxarifado vai sair estes produtos!');\n  end if;\n/*\n   If :new.beg_est_tp_especie_id = 2000021 and :new.beg_est_almoxarifado_id is not null then\n\n\n      open Busca_almoxarifado;\n      fetch Busca_almoxarifado into r_alm;\n      close Busca_almoxarifado;\n\n      if r_alm.beg_est_tp_almoxarifado_id <>2000003 then\n     RAISE_APPLICATION_ERROR(-20001,'Somente informar almoxarifado de assistencia para este tipo de nota!');\n      end if;\n  end if;*/\n\n  ----\n  if Inserting then\n      open Busca_Tipo_Pedido;\n      fetch Busca_Tipo_Pedido into v_Tipo_Pedido;\n      close Busca_Tipo_Pedido;\n      :new.desc_tp_pedido := v_Tipo_Pedido.desc_tipo_pedido;\n      v_serie := Beg_Fnc_Retorna_Parametro(:new.Ad_Client_Id,\n                                           :new.Ad_Org_Id,\n                                           'Geral',\n                                           'Faturamento',\n                                           'SERIE_AUTOMATICA');\n    :new.Vl_Total_Nfs := Nvl(:new.Vl_Frete, 0);\n    :new.Vl_Total_Nfs := Nvl(:new.Vl_Total_Nfs, 0) -\n                         Nvl(:new.Vlr_Desconto, 0);\n    if Nvl(:new.Nro_Nfs, 0) = 0 then\n      /*open Busca_Num_Nf(v_serie);\n      fetch Busca_Num_Nf\n        into Vnum_Nf;\n      close Busca_Num_Nf;*/\n      :new.Nro_Nfs   := :NEW.BEG_FAT_PRE_NFS_ID;\n      :new.Serie_Nfs := 'NE';\n      --\n      /*update Beg_Fat_Num_Nf s\n         set s.Num_Nf = s.Num_Nf + 1\n       where s.Beg_Fat_Num_Nf_Id = Vnum_Nf.Beg_Fat_Num_Nf_Id;*/\n      --\n    end if;\n  end if;\n  if Updating then\n    :new.Vl_Total_Nfs := Nvl(:new.Vl_Total_Nfs, 0) +\n                         Nvl(:old.Vlr_Desconto, 0) -\n                         Nvl(:new.Vlr_Desconto, 0);\n    --\n    if NVL(:new.Base_Issqn,0) > 0 and NVL(:new.Aliq_Issqn,0) > 0 then\n      --\n      :new.Valor_Issqn := round(((:new.Base_Issqn * :new.Aliq_Issqn) / 100),2);\n      --\n    ELSIF NVL(:new.Base_Issqn,0) > 0 and NVL(:new.Valor_Issqn,0) > 0 then\n      --\n      :NEW.ALIQ_ISSQN := round(((100 * :new.Valor_Issqn) / :new.Base_Issqn),2);\n      --\n    end if;\n    --\n    if NVL(:new.Base_Irrf,0) > 0 and NVL(:new.Aliq_Irrf,0) > 0 then\n      --\n      :new.Valor_Irrf := round(((:new.Base_Irrf * :new.Aliq_Irrf) / 100), 2);\n      --\n    ELSIF NVL(:new.Base_Irrf,0) > 0 and NVL(:new.Valor_Irrf,0) > 0 then\n      --\n      :new.Aliq_Irrf := round(((100 * :new.Valor_Irrf) / :new.Base_Irrf), 2);\n      --\n    end if;\n    --\n    if NVL(:new.Base_Inss,0) > 0 and NVL(:new.Aliq_Inss,0) > 0 then\n      --\n      :new.Vlr_Inss := round(((:new.Base_Inss * :new.Aliq_Inss) / 100), 2);\n      --\n    ELSIF NVL(:new.Base_Inss,0) > 0 and NVL(:new.Vlr_Inss,0) > 0 then\n      --\n      :new.Aliq_Inss := round(((100 * :new.Vlr_Inss) / :new.Base_Inss), 2);\n      --\n    end if;\n    --\n    :new.Vl_Total_Nfs := :new.Vl_Total_Nfs - Nvl(:old.Vl_Frete, 0);\n    :new.Vl_Total_Nfs := :new.Vl_Total_Nfs + Nvl(:new.Vl_Frete, 0);\n    if :new.Beg_Vw_Cliente_Id <> :old.Beg_Vw_Cliente_Id then\n      :new.Beg_Vw_Pessoa_Entrega_Id  := :new.Beg_Vw_Cliente_Id;\n      :new.Beg_Vw_Pessoa_Cobranca_Id := :new.Beg_Vw_Cliente_Id;\n    end if;\n  end if;\n  if :new.Beg_Vw_Pessoa_Cobranca_Id is null then\n    :new.Beg_Vw_Pessoa_Cobranca_Id := :new.Beg_Vw_Cliente_Id;\n  end if;\n\n  -- Validar tipo de pedido auditoria ser para fl15 ( faltas e sobras)\n IF INSERTING or UPDATING THEN\n    IF :NEW.Beg_Ven_Tipo_Pedido_Id IN ('2000055','2000057')\n    AND :NEW.BEG_VW_CLIENTE_ID NOT IN ('2000018') THEN\n    RAISE_APPLICATION_ERROR(-20001,'ACERTOS DE AUDITORIA SOMENTE PARA FL-15!');\n    END IF;\n  END IF;    \n\n  <<FIM>>\n  --\n  NULL;\n  --\nend Beg_Trg_Biu_Fat_Pre_Nfs;\n"}`;
    
    }
}
