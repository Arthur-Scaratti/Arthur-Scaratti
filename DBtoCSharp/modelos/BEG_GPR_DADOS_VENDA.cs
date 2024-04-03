
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GPR_DADOS_VENDA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GPR_DADOS_VENDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_DADOS_VENDA_ID { get; set; }
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

        [NotMapped]
        public string Trigger_BEG_TRG_BI_GPR_DADOS_VENDA { get; set; } = `{"triggering_event":"INSERT","trigger_body":"BEGIN\n  INSERT INTO BEG_GPR_DV_PRD_DADO (BEG_GPR_DV_PRD_DADO_ID\n                                  ,AD_CLIENT_ID\n                                  ,AD_ORG_ID\n                                  ,ISACTIVE\n                                  ,CREATED\n                                  ,CREATEDBY\n                                  ,UPDATED\n                                  ,UPDATEDBY\n                                  ,BEG_GPR_DADOS_VENDA_ID\n                                  ,BEG_PRD_DADOS_VENDA_ID\n                                  )\n                           VALUES\n                                  (beg_fnc_ad_sequence('BEG_GPR_DV_PRD_DADO')\n                                  ,:NEW.AD_CLIENT_ID\n                                  ,:NEW.AD_ORG_ID\n                                  ,'Y'\n                                  ,SYSDATE\n                                  ,:NEW.CREATEDBY\n                                  ,SYSDATE\n                                  ,:NEW.UPDATEDBY\n                                  ,:NEW.BEG_GPR_DADOS_VENDA_ID\n                                  ,:NEW.BEG_PRD_DADOS_VENDA_ID\n                                  );\nEND;\n"}`;
    
    }
}
