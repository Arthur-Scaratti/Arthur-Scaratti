
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ITENS_CARTEIRA_VENDIDA
    {
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [StringLength(45)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRATO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string EMISSAO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CDPRODUTO { get; set; }
            [StringLength(150)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_UNITARIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_DESCONTO { get; set; }

    }
}
