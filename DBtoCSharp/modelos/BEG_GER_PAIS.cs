
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_PAIS
    {
            [Required]
    [StringLength(3)]
        /// <summary>
        /// Sigla internacional do país
        /// </summary>
        public string SIGLA { get; set; }
            [Required]
        /// <summary>
        /// Zona do código DDI do país
        /// </summary>
        public int ZONA_DDI { get; set; }
            [Required]
    [StringLength(7)]
        /// <summary>
        /// Código DDI do país - zero indica zona
        /// </summary>
        public string DDI { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do país
        /// </summary>
        public int BEG_GER_PAIS_ID { get; set; }
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
        /// Código do país
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// Nome do país
        /// </summary>
        public string NAME { get; set; }

    }
}
