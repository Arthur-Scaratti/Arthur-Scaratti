
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_TIPO_TITULO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TIPO1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TIPO2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CPG_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_FORN_OBRIG { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica se a conta está no processo de recuperacao judicial.
        /// </summary>
        public string IND_RJ { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_DIARIO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do tipo do titulo
        /// </summary>
        public int BEG_CPG_TIPO_TITULO_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// Codigo do tipo do titulo
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// Descric?o do tipo do titulo
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se o titulo e a debito ou a credito
        /// </summary>
        public string DEBITO_CREDITO { get; set; }
            [Required]
        /// <summary>
        /// ID do tipo de movimento (utilizado para inclus?o do(s) titulo(s))
        /// </summary>
        public int BEG_CPG_TPMOV_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_OBRIGA_NOTA { get; set; }

        [NotMapped]
        public string Trigger_ACC_TRG_BIUD_TIPO_TITULO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  cursor c_conta_new is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :NEW.BEG_CPG_CONTA_ID;\n   r_conta_new c_conta_new%rowtype;\n\n   cursor c_conta_old is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :OLD.BEG_CPG_CONTA_ID;\n   r_conta_old c_conta_old%rowtype;\n\nBEGIN\n\n  if inserting and :NEW.BEG_CPG_CONTA_ID IS NOT NULL THEN\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_new.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a inclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if deleting  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    if r_conta_old.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if updating and :NEW.BEG_CPG_CONTA_ID <> :OLD.BEG_CPG_CONTA_ID  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_old.ind_rj ='Y' and r_conta_new.ind_rj ='N' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n\n\nEND ACC_TRG_BIUD_TIPO_TITULO;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BD_BEG_CPG_TIPO_TITULO { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  VN_BEG_CPG_TIPO_TITULO_ID BEG_CPG_TIPO_TITULO.BEG_CPG_TIPO_TITULO_ID%type;\n\nbegin\n  VN_BEG_CPG_TIPO_TITULO_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAM_GERAL('Suprimentos',\n                                                                     'Nota Fiscal Entrada',\n                                                                     'TIPO_TITULO_NFE'));\n\n  if VN_BEG_CPG_TIPO_TITULO_ID = :old.BEG_CPG_TIPO_TITULO_ID then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Tipo de titulo parametrizado como tipo de nota fiscal de entrada!');\n  end if;\n\nend TRG_BD_BEG_CPG_TIPO_TITULO;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIU_BEG_CPG_TIPO_TITULO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  VN_DUMMY number;\n  \nbegin\n  -- Valida se o tipo de movimento cadastrado no tipo de titulo e TOTAL\n  select 1\n    into VN_DUMMY\n    from BEG_CPG_TPMOV\n   where BEG_CPG_TPMOV_ID = :new.BEG_CPG_TPMOV_ID\n     and DEBITO_CREDITO = :new.DEBITO_CREDITO\n     and IND_MOV = 'T';\n\nexception\n  when NO_DATA_FOUND then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Tipo de movimento deve ser total e de debito ou credito conforme o tipo do titulo!');\n  \nend TRG_BIU_BEG_CPG_TIPO_TITULO;\n"}`;
    
    }
}
