
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_GPR_FORN
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_GPR_FORN_ID { get; set; }
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
    [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BI_PRD_GPR_FORN { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n  insert into BEG_PRD_GPR_FORN_FORNEC (BEG_PRD_GPR_FORN_FORNEC_ID\n                                      ,AD_CLIENT_ID\n                                      ,AD_ORG_ID\n                                      ,ISACTIVE\n                                      ,CREATED\n                                      ,CREATEDBY\n                                      ,UPDATED\n                                      ,UPDATEDBY\n                                      ,BEG_PRD_GPR_FORN_ID\n                                      ,BEG_VW_FORNECEDOR_ID\n                                      )\n                               values\n                                      (beg_fnc_ad_sequence('BEG_PRD_GPR_FORN_FORNEC')\n                                      ,:NEW.AD_CLIENT_ID\n                                      ,:NEW.AD_ORG_ID\n                                      ,'Y'\n                                      ,sysdate\n                                      ,:NEW.CREATEDBY\n                                      ,sysdate\n                                      ,:NEW.UPDATEDBY\n                                      ,:new.beg_prd_gpr_forn_id\n                                      ,:new.BEG_VW_FORNECEDOR_ID\n                                      );\nend;"}`;
    
    }
}
