
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_MONTAGEM
    {
        
        /// <summary>
        /// Percentual paga ao cobrador para montagem externa ( OM gerada sobre venda) - TABELA DIE_PARAMETROS_FIL ( PERC_MON_EXTERNA )
        /// </summary>
        public int PERC_MONTAGEM { get; set; }
            [Required]
    [Key]
        /// <summary>
        ///  
        /// </summary>
        public int DIE_FAT_MONTAGEM_ID { get; set; }
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
        /// Id nota de venda 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
            [Required]
        /// <summary>
        /// Id parceiro comercial(MONTADOR)
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// Data previsao 
        /// </summary>
        public string DT_PREVISAO { get; set; }
        
        /// <summary>
        /// Data da execucao da montagem encerramento
        /// </summary>
        public string DT_BAIXA { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [Required]
        /// <summary>
        /// nrmontagem igual ao id do registro
        /// </summary>
        public int NRMONTAGEM { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// WC- Aguarda impressao,  AP - impresso,  CO completo,  CA - Cancelada
        /// </summary>
        public string DOCSTATUS { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_MONTAGEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n\ncursor c1 is\nselect n.*\nFROM  beg_fat_nfs n\nwhere n.beg_fat_nfs_id = :NEW.BEG_FAT_NFS_ID;\nR1 C1%ROWTYPE;\n\n \nBEGIN\n\n IF INSERTING THEN\n\n   :NEW.NRMONTAGEM := :NEW.DIE_FAT_MONTAGEM_ID;\n   \n   OPEN C1;\n  FETCH C1\n    INTO R1;\n  CLOSE C1;\n\n  :NEW.BEG_PESSOA_ID := R1.BEG_VW_PESSOA_ENTREGA_ID;\n  :NEW.AD_ORG_ID     := R1.AD_ORG_ID;\n  \n\n   \n   \n   \n\n END IF;\n \n  \n   OPEN C1;\n  FETCH C1\n    INTO R1;\n  CLOSE C1;\n \n  IF :NEW.DT_PREVISAO < R1.DT_EMISSAO  THEN\n    \n   RAISE_APPLICATION_ERROR(-20001,\n                            'Data de previsão de montagem não pode ser anterior a data de emissão da nota. Verifique !');\n    \n  END IF;\n  \n  IF UPDATING AND :NEW.DT_PREVISAO > TRUNC(SYSDATE + 180) THEN\n    \n   RAISE_APPLICATION_ERROR(-20001,\n                            'Data de previsão de montagem não pode superior a 180 dias. Verifique !');\n    \n  END IF;\n  \n  IF UPDATING AND :NEW.DT_BAIXA IS NOT NULL AND :OLD.DT_BAIXA  IS NULL THEN\n    \n    :NEW.DOCSTATUS := 'CO';\n  \n  END IF;\n\n END DIE_TRG_BIUD_MONTAGEM;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AI_FAT_MONTAGEM { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n\n  CURSOR C1 IS\n    select i.*\n      from beg_fat_nfs_item i, beg_produto p, die_prd_subgrupo s\n     where i.beg_produto_id = p.beg_produto_id\n       and p.die_prd_subgrupo_id = s.die_prd_subgrupo_id\n       and s.montagem = 'Y'\n       and i.beg_fat_nfs_id = :NEW.BEG_FAT_NFS_ID;\n  R_C1 C1%ROWTYPE;\n\nBEGIN\n\n  OPEN C1;\n  FETCH C1\n    INTO R_C1;\n  CLOSE C1;\n\n  IF R_C1.BEG_FAT_NFS_ITEM_ID IS NULL THEN\n  \n    RAISE_APPLICATION_ERROR(-20001,\n                            'Nota não possui itens que permite montagem !');\n  \n  END IF;\n\n  FOR X IN C1 LOOP\n  \n    INSERT INTO DIE_FAT_MONTAGEM_ITEM\n      (DIE_FAT_MONTAGEM_ITEM_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       BEG_FAT_NFS_ITEM_ID,\n       QTDE,\n       VLR_UNITARIO,\n       VL_DESCONTO,\n       DIE_FAT_MONTAGEM_ID)\n    VALUES\n      (BEG_FNC_AD_SEQUENCE('DIE_FAT_MONTAGEM_ITEM'),\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID,\n       :NEW.ISACTIVE,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       X.BEG_FAT_NFS_ITEM_ID,\n       X.QTDE,\n       X.VL_UNITARIO,\n       X.VL_DESCONTO,\n       :NEW.DIE_FAT_MONTAGEM_ID);\n  \n  END LOOP;\n\nEND DIE_TRG_AI_FAT_MONTAGEM;\n"}`;
    
    }
}
