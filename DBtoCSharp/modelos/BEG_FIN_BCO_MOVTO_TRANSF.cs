
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_BCO_MOVTO_TRANSF
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_MOVTO_TRANSF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_SALDO_TRANSFERE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_MOVTO_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_AGENCIA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CONTA_CORRENTE_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_LANCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VERB_CODIGO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_MOV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_LANC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_COMP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CHQ_CHEQUE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_PGTO_MANUAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_IDENTIFICACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_BCO_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INTEGRACAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_INTEGRADO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ESTORNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_SALDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NR_DEPOSITO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_IDENTIFICACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ORIGEM { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_LOTE_CONVENIO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ORIGEM { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string PORTADOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PCE_LOTE_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_CONV_REC_FAT_LOT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_PGTO_MANUAL_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_DOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CHQ_ALIQUOTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CHQ_DEVOLVIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_CHEQUE { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BCO_MOVTO_TRANSF { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n\n\n \n\nbegin\n  IF :NEW.ISACTIVE = 'Y' THEN\n    DECLARE\n     I NUMBER ;\n     BEGIN \n  SELECT COUNT(*) QTDE\n   INTO I\n      FROM BEG_VW_FIN_BCO_MOVTO_TRANSF M\n     WHERE M.ISACTIVE = 'Y'\n       AND M.BEG_FIN_BCO_MOVTO_ID = :new.BEG_FIN_BCO_MOVTO_ID;\n\n  IF I>0   THEN\n  \n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Este movimento ja foi alterado de data uma vez. Para mais de uma solicitar autorizaçao!');\n   \n  END IF;\n   END;\n  END IF;\nend trg_biu_bco_movto_transf;\n"}`;
    
    }
}
