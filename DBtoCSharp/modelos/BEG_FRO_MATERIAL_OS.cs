
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_MATERIAL_OS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_MATERIAL_OS_ID { get; set; }
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
        public int QUANTIDADE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO_MATERIAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_ORDEM_SERVICO_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FRO_MATERIAL_OS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  cursor C_ORDEM_SERVICO(P_BEG_FRO_ORDEM_SERVICO_ID number) is\n    select IND_PAGTO\n      from BEG_FRO_ORDEM_SERVICO\n     where BEG_FRO_ORDEM_SERVICO_ID = P_BEG_FRO_ORDEM_SERVICO_ID;\n  R_ORDEM_SERVICO char;\n\nbegin\n\n  if not BEG_PCK_FROTA.V_DELETANDO_OS then\n  \n    open C_ORDEM_SERVICO(NVL(:new.BEG_FRO_ORDEM_SERVICO_ID,\n                             :new.BEG_FRO_ORDEM_SERVICO_ID));\n    fetch C_ORDEM_SERVICO\n      into R_ORDEM_SERVICO;\n    close C_ORDEM_SERVICO;\n  \n    if R_ORDEM_SERVICO = 'Y' then\n      RAISE_APPLICATION_ERROR(-20001, 'Ordem de servico ja paga !');\n    end if;\n  \n    if INSERTING then\n      update BEG_FRO_ORDEM_SERVICO A\n         set A.VLR_MATERIAL = NVL(A.VLR_MATERIAL, 0) + :new.VALOR\n       where A.BEG_FRO_ORDEM_SERVICO_ID = :new.BEG_FRO_ORDEM_SERVICO_ID;\n    elsif UPDATING then\n      update BEG_FRO_ORDEM_SERVICO A\n         set A.VLR_MATERIAL = NVL(VLR_MATERIAL, 0) + :new.VALOR - :old.VALOR\n       where A.BEG_FRO_ORDEM_SERVICO_ID = :new.BEG_FRO_ORDEM_SERVICO_ID;\n    else\n      update BEG_FRO_ORDEM_SERVICO A\n         set VLR_MATERIAL = NVL(VLR_MATERIAL, 0) + - :old.VALOR\n       where A.BEG_FRO_ORDEM_SERVICO_ID = :old.BEG_FRO_ORDEM_SERVICO_ID;\n    end if;\n  end if;\nend;\n"}`;
    
    }
}
