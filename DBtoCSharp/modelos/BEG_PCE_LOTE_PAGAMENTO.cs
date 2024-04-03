
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PCE_LOTE_PAGAMENTO
    {
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do lote de pagamento
        /// </summary>
        public int BEG_PCE_LOTE_PAGAMENTO_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
        /// Selecao - data de emissao
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// Selecao - Segunda data de emissao
        /// </summary>
        public string DT_EMISSAO2 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Selecao - Opcao para data de emissao
        /// </summary>
        public string OP_DT_EMISSAO { get; set; }
        
        /// <summary>
        /// Selecao - data de vencimento
        /// </summary>
        public string DT_VENCTO { get; set; }
        
        /// <summary>
        /// Selecao - segunda data de vencimento
        /// </summary>
        public string DT_VENCTO2 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Selecao - opcao para data de vencimento
        /// </summary>
        public string OP_DT_VENCTO { get; set; }
        
        /// <summary>
        /// Selecao  Valor limite
        /// </summary>
        public int VL_LIMITE { get; set; }
        
        /// <summary>
        /// Selecao - segundo valor limite
        /// </summary>
        public int VL_LIMITE2 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// selecao - opcao para limite de valores
        /// </summary>
        public string OP_VL_LIMITE { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Status do registro
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// Valor do lote
        /// </summary>
        public int VLR_LOTE { get; set; }
        
        /// <summary>
        /// Id do portador
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Usuario
        /// </summary>
        public string USUARIO { get; set; }
        
        /// <summary>
        /// Id do forneceor
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// Selecao - id do banco
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
            [Required]
        /// <summary>
        /// Indica buscar os titulos e apresenta-los marcados
        /// </summary>
        public string IND_MARCADOS { get; set; }
        
        /// <summary>
        /// Desfazimento do lote gerado
        /// </summary>
        public string DESFAZIMENTO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BUD_PCE_LOTE_PAGAMENTO { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  cursor C_TIT is\n    select T.BEG_CPG_TITULO_ID\n      from BEG_CPG_TITULO T\n     where T.IND_LOTE_PGTO_ESCRITURAL = 'Y'\n       and T.BEG_PCE_LOTE_PAGAMENTO_ID is null;\nbegin\n  if UPDATING then\n    if :old.DOCSTATUS in ('WP', 'CO')\n       and :old.DESFAZIMENTO = 'N' then\n      -- Processo de gerac?o do lote bancario ja esta finalizado\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Processo de gerac?o do lote bancario ja esta finalizado ... N?o pode ser alterado!');\n    end if;\n  end if;\n  --\n  if DELETING then\n    -- Naum permite a eliminac?o do lote apos completado todas as etapas\n    if :old.DOCSTATUS in ('WP', 'CO') then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Este lote ja foi processado, n?o pode ser eliminado');\n    \n    else\n      -- \n      -- Desmarca os registro que pertencem ao lote que esta sendo eliminado\n      -- \n      for WC1 in C_TIT\n      loop\n        update BEG_CPG_TITULO T\n           set T.IND_LOTE_PGTO_ESCRITURAL = 'N'\n         where T.BEG_CPG_TITULO_ID = WC1.BEG_CPG_TITULO_ID;\n      \n      end loop;\n    \n      -- \n      -- Elimina todos os titulos referente ao lote\n      --\n      delete BEG_PCE_LOTE_PAGTO_TIT LT\n       where LT.BEG_PCE_LOTE_PAGAMENTO_ID = :old.BEG_PCE_LOTE_PAGAMENTO_ID;\n      --\n    end if;\n  end if;\n  --\nend BEG_TRG_BUD_PCE_LOTE_PAGAMENTO;\n"}`;
    
    }
}
