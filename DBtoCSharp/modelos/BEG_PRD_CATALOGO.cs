
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_CATALOGO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_CATALOGO_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FINAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PRECO_OBRIGATORIO { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// Descricao  resumida - palm
        /// </summary>
        public string DESC_RESUMIDA { get; set; }

        [NotMapped]
        public string Trigger_TRG_BD_BEG_PRD_CATALOGO { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\nbegin\n  delete from BEG_PRD_CATALOGO_PRODUTO\n   where BEG_PRD_CATALOGO_ID = :old.BEG_PRD_CATALOGO_ID;\n\nend TRG_BD_BEG_PRD_CATALOGO;\n"}`;
    
    }
}
