
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIS_TRIB_ICMS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_TRIB_ICMS_ID { get; set; }
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
        public string COD_TRIB_ICMS { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCR_TRIB_ICMS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string REDUCAO { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FIS_TRIB_ICMS { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n    ISVALID   boolean;   \nbegin\n    ISVALID := REGEXP_LIKE(:new.COD_TRIB_ICMS,'^[0-9]{2}$');\n    if (not ISVALID) then\n        RAISE_APPLICATION_ERROR(-20002,'A mascara do codigo da tributac?o do ICMS e (99) dois digitos numericos - VERIFIQUE!');\n    end if;\nend trg_biu_beg_fis_trib_icms;\n"}`;
    
    }
}
