
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class MOVBAN
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
        public string DTCOMPEN { get; set; }
        
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
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRCHEQUE { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DTLANCAM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTIDENTIF { get; set; }

    }
}
