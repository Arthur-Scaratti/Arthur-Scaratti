
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_UF
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQ_FUNDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UF_IBGE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQ_INTERNA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_UF_ID { get; set; }
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
            [Required]
    [StringLength(50)]
        /// <summary>
        /// Descricao da uf
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// Abreviatura do estado
        /// </summary>
        public string ABREVIATURA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PAIS_ID { get; set; }
        
        /// <summary>
        /// codigo do ibge
        /// </summary>
        public int CODIGO_IBGE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQ_INTEREST { get; set; }

    }
}
