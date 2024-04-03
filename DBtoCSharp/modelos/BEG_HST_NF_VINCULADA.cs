
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_HST_NF_VINCULADA
    {
            [Required]
    [Key]
        /// <summary>
        /// Id da NFs vinculadas
        /// </summary>
        public int BEG_HST_NF_VINCULADA_ID { get; set; }
            [Required]
        /// <summary>
        /// Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo  - yes ou no
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// Data da criacao do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da ultima alteracao
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que fez a ultima alteracao
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// Id da NF de saida
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
        
        /// <summary>
        /// Id do item da NF de saida
        /// </summary>
        public int BEG_FAT_NFS_ITEM_ID { get; set; }
        
        /// <summary>
        /// Id da NF de entrada
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// Id do item da NF de entrada
        /// </summary>
        public int BEG_CPR_NFE_ITEM_ID { get; set; }
        
        /// <summary>
        /// Id do hist.da nota fiscal
        /// </summary>
        public int BEG_HST_NOTA_FISCAL_ID { get; set; }
        
        /// <summary>
        /// Quantidade de item movimentado nesta transacao
        /// </summary>
        public int QTD { get; set; }

        [NotMapped]
        public string Trigger_BEG_BIUD_HST_NF_VINCULADA { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"BEGIN\n  IF INSERTING THEN\n\n    UPDATE BEG_HST_NOTA_FISCAL N\n       SET N.QTD_FALTANTE  = N.QTD_FALTANTE - :NEW.QTD,\n           N.QTD_DEVOLVIDA = N.QTD_DEVOLVIDA + :NEW.QTD\n     WHERE N.BEG_HST_NOTA_FISCAL_ID = :NEW.BEG_HST_NOTA_FISCAL_ID;\n\n  END IF;\n\n\n   IF DELETING  THEN\n\n    UPDATE BEG_HST_NOTA_FISCAL N\n       SET N.QTD_FALTANTE  = N.QTD_FALTANTE + :OLD.QTD,\n           N.QTD_DEVOLVIDA = N.QTD_DEVOLVIDA - :OLD.QTD\n     WHERE N.BEG_HST_NOTA_FISCAL_ID = :OLD.BEG_HST_NOTA_FISCAL_ID;\n\n  END IF;\n\nEND BEG_BID_HST_NF_VINCULADA;\n"}`;
    
    }
}
