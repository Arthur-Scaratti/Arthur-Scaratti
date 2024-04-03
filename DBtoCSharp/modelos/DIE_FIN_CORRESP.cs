
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_CORRESP
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_CORRESP_ID { get; set; }
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
        /// Data do movimento
        /// </summary>
        public string DATA { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// WC, CO
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// Total Acumulado do movimento
        /// </summary>
        public int VALORTOTAL { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_FIN_CORRESP { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"BEGIN\n\n\nIF DELETING AND :OLD.DOCSTATUS ='CO' THEN\n  RAISE_APPLICATION_ERROR(-20001,'Lote ja encerrado não permite exclusão');\n\nEND IF;\n\n\n/*\nIF UPDATING AND :OLD.DOCSTATUS ='CO' THEN\n  RAISE_APPLICATION_ERROR(-20001,'Lote ja encerrado não permite exclusão');\n\nEND IF;*/\n\n\n\nEND DIE_TRG_BIUD_FIN_CORRESP;\n"}`;
    
    }
}
