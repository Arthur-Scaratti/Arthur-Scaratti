
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_BCO_MOVTO
    {
        
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
        public int DIE_FIN_LOTE_CRED_BANC_ID { get; set; }
        
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
            [Required]
    [Key]
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

        [NotMapped]
        public string Trigger_BEG_TRG_VALIDA_VALOR { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  --\n  VN_BEG_FIN_CAIXA_HISTORICO_ID number(10);\n  VN_BEG_FIN_CAIXA_CONTA_ID     number(10);\n  VN_BEG_FIN_CAIXA_MOVIMENTO_ID number(10);\n  VC_VALUE_BANCO                varchar2(40);\n  VN_NUMERO_CHEQUE              number(10);\n  VC_IND_REAPRESENTA            varchar2(1);\n  VN_BEG_FIN_PORTADOR_ID        number(10);\n  VN_BEG_FIN_CAIXA_SALDO_ID     number(10);\n  VD_DT_VENCIMENTO_CHEQUE       DATE;\n  VC_NOME                       VARCHAR2(50);\n  --  \n  --\n  cursor busca_dados is\n    select *\n      from BEG_FIN_BCO_SALDO S\n     where S.BEG_FIN_BCO_SALDO_ID = :new.BEG_FIN_BCO_SALDO_ID;\n  --\n  V_DADOS BUSCA_DADOS%ROWTYPE;\n  --\n  VN_VALIDA NUMBER(17, 4);\n  --\n  CURSOR C1 IS\n    SELECT 1\n      FROM BEG_FIN_BCO_MOVTO_ORIGEM O\n     WHERE O.BEG_FIN_BCO_MOVTO_ID = :OLD.BEG_FIN_BCO_MOVTO_ID;\n  --\n  R_C1 C1%ROWTYPE;\n  --\n  CURSOR C2 IS\n    SELECT 1\n      FROM BEG_FIN_BCO_SALDO S\n     WHERE S.DOCSTATUS = 'CL'\n       AND S.BEG_FIN_BCO_SALDO_ID = :OLD.BEG_FIN_BCO_SALDO_ID;\n  --\n  R_C2 C2%ROWTYPE;\n  --\n  CURSOR C3 IS\n    SELECT C.DOCSTATUS\n      FROM BEG_FIN_BCO_SALDO C\n     WHERE C.BEG_FIN_BCO_SALDO_ID = :NEW.BEG_FIN_BCO_SALDO_ID;\n  --\n  R_C3 C3%ROWTYPE;\n  --\n  CURSOR C4 IS\n    SELECT P.NAME\n      FROM BEG_FIN_BCO_SALDO S, BEG_FIN_PORTADOR P\n     WHERE P.BEG_FIN_PORTADOR_ID = S.BEG_FIN_PORTADOR_ID\n       AND S.BEG_FIN_BCO_SALDO_ID = :NEW.BEG_FIN_BCO_SALDO_ID;\n  --\n  R_C4 C4%ROWTYPE;\n  --\n  cursor C_FECH_CONT is\n    select MAX(C.DT_FINAL) DT_FINAL from BEG_FECH_CONTABIL C;\n  --\n  R_FECH_CONT C_FECH_CONT%rowtype;\n  --\n  cursor C_FECH_CONT1 is\n    select ind_escrita\n      from BEG_FECH_CONTABIL C\n     where c.dt_final = R_FECH_CONT.DT_FINAL;\n  --\n  R_FECH_CONT1 C_FECH_CONT1%rowtype;\n\n  --\n  cursor C_VALIDA_DATA is\n    select SL.DT_SALDO\n      from BEG_FIN_BCO_SALDO SL\n     where SL.BEG_FIN_BCO_SALDO_ID = :NEW.BEG_FIN_BCO_SALDO_ID\n        or SL.BEG_FIN_BCO_SALDO_ID = :OLD.BEG_FIN_BCO_SALDO_ID;\n  --\n  R_VALIDA_DATA C_VALIDA_DATA%rowtype;\n  --  \n  cursor C_INTEGRACAO is\n    select NVL(BC.IND_INTEGRACAO, 'N') IND_INTEGRACAO\n      from BEG_FIN_BCO_CONTA BC\n     where BC.BEG_FIN_BCO_CONTA_ID = :NEW.BEG_FIN_BCO_CONTA_ID\n       and BC.IND_INTEGRACAO = 'Y'\n    union\n    select NVL(BC.IND_INTEGRACAO, 'N') IND_INTEGRACAO\n      from BEG_FIN_BCO_CONTA BC\n     where BC.BEG_FIN_BCO_CONTA_ID = :NEW.BEG_VW_FIN_BCO_CONTA_ID\n       and BC.IND_INTEGRACAO = 'Y';\n  --\n  R_INTEGRACAO C_INTEGRACAO%rowtype;\n  --  \n  cursor VALIDA_CAIXA is\n    select S.*\n      from BEG_FIN_CAIXA_SALDO S\n     where S.BEG_FIN_CAIXA_ID = :NEW.BEG_FIN_CAIXA_ID\n       and S.DATA = :NEW.DT_INTEGRACAO;\n  --\n  R_VALIDA_CAIXA VALIDA_CAIXA%rowtype;\n  --\n  cursor c_cheque is\n    select c.value, C.DATA_VENCIMENTO, C.NOME\n      from beg_chq_cheque c\n     where beg_chq_cheque_id = :new.beg_chq_cheque_id;\n  --\n  CURSOR C_CONTA IS\n    SELECT NVL(C.IND_BLOQUEIO, 'N') IND_BLOQUEIO\n      FROM BEG_FIN_BCO_CONTA C\n     WHERE C.BEG_FIN_BCO_CONTA_ID = :OLD.BEG_FIN_BCO_CONTA_ID;\n  --\n  R_CONTA C_CONTA%ROWTYPE;\n  --\n  CURSOR C_LOTE IS\n    SELECT *\n      FROM BEG_VEN_CONV_REC_FAT_LOT L\n     WHERE L.BEG_VEN_CONV_REC_FAT_LOT_ID = :NEW.BEG_VEN_CONV_REC_FAT_LOT_ID;\n\n  R_LOTE C_LOTE%ROWTYPE;\n\n  CURSOR C_LOTE1 IS\n    SELECT *\n      FROM BEG_CRC_PGTO_MANUAL L\n     WHERE L.BEG_CRC_PGTO_MANUAL_ID = :NEW.BEG_CRC_PGTO_MANUAL_ID;\n\n  R_LOTE1 C_LOTE1%ROWTYPE;\n\nbegin\n  --\n  IF :NEW.DATA_IDENTIFICACAO IS NOT NULL THEN\n    --\n    open BUSCA_DADOS;\n    FETCH BUSCA_DADOS\n      into V_DADOS;\n    close BUSCA_DADOS;\n    --\n    IF :NEW.DATA_IDENTIFICACAO < V_DADOS.DT_SALDO THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Data de Identificação não pode ser menor que data do Saldo do dia!');\n    end if;\n    --\n  end if;\n  --\n  IF :NEW.BEG_VW_FIN_BCO_CONTA_ID in (1000014, 1000068) AND\n     :NEW.BEG_CRC_PGTO_MANUAL_ID IS NULL THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Faltou informar lote de pagto para este registro!');\n  END IF;\n  --\n  IF :NEW.BEG_VW_FIN_BCO_CONTA_ID = 1000066 AND\n     :NEW.BEG_VEN_CONV_REC_FAT_LOT_ID IS NULL THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Faltou informar lote de convenio para este registro!');\n  END IF;\n  --\n  IF :NEW.BEG_VW_FIN_BCO_CONTA_ID = 1000066 and\n     nvl(:new.ind_integrado, 'N') = 'N' THEN\n  \n    open C_LOTE;\n    FETCH C_LOTE\n      into R_LOTE;\n    close C_LOTE;\n    IF :NEW.VALOR <> R_LOTE.VLR_PREV_REPASSE THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Valor do deposito diferente do valor informado no lote. Verifique!!');\n    END IF;\n  \n  END IF;\n  --\n  IF :NEW.BEG_VW_FIN_BCO_CONTA_ID in (1000014, 1000068) and\n     nvl(:new.ind_integrado, 'N') = 'N' THEN\n  \n    open C_LOTE1;\n    FETCH C_LOTE1\n      into R_LOTE1;\n    close C_LOTE1;\n    IF :NEW.VALOR <> R_LOTE1.VLR_DIGITADO THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Valor do deposito diferente do valor informado no lote. Verifique!!');\n    END IF;\n  \n  END IF;\n  --\n  if nvl(:new.beg_chq_cheque_id, 0) > 0 then\n    open c_cheque;\n    fetch c_cheque\n      into :new.nro_cheque, VD_DT_VENCIMENTO_CHEQUE, VC_NOME;\n    close c_cheque;\n  end if;\n  --\n  open C_INTEGRACAO;\n  fetch C_INTEGRACAO\n    into R_INTEGRACAO;\n  close C_INTEGRACAO;\n  --\n  IF NVL(:NEW.BEG_CHQ_CHEQUE_ID, 0) > 0 or\n     R_INTEGRACAO.IND_INTEGRACAO = 'Y' THEN\n    --\n    if :NEW.DT_INTEGRACAO is not null then\n    \n      select P.VALUE\n        into VC_VALUE_BANCO\n        from BEG_FIN_BCO_SALDO S, BEG_FIN_PORTADOR P\n       where S.BEG_FIN_PORTADOR_ID = P.BEG_FIN_PORTADOR_ID\n         and S.BEG_FIN_BCO_SALDO_ID = :NEW.BEG_FIN_BCO_SALDO_ID;\n    \n      -- SE FOR REAPRESENTACAO VAI PEGAR ESSES PARAMETROS\n      if NVL(:NEW.BEG_CHQ_CHEQUE_ID, 0) > 0 then\n      \n        if trim(VC_VALUE_BANCO) = '901' -- BB\n           or trim(VC_VALUE_BANCO) = '001' then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_BB');\n        elsif trim(VC_VALUE_BANCO) = '041' -- BANRISUL\n              or trim(VC_VALUE_BANCO) = '941' then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_BANRISUL');\n        elsif trim(VC_VALUE_BANCO) = '931' -- BRADESCO\n              or trim(VC_VALUE_BANCO) = '237' then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_BRADESCO');\n        elsif trim(VC_VALUE_BANCO) = '933' -- SANTANDER\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_SANTANDER');\n        elsif trim(VC_VALUE_BANCO) = '104' --CEF\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_CEF');\n        elsif trim(VC_VALUE_BANCO) = '837' --CEF\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_BRA_HSBC');\n        elsif trim(VC_VALUE_BANCO) = '748' -- SICREDI\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_SICREDI');\n        end if;\n        VN_BEG_FIN_CAIXA_HISTORICO_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                     'Contas a Pagar',\n                                                                     'BEG_FIN_CAIXA_HISTORICO_ID_SAI');\n      \n      else\n        --\n        if trim(VC_VALUE_BANCO) = '901' -- BB\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_BB_SAI');\n        elsif trim(VC_VALUE_BANCO) = '001' -- BB\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_BB_NEW_SAI');\n        elsif trim(VC_VALUE_BANCO) = '941' -- BANRISUL\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_BANRISUL_SAI');\n        elsif trim(VC_VALUE_BANCO) = '041' -- BANRISUL\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_BANRISUL_NEW_SAI');\n        elsif trim(VC_VALUE_BANCO) = '937' -- BRADESCO\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_BRADESCO_SAI');\n        elsif trim(VC_VALUE_BANCO) = '237' -- BRADESCO\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_BRADESCO_NEW_SAI');\n        elsif trim(VC_VALUE_BANCO) = '033' -- SANTANDER\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_SANTANDER_SAI');\n        elsif trim(VC_VALUE_BANCO) = '104' --CEF\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_CEF_SAI');\n        elsif trim(VC_VALUE_BANCO) = '748' -- SICREDI\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_SICREDI_SAI');\n        elsif trim(VC_VALUE_BANCO) = '399' -- HSBC\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_HSBC_SAI');\n        elsif trim(VC_VALUE_BANCO) = '837' -- HSBC\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_BRA_HSBC_SAI');\n        elsif trim(VC_VALUE_BANCO) = '136' -- HSBC\n         then\n          VN_BEG_FIN_CAIXA_CONTA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_UNICRED_SAI');\n        end if;\n      \n        VN_BEG_FIN_CAIXA_HISTORICO_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                     'Contas a Pagar',\n                                                                     'BEG_FIN_CAIXA_HISTORICO_DEP_SAI');\n      \n      end if;\n    \n    end if;\n  \n    if R_INTEGRACAO.IND_INTEGRACAO = 'Y' then\n      --  \n    \n      --\n      if NVL(:NEW.BEG_FIN_CAIXA_ID, 0) = 0 and :NEW.DT_INTEGRACAO is null AND\n         NVL(:NEW.BEG_CHQ_CHEQUE_ID, 0) > 0 then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Faltou informar Data Integração e para qual Caixa será enviado');\n      end if;\n      --\n      /*open VALIDA_CAIXA;\n      fetch VALIDA_CAIXA\n        into R_VALIDA_CAIXA;\n      close VALIDA_CAIXA;*/\n    \n      open VALIDA_CAIXA;\n      fetch VALIDA_CAIXA\n        into R_VALIDA_CAIXA;\n      if VALIDA_CAIXA%notfound then\n      \n        VN_BEG_FIN_CAIXA_SALDO_ID := BEG_FNC_AD_SEQUENCE('BEG_FIN_CAIXA_SALDO');\n      \n        insert into BEG_FIN_CAIXA_SALDO\n          (BEG_FIN_CAIXA_SALDO_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           DATA,\n           SALDO_REALIZADO,\n           SALDO_PREVISTO,\n           BEG_FIN_CAIXA_ID,\n           DOCSTATUS,\n           TOTAL_ENTRADAS,\n           TOTAL_SAIDAS,\n           SALDO_ANTERIOR,\n           DATA_MOV,\n           NRO_CAIXA)\n        values\n          (VN_BEG_FIN_CAIXA_SALDO_ID,\n           :NEW.AD_CLIENT_ID,\n           :NEW.AD_ORG_ID,\n           'Y',\n           :NEW.CREATED,\n           :NEW.CREATEDBY,\n           :NEW.UPDATED,\n           :NEW.UPDATEDBY,\n           :NEW.DT_INTEGRACAO,\n           0,\n           0,\n           :NEW.BEG_FIN_CAIXA_ID,\n           'IP',\n           0,\n           0,\n           0,\n           :NEW.DT_INTEGRACAO,\n           0);\n      \n      else\n        VN_BEG_FIN_CAIXA_SALDO_ID := R_VALIDA_CAIXA.BEG_FIN_CAIXA_SALDO_ID;\n      end if;\n      close VALIDA_CAIXA;\n      --\n      open C_VALIDA_DATA;\n      fetch C_VALIDA_DATA\n        into R_VALIDA_DATA;\n      close C_VALIDA_DATA;\n    \n      /* VN_BEG_FIN_CAIXA_HISTORICO_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n      'Contas a Pagar',\n      'BEG_FIN_CAIXA_HISTORICO_ID_SAI');*/\n      --\n      insert into BEG_FIN_CAIXA_MOVIMENTO\n        (BEG_FIN_CAIXA_MOVIMENTO_ID,\n         BEG_FIN_CAIXA_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         TP_MOVTO,\n         BEG_FIN_CAIXA_HISTORICO_ID,\n         BEG_FIN_CAIXA_CONTA_ID,\n         BEG_FILIAL_ID,\n         BEG_FIN_CAIXA_SALDO_ID,\n         DATA_PREVISTA,\n         VLR_MOVIMENTO,\n         historico)\n      values\n        (BEG_FNC_AD_SEQUENCE('BEG_FIN_CAIXA_MOVIMENTO'),\n         :NEW.BEG_FIN_CAIXA_ID,\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         :NEW.ISACTIVE,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         'S',\n         VN_BEG_FIN_CAIXA_HISTORICO_ID,\n         VN_BEG_FIN_CAIXA_CONTA_ID,\n         nvl(:NEW.BEG_VW_FILIAL_ID, 1000016),\n         VN_BEG_FIN_CAIXA_SALDO_ID,\n         :NEW.DT_INTEGRACAO,\n         :NEW.VALOR,\n         to_char(R_VALIDA_DATA.dt_saldo, 'DD/MM/YYYY') || ' ' ||\n         :NEW.Historico);\n    end if;\n    --\n    if NVL(:NEW.NRO_CHEQUE, 0) > 0 and :NEW.DT_INTEGRACAO is not null then\n      --\n      select NVL(A.REAPRESENTAVEL, 'N') REAPRESENTAVEL\n        into VC_IND_REAPRESENTA\n        from BEG_CHQ_ALIQUOTA A\n       where A.BEG_CHQ_ALIQUOTA_ID = :NEW.BEG_CHQ_ALIQUOTA_ID;\n      --\n      select S.BEG_FIN_PORTADOR_ID\n        into VN_BEG_FIN_PORTADOR_ID\n        from BEG_FIN_BCO_SALDO S\n       where S.BEG_FIN_BCO_SALDO_ID = :NEW.BEG_FIN_BCO_SALDO_ID;\n      --\n      if VC_IND_REAPRESENTA = 'Y' then\n        insert into BEG_CHQ_REAPRESENTACAO\n          (BEG_CHQ_REAPRESENTACAO_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           BEG_CHQ_CHEQUE_ID,\n           BEG_FIN_PORTADOR_ID,\n           BEG_CHQ_ALIQUOTA_ID)\n        values\n          (BEG_FNC_AD_SEQUENCE('BEG_CHQ_REAPRESENTACAO'),\n           :NEW.AD_CLIENT_ID,\n           :NEW.AD_ORG_ID,\n           'Y',\n           :NEW.CREATED,\n           :NEW.CREATEDBY,\n           :NEW.UPDATED,\n           :NEW.UPDATEDBY,\n           :NEW.BEG_CHQ_CHEQUE_ID,\n           VN_BEG_FIN_PORTADOR_ID,\n           :NEW.BEG_CHQ_ALIQUOTA_ID);\n      \n      else\n        --\n        open BUSCA_DADOS;\n        FETCH BUSCA_DADOS\n          into V_DADOS;\n        close BUSCA_DADOS;\n        --\n        insert into beg_chq_cobranca_loja\n          (beg_chq_cobranca_loja_id,\n           beg_chq_cheque_id,\n           ad_client_id,\n           ad_org_id,\n           isactive,\n           created,\n           createdby,\n           updated,\n           updatedby,\n           value,\n           docstatus,\n           beg_fin_portador_id,\n           beg_banco_id,\n           beg_agencia_id,\n           beg_fin_conta_corrente_id,\n           beg_chq_aliquota_id,\n           beg_filial_id,\n           nro_conta,\n           dt_devolucao,\n           dt_vencimento,\n           vlr_cheque,\n           nome)\n        values\n          (beg_fnc_ad_sequence('BEG_CHQ_COBRANCA_LOJA'),\n           :NEW.beg_chq_cheque_id,\n           :NEW.ad_client_id,\n           :NEW.ad_org_id,\n           'Y',\n           SYSDATE,\n           :NEW.createdby,\n           SYSDATE,\n           :NEW.updatedby,\n           :NEW.value,\n           'IP',\n           V_DADOS.beg_fin_portador_id,\n           V_DADOS.beg_banco_id,\n           V_DADOS.beg_agencia_id,\n           V_DADOS.beg_fin_conta_corrente_id,\n           :NEW.beg_chq_aliquota_id,\n           :NEW.BEG_VW_FILIAL_ID,\n           NULL,\n           V_DADOS.DT_SALDO,\n           VD_DT_VENCIMENTO_CHEQUE,\n           :NEW.VALOR,\n           VC_NOME);\n      end if;\n    \n      --\n      open VALIDA_CAIXA;\n      fetch VALIDA_CAIXA\n        into R_VALIDA_CAIXA;\n      if VALIDA_CAIXA%notfound then\n      \n        VN_BEG_FIN_CAIXA_SALDO_ID := BEG_FNC_AD_SEQUENCE('BEG_FIN_CAIXA_SALDO');\n      \n        insert into BEG_FIN_CAIXA_SALDO\n          (BEG_FIN_CAIXA_SALDO_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           DATA,\n           SALDO_REALIZADO,\n           SALDO_PREVISTO,\n           BEG_FIN_CAIXA_ID,\n           DOCSTATUS,\n           TOTAL_ENTRADAS,\n           TOTAL_SAIDAS,\n           SALDO_ANTERIOR,\n           DATA_MOV,\n           NRO_CAIXA)\n        values\n          (VN_BEG_FIN_CAIXA_SALDO_ID,\n           :NEW.AD_CLIENT_ID,\n           :NEW.AD_ORG_ID,\n           'Y',\n           :NEW.CREATED,\n           :NEW.CREATEDBY,\n           :NEW.UPDATED,\n           :NEW.UPDATEDBY,\n           :NEW.DT_INTEGRACAO,\n           0,\n           0,\n           :NEW.BEG_FIN_CAIXA_ID,\n           'IP',\n           0,\n           0,\n           0,\n           :NEW.DT_INTEGRACAO,\n           0);\n      \n      else\n        VN_BEG_FIN_CAIXA_SALDO_ID := R_VALIDA_CAIXA.BEG_FIN_CAIXA_SALDO_ID;\n      end if;\n      close VALIDA_CAIXA;\n      --\n      VN_BEG_FIN_CAIXA_HISTORICO_ID := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                                   'Contas a Pagar',\n                                                                   'BEG_FIN_CAIXA_HISTORICO_ID');\n    \n      VN_BEG_FIN_CAIXA_MOVIMENTO_ID := BEG_FNC_AD_SEQUENCE('BEG_FIN_CAIXA_MOVIMENTO');\n      --\n      insert into BEG_FIN_CAIXA_MOVIMENTO\n        (BEG_FIN_CAIXA_MOVIMENTO_ID,\n         BEG_FIN_CAIXA_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         TP_MOVTO,\n         BEG_FIN_CAIXA_HISTORICO_ID,\n         BEG_FIN_CAIXA_CONTA_ID,\n         BEG_FILIAL_ID,\n         BEG_FIN_CAIXA_SALDO_ID,\n         DATA_PREVISTA,\n         VLR_MOVIMENTO,\n         BEG_CHQ_CHEQUE_ID)\n      values\n        (VN_BEG_FIN_CAIXA_MOVIMENTO_ID,\n         :NEW.BEG_FIN_CAIXA_ID,\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         :NEW.ISACTIVE,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         'E',\n         VN_BEG_FIN_CAIXA_HISTORICO_ID,\n         VN_BEG_FIN_CAIXA_CONTA_ID,\n         nvl(:NEW.BEG_VW_FILIAL_ID, 1000016),\n         VN_BEG_FIN_CAIXA_SALDO_ID,\n         :NEW.DT_INTEGRACAO,\n         :NEW.VALOR,\n         :NEW.BEG_CHQ_CHEQUE_ID);\n    \n    end if;\n    --  \n  END IF;\n\n  --  \n  --\n  open C_VALIDA_DATA;\n  fetch C_VALIDA_DATA\n    into R_VALIDA_DATA;\n  close C_VALIDA_DATA;\n  --\n  OPEN C_FECH_CONT;\n  FETCH C_FECH_CONT\n    INTO R_FECH_CONT;\n  CLOSE C_FECH_CONT;\n  --\n\n  --\n  IF UPDATING THEN\n    IF NVL(:NEW.NRO_DOC, 0) > 0 THEN\n      --\n      DELETE FROM beg_cpg_doc_lote_manual C\n       WHERE C.DOCUMENTO = :OLD.NRO_DOC;\n      --\n      DELETE FROM beg_cpg_doc_lote_manual C\n       WHERE C.DOCUMENTO = :NEW.NRO_DOC;\n      --\n      insert into beg_cpg_doc_lote_manual\n        (beg_cpg_doc_lote_manual_id,\n         ad_client_id,\n         ad_org_id,\n         isactive,\n         created,\n         createdby,\n         updated,\n         updatedby,\n         documento,\n         valor,\n         beg_cpg_pgto_manual_id)\n      values\n        (beg_fnc_ad_sequence('BEG_CPG_DOC_LOTE_MANUAL'),\n         :NEW.ad_client_id,\n         :NEW.ad_org_id,\n         :NEW.isactive,\n         :NEW.created,\n         :NEW.createdby,\n         :NEW.updated,\n         :NEW.updatedby,\n         :NEW.NRO_DOC,\n         :NEW.valor,\n         :NEW.beg_cpg_pgto_manual_id);\n    END IF;\n    --\n    open C_FECH_CONT1;\n    fetch C_FECH_CONT1\n      into R_FECH_CONT1;\n    close C_FECH_CONT1;\n  \n    IF :NEW.DATA_IDENTIFICACAO <= R_FECH_CONT.DT_FINAL THEN\n      if nvl(r_FECH_CONT1.ind_escrita, 'N') = 'N' then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Movimento ja encerrado para este periodo!');\n      END IF;\n    END IF;\n    IF :NEW.dt_integracao <= R_FECH_CONT.DT_FINAL THEN\n      if nvl(r_FECH_CONT1.ind_escrita, 'N') = 'N' then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Movimento ja encerrado para este periodo!');\n      END IF;\n    END IF;\n    IF :NEW.Data_Comp <= R_FECH_CONT.DT_FINAL THEN\n      if nvl(r_FECH_CONT1.ind_escrita, 'N') = 'N' then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Movimento ja encerrado para este periodo!');\n      END IF;\n    END IF;\n    --\n  END IF;\n  --\n  OPEN C4;\n  FETCH C4\n    INTO :NEW.PORTADOR;\n  CLOSE C4;\n  --\n  if :new.BEG_VW_FIN_BCO_CONTA_ID is not null and\n     :new.DATA_IDENTIFICACAO is null then\n    RAISE_APPLICATION_ERROR(-20501,\n                            'Conta identificacao deve ser informada somente apos a data de identificacao');\n  end if;\n\n  if INSERTING then\n    open BUSCA_DADOS;\n    FETCH BUSCA_DADOS\n      into V_DADOS;\n    close BUSCA_DADOS;\n    :new.BEG_BANCO_ID              := v_dados.BEG_BANCO_ID;\n    :new.BEG_AGENCIA_ID            := v_dados.BEG_AGENCIA_ID;\n    :new.BEG_FIN_CONTA_CORRENTE_ID := V_DADOS.BEG_FIN_CONTA_CORRENTE_ID;\n    :new.data_lanc                 := v_dados.dt_saldo;\n  End If;\n\n  --\n  if :new.BEG_VW_FIN_BCO_CONTA_ID = :new.Beg_Fin_Bco_Conta_Id then\n    RAISE_APPLICATION_ERROR(-20501,\n                            'Conta identificacao nao pode ser igual a conta original');\n  end if;\n\n  --\n  IF :NEW.DATA_IDENTIFICACAO IS NOT NULL AND\n     :NEW.BEG_VW_FIN_BCO_CONTA_ID IS NULL THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Faltou informar para qual Conta Receira / Despesa Destino!' ||\n                            V_DADOS.dt_saldo || v_dados.beg_fin_portador_id);\n  END IF;\n\n  if INSERTING or updating then\n    If :New.Data_Identificacao Is Not Null AND\n       :new.BEG_VW_FIN_BCO_CONTA_ID IS NOT NULL Then\n      :new.Ind_Integrado := 'Y';\n    Else\n      :New.Ind_Integrado := 'N';\n    end if;\n  end if;\n\n  --\n  IF INSERTING THEN\n    --\n    OPEN C3;\n    FETCH C3\n      INTO R_C3;\n    CLOSE C3;\n    --\n    IF R_C3.DOCSTATUS = 'CL' THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              ' Não pode inserir Movimento onde Saldo já está fechado!');\n    END IF;\n    --\n    IF :NEW.TIPO_MOV = 'E' THEN\n      --\n      UPDATE BEG_FIN_BCO_SALDO B\n         SET B.TOTAL_DEBITOS = NVL(B.TOTAL_DEBITOS, 0) + :NEW.VALOR\n       WHERE B.BEG_FIN_BCO_SALDO_ID = :NEW.BEG_FIN_BCO_SALDO_ID;\n      --\n    ELSE\n      --\n      UPDATE BEG_FIN_BCO_SALDO B\n         SET B.TOTAL_CREDITOS = NVL(B.TOTAL_CREDITOS, 0) + :NEW.VALOR\n       WHERE B.BEG_FIN_BCO_SALDO_ID = :NEW.BEG_FIN_BCO_SALDO_ID;\n      --\n    END IF;\n    --\n  ELSIF UPDATING THEN\n    --\n    IF :NEW.TIPO_MOV = 'E' THEN\n      --\n      IF :NEW.VALOR <> :OLD.VALOR THEN\n        --  \n        UPDATE BEG_FIN_BCO_SALDO B\n           SET B.TOTAL_DEBITOS = NVL(B.TOTAL_DEBITOS, 0) +\n                                 NVL(:NEW.VALOR, 0) - NVL(:OLD.VALOR, 0)\n         WHERE B.BEG_FIN_BCO_SALDO_ID = :NEW.BEG_FIN_BCO_SALDO_ID;\n        --\n      END IF;\n      --\n    ELSE\n      --\n      IF :NEW.VALOR <> :OLD.VALOR THEN\n        --        \n        UPDATE BEG_FIN_BCO_SALDO B\n           SET B.TOTAL_CREDITOS = NVL(B.TOTAL_CREDITOS, 0) +\n                                  NVL(:NEW.VALOR, 0) - NVL(:OLD.VALOR, 0)\n         WHERE B.BEG_FIN_BCO_SALDO_ID = :NEW.BEG_FIN_BCO_SALDO_ID;\n        --\n      END IF;\n      --\n    END IF;\n    --\n    VN_VALIDA := CASE\n                   WHEN :NEW.VLR_ORIGEM < 0 THEN\n                    - :NEW.VLR_ORIGEM\n                   ELSE\n                    :NEW.VLR_ORIGEM\n                 END;\n    /* IF UPDATING(:NEW.VLR_ORIGEM) THEN\n      IF :NEW.VALOR <> VN_VALIDA THEN\n        raise_application_error(-20501,\n                                'Valor total das origens ' ||\n                                TO_CHAR((VN_VALIDA), '999G999G990D00') ||\n                                ' nao fecha com o total do movimento.');\n      END IF;\n    END IF;*/\n    --\n  END IF;\n  --\n  IF DELETING THEN\n    --\n    --\n    OPEN C_CONTA;\n    FETCH C_CONTA\n      INTO R_CONTA;\n    CLOSE C_CONTA;\n    --\n    IF NVL(R_CONTA.IND_BLOQUEIO, 'N') = 'Y' THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Essa conta não permite deleção de movimento do Banco!');\n    END IF;\n    -- \n    OPEN C2;\n    FETCH C2\n      INTO R_C2;\n    IF C2%FOUND THEN\n      raise_application_error(-20001,\n                              'Não pode deletar Movimentos quando Saldo está fechado!');\n    END IF;\n    CLOSE C2;\n    --\n    OPEN C1;\n    FETCH C1\n      INTO R_C1;\n    IF C1%FOUND THEN\n      raise_application_error(-20001,\n                              'Não pode deletar Movimentos que possuem Origem!');\n    END IF;\n    CLOSE C1;\n    --    \n  END IF;\n  --\n  IF UPDATING AND :NEW.BEG_FIN_BCO_SALDO_ID <> :OLD.BEG_FIN_BCO_SALDO_ID THEN\n    OPEN C3;\n    FETCH C3\n      INTO R_C3;\n    CLOSE C3;\n    --\n    IF R_C3.DOCSTATUS = 'CL' THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              ' Não pode inserir Movimento onde Saldo já está fechado!');\n    END IF;\n  END IF;\n\n  --\nEND;\n"}`;
    
    }
}
