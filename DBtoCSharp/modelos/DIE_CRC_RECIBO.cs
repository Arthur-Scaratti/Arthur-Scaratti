
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_RECIBO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_RECIBO_ID { get; set; }
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
        public int NRRECIBO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_TAXA_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// CODIGO DE APROVACAO DO CARTAO
        /// </summary>
        public string TID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NR_PARCELA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SALDO { get; set; }
            [StringLength(400)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VALE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTPEDIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CANCELAMENTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRPEDIDO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTREGA_B2W { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_MOVIMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_CAIXA_HISTORICO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_BAIXA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_PRE_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ID_REC_LOJA { get; set; }
        
        /// <summary>
        /// Quando gravado 1 indica que e do televendas e igual id do registro demais
        /// </summary>
        public int SEQ { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indicativo se recibo foi carregado saldo para capa pre-nfs
        /// </summary>
        public string IND_INTEGRADO { get; set; }

        [NotMapped]
        public string Trigger_DIE_BIU_CRC_RECIBO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n\n  IF :OLD.DOCSTATUS<> :NEW.DOCSTATUS AND :NEW.DOCSTATUS='CO' THEN\n\n   :NEW.DT_BAIXA := TRUNC(SYSDATE);\n\n  END IF;\n\n  IF :NEW.SEQ IS NULL THEN\n\n   :NEW.SEQ := :NEW.DIE_CRC_RECIBO_ID;\n\n  END IF;\n\nend DIE_BIU_CRC_RECIBO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIU_CRC_RECIBO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  vn_id number;\n\n  cursor c1 is\n    select t.* from die_car_taxa t where t.die_car_taxa_id = vn_id;\n  r1 c1%rowtype;\n\n  CURSOR C_PRE_NF IS\n    SELECT N.VLR_SALDO_REC, N.VL_TOTAL_NFS, N.BEG_EST_TP_ESPECIE_ID, R.DIE_FAT_NFS_RET_ID\n      FROM DIE_FAT_PRE_NFS N,\n           DIE_FAT_NFS_RET R\n     WHERE N.DIE_FAT_PRE_NFS_ID = :NEW.DIE_FAT_PRE_NFS_ID\n       AND N.DIE_FAT_PRE_NFS_ID = R.DIE_FAT_NFS_RET_ID(+);\n\n  R_PRE_NF C_PRE_NF%ROWTYPE;\n\n  CURSOR C_BUSCA_PRE IS\n    SELECT N.DIE_FAT_PRE_NFS_ID\n      FROM DIE_FAT_PRE_NFS N\n     WHERE N.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n\n  R_BUSCA_PRE C_BUSCA_PRE%ROWTYPE;\n\n\nbegin\n\n  IF INSERTING AND :NEW.DIE_PEDIDO_ID IS NOT NULL AND :NEW.DIE_FAT_PRE_NFS_ID IS NULL THEN\n\n    open C_BUSCA_PRE;\n    fetch C_BUSCA_PRE\n      into R_BUSCA_PRE;\n    close C_BUSCA_PRE;\n\n    :NEW.DIE_FAT_PRE_NFS_ID := R_BUSCA_PRE.DIE_FAT_PRE_NFS_ID;\n\n\n  END IF;\n\n  --\n  IF :NEW.AD_ORG_ID = 1000134 THEN\n\n    IF :NEW.BEG_PESSOA_ID IS NULL THEN\n\n       RAISE_APPLICATION_ERROR(-20001,\n                                'Faltou informar Parceiro Comercial.');\n\n    END IF;\n\n    IF :NEW.BEG_CONDICAO_PAGAMENTO_ID IS NULL THEN\n\n       RAISE_APPLICATION_ERROR(-20001,\n                                'Faltou informar condicao pagamento.');\n\n    END IF;\n\n\n    if :new.die_car_taxa_id is not null then\n\n      vn_id := :new.die_car_taxa_id;\n      open C1;\n      fetch C1\n        into R1;\n      close C1;\n\n      if :new.beg_condicao_pagamento_id = 2000112 and\n         r1.beg_car_tipo_venda_id = 1000001 then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Tipo de cartao selecionado debito diferente da condicao de pagamento');\n      elsif :new.beg_condicao_pagamento_id = 2000118 and\n            r1.beg_car_tipo_venda_id = 1000000 then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Tipo de cartao selecionado credito diferente da condicao de pagamento');\n      end if;\n\n    end if;\n\n  END IF;\n  --\n  IF (:NEW.DOCSTATUS = 'AP' AND NVL(:NEW.IND_INTEGRADO, 'N') = 'N' AND\n     :NEW.DIE_FAT_PRE_NFS_ID IS NOT NULL AND :NEW.ID_REC_LOJA IS NULL) or \n     (updating AND :NEW.DOCSTATUS = 'AP' AND NVL(:NEW.IND_INTEGRADO, 'N') = 'N' AND\n     :NEW.DIE_FAT_PRE_NFS_ID IS NOT NULL AND :NEW.ID_REC_LOJA IS NOT NULL AND :OLD.DIE_FAT_PRE_NFS_ID IS  NULL)  OR \n     (:NEW.DOCSTATUS ='AP' AND NVL(:NEW.IND_INTEGRADO, 'N') ='Y' AND\n     :OLD.DIE_FAT_PRE_NFS_ID <> :NEW.DIE_FAT_PRE_NFS_ID AND :OLD.DOCSTATUS ='AP' AND :OLD.IND_INTEGRADO ='Y' )THEN\n\n\n    open C_PRE_NF;\n    fetch C_PRE_NF\n      into R_PRE_NF;\n    close C_PRE_NF;\n\n    IF R_PRE_NF.DIE_FAT_NFS_RET_ID IS NOT NULL THEN\n\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Nota já emitida não permite vínculo de recibo.');\n\n    END IF;\n\n   /* IF (R_PRE_NF.VLR_SALDO_REC + :NEW.VALOR) = R_PRE_NF.VL_TOTAL_NFS AND R_PRE_NF.BEG_EST_TP_ESPECIE_ID NOT IN (2000002,2000005)  THEN\n      \n    \n    UPDATE DIE_FAT_PRE_NFS N\n       SET N.VLR_SALDO_REC = N.VLR_SALDO_REC + :NEW.VALOR,\n           N.DIE_CRC_RECIBO_ID = :NEW.DIE_CRC_RECIBO_ID\n     WHERE N.DIE_FAT_PRE_NFS_ID = :NEW.DIE_FAT_PRE_NFS_ID;\n          \n\n    ELSE\n\n     UPDATE DIE_FAT_PRE_NFS N\n       SET N.VLR_SALDO_REC = N.VLR_SALDO_REC + :NEW.VALOR\n     WHERE N.DIE_FAT_PRE_NFS_ID = :NEW.DIE_FAT_PRE_NFS_ID;\n\n\n    END IF;*/\n\n\n    :NEW.IND_INTEGRADO := 'Y';\n\n\n\n  END IF;\n\n  IF :NEW.DOCSTATUS = 'CA' AND :OLD.DOCSTATUS <> 'CA' AND\n     NVL(:NEW.IND_INTEGRADO, 'N') = 'Y' AND :NEW.DIE_FAT_PRE_NFS_ID IS NOT NULL THEN\n\n    UPDATE DIE_FAT_PRE_NFS N\n       SET N.VLR_SALDO_REC = N.VLR_SALDO_REC - :NEW.VALOR,\n           N.DIE_CRC_RECIBO_ID = NULL\n     WHERE N.DIE_FAT_PRE_NFS_ID = :NEW.DIE_FAT_PRE_NFS_ID;\n\n  END IF;\n\nend DIE_TRG_BIU_CRC_RECIBO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AIU_CRC_RECIBO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n\n  CURSOR C_PRE_NF IS\n    SELECT N.VLR_SALDO_REC,\n           N.VL_TOTAL_NFS,\n           N.BEG_EST_TP_ESPECIE_ID,\n           R.DIE_FAT_NFS_RET_ID\n      FROM DIE_FAT_PRE_NFS N, DIE_FAT_NFS_RET R\n     WHERE N.DIE_FAT_PRE_NFS_ID = :NEW.DIE_FAT_PRE_NFS_ID\n       AND N.DIE_FAT_PRE_NFS_ID = R.DIE_FAT_NFS_RET_ID(+);\n\n  R_PRE_NF C_PRE_NF%ROWTYPE;\n\nbegin\n\n  --\n  IF (:NEW.DOCSTATUS = 'AP' /*AND NVL(:NEW.IND_INTEGRADO, 'N') = 'N'*/\n     AND :NEW.DIE_FAT_PRE_NFS_ID IS NOT NULL AND :NEW.ID_REC_LOJA IS NULL) or\n     (updating AND :NEW.DOCSTATUS = 'AP' AND\n     NVL(:NEW.IND_INTEGRADO, 'N') = 'N' AND\n     :NEW.DIE_FAT_PRE_NFS_ID IS NOT NULL AND :NEW.ID_REC_LOJA IS NOT NULL AND\n     :OLD.DIE_FAT_PRE_NFS_ID IS NULL) OR\n     (:NEW.DOCSTATUS = 'AP' AND NVL(:NEW.IND_INTEGRADO, 'N') = 'Y' AND\n     :OLD.DIE_FAT_PRE_NFS_ID <> :NEW.DIE_FAT_PRE_NFS_ID AND\n     :OLD.DOCSTATUS = 'AP' AND :OLD.IND_INTEGRADO = 'Y') THEN\n  \n    open C_PRE_NF;\n    fetch C_PRE_NF\n      into R_PRE_NF;\n    close C_PRE_NF;\n  \n    IF R_PRE_NF.DIE_FAT_NFS_RET_ID IS NOT NULL THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Nota já emitida não permite vínculo de recibo.');\n    \n    END IF;\n  \n    IF (R_PRE_NF.VLR_SALDO_REC + :NEW.VALOR) = R_PRE_NF.VL_TOTAL_NFS AND\n       R_PRE_NF.BEG_EST_TP_ESPECIE_ID NOT IN (2000002, 2000005) THEN\n    \n      UPDATE DIE_FAT_PRE_NFS N\n         SET N.VLR_SALDO_REC     = N.VLR_SALDO_REC + :NEW.VALOR,\n             N.DIE_CRC_RECIBO_ID = :NEW.DIE_CRC_RECIBO_ID\n       WHERE N.DIE_FAT_PRE_NFS_ID = :NEW.DIE_FAT_PRE_NFS_ID;\n    \n    ELSE\n    \n      IF R_PRE_NF.BEG_EST_TP_ESPECIE_ID IN (2000002, 2000005) THEN\n      \n        UPDATE DIE_FAT_PRE_NFS N\n           SET N.VLR_SALDO_REC     = N.VLR_SALDO_REC + :NEW.VALOR,\n               N.DIE_CRC_RECIBO_ID = :NEW.DIE_CRC_RECIBO_ID\n         WHERE N.DIE_FAT_PRE_NFS_ID = :NEW.DIE_FAT_PRE_NFS_ID;\n      \n      ELSE\n      \n        UPDATE DIE_FAT_PRE_NFS N\n           SET N.VLR_SALDO_REC = N.VLR_SALDO_REC + :NEW.VALOR\n         WHERE N.DIE_FAT_PRE_NFS_ID = :NEW.DIE_FAT_PRE_NFS_ID;\n      \n      END IF;\n    \n    END IF;\n  \n  END IF;\n\nend DIE_TRG_AIU_CRC_RECIBO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BI_CRC_RECIBO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  -- local variables here\n \nbegin\n\n  --\n  IF :NEW.AD_ORG_ID = 1000134 THEN               \n  \n    :NEW.TID := TRIM(:NEW.TID);\n    :NEW.ENTREGA_B2W := TRIM(:NEW.ENTREGA_B2W);\n  \n    :NEW.NRRECIBO := beg_fnc_retorna_parametro(:NEW.AD_CLIENT_ID,\n                                               :NEW.AD_ORG_ID,\n                                               'Financeiro',\n                                               'Caixa',\n                                               'NRO_RECIBO');\n    \n       UPDATE BEG_PARAMETRO_SISTEMA S\n          SET S.NUMERO = S.NUMERO + 1\n        WHERE S.NAME = 'NRO_RECIBO'\n          AND S.AD_ORG_ID = :NEW.AD_ORG_ID;\n     \n  END IF;\n  --\n  IF :NEW.AD_ORG_ID <> 1000134 AND NVL(:NEW.NRRECIBO,0) = 0 THEN     \n   \n    :NEW.NRRECIBO := :NEW.DIE_CRC_RECIBO_ID;  \n  \n  END IF; \n\n\nend DIE_TRG_BI_CRC_RECIBO;\n"}`;
    
    }
}
