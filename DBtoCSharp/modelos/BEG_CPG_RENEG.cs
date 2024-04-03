
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_RENEG
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_GERA_PARCELAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID da renegociac?o
        /// </summary>
        public int BEG_CPG_RENEG_ID { get; set; }
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
        /// Codigo da renegociac?o
        /// </summary>
        public int VALUE { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// Descric?o da renegociac?o
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// Data da renegociac?o (emiss?o)
        /// </summary>
        public string DT_RENEG { get; set; }
        
        /// <summary>
        /// Data do fechamento
        /// </summary>
        public string DT_FECHAMENTO { get; set; }
            [Required]
        /// <summary>
        /// Taxa de juros utilizada para renegociac?o
        /// </summary>
        public int TAX_JUROS_NOMINAL { get; set; }
            [Required]
        /// <summary>
        /// Valor total original dos titulos
        /// </summary>
        public int VLR_TOTAL_ORIGINAL { get; set; }
            [Required]
        /// <summary>
        /// Valor total da renegociac?o aplicada a taxa de juros
        /// </summary>
        public int VLR_TOTAL_RENEG { get; set; }
            [Required]
        /// <summary>
        /// Valor total dos encargos
        /// </summary>
        public int VLR_TOTAL_ENCARGOS { get; set; }
            [Required]
        /// <summary>
        /// Valor em aberto da renegociac?o
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Numero do(s) titulo(s) a serem gerados
        /// </summary>
        public string NRO_TITULO { get; set; }
        
        /// <summary>
        /// Quantidade de parcelas
        /// </summary>
        public int QTD_PARCELAS { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Quantidade de dias para vencimento das parcelas
        /// </summary>
        public string DIAS_VENCIMENTO { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Status da renegociac?o: WC - Aguardando confirmac?o (Waiting Confirmation) / WP - Baixa os titulos de origem e libera para movimentac?o (Waiting Payment) / PA - TODDOS os titulos vinculados pagos (PAyed) / CA - Cancelada (CAnceled)
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Observac?o da renegociac?o
        /// </summary>
        public string OBS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Bot?o auxiliar para o Compiere que processa a inclus?o de titulos na renegociac?o
        /// </summary>
        public string BTN_INCLUI_TITULOS { get; set; }
            [Required]
        /// <summary>
        /// ID do fornecedor
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do tipo da renegociac?o
        /// </summary>
        public int BEG_CPG_TIPO_RENEG_ID { get; set; }
        
        /// <summary>
        /// ID da condic?o de pagamento
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// ID da forma de pagamento
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// ID do banco
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// ID da moeda
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_JUROS_NOMINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IOF { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_CPG_RENEG { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que valida a renegociac?o de titulos do contas a pagar\n   Modulo.......: CPG - Contas a Pagar\n   Analista.....: Tiago Gabriel\n   Alterac?es:\n   Data        Desenvolvedor  Alterac?o\n   04/10/2006  Tiago Gabriel  Criac?o.\n  --------------------------------------------------------------------------------------------------- */\n  VC_MSG_ERRO varchar2(200);\n\nbegin\n  BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_RENEG := true;\n\n  -- Se esta excluindo uma renegociac?o, exclui os fornecedores.\n  if DELETING then\n  \n    -- Verifica o status\n    if :old.DOCSTATUS <> 'WC' then\n      VC_MSG_ERRO := 'Somente e possivel excluir renegociac?es ainda n?o processadas!';\n      goto FIM;\n    end if;\n  \n    -- Exclui parcelas\n    delete from BEG_CPG_RENEG_PARCELA\n     where BEG_CPG_RENEG_ID = :old.BEG_CPG_RENEG_ID;\n  \n    -- Exclui titulos\n    delete from BEG_CPG_RENEG_TITULO\n     where BEG_CPG_RENEG_ID = :old.BEG_CPG_RENEG_ID;\n  \n    -- Exclui fornecedores (os titulos s?o excluidos na exclu?o do fornecedor)\n    delete from BEG_CPG_RENEG_FORNECEDOR\n     where BEG_CPG_RENEG_ID = :old.BEG_CPG_RENEG_ID;\n  \n    BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_RENEG := false;\n  \n    goto FIM;\n  end if;\n\n  -- Verifica o status da renegociac?o\n  if UPDATING\n     and :old.DOCSTATUS = :new.DOCSTATUS\n     and :new.DOCSTATUS <> 'WC' then\n    VC_MSG_ERRO := 'Somente e possivel alterar renegociac?es que est?o aguardando confirmac?o!';\n    goto FIM;\n  end if;\n\n  --if not BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_RENEG_FORN then\n  if not BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_INCLUI_TITULO  then\n  \n    -- Verifica filial\n    if NVL(:new.AD_ORG_ID, 0) = 0 then\n      VC_MSG_ERRO := 'Deve ser selecionada uma filial para a renegociac?o!';\n      goto FIM;\n    end if;\n  \n    -- Valida o codigo da renegociac?o\n    if not REGEXP_LIKE(:new.value, '^[[:digit:]]+$') then\n      VC_MSG_ERRO := 'Codigo numerico deve ser infrmado e maior que zero!';\n      goto FIM;\n    end if;\n  \n    -- Fornecedor\n    if NVL(:new.BEG_VW_FORNECEDOR_ID, 0) <= 0 then\n      VC_MSG_ERRO := 'Fornecedor deve ser informado!';\n      goto FIM;\n    end if;\n  \n    -- Verifica o numero do titulo\n    if NVL(:new.NRO_TITULO, 0) = 0 then\n      :new.NRO_TITULO := :new.value;\n    end if;\n  \n    -- Gera as parcelas\n    BEG_PCK_CPG_CONTAS_PAGAR.PRC_GERA_PARCELA_RENEG(:new.BEG_CPG_RENEG_ID,\n                                                    :new.AD_CLIENT_ID,\n                                                    :new.AD_ORG_ID,\n                                                    :new.UPDATEDBY,\n                                                    :new.DT_FECHAMENTO,\n                                                    :new.TAX_JUROS_NOMINAL,\n                                                    :new.VLR_TOTAL_ORIGINAL,\n                                                    :new.QTD_PARCELAS,\n                                                    :new.DIAS_VENCIMENTO,\n                                                    :new.BEG_CONDICAO_PAGAMENTO_ID,\n                                                    :new.VLR_TOTAL_RENEG,\n                                                    :new.VLR_TOTAL_ENCARGOS,\n                                                    :new.VLR_ABERTO);                                                  \n  end if;\n  --\n      if :new.DOCSTATUS <> 'WP' then\n  IF BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_RENEG THEN\n    BEG_PCK_CPG_CONTAS_PAGAR.PRC_GERA_PARCELA_RENEG(:new.BEG_CPG_RENEG_ID,\n                                                    :new.AD_CLIENT_ID,\n                                                    :new.AD_ORG_ID,\n                                                    :new.UPDATEDBY,\n                                                    :new.DT_FECHAMENTO,\n                                                    :new.TAX_JUROS_NOMINAL,\n                                                    :new.VLR_TOTAL_ORIGINAL,\n                                                    :new.QTD_PARCELAS,\n                                                    :new.DIAS_VENCIMENTO,\n                                                    :new.BEG_CONDICAO_PAGAMENTO_ID,\n                                                    :new.VLR_TOTAL_RENEG,\n                                                    :new.VLR_TOTAL_ENCARGOS,\n                                                    :new.VLR_ABERTO);\n  END IF;\n       END IF;\n  --\n  BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_RENEG := false;\n\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend TRG_BIUD_BEG_CPG_RENEG;\n"}`;
    
    }
}
