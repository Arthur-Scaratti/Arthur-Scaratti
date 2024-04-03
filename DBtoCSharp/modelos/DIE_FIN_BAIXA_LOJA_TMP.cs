
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_BAIXA_LOJA_TMP
    {
            [StringLength(3)]
        /// <summary>
        /// CODIGO DA FILIAL
        /// </summary>
        public string COD_FIL { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// id da tabela de baixa da loja (temp)
        /// </summary>
        public int DIE_FIN_BAIXA_LOJA_TMP_ID { get; set; }
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
        /// 1 . Entrada 2.pgtos loja    3. pgtos outras lojas 4.Entrada Antecipada
        /// </summary>
        public int TIPO_REG { get; set; }
        
        /// <summary>
        /// Valor do titulo
        /// </summary>
        public int VLR_TITULO { get; set; }
        
        /// <summary>
        /// Valor do juros
        /// </summary>
        public int VLR_JUROS { get; set; }
        
        /// <summary>
        /// Valor do desconto
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// Valor do pagamento
        /// </summary>
        public int VLR_PAGO { get; set; }
        
        /// <summary>
        /// Data de pagamento
        /// </summary>
        public string DT_PGTO { get; set; }
        
        /// <summary>
        /// Quantidade de titulos
        /// </summary>
        public int QTDE_TIT { get; set; }
        
        /// <summary>
        /// id da sessao de processamento do relatorio
        /// </summary>
        public int AD_SESSION_ID { get; set; }
        
        /// <summary>
        /// Id fo titpo do titulo
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// Id do tipo de movto
        /// </summary>
        public int BEG_CRC_TPMOV_ID { get; set; }

    }
}
