
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_CONV_REC_FAT_LOT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_CONV_REC_FAT_LOT_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da Filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo (Y/N)
        /// </summary>
        public string ISACTIVE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Sequencial
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Dta de criacao do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Dta ultima alteracao registro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Usuaro ultima alteracao registro
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// id do convenio
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// Data da atualizacao do lote
        /// </summary>
        public string DT_ATUALIZACAO { get; set; }
            [Required]
        /// <summary>
        /// Valor total do lote
        /// </summary>
        public int VLR_LOTE { get; set; }
            [Required]
        /// <summary>
        /// Quantidades de titulos do lote
        /// </summary>
        public int QTD_TITULO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuario que processou o relatorio
        /// </summary>
        public string USUARIO { get; set; }
            [Required]
        /// <summary>
        /// Dta de vencimento
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// Data de emissao do relatorio
        /// </summary>
        public string DT_EMISSAO_RELATO { get; set; }
            [Required]
        /// <summary>
        /// Percentual de comissao da conveniada
        /// </summary>
        public int PERC_COMISSAO { get; set; }
        
        /// <summary>
        /// Valor do repasse da conveniada
        /// </summary>
        public int VLR_REPASSE { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuario que efetuou a baixa
        /// </summary>
        public string USUARIO_BAIXA { get; set; }
        
        /// <summary>
        /// Data da efetivacao da baixa
        /// </summary>
        public string DT_BAIXA { get; set; }
            [Required]
        /// <summary>
        /// Valor previsto do repasse
        /// </summary>
        public int VLR_PREV_REPASSE { get; set; }
        
        /// <summary>
        /// Situacao do lote (A)tivo / (C)oncluido
        /// </summary>
        public string SIT_LOTE { get; set; }
        
        /// <summary>
        /// Quantidade de titulos a baixar ou baixados
        /// </summary>
        public int QTDE_TITULO_FINAL { get; set; }
        
        /// <summary>
        /// Valor do lote a baixar ou baixados
        /// </summary>
        public int VLR_LOTE_FINAL { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuario do Portal
        /// </summary>
        public string APP_USER { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_BANCO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CAIXA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_INTEGRADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_RECEBIMENTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_FATURAMENTO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_HISTORICO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_CONTA_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_TITULO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ESTORNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_BCO_CONTA_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AI_CONV_REC_FAT_LOT { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n\n  cursor c1 is\n    select M.*\n      from beg_fin_bco_movto m, beg_fin_bco_saldo s\n     where m.beg_fin_bco_conta_id = 1000011\n       and m.beg_vw_fin_bco_conta_id is null\n       and m.data_identificacao is null\n       and m.beg_fin_bco_saldo_id = s.beg_fin_bco_saldo_id\n       and s.beg_fin_portador_id = :new.beg_fin_portador_id\n       AND S.DT_SALDO BETWEEN :NEW.DT_INI AND :NEW.DT_FIM\n       UNION\n       select M.*\n      from beg_fin_bco_movto m, beg_fin_bco_saldo s\n     where m.beg_fin_bco_conta_id = 1000066\n       --and m.beg_vw_fin_bco_conta_id is null\n       --and m.data_identificacao is null\n       and m.beg_ven_conv_rec_fat_lot_id is null\n       and m.beg_fin_bco_saldo_id = s.beg_fin_bco_saldo_id\n       and s.beg_fin_portador_id = :new.beg_fin_portador_id\n       AND S.DT_SALDO BETWEEN :NEW.DT_INI AND :NEW.DT_FIM\n       ;\n\n  cursor c2 is\n\n    select  M.DATA_LANC,\n           M.BEG_FIN_BCO_MOVTO_ID,\n           M.HISTORICO,\n           o.valor vlr_origem,\n           o.beg_fin_bco_movto_origem_id\n      from beg_fin_bco_movto m, beg_fin_bco_saldo s, beg_fin_bco_movto_origem o\n     where m.beg_fin_bco_conta_id = 1000104\n     and o.BEG_VEN_CONV_REC_FAT_LOT_ID is null\n       and m.beg_fin_bco_movto_id = o.beg_fin_bco_movto_id\n       and o.beg_fin_bco_conta_id = 1000066\n       and m.beg_vw_fin_bco_conta_id is null\n       and m.data_identificacao is null\n       and m.beg_fin_bco_saldo_id = s.beg_fin_bco_saldo_id\n       and s.beg_fin_portador_id = :new.beg_fin_portador_id\n       AND S.DT_SALDO BETWEEN :NEW.DT_INI AND :NEW.DT_FIM;\n\n\nbegin\n\n  if :new.ind_banco = 'Y' then\n    for x in c1 loop\n      insert into DIE_FIN_DEP_VINC\n        (DIE_FIN_DEP_VINC_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         VALUE,\n         BEG_FIN_BCO_MOVTO_ID,\n         DATA_IDENTIFICACAO,\n         BEG_VW_FIN_BCO_CONTA_ID,\n         BEG_VEN_CONV_REC_FAT_LOT_ID,\n         VALOR,\n         DATA_LANC,\n         HISTORICO)\n      values\n        (BEG_FNC_AD_SEQUENCE('DIE_FIN_DEP_VINC'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n          'N', --:NEW.ISACTIVE,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         :NEW.VALUE,\n         X.BEG_FIN_BCO_MOVTO_ID,\n         case when x.BEG_FIN_BCO_CONTA_ID = 1000011 then\n         :NEW.Dt_Baixa --DATA_IDENTIFICACAO      ,\n         else \n           null end ,\n         case when x.BEG_FIN_BCO_CONTA_ID = 1000011 then\n         :NEW.BEG_VW_FIN_BCO_CONTA_ID --BEG_VW_FIN_BCO_CONTA_ID ,\n         else \n           null end ,\n         :NEW.BEG_VEN_CONV_REC_FAT_LOT_ID,\n         X.VALOR,\n         X.DATA_LANC,\n         X.HISTORICO);\n\n    end loop;\n    \n    for y in c2 loop\n      insert into DIE_FIN_DEP_VINC\n        (DIE_FIN_DEP_VINC_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         VALUE,\n         BEG_FIN_BCO_MOVTO_ID,\n         DATA_IDENTIFICACAO,\n         BEG_VW_FIN_BCO_CONTA_ID,\n         BEG_VEN_CONV_REC_FAT_LOT_ID,\n         VALOR,\n         DATA_LANC,\n         HISTORICO,\n         BEG_FIN_BCO_MOVTO_ORIGEM_ID)\n      values\n        (BEG_FNC_AD_SEQUENCE('DIE_FIN_DEP_VINC'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n          'N', --:NEW.ISACTIVE,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         :NEW.VALUE,\n         y.BEG_FIN_BCO_MOVTO_ID,\n         :NEW.Dt_Baixa, --DATA_IDENTIFICACAO      ,\n         :NEW.BEG_VW_FIN_BCO_CONTA_ID, --BEG_VW_FIN_BCO_CONTA_ID ,\n         :NEW.BEG_VEN_CONV_REC_FAT_LOT_ID,\n         y.vlr_origem,\n         y.DATA_LANC,\n         y.HISTORICO,\n         Y.BEG_FIN_BCO_MOVTO_ORIGEM_ID);\n\n    end loop;\n    \n    \n    \n  end if;\n\nend BEG_TRG_AI_CONV_REC_FAT_LOT;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CONV_REC_FAT_LOT { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n\n  v_count number := 0;\n  --\n  CURSOR C1 IS\n    SELECT C.PERC_COMISSAO\n      FROM BEG_CONVENIO C\n     WHERE C.BEG_CONVENIO_ID = :NEW.BEG_CONVENIO_ID;\n  --\nBEGIN\n  --\n  OPEN C1;\n  FETCH C1\n    INTO :NEW.PERC_COMISSAO;\n  CLOSE C1;\n  --\n  IF NVL(:NEW.IND_RECEBIMENTO, 'N') = 'Y' AND\n     NVL(:NEW.IND_FATURAMENTO, 'N') = 'Y' THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Não pode marcar Recebimento e Faturamento ao mesmo tempo!');\n  ELSIF NVL(:NEW.IND_RECEBIMENTO, 'N') = 'N' AND\n        NVL(:NEW.IND_FATURAMENTO, 'N') = 'N' THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Faltou informar qual Recebimentou ou Faturamentos deste Lote!');\n  END IF;\n  --\n\n  IF :NEW.BEG_VW_FIN_BCO_CONTA_ID <> 1000066 THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Somente permitido identificar como : CREDITO DE TITULOS - CONVENIO!!');\n  END IF;\n\n  IF :NEW.DT_BAIXA <> :OLD.DT_BAIXA THEN\n  \n    UPDATE DIE_FIN_DEP_VINC D\n       SET D.DATA_IDENTIFICACAO = :NEW.DT_BAIXA\n     WHERE D.BEG_VEN_CONV_REC_FAT_LOT_ID = :NEW.BEG_VEN_CONV_REC_FAT_LOT_ID;\n  \n  END IF;\n\n  IF :NEW.DT_BAIXA > SYSDATE() THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Data da baixa nao pode ser maior que a data atual.!!');\n  END IF;\n\n  if updating and :new.isactive = 'N' and :old.isactive = 'Y' then\n  \n    select count(1)\n      into v_count\n      from DIE_FIN_DEP_VINC d\n     where d.beg_ven_conv_rec_fat_lot_id = :new.beg_ven_conv_rec_fat_lot_id\n       and d.isactive = 'Y';\n  \n    if v_count > 0 then\n      raise_application_error(-20501,\n                              'Lote com deposito vinculado ativo. Verifique!');\n    end if;\n  \n  end if;\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIUD_LOT_CONVENIO_ENCER { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  cursor C_FECH_CONT is\n    select MAX(C.DT_FINAL) DT_FINAL from BEG_FECH_CONTABIL C\n    where c.ind_escrita ='N';\n  --\n  R_FECH_CONT C_FECH_CONT%rowtype;\n  \n  cursor C_BUSCA is  \n\n    select * \n      from BEG_CONVENIO c\n     where c.beg_convenio_id = :new.beg_convenio_id;\n\n  R_BUSCA C_BUSCA%ROWTYPE;\n     \n\nbegin\n  if (updating and :new.dt_baixa <> :old.dt_baixa) or inserting or deleting then\n    open C_FECH_CONT;\n    fetch C_FECH_CONT\n      into R_FECH_CONT;\n    close C_FECH_CONT;\n    if R_FECH_CONT.DT_FINAL >= :new.dt_baixa then\n      raise_application_error(-20501,\n                              'Movimento ja encerrado!' ||\n                              R_FECH_CONT.DT_FINAL);\n    end if;\n  end if;\n  \n  if inserting then \n   OPEN C_BUSCA;\n   FETCH C_BUSCA\n    INTO R_BUSCA;\n   CLOSE C_BUSCA;\n   \n   :NEW.PERC_COMISSAO := R_BUSCA.PERC_COMISSAO;\n   \n    \n  end if;\n  \n  \n  \nend trg_biud_lot_convenio_encer;\n"}`;
    
    }
}
