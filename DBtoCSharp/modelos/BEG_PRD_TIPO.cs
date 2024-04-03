
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_TIPO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_TIPO_ID { get; set; }
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
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica serviço
        /// </summary>
        public string IND_SERVICO { get; set; }

        [NotMapped]
        public string Trigger_TRG_BI_BEG_PRD_TIPO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  cursor c1 is\n  select 1 from beg_prd_tipo where upper(descricao) = upper(:new.descricao)\n  and ad_client_id = :new.ad_client_id;\n  wlixo number(1);\nbegin\n  open c1;\n  fetch c1 into wlixo;\n  if c1%found then\n      RAISE_APPLICATION_ERROR(-20001,'Ja existe registro com o tipo descrito... Verifique!');\n  end if;\nend trg_bi_beg_prd_tipo;\n"}`;
    
    }
}
