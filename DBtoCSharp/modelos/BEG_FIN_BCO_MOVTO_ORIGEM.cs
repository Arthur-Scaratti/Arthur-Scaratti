
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_BCO_MOVTO_ORIGEM
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CPG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CRC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTO { get; set; }
        
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
        public int BEG_FIN_BCO_SALDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TITULO_ID { get; set; }
        
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
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_MOVTO_ORIGEM_ID { get; set; }
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
            [Required]
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_MOVTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_MOVTO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AT_VLR_MOVTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"DECLARE\n  --\n  CURSOR busca_movto_bco IS\n    SELECT *\n      FROM beg_fin_bco_movto m\n     WHERE m.beg_fin_bco_movto_id =\n           nvl(:NEW.beg_fin_bco_movto_id, :old.beg_fin_bco_movto_Id);\n  --\n  v_movto_bco busca_movto_bco%rowtype;\n\n  --\n  vn_old number(17, 4);\n  vn_new number(17, 4);\n  --\n  CURSOR C1 IS\n    SELECT S.DOCSTATUS\n      FROM BEG_FIN_BCO_SALDO S, BEG_FIN_BCO_MOVTO M\n     WHERE S.BEG_FIN_BCO_SALDO_ID = M.BEG_FIN_BCO_SALDO_ID\n       AND M.BEG_FIN_BCO_MOVTO_ID = :OLD.BEG_FIN_BCO_MOVTO_ID;\n  --\n  R_C1 C1%ROWTYPE;\n  --\n  CURSOR C2 IS\n    SELECT S.DOCSTATUS\n      FROM BEG_FIN_BCO_SALDO S, BEG_FIN_BCO_MOVTO M\n     WHERE S.BEG_FIN_BCO_SALDO_ID = M.BEG_FIN_BCO_SALDO_ID\n       AND M.BEG_FIN_BCO_MOVTO_ID = :NEW.BEG_FIN_BCO_MOVTO_ID;\n  --\n  R_C2 C2%ROWTYPE;\n  --\nBEGIN\n  OPEN busca_movto_bco;\n  fetch busca_movto_bco\n    INTO v_movto_bco;\n  close busca_movto_bco;\n  IF INSERTING THEN\n    --\n    OPEN C2;\n    FETCH C2\n      INTO R_C2;\n    CLOSE C2;\n    --\n    IF R_C2.DOCSTATUS = 'CL' THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Não pode inserir Origem com Saldo fechado');\n    END IF;\n    --\n\n    if :new.tp_movto = 'D' then\n      -- (D) = Debito\n      UPDATE BEG_FIN_BCO_MOVTO M\n         set m.vlr_origem = nvl(m.vlr_origem, 0) + NVL(:new.VALOR, 0)\n       where M.BEG_FIN_BCO_MOVTO_ID = :new.BEG_FIN_BCO_MOVTO_ID;\n\n      --\n    ELSE\n      --\n\n      UPDATE BEG_FIN_BCO_MOVTO M\n         set m.vlr_origem = nvl(m.vlr_origem, 0) - NVL(:new.VALOR, 0)\n       where M.BEG_FIN_BCO_MOVTO_ID = :new.BEG_FIN_BCO_MOVTO_ID;\n    END IF;\n\n  ELSIF UPDATING then\n\n    --\n    IF v_movto_bco.tipo_mov = 'E' THEN\n      --\n      if :new.tp_movto = 'D' then\n        -- (D) = Debito\n\n        if :new.tp_movto = :old.tp_movto then\n          --\n          vn_old := nvl(vn_old, 0) - nvl(:old.valor, 0);\n          vn_new := nvl(vn_new, 0) + nvl(:new.valor, 0);\n          --\n          UPDATE BEG_FIN_BCO_MOVTO M\n             set m.vlr_origem = m.vlr_origem + vn_new + vn_old\n           where M.BEG_FIN_BCO_MOVTO_ID = :new.BEG_FIN_BCO_MOVTO_ID;\n\n        else\n          vn_old := nvl(vn_old, 0) + nvl(:old.valor, 0);\n          vn_new := nvl(vn_new, 0) + nvl(:new.valor, 0);\n          --\n          UPDATE BEG_FIN_BCO_MOVTO M\n             set m.vlr_origem = m.vlr_origem + vn_new + vn_old\n           where M.BEG_FIN_BCO_MOVTO_ID = :new.BEG_FIN_BCO_MOVTO_ID;\n        end if;\n\n      else\n        if :new.tp_movto = :old.tp_movto then\n\n          vn_old := nvl(vn_old, 0) + nvl(:old.valor, 0);\n          vn_new := nvl(vn_new, 0) - nvl(:new.valor, 0);\n          --\n          UPDATE BEG_FIN_BCO_MOVTO M\n             set m.vlr_origem = m.vlr_origem + vn_new + vn_old\n           where M.BEG_FIN_BCO_MOVTO_ID = :new.BEG_FIN_BCO_MOVTO_ID;\n        else\n          vn_old := nvl(vn_old, 0) - nvl(:old.valor, 0);\n          vn_new := nvl(vn_new, 0) - nvl(:new.valor, 0);\n          --\n          UPDATE BEG_FIN_BCO_MOVTO M\n             set m.vlr_origem = m.vlr_origem + vn_new + vn_old\n           where M.BEG_FIN_BCO_MOVTO_ID = :new.BEG_FIN_BCO_MOVTO_ID;\n        end if;\n      END IF;\n    ELSE\n      --\n      vn_old := nvl(vn_old, 0) + nvl(:old.valor, 0);\n      vn_new := nvl(vn_new, 0) - nvl(:new.valor, 0);\n      --\n      UPDATE BEG_FIN_BCO_MOVTO M\n         set m.vlr_origem = m.vlr_origem + vn_new + vn_old\n       where M.BEG_FIN_BCO_MOVTO_ID = :new.BEG_FIN_BCO_MOVTO_ID;\n    END IF;\n    --\n  END IF;\n  --\n\n  --\n  IF DELETING THEN\n    --\n    OPEN C1;\n    FETCH C1\n      INTO R_C1;\n    CLOSE C1;\n    --\n    IF R_C1.DOCSTATUS = 'CL' THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Não pode deletar registros onde Saldo já está fechado!');\n    END IF;\n\n    if :old.tp_movto = 'D' then\n      -- (D) = Debito\n      UPDATE BEG_FIN_BCO_MOVTO M\n         set m.vlr_origem = nvl(m.vlr_origem, 0) - NVL(:old.VALOR, 0)\n       where M.BEG_FIN_BCO_MOVTO_ID = :old.BEG_FIN_BCO_MOVTO_ID;\n      -- end if;\n      --\n    ELSE\n      --\n\n      --\n      UPDATE BEG_FIN_BCO_MOVTO M\n         set m.vlr_origem = nvl(m.vlr_origem, 0) + NVL(:old.VALOR, 0)\n       where M.BEG_FIN_BCO_MOVTO_ID = :old.BEG_FIN_BCO_MOVTO_ID;\n    END IF;\n\n  END IF;\n  --\nEND;\n"}`;
    
    }
}
