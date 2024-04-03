
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_EST_LOJAS_TMP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_VENDA_60DIAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
        
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
        public int QTD_VENDA_30DIAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VENDA_30DIAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_VENDA_90DIAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_ASSISTENCIA { get; set; }
        
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
        public int CLASSIF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_SESSION_ID { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string MARCA { get; set; }

    }
}
