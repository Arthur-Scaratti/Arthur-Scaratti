
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_TITULO_COBRADOR_TMP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONTRATO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TITULO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_CLIENTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO_COBR { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_DOCUMENTO { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }

    }
}
