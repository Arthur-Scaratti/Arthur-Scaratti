
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PCE_PORTADOR_PGTO
    {
            [Required]
    [Key]
        /// <summary>
        /// Id dos parametros de pagamento por portador
        /// </summary>
        public int BEG_PCE_PORTADOR_PGTO_ID { get; set; }
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
        /// <summary>
        /// Codigo do convenio para pagamento escritural
        /// </summary>
        public int COD_CONVENIO { get; set; }
            [Required]
        /// <summary>
        /// Id do Portador
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do codigo de remessa de pagamento
        /// </summary>
        public int BEG_PCE_COMANDO_REM_PAG_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AIUD_FIN_PORT_PGTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\nbegin\n  if INSERTING then\n    update BEG_FIN_PORTADOR\n       set IND_PGTO_ESCR = 'Y'\n     where BEG_FIN_PORTADOR_ID = :new.BEG_FIN_PORTADOR_ID;\n  end if;\n  --\n  if DELETING then\n    update BEG_FIN_PORTADOR\n       set IND_PGTO_ESCR = 'N'\n     where BEG_FIN_PORTADOR_ID = :old.BEG_FIN_PORTADOR_ID;\n  end if;\n  --\n  if UPDATING then\n    if :new.ISACTIVE != :old.ISACTIVE then\n      update BEG_FIN_PORTADOR\n         set IND_PGTO_ESCR = :new.ISACTIVE\n       where BEG_FIN_PORTADOR_ID = :new.BEG_FIN_PORTADOR_ID;\n    end if;\n  end if;\n\nend BEG_TRG_AIUD_FIN_PORT_PGTO;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_FIN_PORT_PGTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  --\n  if :new.ad_org_id = 0 then\n    RAISE_APPLICATION_ERROR(-20001,'Faltou informar Filial');\n  end if;\n  --\nend;\n"}`;
    
    }
}
