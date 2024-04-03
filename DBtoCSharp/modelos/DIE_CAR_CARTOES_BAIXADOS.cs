
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAR_CARTOES_BAIXADOS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_BAIXADOS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_FILIAL { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CDDUPL { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRNF { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CDCARTAO { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREDITO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_VENDA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_INICIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_FINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTVENCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTPAGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SEQUENCIA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_TAXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_SESSION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MODALIDADE { get; set; }

    }
}
