
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CLIENTES_SMS
    {
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DDD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FONE { get; set; }

    }
}
