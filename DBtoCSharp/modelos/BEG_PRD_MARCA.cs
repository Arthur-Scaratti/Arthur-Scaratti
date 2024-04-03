
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_MARCA
    {
            [Required]
    [Key]
        /// <summary>
        /// ID da marca
        /// </summary>
        public int BEG_PRD_MARCA_ID { get; set; }
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
    [StringLength(30)]
        /// <summary>
        /// Descrição da marca
        /// </summary>
        public string DESCRICAO { get; set; }

        [NotMapped]
        public string Trigger_TRG_BI_BEG_PRD_MARCA { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n  :new.DESCRICAO := UPPER(:new.DESCRICAO);\n/*\n  open C1;\n  fetch C1\n    into WLIXO;\n  if C1%found then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Ja existe registro com a Marca descrita... Verifique!');\n  end if;\n*/\nend TRG_BI_BEG_PRD_MARCA;\n"}`;
    
    }
}
