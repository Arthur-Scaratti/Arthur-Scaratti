
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_COB_TMA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_COB_TMA_ID { get; set; }
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
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_NOMINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CUSTOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CORRIGIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_HONORARIOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENVIO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_AUTORIZADO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_PROTOCOLO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PROTOCOLO { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_MOTIVO_BAIXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NOVO_CONTRATO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_BAIXA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string APP_USER { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_TMA { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  ----\nbegin\n\n  if :new.BEG_PESSOA_ID is not null then\n    :new.DOCSTATUS := 'AG'; -- Aguardando confirmação\n  end if;\n\n  if :new.IND_AUTORIZADO = 'N' then\n    :new.DOCSTATUS := 'NR'; --Não Protestar\n  end if;\n\n  if :new.IND_AUTORIZADO = 'Y' then\n    :new.DOCSTATUS := 'AU'; --Protestar\n  end if;\n\n  if :new.NRO_PROTOCOLO is not null\n     and :new.DT_PROTOCOLO is not null then\n    :new.DOCSTATUS := 'TM'; --Em TMA\n  end if;\n\n  if :new.BEG_MOTIVO_BAIXA_ID is not null\n     and :new.DT_BAIXA is not null then\n    :new.DOCSTATUS := 'EX'; --Excluido\n  end if;\n\n  --Validar Datas Informadas\n  if :new.DT_PROTOCOLO > :new.DT_BAIXA then\n    RAISE_APPLICATION_ERROR(-20009,\n                            'A Data de Baixa deve ser maior que a data de Protocolo!');\n  end if;\n\n  --Validar Campo Dt_Protocolo e Dt_protocolo\n  if :new.DT_PROTOCOLO is not null\n     and :new.NRO_PROTOCOLO is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o numero de protocolo!');\n  end if;\n\n  if :new.DT_PROTOCOLO is null\n     and :new.NRO_PROTOCOLO is not null then\n    RAISE_APPLICATION_ERROR(-20002, 'Faltou informar a data de protocolo!');\n  end if;\n\n  --Validar Campo DT_BAIXA e BEG_MOTIVO_BAIXA_ID\n  if :new.DT_BAIXA is not null\n     and :new.BEG_MOTIVO_BAIXA_ID is null then\n    RAISE_APPLICATION_ERROR(-20002, 'Faltou informar o Motivo da Baixa!');\n  end if;\n\n  if :new.DT_BAIXA is null\n     and :new.BEG_MOTIVO_BAIXA_ID is not null then\n    RAISE_APPLICATION_ERROR(-20002, 'Faltou informar a data da Baixa!');\n  end if;\n\n  -- Validar o Campo NOVO_CONTRATO e BEG_CRC_TITULO_ID\n\n  if :new.NOVO_CONTRATO is not null\n     and :new.BEG_TIPO_TITULO_ID is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o Tipo de de Titulo do Novo Contrato!');\n  end if;\n\n  if :new.BEG_TIPO_TITULO_ID is not null\n     and :new.NOVO_CONTRATO is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Faltou informar o Novo Contrato Gerado!');\n  end if;\n\nend DIE_TRG_BIUD_TMA;\n"}`;
    
    }
}
