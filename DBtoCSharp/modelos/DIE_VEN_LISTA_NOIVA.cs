
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VEN_LISTA_NOIVA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_VEN_LISTA_NOIVA_ID { get; set; }
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
            [StringLength(40)]
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
        public string DT_CASAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENCERRAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PREPOSTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COMISSAO_PAGA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COMISSAO_PREPOSTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_VOLTAGEM_ID { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_UF_ID { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_BIU_VEN_LISTA_NOIVA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n\n\n\n     if  :new.DT_CASAMENTO < trunc(sysdate) then\n\n        RAISE_APPLICATION_ERROR(-20002,'Data do casamento não pode ser menor que dia de hoje. Verifique!!!');\n     end if;\n\n\nend;\n"}`;
    
    }
}
