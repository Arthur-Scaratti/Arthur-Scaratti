
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_PARAMETRO
    {
        
        /// <summary>
        /// Data do ultimo envio ao spc
        /// </summary>
        public string DT_ULT_ENVIO_SPC { get; set; }
            [Required]
        /// <summary>
        /// Quantidade de envio na ultima data
        /// </summary>
        public int QTD_ENVIO_ULT_DTA { get; set; }
            [Required]
        /// <summary>
        /// Sequencial de processamento do SPC
        /// </summary>
        public int SEQ_PROC_SPC { get; set; }
        
        /// <summary>
        /// Data anterior do ultimo envio ao SPC
        /// </summary>
        public string DT_ULT_ENVIO_ANT { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Codigo do SPC Associado
        /// </summary>
        public string COD_SPC { get; set; }
        
        /// <summary>
        /// codigo do Associado no SPC
        /// </summary>
        public int COD_ASSOCIADO_SPC { get; set; }
        
        /// <summary>
        /// codigo da filial no SPC
        /// </summary>
        public int COD_FILIAL_SPC { get; set; }
        
        /// <summary>
        /// Idade minima para a Cobrança
        /// </summary>
        public int IDADE_MINIMA { get; set; }
        
        /// <summary>
        /// Idade máxima para a Cobrança
        /// </summary>
        public int IDADE_MAXIMA { get; set; }
        
        /// <summary>
        /// Indica que é para criar a restricao de nao vender - SPC
        /// </summary>
        public string IND_CRIA_RESTRICAO_SPC { get; set; }
        
        /// <summary>
        /// Indica enviar contrato unico para o SPC
        /// </summary>
        public string IND_TITULO_UNICO { get; set; }
        
        /// <summary>
        /// Indica implantacao do contato
        /// </summary>
        public string IND_CONTATO { get; set; }
        
        /// <summary>
        /// Indica implantacao da cobranca (externa / assessoria)
        /// </summary>
        public string IND_COBRANCA { get; set; }
        
        /// <summary>
        /// Indica implantacao do cartorio / juridico
        /// </summary>
        public string IND_CARTORIO { get; set; }
        
        /// <summary>
        /// Indica que é para criar a restricao para o cartorio
        /// </summary>
        public string IND_RESTRICAO_CARTORIO { get; set; }
        
        /// <summary>
        /// Indica que é para criar a restricao para o juridico
        /// </summary>
        public string IND_RESTRICAO_JURIDICO { get; set; }
        
        /// <summary>
        /// Quantidade de dias maximo para negativacao
        /// </summary>
        public int QTD_DIAS_MAX_NEGATIVAR { get; set; }
        
        /// <summary>
        /// Executa jobs no domingo
        /// </summary>
        public string IND_EXECUTA1 { get; set; }
        
        /// <summary>
        /// Executa jobs na segunda
        /// </summary>
        public string IND_EXECUTA2 { get; set; }
        
        /// <summary>
        /// Executa jobs na terca
        /// </summary>
        public string IND_EXECUTA3 { get; set; }
        
        /// <summary>
        /// Executa jobs na quarta
        /// </summary>
        public string IND_EXECUTA4 { get; set; }
        
        /// <summary>
        /// Executa jobs na quinta
        /// </summary>
        public string IND_EXECUTA5 { get; set; }
        
        /// <summary>
        /// Executa jobs na sexta
        /// </summary>
        public string IND_EXECUTA6 { get; set; }
        
        /// <summary>
        /// Executa jobs no sabado
        /// </summary>
        public string IND_EXECUTA7 { get; set; }
        
        /// <summary>
        /// Cobranca integrada
        /// </summary>
        public string IND_INTEGRA { get; set; }
        
        /// <summary>
        /// Quantidade de dias maximo permitido para aviso pgto
        /// </summary>
        public int QTDE_DIAS_MAX_AVISO { get; set; }
        
        /// <summary>
        /// Indica implantacao controle SPC
        /// </summary>
        public string IND_SPC { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// TABELA PARA USO FCDL
        /// </summary>
        public int BEG_COB_PARAMETRO_ID { get; set; }
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
        
        /// <summary>
        /// indica implantacao dos avisos
        /// </summary>
        public string IND_AVISO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_COB_PARAMETRRO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  cursor C_GERAL is\n    select *\n      from BEG_COB_PARAMETRO P\n     where P.AD_CLIENT_ID = :new.AD_CLIENT_ID\n       and P.AD_ORG_ID = 0;\n  RGERAL C_GERAL%rowtype;\n  pragma autonomous_transaction;\nbegin\n\n  -- Leitura do registro referente a parametro geral\n  open C_GERAL;\n  fetch C_GERAL\n    into RGERAL;\n  if C_GERAL%notfound then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Faltou a criação do parametro geral da cobrança');\n  end if;\n\n  -- Popula campo para as filiais\n  :new.COD_ASSOCIADO_SPC := RGERAL.COD_ASSOCIADO_SPC;\n  :new.COD_SPC           := RGERAL.COD_SPC;\n\nend BEG_TRG_BIU_COB_PARAMETRRO;\n"}`;
    
    }
}
