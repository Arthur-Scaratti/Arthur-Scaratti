
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class NOP_DBF
    {
            [StringLength(4)]
        /// <summary>
        /// Codigo da natureza de operacao
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Descricao
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTOQUE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERCICM { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string FATURA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string COMISSAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTATISTIC { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIPI { get; set; }

    }
}
