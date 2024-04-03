
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_INF_PESSOA
    {
        
        /// <summary>
        /// Tempo de relacionamento (anos)
        /// </summary>
        public int QTD_ANO { get; set; }
        
        /// <summary>
        /// Valor total do contas a receber
        /// </summary>
        public int VLR_CRC_TOTAL { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id de informacoes financeiras do parceiro comercial
        /// </summary>
        public int BEG_FIN_INF_PESSOA_ID { get; set; }
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
        /// Parceiro Comercial
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// Limite de credito do parceiro comercial
        /// </summary>
        public int LIMITE_CREDITO { get; set; }
        
        /// <summary>
        /// Credit Score
        /// </summary>
        public int CREDIT_SCORE { get; set; }
        
        /// <summary>
        /// Total dos titulos em aberto - Contas a Receber
        /// </summary>
        public int TOT_CRC_ABERTO { get; set; }
        
        /// <summary>
        /// Total dos titulos vencidos - Contas a Receber
        /// </summary>
        public int TOT_CRC_VENCIDO { get; set; }
        
        /// <summary>
        /// Media de atrasos - Contas a Receber
        /// </summary>
        public int MEDIA_ATRASO_CRC { get; set; }
        
        /// <summary>
        /// Total de titulos em aberto - Contas a pagar
        /// </summary>
        public int TOT_CPG_ABERTO { get; set; }
        
        /// <summary>
        /// Total dos titulos vencidos - Contas a Pagar
        /// </summary>
        public int TOT_CPG_VENCIDO { get; set; }
        
        /// <summary>
        /// Total dos pedidos em aberto
        /// </summary>
        public int TOT_PEDIDO_ABERTO { get; set; }
        
        /// <summary>
        /// Valor limite de inadimplencia
        /// </summary>
        public int VLR_LIMITE_INADIMPL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Descritivo de restricao ref. a tipo de cobranca
        /// </summary>
        public string RESTRINGE_TP_COBR { get; set; }
        
        /// <summary>
        /// Total dos titulos do contas a receber a compensar (titulos em aberto, mas ja vencidos)
        /// </summary>
        public int TOT_CRC_ACOMPENSAR { get; set; }
        
        /// <summary>
        /// Quando fornecedor: existindo dados bancarios , este sera o dados a ser considerado como padrao
        /// </summary>
        public int BEG_DADOS_BANCARIOS_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BU_FIN_INF_PESSOA { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  cursor C_VER_CC is\n    select count(*) QTDE\n      from BEG_DADOS_BANCARIOS\n     where BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n     group by BEG_PESSOA_ID;\n  --\n  RVCC C_VER_CC%rowtype;\n  --\n  cursor C_CC_PADRAO is\n    select BEG_DADOS_BANCARIOS_ID\n      from BEG_DADOS_BANCARIOS\n     where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  --\n  RCCPAD C_CC_PADRAO%rowtype;\n  --\n  pragma autonomous_transaction;\n  --\nbegin\n  -- Verifia se existe conta bancaria digitada para o parceiro omercial\n  open C_VER_CC;\n  fetch C_VER_CC\n    into RVCC;\n  if C_VER_CC%found then\n    if RVCC.QTDE = 1 then\n      -- Existindo apenas uma conta bancaria - traz como Padrao\n      open C_CC_PADRAO;\n      fetch C_CC_PADRAO\n        into RCCPAD;\n      close C_CC_PADRAO;\n      :new.BEG_DADOS_BANCARIOS_ID := RCCPAD.BEG_DADOS_BANCARIOS_ID;\n    else\n      if :new.BEG_DADOS_BANCARIOS_ID is null then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Parceiro Comercial com mais de uma Conta Corrente, e necessario atribuir uma como padr?o..... Verifique!');\n      end if;\n    end if;\n  end if;\n  close C_VER_CC;\nend BEG_TRG_BU_FIN_INF_PESSOA;\n"}`;
    
    }
}
