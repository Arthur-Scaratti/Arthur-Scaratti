
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_GARANTIA
    {
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALORINI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALORFIN { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CODMAPHRE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CUSTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CODNOVO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECOANT { get; set; }

    }
}
