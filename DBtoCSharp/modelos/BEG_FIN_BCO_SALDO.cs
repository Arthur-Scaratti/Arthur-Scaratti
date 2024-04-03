
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_BCO_SALDO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_TRANFERENCIA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_TRANSFERENCIA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_SALDO_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_SALDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALDO_DIA_ANTERIOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_DEBITOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_CREDITOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALDO_DIA { get; set; }
        
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
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BI_FIN_BANCO_SALDO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE          \n  --\n  pragma autonomous_transaction;\n  --\n  CURSOR C1 IS\n    SELECT 1\n      FROM BEG_FIN_BCO_SALDO S\n     WHERE S.BEG_BANCO_ID              = :NEW.BEG_BANCO_ID\n       AND S.BEG_AGENCIA_ID            = :NEW.BEG_AGENCIA_ID\n       AND S.BEG_FIN_CONTA_CORRENTE_ID = :NEW.BEG_FIN_CONTA_CORRENTE_ID\n       AND S.DT_SALDO                  > :NEW.DT_SALDO\n       AND S.DOCSTATUS                 = 'CL';\n  --\n  R_C1 C1%ROWTYPE;\n  --\nBEGIN\n  --\n  OPEN C1;\n  FETCH C1 INTO R_C1;\n    IF C1%FOUND THEN\n      RAISE_APPLICATION_ERROR(-20001,'Não pode inserir registros posteriores quando já possui fechados');\n    END IF;\n  CLOSE C1;\n  --\n  :new.saldo_dia_anterior := 0;\n  --\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_FIN_BANCO_SALDO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n  CURSOR C1 IS\n    SELECT *\n      FROM beg_fin_portador C\n     WHERE C.beg_fin_portador_id = :NEW.beg_fin_portador_id;\n  --\n  R_C1 C1%ROWTYPE;\n  --\nBEGIN\n  --\n  if inserting then\n    :new.docstatus := 'IP';\n  end if;\n  --\n  OPEN C1;\n  FETCH C1 INTO R_C1;\n  CLOSE C1;\n  --\n  :NEW.BEG_BANCO_ID              := R_C1.BEG_BANCO_ID;\n  :NEW.BEG_AGENCIA_ID            := R_C1.BEG_AGENCIA_ID;\n  :NEW.BEG_FIN_CONTA_CORRENTE_ID := R_C1.BEG_FIN_CONTA_CORRENTE_ID;\n  --\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUR_SALDO_BCO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  --\n  cursor C_FECH_CONT is\n  select MAX(C.DT_FINAL) DT_FINAL\n    from BEG_FECH_CONTABIL C\n   WHERE C.IND_ESCRITA = 'N';\n  --\n  R_FECH_CONT C_FECH_CONT%rowtype;  \n  --\n  cursor C_FECH_CONT1 is\n  select ind_escrita from BEG_FECH_CONTABIL C where c.dt_final = R_FECH_CONT.DT_FINAL;\n  --\n  R_FECH_CONT1 C_FECH_CONT1%rowtype;\n\nbegin\n  --\n  OPEN C_FECH_CONT;\n  FETCH C_FECH_CONT INTO R_FECH_CONT;\n  CLOSE C_FECH_CONT;\n  --\n  open C_FECH_CONT1;\n  fetch C_FECH_CONT1\n    into R_FECH_CONT1;\n  close C_FECH_CONT1;  \n  --\n  IF :NEW.DT_SALDO <= R_FECH_CONT.DT_FINAL THEN\n  --  if nvl(r_FECH_CONT1.ind_escrita,'N') ='N' then\n      RAISE_APPLICATION_ERROR(-20001,'Não pode deletar, alterar ou inserir registro quando fechamentos contabil está fechado!');    \n  --  END IF;      \n  END IF;\n  --  \nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BD_FIN_BANCO_SALDO { get; set; } = `{"triggering_event":"DELETE","trigger_body":"DECLARE\n  --\n  CURSOR C2 IS\n    SELECT 1\n      FROM BEG_FIN_BCO_MOVTO M\n     WHERE M.BEG_FIN_BCO_SALDO_ID = :OLD.BEG_FIN_BCO_SALDO_ID;\n  --\n  R_C2 C2%ROWTYPE;\n  --\nBEGIN\n  --\n  OPEN C2;\n  FETCH C2 INTO R_C2;\n    IF C2%FOUND THEN\n      RAISE_APPLICATION_ERROR(-20001,'Não pode deletar Saldo Diaro que possuem Movimento!');\n    end if;\n  CLOSE C2;\n  --\nEND;\n"}`;
    
    }
}
