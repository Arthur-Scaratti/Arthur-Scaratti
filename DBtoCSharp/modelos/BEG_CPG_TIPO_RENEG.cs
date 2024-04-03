
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_TIPO_RENEG
    {
            [StringLength(1)]
        /// <summary>
        /// Indica se a conta está no processo de recuperacao judicial.
        /// </summary>
        public string IND_RJ { get; set; }
        
        /// <summary>
        /// ID da conta de lancamento para os titulos gerados pela renegociac?o
        /// </summary>
        public int BEG_VW_CPG_CONTA_DEST_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CPG_CONTA_ORIG_ID { get; set; }
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
        /// Codigo do tipo da renegociac?o
        /// </summary>
        public int VALUE { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// Descric?o do tipo da renegociac?o
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// ID do tipo de titulo para renegociac?o
        /// </summary>
        public int BEG_CPG_TIPO_TITULO_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do tipo da renegociac?o
        /// </summary>
        public int BEG_CPG_TIPO_RENEG_ID { get; set; }
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

        [NotMapped]
        public string Trigger_ACC_TRG_BIUD_CPG_TIPO_RENEG { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  cursor c_conta_new is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :NEW.BEG_VW_CPG_CONTA_DEST_ID;\n   r_conta_new c_conta_new%rowtype;\n\n   cursor c_conta_old is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :OLD.BEG_VW_CPG_CONTA_DEST_ID;\n   r_conta_old c_conta_old%rowtype;\n\nBEGIN\n\n  if inserting and :NEW.BEG_VW_CPG_CONTA_DEST_ID IS NOT NULL THEN\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_new.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a inclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if deleting  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    if r_conta_old.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if updating and :NEW.BEG_VW_CPG_CONTA_DEST_ID <> :OLD.BEG_VW_CPG_CONTA_DEST_ID  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_old.ind_rj ='Y' and r_conta_new.ind_rj ='N' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n\n\nEND ACC_TRG_BIUD_CPG_TITULO;\n"}`;
    
    }
}
