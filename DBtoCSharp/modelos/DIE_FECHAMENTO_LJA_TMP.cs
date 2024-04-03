
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FECHAMENTO_LJA_TMP
    {
        
        /// <summary>
        /// Codigo do cliente
        /// </summary>
        public int CODCLI { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FECHAMENTO_LJA_TMP_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da loja
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
        /// Id da sessão usada
        /// </summary>
        public int AD_SESSION_ID { get; set; }
        
        /// <summary>
        /// Local  da loja
        /// </summary>
        public int LOCALPG { get; set; }
        
        /// <summary>
        /// Valor do faturamento DBF
        /// </summary>
        public int VLR_FATUR_DBF { get; set; }
        
        /// <summary>
        /// Valor da baixa DBF
        /// </summary>
        public int VLR_BAIXA_DBF { get; set; }
        
        /// <summary>
        /// Valor do faturamento Oracle
        /// </summary>
        public int VLR_FATUR_ORA { get; set; }
        
        /// <summary>
        /// Valor da baixa Oracle 
        /// </summary>
        public int VLR_BAIXA_ORA { get; set; }
        
        /// <summary>
        /// Diferença do faturamento (vlr_fatur_dbf - vlr_fatur_ora)
        /// </summary>
        public int VLR_DIFER_FAT { get; set; }
        
        /// <summary>
        /// Diferenca da baixa (vlr_baixa_dbf - vlr_baixa_ora)
        /// </summary>
        public int VLR_DIFER_BAI { get; set; }
        
        /// <summary>
        /// Id da pessoa (quando solicitado por pessoa ou por titulo)
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// contrato  (numero do titulo)
        /// </summary>
        public string CONTRATO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// nao usado
        /// </summary>
        public string DEVOL_DBF { get; set; }
            [StringLength(1)]
        /// <summary>
        /// nao usado
        /// </summary>
        public string DEVOL_ORA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// serie da suplicara - dbf
        /// </summary>
        public string SRDUP { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// classificacao usada na emissao do titulo - dbf
        /// </summary>
        public string CLASSIF { get; set; }
        
        /// <summary>
        /// nao usado
        /// </summary>
        public int PARCELA { get; set; }
            [Required]
        /// <summary>
        /// Abrir os titulos (s/n)
        /// </summary>
        public string ABRIR_TITULO { get; set; }
            [Required]
        /// <summary>
        /// Data inicial do movimento
        /// </summary>
        public string DT_MOVTO { get; set; }
        
        /// <summary>
        /// Listar somente as diferençcas
        /// </summary>
        public string SOMENTE_DIF { get; set; }
            [StringLength(1)]
        /// <summary>
        /// tipo do relatorio (F)aturamento, (B)aixa e (A)mmbos
        /// </summary>
        public string TIPO_REL { get; set; }
        
        /// <summary>
        /// Local emissao titulo
        /// </summary>
        public int LOCAL { get; set; }
        
        /// <summary>
        /// Tipo do registro
        /// </summary>
        public int TIPO_REG { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Descricao do registro
        /// </summary>
        public string DESC_REG { get; set; }

    }
}
