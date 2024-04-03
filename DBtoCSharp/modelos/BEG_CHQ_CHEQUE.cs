
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CHQ_CHEQUE
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_REAPRESENTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ID_CHQ_LOJA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAIXA_HIST_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CHQ_CHEQUE_ID { get; set; }
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
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_VENCIMENTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string CMC7 { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_AGENCIA_ID { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_CONTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DISPONIVEL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// L ou D
        /// </summary>
        public string LEITOR_DIGITADO { get; set; }
            [Required]
    [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NUM_DIAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CUSTODIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_DEVOLUCAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_DEVOLUCAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CHQ_ALIQUOTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PAGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CUSTODIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_BANCO_CUSTODIA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_ID { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO_DBF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_COMPENSACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_COMPENSADO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIR_HISTORICO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n  CURSOR BUSCA_PORTADOR IS \n    SELECT P.BEG_BANCO_ID,\n           P.BEG_AGENCIA_ID,\n           C.CONTA_CORRENTE\n    FROM   BEG_FIN_PORTADOR P,\n           BEG_FIN_CONTA_CORRENTE C \n    WHERE  P.BEG_FIN_PORTADOR_ID = :NEW.BEG_FIN_PORTADOR_ID\n      AND P.BEG_FIN_CONTA_CORRENTE_ID = C.BEG_FIN_CONTA_CORRENTE_ID;\n  --\nBEGIN\n  --\n  IF :NEW.BEG_FIN_PORTADOR_ID > 0 THEN\n    OPEN BUSCA_PORTADOR;\n    FETCH BUSCA_PORTADOR INTO :NEW.BEG_BANCO_ID\n                            , :NEW.BEG_AGENCIA_ID\n                            , :NEW.NRO_CONTA;\n    CLOSE BUSCA_PORTADOR;\n  END IF;\n  INSERT INTO BEG_CHQ_HISTORICO\n    (\n      BEG_CHQ_HISTORICO_ID,\n      AD_CLIENT_ID,\n      AD_ORG_ID,\n      ISACTIVE,\n      CREATED,\n      CREATEDBY,\n      UPDATED,\n      UPDATEDBY,\n      DATA,\n      DESCRICAO,\n      BEG_CHQ_CHEQUE_ID,\n      BEG_FIN_CAIXA_ID,\n      BEG_FIN_CONTA_CORRENTE_ID,\n      DT_EMI_ENT,\n      DT_SAI_COMP\n    )\n    VALUES\n    (\n      beg_fnc_ad_sequence('BEG_CHQ_HISTORICO'),\n      :NEW.AD_CLIENT_ID,\n      :NEW.AD_ORG_ID,\n      'Y',\n      :NEW.CREATED,\n      :NEW.CREATEDBY,\n      :NEW.UPDATED,\n      :NEW.UPDATEDBY,\n      TRUNC(SYSDATE),\n      'EMISSAO',\n      :NEW.BEG_CHQ_CHEQUE_ID,\n      NULL,\n      NULL,\n      NULL,\n      NULL\n    );\n    :NEW.num_dias := :NEW.data_vencimento - :NEW.DATA;\n    IF :new.num_dias > 0 THEN\n      :new.tipo := 'P';\n    ELSE\n      :NEW.tipo:= 'V';\n    END IF;\n    :new.disponivel := 'Y';\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRB_BU_CHEQUE { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"DECLARE \n  CURSOR BUSCA_ALINEA IS \n    SELECT A.NAME\n    FROM beg_chq_aliquota A\n    WHERE A.beg_chq_aliquota_id = :NEW.BEG_CHQ_ALIQUOTA_ID;\n  --\n  V_ALINEA  BUSCA_ALINEA%ROWTYPE;\nBEGIN\n  --\n  IF NVL(:NEW.QTD_REAPRESENTA,0) > 3 THEN\n    RAISE_APPLICATION_ERROR(-20001,'Não pode Reapresentar Cheque mais que 3 vezes!');\n  end if;\n  --\n  if :new.dt_devolucao IS NOT NULL  then\n    :new.ind_devolucao := 'Y';\n    if :new.beg_chq_aliquota_id is null then\n      raise_application_error(-20501,'Informe a Alinea pela qual o cheque foi devolvido');\n    end if;\n  else\n    if :new.beg_chq_aliquota_id is not null then\n      raise_application_error(-20501,'Alinea nao pode ser informada caso o cheque nao esteja devolvida');\n    end if;\n    :new.dt_devolucao := null;\n  end if;\n  :NEW.Num_Dias := Ceil(:NEW.Data_Vencimento - :NEW.DATA);\n  IF :NEW.DT_DEVOLUCAO IS NOT NULL\n    AND :NEW.DT_DEVOLUCAO <> :OLD.DT_DEVOLUCAO THEN\n    OPEN BUSCA_ALINEA; \n    FETCH BUSCA_ALINEA INTO V_ALINEA;\n    CLOSE BUSCA_ALINEA;\n    \n  INSERT INTO BEG_CHQ_HISTORICO\n    (\n      BEG_CHQ_HISTORICO_ID,\n      AD_CLIENT_ID,\n      AD_ORG_ID,\n      ISACTIVE,\n      CREATED,\n      CREATEDBY,\n      UPDATED,\n      UPDATEDBY,\n      DATA,\n      DESCRICAO,\n      BEG_CHQ_CHEQUE_ID,\n      BEG_FIN_CAIXA_ID,\n      BEG_FIN_CONTA_CORRENTE_ID,\n      DT_EMI_ENT,\n      DT_SAI_COMP\n    )\n    VALUES\n    (\n      beg_fnc_ad_sequence('BEG_CHQ_HISTORICO'),\n      :NEW.AD_CLIENT_ID,\n      :NEW.AD_ORG_ID,\n      'Y',\n      :NEW.CREATED,\n      :NEW.CREATEDBY,\n      :NEW.UPDATED,\n      :NEW.UPDATEDBY,\n      TRUNC(SYSDATE),\n      'DEVOLUCAO '||V_ALINEA.NAME,\n      :NEW.BEG_CHQ_CHEQUE_ID,\n      NULL,\n      NULL,\n      NULL,\n      NULL\n    );\n  END IF;\n  IF :NEW.dt_compensacao IS not NULL THEN \n    :new.ind_compensado := 'Y';\n  INSERT INTO BEG_CHQ_HISTORICO\n    (\n      BEG_CHQ_HISTORICO_ID,\n      AD_CLIENT_ID,\n      AD_ORG_ID,\n      ISACTIVE,\n      CREATED,\n      CREATEDBY,\n      UPDATED,\n      UPDATEDBY,\n      DATA,\n      DESCRICAO,\n      BEG_CHQ_CHEQUE_ID,\n      BEG_FIN_CAIXA_ID,\n      BEG_FIN_CONTA_CORRENTE_ID,\n      DT_EMI_ENT,\n      DT_SAI_COMP\n    )\n    VALUES\n    (\n      beg_fnc_ad_sequence('BEG_CHQ_HISTORICO'),\n      :NEW.AD_CLIENT_ID,\n      :NEW.AD_ORG_ID,\n      'Y',\n      :NEW.CREATED,\n      :NEW.CREATEDBY,\n      :NEW.UPDATED,\n      :NEW.UPDATEDBY,\n      TRUNC(SYSDATE),\n      'COMPENSADA ',\n      :NEW.BEG_CHQ_CHEQUE_ID,\n      NULL,\n      NULL,\n      NULL,\n      NULL\n    );\n    ELSE\n    :new.ind_compensado := 'N';\n  end if;\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CHQ_CHEQUE { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"DECLARE\n  --\n  cursor C_FECH_CONT is\n  select MAX(C.DT_FINAL) DT_FINAL\n    from BEG_FECH_CONTABIL C;\n  --\n  R_FECH_CONT C_FECH_CONT%rowtype;\n  --\nBEGIN\n  --\n  OPEN C_FECH_CONT;\n  FETCH C_FECH_CONT INTO R_FECH_CONT;\n  CLOSE C_FECH_CONT;\n  --\n/*  IF :NEW.DATA <= R_FECH_CONT.DT_FINAL THEN\n    RAISE_APPLICATION_ERROR(-20001,'Não pode deletar, alterar ou inserir registro quando fechamentos contabil está fechado!');\n  END IF;\n  --*/\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRB_BIU_CHEQUE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\n  V_BEG_FIN_BCO_SALDO_ID number(10);\n  --\n  cursor C1 is\n    select *\n      from BEG_FIN_PORTADOR P\n     where P.BEG_BANCO_ID = :NEW.BEG_FIN_PORTADOR_ID;\n  --\n  R_C1 C1%rowtype;\n  --\n  cursor C2 is\n    select *\n      from BEG_FIN_BCO_SALDO S\n     where S.BEG_FIN_PORTADOR_ID = :NEW.BEG_FIN_PORTADOR_ID\n       and S.BEG_AGENCIA_ID      = :NEW.BEG_AGENCIA_ID\n       and S.BEG_BANCO_ID        = :NEW.BEG_BANCO_ID\n       AND S.DT_SALDO            = :NEW.DT_COMPENSACAO;\n  --\n  R_C2 C2%rowtype;\n  --\nbegin\n  --\n  IF UPDATING THEN\n    IF :NEW.DT_COMPENSACAO IS NOT NULL AND\n      :NEW.BEG_FIN_PORTADOR_ID IS NULL THEN\n      RAISE_APPLICATION_ERROR(-20001,'Faltou informar Portador!');\n    END IF;\n    \n    IF :NEW.DT_COMPENSACAO IS NOT NULL AND :OLD.DT_COMPENSACAO IS NOT NULL AND :NEW.IND_COMPENSADO = 'Y' AND :NEW.IND_COMPENSADO = :OLD.IND_COMPENSADO THEN\n      RAISE_APPLICATION_ERROR(-20001,'Cheque ja compensado não permite alteração!');    \n    END IF;\n    \n  END IF;\n  --\n  if :NEW.DT_COMPENSACAO is not null and :OLD.DT_COMPENSACAO is null then\n    --\n    open C1;\n    fetch C1\n      into R_C1;\n    if C1%found then\n      :NEW.BEG_FIN_PORTADOR_ID := R_C1.BEG_FIN_PORTADOR_ID;\n      :NEW.IND_COMPENSADO      := 'Y';\n      :NEW.BEG_AGENCIA_ID      := R_C1.BEG_AGENCIA_ID;\n      :NEW.BEG_BANCO_ID        := R_C1.BEG_BANCO_ID;\n      null;\n    end if;\n    close C1;\n    --\n    open C2;\n    fetch C2\n      into R_C2;\n    if C2%found then\n      --\n      V_BEG_FIN_BCO_SALDO_ID := r_c2.BEG_FIN_BCO_SALDO_ID;\n      --\n    else \n      V_BEG_FIN_BCO_SALDO_ID := BEG_FNC_AD_SEQUENCE('BEG_FIN_BCO_SALDO');\n      --\n      insert into BEG_FIN_BCO_SALDO\n        (BEG_FIN_BCO_SALDO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         DT_SALDO,\n         SALDO_DIA_ANTERIOR,\n         TOTAL_DEBITOS,\n         TOTAL_CREDITOS,\n         SALDO_DIA,\n         BEG_BANCO_ID,\n         BEG_AGENCIA_ID,\n         --  BEG_FIN_CONTA_CORRENTE_ID,\n         DOCSTATUS,\n         BEG_FIN_PORTADOR_ID)\n      values\n        (V_BEG_FIN_BCO_SALDO_ID,\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'Y',\n         sysdate,\n         :NEW.CREATEDBY,\n         sysdate,\n         :NEW.UPDATEDBY,\n         :NEW.DT_COMPENSACAO,\n         0,\n         0,\n         0,\n         0,\n         0,\n         0,\n         -- R_LOTE_CPG_DEBITO.BEG_FIN_CONTA_CORRENTE_ID,\n         'IP',\n         :NEW.BEG_FIN_PORTADOR_ID);\n      --\n    end if;\n    close C2;\n    --\n    if NVL(:NEW.IND_COMPENSADO, 'N') = 'Y' then\n    \n      insert into BEG_FIN_BCO_MOVTO\n        (BEG_FIN_BCO_MOVTO_ID,\n        -- BEG_FIN_CONTA_CORRENTE_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         TIPO_MOV,\n         BEG_FIN_BCO_CONTA_ID,\n         BEG_FIN_BCO_SALDO_ID,\n         IND_INTEGRADO,\n         DATA_LANC,\n         VALOR,\n         historico )\n      values\n        (BEG_FNC_AD_SEQUENCE('BEG_FIN_BCO_MOVTO'),\n         --R_LOTE_CPG_DEBITO.BEG_FIN_CONTA_CORRENTE_ID,\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'Y',\n         SYSDATE,\n         :NEW.CREATEDBY,\n         SYSDATE,\n         :NEW.UPDATEDBY,\n         'S',\n         1000037, --beg_fin_bco_conta_id VER QUAL MOVIMENTE TEM QUE SER INSERIDO\n         V_BEG_FIN_BCO_SALDO_ID,\n         'N',\n         :NEW.DATA, -- VER QUAL DATA É PRA SER USADA\n         :NEW.VALOR,\n         'CHEQUE: '||:NEW.VALUE||' - '||:NEW.DATA);\n    \n    elsif NVL(:NEW.IND_COMPENSADO, 'N') = 'N' then\n      --\n      insert into BEG_FIN_BCO_MOVTO\n        (BEG_FIN_BCO_MOVTO_ID,\n        -- BEG_FIN_CONTA_CORRENTE_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         TIPO_MOV,\n         BEG_FIN_BCO_CONTA_ID,\n         BEG_FIN_BCO_SALDO_ID,\n         IND_INTEGRADO,\n         DATA_LANC,\n         VALOR,\n         HISTORICO)\n      values\n        (BEG_FNC_AD_SEQUENCE('BEG_FIN_BCO_MOVTO'),\n         --R_LOTE_CPG_DEBITO.BEG_FIN_CONTA_CORRENTE_ID,\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'Y',\n         SYSDATE,\n         :NEW.CREATEDBY,\n         SYSDATE,\n         :NEW.UPDATEDBY,\n         'S',\n         1000037, --beg_fin_bco_conta_id VER QUAL MOVIMENTE TEM QUE SER INSERIDO\n         V_BEG_FIN_BCO_SALDO_ID,\n         'N',\n         :NEW.DATA, -- VER QUAL DATA É PRA SER USADA\n         :NEW.VALOR,\n         :NEW.VALUE||' - '||:NEW.DATA);\n    \n    end if;\n    --\n  end if;\n  --\nend;\n"}`;
    
    }
}
