
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_NFE_DESPESAS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_NFE_DESPESAS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NFS { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE_NFS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [StringLength(400)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_RATEIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ACUMULADO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ISENTO_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_OUTROS_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ISENTO_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTROS_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_IR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_IR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_INSS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_INSS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_INSS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_ISSQN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ISSQN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ISSQN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FRETE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGURO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESPESAS_FINANCEIRAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PER_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PER_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_PRODUTOS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_NOTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_FATURADO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COTACAO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_FATURA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_PARCELAS { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DIAS_VENCIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CFOP_ENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CFOP_SAI_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_CALCULO_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_CALCULO_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_PISCOFINS { get; set; }
            [StringLength(44)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE_NFE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string P_SERVICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FATURA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VENCIMENTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_MARCADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_ISSQN_SUBITEM_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indicativo para notas modelo 55 se for nota de servico ira pedir obrigatoriamante o tipo de servico DIE_ISSQN_SUBITEM_ID
        /// </summary>
        public string IND_MODELO_55 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_CONTRATOS_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_NF_SEM_CONTRATO { get; set; }

        [NotMapped]
        public string Trigger_ACC_TRG_BIUD_NFE_DESPESAS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  cursor c_conta_new is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :NEW.BEG_CPG_CONTA_ID;\n   r_conta_new c_conta_new%rowtype;\n\n   cursor c_conta_old is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :OLD.BEG_CPG_CONTA_ID;\n   r_conta_old c_conta_old%rowtype;\n\nBEGIN\n\n  if inserting and :NEW.BEG_CPG_CONTA_ID IS NOT NULL THEN\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_new.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a inclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if deleting  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    if r_conta_old.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if updating and :NEW.BEG_CPG_CONTA_ID <> :OLD.BEG_CPG_CONTA_ID  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_old.ind_rj ='Y' and r_conta_new.ind_rj ='N' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n\n\nEND ACC_TRG_BIUD_NFE_DESPESAS;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AIUD_NFE_DESPESAS { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n\n  vqtde  number;\n  vvalor number;\n  -- PRAGMA AUTONOMOUS_TRANSACTION;\n  ---\n  cursor c1 is\n    select a.*\n      from ad_org a\n     where a.encerramento = 'N'\n       and a.ad_org_id not in\n           (11, 12, 1000085, 1000086, 1000097, 1000125, 1000134,1000138,1000001,1000083);\n  R1 C1%rowtype;\n  ---\n\n  cursor c2 is\n    select count(a.ad_org_id) qtde\n      from ad_org a\n     where a.encerramento = 'N'\n       and a.ad_org_id not in\n           (11, 12, 1000085, 1000086, 1000097, 1000125, 1000134,1000138,1000001,1000083);\n  R2 C2%rowtype;\n\n  ---\n\nBEGIN\n  --\n  IF (INSERTING and :new.ind_rateio = 'Y') /*or ( UPDATING AND :OLD.IND_RATEIO = 'N'  AND :new.ind_rateio = 'Y')*/\n   THEN\n  \n    open C2;\n    fetch C2\n      into R2;\n    close C2;\n    vqtde  := r2.qtde;\n    vvalor := round(:new.vlr_total_nota / vqtde, 2);\n  \n    FOR R1 IN C1 LOOP\n    \n      insert into DIE_NFE_DESP_RATEIO\n        (DIE_NFE_DESP_RATEIO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         DIE_NFE_DESPESAS_ID,\n         BEG_FILIAL_ID,\n         VLR_LOJA,\n         DOCSTATUS)\n      VALUES\n        (beg_fnc_ad_sequence('DIE_NFE_DESP_RATEIO'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'Y',\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         :NEW.DIE_NFE_DESPESAS_ID,\n         R1.AD_ORG_ID,\n         vvalor,\n         'WC');\n    \n    end loop;\n  END IF;\n\n  IF INSERTING and :new.ind_rateio = 'N'  and :new.ind_marcado = 'N' THEN\n  \n    FOR R1 IN C1 LOOP\n    \n      insert into DIE_NFE_DESP_RATEIO\n        (DIE_NFE_DESP_RATEIO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         DIE_NFE_DESPESAS_ID,\n         BEG_FILIAL_ID,\n         VLR_LOJA,\n         DOCSTATUS)\n      VALUES\n        (beg_fnc_ad_sequence('DIE_NFE_DESP_RATEIO'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'N',\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         :NEW.DIE_NFE_DESPESAS_ID,\n         R1.AD_ORG_ID,\n         0,\n         'WC');\n    \n    end loop;\n  END IF;\n \n  IF INSERTING and :new.ind_rateio = 'N'  and :new.ind_marcado = 'Y' THEN\n  \n    FOR R1 IN C1 LOOP\n    \n      insert into DIE_NFE_DESP_RATEIO\n        (DIE_NFE_DESP_RATEIO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         DIE_NFE_DESPESAS_ID,\n         BEG_FILIAL_ID,\n         VLR_LOJA,\n         DOCSTATUS)\n      VALUES\n        (beg_fnc_ad_sequence('DIE_NFE_DESP_RATEIO'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'Y',\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         :NEW.DIE_NFE_DESPESAS_ID,\n         R1.AD_ORG_ID,\n         0,\n         'WC');\n    \n    end loop;\n  END IF;\n\n\n  --COMMIT;\n\nEND DIE_TRG_BIUD_NFE_DESPESAS;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BU_NFE_DESPESAS { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n\n  vqtde  number;\n  vvalor number;\n --  PRAGMA AUTONOMOUS_TRANSACTION;\n  ---\n  cursor c1 is\n    select a.*\n      from ad_org a\n     where a.encerramento = 'N'\n       and a.ad_org_id not in\n           (11, 12, 1000085, 1000086, 1000097, 1000125, 1000134,1000138,1000001,1000083);\n  R1 C1%rowtype;\n  ---\n\n  cursor c2 is\n    select count(a.ad_org_id) qtde\n      from ad_org a\n     where a.encerramento = 'N'\n       and a.ad_org_id not in\n           (11, 12, 1000085, 1000086, 1000097, 1000125, 1000134,1000138,1000001,1000083);\n  R2 C2%rowtype;\n\n  ---\n\nBEGIN\n  --\n \n\n  IF UPDATING AND :OLD.IND_RATEIO = 'N' AND :new.ind_rateio = 'Y' THEN\n\n\n\n\n    open C2;\n    fetch C2\n      into R2;\n    close C2;\n    vqtde  := r2.qtde;\n    vvalor := round(:new.vlr_total_nota / vqtde, 2);\n\n    FOR R1 IN C1 LOOP\n \n      UPDATE DIE_NFE_DESP_RATEIO\n         SET ISACTIVE      = 'Y',\n             VLR_LOJA      = vvalor,\n             DOCSTATUS     = 'WC'\n       WHERE DIE_NFE_DESPESAS_ID = :NEW.DIE_NFE_DESPESAS_ID\n         AND BEG_FILIAL_ID = R1.AD_ORG_ID;\n\n    end loop;\n  END IF;\n\n \n\n  --COMMIT;\n\nEND DIE_TRG_BIUD_NFE_DESPESAS;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BI_NFE_DESPESAS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  CURSOR C_CONTR IS\n    SELECT COUNT(1) QTDE\n      FROM DIE_FIN_CONTRATOS C\n     WHERE C.BEG_VW_FORNECEDOR_ID = :NEW.BEG_VW_FORNECEDOR_ID\n       AND C.BEG_CPG_TIPO_TITULO_ID = :NEW.BEG_CPG_TIPO_TITULO_ID\n       AND C.AD_ORG_ID = :NEW.AD_ORG_ID\n       AND C.ISACTIVE='Y'\n       AND C.DT_VCTO >= :NEW.DT_ENTRADA\n       AND C.DOCSTATUS = 'CO';\n  R_CONTR C_CONTR%ROWTYPE;\n\nBEGIN\n  if :new.dt_vencimento - :NEW.DT_ENTRADA < 3 then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Data vencimento nao pode ser menor que a data de entrada mais 3 dias');\n  end if;\n\n  IF DELETING AND :OLD.DOCSTATUS = 'CO' THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Nota de despesa ja aprovada nao pode ser excluida.');\n  END IF;\n\n  IF INSERTING AND :NEW.BEG_EST_TP_ESPECIE_ID <> 2000060 AND\n     :NEW.DIE_ISSQN_SUBITEM_ID IS NULL AND :NEW.IND_MODELO_55 = 'N' THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Faltou informar a Descricao do Servico.');\n  END IF;\n  \n  \n  IF INSERTING  AND :NEW.BEG_CPR_NFE_ID IS NULL THEN\n   \n      OPEN C_CONTR;\n      FETCH C_CONTR\n        INTO R_CONTR;\n      CLOSE C_CONTR;  \n      \n      IF NVL(R_CONTR.QTDE,0) > 0 AND :NEW.IND_NF_SEM_CONTRATO = 'N' THEN\n        \n    RAISE_APPLICATION_ERROR(-20001,\n                            'Fornecedor possui contrato ativo para esta filial. Verifique!!.');      \n      \n      END IF; \n  \n  END IF;\n\nEND DIE_TRG_BI_NFE_DESPESAS;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIUD_NFE_DESPESAS_ENC { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  cursor C_FECH_CONT is\n    select MAX(C.DT_FINAL) DT_FINAL\n      from BEG_FECH_CONTABIL C\n     WHERE C.IND_ESCRITA = 'N';\n\n  R_FECH_CONT C_FECH_CONT%rowtype;\n\n  cursor c_nota is\n    select beg_cpr_nfe_id\n      from beg_cpr_nfe\n     where beg_cpr_nfe_id = :OLD.BEG_CPR_NFE_ID;\n  R_NOTA C_NOTA%ROWTYPE;\n  --\n  --\n  CURSOR C1 IS\n    select T.BEG_CPG_CONTA_ID\n      from BEG_CPG_TIPO_TITULO t\n     where BEG_CPG_TIPO_TITULO_ID = :NEW.BEG_CPG_TIPO_TITULO_ID;\n  R1 C1%rowtype;\n\n  --\n  cursor C_FECH_CONT1 is\n    select ind_escrita\n      from BEG_FECH_CONTABIL C\n     where c.dt_final = R_FECH_CONT.DT_FINAL;\n  --\n  R_FECH_CONT1 C_FECH_CONT1%rowtype;\n\n  CURSOR C_FORNEC IS\n    SELECT F.NAME, F.CPFCNPJ\n      FROM BEG_VW_FORNECEDOR F\n     WHERE F.beg_vw_fornecedor_id = :NEW.BEG_VW_FORNECEDOR_ID;\n  R_FORNEC C_FORNEC%ROWTYPE;\n\nbegin\n   \n   IF INSERTING OR UPDATING THEN\n     open C_FORNEC;\n    fetch C_FORNEC\n      into R_FORNEC;\n    close C_FORNEC;\n    \n     IF R_FORNEC.CPFCNPJ LIKE '03880277%' THEN\n       raise_application_error(-20501,\n                              'Informado como fornecedor o CNPJ da filial. Verifique!!');\n     \n     END IF;\n    \n   END IF;\n\n  if (updating and :NEW.DT_ENTRADA <> :OLD.DT_ENTRADA) or inserting or\n     deleting then\n    open C_FECH_CONT;\n    fetch C_FECH_CONT\n      into R_FECH_CONT;\n    close C_FECH_CONT;\n    open C_FECH_CONT1;\n    fetch C_FECH_CONT1\n      into R_FECH_CONT1;\n    close C_FECH_CONT1;\n    if R_FECH_CONT.DT_FINAL >= :new.DT_ENTRADA then\n      if nvl(r_FECH_CONT1.ind_escrita, 'N') = 'N' then\n        raise_application_error(-20501,\n                                'Movimento ja encerrado!' ||\n                                R_FECH_CONT.DT_FINAL);\n      END IF;\n    end if;\n  end if;\n\n  IF DELETING THEN\n    open C_NOTA;\n    fetch C_NOTA\n      into R_NOTA;\n    close C_NOTA;\n    IF R_NOTA.BEG_CPR_NFE_ID IS NOT NULL THEN\n      raise_application_error(-20501,\n                              'Nota de entrada ainda não excluida. Primeiro excluir a nota de entrada e depois a despesa');\n    END IF;\n  END IF;\n\n  IF INSERTING OR UPDATING THEN\n    open C1;\n    fetch C1\n      into R1;\n    close C1;\n  \n    IF R1.BEG_CPG_CONTA_ID <> :NEW.BEG_CPG_CONTA_ID THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Tipo título diferente da conta contabil. Verifique!');\n    END IF;\n  END IF;\nend TRG_BIUD_NFE_DESPESAS_ENC;\n"}`;
    
    }
}
