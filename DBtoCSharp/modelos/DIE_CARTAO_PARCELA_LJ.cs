
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CARTAO_PARCELA_LJ
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_PARCELA_LJ_ID { get; set; }
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
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CDDUPL { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string PARCELA { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string NRCUPOM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTVENCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTPAGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int JUROS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRNF { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRCAIXA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CDCARTAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTMOVIM { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
        
        /// <summary>
        /// Usado como data do processo
        /// </summary>
        public string DTDEP { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SEQUENCIA { get; set; }
            [Required]
    [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string NRAUTOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_TAXA_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ESTORNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TX_ADIANTAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTVENCTO_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIQUIDO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_AUTORIZACAO_TEF { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO_RESUMO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Identificacao de transacao realizada pelo ecommerce
        /// </summary>
        public string TID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ESTORNO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CONFERIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CONFERIDO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NR_ANTECIPACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ANTECIPACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_RECIBO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VALE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTREGA_B2W { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_CR_VENDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PARC_ADM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ID_PARC_LOJA { get; set; }
        
        /// <summary>
        /// Origem da loja
        /// </summary>
        public int DIE_CAIXA_HIST_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica se foi importado para o sistema. tabela oficial: die_cartao_parecla
        /// </summary>
        public string IND_IMPORTADO { get; set; }
        
        /// <summary>
        /// Id do registro na tabela destino
        /// </summary>
        public int DIE_CARTAO_PARCELA_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_CARTAO_PARCELA_LJ { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"BEGIN\n  \n\n\n  IF :NEW.DTDEP IS NULL THEN\n    \n  \n    :NEW.DTDEP := TRUNC(SYSDATE);\n  \n  \n  END IF;\n\nEND;\n"}`;
    
    }
}
