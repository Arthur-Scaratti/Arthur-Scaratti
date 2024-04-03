
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AGENCIASATIVAS
    {
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string COD { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_AG_NC { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string MUNIC_PIO { get; set; }

    }
}
