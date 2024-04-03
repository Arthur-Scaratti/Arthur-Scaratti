
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_INDICADORES_VEND
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_INDICADORES_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
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
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DEVOLUCAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_AP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_GAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_IT_VEN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_IT_DEV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_AP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_GAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_RECEITAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CMV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VENDA_LIQUIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LUCRO_BRUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PISCOFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FILIAL { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string USUARIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_VENDAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int META { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CATEGORIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_SESSION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PARC_ADM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PARC_ESTAB { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_CR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_CR_ADM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LUCRO_BRUTO_ATIVOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VENDA_LIQUIDA_ATIVOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FINAL { get; set; }

    }
}
