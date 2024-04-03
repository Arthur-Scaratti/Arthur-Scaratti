
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_POS_COMIS_SERV
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_POS_COMIS_SERV_ID { get; set; }
        
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
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_POSICAO { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SALDO_FINAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SALDO_ANTERIOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PAGTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_NOTAS { get; set; }

    }
}
