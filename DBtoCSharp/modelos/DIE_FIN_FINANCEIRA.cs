
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_FINANCEIRA
    {
            [Required]
    [Key]
        /// <summary>
        /// Id da financeira
        /// </summary>
        public int DIE_FIN_FINANCEIRA_ID { get; set; }
            [Required]
        /// <summary>
        /// Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// Codigo gerado pela Diementz
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Data criacao do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Quem fez a criação
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da ultima alteracao no registro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Quem fez a ultima atualizacao
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
    [StringLength(5)]
        /// <summary>
        /// Sigla - Nome abreviado
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// Indica se recebe pagamento
        /// </summary>
        public string IND_RECEBEPGTO { get; set; }
        
        /// <summary>
        /// Indica .....
        /// </summary>
        public string IND_CONTRATODV { get; set; }
        
        /// <summary>
        /// Indica para abrir campo para informar nome do cliente no pagamento
        /// </summary>
        public string IND_PEDNOME { get; set; }
        
        /// <summary>
        /// Numero minimo de digitos do contrato para recebimento de pagamento 
        /// </summary>
        public int MINDIG { get; set; }
        
        /// <summary>
        /// Numero máximo de digitos do contrato para recebimento de pagamento
        /// </summary>
        public int MAXDIG { get; set; }
        
        /// <summary>
        /// Taxa financeira inclusa no valor final do contrato
        /// </summary>
        public int VL_TAC { get; set; }
        
        /// <summary>
        /// Valor do seguro de crédito
        /// </summary>
        public int VL_SEGURO { get; set; }
        
        /// <summary>
        /// Tarifa bancaria sobre cada parcela do financiamento
        /// </summary>
        public int VL_TARIFA_BANCO { get; set; }
            [Required]
        /// <summary>
        /// Id do parceiro comercial referente a esta financeira
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// Nr de Dias minimo para a 1ª parcela
        /// </summary>
        public int DIAS_MINIMO { get; set; }
        
        /// <summary>
        /// Nr de Dias maximo para a 1ª parcela
        /// </summary>
        public int DIAS_MAXIMO { get; set; }

    }
}
