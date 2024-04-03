
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CONVENIO
    {
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAINI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAFIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAFAT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CARFAT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAVEN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CARVEN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MAXPAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMISSAO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS1 { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS2 { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS3 { get; set; }

    }
}
