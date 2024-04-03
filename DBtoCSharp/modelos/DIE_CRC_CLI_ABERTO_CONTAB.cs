
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_CLI_ABERTO_CONTAB
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_CLI_ABERTO_CONTAB_ID { get; set; }
        
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
        public int COD_FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_POSICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRATO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string PARCELA { get; set; }
        
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
        public int VALOR_ABERTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_TITULO { get; set; }

    }
}
