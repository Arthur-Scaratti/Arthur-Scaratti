
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class FORA_LINHA
    {
            [StringLength(98)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(98)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string MARCA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO_LIST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int POR { get; set; }

    }
}
