
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_ORDEM_SERVICO
    {
        
        /// <summary>
        /// Nota fiscal do serviço
        /// </summary>
        public int NOTA_FISCAL { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Serie da nota fiscal
        /// </summary>
        public string SERIE_NF { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id da ordem de servico
        /// </summary>
        public int BEG_FRO_ORDEM_SERVICO_ID { get; set; }
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
        /// Data de abertura da OS
        /// </summary>
        public string DT_ABERTURA_OS { get; set; }
        
        /// <summary>
        /// Data de encerramento da OS
        /// </summary>
        public string DT_ENCERRAM_OS { get; set; }
        
        /// <summary>
        /// Data de entrada de veiculo (serviço)
        /// </summary>
        public string DT_ENTR_VEIC { get; set; }
        
        /// <summary>
        /// Data de saida do veiculo (servico)
        /// </summary>
        public string DT_SAIDA_VEIC { get; set; }
            [Required]
        /// <summary>
        /// Odometro do veiculo
        /// </summary>
        public int ODOMETRO { get; set; }
            [Required]
        /// <summary>
        /// Valor total dos materiais utilizados para o serviço
        /// </summary>
        public int VLR_MATERIAL { get; set; }
            [Required]
        /// <summary>
        /// Valor da operação
        /// </summary>
        public int VLR_OPERACAO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo da ordem de serviço
        /// </summary>
        public string TP_ORDEM_SERVICO { get; set; }
            [Required]
        /// <summary>
        /// Id do veiculo
        /// </summary>
        public int BEG_FRO_VEICULO_ID { get; set; }
            [Required]
        /// <summary>
        /// Id co parceiro comercial
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do motorista
        /// </summary>
        public int BEG_FRO_VW_MOTORISTA_ID { get; set; }
        
        /// <summary>
        /// Indicativo se serviço pago
        /// </summary>
        public string IND_PAGTO { get; set; }
        
        /// <summary>
        /// Valor total da NF
        /// </summary>
        public int VLR_TOTAL { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_FRO_OS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\nbegin\n  --\n  -- Atualiza valor no abastecimento e total da ordem\n  --\n  if DELETING then\n    BEG_PCK_FROTA.V_DELETANDO_OS := true;\n    update BEG_FRO_ABASTECIMENTO A\n       set A.VLR_ORDEM_SERVICO = 0\n     where A.BEG_FRO_ORDEM_SERVICO_ID = :old.BEG_FRO_ORDEM_SERVICO_ID;\n  \n  else\n  \n    :new.VLR_TOTAL := NVL(:new.VLR_MATERIAL, 0) + NVL(:new.VLR_OPERACAO, 0);\n  \n    if not BEG_PCK_FROTA.V_GERANDO_OS then\n    \n      update BEG_FRO_ABASTECIMENTO A\n         set A.VLR_ORDEM_SERVICO = :new.VLR_TOTAL\n       where A.BEG_FRO_ORDEM_SERVICO_ID = :new.BEG_FRO_ORDEM_SERVICO_ID;\n    \n    end if;\n  end if;\n\n  --\n  -- FIM\n  --\nend TRG_AIUD_BEG_FRO_ABASTECIMENTO;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_AD_BEG_FRO_OS { get; set; } = `{"triggering_event":"DELETE","trigger_body":"begin\n  BEG_PCK_FROTA.V_DELETANDO_OS := false;\nend;\n"}`;
    
    }
}
