
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_EST_TP_ESPECIE
    {
            [Required]
        /// <summary>
        /// Indica geracao de titulo para a nota fiscal
        /// </summary>
        public string IND_GERA_TITULO { get; set; }
            [Required]
        /// <summary>
        /// Indica geracao de historico de notas fiscais
        /// </summary>
        public string IND_GERA_HST_NF { get; set; }
            [Required]
        /// <summary>
        /// Indica geracao de historico de vinculos de notas fiscais
        /// </summary>
        public string IND_GERA_HST_VINC { get; set; }
        
        /// <summary>
        /// Indicador de (E)ntrada ou (S)aida
        /// </summary>
        public string IND_ENT_SAI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// indica se controla o estoque por parceiro
        /// </summary>
        public string IND_EST_PARCEIRO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BKN_AGRUPA_ENTRADA_ID { get; set; }
        
        /// <summary>
        /// Permite que a NF gerada possa ser incluida no manifesto de transporte 
        /// </summary>
        public string IND_MANIFESTO { get; set; }
        
        /// <summary>
        /// indica se cliente e consumidor ou nao
        /// </summary>
        public string IND_FINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_USO_LOJA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_FATURAMENTO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do tipo da especie
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
            [Required]
        /// <summary>
        /// Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// * 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo ( Y  / N )
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// Descricao do tipo da especie
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Data de criacao do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data ultima alteracao
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario ultima alteracao
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo Movimento - (D)esconta / (S)oma / (T)ransfere
        /// </summary>
        public string TP_MOVTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indicativo se baixa reserva 
        /// </summary>
        public string BAIXA_RESERVA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Sigla do tipo da especie  (Ira - 12/07/2007)
        /// </summary>
        public string SIGLA { get; set; }

        [NotMapped]
        public string Trigger_TRG_BD_BEG_EST_TP_ESPECIE { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  VN_BEG_EST_TP_ESPECIE_ID BEG_EST_TP_ESPECIE.BEG_EST_TP_ESPECIE_ID%type;\n\nbegin\n  VN_BEG_EST_TP_ESPECIE_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAM_GERAL('Suprimentos',\n                                                                    'Nota Fiscal Entrada',\n                                                                    'TP_ESPECIE_ENTRADA_ESTOQUE'));\n\n  if VN_BEG_EST_TP_ESPECIE_ID = :old.BEG_EST_TP_ESPECIE_ID then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Tipo de especie parametrizada como entrada de estoque!');\n  end if;\n\n  VN_BEG_EST_TP_ESPECIE_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAM_GERAL('Suprimentos',\n                                                                    'Nota Fiscal Entrada',\n                                                                    'TP_ESPECIE_SAIDA_ESTOQUE'));\n\n  if VN_BEG_EST_TP_ESPECIE_ID = :old.BEG_EST_TP_ESPECIE_ID then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Tipo de especie parametrizada como saida de estoque!');\n  end if;\n\n  VN_BEG_EST_TP_ESPECIE_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAM_GERAL('Suprimentos',\n                                                                    'Nota Fiscal Entrada',\n                                                                    'TP_ESPECIE_TRANSF_ESTOQUE'));\n\n  if VN_BEG_EST_TP_ESPECIE_ID = :old.BEG_EST_TP_ESPECIE_ID then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Tipo de especie parametrizada como transferencia de estoque!');\n  end if;\n\nend TRG_BD_BEG_EST_TP_ESPECIE;\n"}`;
    
    }
}
