
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PCE_LOTE_COBRANCA
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do lote de cobranca
        /// </summary>
        public int BEG_PCE_LOTE_COBRANCA_ID { get; set; }
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
        /// 
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
        /// Data de emissao
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// Data de emissao2
        /// </summary>
        public string DT_EMISSAO2 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Igual ou entre
        /// </summary>
        public string OP_DT_EMISSAO { get; set; }
        
        /// <summary>
        /// Data de vencimento
        /// </summary>
        public string DT_VENCTO { get; set; }
        
        /// <summary>
        /// Data de vencimento 2
        /// </summary>
        public string DT_VENCTO2 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Igual ou entre
        /// </summary>
        public string OP_DT_VENCTO { get; set; }
            [Required]
        /// <summary>
        /// id do portador
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
        
        /// <summary>
        /// Valor do limite
        /// </summary>
        public int VL_LIMITE { get; set; }
        
        /// <summary>
        /// Valor do limite 2
        /// </summary>
        public int VL_LIMITE2 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Igual, maior, menor ou entre
        /// </summary>
        public string OP_VL_LIMITE { get; set; }
        
        /// <summary>
        /// id do parceiro comercial
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Status do cocumento
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// Numero do lote de cobranca
        /// </summary>
        public int BEG_PCE_COMANDO_REM_COB_ID { get; set; }
        
        /// <summary>
        /// id do codigo de instrucao de cobranca 1
        /// </summary>
        public int BEG_PCE_INSTRUCAO_COBRANCA_ID { get; set; }
        
        /// <summary>
        /// id do codigo de instrucao de cobranca 2
        /// </summary>
        public int BEG_VW_PCE_INSTR_COBR_ID { get; set; }
        
        /// <summary>
        /// data da geracao do lote
        /// </summary>
        public string DT_LOTE { get; set; }
            [StringLength(15)]
        /// <summary>
        /// nome do usuario respeonsavel pela ultima alteracao do lote
        /// </summary>
        public string USUARIO { get; set; }
        
        /// <summary>
        /// Valor do lote
        /// </summary>
        public int VLR_LOTE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Atributo para disponibilizar o botao de desfazimento
        /// </summary>
        public string DESFAZIMENTO { get; set; }
        
        /// <summary>
        /// Quantidade de titulos enviados para cobranca
        /// </summary>
        public int QTD_TITULOS { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BUD_PCE_LOTE_COBRANCA { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  cursor C_TIT is\n    select T.BEG_CRC_TITULO_ID\n      from BEG_CRC_TITULO T\n     where T.IND_LOTE_COB_ESCR = 'Y'\n       and T.BEG_PCE_LOTE_COBRANCA_ID is null;\nbegin\n  if UPDATING then\n    if :old.DOCSTATUS = 'CO' then\n      -- Processo de gerac?o do lote bancario ja esta finalizado\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Processo de gerac?o do lote bancario ja esta finalizado ... N?o pode ser alterado!');\n    end if;\n  end if;\n  --\n  if DELETING then\n    -- Naum permite a eliminac?o do lote apos completado todas as etapas\n    if :old.DOCSTATUS = 'CO' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Este lote ja foi processado, n?o pode ser eliminado');\n    \n    else\n      -- \n      -- Desmarca os registro que pertencem ao lote que esta sendo eliminado\n      -- \n      for WC1 in C_TIT\n      loop\n        update BEG_CRC_TITULO T\n           set T.IND_LOTE_COB_ESCR = 'N'\n         where T.BEG_CRC_TITULO_ID = WC1.BEG_CRC_TITULO_ID;\n      \n      end loop;\n    \n      -- \n      -- Elimina todos os titulos referente ao lote\n      --\n      delete BEG_PCE_LOTE_COB_TIT LT\n       where LT.BEG_PCE_LOTE_COBRANCA_ID = :old.BEG_PCE_LOTE_COBRANCA_ID;\n      --\n    end if;\n  end if;\n  --\nend BEG_TRG_BUD_PCE_LOTE_COBRANCA;\n"}`;
    
    }
}
