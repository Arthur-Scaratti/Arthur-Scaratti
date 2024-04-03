
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DNE_GU_LOCALIDADES
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_REG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SIGLA_PAIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SIGLA_UF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_LOC_CEP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CHV_LOC_DNE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NOME_OFIC_LOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CEP_LOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ABRV_LOC_ECT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_LOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SIT_LOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_SUB_LOC_CEP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHV_SUB_LOC_DNE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SIGLA_DR_ECT_LOC { get; set; }

    }
}
