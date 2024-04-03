
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CALC_MC
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CALC_MC_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DIE_COD_ESTRUTURADO { get; set; }
            [StringLength(55)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_RESUMIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_GRUPO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_SUBGRUPO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_UNITARIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ITEM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_CUSTO_FINANCEIRO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_PIS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_COFINS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CUSTO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string USUARIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DEVOLUCAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_COMERCIAL_CLASS_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CLASS_SINT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIQ_DEVOL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_SESSION { get; set; }

    }
}
