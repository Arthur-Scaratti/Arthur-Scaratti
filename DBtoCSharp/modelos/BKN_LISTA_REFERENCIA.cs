
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BKN_LISTA_REFERENCIA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BKN_LISTA_REFERENCIA_ID { get; set; }
        
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
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_SUP_LISTA_FORNECEDOR_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCIA { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_LISTA_REFERENCIA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n\n  CURSOR C1 IS\n    select *\n      from beg_sup_lista_fornecedor a\n     where a.beg_sup_lista_fornecedor_id = :NEW.BEG_SUP_LISTA_FORNECEDOR_ID;\n  R1 C1%ROWTYPE;\n\nBEGIN\n\n  OPEN C1;\n  fetch C1\n    INTO R1;\n  CLOSE C1;\n\n  IF R1.ISACTIVE = 'N' THEN\n  \n    RAISE_APPLICATION_ERROR(-20001,\n                            'Somente permitido incluir ou alterar referencias de produtos ativos na lista do fornecedor');\n  \n  END IF;\n\nEND DIE_TRG_BIU_LISTA_REFERENCIA;\n"}`;
    
    }
}
