
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_TIT_ABERTO_TMP
    {
        
        /// <summary>
        /// Valor de juros
        /// </summary>
        public int VLR_JUROS { get; set; }
        
        /// <summary>
        /// Data Fim do Convenio
        /// </summary>
        public string DT_FIM { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Contrato
        /// </summary>
        public string CONTRATO { get; set; }
        
        /// <summary>
        /// Parcela
        /// </summary>
        public int PARCELA { get; set; }
            [Required]
        /// <summary>
        /// Id da tab. temporaria de titulos em atraso
        /// </summary>
        public int DIE_CRC_TIT_ABERTO_TMP_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// Id do titulo
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// Id da parceiro comercial
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// Data de emissao do titulo
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// Data de vencimento do titulo
        /// </summary>
        public string DT_VENCTO { get; set; }
        
        /// <summary>
        /// valor em aberto
        /// </summary>
        public int VLR_ABERTO { get; set; }
        
        /// <summary>
        /// numero de dias em atraso
        /// </summary>
        public int NRO_DIA_ATRASO { get; set; }
        
        /// <summary>
        /// numero da nota fiscal devolucao
        /// </summary>
        public int NUM_NF_DEVOL { get; set; }
        
        /// <summary>
        /// dias inicial de atraso
        /// </summary>
        public int DIAS_INICIAL { get; set; }
        
        /// <summary>
        /// dias finais de atraso
        /// </summary>
        public int DIAS_FINAL { get; set; }
        
        /// <summary>
        /// data da devolucao
        /// </summary>
        public string DATA_DEVOL { get; set; }
        
        /// <summary>
        /// (F)uncionario; pessoa (J)uridica; (C)onvenio
        /// </summary>
        public string TIPO_REL { get; set; }
            [Required]
        /// <summary>
        /// Id da sessao do funcionario
        /// </summary>
        public int AD_SESSION_ID { get; set; }
            [Required]
        /// <summary>
        /// Dta de referencia para emissao do relatorio
        /// </summary>
        public string DT_REFERENCIA { get; set; }
        
        /// <summary>
        /// codigo da filial
        /// </summary>
        public int FILIAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// (A)nalitico e (S)intetico
        /// </summary>
        public string TIPO_REL2 { get; set; }
            [StringLength(14)]
        /// <summary>
        /// CPF ou CNPJ
        /// </summary>
        public string CPFCNPJ { get; set; }
        
        /// <summary>
        /// ID da Conveniada
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// Codigo da conveniada
        /// </summary>
        public int COD_CONVENIO { get; set; }
        
        /// <summary>
        /// Id do tipo de filial
        /// </summary>
        public int BEG_GER_TIPO_FILIAL_ID { get; set; }

    }
}
