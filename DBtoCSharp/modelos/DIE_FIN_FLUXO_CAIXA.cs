
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_FLUXO_CAIXA
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_FLUXO_CAIXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DIA { get; set; }
            [Required]
        /// <summary>
        /// Valores a pagar de duplicatas de compras ja lancadas
        /// </summary>
        public int VLR_DUPLICATA { get; set; }
            [Required]
        /// <summary>
        /// Valores a pagar de duplicatas de impostos, e demais obrigacoes ja lancadas
        /// </summary>
        public int VLR_OBRIGACAO { get; set; }
            [Required]
        /// <summary>
        /// Valores a receber de vendas a prazo ja emitidas
        /// </summary>
        public int VLR_RECEBER { get; set; }
            [Required]
        /// <summary>
        /// Previsao de valores de vendas
        /// </summary>
        public int VLR_VENDA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SUBTOTAL { get; set; }
            [Required]
        /// <summary>
        /// Previsao de valores de compras a partir de OC aprovadas no sistema
        /// </summary>
        public int VLR_PED_COMP { get; set; }
            [Required]
        /// <summary>
        /// Previsao de obrigacoes futuras conforme tabela 
        /// </summary>
        public int VLR_OBR_FUT { get; set; }
            [Required]
        /// <summary>
        /// Previsao de parcelas a receber de vendas a prazo futuras
        /// </summary>
        public int VLR_REC_PREV { get; set; }

    }
}
