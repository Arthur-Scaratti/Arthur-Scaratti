
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_BAIXA_DEV_ORIGEM
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_BAIXA_DEV_ORIGEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_BAIXA_DEV_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BAIXAR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ESTORNO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_CPG_BAIXA_DEV_ORIGEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n  CURSOR C1 IS\n    SELECT B.VLR_ABERTO\n      FROM BEG_CPG_TITULO B\n     WHERE B.BEG_CPG_TITULO_ID = :NEW.BEG_CPG_TITULO_ID;\n\nBEGIN\n  --\n  OPEN C1;\n  FETCH C1 INTO :NEW.VLR_ABERTO;\n  CLOSE C1;\n  --\nEND;\n"}`;
    
    }
}
