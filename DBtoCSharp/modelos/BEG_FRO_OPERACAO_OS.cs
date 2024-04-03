
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_OPERACAO_OS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_OPERACAO_OS_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
        public int VLR_OPERACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_ORDEM_SERVICO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_OPERACAO_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FRO_OPERACAO_OS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  cursor C_ORDEM_SERVICO(P_BEG_FRO_ORDEM_SERVICO_ID number) is\n    select IND_PAGTO\n      from BEG_FRO_ORDEM_SERVICO\n     where BEG_FRO_ORDEM_SERVICO_ID = P_BEG_FRO_ORDEM_SERVICO_ID;\n  R_ORDEM_SERVICO char;\n\nbegin\n\n  if not BEG_PCK_FROTA.V_DELETANDO_OS then\n  \n    open C_ORDEM_SERVICO(NVL(:new.BEG_FRO_ORDEM_SERVICO_ID,\n                             :new.BEG_FRO_ORDEM_SERVICO_ID));\n    fetch C_ORDEM_SERVICO\n      into R_ORDEM_SERVICO;\n    close C_ORDEM_SERVICO;\n  \n    if R_ORDEM_SERVICO = 'Y' then\n      RAISE_APPLICATION_ERROR(-20001, 'Ordem de servico ja paga !');\n    end if;\n  \n    if INSERTING then\n    \n      update BEG_FRO_ORDEM_SERVICO A\n         set A.VLR_OPERACAO = NVL(A.VLR_OPERACAO, 0) + :new.VLR_OPERACAO\n       where A.BEG_FRO_ORDEM_SERVICO_ID = :new.BEG_FRO_ORDEM_SERVICO_ID;\n    \n    elsif UPDATING then\n    \n      update BEG_FRO_ORDEM_SERVICO A\n         set A.VLR_OPERACAO = NVL(A.VLR_OPERACAO, 0) + :new.VLR_OPERACAO -\n                              :old.VLR_OPERACAO\n       where A.BEG_FRO_ORDEM_SERVICO_ID = :new.BEG_FRO_ORDEM_SERVICO_ID;\n    \n    else\n    \n      update BEG_FRO_ORDEM_SERVICO A\n         set A.VLR_OPERACAO = NVL(A.VLR_OPERACAO, 0) - :old.VLR_OPERACAO\n       where A.BEG_FRO_ORDEM_SERVICO_ID = :old.BEG_FRO_ORDEM_SERVICO_ID;\n    \n    end if;\n  end if;\nend;\n"}`;
    
    }
}
