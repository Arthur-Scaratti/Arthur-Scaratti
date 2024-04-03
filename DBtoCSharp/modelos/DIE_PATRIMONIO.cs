
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PATRIMONIO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PATRIMONIO_ID { get; set; }
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
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
        public int BEG_GPR_DADOS_VENDA_ID { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string MARCA { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string MODELO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTCOMPRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLCOMPRA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_SERIE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_COMPLETO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_DIE_PATRIMONIO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n\n if length(:new.value) > 5 then\n   \n    raise_application_error(-20501,'Numero do patrimonio nao pode conter mais de cinco digitos. Verifique!!');\n   \n\n end if;\n\n\n  :new.value :=  lpad(:new.value,5,0);\n\nend;\n"}`;
    
    }
}
