
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CDL
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DEVEDOR { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CICCGC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTCONT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTVENC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VENCMAISAN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VENCMAISRE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALDOMIN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALDOMAX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREDOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTCREDORES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREDORPRI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ULTHISTORI { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string GRUPOHISTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ENTRMAISAN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ENTRMAISRE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string DISPONIBIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATACONTAT { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string COMISSIONA { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string DTULTOCORR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDIASULTH { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CLASSE { get; set; }
            [StringLength(113)]
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }

    }
}
