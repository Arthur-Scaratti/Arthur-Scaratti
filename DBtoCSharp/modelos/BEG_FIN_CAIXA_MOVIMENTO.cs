
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_CAIXA_MOVIMENTO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_RECIBO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// indicativo de integracao de processos para nao permitir exclusão
        /// </summary>
        public string IND_INTEGRADO { get; set; }
            [StringLength(18)]
        /// <summary>
        /// Informa o nr do envelope do banco para depositos bancarios onde a flag ind_nrdeposito estiver Y.
        /// </summary>
        public string NR_DEPOSITO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_DO_CLIENTE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Nr do controle do titulo a receber
        /// </summary>
        public string CONTRATO { get; set; }
        
        /// <summary>
        /// Serie do titulo
        /// </summary>
        public string SRDUP { get; set; }
        
        /// <summary>
        /// Classif do titulo
        /// </summary>
        public string CLASSIF { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Gravar o nr do banco  das contas correntes de uso da empresa
        /// </summary>
        public string COD_BANCO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Gravar o nr dagencia das contas correntes de uso da empresa
        /// </summary>
        public string NR_AGENCIA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Gravar o nr da conta das contas correntes de uso da empresa
        /// </summary>
        public string NR_CONTA { get; set; }
        
        /// <summary>
        /// Nr da parcela cobrada.
        /// </summary>
        public int PARCELA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NR_RECIBO { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO_OBS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se o registro foi estornado.
        /// </summary>
        public string IND_ESTORNO { get; set; }
        
        /// <summary>
        /// Gravar o ID do registro que foi estornado.
        /// </summary>
        public int REG_ESTORNADO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_HISTORICO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NR_AUTENTICACAO { get; set; }
        
        /// <summary>
        /// id da tabela de movimento do caixa da loja
        /// </summary>
        public int ID_MOVTO_LOJA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_CAIXA_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Nao usar.
        /// </summary>
        public string BEG_VW_FIN_CAIXA_HISTORICO_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica prestacao de servico
        /// </summary>
        public string P_SERVICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_CONV_REC_FAT_LOT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_PGTO_MANUAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_SALDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CHQ_CHEQUE_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CONFIRMACAO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_MOVIMENTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_ID { get; set; }
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
        /// Gravar completo data + hora
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
        /// Tipo de lancamento: A - Automatico / M - Manual
        /// </summary>
        public string TP_LANCTO { get; set; }
            [Required]
        /// <summary>
        /// Tipo de movimento: D - Desconta / S - Soma / T - Transfere
        /// </summary>
        public string TP_MOVTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_HISTORICO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CRC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CPG { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// Data do caixa.
        /// </summary>
        public string DATA_PREVISTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_REALIZADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MOVIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BAIXA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_JUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MULTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string FECHADO { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CONTA_CORRENTE_OBRIGATORIA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL_ORIGEM_OBRIGATORIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CONTA_CORRENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_TIPO_DOCUMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTO_OBRIGATORIO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CC_MOVIMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_PGTO_MANUAL_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string LOTE_CPG_OBRIGATORIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BI_CX_MOV { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n  --\n  pragma autonomous_transaction;\n  --\n\nBEGIN\n\n\n  IF :NEW.REG_ESTORNADO_ID IS NOT NULL THEN\n\n\n\n      UPDATE BEG_FIN_CAIXA_MOVIMENTO M SET\n     --  M.REG_ESTORNADO_ID = :NEW.BEG_FIN_CAIXA_MOVIMENTO_ID,\n       M.IND_ESTORNO = 'Y'\n       WHERE M.BEG_FIN_CAIXA_MOVIMENTO_ID = :NEW.REG_ESTORNADO_ID;\n\n\n  COMMIT;\n  END IF;\n\n\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BD_BEG_FIN_CAIXA { get; set; } = `{"triggering_event":"DELETE","trigger_body":"BEGIN\n\n  IF :OLD.AD_ORG_ID = 1000001 THEN\n  \n    RAISE_APPLICATION_ERROR(-20001,\n                            'Não permitido excluir Movimento do caixa trânsito. Solicitar ao setor de T.I.');\n  \n  END IF;\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_FIN_CAIXA { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"DECLARE\n  --\n  CURSOR C_TP_HISTORICO IS\n    SELECT CH.TP_MOVTO\n      FROM BEG_FIN_CAIXA_HISTORICO CH\n     WHERE CH.BEG_FIN_CAIXA_HISTORICO_ID = :NEW.BEG_FIN_CAIXA_HISTORICO_ID;\n  --\n  R_TP_HISTORICO C_TP_HISTORICO%ROWTYPE;\n  --\n  --\n  CURSOR C2 IS\n    SELECT CH.TP_MOVTO\n      FROM BEG_FIN_CAIXA_HISTORICO CH\n     WHERE CH.BEG_FIN_CAIXA_HISTORICO_ID = :OLD.BEG_FIN_CAIXA_HISTORICO_ID;\n  r_c2 c2%rowtype;\n  --\n  CURSOR C3 IS\n    SELECT C.DOCSTATUS\n      FROM BEG_FIN_CAIXA_SALDO C\n     WHERE C.BEG_FIN_CAIXA_SALDO_ID = :OLD.BEG_FIN_CAIXA_SALDO_ID;\n  --\n  R_C3 C3%ROWTYPE;\n  --\n  CURSOR C4 IS\n    SELECT C.DOCSTATUS\n      FROM BEG_FIN_CAIXA_SALDO C\n     WHERE C.BEG_FIN_CAIXA_SALDO_ID = :NEW.BEG_FIN_CAIXA_SALDO_ID;\n  --\n  R_C4 C4%ROWTYPE;\n  --\n  --  VN_NEW NUMBER(17,4);\n  --  VN_OLD NUMBER(17,4);\n  --\n  cursor C_FECH_CONT is\n    select MAX(C.DT_FINAL) DT_FINAL from BEG_FECH_CONTABIL C;\n  --\n  R_FECH_CONT C_FECH_CONT%rowtype;\n  --  \n  cursor C_VALIDA_DATA is\n    select SL.DATA\n      from BEG_FIN_CAIXA_SALDO SL\n     where SL.BEG_FIN_CAIXA_SALDO_ID = :NEW.BEG_FIN_CAIXA_SALDO_ID\n        or SL.BEG_FIN_CAIXA_SALDO_ID = :OLD.BEG_FIN_CAIXA_SALDO_ID;\n  --\n  R_VALIDA_DATA C_VALIDA_DATA%rowtype;\n  --      \nbegin\n  --\n  open C_VALIDA_DATA;\n  fetch C_VALIDA_DATA\n    into R_VALIDA_DATA;\n  close C_VALIDA_DATA;\n  --\n  OPEN C_FECH_CONT;\n  FETCH C_FECH_CONT\n    INTO R_FECH_CONT;\n  CLOSE C_FECH_CONT;\n  --\n  /*  IF R_VALIDA_DATA.Data <= R_FECH_CONT.DT_FINAL THEN\n    RAISE_APPLICATION_ERROR(-20001,'Não pode deletar, alterar ou inserir registro quando fechamentos contabil está fechado!');    \n  END IF;*/\n  --  \n  OPEN C_TP_HISTORICO;\n  FETCH C_TP_HISTORICO\n    INTO R_TP_HISTORICO;\n  CLOSE C_TP_HISTORICO;\n  --\n  IF INSERTING THEN\n    --\n    OPEN C4;\n    FETCH C4\n      INTO R_C4;\n    CLOSE C4;\n    --\n    IF R_C4.DOCSTATUS = 'CL' THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Não pode inserir novo Movimento com Saldo Caixa fechado');\n    END IF;\n    --\n    IF :NEW.AD_ORG_ID IN (0, 1000134) THEN\n      IF R_TP_HISTORICO.TP_MOVTO = 'S' THEN\n        --\n        UPDATE BEG_FIN_CAIXA_SALDO SAL\n           SET SAL.TOTAL_ENTRADAS = NVL(SAL.TOTAL_ENTRADAS, 0) +\n                                    :NEW.VLR_MOVIMENTO\n         WHERE SAL.BEG_FIN_CAIXA_SALDO_ID = :NEW.BEG_FIN_CAIXA_SALDO_ID;\n        --\n      ELSE\n        --\n        UPDATE BEG_FIN_CAIXA_SALDO SAL\n           SET SAL.TOTAL_SAIDAS = NVL(SAL.TOTAL_SAIDAS, 0) +\n                                  :NEW.VLR_MOVIMENTO\n         WHERE SAL.BEG_FIN_CAIXA_SALDO_ID = :NEW.BEG_FIN_CAIXA_SALDO_ID;\n        --\n      END IF;\n      --\n    \n    END IF;\n  ELSIF UPDATING AND :NEW.AD_ORG_ID IN (0, 1000134) THEN\n    --\n    IF R_TP_HISTORICO.TP_MOVTO = 'S' THEN\n      -- (S) SOMA = ENTRADA\n      --\n      UPDATE BEG_FIN_CAIXA_SALDO SAL\n         SET SAL.TOTAL_ENTRADAS = NVL(SAL.TOTAL_ENTRADAS, 0) +\n                                  :NEW.VLR_MOVIMENTO - :OLD.VLR_MOVIMENTO\n       WHERE SAL.BEG_FIN_CAIXA_SALDO_ID = :NEW.BEG_FIN_CAIXA_SALDO_ID;\n      --\n    ELSE\n      -- (D) DECRESCIMO = SAIDA\n      --\n      UPDATE BEG_FIN_CAIXA_SALDO SAL\n         SET SAL.TOTAL_SAIDAS = NVL(SAL.TOTAL_SAIDAS, 0) +\n                                :NEW.VLR_MOVIMENTO - :OLD.VLR_MOVIMENTO\n       WHERE SAL.BEG_FIN_CAIXA_SALDO_ID = :NEW.BEG_FIN_CAIXA_SALDO_ID;\n      --\n    END IF;\n    --\n  ELSIF DELETING THEN\n    open c2;\n    fetch c2\n      into r_c2;\n    close c2;\n    --\n    OPEN C3;\n    FETCH C3\n      INTO R_C3;\n    CLOSE C3;\n    --\n    IF R_C3.DOCSTATUS = 'CL' THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Não pode deletar Movimento onde Saldo Caixa está fechado');\n    END IF;\n    --\n    IF :NEW.AD_ORG_ID IN (0, 1000134) THEN\n      IF r_c2.TP_MOVTO = 'S' THEN\n        -- (S) SOMA = ENTRADA\n        --\n        UPDATE BEG_FIN_CAIXA_SALDO SAL\n           SET SAL.TOTAL_ENTRADAS = NVL(SAL.TOTAL_ENTRADAS, 0) -\n                                    :OLD.VLR_MOVIMENTO\n         WHERE SAL.BEG_FIN_CAIXA_SALDO_ID = :OLD.BEG_FIN_CAIXA_SALDO_ID;\n        --\n      ELSE\n        -- (D) DECRESCIMO = SAIDA\n        --\n        UPDATE BEG_FIN_CAIXA_SALDO SAL\n           SET SAL.TOTAL_SAIDAS = NVL(SAL.TOTAL_SAIDAS, 0) -\n                                  :OLD.VLR_MOVIMENTO\n         WHERE SAL.BEG_FIN_CAIXA_SALDO_ID = :OLD.BEG_FIN_CAIXA_SALDO_ID;\n        --\n      END IF;\n      ---\n    END IF;\n    IF NVL(:OLD.IND_INTEGRADO, 'N') = 'Y' THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Registro integrado via sistema não permite exclusao. Verifique!');\n    \n    END IF;\n  \n    --      \n  END IF;\n  --\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FIN_CAIXA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  cursor C_CAIXA(P_CAIXA_SALDO_ID number) is\n    select AD_CLIENT_ID,\n           AD_ORG_ID,\n           BEG_FIN_CAIXA_ID\n      FROM BEG_FIN_CAIXA_saldo A\n     where A.BEG_FIN_CAIXA_SALDO_ID = P_CAIXA_SALDO_ID;\n CURSOR BUSCA_PESSOA IS \n    SELECT T.BEG_PESSOA_ID\n    FROM   BEG_CPG_TITULO T \n    WHERE  BEG_CPG_TITULO_ID = :NEW.BEG_CPG_TITULO_ID;\n --\n CURSOR busca_historico IS \n   SELECT *\n   FROM   beg_fin_caixa_historico\n   WHERE  beg_fin_caixa_historico_id = :NEW.beg_fin_caixa_historico_id;\n  --\n  v_historico busca_historico%rowtype;\n  --\n  vc_teste    varchar2(100);\n  --\nbegin\n  --\n  vc_teste := :NEW.beg_fin_caixa_historico_id;\n  ---\n  IF INSERTING AND :NEW.BEG_FIN_CAIXA_HISTORICO_ID=2000086 THEN\n    \n  :NEW.HISTORICO :=SUBSTR(:NEW.HISTORICO,24);\n  END IF;\n  \n  --\n  OPEN BUSCA_PESSOA;\n  FETCH BUSCA_PESSOA INTo :NEW.BEG_PESSOA_ID;\n  CLOSE BUSCA_PESSOA;\n\n  open C_CAIXA(:new.BEG_FIN_CAIXA_SALDO_ID);\n  fetch C_CAIXA\n    into :new.AD_CLIENT_ID, :new.AD_ORG_ID, :NEW.BEG_FIN_CAIXA_ID;\n  close C_CAIXA;\n\n/*  if :new.HISTORICO is null then\n  \n    :new.HISTORICO := BEG_PCK_CAIXA.FNC_MONTA_HISTORICO(:new.BEG_FIN_CAIXA_HISTORICO_ID,\n                                                        :new.COMPLEMENTO_HISTORICO_1,\n                                                        :new.COMPLEMENTO_HISTORICO_2,\n                                                        :new.COMPLEMENTO_HISTORICO_3,\n                                                        :new.DOCUMENTO,\n                                                        :new.HISTORICO);\n  end if;*/\n  --\n  IF :NEW.IND_CONFIRMACAO = 'Y' AND\n    :NEW.BEG_VW_FIN_CAIXA_HISTORICO_ID IS NULL AND\n    :NEW.DATA_REALIZADA IS NULL THEN\n    RAISE_APPLICATION_ERROR(-20001,'Faltou informar Caixa ou Data Realizada!');\n  END IF;\n  --\n /* IF NVL(:NEW.IND_CONFIRMACAO,'N') = 'Y' THEN\n    BKN_PRC_CAIXA_MOVIMENTO(:NEW.BEG_VW_FIN_CAIXA_ID\n                           ,:NEW.BEG_FIN_CAIXA_ID\n                           ,:NEW.BEG_FIN_CAIXA_MOVIMENTO_ID\n                           ,:NEW.DATA_REALIZADA);\n  END IF;*/\n  --\n  IF :NEW.P_SERVICO = 'Y' AND\n     :NEW.BEG_PESSOA_ID IS NULL THEN\n     RAISE_APPLICATION_ERROR(-20001,'Obrigatório informar Parceiro Comercial!');\n  END IF;\n  --\n  IF :NEW.P_SERVICO = 'Y' AND\n     :NEW.BEG_CPG_PGTO_MANUAL_ID is not null THEN\n    RAISE_APPLICATION_ERROR(-20001,'Nota integrado por Contas a Pagar não pode ser marcada como Prestação de Serviço!');\n  END IF;\n  --\n  -- Limpa dados relevantes ao historico\n  --\n\n  /*if :new.DOCUMENTO_OBRIGATORIO = 'N' then\n    :new.DOCUMENTO                 := null;\n    :new.BEG_FIN_TIPO_DOCUMENTO_ID := null;\n  end if;*/\n\n  if :new.CONTA_CORRENTE_OBRIGATORIA = 'N' then\n    :new.BEG_FIN_CONTA_CORRENTE_ID := null;\n  END IF;\n  --\n  if :new.ad_org_id in (0,1000016, 1000134) then\n    OPEN busca_historico;\n    fetch busca_historico\n      INTO v_historico;\n    CLOSE busca_historico;\n    :NEW.tp_lancto := 'M';\n    :NEW.tp_movto  := v_historico.tp_movto;\n    IF v_historico.beg_fin_caixa_conta_id IS NOT NULL AND\n       :NEW.beg_fin_caixa_conta_id IS NULL THEN\n      :new.beg_fin_caixa_conta_id := v_historico.beg_fin_caixa_conta_id;\n    end if;\n  end if;\n/*  IF INSERTING OR UPDATING THEN \n    vc_teste := :old.beg_chq_cheque_id;\n    IF :OLD.BEG_CHQ_CHEQUE_ID IS NOT NULL THEN\n      UPDATE BEG_CHQ_CHEQUE C\n         SET C.BEG_FIN_CAIXA_ID = NULL\n      WHERE  BEG_CHQ_CHEQUE_ID = :OLD.BEG_CHQ_CHEQUE_ID;\n      --\n    END IF;\n    vc_teste := :new.beg_chq_cheque_id;\n    IF :NEW.BEG_CHQ_CHEQUE_ID IS NOT NULL THEN \n      UPDATE BEG_CHQ_CHEQUE C\n         SET C.BEG_FIN_CAIXA_ID = :NEW.BEG_FIN_CAIXA_ID\n      WHERE  BEG_CHQ_CHEQUE_ID = :NEW.BEG_CHQ_CHEQUE_ID;\n    END IF;\n  ELSE \n    vc_teste := :old.beg_chq_cheque_id;\n    IF :OLD.BEG_CHQ_CHEQUE_ID IS NOT NULL THEN \n      UPDATE BEG_CHQ_CHEQUE C\n         SET C.BEG_FIN_CAIXA_ID = NULL\n      WHERE  BEG_CHQ_CHEQUE_ID = :OLD.BEG_CHQ_CHEQUE_ID;\n      --\n    END IF;\n  END IF;*/\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_AIUD_BEG_FIN_CAIXA_MOVTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  VC_MSG_ERRO varchar2(200);\n  REGISTRO    BEG_FIN_CAIXA_MOVIMENTO%rowtype;\nbegin\n  IF :NEW.AD_ORG_ID IN (0, 1000134) THEN\n  -- Verifica o valor do movimento\n  if not DELETING then\n    if NVL(:new.VLR_MOVIMENTO, 0) <= 0 then\n      VC_MSG_ERRO := 'Valor do movimento deve ser informado e maior que zero!';\n      goto ERRO;\n    end if;\n  end if;\n\n  REGISTRO.BEG_FIN_CAIXA_MOVIMENTO_ID := :new.BEG_FIN_CAIXA_MOVIMENTO_ID;\n  REGISTRO.BEG_FIN_CAIXA_ID           := :new.BEG_FIN_CAIXA_ID;\n  REGISTRO.AD_CLIENT_ID               := :new.AD_CLIENT_ID;\n  REGISTRO.AD_ORG_ID                  := :new.AD_ORG_ID;\n  REGISTRO.ISACTIVE                   := :new.ISACTIVE;\n  REGISTRO.CREATED                    := :new.CREATED;\n  REGISTRO.CREATEDBY                  := :new.CREATEDBY;\n  REGISTRO.UPDATED                    := :new.UPDATED;\n  REGISTRO.UPDATEDBY                  := :new.UPDATEDBY;\n  REGISTRO.TP_LANCTO                  := :new.TP_LANCTO;\n  REGISTRO.TP_MOVTO                   := :new.TP_MOVTO;\n  REGISTRO.BEG_PESSOA_ID              := :new.BEG_PESSOA_ID;\n  REGISTRO.BEG_FIN_CAIXA_HISTORICO_ID := :new.BEG_FIN_CAIXA_HISTORICO_ID;\n  REGISTRO.BEG_FIN_CAIXA_CONTA_ID     := :new.BEG_FIN_CAIXA_CONTA_ID;\n  REGISTRO.BEG_FILIAL_ID              := :new.BEG_FILIAL_ID;\n--  REGISTRO.COMPLEMENTO_HISTORICO_1    := :new.COMPLEMENTO_HISTORICO_1;\n--  REGISTRO.COMPLEMENTO_HISTORICO_2    := :new.COMPLEMENTO_HISTORICO_2;\n--  REGISTRO.COMPLEMENTO_HISTORICO_3    := :new.COMPLEMENTO_HISTORICO_3;\n  REGISTRO.HISTORICO                  := :new.HISTORICO;\n  REGISTRO.BEG_CRC_TITULO_ID          := :new.BEG_CRC_TITULO_ID;\n  REGISTRO.BEG_CPG_TITULO_ID          := :new.BEG_CPG_TITULO_ID;\n  REGISTRO.DATA_PREVISTA              := :new.DATA_PREVISTA;\n  REGISTRO.DATA_REALIZADA             := :new.DATA_REALIZADA;\n  REGISTRO.VLR_MOVIMENTO              := :new.VLR_MOVIMENTO;\n  REGISTRO.VLR_BAIXA                  := :new.VLR_BAIXA;\n  REGISTRO.VLR_JUROS                  := :new.VLR_JUROS;\n  REGISTRO.VLR_DESCONTO               := :new.VLR_DESCONTO;\n  REGISTRO.VLR_MULTA                  := :new.VLR_MULTA;\n  REGISTRO.FECHADO                    := :new.FECHADO;\n  REGISTRO.PESSOA_OBRIGATORIA         := :new.PESSOA_OBRIGATORIA;\n  REGISTRO.TITULO_CRC_OBRIGATORIO     := :new.TITULO_CRC_OBRIGATORIO;\n  REGISTRO.TITULO_CPG_OBRIGATORIO     := :new.TITULO_CPG_OBRIGATORIO;\n  REGISTRO.CONTA_CORRENTE_OBRIGATORIA := :new.CONTA_CORRENTE_OBRIGATORIA;\n  REGISTRO.FILIAL_ORIGEM_OBRIGATORIA  := :new.FILIAL_ORIGEM_OBRIGATORIA;\n  REGISTRO.BEG_FIN_CONTA_CORRENTE_ID  := :new.BEG_FIN_CONTA_CORRENTE_ID;\n  REGISTRO.BEG_FIN_TIPO_DOCUMENTO_ID  := :new.BEG_FIN_TIPO_DOCUMENTO_ID;\n  REGISTRO.DOCUMENTO_OBRIGATORIO      := :new.DOCUMENTO_OBRIGATORIO;\n  REGISTRO.DOCUMENTO                  := :new.DOCUMENTO;\n\n  BEG_PCK_CAIXA.REG_NEW := REGISTRO;\n\n  if UPDATING then\n    REGISTRO.BEG_FIN_CAIXA_MOVIMENTO_ID := :old.BEG_FIN_CAIXA_MOVIMENTO_ID;\n    REGISTRO.BEG_FIN_CAIXA_ID           := :old.BEG_FIN_CAIXA_ID;\n    REGISTRO.AD_CLIENT_ID               := :old.AD_CLIENT_ID;\n    REGISTRO.AD_ORG_ID                  := :old.AD_ORG_ID;\n    REGISTRO.ISACTIVE                   := :new.ISACTIVE;\n    REGISTRO.CREATED                    := :new.CREATED;\n    REGISTRO.CREATEDBY                  := :old.CREATEDBY;\n    REGISTRO.UPDATED                    := :old.UPDATED;\n    REGISTRO.UPDATEDBY                  := :old.UPDATEDBY;\n    REGISTRO.TP_LANCTO                  := :old.TP_LANCTO;\n    REGISTRO.TP_MOVTO                   := :old.TP_MOVTO;\n    REGISTRO.BEG_PESSOA_ID              := :old.BEG_PESSOA_ID;\n    REGISTRO.BEG_FIN_CAIXA_HISTORICO_ID := :old.BEG_FIN_CAIXA_HISTORICO_ID;\n    REGISTRO.BEG_FIN_CAIXA_CONTA_ID     := :old.BEG_FIN_CAIXA_CONTA_ID;\n    REGISTRO.BEG_FILIAL_ID              := :old.BEG_FILIAL_ID;\n  --  REGISTRO.COMPLEMENTO_HISTORICO_1    := :old.COMPLEMENTO_HISTORICO_1;\n  --  REGISTRO.COMPLEMENTO_HISTORICO_2    := :old.COMPLEMENTO_HISTORICO_2;\n  --  REGISTRO.COMPLEMENTO_HISTORICO_3    := :old.COMPLEMENTO_HISTORICO_3;\n    REGISTRO.HISTORICO                  := :old.HISTORICO;\n    REGISTRO.BEG_CRC_TITULO_ID          := :old.BEG_CRC_TITULO_ID;\n    REGISTRO.BEG_CPG_TITULO_ID          := :old.BEG_CPG_TITULO_ID;\n    REGISTRO.DATA_PREVISTA              := :old.DATA_PREVISTA;\n    REGISTRO.DATA_REALIZADA             := :old.DATA_REALIZADA;\n    REGISTRO.VLR_MOVIMENTO              := :old.VLR_MOVIMENTO;\n    REGISTRO.VLR_BAIXA                  := :old.VLR_BAIXA;\n    REGISTRO.VLR_JUROS                  := :old.VLR_JUROS;\n    REGISTRO.VLR_DESCONTO               := :old.VLR_DESCONTO;\n    REGISTRO.VLR_MULTA                  := :old.VLR_MULTA;\n    REGISTRO.FECHADO                    := :old.FECHADO;\n    REGISTRO.PESSOA_OBRIGATORIA         := :old.PESSOA_OBRIGATORIA;\n    REGISTRO.TITULO_CRC_OBRIGATORIO     := :old.TITULO_CRC_OBRIGATORIO;\n    REGISTRO.TITULO_CPG_OBRIGATORIO     := :old.TITULO_CPG_OBRIGATORIO;\n    REGISTRO.CONTA_CORRENTE_OBRIGATORIA := :old.CONTA_CORRENTE_OBRIGATORIA;\n    REGISTRO.FILIAL_ORIGEM_OBRIGATORIA  := :old.FILIAL_ORIGEM_OBRIGATORIA;\n    REGISTRO.BEG_FIN_CONTA_CORRENTE_ID  := :old.BEG_FIN_CONTA_CORRENTE_ID;\n    REGISTRO.BEG_FIN_TIPO_DOCUMENTO_ID  := :old.BEG_FIN_TIPO_DOCUMENTO_ID;\n    REGISTRO.DOCUMENTO_OBRIGATORIO      := :old.DOCUMENTO_OBRIGATORIO;\n    REGISTRO.DOCUMENTO                  := :old.DOCUMENTO;\n    \n    BEG_PCK_CAIXA.REG_OLD := REGISTRO;\n  end if;\n  --BEG_PCK_CAIXA.PRC_VALIDA_MOVIMENTO(null);\n\n  if INSERTING then\n    BEG_PCK_CAIXA.PRC_SALDO('I');\n  elsif UPDATING then\n    BEG_PCK_CAIXA.PRC_SALDO('U');\n  else\n    BEG_PCK_CAIXA.PRC_SALDO('D');\n  end if;\n\n  --Efetivando pagamento de titulo a pagar\n  /*if :new.DATA_REALIZADA is not null\n     and :old.DATA_REALIZADA is null\n     and :new.BEG_CPG_TITULO_ID is not null then\n    BEG_PCK_FIN_CPG.R_BEG_FIN_CAIXA_MOVIMENTO := REGISTRO;\n    BEG_PCK_FIN_CPG.PRC_CPG_BAIXA_PGTO_CAIXA;\n  end if;*/\n\n  goto FIM;\n\n  <<ERRO>>\n  RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n\n  <<FIM>>\n  return;\n END IF; \nend TRG_AIUD_BEG_FIN_CAIXA_MOVTO;\n"}`;
    
    }
}
