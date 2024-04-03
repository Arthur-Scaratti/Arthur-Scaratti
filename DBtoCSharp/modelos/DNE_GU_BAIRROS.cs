
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DNE_GU_BAIRROS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_REG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SIGLA_UF_BAI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_LOC_BAI_CEP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_LOC_BAI_DNE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NOME_OFIC_LOC_BAI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_BAI_CEP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CHV_BAI_DNE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NOME_OFIC_BAI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ABRV_BAI_ECT { get; set; }

    }
}
