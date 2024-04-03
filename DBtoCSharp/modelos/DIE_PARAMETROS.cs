
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PARAMETROS
    {
            [StringLength(30)]
        /// <summary>
        /// TELEFONE LOJA
        /// </summary>
        public string FONE { get; set; }
            [StringLength(8)]
        /// <summary>
        /// CEP LOJA
        /// </summary>
        public string CEP { get; set; }
            [StringLength(50)]
        /// <summary>
        /// ENDERECO LOJA
        /// </summary>
        public string LOGRADOURO { get; set; }
        
        /// <summary>
        /// NR DO PREDIO DA LOJA
        /// </summary>
        public int NUMERO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// COMPLEMENTO ENDERECO DA LOJA
        /// </summary>
        public string COMPLEMENTO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// BAIRRO DALOJA
        /// </summary>
        public string BAIRRO { get; set; }
        
        /// <summary>
        /// CODIGO IBGE DO ENDERECO DA LOJA.
        /// </summary>
        public int CODCIDADE { get; set; }
            [StringLength(30)]
        /// <summary>
        /// NOME DA CIDADE
        /// </summary>
        public string CIDADE_DESCRICAO { get; set; }
        
        /// <summary>
        /// AUTENTICACAO DO CAIXA
        /// </summary>
        public int NRO_AUTENTICACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCAIDIN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCAICAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCAICHE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARIDTOKEN { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string PARTOKEN { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string IMPPADNFE { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string IMPPADCAR { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string IMPPADREL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string COMCUP { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string IPHOM { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string IPPRO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MAXIMO_CAIXA_LOJA { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string CODLOJA { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string CODTER { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string MENSPINPAD { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMICER { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string SENHACER { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string CCMAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int EMAILEVITARRELAY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int EMAIL_EVITARRELAY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROTOCOLO { get; set; }
        
        /// <summary>
        /// Se comunicacao esta ok (yes ou no)
        /// </summary>
        public string COMUNICACAO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Codigo da filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// Codigo do almoxarifado da loja
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// Parametro horario carga notas do dbf para banco
        /// </summary>
        public string CARGANFE { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMINHOIMPORTACAO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMINHOXMLPROCESSADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ATIVARTIMER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int INTERVALOTIMER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int EMAIL_ATIVARPOP3 { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL_POP3HOST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int EMAIL_GMAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ATIVARLOG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CALCULAST { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ST_UFBASE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ST_PERCENTUALREDUCAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ST_ALIQUOTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MSG_ENVIOSEMPESOLIQUIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MSG_ENVIOSEMPESOBRUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MSG_ENVIOSEMTRANSPORTADOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MSG_ENVIOSEMPLACAVEICULO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TRIB_OPNORMAL_CST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TRIB_OPNORMAL_PERMICRED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TRIB_OPNORMAL_PERMICRED_ALIQ { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TRIB_ST_CST_SUBSTITUTO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TRIB_ST_CST_SUBSTITUIDO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TRIB_CST_PIS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TRIB_CST_COFINS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TRIB_CST_IPI { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string TRIB_INFADICIONAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SIMPLESNACIONAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TIPOEMITENTEST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ST_SOMASTTOTALNF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IDNF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATAVALIDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CHKCFOP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CRT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_SIMPLES { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string EMIT_EMAIL { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string EMIT_INS_MUN { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string EMIT_EMAIL_CONTAB { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NFE_AMBIENTE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NFE_MODELODOCFISCAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NFE_FORMATOIMPRESSAODANFE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NFE_VERSAODOPROCESSO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NFE_PROCESSODEEMISSAO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string RAZAOSOCIAL { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NOMEFANTASIA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string IE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string IEST { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string IM { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CNAE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CNPJ { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQUOTAPIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQUOTACOFINS { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRODUTO_CONTROLARCOMPOSICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRODUTO_CONTROLARPRODUCAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LOTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int XML { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BANCODADOS_ATIVARBASE2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_CAIXA { get; set; }
        
        /// <summary>
        /// SEQUENCIA PARA NOTA ELETRONICA. INTERNO E SEFAZ. (ULTIMO NR GERADO )
        /// </summary>
        public int NRO_CONTROLE_NE { get; set; }
        
        /// <summary>
        /// SEQUENCIA PARA NR DO CUPOM ELETRONICO QUE VAI PARA A SEFAZ  (ULTIMO NR GERADO )
        /// </summary>
        public int NRO_CONTROLE_CE { get; set; }
        
        /// <summary>
        /// SEQUENCIA PARA CUPOM ELETRONICO QUE GRAVA NO SISTEMA INTERNO (CONTROLE)   (ULTIMO NR GERADO )
        /// </summary>
        public int NRO_CONTROLE_CUPOM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_CONTROLE_RECIBO { get; set; }
        
        /// <summary>
        /// APENAS PARA O AMBIENTE HOMOLOGACAO
        /// </summary>
        public int NRO_CONTROLE_NE_HOM { get; set; }

    }
}
