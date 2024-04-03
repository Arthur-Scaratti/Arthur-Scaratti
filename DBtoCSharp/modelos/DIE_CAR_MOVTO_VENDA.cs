
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAR_MOVTO_VENDA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_MOVTO_VENDA_ID { get; set; }
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
        /// Indicativo do registro '2'
        /// </summary>
        public int TP_REGISTRO { get; set; }
        
        /// <summary>
        /// Código loja
        /// </summary>
        public int COD_LOJA { get; set; }
        
        /// <summary>
        /// 205 / 206 / 213 / 999
        /// </summary>
        public int TP_LOTE { get; set; }
        
        /// <summary>
        /// N° Lote HiperCard
        /// </summary>
        public int NRO_LOTE { get; set; }
        
        /// <summary>
        /// N° Cartao HiperCard
        /// </summary>
        public int NRO_CARTAO { get; set; }
        
        /// <summary>
        /// Data da compra
        /// </summary>
        public string DT_COMPRA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_TOTAL_COMPRA { get; set; }
        
        /// <summary>
        /// Valor total compra
        /// </summary>
        public int VLR_TOTAL_COMPRA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_PARCELA_COMPRA { get; set; }
        
        /// <summary>
        /// Valor da parcela, se for plano parcelado
        /// </summary>
        public int VLR_PARCELA_COMPRA { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Descrição do motivo da rejeição (se for o caso)
        /// </summary>
        public string MOTIVO_REJEICAO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// N° Autorização da venda
        /// </summary>
        public string COD_AUTORIZACAO_TEF { get; set; }
            [StringLength(10)]
        /// <summary>
        /// N° Documento venda
        /// </summary>
        public string NSU_BANCO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// Meio captura venda (ELE)trônica / (MAN)ual / (ASS)inatura Arquivo
        /// </summary>
        public string MEIO_CAPTURA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// N° Terminal (meio  captura) emissor da venda
        /// </summary>
        public string NRO_TERMINAL { get; set; }
        
        /// <summary>
        /// N° Estabelecimento que efetuou a venda
        /// </summary>
        public int ESTABELECIMENTO { get; set; }
        
        /// <summary>
        /// N° Lote (vindo do POS ou PDV)
        /// </summary>
        public int NRO_LOTE_ORIGINAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_BRUTO_PARCELA_COMPRA { get; set; }
        
        /// <summary>
        /// Valor da parcela (adicionando o resto da divisão, se houver, no caso de ser a 1ª parcela) referente compra (se for parcelado)
        /// </summary>
        public int VLR_BRUTO_PARCELA_COMPRA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_VLR_LIQUIDO { get; set; }
        
        /// <summary>
        /// Valor da parcela da compra - Valor Tda Taxa Administrativa pró-rata - Valor da Taxa Financeira pró-rata (se houver antecipação)
        /// </summary>
        public int VLR_LIQUIDO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// PRC => Processada / PEN => Pendente / CAN => Cancelada / ANT => Antecipada
        /// </summary>
        public string STATUS_VENDA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// '+'  => valor à crédito  || '-' => valor à débito
        /// </summary>
        public string SINAL_VLR_LIQUIDO2 { get; set; }
        
        /// <summary>
        /// Valor da parcela (adicionando o resto da divisão, se houver, no caso de ser a 1ª parcela)  - Valor Tda Taxa Administrativa pró-rata - Valor da Taxa Financeira pró-rata (se houver antecipação)
        /// </summary>
        public int VLR_LIQUIDO_PARCELA2 { get; set; }

    }
}
