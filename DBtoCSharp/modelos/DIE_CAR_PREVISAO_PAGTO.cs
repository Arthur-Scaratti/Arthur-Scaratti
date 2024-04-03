
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAR_PREVISAO_PAGTO
    {
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_BRUTO_PARC4 { get; set; }
        
        /// <summary>
        /// Valor bruto da parcela
        /// </summary>
        public int VLR_BRUTO_PARC4 { get; set; }
        
        /// <summary>
        /// Valor (em %) da Taxa de Amdinistração aplicada ao Lote/Parcela
        /// </summary>
        public int PERCENTUAL_TAXA_ADM4 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_VLR_TAXA_ADM4 { get; set; }
        
        /// <summary>
        /// Valor da taxa Administrativa aplicada à loja
        /// </summary>
        public int VLR_TAXA_ADM4 { get; set; }
        
        /// <summary>
        /// Valor (em %) da Taxa Financeira (de antecipação) aplicada ao Lote/Parcela
        /// </summary>
        public int PERCENTUAL_TAXA_FIN4 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_VLR_TAXA_FIN4 { get; set; }
        
        /// <summary>
        /// Valor da taxaFinanceira (de antecipação) aplicada à loja
        /// </summary>
        public int VLR_TAXA_FIN4 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_VLR_LIQ_PARC4 { get; set; }
        
        /// <summary>
        /// Valor da Parcela - Vlr Tx Adm - Vlr Tx Fin (se houver)
        /// </summary>
        public int VLR_LIQ_PARC4 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_DIFERENCA_PARC2 { get; set; }
        
        /// <summary>
        /// Diferença entre o valor da 2ª parcela(bruta) do lote e a soma das parcelas das vendas (sem acréscimo do resto da divisão)
        /// </summary>
        public int VLR_DIFERENCA_PARC2 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_DIFERENCA_PARC3 { get; set; }
        
        /// <summary>
        /// Diferença entre o valor da 3ª parcela(bruta) do lote e a soma das parcelas das vendas (sem acréscimo do resto da divisão)
        /// </summary>
        public int VLR_DIFERENCA_PARC3 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_DIFERENCA_PARC4 { get; set; }
        
        /// <summary>
        /// Diferença entre o valor da 4ª parcela(bruta) do lote e a soma das parcelas das vendas (sem acréscimo do resto da divisão)
        /// </summary>
        public int VLR_DIFERENCA_PARC4 { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_PREVISAO_PAGTO_ID { get; set; }
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
        /// 3
        /// </summary>
        public int TP_REGISTRO { get; set; }
            [Required]
        /// <summary>
        /// Codigo loja (maquineta)
        /// </summary>
        public int COD_LOJA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TP_LOTE { get; set; }
        
        /// <summary>
        /// N° Lote Hipercard
        /// </summary>
        public int NRO_LOTE { get; set; }
        
        /// <summary>
        /// Data da remessa do lote (data venda)
        /// </summary>
        public string DT_REMESSA { get; set; }
        
        /// <summary>
        /// Data do processamneto do pagamento do Lote/Parcela
        /// </summary>
        public string DT_PROCESSAMENTO { get; set; }
        
        /// <summary>
        /// Data da programação do crádito Lote/Parcela
        /// </summary>
        public string DT_PROG_PARC2 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// N° da parcela / total de parcelas
        /// </summary>
        public string NRO_PARCELA_TOT_PARC2 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_BRUTO_PARC2 { get; set; }
        
        /// <summary>
        /// Valor bruto da parcela
        /// </summary>
        public int VLR_BRUTO_PARC2 { get; set; }
        
        /// <summary>
        /// Valor (em %) da Taxa de Amdinistração aplicada ao Lote/Parcela
        /// </summary>
        public int PERCENTUAL_TAXA_ADM2 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_VLR_TAXA_ADM2 { get; set; }
        
        /// <summary>
        /// Valor da taxa Administrativa aplicada à loja
        /// </summary>
        public int VLR_TAXA_ADM2 { get; set; }
        
        /// <summary>
        /// Valor (em %) da Taxa Financeira (de antecipação) aplicada ao Lote/Parcela
        /// </summary>
        public int PERCENTUAL_TAXA_FIN2 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_VLR_TAXA_FIN2 { get; set; }
        
        /// <summary>
        /// Valor da taxaFinanceira (de antecipação) aplicada à loja
        /// </summary>
        public int VLR_TAXA_FIN2 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_VLR_LIQ_PARC2 { get; set; }
        
        /// <summary>
        /// Valor da Parcela - Vlr Tx Adm - Vlr Tx Fin (se houver)
        /// </summary>
        public int VLR_LIQ_PARC2 { get; set; }
        
        /// <summary>
        /// Data da programação do crádito Lote/Parcela
        /// </summary>
        public string DT_PROG_PARC3 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// N° da parcela / total de parcelas
        /// </summary>
        public string NRO_PARCELA_TOT_PARC3 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_BRUTO_PARC3 { get; set; }
        
        /// <summary>
        /// Valor bruto da parcela
        /// </summary>
        public int VLR_BRUTO_PARC3 { get; set; }
        
        /// <summary>
        /// Valor (em %) da Taxa de Amdinistração aplicada ao Lote/Parcela
        /// </summary>
        public int PERCENTUAL_TAXA_ADM3 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_VLR_TAXA_ADM3 { get; set; }
        
        /// <summary>
        /// Valor da taxa Administrativa aplicada à loja
        /// </summary>
        public int VLR_TAXA_ADM3 { get; set; }
        
        /// <summary>
        /// Valor (em %) da Taxa Financeira (de antecipação) aplicada ao Lote/Parcela
        /// </summary>
        public int PERCENTUAL_TAXA_FIN3 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_VLR_TAXA_FIN3 { get; set; }
        
        /// <summary>
        /// Valor da taxaFinanceira (de antecipação) aplicada à loja
        /// </summary>
        public int VLR_TAXA_FIN3 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_VLR_LIQ_PARC3 { get; set; }
        
        /// <summary>
        /// Valor da Parcela - Vlr Tx Adm - Vlr Tx Fin (se houver)
        /// </summary>
        public int VLR_LIQ_PARC3 { get; set; }
        
        /// <summary>
        /// Data da programação do crádito Lote/Parcela
        /// </summary>
        public string DT_PROG_PARC4 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// N° da parcela / total de parcelas
        /// </summary>
        public string NRO_PARCELA_TOT_PARC4 { get; set; }

    }
}
