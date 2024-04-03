
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CTB_PISCOFINS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CTB_PISCOFINS_ID { get; set; }
        
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
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_FIM { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_VENDA { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string NOTAS_FISCAIS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTADO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_NOTAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NF_FIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS { get; set; }

    }
}
