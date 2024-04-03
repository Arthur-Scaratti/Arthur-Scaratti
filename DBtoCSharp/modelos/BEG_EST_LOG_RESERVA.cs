
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_EST_LOG_RESERVA
    {
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_LOG_RESERVA_ID { get; set; }
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
    [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string MOVIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_VW_ALMOX_DESTINO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTD_MOVTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_MOVTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_ESTOQUE { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00005 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n\n\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIR_BEG_EST_LOG_RES { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  -- local variables here\n  cursor BUSCA_ESTOQUE is\n    select *\n      from BEG_ESTOQUE E\n     where E.BEG_EST_ALMOXARIFADO_ID = :new.BEG_EST_ALMOXARIFADO_ID\n       and E.BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n       and E.BEG_PRD_SKU_ID = :new.BEG_PRD_SKU_ID;\n  --\n  V_ESTOQUE BUSCA_ESTOQUE%rowtype;\nbegin\n  --\n  open BUSCA_ESTOQUE;\n  fetch BUSCA_ESTOQUE\n    into V_ESTOQUE;\n  close BUSCA_ESTOQUE;\n  --\n  :new.QTD_ESTOQUE := V_ESTOQUE.QTD;\nend BEG_TRG_BIR_BEG_EST_LOG_RES;\n"}`;
    
    }
}
