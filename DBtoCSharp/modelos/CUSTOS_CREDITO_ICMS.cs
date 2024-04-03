
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CUSTOS_CREDITO_ICMS
    {
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string UNIDADE_ME { get; set; }
            [StringLength(42)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int N_CUSTO_ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int N_TOTAL_IT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int N_N__NF_ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int N_BASE_C_L { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CREDIT { get; set; }

    }
}
