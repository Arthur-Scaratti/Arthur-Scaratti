
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CHK_LIST_ITEM
    {
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string ACAO { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string COMO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string RESPONSAVEL { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_NOVA_ANALISE { get; set; }
        
        /// <summary>
        /// Data que foi concluido o processo
        /// </summary>
        public string DT_CONCLUSAO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do ITEM do check list
        /// </summary>
        public int DIE_CHK_LIST_ITEM_ID { get; set; }
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
            [StringLength(500)]
        /// <summary>
        /// Descricao completa da causa
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
        /// <summary>
        /// ID TIPO 
        /// </summary>
        public int DIE_TIPO_CHK_LIST_ID { get; set; }
            [Required]
        /// <summary>
        /// ID DO CHECKL IST
        /// </summary>
        public int DIE_CHK_LIST_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// indicativo de conformidade do item 
        /// </summary>
        public string IND_CONFORME { get; set; }
        
        /// <summary>
        /// valor de meta do indicador
        /// </summary>
        public int VLR_META { get; set; }
        
        /// <summary>
        /// valor de projecao do indicador
        /// </summary>
        public int VLR_PROJECAO { get; set; }
        
        /// <summary>
        /// valor realizado do indicador ate o dia da visista
        /// </summary>
        public int VLR_REALIZADO { get; set; }
        
        /// <summary>
        /// data final para conformidade do item
        /// </summary>
        public string DT_FINAL { get; set; }

    }
}
