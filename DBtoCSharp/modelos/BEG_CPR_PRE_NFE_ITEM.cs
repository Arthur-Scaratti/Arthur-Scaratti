
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPR_PRE_NFE_ITEM
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_ORIGEM_MERC_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_DESCONTO_ITEM { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ACRESCIMO_ITEM { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        public int VLR_APURADO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SUGERIDO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VIGENTE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_MARGEM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PER_VARIACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESPESAS_INTERNAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_DESC_TMP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_ACRE_TMP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_CONFERIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_IPI_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_PIS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_COFINS_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DES_REFERENCIA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_DOC_IMPORTACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_PIS_IMPORTACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_COFINS_IMPORTACAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_ACDRAWBACK { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_REGISTRO_DI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_DESEMBARACO_ADUANA { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL_DESEMBARACO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_UF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_IMPOSTO_IMPORTACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_PRE_NFS_ITEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESP_ACES_IMP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_ADICAO_DI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CIDADE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_PRE_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_ORDEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_MVAST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ITEM_ORDEM_COMPRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ST_OC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_ORDEM { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string UNIDADE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CEST { get; set; }
        
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
            [StringLength(14)]
        /// <summary>
        /// Nr do GTIN
        /// </summary>
        public string EAN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_PRE_NFE_ITEM_ID { get; set; }
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
        public int SEQUENCIA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTD { get; set; }
            [StringLength(120)]
        /// <summary>
        /// 
        /// </summary>
        public string DES_ITEM_FORNECEDOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_UNITARIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_CALC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_ICMS_SUBST { get; set; }
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
        public int ALQ_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_OUTROS_IPI { get; set; }
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
        public int VLR_FRETE_RDP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTD_VOLUMES { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
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
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_FRETE_NOTA { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_PRE_NFE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
        
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
        public int BEG_PRD_NCM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_TRIB_ICMS_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BD_CPR_PRE_NFE_ITEM { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\ncursor c1 is\n\nselect n.docstatus\nfrom beg_cpr_pre_nfe n\nwhere n.beg_cpr_pre_nfe_id = :old.beg_cpr_pre_nfe_id;\nr1 c1%rowtype;\nbegin\nopen c1;\n    fetch c1 into r1;\n    close c1;  \n    if r1.docstatus = 'CO' then \n       RAISE_APPLICATION_ERROR(-20001,'Nota ja integrada nao pode excluir itens');\n    end if;   \n\n  update BEG_CPR_PRE_NFE X\n     set VLR_BASE_ICMS_CALC       = ROUND(VLR_BASE_ICMS_CALC -\n                                          NVL(:OLD.VLR_BASE_ICMS_CALC, 0),\n                                          2),\n         VLR_BASE_OUTROS_ICMS     = VLR_BASE_OUTROS_ICMS -\n                                    NVL(:OLD.VLR_BASE_OUTROS_ICMS, 0),\n         VLR_BASE_ICMS_SUBST_CALC = ROUND(VLR_BASE_ICMS_SUBST -\n                                          NVL(:OLD.VLR_BASE_ICMS_SUBST, 0),\n                                          2),\n         VLR_BASE_ISENTO_ICMS     = VLR_BASE_ISENTO_ICMS -\n                                    NVL(:OLD.VLR_BASE_ISENTO_ICMS, 0),\n         VLR_ICMS_CALC            = ROUND(VLR_ICMS_CALC -\n                                          NVL(:OLD.VLR_ICMS_CALC, 0),\n                                          2),\n         VLR_OUTROS_ICMS          = VLR_OUTROS_ICMS -\n                                    NVL(:OLD.VLR_OUTROS_ICMS, 0),\n         VLR_ICMS_SUBST_CALC = case\n                                 when NVL(:OLD.VLR_TOTAL_CALC, 0) <>\n                                      NVL(:NEW.VLR_TOTAL_CALC, 0) and\n                                      IND_NFE_ORDEM = 'Y' then\n                                  0\n                                 else\n                                  VLR_ICMS_SUBST\n                               end,\n         /*ROUND(VLR_ICMS_SUBST_CALC -\n         NVL(:OLD.VLR_ICMS_SUBST_CALC, 0) +\n         NVL(:NEW.VLR_ICMS_SUBST_CALC, 0),\n         2),*/\n         VLR_ICMS_SUBST = case\n                            when NVL(:OLD.VLR_TOTAL_CALC, 0) <>\n                                 NVL(:NEW.VLR_TOTAL_CALC, 0) and\n                                 IND_NFE_ORDEM = 'Y' then\n                             0\n                            else\n                             VLR_ICMS_SUBST\n                          end,\n         VLR_BASE_IPI_CALC   = ROUND(VLR_BASE_IPI_CALC -\n                                     NVL(:OLD.VLR_BASE_IPI_CALC, 0),\n                                     2),\n         VLR_BASE_OUTROS_IPI = VLR_BASE_OUTROS_IPI -\n                               NVL(:OLD.VLR_BASE_OUTROS_IPI, 0),\n         VLR_BASE_ISENTO_IPI = VLR_BASE_ISENTO_IPI -\n                               NVL(:OLD.VLR_BASE_ISENTO_IPI, 0),\n         VLR_IPI_CALC        = ROUND(VLR_IPI_CALC -\n                                     NVL(:OLD.VLR_IPI_CALC, 0),\n                                     2),\n         VLR_BASE_IPI        = VLR_BASE_IPI - NVL(:OLD.VLR_BASE_IPI, 0),\n         /* VLR_IPI = case\n           when NVL(:OLD.VLR_TOTAL_CALC, 0) <>\n                NVL(:NEW.VLR_TOTAL_CALC, 0)\n                and IND_NFE_ORDEM = 'Y' then\n            0\n           else\n            ROUND(VLR_IPI -\n                                NVL(:OLD.VLR_IPI, 0) +\n                                NVL(:NEW.VLR_IPI, 0),\n                                2)\n         end,*/\n         VLR_OUTROS_IPI = VLR_OUTROS_IPI - NVL(:OLD.VLR_OUTROS_IPI, 0),\n         VLR_BASE_ISSQN = VLR_BASE_ISSQN - NVL(:OLD.VLR_BASE_ISSQN, 0),\n         VLR_ISSQN      = VLR_ISSQN - NVL(:OLD.VLR_ISSQN, 0),\n         QTD_VOLUMES    = QTD_VOLUMES - NVL(:NEW.QTD_VOLUMES, 0),\n         --PESO_BRUTO               = PESO_BRUTO - NVL(:OLD.PESO_BRUTO, 0) +\n         --                           NVL(:NEW.PESO_BRUTO, 0),\n         --PESO_LIQUIDO             = PESO_LIQUIDO -\n         --                           NVL(:OLD.PESO_LIQUIDO, 0) +\n         --                           NVL(:NEW.PESO_LIQUIDO, 0),\n         VLR_SEGURO              = VLR_SEGURO - NVL(:OLD.VLR_SEGURO, 0),\n         VLR_TOTAL_PRODUTOS_CALC = ROUND(VLR_TOTAL_PRODUTOS_CALC -\n                                         NVL(:OLD.VLR_TOTAL_CALC, 0),\n                                         2),\n         VLR_TOTAL_NOTA_CALC     = ROUND(VLR_TOTAL_NOTA_CALC -\n                                         NVL(:OLD.VLR_TOTAL_CALC, 0) + NVL(:OLD.VLR_DESCONTO,0) -- Total dos itens\n                                         /*--NVL(:OLD.VLR_DESCONTO,0) + -- VALOR DO DESCONTO\n                                         + NVL(:OLD.VLR_DESPESAS_FINANCEIRAS, 0) + -- Despesas financeiras do item\n                                         NVL(:OLD.VLR_OUTRAS_DESPESAS, 0) + -- Outras despesas do item\n                                         --nvl(:OLD.VLR_ICMS_SUBST_CALC, 0) + -- aok - 26/07/2013\n                                         DECODE(NVL(:OLD.IND_FRETE_NOTA, 'N'),\n                                                 'Y',\n                                                 (NVL(:OLD.VLR_FRETE, 0) +\n                                                 NVL(:OLD.VLR_FRETE_RDP, 0)),\n                                                 0) +\n                                         NVL(:OLD.VL_IMPOSTO_IMPORTACAO, 0) + -- AOK - 05/08/2013\n                                         NVL(:OLD.VLR_DESP_ACES_IMP, 0) -- AOK - 05/08/2013\n                                         )*/,\n                                         2)\n   where BEG_CPR_PRE_NFE_ID = :OLD.BEG_CPR_PRE_NFE_ID;\n\n  --\n\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BI_CPR_PRE_NFE_ITEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que valida o item incluido ou atualizado em uma nota fiscal de entrada.\n  Modulo.......: CPR - Compras\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  04/07/2006  Tiago Gabriel  Criac?o.\n  06/07/2006  Tiago Gabriel  Addicionada validac?o do almoxarifado.\n  12/07/2006  Tiago Gabriel  Adicionada verificac?o para delec?o.\n  31/07/2006  Tiago Gabriel  Adicionada inicializac?o das aliquotas da tabela de precos de\n                             suprimento (fornecedor) para calculo do custo.\n  28/08/2006  Tiago Gabriel  Adicionada verificac?o quando a troca de CFOP de entrada pelo de saida.\n  03/11/2006  Tiago Gabriel  Adicionadas flags referente aos descontos e acrescimos.\n  16/01/2007  Tiago Gabriel  Passou a buscar dados do detalhe do SKU, filtrado por filial.\n  16/10/2008  Guilherme      Liberando teste de fornecedor em NFS de transferencia\n  25/05/2010  Aroldo O. Krul Tratamento dos codigos de tributação de icms\n  16/09/2010  Aroldo O.Krul  Alterado tratamento cod.tributacao icms por funcao\n  22/02/2011  Aroldo O.Krul  Alteracao de cfop determinados por parametrizados em cfopstf ou cfopstd\n  24/02/2011  Aroldo O.Krul  Inserido tratamento para o tipo da nota (beg_tipo_nfe)\n  07/04/2011  Aroldo O.Krul  Passa a não mais zerar os impostos automaticamente - processo tratado na\n                             geracao do arquivo fiscal de notas fiscais\n  11/04/2011  Aroldo O.Krul  Validacao da localizacao do fornecedor com a operacao do cfop\n  27/06/2011  Aroldo O.Krul  Passa a atualizar o id do CST do PIS, COFINS e IPI\n  26/07/2011  Aroldo O.Krul  Correcao de valore de bases ST informada e calculada - via pseudo mva\n                             Inserido na descricao do fornecedor a expressao ref. xxxxxxxxx\n  08/08/2011  Aroldo O.Krul  Novo tratamento de almox a partir de parametros sku detalhe ou informacao\n  12/08/2011  Aroldo O.Krul  Tratamento de % ou Valor para icms ou ipi outros\n  06/09/2011  Aroldo O.Krul  Apenas processar a troca automatica cfop qdo nao for devolucao\n  08/09/2011  Aroldo O.Krul  Verifica e busca possivel excecao do cfop x ncm x cst\n                             retirado a busca dos CSTs do cursor c_cfop\n  08/11/2011  Aroldo O.Krul  Novo parametro (CFOP) para a funcao beg_fnc_gera_cod_sit_trib\n  05/02/2013  Aroldo O.Krul  Quando nf de importacao não valida impostos\n  21/02/2013  Aroldo O.Krul  Se emitida pelo faturamento, aceita valore total calculado item\n  02/05/2013  Aroldo O.Krul  Aproveitamento da variavel IND_IMPORTACAO\n  29/05/2013  Aroldo O.Krul  Atualiza a capa da nota com o cfop do primeiro item quando este for nulo\n  26/07/2013  Aroldo O.Krul  Tratamento do vlr icms subbt tributaria no total da nota\n  05/08/2013  Aroldo O.Krul  Quando nota importacao e possui icms somar ao total da nota\n  05/09/2013  Aroldo O.Krul  Não gerar inicializacao de impostos quando nf gerada faturamento\n  --------------------------------------------------------------------------------------------------- */\n  VC_MSG_ERRO                varchar2(200);\n  VN_DUMMY                   number;\n  VN_AUX_ALQ                 number(18, 4);\n  VN_AUX_BASE                number(18, 4);\n  VN_AUX_CALC                number(18, 4);\n  VN_VLR_RATEADO             number(18, 4);\n  VC_DOCSTATUS               BEG_CPR_NFE.DOCSTATUS%type;\n  VN_BEG_VW_FORNECEDOR_ID    BEG_CPR_NFE.BEG_VW_FORNECEDOR_ID%type;\n  VN_BEG_EST_ALMOXARIFADO_ID BEG_EST_ALMOXARIFADO.BEG_EST_ALMOXARIFADO_ID%type;\n  VN_BEG_CPR_ORDEM_ITEM_ID   BEG_CPR_ORDEM_ITEM.BEG_CPR_ORDEM_ITEM_ID%type;\n  --vn_beg_prd_ncm_id          beg_prd_ncm.beg_prd_ncm_id%type; -- aok - 19/07/2013\n  VN_QTD_SALDO           BEG_CPR_ORDEM_ITEM.QTD_SALDO%type;\n  VC_VALUE_PRODUTO       BEG_PRODUTO.VALUE%type;\n  VC_DESC_DETALHADA      BEG_PRODUTO.DESC_DETALHADA%type;\n  VC_IND_FATURAMENTO     BEG_CPR_NFE.IND_EMITIDA_FATURAMENTO%type; -- aok - 21/02/2013\n  VC_IND_GERADA_XML      BEG_CPR_NFE.IND_GERADA_XML%type; -- aok - 19/07/2013\n  VC_IND_ICMS_TOTAL_NOTA BEG_CPR_NFE.IND_ICMS_TOTAL_NOTA%type; -- aok - 05/08/2013\n  V_VALIDA               varchar2(1);\n  VN_BEG_TIPO_NF_ID      BEG_TIPO_NF.BEG_TIPO_NF_ID%type := null; -- aok - 24/02/2011\n  VN_PERC_MVA            BEG_PRD_NCM_UF.PERC_MVAO%type; -- aok - 26/07/2011\n  VN_VLR_FRETE_NFE       BEG_CPR_NFE.VLR_FRETE%type;\n  --\n  VN_TESTE NUMBER(18, 4);\n  --vc_ind_importacao          beg_tipo_nf.ind_importacao%type := 'N'; -- aok - 02/05/2013\n  --\n  cursor BUSCA_TIPO_NF is\n    select T.IND_VAL_LISTA_FORN,\n           SUBSTR(T.VALUE, 1, 3) DESC_RESUMIDA,\n           T.IND_IMPORTACAO -- aok - 02/05/2013\n      from BEG_TIPO_NF T\n     where T.BEG_TIPO_NF_ID = :NEW.BEG_TIPO_NF_ID;\n  --\n  V_TIPO_NF BUSCA_TIPO_NF%rowtype;\n  --\n  cursor C_CFOP is\n    select NVL(:NEW.BEG_VW_CFOP_SAI_ID, A.BEG_VW_CFOP_SAI_ID),\n           NVL(:NEW.BEG_VW_CFOP_ENT_ID, A.BEG_VW_CFOP_ENT_ID),\n           A.IND_PADRAO,\n           --A.IND_SOMA_ST, -- aok - 22/02/2011\n           B.TP_OPERACAO -- aok - 22/02/2011\n      from BEG_CFOP_ENT_SAI A, BEG_CFOP B\n     where A.BEG_VW_CFOP_ENT_ID =\n           NVL(:NEW.BEG_VW_CFOP_ENT_ID, A.BEG_VW_CFOP_ENT_ID)\n       and A.BEG_VW_CFOP_SAI_ID =\n           NVL(:NEW.BEG_VW_CFOP_SAI_ID, A.BEG_VW_CFOP_SAI_ID)\n       and A.ISACTIVE = 'Y'\n       and B.BEG_CFOP_ID = NVL(A.BEG_VW_CFOP_ENT_ID, A.BEG_VW_CFOP_SAI_ID)\n     order by 3 desc;\n  -- aok - 08/09/2011 ------------------------------------------------\n  cursor CCFOCST is\n    select B.CFOP, -- aok - 11/08/2011\n           NVL(:NEW.BEG_FIS_CST_PIS_ID,\n               NVL(C.BEG_FIS_CST_PIS_ID, B.BEG_FIS_CST_PIS_ID)) BEG_FIS_CST_PIS_ID,\n           NVL(:NEW.BEG_FIS_CST_COFINS_ID,\n               NVL(C.BEG_FIS_CST_COFINS_ID, B.BEG_FIS_CST_COFINS_ID)) BEG_FIS_CST_COFINS_ID,\n           NVL(:NEW.BEG_FIS_CST_IPI_ID,\n               NVL(C.BEG_FIS_CST_IPI_ID, B.BEG_FIS_CST_IPI_ID)) BEG_FIS_CST_IPI_ID\n      from BEG_CFOP B, BEG_FIS_CFOP_NCM_CST C\n     where B.BEG_CFOP_ID = :NEW.BEG_VW_CFOP_ENT_ID\n       and C.BEG_CFOP_ID(+) = B.BEG_CFOP_ID\n       and C.BEG_PRD_NCM_ID(+) = :NEW.BEG_PRD_NCM_ID\n       and C.ISACTIVE(+) = 'Y';\n  RCFOCST CCFOCST%rowtype;\n\n  -- aok - 08/08/2011 - Busca o almox padrao do item -----------------\n  cursor CALMOX(PBEG_PRODUTO_ID number, PBEG_PRD_SKU_ID number) is\n    select SKD.BEG_EST_ALMOXARIFADO_ID\n      from BEG_PRD_SKU_DETALHE SKD\n     where SKD.AD_CLIENT_ID = :NEW.AD_CLIENT_ID\n       and SKD.AD_ORG_ID = :NEW.AD_ORG_ID\n       and SKD.BEG_PRODUTO_ID = PBEG_PRODUTO_ID\n       and SKD.BEG_PRD_SKU_ID = PBEG_PRD_SKU_ID\n       and SKD.ISACTIVE = 'Y';\n  RALMOX CALMOX%rowtype;\n  --------------------------------------------------------------------\n\n  -- Variaveis para o processamento\n  VN_IND_PADRAO    varchar2(1);\n  VN_IND_SOMA_ST   varchar2(1) := 'N'; -- aok - 21/02/2011\n  VC_TP_OPERACAO   BEG_CFOP.TP_OPERACAO%type; -- aok - 22/02/2011\n  VC_SITUACAO_TRIB BEG_FIS_TRIB_ICMS.REDUCAO%type := null; -- aok - 24/02/2011\n\n  --    AOK - 26/07/2011 - Busca ref. do fornecedor\n  cursor CREF is\n    select X.DES_REFERENCIA\n      from BEG_SUP_LISTA_FORNECEDOR X\n     where X.BEG_VW_FORNECEDOR_ID = VN_BEG_VW_FORNECEDOR_ID\n       and X.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID\n       and X.BEG_PRD_SKU_ID = :NEW.BEG_PRD_SKU_ID\n       and X.ISACTIVE = 'Y';\n  --\n  cursor busca_item_ordem is\n    select o.VLR_UNITARIO\n         , o.ALQ_ICMS_SUBST\n         , o.QTD_SALDO\n         , p.name\n    from   beg_cpr_ordem_item o\n         , beg_produto p\n    where  o.beg_produto_id   = p.beg_produto_id\n    and    o.beg_cpr_ordem_id = :new.beg_cpr_ordem_id\n    and    o.beg_produto_id   = :new.beg_produto_id\n    and    o.beg_prd_sku_id   = :new.beg_prd_sku_id;\n  --\n  v_item_ordem busca_item_ordem%rowtype;\n  --\nbegin\n  --\n  \n  --\n  IF NVL(:NEW.BEG_CPR_ORDEM_ID,0) > 0 THEN\n    --\n    open busca_item_ordem;\n    fetch busca_item_ordem into v_item_ordem\n                              ;\n    close busca_item_ordem;\n    --\n    IF NVL(:NEW.QTD,0) > v_item_ordem.QTD_SALDO THEN\n      --\n      RAISE_APPLICATION_ERROR(-20001,'Ordem de Compra com '||v_item_ordem.QTD_SALDO||' e itens da nota com a quantidade de '||NVL(:NEW.QTD,0)||' '||v_item_ordem.name );\n      --\n   /* ELSIF NVL(:NEW.VLR_UNITARIO,0) <> NVL(v_item_ordem.VLR_UNITARIO,0) THEN\n      --\n      RAISE_APPLICATION_ERROR(-20001,'Valor unitario do Item difere do valor unitario da Ordem de Compra!');\n      --*/\n    END IF;\n    --\n    :NEW.VLR_ITEM_ORDEM_COMPRA := v_item_ordem.VLR_UNITARIO;\n    :NEW.PERC_ST_OC            := v_item_ordem.ALQ_ICMS_SUBST;\n    :NEW.QTD_ORDEM             := v_item_ordem.QTD_SALDO;\n    --\n  END IF;\n  --\n  -- Verifica se o item esta inativo\n  if :NEW.ISACTIVE = 'N' then\n    goto FIM;\n  end if;\n  -- aok - 28/02/2011\n  if BEG_PCK_CPR_COMPRAS.VB_PROC_ACERTO_ESPECIAL then\n    goto FIM;\n  end if;\n\n  -- Valida o status da nota (capa)\n    if not BEG_PCK_CPR_COMPRAS.VB_PROC_NFE then\n    --\n    select DOCSTATUS,\n           BEG_VW_FORNECEDOR_ID,\n           BEG_TIPO_NF_ID, -- aok - 24/02/2011\n           IND_EMITIDA_FATURAMENTO, -- aok - 21/02/2013\n           IND_GERADA_XML, -- aok - 19/07/2013\n           IND_ICMS_TOTAL_NOTA -- aok - 05/08/2013\n      into VC_DOCSTATUS,\n           VN_BEG_VW_FORNECEDOR_ID,\n           VN_BEG_TIPO_NF_ID, -- aok - 24/02/2011\n           VC_IND_FATURAMENTO, -- aok - 21/02/2013\n           VC_IND_GERADA_XML, -- aok - 31/05/2013\n           VC_IND_ICMS_TOTAL_NOTA -- aok - 05/08/2013\n      from BEG_CPR_PRE_NFE\n     where BEG_CPR_PRE_NFE_ID = NVL(:NEW.BEG_CPR_pre_NFE_ID, :OLD.BEG_CPR_pre_NFE_ID);\n\n  /*  if VC_DOCSTATUS <> 'WC' then\n      VC_MSG_ERRO := 'Somente e possivel alterar notas ainda n?o processadas!';\n      goto FIM;\n    end if;*/\n  else\n    VC_IND_FATURAMENTO     := BEG_PCK_CPR_COMPRAS.VC_IND_FATURAMENTO; -- aok - 22/02/2013\n    VC_IND_ICMS_TOTAL_NOTA := BEG_PCK_CPR_COMPRAS.VC_IND_ICMS_TOTAL_NOTA; -- aok - 08/05/2013\n  end if;\n\n  if not DELETING then\n    if NVL(:NEW.BEG_TIPO_NF_ID, 0) = 0 -- aok - 24/02/2011\n     then\n      :NEW.BEG_TIPO_NF_ID := VN_BEG_TIPO_NF_ID;\n    end if;\n  end if;\n  --\n  if :NEW.ALQ_ICMS_SUBST <> :OLD.ALQ_ICMS_SUBST then\n    :NEW.VLR_BASE_ICMS_SUBST := 0;\n    :NEW.VLR_ICMS_SUBST      := 0;\n  end if;\n  ----\n\n  -- Se esta deletando, remove os historicos do item e atualiza os valores na nota\n  if DELETING then\n    -- Historico da movimntac?o pela ordem de compra\n    delete from BEG_CPR_HISTORICO_ITEM\n     where BEG_CPR_NFE_ITEM_ID = :OLD.BEG_CPR_PRE_NFE_ITEM_ID;\n\n    if not BEG_PCK_CPR_COMPRAS.VB_PROC_NFE then\n\n      BEG_PCK_CPR_COMPRAS.VB_PROC_NFE_IT := true;\n\n      update BEG_CPR_pre_NFE\n         set VLR_BASE_ICMS_CALC       = ROUND(VLR_BASE_ICMS_CALC -\n                                              :OLD.VLR_BASE_ICMS_CALC,\n                                              2),\n             VLR_BASE_OUTROS_ICMS     = VLR_BASE_OUTROS_ICMS -\n                                        :OLD.VLR_BASE_OUTROS_ICMS,\n             VLR_BASE_ICMS_SUBST_CALC = ROUND(VLR_BASE_ICMS_SUBST_CALC -\n                                              :OLD.VLR_BASE_ICMS_SUBST_CALC,\n                                              2),\n             VLR_BASE_ISENTO_ICMS     = VLR_BASE_ISENTO_ICMS -\n                                        :OLD.VLR_BASE_ISENTO_ICMS,\n             VLR_ICMS_CALC            = ROUND(VLR_ICMS_CALC -\n                                              :OLD.VLR_ICMS_CALC,\n                                              2),\n             VLR_OUTROS_ICMS          = VLR_OUTROS_ICMS -\n                                        :OLD.VLR_OUTROS_ICMS,\n             VLR_ICMS_SUBST_CALC      = ROUND(VLR_ICMS_SUBST_CALC -\n                                              :OLD.VLR_ICMS_SUBST_CALC,\n                                              2),\n             VLR_BASE_IPI_CALC        = ROUND(VLR_BASE_IPI_CALC -\n                                              :OLD.VLR_BASE_IPI_CALC,\n                                              2),\n             VLR_BASE_OUTROS_IPI      = VLR_BASE_OUTROS_IPI -\n                                        :OLD.VLR_BASE_OUTROS_IPI,\n             VLR_BASE_ISENTO_IPI      = VLR_BASE_ISENTO_IPI -\n                                        :OLD.VLR_BASE_ISENTO_IPI,\n             VLR_IPI_CALC             = ROUND(VLR_IPI_CALC -\n                                              :OLD.VLR_IPI_CALC,\n                                              2),\n             VLR_OUTROS_IPI           = VLR_OUTROS_IPI - :OLD.VLR_OUTROS_IPI,\n             VLR_BASE_ISSQN           = VLR_BASE_ISSQN - :OLD.VLR_BASE_ISSQN,\n             VLR_ISSQN                = VLR_ISSQN - :OLD.VLR_ISSQN,\n             QTD_VOLUMES              = QTD_VOLUMES - :OLD.QTD_VOLUMES,\n             PESO_BRUTO               = PESO_BRUTO - :OLD.PESO_BRUTO,\n             PESO_LIQUIDO             = PESO_LIQUIDO - :OLD.PESO_LIQUIDO,\n             VLR_SEGURO               = VLR_SEGURO - :OLD.VLR_SEGURO,\n             VLR_TOTAL_PRODUTOS_CALC  = ROUND(VLR_TOTAL_PRODUTOS_CALC -\n                                              :OLD.VLR_TOTAL_CALC,\n                                              2),\n             VLR_TOTAL_NOTA_CALC      = ROUND(VLR_TOTAL_NOTA_CALC -\n                                              (:OLD.VLR_TOTAL_CALC +\n                                              :OLD.VLR_DESPESAS_FINANCEIRAS +\n                                              :OLD.VLR_OUTRAS_DESPESAS +\n                                              --:OLD.VLR_ICMS_SUBST_CALC + -- aok - 26/07/2013\n                                              DECODE(:OLD.IND_FRETE_NOTA,\n                                                      'Y',\n                                                      (:OLD.VLR_FRETE +\n                                                      :OLD.VLR_FRETE_RDP),\n                                                      0)),\n                                              2)\n       where BEG_CPR_pre_NFE_ID = :OLD.BEG_CPR_pre_NFE_ID;\n\n      BEG_PCK_CPR_COMPRAS.VB_PROC_NFE_IT := false;\n\n    end if;\n\n    goto FIM;\n\n  end if;\n  --\n  open BUSCA_TIPO_NF;\n  fetch BUSCA_TIPO_NF\n    into V_TIPO_NF;\n  if BUSCA_TIPO_NF%notfound then\n    -- V_TIPO_NF.IND_VAL_LISTA_FORN := 'Y'; -- aok - 02/06/2011\n    V_TIPO_NF.IND_VAL_LISTA_FORN := BEG_FNC_RETORNA_PARAM_GERAL('Compras',\n                                                                'Produto',\n                                                                'CONSISTE_PRODUTO_FORNECEDOR');\n  end if;\n  close BUSCA_TIPO_NF;\n  -- Se trocou o produto, valida novamente\n  if (NVL(:NEW.BEG_PRODUTO_ID, 0) <> NVL(:OLD.BEG_PRODUTO_ID, 0) or\n     NVL(:NEW.BEG_PRD_SKU_ID, 0) <> NVL(:OLD.BEG_PRD_SKU_ID, 0))\n  --and NVL(V_TIPO_NF.IND_VAL_LISTA_FORN, 'Y') = 'Y'   -- aok - 02/06/2011\n   then\n    -- Valida produto vs. fornecedor\n    -- if BEG_FNC_RETORNA_PARAM_GERAL('Compras',  -- AOK - 02/06/2011\n    --                                'Produto',\n    --                                'CONSISTE_PRODUTO_FORNECEDOR') = 'Y' then\n    /*    if NVL(V_TIPO_NF.IND_VAL_LISTA_FORN, 'Y') = 'Y' then\n      VN_DUMMY := 0;\n      for R_FRN in (select BEG_VW_FORNECEDOR_ID,\n                           'S' FORNEC\n                      from BEG_VW_SUP_FORNECEDOR\n                     where BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID\n                    union all\n                    select D.BEG_PESSOA_ID,\n                           'N'\n                      from BEG_DADO_FILIAL D)\n      loop\n        if R_FRN.BEG_VW_FORNECEDOR_ID = VN_BEG_VW_FORNECEDOR_ID then\n          VN_DUMMY := 0;\n          V_VALIDA := R_FRN.FORNEC;\n          exit;\n        else\n          VN_DUMMY := VN_DUMMY + 1;\n        end if;\n      end loop;\n\n      if VN_DUMMY > 0 then\n        select 'Produto <' || value || ' - ' || DESC_RESUMIDA ||\n               '> nao pertence ao fornecedor da nota!'\n          into VC_MSG_ERRO\n          from BEG_PRODUTO\n         where BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n        goto FIM;\n      end if;\n    end if;*/\n\n    begin\n      select value, DESC_DETALHADA\n        into VC_VALUE_PRODUTO, VC_DESC_DETALHADA\n        from BEG_PRODUTO\n       where BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n\n    exception\n      when NO_DATA_FOUND then\n        VC_MSG_ERRO := 'Produto nao encontrado!';\n        goto FIM;\n\n    end;\n    -- Atualiza campos n?o digitados\n    begin\n      if NVL(VC_IND_GERADA_XML, 'N') = 'Y' -- aok - 07/01/2014\n       then\n        select PRD.DESC_RESUMIDA,\n               SKU.BEG_PRD_SKU_ID,\n               PRD_CTB.BEG_FIS_ORIGEM_MERC_ID\n          into :NEW.DES_ITEM_FORNECEDOR,\n               :NEW.BEG_PRD_SKU_ID,\n               :NEW.BEG_FIS_ORIGEM_MERC_ID\n          from BEG_PRODUTO PRD, BEG_PRD_SKU SKU, BEG_PRD_CONTABIL PRD_CTB\n         where PRD.BEG_PRODUTO_ID = SKU.BEG_PRODUTO_ID\n           and PRD.BEG_PRODUTO_ID = PRD_CTB.BEG_PRODUTO_ID\n           and PRD.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID\n           and SKU.PADRAO = 'Y';\n      else\n        select PRD.DESC_RESUMIDA,\n               SKU.BEG_PRD_SKU_ID,\n               PRD_CTB.BEG_FIS_ORIGEM_MERC_ID,\n               PRD_CTB.BEG_PRD_NCM_ID\n          into :NEW.DES_ITEM_FORNECEDOR,\n               :NEW.BEG_PRD_SKU_ID,\n               :NEW.BEG_FIS_ORIGEM_MERC_ID,\n               :NEW.BEG_PRD_NCM_ID\n          from BEG_PRODUTO PRD, BEG_PRD_SKU SKU, BEG_PRD_CONTABIL PRD_CTB\n         where PRD.BEG_PRODUTO_ID = SKU.BEG_PRODUTO_ID\n           and PRD.BEG_PRODUTO_ID = PRD_CTB.BEG_PRODUTO_ID\n           and PRD.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID\n           and SKU.PADRAO = 'Y';\n      end if;\n    exception\n      when NO_DATA_FOUND then\n       /* VC_MSG_ERRO := 'Produto <' || VC_VALUE_PRODUTO || ' - ' ||\n                       VC_DESC_DETALHADA ||\n                       '> sem SKU padr?o ou informac?o contabil!';\n        dbms_output.put_line(VC_VALUE_PRODUTO||' - '||VC_DESC_DETALHADA);*/\n        goto FIM;\n\n      when TOO_MANY_ROWS then\n        /*VC_MSG_ERRO := 'Produto <' || VC_VALUE_PRODUTO || ' - ' ||\n                       VC_DESC_DETALHADA ||\n                       '> com SKU padr?o ou informac?o contabil duplicadas!';*/\n        goto FIM;\n\n    end;\n\n    -- AOK - 26/07/2011 ----------------------------------------------------------------------------\n  /*  if NVL(V_TIPO_NF.IND_VAL_LISTA_FORN, 'Y') = 'Y' then\n      open CREF;\n      fetch CREF\n        into :NEW.DES_REFERENCIA;\n      close CREF;\n    end if;*/\n    --------------------------------------------------------------------------------------------------\n\n    -- Verifica se restaram campos obrigatorios em branco\n    if NVL(:NEW.BEG_PRD_SKU_ID, 0) = 0 then\n      VC_MSG_ERRO := 'SKU deve ser informado!';\n      goto FIM;\n    end if;\n\n    -- AOK - 08/08/2011 - busca padrao almox no sku detalhe\n    if NVL(:NEW.BEG_EST_ALMOXARIFADO_ID, 0) = 0 then\n      open CALMOX(:NEW.BEG_PRODUTO_ID, :NEW.BEG_PRD_SKU_ID);\n      fetch CALMOX\n        into RALMOX;\n      close CALMOX;\n      :NEW.BEG_EST_ALMOXARIFADO_ID := RALMOX.BEG_EST_ALMOXARIFADO_ID;\n    end if;\n    ------------------------------------------------------------------\n    -- Inicializa os valores de impostos (se não for gerada pelo faturamento)\n /*   if NVL(VC_IND_FATURAMENTO, 'N') = 'N' -- aok - 05/09/2013\n     then\n      begin\n        -- DBMS_OUTPUT.PUT_LINE(VN_BEG_VW_FORNECEDOR_ID || ' ' ||\n        --                      :NEW.BEG_PRODUTO_ID || ' ' ||\n        --                      :NEW.BEG_PRD_SKU_ID);\n        select DECODE(NVL(:NEW.ALQ_ICMS, 0), 0, P.ALQ_ICMS, :NEW.ALQ_ICMS),\n               DECODE(NVL(:NEW.ALQ_ICMS_SUBST, 0),\n                      0,\n                      P.ALQ_ICMS_SUBST,\n                      :NEW.ALQ_ICMS_SUBST),\n               DECODE(NVL(:NEW.VLR_ICMS_SUBST_CALC, 0),\n                      0,\n                      P.VLR_ICMS_SUBST,\n                      :NEW.VLR_ICMS_SUBST_CALC),\n               DECODE(NVL(:NEW.ALQ_IPI, 0), 0, P.ALQ_IPI, :NEW.ALQ_IPI),\n               DECODE(NVL(:NEW.VLR_UNITARIO, 0),\n                      0,\n                      P.VLR_LIQUIDO,\n                      :NEW.VLR_UNITARIO)\n          into :NEW.ALQ_ICMS,\n               :NEW.ALQ_ICMS_SUBST,\n               :NEW.VLR_ICMS_SUBST_CALC,\n               :NEW.ALQ_IPI,\n               :NEW.VLR_UNITARIO\n          from BEG_VW_SUP_PRODUTO P\n         where P.AD_ORG_ID =\n               (select max(AD_ORG_ID)\n                  from BEG_VW_SUP_PRODUTO PP, BEG_GER_FILIAL F\n                 where PP.AD_CLIENT_ID = F.AD_CLIENT_ID\n                   and PP.BEG_PRD_SKU_ID = P.BEG_PRD_SKU_ID\n                   and PP.AD_ORG_ID in (F.AD_ORG_ID_GERAL, :NEW.AD_ORG_ID))\n           and P.ISACTIVE_PRD = 'Y'\n           and P.ISACTIVE_FRN = 'Y'\n           and P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID\n           and P.BEG_PRD_SKU_ID = :NEW.BEG_PRD_SKU_ID\n           and P.BEG_VW_FORNECEDOR_ID = VN_BEG_VW_FORNECEDOR_ID;\n\n      exception\n        when NO_DATA_FOUND then\n          null;\n      end;\n    end if; -- aok - 05/09/2013*/\n\n  end if;\n\n  -- Quantidade\n  if NVL(:NEW.QTD, 0) <= 0 then\n    VC_MSG_ERRO := 'Quantidade zerada ou negativa!';\n    goto FIM;\n  end if;\n\n  -- AOK - 11/04/2011 - valida cfop com fornecedor\n  -- aok - 18/04/2011 - Desativado, pois problema ao validar informacoes de frete.\n  /*  if not BEG_FNC_VALIDA_UF_CFOP(:NEW.AD_ORG_ID,\n                                VN_BEG_VW_FORNECEDOR_ID,\n                                NVL(:NEW.BEG_VW_CFOP_SAI_ID,\n                                    :NEW.BEG_VW_CFOP_ENT_ID)) then\n    VC_MSG_ERRO := 'CFOP não corresponde ao estado do fornecedor!';\n    goto FIM;\n  end if;*/\n\n  --\n  -- AOK - 22/02/2011 - Verifica procedimento especial para ST e troca de CFOP automatica\n  if V_TIPO_NF.DESC_RESUMIDA <> 'DEV' then\n    if VN_IND_SOMA_ST = 'Y' then\n      --if :NEW.ALQ_ICMS_SUBST > 0 then\n      VC_SITUACAO_TRIB := BEG_FNC_MATRIZ_TRIB_UF(:NEW.BEG_PRODUTO_ID,\n                                                 1000023); -- sc\n      if VC_SITUACAO_TRIB = 'ST' then\n        if VC_TP_OPERACAO = 'F' then\n          -- Fora estado / Interestadual\n          :NEW.BEG_VW_CFOP_ENT_ID := BEG_FNC_RETORNA_PARAM_GERAL('Compras',\n                                                                 null,\n                                                                 'CFOPSTF'); -- cfop - 255/2403\n        else\n          :NEW.BEG_VW_CFOP_ENT_ID := BEG_FNC_RETORNA_PARAM_GERAL('Compras',\n                                                                 null,\n                                                                 'CFOPSTD'); -- cfop - 146/1403\n        end if;\n        -- :NEW.ALQ_ICMS       := 0;  -- AOK - 07/04/2011\n        -- :NEW.ALQ_ICMS_SUBST := 0;  -- AOK - 07/04/2011\n      end if;\n    end if;\n  end if;\n\n  -- aok - 08/09/0211 - Busca os cst para pis , cofins e ipi--------------------\n  open CCFOCST;\n  fetch CCFOCST\n    into RCFOCST;\n  close CCFOCST;\n  :NEW.BEG_FIS_CST_PIS_ID    := RCFOCST.BEG_FIS_CST_PIS_ID;\n  :NEW.BEG_FIS_CST_COFINS_ID := RCFOCST.BEG_FIS_CST_COFINS_ID;\n  :NEW.BEG_FIS_CST_IPI_ID    := RCFOCST.BEG_FIS_CST_IPI_ID;\n\n  -- Se existe historico do item, valida a quantidade\n  if NVL(:OLD.QTD, 0) <> NVL(:NEW.QTD, 0) or\n     NVL(:OLD.beg_cpr_ordem_id, 0) <> NVL(:NEW.beg_cpr_ordem_id, 0) then\n    if NVL(:OLD.QTD, 0) <> NVL(:NEW.QTD, 0) then\n      begin\n        select ORD_IT.BEG_CPR_ORDEM_ITEM_ID,\n               ORD_IT.QTD_SALDO,\n               ord_it.vlr_unitario\n          into VN_BEG_CPR_ORDEM_ITEM_ID,\n               VN_QTD_SALDO,\n               :new.vlr_item_ordem_compra\n          from BEG_CPR_ORDEM_ITEM ORD_IT, BEG_CPR_HISTORICO_ITEM HIST_IT\n         where ORD_IT.BEG_CPR_ORDEM_ITEM_ID = HIST_IT.BEG_CPR_ORDEM_ITEM_ID\n           and HIST_IT.BEG_CPR_NFE_ITEM_ID = :NEW.BEG_CPR_PRE_NFE_ITEM_ID;\n\n        if :NEW.QTD > VN_QTD_SALDO + NVL(:OLD.QTD, 0) then\n          VC_MSG_ERRO := 'Quantidade maior que o saldo do item na ordem (' ||\n                         TO_CHAR(VN_QTD_SALDO) || ')!' || :new.qtd || ' - ' ||\n                         :old.qtd;\n          goto FIM;\n        end if;\n\n        /*          update BEG_CPR_ORDEM_ITEM\n                     set QTD_ATENDIDA = QTD_ATENDIDA - NVL(:OLD.QTD, 0) + :NEW.QTD\n                   where BEG_CPR_ORDEM_ITEM_ID = VN_BEG_CPR_ORDEM_ITEM_ID;\n\n        */\n      exception\n        when NO_DATA_FOUND then\n          null;\n      end;\n    else\n      --       raise_application_error(-20501,'erro atualizando o/c');\n      begin\n        select ORD_IT.BEG_CPR_ORDEM_ITEM_ID,\n               ORD_IT.QTD_SALDO,\n               ord_it.vlr_unitario\n          into VN_BEG_CPR_ORDEM_ITEM_ID,\n               VN_QTD_SALDO,\n               :new.vlr_item_ordem_compra\n          from BEG_CPR_ORDEM_ITEM ORD_IT, BEG_CPR_HISTORICO_ITEM HIST_IT\n         where ORD_IT.BEG_CPR_ORDEM_ITEM_ID = HIST_IT.BEG_CPR_ORDEM_ITEM_ID\n           and HIST_IT.BEG_CPR_NFE_ITEM_ID = :NEW.BEG_CPR_PRE_NFE_ITEM_ID;\n\n        if :NEW.QTD > VN_QTD_SALDO then\n          VC_MSG_ERRO := 'Quantidade maior que o saldo do item na ordem (' ||\n                         TO_CHAR(VN_QTD_SALDO) || ')!';\n          goto FIM;\n        end if;\n\n        /*          update BEG_CPR_ORDEM_ITEM\n                     set QTD_ATENDIDA = QTD_ATENDIDA - :NEW.QTD\n                   where BEG_CPR_ORDEM_ITEM_ID = VN_BEG_CPR_ORDEM_ITEM_ID;\n\n        */\n      exception\n        when NO_DATA_FOUND then\n          null;\n      end;\n    end if;\n  end if;\n\n /* -- Valor unitario\n  if NVL(:NEW.VLR_UNITARIO, 0) <= 0 then\n    VC_MSG_ERRO := 'Valor unitario zerado ou negativo!';\n    goto FIM;\n  end if;*/\n\n  if NVL(:NEW.BEG_FIS_ORIGEM_MERC_ID, 0) = 0 then\n    VC_MSG_ERRO := 'Origem da mercadoria deve ser informada!';\n    goto FIM;\n  end if;\n\n  -- aok - 21/02/2013 ----------------------------------------------------------\n  -- if NVL(VC_IND_FATURAMENTO, 'N') = 'N' then  -- aok - 02/05/2013\n  if NVL(V_TIPO_NF.IND_IMPORTACAO, 'N') = 'N' -- aok - 02/05/2013\n   then\n     NULL;\n    :NEW.VLR_TOTAL_CALC := ROUND(:NEW.QTD * :NEW.VLR_UNITARIO, 2);\n  else\n    :NEW.VLR_TOTAL_CALC := :NEW.VLR_TOTAL;\n  end if;\n  dbms_output.put_line('BEG_TRG_BIUD_CPR_NFE_ITEM');\n  dbms_output.put_line('L590: ' || :new.des_referencia || ' ' ||\n                       :NEW.VLR_TOTAL_CALC);\n  --:NEW.VLR_TOTAL_CALC := ROUND(:NEW.QTD * :NEW.VLR_UNITARIO, 2);\n  ------------------------------------------------------------------------------\n\n  -- Desconto\n  if (NVL(:OLD.VLR_UNITARIO, 0) <> NVL(:NEW.VLR_UNITARIO, 0) or\n     NVL(:OLD.PER_DESCONTO, 0) <> NVL(:NEW.PER_DESCONTO, 0) or\n     NVL(:OLD.VLR_DESCONTO, 0) <> NVL(:NEW.VLR_DESCONTO, 0)) and\n     (NVL(:NEW.PER_DESCONTO, 0) > 0 or NVL(:NEW.VLR_DESCONTO, 0) > 0) then\n\n    if NVL(:NEW.VLR_TOTAL, 0) = 0 and NVL(:NEW.VLR_TOTAL_CALC, 0) = 0 then\n\n      if NVL(:NEW.VLR_DESCONTO, 0) > 0 then\n        :NEW.PER_DESCONTO := 0;\n      end if;\n\n    else\n\n      if :NEW.VLR_TOTAL = 0 then\n        VN_AUX_BASE := :NEW.VLR_TOTAL_CALC;\n      else\n        VN_AUX_BASE := :NEW.VLR_TOTAL;\n      end if;\n\n      if NVL(:OLD.PER_DESCONTO, 0) <> NVL(:NEW.PER_DESCONTO, 0) or\n         NVL(:NEW.VLR_DESCONTO, 0) = 0 then\n        VN_AUX_ALQ  := :NEW.PER_DESCONTO;\n        VN_AUX_CALC := 0;\n      else\n        VN_AUX_ALQ  := 0;\n        VN_AUX_CALC := :NEW.VLR_DESCONTO;\n      end if;\n\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                             VN_AUX_BASE,\n                                             VN_AUX_CALC);\n\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do desconto!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do desconto!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de desconto diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :NEW.PER_DESCONTO := VN_AUX_ALQ;\n        :NEW.VLR_DESCONTO := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  -- Acrescimo\n  if (NVL(:OLD.VLR_TOTAL, 0) <> NVL(:NEW.VLR_TOTAL, 0) or\n     NVL(:OLD.VLR_TOTAL_CALC, 0) <> NVL(:NEW.VLR_TOTAL_CALC, 0) or\n     NVL(:OLD.PER_ACRESCIMO, 0) <> NVL(:NEW.PER_ACRESCIMO, 0) or\n     NVL(:OLD.VLR_ACRESCIMO, 0) <> NVL(:NEW.VLR_ACRESCIMO, 0)) and\n     (NVL(:NEW.PER_ACRESCIMO, 0) > 0 or NVL(:NEW.VLR_ACRESCIMO, 0) > 0) then\n\n    if NVL(:NEW.VLR_TOTAL, 0) = 0 and NVL(:NEW.VLR_TOTAL_CALC, 0) = 0 then\n\n      if NVL(:NEW.VLR_ACRESCIMO, 0) > 0 then\n        :NEW.PER_ACRESCIMO := 0;\n      end if;\n\n    else\n\n      if :NEW.VLR_TOTAL = 0 then\n        VN_AUX_BASE := :NEW.VLR_TOTAL_CALC;\n      else\n        VN_AUX_BASE := :NEW.VLR_TOTAL;\n      end if;\n\n      if NVL(:OLD.PER_ACRESCIMO, 0) <> NVL(:NEW.PER_ACRESCIMO, 0) or\n         NVL(:NEW.VLR_ACRESCIMO, 0) = 0 then\n        VN_AUX_ALQ  := :NEW.PER_ACRESCIMO;\n        VN_AUX_CALC := 0;\n      else\n        VN_AUX_ALQ  := 0;\n        VN_AUX_CALC := :NEW.VLR_ACRESCIMO;\n      end if;\n\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                             VN_AUX_BASE,\n                                             VN_AUX_CALC);\n\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do acrescimo!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do acrescimo!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de acrescimo diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :NEW.PER_ACRESCIMO := VN_AUX_ALQ;\n        :NEW.VLR_ACRESCIMO := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  if NVL(:NEW.VLR_FRETE, 0) = 0 and NVL(:NEW.VLR_FRETE_RDP, 0) = 0 then\n    :NEW.IND_FRETE_NOTA := 'N';\n  end if;\n  dbms_output.put_line('L699: vlr_frete: ' || :new.vlr_frete || ' ' ||\n                       :NEW.IND_FRETE_NOTA);\n\n  if NVL(:NEW.VLR_DESCONTO, 0) = 0 then\n    :NEW.IND_DESCONTO_ITEM      := 'N';\n    :NEW.IND_DESCONTO_BASE_ICMS := 'N';\n    :NEW.IND_DESCONTO_BASE_IPI  := 'N';\n  elsif NVL(:NEW.VLR_DESCONTO, 0) > 0 then\n    :NEW.IND_DESCONTO_ITEM      := 'Y';\n  end if;\n\n  if NVL(:NEW.VLR_BASE_ICMS_CALC, 0) = 0 and\n     NVL(:NEW.VLR_BASE_ICMS_SUBST_CALC, 0) = 0 then\n    :NEW.IND_DESCONTO_BASE_ICMS := 'N';\n  end if;\n  dbms_output.put_line('L711: vlr_frete: ' || :NEW.VLR_BASE_ICMS_CALC || ' ' ||\n                       :NEW.IND_DESCONTO_BASE_ICMS);\n\n  if NVL(:NEW.VLR_ACRESCIMO, 0) = 0 then\n    :NEW.IND_ACRESCIMO_ITEM      := 'N';\n    :NEW.IND_ACRESCIMO_BASE_ICMS := 'N';\n    :NEW.IND_ACRESCIMO_BASE_IPI  := 'N';\n  end if;\n\n  if NVL(:NEW.VLR_BASE_IPI_CALC, 0) = 0 then\n    :NEW.IND_ACRESCIMO_BASE_IPI := 'N';\n  end if;\n\n  if :NEW.IND_ACRESCIMO_ITEM = 'Y' then\n    :NEW.VLR_TOTAL_CALC := :NEW.VLR_TOTAL_CALC + :NEW.VLR_ACRESCIMO;\n  end if;\n\n/*  if :NEW.IND_DESCONTO_ITEM = 'Y' then\n    :NEW.VLR_TOTAL_CALC := :NEW.VLR_TOTAL_CALC - :NEW.VLR_DESCONTO;\n  end if;*/\n\n  if :NEW.IND_FRETE_NOTA = 'Y' then\n    :NEW.VLR_TOTAL_CALC := ROUND(:NEW.VLR_TOTAL_CALC +\n                                 NVL(:NEW.VLR_FRETE, 0) +\n                                 NVL(:NEW.VLR_FRETE_RDP, 0),\n                                 2);\n  end if;\n  dbms_output.put_line('L737: vlr_total_calc: ' || :NEW.VLR_TOTAL_CALC ||\n                       ' fr nf: ' || :NEW.IND_FRETE_NOTA || ' bseICMS: ' ||\n                       :NEW.VLR_BASE_ICMS_CALC);\n\n  -- AOK - 05/02/2013 - quando nota de importacao - não consistir os impostos\n  --if VN_BEG_TIPO_NF_ID <> BEG_FNC_RETORNA_PARAM_GERAL('Faturamento', null, 'TIPO_NF_IMPORTACAO') then\n  if NVL(V_TIPO_NF.IND_IMPORTACAO, 'N') = 'N' -- aok - 02/05/2013\n     and NVL(VC_IND_GERADA_XML, 'N') = 'N' -- aok - 30/01/2014\n   then\n    -- ICMS\n    if NVL(:NEW.ALQ_ICMS, 0) = 0 then\n      :NEW.VLR_BASE_ICMS_CALC := 0;\n      :NEW.VLR_ICMS_CALC      := 0;\n    else\n      -- Se digitou nova base ou novo valor, verifica pelos digitados\n      if NVL(:NEW.VLR_BASE_ICMS, 0) > 0 or NVL(:NEW.VLR_ICMS, 0) > 0 then\n\n        VN_AUX_CALC := NVL(:NEW.VLR_ICMS, 0);\n\n        BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:NEW.ALQ_ICMS,\n                                               :NEW.VLR_BASE_ICMS,\n                                               VN_AUX_CALC);\n        if VN_AUX_CALC = -1 then\n          VC_MSG_ERRO := 'Valores negativos no calculo do ICMS digitado!';\n        elsif VN_AUX_CALC = -2 then\n          VC_MSG_ERRO := 'Impossivel apurar valor do ICMS digitado!';\n        elsif VN_AUX_CALC = -3 then\n          VC_MSG_ERRO := 'Valor apurado de ICMS digitado diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n        else\n          :NEW.VLR_ICMS := VN_AUX_CALC;\n        end if;\n        if VC_MSG_ERRO is not null then\n          goto FIM;\n        end if;\n\n      end if;\n\n      VN_VLR_RATEADO := 0;\n      --\n      if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS, 0) > 0 then\n        if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE, 0) > 0 then\n          VN_VLR_RATEADO := VN_VLR_RATEADO +\n                            BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE;\n        end if;\n        if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE, 0) > 0 then\n          VN_VLR_RATEADO := VN_VLR_RATEADO +\n                            BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE;\n        end if;\n        if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE, 0) > 0 then\n          VN_VLR_RATEADO := VN_VLR_RATEADO -\n                            BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE;\n        end if;\n      end if;\n\n      if VN_VLR_RATEADO = 0 then\n        VN_TESTE                := 0;\n        :NEW.VLR_BASE_ICMS_CALC := :NEW.VLR_TOTAL_CALC;\n        VN_TESTE                := :NEW.VLR_BASE_ICMS_CALC;\n      else\n        :NEW.VLR_BASE_ICMS_CALC := ROUND((VN_VLR_RATEADO /\n                                         BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS *\n                                         :NEW.VLR_TOTAL_CALC) +\n                                         :NEW.VLR_TOTAL_CALC,\n                                         2);\n      end if;\n      dbms_output.put_line('L798: rateio: ' || VN_VLR_RATEADO ||\n                           ' base icms: ' || :NEW.VLR_BASE_ICMS_CALC);\n\n      if :NEW.IND_ACRESCIMO_BASE_ICMS = 'Y' then\n        :NEW.VLR_BASE_ICMS_CALC := :NEW.VLR_BASE_ICMS_CALC +\n                                   NVL(:NEW.VLR_ACRESCIMO, 0);\n      end if;\n\n      if :NEW.IND_DESCONTO_BASE_ICMS = 'Y' then\n        :NEW.VLR_BASE_ICMS_CALC := :NEW.VLR_BASE_ICMS_CALC -\n                                   NVL(:NEW.VLR_DESCONTO, 0);\n      end if;\n      VN_AUX_CALC := 0;\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:NEW.ALQ_ICMS,\n                                             :NEW.VLR_BASE_ICMS_CALC,\n                                             VN_AUX_CALC);\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do ICMS!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do ICMS!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de ICMS diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :NEW.VLR_ICMS_CALC := ROUND(VN_AUX_CALC, 2);\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n\n    -- Outros ICMS\n    VN_AUX_CALC := :NEW.VLR_OUTROS_ICMS;\n\n    if NVL(:NEW.ALQ_OUTROS_ICMS, 0) > 0 or -- aok - 12/08/2011\n       NVL(:NEW.VLR_OUTROS_ICMS, 0) > 0 then\n\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:NEW.ALQ_OUTROS_ICMS,\n                                             :NEW.VLR_BASE_OUTROS_ICMS,\n                                             VN_AUX_CALC);\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo de outros ICMS!';\n      elsif VN_AUX_CALC = -2 and V_VALIDA = 'S' then\n        VC_MSG_ERRO := 'Impossivel apurar valor de outros ICMS!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de outros ICMS diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        if NVL(:NEW.VLR_OUTROS_ICMS, 0) = 0 then\n          :NEW.VLR_OUTROS_ICMS := VN_AUX_CALC;\n        end if;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n\n    -- AOK - 26/07/2011 ------------------------------------------------------------------\n    VN_PERC_MVA := 0;\n    /*    -- aok - 19/12/2013 --\n      if :NEW.VLR_BASE_ICMS_SUBST > 0\n       and\n       :NEW.VLR_BASE_ICMS_SUBST > ROUND(:NEW.QTD * :NEW.VLR_UNITARIO, 2)\n       and V_TIPO_NF.DESC_RESUMIDA = 'TRA'\n       and VC_IND_FATURAMENTO = 'N' -- aok - 19/12/2013\n       then\n      if (((:NEW.VLR_BASE_ICMS_SUBST /\n         (ROUND(:NEW.QTD * :NEW.VLR_UNITARIO, 2))) - 1) * 100) > 100 -- AOK - 05/08/2013\n       then\n        RAISE_APPLICATION_ERROR(-20001,:new.beg_produto_id ||\n                                ' Revisar, a base icms st (' ||\n                                :NEW.VLR_BASE_ICMS_SUBST ||\n                                ') > qtde x vlr.unit. (' ||\n                                round((((:NEW.VLR_BASE_ICMS_SUBST /\n                                (ROUND(:NEW.QTD * :NEW.VLR_UNITARIO, 2))) - 1) * 100),2) || ')');\n      end if;\n      VN_PERC_MVA := (:NEW.VLR_BASE_ICMS_SUBST /\n                     (ROUND(:NEW.QTD * :NEW.VLR_UNITARIO, 2)) - 1) * 100;\n    end if;*/\n    --------------------------------------------------------------------------------------\n    -- ICMS substituic?o\n    if NVL(:NEW.ALQ_ICMS_SUBST, 0) = 0 then\n      :NEW.VLR_BASE_ICMS_SUBST_CALC := 0;\n      :NEW.VLR_ICMS_SUBST_CALC      := 0;\n      :NEW.VLR_BASE_ICMS_SUBST      := 0; -- aok - 25/05/2010\n      :NEW.VLR_ICMS_SUBST           := 0; -- aok - 25/05/2010\n    elsif NVL(VC_IND_GERADA_XML, 'N') = 'N' -- aok - 31/05/2013\n          and NVL(VC_IND_FATURAMENTO, 'N') = 'N' -- aok - 19/12/2013\n     then\n      -- else\n      -- Se digitou nova base ou novo valor, verifica pelos digitados\n      if NVL(:NEW.VLR_BASE_ICMS_SUBST, 0) > 0 or\n         NVL(:NEW.VLR_ICMS_SUBST, 0) > 0 then\n\n        VN_AUX_CALC := NVL(:NEW.VLR_ICMS_SUBST, 0);\n        BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:NEW.ALQ_ICMS_SUBST,\n                                               :NEW.VLR_BASE_ICMS_SUBST,\n                                               VN_AUX_CALC);\n        -- teste - aok - 23/10/2013 --------------------------------------------\n        DBMS_OUTPUT.PUT_LINE('1.beg_trg_biud_cpr_nfe_item:' ||\n                             :NEW.ALQ_ICMS_SUBST || ' ' ||\n                             :NEW.VLR_BASE_ICMS_SUBST || ' ' ||\n                             VN_AUX_CALC);\n        ------------------------------------------------------------------------\n        if VN_AUX_CALC = -1 then\n          VC_MSG_ERRO := 'Valores negativos no calculo do ICMS da substituic?o digitada!';\n        elsif VN_AUX_CALC = -2 then\n          VC_MSG_ERRO := 'Impossivel apurar valor do ICMS da substituic?o digitada!';\n        elsif VN_AUX_CALC = -3 then\n          VC_MSG_ERRO := 'Valor apurado de ICMS da substituic?o digitada diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n        else\n          :NEW.VLR_ICMS_SUBST := VN_AUX_CALC;\n        end if;\n        if VC_MSG_ERRO is not null then\n          goto FIM;\n        end if;\n      end if;\n\n      VN_VLR_RATEADO := 0;\n\n      if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS, 0) > 0 then\n        if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE, 0) > 0 then\n          VN_VLR_RATEADO := VN_VLR_RATEADO +\n                            BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE;\n        end if;\n        if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE, 0) > 0 then\n          VN_VLR_RATEADO := VN_VLR_RATEADO +\n                            BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE;\n        end if;\n        if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE, 0) > 0 then\n          VN_VLR_RATEADO := VN_VLR_RATEADO -\n                            BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE;\n        end if;\n      end if;\n\n      -- aok - 26/07/2011 - Adicionado o calculo do percentual de correção para o calculado\n      if VN_VLR_RATEADO = 0 then\n        :NEW.VLR_BASE_ICMS_SUBST_CALC := :NEW.VLR_TOTAL_CALC *\n                                         (1 + (VN_PERC_MVA / 100));\n      else\n        :NEW.VLR_BASE_ICMS_SUBST_CALC := ROUND((VN_VLR_RATEADO /\n                                               BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS *\n                                               :NEW.VLR_TOTAL_CALC *\n                                               (1 + (VN_PERC_MVA / 100))) +\n                                               :NEW.VLR_TOTAL_CALC *\n                                               (1 + (VN_PERC_MVA / 100)),\n                                               2);\n      end if;\n      --  if VN_VLR_RATEADO = 0 then\n      --    :NEW.VLR_BASE_ICMS_SUBST_CALC := :NEW.VLR_TOTAL_CALC;\n      --  else\n      --    :NEW.VLR_BASE_ICMS_SUBST_CALC := ROUND((VN_VLR_RATEADO /\n      --                                           BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS *\n      --                                           :NEW.VLR_TOTAL_CALC) +\n      --                                           :NEW.VLR_TOTAL_CALC,\n      --                                           2);\n      --  end if;\n\n      if :NEW.IND_ACRESCIMO_BASE_ICMS = 'Y' then\n        :NEW.VLR_BASE_ICMS_SUBST_CALC := :NEW.VLR_BASE_ICMS_SUBST_CALC +\n                                         NVL(:NEW.VLR_ACRESCIMO, 0);\n      end if;\n\n      if :NEW.IND_DESCONTO_BASE_ICMS = 'Y' then\n        :NEW.VLR_BASE_ICMS_SUBST_CALC := :NEW.VLR_BASE_ICMS_SUBST_CALC -\n                                         NVL(:NEW.VLR_DESCONTO, 0);\n      end if;\n\n      VN_AUX_CALC := 0;\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:NEW.ALQ_ICMS_SUBST,\n                                             :NEW.VLR_BASE_ICMS_SUBST_CALC,\n                                             VN_AUX_CALC);\n      -- teste - aok - 23/10/2013 --------------------------------------------\n      DBMS_OUTPUT.PUT_LINE('2.beg_trg_biud_cpr_nfe_item :' ||\n                           :NEW.ALQ_ICMS_SUBST || ' ' ||\n                           :NEW.VLR_BASE_ICMS_SUBST || ' ' || VN_AUX_CALC);\n      ------------------------------------------------------------------------\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do ICMS da substituic?o!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do ICMS da substituic?o!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de ICMS da substituic?o diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :NEW.VLR_ICMS_SUBST_CALC := ROUND(VN_AUX_CALC, 2);\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n\n    -- Isento de ICMS\n    if NVL(:NEW.VLR_BASE_ISENTO_ICMS, 0) < 0 then\n      VC_MSG_ERRO := 'Valor da base isenta de ICMS negativo!';\n      goto FIM;\n    end if;\n\n    -- IPI\n    if NVL(VC_IND_GERADA_XML, 'N') = 'N' -- aok - 29/01/2014\n     then\n      if NVL(:NEW.ALQ_IPI, 0) = 0 then\n        :NEW.VLR_BASE_IPI_CALC := 0;\n        :NEW.VLR_IPI_CALC      := 0;\n      else\n        -- Se digitou nova base ou novo valor, verifica pelos digitados\n        if NVL(:NEW.VLR_BASE_IPI, 0) > 0 or NVL(:NEW.VLR_IPI, 0) > 0 then\n\n          VN_AUX_CALC := NVL(:NEW.VLR_IPI, 0);\n          BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:NEW.ALQ_IPI,\n                                                 :NEW.VLR_BASE_IPI,\n                                                 VN_AUX_CALC);\n          if VN_AUX_CALC = -1 then\n            VC_MSG_ERRO := 'Valores negativos no calculo do IPI digitado!';\n          elsif VN_AUX_CALC = -2 then\n            VC_MSG_ERRO := 'Impossivel apurar valor do IPI digitado!';\n          elsif VN_AUX_CALC = -3 then\n            VC_MSG_ERRO := 'Valor apurado de IPI digitado diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n          else\n            :NEW.VLR_IPI := VN_AUX_CALC;\n          end if;\n          if VC_MSG_ERRO is not null then\n            goto FIM;\n          end if;\n\n        end if;\n\n        VN_VLR_RATEADO := 0;\n\n        if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS, 0) > 0 then\n          if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE, 0) > 0 then\n            VN_VLR_RATEADO := VN_VLR_RATEADO +\n                              BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE;\n          end if;\n          if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_IPI_NFE, 0) > 0 then\n            VN_VLR_RATEADO := VN_VLR_RATEADO +\n                              BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_IPI_NFE;\n          end if;\n          if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_IPI_NFE, 0) > 0 then\n            VN_VLR_RATEADO := VN_VLR_RATEADO -\n                              BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_IPI_NFE;\n          end if;\n        end if;\n\n        if VN_VLR_RATEADO = 0 then\n          :NEW.VLR_BASE_IPI_CALC := :NEW.VLR_TOTAL_CALC;\n        else\n          :NEW.VLR_BASE_IPI_CALC := ROUND((BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE /\n                                          BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS *\n                                          :NEW.VLR_TOTAL_CALC) +\n                                          :NEW.VLR_TOTAL_CALC,\n                                          2);\n        end if;\n\n        if :NEW.IND_ACRESCIMO_BASE_IPI = 'Y' then\n          :NEW.VLR_BASE_IPI_CALC := :NEW.VLR_BASE_IPI_CALC +\n                                    NVL(:NEW.VLR_ACRESCIMO, 0);\n        end if;\n\n        if :NEW.IND_DESCONTO_BASE_IPI = 'Y' then\n          :NEW.VLR_BASE_IPI_CALC := :NEW.VLR_BASE_IPI_CALC -\n                                    NVL(:NEW.VLR_DESCONTO, 0);\n        end if;\n\n        VN_AUX_CALC := 0;\n        BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:NEW.ALQ_IPI,\n                                               :NEW.VLR_BASE_IPI_CALC,\n                                               VN_AUX_CALC);\n        if VN_AUX_CALC = -1 then\n          VC_MSG_ERRO := 'Valores negativos no calculo do IPI!';\n        elsif VN_AUX_CALC = -2 then\n          VC_MSG_ERRO := 'Impossivel apurar valor do IPI!';\n        elsif VN_AUX_CALC = -3 then\n          VC_MSG_ERRO := 'Valor apurado de IPI diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n        else\n          :NEW.VLR_IPI_CALC := ROUND(VN_AUX_CALC, 2);\n        end if;\n        if VC_MSG_ERRO is not null then\n          goto FIM;\n        end if;\n      end if;\n    end if; -- if VC_IND_GERADA_XML = 'N' -- aok - 29/01/2014\n\n    -- Outros IPI\n    VN_AUX_CALC := :NEW.VLR_OUTROS_IPI;\n    if NVL(:NEW.ALQ_OUTROS_IPI, 0) > 0 or -- 12/08/2011\n       NVL(:NEW.VLR_OUTROS_IPI, 0) > 0 then\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:NEW.ALQ_OUTROS_IPI,\n                                             :NEW.VLR_BASE_OUTROS_IPI,\n                                             VN_AUX_CALC);\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo de outros IPI!';\n      elsif VN_AUX_CALC = -2 and NVL(V_VALIDA, 'N') = 'S' then\n        VC_MSG_ERRO := 'Impossivel apurar valor de outros IPI!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de outros IPI diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        if NVL(:NEW.VLR_OUTROS_IPI, 0) = 0 then\n          :NEW.VLR_OUTROS_IPI := VN_AUX_CALC;\n        end if;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n\n    -- Isento de IPI\n    if NVL(:NEW.VLR_BASE_ISENTO_IPI, 0) < 0 then\n      VC_MSG_ERRO := 'Valor da base isenta de IPI negativo!';\n      goto FIM;\n    end if;\n\n    -- ISSQN\n    VN_AUX_CALC := :NEW.VLR_ISSQN;\n    BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:NEW.ALQ_ISSQN,\n                                           :NEW.VLR_BASE_ISSQN,\n                                           VN_AUX_CALC);\n    if VN_AUX_CALC = -1 then\n      VC_MSG_ERRO := 'Valores negativos no calculo do ISSQN!';\n    elsif VN_AUX_CALC = -2 then\n      VC_MSG_ERRO := 'Impossivel apurar valor do ISSQN!';\n    elsif VN_AUX_CALC = -3 then\n      VC_MSG_ERRO := 'Valor apurado de ISSQN diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n    else\n      if NVL(:NEW.VLR_ISSQN, 0) = 0 then\n        :NEW.VLR_ISSQN := VN_AUX_CALC;\n      end if;\n    end if;\n    if VC_MSG_ERRO is not null then\n      goto FIM;\n    end if;\n    --\n  end if; --   if NVL(V_TIPO_NF.IND_IMPORTACAO, 'N') = 'N' then -- aok - 02/05/2013\n\n  -- Valida o almoxarifado informado. Se for zero, n?o posui inspec?o. Neste caso deve ter sido informado no item\n  /*  VN_BEG_EST_ALMOXARIFADO_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAMETRO(:NEW.AD_CLIENT_ID,\n                                                                    :NEW.AD_ORG_ID,\n                                                                    'Estoque',\n                                                                    null,\n                                                                    'ALMOXARIFADO_INSPECAO'));\n\n  if NVL(VN_BEG_EST_ALMOXARIFADO_ID, 0) = 0 then\n    if NVL(:NEW.BEG_EST_ALMOXARIFADO_ID, 0) = 0 then\n      VC_MSG_ERRO := 'Nao existe almoxarifado de inspecao parametrizado e item nao possui almoxarifado informado!';\n      goto FIM;\n    end if;\n    --  else\n    --    if :NEW.BEG_EST_ALMOXARIFADO_ID is not null then\n    --      VC_MSG_ERRO := 'Existe almoxarifado de inspec?o parametrizado e item possui almoxarifado informado!';\n    --      goto FIM;\n    --    end if;\n  end if;*/\n  --\n  --  VN_TESTE := NVL(:NEW.VLR_BASE_ICMS_SUBST_CALC,0);--NVL(:NEW.VLR_BASE_ICMS_CALC,0);\n  --\n  -- Atualiza os campos da nota\n  if not BEG_PCK_CPR_COMPRAS.VB_PROC_NFE then\n\n    BEG_PCK_CPR_COMPRAS.VB_PROC_NFE_IT := true;\n    --\n    VN_TESTE := :NEW.VLR_IPI;\n    --VN_TESTE := :NEW.VLR_IPI_CALC;\n    --\n    --dbms_output.put_line('BEG_TRG_BIUD_CPR_NFE_ITEM');\n    dbms_output.put_line('L1159: total_calc old: ' || :old.VLR_TOTAL_CALC ||\n                         ' new:' || :NEW.VLR_TOTAL_CALC);\n\n    update BEG_CPR_PRE_NFE X\n       set VLR_BASE_ICMS_CALC       = ROUND(VLR_BASE_ICMS_CALC -\n                                            NVL(:OLD.VLR_BASE_ICMS_CALC, 0) +\n                                            NVL(:NEW.VLR_BASE_ICMS_CALC, 0),\n                                            2),\n           VLR_BASE_OUTROS_ICMS     = VLR_BASE_OUTROS_ICMS -\n                                      NVL(:OLD.VLR_BASE_OUTROS_ICMS, 0) +\n                                      NVL(:NEW.VLR_BASE_OUTROS_ICMS, 0),\n           VLR_BASE_ICMS_SUBST_CALC = ROUND(VLR_BASE_ICMS_SUBST -\n                                            NVL(:OLD.VLR_BASE_ICMS_SUBST,\n                                                0) + NVL(:NEW.VLR_BASE_ICMS_SUBST,\n                                                         0),\n                                            2),\n           VLR_BASE_ISENTO_ICMS     = VLR_BASE_ISENTO_ICMS -\n                                      NVL(:OLD.VLR_BASE_ISENTO_ICMS, 0) +\n                                      NVL(:NEW.VLR_BASE_ISENTO_ICMS, 0),\n           VLR_ICMS_CALC            = ROUND(VLR_ICMS_CALC -\n                                            NVL(:OLD.VLR_ICMS_CALC, 0) +\n                                            NVL(:NEW.VLR_ICMS_CALC, 0),\n                                            2),\n           VLR_OUTROS_ICMS          = VLR_OUTROS_ICMS -\n                                      NVL(:OLD.VLR_OUTROS_ICMS, 0) +\n                                      NVL(:NEW.VLR_OUTROS_ICMS, 0),\n           VLR_ICMS_SUBST_CALC      = case\n                                        when NVL(:OLD.VLR_TOTAL_CALC, 0) <>\n                                             NVL(:NEW.VLR_TOTAL_CALC, 0)\n                                             and IND_NFE_ORDEM = 'Y' then\n                                         0\n                                        else\n                                         VLR_ICMS_SUBST\n                                        end,\n                                      /*ROUND(VLR_ICMS_SUBST_CALC -\n                                            NVL(:OLD.VLR_ICMS_SUBST_CALC, 0) +\n                                            NVL(:NEW.VLR_ICMS_SUBST_CALC, 0),\n                                            2),*/\n           VLR_ICMS_SUBST = case\n                              when NVL(:OLD.VLR_TOTAL_CALC, 0) <>\n                                   NVL(:NEW.VLR_TOTAL_CALC, 0)\n                                   and IND_NFE_ORDEM = 'Y' then\n                               0\n                              else\n                               VLR_ICMS_SUBST\n                            end,\n           VLR_BASE_IPI_CALC        = ROUND(VLR_BASE_IPI_CALC -\n                                            NVL(:OLD.VLR_BASE_IPI_CALC, 0) +\n                                            NVL(:NEW.VLR_BASE_IPI_CALC, 0),\n                                            2),\n           VLR_BASE_OUTROS_IPI      = VLR_BASE_OUTROS_IPI -\n                                      NVL(:OLD.VLR_BASE_OUTROS_IPI, 0) +\n                                      NVL(:NEW.VLR_BASE_OUTROS_IPI, 0),\n           VLR_BASE_ISENTO_IPI      = VLR_BASE_ISENTO_IPI -\n                                      NVL(:OLD.VLR_BASE_ISENTO_IPI, 0) +\n                                      NVL(:NEW.VLR_BASE_ISENTO_IPI, 0),\n           VLR_IPI_CALC             = ROUND(VLR_IPI_CALC -\n                                            NVL(:OLD.VLR_IPI_CALC, 0) +\n                                            NVL(:NEW.VLR_IPI_CALC, 0),\n                                            2),\n           VLR_BASE_IPI             = VLR_BASE_IPI + (NVL(:NEW.VLR_BASE_IPI,0) - NVL(:OLD.VLR_BASE_IPI,0) ),\n          /* VLR_IPI = case\n                       when NVL(:OLD.VLR_TOTAL_CALC, 0) <>\n                            NVL(:NEW.VLR_TOTAL_CALC, 0)\n                            and IND_NFE_ORDEM = 'Y' then\n                        0\n                       else\n                        ROUND(VLR_IPI -\n                                            NVL(:OLD.VLR_IPI, 0) +\n                                            NVL(:NEW.VLR_IPI, 0),\n                                            2)\n                     end,*/\n           VLR_OUTROS_IPI           = VLR_OUTROS_IPI -\n                                      NVL(:OLD.VLR_OUTROS_IPI, 0) +\n                                      NVL(:NEW.VLR_OUTROS_IPI, 0),\n           VLR_BASE_ISSQN           = VLR_BASE_ISSQN -\n                                      NVL(:OLD.VLR_BASE_ISSQN, 0) +\n                                      NVL(:NEW.VLR_BASE_ISSQN, 0),\n           VLR_ISSQN                = VLR_ISSQN - NVL(:OLD.VLR_ISSQN, 0) +\n                                      NVL(:NEW.VLR_ISSQN, 0),\n           QTD_VOLUMES              = QTD_VOLUMES - NVL(:OLD.QTD_VOLUMES, 0) +\n                                      NVL(:NEW.QTD_VOLUMES, 0),\n           --PESO_BRUTO               = PESO_BRUTO - NVL(:OLD.PESO_BRUTO, 0) +\n           --                           NVL(:NEW.PESO_BRUTO, 0),\n           --PESO_LIQUIDO             = PESO_LIQUIDO -\n           --                           NVL(:OLD.PESO_LIQUIDO, 0) +\n           --                           NVL(:NEW.PESO_LIQUIDO, 0),\n           PESO_BRUTO = case\n                          when NVL(VC_IND_FATURAMENTO, 'N') = 'N' then\n                           PESO_BRUTO - NVL(:OLD.PESO_BRUTO, 0) +\n                           NVL(:NEW.PESO_BRUTO, 0)\n                          else\n                           PESO_BRUTO\n                        end,\n           PESO_LIQUIDO = case\n                            when NVL(VC_IND_FATURAMENTO, 'N') = 'N' then\n                             PESO_LIQUIDO - NVL(:OLD.PESO_LIQUIDO, 0) +\n                             NVL(:NEW.PESO_LIQUIDO, 0)\n                            else\n                             PESO_LIQUIDO\n                          end,\n           VLR_SEGURO              = VLR_SEGURO - NVL(:OLD.VLR_SEGURO, 0) +\n                                     NVL(:NEW.VLR_SEGURO, 0),\n           VLR_TOTAL_PRODUTOS_CALC = ROUND(VLR_TOTAL_PRODUTOS_CALC -\n                                           NVL(:OLD.VLR_TOTAL_CALC, 0) +\n                                           NVL(:NEW.VLR_TOTAL_CALC, 0),\n                                           2),\n           VLR_TOTAL_NOTA_CALC = ROUND(VLR_TOTAL_NOTA_CALC -\n                                       (NVL(:OLD.VLR_TOTAL_CALC, 0) - -- Total dos itens\n                                       NVL(:OLD.VLR_DESCONTO,0) + -- VALOR DO DESCONTO\n                                       NVL(:OLD.VLR_DESPESAS_FINANCEIRAS, 0) + -- Despesas financeiras do item\n                                       NVL(:OLD.VLR_OUTRAS_DESPESAS, 0) + -- Outras despesas do item\n                                       --nvl(:OLD.VLR_ICMS_SUBST_CALC, 0) + -- aok - 26/07/2013\n                                       DECODE(NVL(:OLD.IND_FRETE_NOTA, 'N'),\n                                               'Y',\n                                               (NVL(:OLD.VLR_FRETE, 0) +\n                                               NVL(:OLD.VLR_FRETE_RDP, 0)),\n                                               0) +\n                                       NVL(:OLD.VL_IMPOSTO_IMPORTACAO, 0) + -- AOK - 05/08/2013\n                                       NVL(:OLD.VLR_DESP_ACES_IMP, 0) -- AOK - 05/08/2013\n                                       ) + -- Frete dos itens (na nota)\n                                       (NVL(:NEW.VLR_TOTAL_CALC, 0) - -- Total dos itens\n                                       --NVL(:NEW.VLR_DESCONTO,0) + -- VALOR DO DESCONTO\n                                       NVL(:NEW.VLR_DESPESAS_FINANCEIRAS, 0) + -- Despesas financeiras do item\n                                       NVL(:NEW.VLR_OUTRAS_DESPESAS, 0) + -- Outras despesas do item\n                                       -- nvl(:new.VLR_ICMS_SUBST_CALC, 0) + -- aok - 26/07/2013\n                                       case\n                                         when NVL(VC_IND_ICMS_TOTAL_NOTA, 'N') = 'Y' -- aok - 29/07/2013\n                                          then\n                                          NVL(:NEW.VLR_ICMS, 0)\n                                         else\n                                          0\n                                       end +\n                                       DECODE(NVL(:NEW.IND_FRETE_NOTA, 'N'),\n                                               'Y',\n                                               (NVL(:NEW.VLR_FRETE, 0) +\n                                               NVL(:NEW.VLR_FRETE_RDP, 0)),\n                                               0) +\n                                       NVL(:NEW.VL_IMPOSTO_IMPORTACAO, 0) + -- AOK - 05/08/2013\n                                       NVL(:NEW.VLR_DESP_ACES_IMP, 0) -- AOK - 05/08/2013\n                                       ), -- Frete dos itens (na nota)\n                                       2),\n           BEG_VW_CFOP_ENT_ID      = NVL(BEG_VW_CFOP_ENT_ID,\n                                         :NEW.BEG_VW_CFOP_ENT_ID), -- aok - 29/05/2013\n           BEG_VW_CFOP_SAI_ID      = NVL(BEG_VW_CFOP_SAI_ID,\n                                         :NEW.BEG_VW_CFOP_SAI_ID) -- aok - 29/05/2013\n     where BEG_CPR_PRE_NFE_ID = :NEW.BEG_CPR_PRE_NFE_ID;\n\n    BEG_PCK_CPR_COMPRAS.VB_PROC_NFE_IT := false;\n  end if;\n --\n\n  -- AOK - 25/05/2010 -- Tratamento dos codigos de tributação de icms\n  if INSERTING and NVL(:NEW.BEG_FIS_TRIB_ICMS_ID, 0) = 0 then\n    :NEW.BEG_FIS_TRIB_ICMS_ID := 1000000; -- 00 - Tributa integralmente\n  elsif UPDATING then\n    if :NEW.BEG_FIS_TRIB_ICMS_ID = :OLD.BEG_FIS_TRIB_ICMS_ID then\n      :NEW.BEG_FIS_TRIB_ICMS_ID := BEG_FNC_GERA_COD_SIT_TRIB(2,\n                                                             NVL(:NEW.VLR_BASE_ICMS_CALC,\n                                                                 0),\n                                                             NVL(:NEW.VLR_BASE_OUTROS_ICMS,\n                                                                 0),\n                                                             NVL(:NEW.VLR_BASE_ISENTO_ICMS,\n                                                                 0),\n                                                             NVL(:NEW.VLR_BASE_ICMS_SUBST_CALC,\n                                                                 0),\n                                                             NVL(RCFOCST.CFOP,\n                                                                 0) -- aok - 08/11/2011\n                                                             );\n    end if;\n  end if;\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend BEG_TRG_BIUD_CPR_NFE_ITEM;\n"}`;
    
    }
}
