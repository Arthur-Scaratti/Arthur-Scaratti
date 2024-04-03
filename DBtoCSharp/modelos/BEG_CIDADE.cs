
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CIDADE
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MUN_IBGE { get; set; }
        
        /// <summary>
        /// codigo IBGE
        /// </summary>
        public int CODIGO_IBGE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID da cidade
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
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
    [StringLength(80)]
        /// <summary>
        /// Nome da cidade
        /// </summary>
        public string DESCRICAO { get; set; }
        
        /// <summary>
        /// Codigo do cep
        /// </summary>
        public string CEP { get; set; }
        
        /// <summary>
        /// ID da UF
        /// </summary>
        public int BEG_UF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TRANSPORTADORA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_ATUALIZA_UF_CIDADE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  cursor C1 is\n    select U.value from BEG_UF U where U.BEG_UF_ID = :new.BEG_UF_ID;\nbegin\n  open C1;\n  fetch C1\n    into :new.UF;\n  close C1;\n\nend;\n"}`;
    
    }
}
