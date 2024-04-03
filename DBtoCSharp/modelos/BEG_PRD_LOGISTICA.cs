
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_LOGISTICA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_MAX { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IMPRESSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_ETIQUETA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NF_ENTRADA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CONFERENTE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_LOGISTICA_ID { get; set; }
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
        public int PESO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTROLA_ESTOQUE_RESERVA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VOLUME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LOTE_RESUPRIMENTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTROLA_VALIDADE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTD_PALETE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTROLA_LOTE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LOTE_MULTIPLO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NRO_VOLUME { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ACEITA_NEGATIVO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AIUR_REPLICA_VOL { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  cursor busca_filhos is\n    SELECT *\n    FROM   beg_produto p \n    WHERE  p.die_vw_prd_pai_id = :NEW.beg_produto_id;\n  --\n  v_filhos    busca_filhos%rowtype;\n  PRAGMA AUTONOMOUS_TRANSACTION;\nBEGIN\n  OPEN busca_filhos;\n  loop\n    fetch busca_filhos INTO v_filhos;\n    exit WHEN busca_filhos%notfound;\n    UPDATE beg_prd_logistica l \n       SET l.nro_volume = :NEW.nro_volume\n    where  l.beg_produto_id = v_filhos.beg_produto_id;\n  END loop;\n  COMMIT;\nEND;"}`;
    
    }
}
