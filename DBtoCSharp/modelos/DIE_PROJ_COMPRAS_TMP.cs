
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PROJ_COMPRAS_TMP
    {
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string MARCA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO_ESTRUTURADO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string SUBGRUPO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string UNIDADE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VENDAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VENDA_30DIAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_VENDA_7DIAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VENDA_7DIAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DISPONIVEL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_DEPOSITOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RESERVAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_LOJAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CUSTO_FINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_COMPRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TRANSITO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CLASSIF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_SESSION_ID { get; set; }

    }
}
