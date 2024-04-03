
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ACAO_FGTS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int FILIAL { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string PARCEIRO { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_NASC { get; set; }
            [StringLength(29)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_TITUL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VENC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONT_ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ATRASO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_CORRIG { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string LIBERADO_P { get; set; }

    }
}
