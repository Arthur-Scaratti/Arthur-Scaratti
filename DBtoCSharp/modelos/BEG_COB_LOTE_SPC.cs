
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_LOTE_SPC
    {
            [StringLength(1)]
        /// <summary>
        /// Botao para enviar para o SPC/CDL)POA
        /// </summary>
        public string BTN_ENVIA_CDL_POA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Bota para retorno do SPC/CDL POA
        /// </summary>
        public string BTN_RETORNA_CDL_POA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Botao para enviar para o SPC/FCDL
        /// </summary>
        public string BTN_ENVIA_SPC { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Bota para retorno do SPC
        /// </summary>
        public string BTN_RETORNA_SPC { get; set; }
        
        /// <summary>
        /// indica que será um lote apenas de baixas
        /// </summary>
        public string IND_APENAS_BAIXAR { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do lote do SPC
        /// </summary>
        public int BEG_COB_LOTE_SPC_ID { get; set; }
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
    [StringLength(20)]
        /// <summary>
        /// Numero do lote do SPC
        /// </summary>
        public string VALUE { get; set; }
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
        public string DT_MOVIMENTO { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Situacao do Documento
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// Valor do lote do spc
        /// </summary>
        public int VLR_LOTE { get; set; }
        
        /// <summary>
        /// quantidade de titulos enviados para o SPC
        /// </summary>
        public int QTD_TIT { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica qual o processo pode ser realizado. 
        /// </summary>
        public string BTN_PROCESSO { get; set; }
        
        /// <summary>
        /// Sequencia do processamento no spc
        /// </summary>
        public int SEQ_PROC_SPC { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Nome do arquivo texto de saida
        /// </summary>
        public string NOME_ARQUIVO { get; set; }
            [Required]
        /// <summary>
        /// Indicativo de apenas lote de negativacao
        /// </summary>
        public string IND_APENAS_NEGATIVAR { get; set; }
        
        /// <summary>
        /// Quantidade de título que foram aceitos no SPC
        /// </summary>
        public int QTD_TIT_ACEITO { get; set; }
        
        /// <summary>
        /// Valor do lote aceito pelo SPC
        /// </summary>
        public int VLR_LOTE_ACEITO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_COB_LOTE_SPC { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  if :new.ind_apenas_negativar = 'Y' and :new.ind_apenas_baixar = 'Y' then\n      RAISE_APPLICATION_ERROR(-20001,\n      'O assinalamento do indicativo de apenas negativar ou baixar deverão se unicos!');\n  end if;                            \nend die_trg_biu_cob_lote_spc;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BI_COB_LOTE_SPC { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  cursor CLOTE is\n    select 1\n      from BEG_COB_LOTE_SPC LS\n     where LS.BEG_COB_LOTE_SPC_ID <> :new.BEG_COB_LOTE_SPC_ID\n       and LS.DOCSTATUS <> 'CO';\n  VN_LIXO number(1);\n  pragma autonomous_transaction;\nbegin\n\n  open CLOTE;\n  fetch CLOTE\n    into VN_LIXO;\n  if CLOTE%found then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Existe algum lote sendo criado ou em processamento!');\n--                            null;\n  end if;\n\nend BEG_TRG_BI_COB_LOTE_SPC;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BD_COB_LOTE_SPC { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  ----\nbegin\n\n  if :old.DOCSTATUS <> 'IP' then\n    RAISE_APPLICATION_ERROR(-20002, 'Lote não pode ser eliminado! ');\n  end if;\n\nend BEG_TRG_BD_COB_LOTE_SPC;\n"}`;
    
    }
}
