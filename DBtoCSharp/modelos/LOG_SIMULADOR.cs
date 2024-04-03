
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class LOG_SIMULADOR
    {
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }

    }
}
