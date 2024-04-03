
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_SAIDA_VEICULO
    {
        
        /// <summary>
        /// Data de previsao de retorno
        /// </summary>
        public string DT_PREVISAO_RETORNO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Motivo da saida
        /// </summary>
        public string MOTIVO_SAIDA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id da saida do veiculo
        /// </summary>
        public int BEG_FRO_SAIDA_VEICULO_ID { get; set; }
            [Required]
        /// <summary>
        /// Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo sim ou não
        /// </summary>
        public string ISACTIVE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Codigo
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Data da inclusao
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Quem fez a inclusao
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da ultima alteracao
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Quem fez a ultima alteracao
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data Saida
        /// </summary>
        public string DT_INICIAL { get; set; }
        
        /// <summary>
        /// Data Chegada
        /// </summary>
        public string DT_FINAL { get; set; }
        
        /// <summary>
        /// Odometro Saida
        /// </summary>
        public int ODOMETRO_INICIAL { get; set; }
        
        /// <summary>
        /// Odometro Chegada
        /// </summary>
        public int ODOMETRO_FINAL { get; set; }
            [Required]
        /// <summary>
        /// Veiculo
        /// </summary>
        public int BEG_FRO_VEICULO_ID { get; set; }
            [Required]
        /// <summary>
        /// Motorista
        /// </summary>
        public int BEG_FRO_VW_MOTORISTA_ID { get; set; }
        
        /// <summary>
        /// Kilometragem percorrida
        /// </summary>
        public int KM_PERCORRIDA { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AIU_SAIDA_VEICULO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n\n  update BEG_FRO_VEICULO\n     set ODOMETRO_ATUAL = :new.ODOMETRO_FINAL\n   where BEG_FRO_VEICULO_ID = :new.BEG_FRO_VEICULO_ID\n     and :new.ODOMETRO_FINAL > ODOMETRO_ATUAL;\n\nend DIE_TRG_AIU_SAIDA_VEICULO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIU_SAIDA_VEICULO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  V_ODOMETRO number;\n\nbegin\n\n  :new.KM_PERCORRIDA := :new.ODOMETRO_FINAL - :new.ODOMETRO_INICIAL;\n\n  -- Jailson Tavares 07/11/2008\n\n  if INSERTING then\n  \n    select V.ODOMETRO_ATUAL\n      into V_ODOMETRO\n      from BEG_FRO_VEICULO V\n     where V.BEG_FRO_VEICULO_ID = :new.BEG_FRO_VEICULO_ID;\n  \n    if NVL(V_ODOMETRO, 0) = 0 then\n      if NVL(:new.ODOMETRO_INICIAL, 0) > 0 then\n      \n        update BEG_FRO_VEICULO\n           set ODOMETRO_ATUAL = :new.ODOMETRO_INICIAL\n         where BEG_FRO_VEICULO_ID = :new.BEG_FRO_VEICULO_ID\n           and ODOMETRO_ATUAL = 0;\n      \n      else\n      \n        RAISE_APPLICATION_ERROR(-20001,\n                                'Informe o odômetro de saída do veículo!');\n      end if;\n    \n    else\n    \n      :new.ODOMETRO_INICIAL := V_ODOMETRO;\n    \n    end if;\n  \n  end if;\n\n  if UPDATING then\n  \n    if :new.DT_FINAL is not null\n       and :new.ODOMETRO_FINAL is null then\n      RAISE_APPLICATION_ERROR(-20002,\n                              'Informe o odômetro de chegada do veículo!');\n    end if;\n  \n    if :new.ODOMETRO_FINAL < :new.ODOMETRO_INICIAL then\n      RAISE_APPLICATION_ERROR(-20003,\n                              'O odômetro de chegada do veículo deve ser maior que o odômetro de saída!');\n    end if;\n  \n  end if;\n\nend DIE_TRG_BIU_SAIDA_VEICULO;\n"}`;
    
    }
}
