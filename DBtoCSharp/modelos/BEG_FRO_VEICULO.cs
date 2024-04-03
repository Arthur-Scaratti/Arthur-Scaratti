
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_VEICULO
    {
            [Required]
        /// <summary>
        /// Odometro atual - controle de saidas de veiculo
        /// </summary>
        public int ODOMETRO_ATUAL { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do veiculo
        /// </summary>
        public int BEG_FRO_VEICULO_ID { get; set; }
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
        /// Ativo Sim ou Não
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// Data da criacao do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Quem criou o registro
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
    [StringLength(15)]
        /// <summary>
        /// Numero no Renavan
        /// </summary>
        public string RENAVAN { get; set; }
            [Required]
    [StringLength(7)]
        /// <summary>
        /// placa
        /// </summary>
        public string PLACA { get; set; }
            [Required]
        /// <summary>
        /// Ano de fabricacao
        /// </summary>
        public int ANO_FAB { get; set; }
            [Required]
        /// <summary>
        /// Ano do modelo 
        /// </summary>
        public int ANO_MOD { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Combustivel
        /// </summary>
        public string COMBUSTIVEL { get; set; }
            [Required]
        /// <summary>
        /// Numero de eixo
        /// </summary>
        public int NRO_EIXO { get; set; }
            [Required]
        /// <summary>
        /// Quantidade de pneus
        /// </summary>
        public int QTDE_PNEUS { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// Categoria de carteira de motorista necessaria
        /// </summary>
        public string CAT_CARTA_MOT { get; set; }
            [Required]
    [StringLength(17)]
        /// <summary>
        /// Nro chassi do veiculo
        /// </summary>
        public string NRO_CHASSI { get; set; }
            [Required]
    [StringLength(30)]
        /// <summary>
        /// Cor predominante
        /// </summary>
        public string COR_PREDOMINANTE { get; set; }
            [Required]
        /// <summary>
        /// Capacidade de carga
        /// </summary>
        public int CAPACIDADE_CARGA { get; set; }
            [Required]
        /// <summary>
        /// Modelo do veiculo
        /// </summary>
        public int BEG_FRO_MODELO_VEICULO_ID { get; set; }
            [Required]
        /// <summary>
        /// Tipo de veiculo
        /// </summary>
        public int BEG_FRO_TIPO_VEICULO_ID { get; set; }
        
        /// <summary>
        /// Odometro inicial do veiculo
        /// </summary>
        public int ODOMETRO { get; set; }
        
        /// <summary>
        /// Data ultimo IPVA pago
        /// </summary>
        public string DT_ULT_IPVA_PAGO { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FRO_VEICULO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\n  WCTRL_PNEUS char(1);\n  WCTRL_EIXO  char(1);\n  ISVALID     boolean;\n  --\nbegin\n  begin\n    select TV.CTRL_NRO_PNEUS,\n           TV.CTRL_NRO_EIXO\n      into WCTRL_PNEUS,\n           WCTRL_EIXO\n      from BEG_FRO_TIPO_VEICULO TV\n     where TV.BEG_FRO_TIPO_VEICULO_ID = :new.BEG_FRO_TIPO_VEICULO_ID;\n  end;\n  -- Consistencias de campos\n  if :new.NRO_EIXO = 0\n     and WCTRL_EIXO = 'Y' then\n    RAISE_APPLICATION_ERROR(-20001, 'O numero de eixo deve ser informado!');\n  end if;\n  if :new.QTDE_PNEUS = 0\n     and WCTRL_PNEUS = 'Y' then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'A quantidade de pneus deve ser informada!');\n  end if;\n  if :new.ANO_FAB < 1950\n     or :new.ANO_FAB > 2999 then\n    RAISE_APPLICATION_ERROR(-20003,\n                            'Ano de fabricac?o do veiculo invalido!');\n  end if;\n  if :new.ANO_MOD < 1950\n     or :new.ANO_MOD > 2999 then\n    RAISE_APPLICATION_ERROR(-20004, 'Ano do modelo do veiculo invalido!');\n  end if;\n  --\n /* if (:new.PLACA is not null) then\n    ISVALID := REGEXP_LIKE(:new.PLACA, '^([[:alpha:]]{3}[[:digit:]]{4})$');\n    if (not ISVALID) then\n      RAISE_APPLICATION_ERROR(-20005,\n                              'Informar a placa no formato XXX9999 (3 letras + 4 numeros)!');\n    end if;\n  end if;*/\n  -- \n  -- Atualizac?o dos campos alfanumericos em maiusculo\n  --\n  :new.PLACA            := UPPER(:new.PLACA);\n  :new.CAT_CARTA_MOT    := UPPER(:new.CAT_CARTA_MOT);\n  :new.COR_PREDOMINANTE := UPPER(:new.COR_PREDOMINANTE);\n  :new.NRO_CHASSI       := UPPER(:new.NRO_CHASSI);\n  --\nend BEG_FRO_TRG_BIU_VEICULO;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_AI_BEG_FRO_VEICULO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  cursor C1 is\n    select distinct BEG_FRO_OPERACAO_PADRAO.BEG_FRO_OPERACAO_ID OPER\n      from BEG_FRO_OPERACAO_PADRAO,\n           BEG_FRO_OPERACAO\n     where BEG_FRO_OPERACAO_PADRAO.BEG_FRO_MODELO_VEICULO_ID =\n           :new.BEG_FRO_MODELO_VEICULO_ID\n       and BEG_FRO_OPERACAO.BEG_FRO_OPERACAO_ID =\n           BEG_FRO_OPERACAO_PADRAO.BEG_FRO_OPERACAO_ID\n       and BEG_FRO_OPERACAO.TP_OPERACAO = 'P';\n  --\n V_REVISAO_ID number(10);\n  --\nbegin\n  --\n  if INSERTING then\n    --\n    for WC1 in C1\n    loop\n      --\n      V_REVISAO_ID := BEG_FNC_AD_SEQUENCE('BEG_FRO_REVISAO');\n      --\n      insert into BEG_FRO_REVISAO\n        (BEG_FRO_REVISAO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         DT_REVISAO,\n         ODOMETRO,\n         BEG_FRO_VEICULO_ID,\n         BEG_FRO_OPERACAO_ID)\n      values\n        (V_REVISAO_ID,\n         :new.AD_CLIENT_ID,\n         :new.AD_ORG_ID,\n         'Y',\n         :new.CREATED,\n         :new.CREATEDBY,\n         :new.UPDATED,\n         :new.UPDATEDBY,\n         sysdate,\n         :new.ODOMETRO,\n         :new.BEG_FRO_VEICULO_ID,\n         WC1.OPER);\n    end loop;\n    --\n  end if;\n  --\nend BEG_FRO_TRG_BIU_VEICULO;"}`;
    
    }
}
