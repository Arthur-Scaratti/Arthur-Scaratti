
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_CAIXA_HISTORICO
    {
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica qual estabelecimento pode utilizar esta conta (M-matriz, L-loja, A-ambos)
        /// </summary>
        public string IND_UTILIZA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica se a conta exige a geracao de nr de recibo da operação.
        /// </summary>
        public string IND_RECIBO_OBRIGATORIO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_HISTORICO_ID { get; set; }
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
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PESSOA_OBRIGATORIA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string TITULO_CRC_OBRIGATORIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string TITULO_CPG_OBRIGATORIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_CONTA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CONTA_CORRENTE_OBRIGATORIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CONTA_CORRENTE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL_ORIGEM_OBRIGATORIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TP_MOVTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_TIPO_DOCUMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTO_OBRIGATORIO { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string TEXTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string LOTE_CPG_OBRIGATORIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CHEQUE { get; set; }

        [NotMapped]
        public string Trigger_TRG_AIU_BEG_FIN_CAIXA_HIST { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  REGISTRO BEG_FIN_CAIXA_HISTORICO%rowtype;\nbegin\n\n  REGISTRO.BEG_FIN_CAIXA_HISTORICO_ID := :new.BEG_FIN_CAIXA_HISTORICO_ID;\n  REGISTRO.AD_CLIENT_ID               := :new.AD_CLIENT_ID;\n  REGISTRO.AD_ORG_ID                  := :new.AD_ORG_ID;\n  REGISTRO.ISACTIVE                   := :new.ISACTIVE;\n  REGISTRO.CREATED                    := :new.CREATED;\n  REGISTRO.CREATEDBY                  := :new.CREATEDBY;\n  REGISTRO.UPDATED                    := :new.UPDATED;\n  REGISTRO.UPDATEDBY                  := :new.UPDATEDBY;\n  REGISTRO.value                      := :new.value;\n  REGISTRO.name                       := :new.name;\n  REGISTRO.PESSOA_OBRIGATORIA         := :new.PESSOA_OBRIGATORIA;\n  REGISTRO.TITULO_CRC_OBRIGATORIO     := :new.TITULO_CRC_OBRIGATORIO;\n  REGISTRO.TITULO_CPG_OBRIGATORIO     := :new.TITULO_CPG_OBRIGATORIO;\n  REGISTRO.BEG_FIN_CAIXA_CONTA_ID     := :new.BEG_FIN_CAIXA_CONTA_ID;\n  REGISTRO.CONTA_CORRENTE_OBRIGATORIA := :new.CONTA_CORRENTE_OBRIGATORIA;\n  REGISTRO.BEG_FIN_CONTA_CORRENTE_ID  := :new.BEG_FIN_CONTA_CORRENTE_ID;\n  REGISTRO.FILIAL_ORIGEM_OBRIGATORIA  := :new.FILIAL_ORIGEM_OBRIGATORIA;\n  REGISTRO.TP_MOVTO                   := :new.TP_MOVTO;\n  REGISTRO.BEG_FIN_TIPO_DOCUMENTO_ID  := :new.BEG_FIN_TIPO_DOCUMENTO_ID;\n  REGISTRO.DOCUMENTO_OBRIGATORIO      := :new.DOCUMENTO_OBRIGATORIO;\n  REGISTRO.LOTE_CPG_OBRIGATORIO       := :NEW.LOTE_CPG_OBRIGATORIO;\n\n  BEG_PCK_CAIXA.REG_HISTORICO := REGISTRO;\n\n  BEG_PCK_CAIXA.PRC_VALIDA_HISTORICO;\n\nend;\n"}`;
    
    }
}
