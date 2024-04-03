
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_DIST_LINHA_SOLICITACAO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_DIST_LINHA_SOLICITACAO_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_DIST_SOLICITACAO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FATURAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENVIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_RECEBIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FILIAL_SOLICITANTE_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_PROPOSTA { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIUR_DIST_LIN_SOL { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  CURSOR Busca_Dados IS\n    SELECT Ad_Client_Id,\n           Ad_Org_Id\n      FROM Beg_Apex_User a\n     WHERE a.Ad_User_Id = :NEW.Createdby;\n  --\n  r_Busca_Dados Busca_Dados%ROWTYPE;\n  --       \nBEGIN\n  IF Inserting THEN\n    OPEN Busca_Dados;\n    FETCH Busca_Dados\n      INTO r_Busca_Dados;\n    CLOSE Busca_Dados;\n    :NEW.Ad_Client_Id := r_Busca_Dados.Ad_Client_Id;\n    :NEW.Ad_Org_Id    := r_Busca_Dados.Ad_Org_Id;\n    :NEW.Updatedby    := :NEW.Createdby;\n    :NEW.Updated      := :NEW.Created;\n    :NEW.Isactive     := 'Y';\n  END IF;\nEND Beg_Trg_Biur_Dist_Lin_Sol;\n"}`;
    
    }
}
