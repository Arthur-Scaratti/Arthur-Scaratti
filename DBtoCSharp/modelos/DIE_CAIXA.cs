
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAIXA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int NRMOV { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CDMOV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATAMOV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRCONTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRCONTA2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRCAIXA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRREGCHEQ { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CDGDES { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CDSDES { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CDGREC { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CDSREC { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CDHIST { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO2 { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO3 { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO4 { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO5 { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO6 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string NRBANCO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRARQUIVO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string PSERVICO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }

    }
}
