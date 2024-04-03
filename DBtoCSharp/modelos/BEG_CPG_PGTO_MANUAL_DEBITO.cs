
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_PGTO_MANUAL_DEBITO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CHEQUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_JUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TARIFA_DOC { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CARTAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CPG_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CPG_TITULO_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_PGTO_MANUAL_DEBITO_ID { get; set; }
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
        public int BEG_CPG_PGTO_MANUAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CONTA_CORRENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_TIPO_DOCUMENTO_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CAIXA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CONTA_CORRENTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_HISTORICO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CC_HISTORICO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_PREVISTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_REALIZADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_ADIANTAMENTO_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AI_CPG_PGTO_MAN_DEB { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n\n  CURSOR C1 IS\n    SELECT O.BEG_CPR_ORDEM_ID, O.VLR_ABERTO\n      FROM BEG_CPR_ORDEM O\n     WHERE O.BEG_VW_FORNECEDOR_ID = :NEW.BEG_VW_FORNECEDOR_ID\n       AND O.DOCSTATUS = 'AP';\n--       AND O.VLR_ABERTO > 0;\n\nbegin\n\n  If :NEW.BEG_CPG_TIPO_TITULO_ID IN (2000212) THEN\n\n    FOR X IN C1 LOOP\n\n      INSERT INTO DIE_CPG_LOTE_ORDEM\n        (DIE_CPG_LOTE_ORDEM_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         VALUE,\n         BEG_CPG_PGTO_MANUAL_ID,\n         BEG_CPG_PGTO_MANUAL_DEBITO_ID,\n         BEG_CPR_ORDEM_ID,\n         VLR_TOTAL_ORDEM,\n         VLR_APAGAR)\n      VALUES\n        (BEG_FNC_AD_SEQUENCE('DIE_CPG_LOTE_ORDEM'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'N', --ISACTIVE                      ,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         NULL, --:NEW.VALUE                         ,\n         :NEW.BEG_CPG_PGTO_MANUAL_ID,\n         :NEW.BEG_CPG_PGTO_MANUAL_DEBITO_ID,\n         X.BEG_CPR_ORDEM_ID,\n         X.VLR_ABERTO, --VLR_TOTAL_ORDEM               ,\n         0 --VLR_APAGAR\n\n         );\n\n    END LOOP;\n  END IF;\n\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BD_CPG_PGTO_MAN_DEB { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  --\n  cursor c1 is\n    select 1\n      from BEG_CPG_PGTO_MANUAL\n     where BEG_CPG_PGTO_MANUAL_ID = :OLD.BEG_CPG_PGTO_MANUAL_ID\n       AND DOCSTATUS              = 'CO';\n  --\n  R_C1 C1%ROWTYPE;\n  --\nbegin\n  --\n  if (updating and nvl(:new.documento,0) = nvl(:old.documento,0)) or deleting  then \n    \n  OPEN C1;\n  FETCH C1 INTO R_C1;\n    IF C1%FOUND THEN\n      RAISE_APPLICATION_ERROR(-20001,'Não pode alterar ou deletar movimentos quando lote estiver fechado!');\n    END IF;  \n  CLOSE C1;\n  \n  end if;\n  --\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_CPG_PGTO_MAN_DEB { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n  VN_BEG_CPG_TITULO_ID NUMBER(10);\n  --\nbegin\n  --\n  IF NVL(:NEW.BEG_CPG_CONTA_ID,0)           > 0 AND NVL(:NEW.BEG_CPG_TIPO_TITULO_ID,0)     = 0 THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'INFORMADO CONTA CONTABIL E NÃO INFORMADO TIPO DE TÍTULO !');\n  \n  END IF;\n\n  IF NVL(:NEW.BEG_CPG_CONTA_ID,0)           = 0 AND NVL(:NEW.BEG_CPG_TIPO_TITULO_ID,0)     > 0 THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'INFORMADO TIPO DE TÍTULO E NÃO INFORMADO CONTA CONTÁBIL !');\n  \n  END IF;\n\n\n  \n  --\n  IF NVL(:NEW.BEG_CPG_TIPO_TITULO_ID,0)     > 0 AND\n     --NVL(:NEW.BEG_VEN_FORMA_PAGAMENTO_ID,0) > 0 AND\n     NVL(:NEW.BEG_CPG_CONTA_ID,0)           > 0 AND\n     NVL(:NEW.BEG_VW_FORNECEDOR_ID,0)       > 0 AND\n     NVL(:NEW.BEG_CPG_TITULO_ID,0) = 0 THEN\n    --\n    VN_BEG_CPG_TITULO_ID := BEG_FNC_AD_SEQUENCE('BEG_CPG_TITULO');\n    --\n    insert into BEG_CPG_TITULO\n                (BEG_CPG_TITULO_ID,\n                 AD_CLIENT_ID,\n                 AD_ORG_ID,\n                 ISACTIVE,\n                 CREATED,\n                 CREATEDBY,\n                 UPDATED,\n                 UPDATEDBY,\n                 value,\n                 PARCELA,\n                 DT_EMISSAO,\n                 DT_RECEBIMENTO,\n                 DT_VCTO,\n                 DT_PGTO,\n                 VLR_TITULO,\n                 VLR_ORIGINAL,\n                 VLR_ENCARGOS,\n                 VLR_ABERTO,\n                 VLR_DESCONTO,\n                 VLR_OUTRAS_DEDUCOES,\n                 VLR_MULTA,\n                 VLR_JUROS,\n                 VLR_OUTROS_ACRESCIMOS,\n                 DOCSTATUS,\n                 OBS,\n                 BEG_VW_FORNECEDOR_ID,\n                 BEG_CPG_TIPO_TITULO_ID,\n                 BEG_CPG_CONTA_ID,\n                 BEG_VEN_FORMA_PAGAMENTO_ID\n                 )\n              values\n                (VN_BEG_CPG_TITULO_ID\n                ,:NEW.AD_CLIENT_ID\n                ,:NEW.AD_ORG_ID\n                ,'Y'\n                ,SYSDATE\n                ,:NEW.CREATEDBY\n                ,SYSDATE\n                ,:NEW.UPDATEDBY\n                ,VN_BEG_CPG_TITULO_ID\n                ,1\n                ,:NEW.DATA_REALIZADA\n                ,:NEW.DATA_REALIZADA\n                ,:NEW.DATA_REALIZADA\n                ,:NEW.DATA_REALIZADA\n                ,:NEW.VALOR\n                ,0\n                ,0\n                ,0\n                ,0\n                ,0\n                ,0\n                ,0\n                ,0\n                ,'WC'\n                ,NULL\n                ,:NEW.BEG_VW_FORNECEDOR_ID\n                ,:NEW.BEG_CPG_TIPO_TITULO_ID\n                ,:NEW.BEG_CPG_CONTA_ID\n                ,:NEW.BEG_VEN_FORMA_PAGAMENTO_ID);\n    --\n    :NEW.BEG_CPG_TITULO_ID := VN_BEG_CPG_TITULO_ID;\n    --\n  END IF;\n  --\n  if (:new.CAIXA = 'N' and :new.CONTA_CORRENTE = 'N' and :new.ind_cheque = 'N' and nvl(:new.ind_cartao,'N') = 'N') THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'DEBITO DEVE SER DE CAIXA OU CONTA CORRENTE OU CHEQUE OU CARTAO !');\n  end if;\n\n  if :new.CONTA_CORRENTE = 'Y'\n     and :new.Beg_Fin_Portador_Id is null then\n    RAISE_APPLICATION_ERROR(-20001, 'PORTADOR DEVE SER INFORMADA !');\n  end if;\n\n  if :new.CONTA_CORRENTE = 'Y'\n     and :new.BEG_FIN_CONTA_CORRENTE_ID is not null\n     and :new.BEG_FIN_CC_HISTORICO_ID is null then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'HISTORICO DE CONTA CORRENTE DEVE SER INFORMADO !');\n  end if;\n\n  if :new.CAIXA = 'Y'\n     and :new.BEG_FIN_CAIXA_ID is not null\n     and :new.BEG_FIN_CAIXA_HISTORICO_ID is null then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'HISTORICO DE CAIXA DEVE SER INFORMADO !');\n  end if;\n\n  if :new.CAIXA = 'Y'\n     and :new.BEG_FIN_CAIXA_ID is null then\n    RAISE_APPLICATION_ERROR(-20001, 'CAIXA DEVE SER INFORMADO !');\n  end if;\n\n  if :new.CAIXA = 'Y' then\n    :new.BEG_FIN_CONTA_CORRENTE_ID := null;\n    :new.BEG_FIN_CC_HISTORICO_ID   := null;\n  end if;\n\n  if :new.CONTA_CORRENTE = 'Y' then\n    :new.BEG_FIN_CAIXA_ID           := null;\n    :new.BEG_FIN_CAIXA_HISTORICO_ID := null;\n  END IF;\n if updating  and :new.isactive <>  :old.isactive then\n   if :new.ISACTIVE = 'Y' and :old.isactive = 'N' then\n      UPDATE BEG_CPG_PGTO_MANUAL\n         set VLR_TOTAL = VLR_TOTAL + :new.valor\n       where BEG_CPG_PGTO_MANUAL_ID = :new.BEG_CPG_PGTO_MANUAL_ID;\n    else\n      update BEG_CPG_PGTO_MANUAL\n         set VLR_TOTAL = VLR_TOTAL - :new.valor\n       where BEG_CPG_PGTO_MANUAL_ID = :new.BEG_CPG_PGTO_MANUAL_ID;\n    END IF;\n  end if;\nend;\n"}`;
    
    }
}
