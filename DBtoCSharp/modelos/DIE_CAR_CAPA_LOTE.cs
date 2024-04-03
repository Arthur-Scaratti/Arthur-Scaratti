
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAR_CAPA_LOTE
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TAXA_ADM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERCENTUAL_TAXA_FIN { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SINAL_VLR_TAXA_FIN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TAXA_FIN { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SINAL_VLR_LIQ_PARC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIQ_PARC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BANCO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AGENCIA { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTA_CORRENTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_VENDAS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_CREDITO_DEBITO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_VENDAS_REJEITADAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_LOTE_ORIGINAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IDENTIFICADOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IND_JUROS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string FORMA_PAGTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SINAL_VLR_DIF_BRUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DIF_BRUTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SINAL_VLR_DIF_BRUTO2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DIF_BRUTO2 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SINAL_VLR_LIQ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DIF_LIQ { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SINAL_DIF_VLR_LIQ2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DIF_LIQ2 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_CAPA_LOTE_ID { get; set; }
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
        public int TP_REGISTRO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COD_LOJA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TP_LOTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_LOTE { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_PARCELA_TOT_PARC { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_REMESSA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PROCESSAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PROGRAMADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CREDITO_DEBITO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SINAL_BRUTO_PARC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BRUTO_PARC { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SINAL_VLR_REJEITADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_REJEITADO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SINAL_VLR_PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERCENTUAL_TAXA_ADM { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SINAL_VLR_TAXA_ADM { get; set; }

    }
}
