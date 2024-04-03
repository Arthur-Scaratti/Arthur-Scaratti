
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_ADTO_MVTO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_ADTO_MVTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TITULO_ID { get; set; }
        
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TITULO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_MOVIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TPMOV_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MOVIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string CHEQUE { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NR_LOTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_BASE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NR_ADTO { get; set; }

    }
}
