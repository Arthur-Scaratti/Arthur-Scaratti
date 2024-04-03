
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_MOTORISTA
    {
            [StringLength(15)]
        /// <summary>
        /// nro da habilitacao
        /// </summary>
        public string NRO_HABILITACAO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do Motorista
        /// </summary>
        public int BEG_FRO_MOTORISTA_ID { get; set; }
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
    [StringLength(4)]
        /// <summary>
        /// Categoria da carteira de motorista
        /// </summary>
        public string CATEGORIA_CARTA { get; set; }
            [Required]
        /// <summary>
        /// Data de emissao da Carteira de motorista
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// Data da primeira habilitação
        /// </summary>
        public string DT_PRI_HABILITACAO { get; set; }
            [Required]
        /// <summary>
        /// data de vencimento da habilitacao
        /// </summary>
        public string DT_VECTO_CARTA { get; set; }
            [Required]
        /// <summary>
        /// Id do Parceiro Comercial 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FRO_MOTORISTA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  --\n  if :new.NRO_HABILITACAO = 0 then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'O numero da habilitação devera ser informada!');\n  end if;\n  :new.CATEGORIA_CARTA := UPPER(:new.CATEGORIA_CARTA);\n  --  \nend BEG_FRO_TRG_BIU_MOTORISTA;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_AIUD_BEG_FRO_MOTORISTA { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\nbegin\n  if INSERTING then\n    update BEG_PESSOA\n       set MOTORISTA = 'Y'\n     where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  end if;\n  --\n  if DELETING then\n    update BEG_PESSOA\n       set MOTORISTA = 'N'\n     where BEG_PESSOA_ID = :old.BEG_PESSOA_ID;\n  end if;\n  --\n  if UPDATING then\n    if :new.ISACTIVE != :old.ISACTIVE then\n      update BEG_PESSOA\n         set MOTORISTA = :new.ISACTIVE\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n      --\n      update BEG_FRO_MOTOR_ESPEC ME\n         set ISACTIVE = :new.ISACTIVE\n       where ME.AD_CLIENT_ID = :new.AD_CLIENT_ID\n         and ME.AD_ORG_ID = :new.AD_ORG_ID\n         and ME.BEG_FRO_MOTORISTA_ID = :new.BEG_FRO_MOTORISTA_ID;\n    end if;\n  end if;\nend TRG_AIUD_BEG_FRO_MOTORISTA;\n"}`;
    
    }
}
