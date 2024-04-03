
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_NOTAS_EZA
    {
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRNF { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CNPJFILIAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DESTINATARIO_CNPJ { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_CONTABIL { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_NOTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASE_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASE_ST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_ST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ACRESCIMO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IPI { get; set; }

    }
}
