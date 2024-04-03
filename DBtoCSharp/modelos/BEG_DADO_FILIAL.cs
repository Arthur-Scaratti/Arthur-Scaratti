
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_DADO_FILIAL
    {
        
        /// <summary>
        /// indica que deve apresentar informacao na grade da distribuicao
        /// </summary>
        public string IND_GRADE_DISTRIB { get; set; }
            [Required]
        /// <summary>
        /// Id da cota x grupo
        /// </summary>
        public int DIE_VEN_COTA_GRUPO_ID { get; set; }
        
        /// <summary>
        /// controle numero sequencia pedido
        /// </summary>
        public int NRPEDIDO { get; set; }
        
        /// <summary>
        /// controle numero notas fiscais
        /// </summary>
        public int NRNF { get; set; }
        
        /// <summary>
        /// controle numero do cupom fiscal
        /// </summary>
        public int NRCONTROLE { get; set; }
        
        /// <summary>
        /// controle sequencia cliente
        /// </summary>
        public int NRCLIENTE { get; set; }
        
        /// <summary>
        /// controle sequencia numero caixa diario
        /// </summary>
        public int NRCAIXA { get; set; }
        
        /// <summary>
        /// controle numero ordem de montagem
        /// </summary>
        public int NRMONTAGEM { get; set; }
        
        /// <summary>
        /// controle do numero do certificado de garantia e seguro
        /// </summary>
        public int NRGARANTIA { get; set; }
        
        /// <summary>
        /// valor saldo vendas a vista antecipadas em aberto
        /// </summary>
        public int VENDAANTEC { get; set; }
        
        /// <summary>
        /// valor saldo entradas antecipadas em aberto
        /// </summary>
        public int ENTRAANTEC { get; set; }
        
        /// <summary>
        /// saldo anterior do caixa
        /// </summary>
        public int SALDOANTC1 { get; set; }
        
        /// <summary>
        /// saldo atual do caixa (do dia)
        /// </summary>
        public int SALDOATUC1 { get; set; }
            [StringLength(20)]
        /// <summary>
        /// ip do servidor do sitef desenvolvimento
        /// </summary>
        public string SITEFDEMO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// ip do servidor sitef desenvolvimento
        /// </summary>
        public string SITEFPROD { get; set; }
            [StringLength(10)]
        /// <summary>
        /// numero cadastro da filial no spc
        /// </summary>
        public string SPC_ASSOC { get; set; }
            [StringLength(10)]
        /// <summary>
        /// cadastro filial spc cidade
        /// </summary>
        public string SPC_ORIGEM { get; set; }
            [StringLength(20)]
        /// <summary>
        /// numero de autorizaçao impressão notas fiscais
        /// </summary>
        public string AIDOF { get; set; }
            [StringLength(1)]
        /// <summary>
        /// indicativo de ecf no servidor
        /// </summary>
        public string ECFSERVID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// indicativo de ecf no caixa1
        /// </summary>
        public string ECF1CAIXA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// indicativo de ecf no caixa2
        /// </summary>
        public string ECF2CAIXA { get; set; }
        
        /// <summary>
        /// controle sequencia numero RECIBOS
        /// </summary>
        public int NRRECIBO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id dos dados da filial
        /// </summary>
        public int BEG_DADO_FILIAL_ID { get; set; }
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
        /// Codigo da filial
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
        
        /// <summary>
        /// NIRE
        /// </summary>
        public int NIRE { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Razao Social
        /// </summary>
        public string RAZAO_SOCIAL { get; set; }
        
        /// <summary>
        /// Numero do livro
        /// </summary>
        public int NRO_LIVRO { get; set; }
        
        /// <summary>
        /// Numero do livro de inventario
        /// </summary>
        public int NRO_LIVRO_INV { get; set; }
        
        /// <summary>
        /// Data do NIRE
        /// </summary>
        public string DT_NIRE { get; set; }
        
        /// <summary>
        /// Data da ultima atualizacao
        /// </summary>
        public string DT_ULT_ATUAL { get; set; }
        
        /// <summary>
        /// Id da beg_pessoa - relacionamento da filial
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// Indicativo se e para gerar avisos via arquivo texto
        /// </summary>
        public string GERA_AVISO { get; set; }
        
        /// <summary>
        /// Id da filial (visao)
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// id do tipo da filial
        /// </summary>
        public int BEG_GER_TIPO_FILIAL_ID { get; set; }
        
        /// <summary>
        /// Numero do livro de fornecedor
        /// </summary>
        public int NRO_LIVRO_FORNEC { get; set; }
        
        /// <summary>
        /// Codigo da filial na contabilidade - enviar para EZA  ( nr da nossa loja + codigo do EZA ). Ex: 01503
        /// </summary>
        public int CD_FILIAL_CONTABIL { get; set; }

    }
}
