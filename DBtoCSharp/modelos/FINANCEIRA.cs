
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class FINANCEIRA
    {
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string SIGLA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string RECEBEPGTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRATODV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MINDIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MAXDIG { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string PEDENOME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TAC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TARIFABANC { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEGURO { get; set; }

    }
}
