
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DEPARA_MOTORISTA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DE_CODIGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARA_CODIGO { get; set; }
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

    }
}
