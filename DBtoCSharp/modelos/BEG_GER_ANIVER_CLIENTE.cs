
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_ANIVER_CLIENTE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_ANIVER_CLIENTE_ID { get; set; }
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
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string CD_FILIAL { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_ANIVER { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string DIAMES_NASC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_NASCIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IDADE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_ANIVER { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_CLIENTE { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string TELEFONES { get; set; }

    }
}
