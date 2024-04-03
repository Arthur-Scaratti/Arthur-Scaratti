
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PRODUTO_DBF
    {
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CDPRODUTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SUBGRUPO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO2 { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string MARCA { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string UNIDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VOLUMES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PESO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECOVVANT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECOVPANT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO3 { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTR_COR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string EST_MAXIMO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUSPRO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA3 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO4 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA4 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO5 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA5 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUOLD { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string LISTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int REDUCAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TPICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTMOVIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTGERADO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LINHAPRO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string GARFABRICA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SUB1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LIQUIDADO { get; set; }

    }
}
