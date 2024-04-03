
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CPG_PREVISAO_TIT
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CPG_PREVISAO_TIT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
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
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PGTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TITULO { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string INSTR_PAGTO { get; set; }

        [NotMapped]
        public string Trigger_DIE_BI_CPG_PREVISAO_TIT { get; set; } = `{"triggering_event":"INSERT","trigger_body":"BEGIN\n\n\n :NEW.VALUE := :NEW.DIE_CPG_PREVISAO_TIT_ID;\n\n END;\n"}`;
    
    }
}
