
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_PRE_TITULO
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_RECEBIMENTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PGTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TITULO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ORIGINAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ENCARGOS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTRAS_DEDUCOES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MULTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_JUROS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTROS_ACRESCIMOS { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_LOTE_PGTO_ESCRITURAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENVIO_BCO { get; set; }
            [StringLength(204)]
        /// <summary>
        /// 
        /// </summary>
        public string LINHA_DIGITAVEL { get; set; }
            [StringLength(44)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO_BARRAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_RENEG_PARCELA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PCE_LOTE_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_DADOS_BANCARIOS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COBRADO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IOF { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string BTN_ESTORNO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string BTN_BAIXA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string BTN_CANCELA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO_HIST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTRAS_DEDUCOES_HIST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MULTA_HIST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_JUROS_HIST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTROS_ACRESCIMOS_HIST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CUS_PLANO_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CUS_CENTRO_CUSTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ID_MATRIZ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_PRE_NFE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_PRE_TITULO_ID { get; set; }
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
        public int VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PARCELA { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_CPR_PRE_TIT { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\nCURSOR C_NF IS\n\n  SELECT N.*\n  FROM BEG_CPR_PRE_NFE N\n  WHERE N.BEG_CPR_PRE_NFE_ID = :NEW.BEG_CPR_PRE_NFE_ID;\n\n  R_NF C_NF%ROWTYPE;\n\n  BEGIN\n\n IF INSERTING OR UPDATING THEN\n     open C_NF;\n    fetch C_NF\n      into R_NF;\n    CLOSE C_NF;\n\n  :NEW.BEG_CPG_CONTA_ID := R_NF.BEG_CPG_CONTA_ID;\n  :NEW.BEG_CPG_TIPO_TITULO_ID := R_NF.BEG_CPG_TIPO_TITULO_ID;\n END IF;                      \n\n  END;\n"}`;
    
    }
}
