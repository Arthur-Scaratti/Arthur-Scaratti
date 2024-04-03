
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_TXT_VK
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_Registro { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string Operação { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string Lancamento { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DT { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string Vencimento { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string NF { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string Fatura { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string Complemento { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string Codigo_Historico { get; set; }
            [StringLength(201)]
        /// <summary>
        /// 
        /// </summary>
        public string Historico { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string Conta { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string Tipo { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string Valor { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string Empresa { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string Cobranca { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string Cheque { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string portador { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string emissao { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string c_partida { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string saldo { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string conferido { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string campo20 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string situacao { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string conciliado { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string serie { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string contabilizado { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string usuario_modificacao { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string tp_pagamento { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string nr_banco { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string campo28 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string juros_dia { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string ultima_liquidacao { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string unidade_negocio { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string documento { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string tp_documento { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string valor_indexado { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string saldo_indexado { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string tolerancia_vencimento { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO37 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string VLR_MULTA { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string TOLERANCIA_MULTA { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string TOLERANCIA_JUROS { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO41 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_JUROS { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string VLR_DESCONTO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string LANCAMENTO_VINCULADO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_INCLUSAO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string SACADOR_AVALISTA { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string MODALIDADE_VENCIMENTO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string MODALIDADE_PAGAMENTO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string ESPECIE_DOCUMENTO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string VENCIMENTO_ORIGINAL { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string PROJETO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO52 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string INDICE { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string BLOQUETO_IMPRESSO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string DUPLICATA_IMPRESSA { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string REMESSA_ENVIADA { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string AUTORIZADO_POR { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string AUTORIZADO_EM { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_MODIFICACAO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CRIADO_POR { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string SESSAO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO60 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO61 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO62 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO63 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO64 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO65 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO66 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO67 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string ORDEM_ENDERECO_COBRANCA { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO69 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string PAGAMENTO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string LISTA_DAI { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_BARRAS_LIDO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_DIRF { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO74 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO75 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string ORDEM_CONTA_CORRENTE { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string PREVISAO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string LISTAR_DIRF { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CHEQUES_TIT { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string SEQUENCIA { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO81 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO82 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO83 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO84 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO85 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string SESSAO_OPERADOR { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO87 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string HORA_CRIACAO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string USRLANC1 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string USRLANC2 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string USRLANC3 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO_OS { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string ITEM_OS { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string VLR_JUROS { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string VLR_MULTA2 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string OUTRAS_DESPESAS { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string VLR_DESCONTO2 { get; set; }

    }
}
