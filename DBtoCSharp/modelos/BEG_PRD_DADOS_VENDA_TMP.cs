
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_DADOS_VENDA_TMP
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_DADOS_VENDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_DADOS_VENDA_VAL_ID { get; set; }
            [Required]
    [StringLength(35)]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string APP_SESSION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ATUALIZACAO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BU_DADOS_VENDA { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"begin\n  if NVL(:NEW.BEG_PRD_DADOS_VENDA_VAL_ID, 10000000000) <>\n     NVL(:OLD.BEG_PRD_DADOS_VENDA_VAL_ID, 10000000000) then\n    BEG_PCK_APEX_FORN.PRC_ATUALIZA_DADOS_PRD(P_BEG_PRODUTO_ID             => :NEW.BEG_PRODUTO_ID\n                                            ,P_BEG_PRD_DADOS_VENDA_ID     => :NEW.BEG_PRD_DADOS_VENDA_ID\n                                            ,P_BEG_PRD_DADOS_VENDA_VAL_ID => :NEW.BEG_PRD_DADOS_VENDA_VAL_ID /*\n                                                                                                                                      ,P_APP_USER                   => V('APP_USER')*/);\n  end if;\nend BEG_TRG_BU_DADOS_VENDA;\n"}`;
    
    }
}
