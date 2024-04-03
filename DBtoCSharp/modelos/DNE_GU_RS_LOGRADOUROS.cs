
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DNE_GU_RS_LOGRADOUROS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_REG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SIGLA_UF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_LOC_CEP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_LOC_DNE { get; set; }
            [StringLength(72)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_OFIC_LOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_BAI_INIC_CEP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_BAI_INIC_DNE { get; set; }
            [StringLength(72)]
        /// <summary>
        /// 
        /// </summary>
        public string BAI_INIC_LOG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_BAI_FINAL_CEP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_BAI_FINAL_DNE { get; set; }
            [StringLength(72)]
        /// <summary>
        /// 
        /// </summary>
        public string BAI_FINAL_LOG { get; set; }
            [StringLength(26)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_OFIC_LOG { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string PREP { get; set; }
            [StringLength(72)]
        /// <summary>
        /// 
        /// </summary>
        public string TIT_PAT_OFIC_LOG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_LOG_CEP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_LOG_DNE { get; set; }
            [StringLength(72)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_OFIC_LOG { get; set; }
            [StringLength(36)]
        /// <summary>
        /// 
        /// </summary>
        public string ABRV_LOG_ECT { get; set; }
            [StringLength(36)]
        /// <summary>
        /// 
        /// </summary>
        public string INFO_ADIC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CEP_LOG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string INDIC_GU_LOG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NUM_LOT_DNE { get; set; }
            [StringLength(36)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_COMPL_1 { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string NUM_LETRA_COMPL_1 { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_COMPL_2 { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string NUM_LETRA_COMPL_2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_LOTE_DNE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_COMPL_1_DNE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_COMPL_2_DNE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SEPARADOR { get; set; }

    }
}
