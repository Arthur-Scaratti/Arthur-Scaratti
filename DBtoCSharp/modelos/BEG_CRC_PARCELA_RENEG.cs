
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_PARCELA_RENEG
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_PARCELA_RENEG_ID { get; set; }
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
        /// 
        /// </summary>
        public int PARCELA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VCTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_RENEGOCIACAO_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_BIU_TRG_PARCELA_RENEG { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare \n  cursor C1 is\n   select r.docstatus\n   from beg_crc_renegociacao r\n   where r.beg_crc_renegociacao_id = :NEW.Beg_Crc_Renegociacao_Id;\n   \n   R1 C1%rowtype;\n   \nbegin    \n    if updating and :new.dt_vcto <> :old.dt_vcto then\n    open C1;\n  fetch C1\n    into R1;\n  close C1;  \n  \n  \n    IF R1.DOCSTATUS = 'AP' THEN \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Renegociação ja aprovada nao permite alteração!');\n    END IF;         \n    end if;                 \n\n     if :NEW.DT_VCTO < TRUNC(SYSDATE) THEN \n        RAISE_APPLICATION_ERROR(-20001,\n                              'Data de vencimento não pode ser inferior ao dia de hoje!');\n    end if;\n\n  IF UPDATING THEN\n    \n     if :NEW.DT_VCTO <> :OLD.DT_VCTO and :new.parcela = 0 and :NEW.DT_VCTO < TRUNC(SYSDATE) then\n       RAISE_APPLICATION_ERROR(-20001,\n                              'Parcela entrada somente pode ser com vencimento para hoje!');\n     end if; \n    \n    IF :NEW.DT_VCTO > :OLD.DT_VCTO + 15 OR :NEW.DT_VCTO < :OLD.DT_VCTO - 15 THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Vcto somente pode ser prorrogado ou antecipado no máximo em 15 dias!');\n  END IF;\n    \n  END IF;\n\n\nend DIE_BIU_TRG_PARCELA_RENEG;\n"}`;
    
    }
}
