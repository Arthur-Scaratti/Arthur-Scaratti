
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_CONTRATOS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_CONTRATOS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// Vencimento do contrato ativo
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BRUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIQUIDO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 'L' -  Loja, 'R' - Rateio
        /// </summary>
        public string TP_DESPESA { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Identificador do Contrato
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// Dia do primeiro vcto(faturamento)
        /// </summary>
        public string DIA_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_IR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_INSS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_INSS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_ISSQN_SUBITEM_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_MODELO_55 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CFOP_SAI_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CFOP_ENT_ID { get; set; }
        
        /// <summary>
        /// Para controle de uk permite mais de um contrato por filial e fornecedor
        /// </summary>
        public int SEQUENCIA { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_CONTRATOS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"BEGIN\n\n  IF DELETING THEN\n  \n    IF :OLD.DOCSTATUS = 'CO' THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Contrato ja processado, não pode ser excluído');\n    END IF;\n  \n  END IF;\n\nEND;\n"}`;
    
    }
}
