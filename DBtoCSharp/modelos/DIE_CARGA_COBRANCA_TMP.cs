
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CARGA_COBRANCA_TMP
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NRODOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CODFIL { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string ERRO { get; set; }

    }
}
