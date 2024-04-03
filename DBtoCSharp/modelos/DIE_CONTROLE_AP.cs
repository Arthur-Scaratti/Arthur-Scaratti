
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CONTROLE_AP
    {
        
        /// <summary>
        /// Id da nota fiscal de saida
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CLIENTE_ID { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_SORTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONTADOR { get; set; }

    }
}
