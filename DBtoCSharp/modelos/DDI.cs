
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DDI
    {
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string PAIS { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string ACESSO_DDI { get; set; }

    }
}
