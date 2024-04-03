
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_NF_CONTRATOS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_NF_CONTRATOS_ID { get; set; }
        
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
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BRUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIQUIDO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_IR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_INSS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_INSS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_CONTRATOS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUMERO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_MODELO_55 { get; set; }
            [StringLength(44)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE_NFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_IR_NEW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ISSQN_NEW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_PIS_NEW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COFINS_NEW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_INSS_NEW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IR_NEW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ISSQN_NEW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS_NEW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS_NEW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_INSS_NEW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_NFE_DESPESAS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BRUTO_NEW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIQUIDO_NEW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO_NEW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CFOP_SAI_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CFOP_ENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }

        [NotMapped]
        public string Trigger_ACC_TRG_BIUD_NF_CONTRATOS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  cursor c_conta_new is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :NEW.BEG_CPG_CONTA_ID;\n   r_conta_new c_conta_new%rowtype;\n\n   cursor c_conta_old is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :OLD.BEG_CPG_CONTA_ID;\n   r_conta_old c_conta_old%rowtype;\n\nBEGIN\n\n  if inserting and :NEW.BEG_CPG_CONTA_ID IS NOT NULL THEN\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_new.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a inclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if deleting  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    if r_conta_old.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if updating and :NEW.BEG_CPG_CONTA_ID <> :OLD.BEG_CPG_CONTA_ID  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_old.ind_rj ='Y' and r_conta_new.ind_rj ='N' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n\n\nEND ACC_TRG_BIUD_NF_CONTRATOS;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_FIN_NF_CONTRATOS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  V_NF_ID NUMBER(10);\n\n  CURSOR C1 IS\n    SELECT C.*\n      FROM DIE_FIN_CONTRATOS C\n     WHERE C.DIE_FIN_CONTRATOS_ID = :NEW.DIE_FIN_CONTRATOS_ID\n       AND C.BEG_VW_FORNECEDOR_ID = :NEW.BEG_VW_FORNECEDOR_ID\n       AND C.AD_ORG_ID = :NEW.AD_ORG_ID\n       AND C.DOCSTATUS = 'CO';\n  R1 C1%ROWTYPE;\n\n  CURSOR C2 IS\n    SELECT N.BEG_CPR_NFE_ID, N.DIE_NFE_DESPESAS_ID\n      FROM BEG_CPR_NFE N\n     WHERE N.DIE_FIN_CONTRATOS_ID = :NEW.DIE_FIN_CONTRATOS_ID\n       AND N.DOCSTATUS = 'WC'\n       AND N.DT_EMISSAO =\n           (SELECT MIN(NF.DT_EMISSAO)\n              FROM BEG_CPR_NFE NF\n             WHERE NF.DIE_FIN_CONTRATOS_ID = :NEW.DIE_FIN_CONTRATOS_ID\n               AND NF.DOCSTATUS = 'WC');\n  R2 C2%ROWTYPE;\n\n  CURSOR C3 IS\n    SELECT DISTINCT (TIT.DT_VCTO) DT_VCTO\n      FROM BEG_CPG_TITULO TIT\n     WHERE TIT.BEG_CPR_NFE_ID = V_NF_ID;\n  R3 C3%ROWTYPE;\n\nBEGIN\n\n  IF INSERTING THEN\n  \n    OPEN C1;\n    FETCH C1\n      INTO R1;\n    CLOSE C1;\n  \n    IF R1.AD_ORG_ID IS NULL THEN\n    \n      RAISE_APPLICATION_ERROR(-20001, 'Dados nao localizados . Verifique!');\n    \n    END IF;\n  \n    IF :NEW.DIE_FIN_CONTRATOS_ID IS NULL THEN\n    \n      :NEW.DIE_FIN_CONTRATOS_ID := R1.DIE_FIN_CONTRATOS_ID;\n    \n    END IF;\n  \n    IF R1.IND_MODELO_55 = 'Y' AND :NEW.CHAVE_NFE IS NULL THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Contrato com nota modelo 55. Favor informar a chave de acessoda NF!');\n    \n    END IF;\n  \n    OPEN C2;\n    FETCH C2\n      INTO R2;\n    CLOSE C2;\n  \n    V_NF_ID := R2.BEG_CPR_NFE_ID;\n    \n    IF V_NF_ID  IS NULL THEN\n    \n      RAISE_APPLICATION_ERROR(-20001, 'Contrato nao possui nota em aberto . Verifique!');\n    \n    END IF;\n  \n    OPEN C3;\n    FETCH C3\n      INTO R3;\n    CLOSE C3;\n  \n    :NEW.AD_ORG_ID              := R1.AD_ORG_ID;\n    :NEW.BEG_VW_FORNECEDOR_ID   := R1.BEG_VW_FORNECEDOR_ID;\n    :NEW.VLR_BRUTO              := R1.VLR_BRUTO;\n    :NEW.VLR_BRUTO_NEW          := R1.VLR_BRUTO;\n    :NEW.VLR_LIQUIDO            := R1.VLR_LIQUIDO;\n    :NEW.VLR_LIQUIDO_NEW        := R1.VLR_LIQUIDO;\n    :NEW.BEG_CPG_CONTA_ID       := R1.BEG_CPG_CONTA_ID;\n    :NEW.OBSERVACAO             := R1.OBSERVACAO;\n    :NEW.BEG_CPG_TIPO_TITULO_ID := R1.BEG_CPG_TIPO_TITULO_ID;\n    :NEW.PERC_IR                := R1.PERC_IR;\n    :NEW.PERC_ISSQN             := R1.PERC_ISSQN;\n    :NEW.PERC_PIS               := R1.PERC_PIS;\n    :NEW.PERC_COFINS            := R1.PERC_COFINS;\n    :NEW.PERC_INSS              := R1.PERC_INSS;\n    :NEW.VLR_IR                 := R1.VLR_IR;\n    :NEW.VLR_ISSQN              := R1.VLR_ISSQN;\n    :NEW.VLR_PIS                := R1.VLR_PIS;\n    :NEW.VLR_COFINS             := R1.VLR_COFINS;\n    :NEW.VLR_INSS               := R1.VLR_INSS;\n    :NEW.BEG_EST_TP_ESPECIE_ID  := R1.BEG_EST_TP_ESPECIE_ID;\n    :NEW.PERC_IR_NEW            := R1.PERC_IR;\n    :NEW.PERC_ISSQN_NEW         := R1.PERC_ISSQN;\n    :NEW.PERC_PIS_NEW           := R1.PERC_PIS;\n    :NEW.PERC_COFINS_NEW        := R1.PERC_COFINS;\n    :NEW.PERC_INSS_NEW          := R1.PERC_INSS;\n    :NEW.VLR_IR_NEW             := R1.VLR_IR;\n    :NEW.VLR_ISSQN_NEW          := R1.VLR_ISSQN;\n    :NEW.VLR_PIS_NEW            := R1.VLR_PIS;\n    :NEW.VLR_COFINS_NEW         := R1.VLR_COFINS;\n    :NEW.VLR_INSS_NEW           := R1.VLR_INSS;\n    :NEW.IND_MODELO_55          := R1.IND_MODELO_55;\n    :NEW.DIE_NFE_DESPESAS_ID    := R2.DIE_NFE_DESPESAS_ID;\n    :NEW.BEG_CPR_NFE_ID         := R2.BEG_CPR_NFE_ID;\n    :NEW.DT_VCTO                := R3.DT_VCTO;\n    :NEW.DT_VCTO_NEW            := R3.DT_VCTO;\n    :NEW.BEG_VW_CFOP_SAI_ID     := R1.BEG_VW_CFOP_SAI_ID;\n    :NEW.BEG_VW_CFOP_ENT_ID     := R1.BEG_VW_CFOP_ENT_ID;\n    :NEW.BEG_PRODUTO_ID         := R1.BEG_PRODUTO_ID;\n  \n  END IF;\n\n  IF UPDATING THEN\n  \n    IF :NEW.PERC_IR_NEW > 0 THEN\n    \n      :NEW.VLR_IR_NEW := ROUND((:NEW.VLR_BRUTO_NEW * :NEW.PERC_IR_NEW) / 100,\n                               2);\n    \n    END IF;\n  \n    IF :NEW.PERC_PIS_NEW > 0 THEN\n    \n      :NEW.VLR_PIS_NEW := ROUND((:NEW.VLR_BRUTO_NEW * :NEW.PERC_PIS_NEW) / 100,\n                                2);\n    \n    END IF;\n  \n    IF :NEW.PERC_COFINS_NEW > 0 THEN\n    \n      :NEW.VLR_COFINS_NEW := ROUND((:NEW.VLR_BRUTO_NEW *\n                                   :NEW.PERC_COFINS_NEW) / 100,\n                                   2);\n    \n    END IF;\n  \n    IF :NEW.PERC_ISSQN_NEW > 0 THEN\n    \n      :NEW.VLR_ISSQN_NEW := ROUND((:NEW.VLR_BRUTO_NEW * :NEW.PERC_ISSQN_NEW) / 100,\n                                  2);\n    \n    END IF;\n  \n    IF :NEW.PERC_INSS_NEW > 0 THEN\n    \n      :NEW.VLR_INSS_NEW := ROUND((:NEW.VLR_BRUTO_NEW * :NEW.PERC_INSS_NEW) / 100,\n                                 2);\n    \n    END IF;\n  \n    :NEW.VLR_LIQUIDO_NEW := :NEW.VLR_BRUTO_NEW - :NEW.VLR_IR_NEW -\n                            :NEW.VLR_PIS_NEW - :NEW.VLR_COFINS_NEW -\n                            :NEW.VLR_ISSQN_NEW - :NEW.VLR_INSS_NEW;\n  \n  END IF;\n---- Acrescentado bloco de testes das datas em 20/12/2023 por Marcelo Fritsch\n\n  IF INSERTING OR UPDATING THEN \n    \n    IF :NEW.DT_ENTRADA < :NEW.DT_EMISSAO THEN \n       RAISE_APPLICATION_ERROR(-20001,'Data de Entrada não pode ser menor que Data de Emissão da nota');\n    END IF;\n  \n    IF :NEW.DT_VCTO < :NEW.DT_EMISSAO THEN \n       RAISE_APPLICATION_ERROR(-20001,'Data de Vencimento não pode ser menor que Data de Emissão da nota');\n    END IF;\n    \n    IF NVL(:NEW.DT_VCTO_NEW,TRUNC(SYSDATE)) < :NEW.DT_EMISSAO THEN \n       RAISE_APPLICATION_ERROR(-20001,'Nova Data de Vencimento não pode ser menor que Data de Emissão da nota');\n    END IF;\n    \n    IF :NEW.DT_VCTO < :NEW.DT_ENTRADA THEN \n       RAISE_APPLICATION_ERROR(-20001,'Data de Vencimento não pode ser menor que Data de Entrada da nota');\n    END IF;\n    \n    IF NVL(:NEW.DT_VCTO_NEW,TRUNC(SYSDATE)) < :NEW.DT_ENTRADA THEN \n       RAISE_APPLICATION_ERROR(-20001,'Nova Data de Vencimento não pode ser menor que Data de Entrada da nota');\n    END IF;  \n  \n  END IF;\n  \n  IF DELETING AND :OLD.DOCSTATUS = 'CO' THEN\n  \n    RAISE_APPLICATION_ERROR(-20001,\n                            'Nota ja processada, não permite exclusão!');\n  \n  END IF;\n\nEND;\n"}`;
    
    }
}
