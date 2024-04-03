
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PRD_TESTE
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTROLA_VOLTAGEM { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string MODELO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTROLA_COR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_VOLTAGEM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_UNIDADE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_MARCA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_FABRICANTE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_TIPO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_COR_ID { get; set; }
            [Required]
    [StringLength(55)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_RESUMIDA { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_DETALHADA { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCIA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string BTN_VALIDA_PRODUTO { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string DIE_COD_PRODUTO { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DIE_COD_ESTRUTURADO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_GRUPO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_SUBGRUPO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_VW_PRD_PAI_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CEL_PLANO_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_IMPORTADO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_SERIAL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ESPECIAL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ENCOMENDA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_RESERVADO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_MANUAL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_TESTE { get; set; }

    }
}
