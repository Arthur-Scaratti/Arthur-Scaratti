
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_BEG_PESSOA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string SEPARADOR { get; set; }
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
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
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
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
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
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string INSCRICAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TPMORADIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ALUGUEL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string FIADOR { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string APROVADOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_NASCIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTSITUACAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_BEG_PESSOA_ID { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string EMPRESACONJ { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CARGOCONJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTADMISSAOCONJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RENDACONJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OUTRENDACONJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LOCAL_ULT_ATUALIZACAO { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF_CONJUGE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CPF_RES_PAGAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CPF_RESP_COMPRAS { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string E_MAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LIMITE_DE_CREDITO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string RENDA_COMPROVADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RENDA_FAMILIAR { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string RESP_COMPRAS { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string RESP_PAGAMENTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CLIENTE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string FORNECEDOR { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TRANSPORTADORA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string COBRADOR { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string VENDEDOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TP_PESSOA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CBO_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCR_CIDADE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string FUNCIONARIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CONJUGE_AUTORIZADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string MOTORISTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPRADOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CORRETOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string SEGURADORA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TP_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CONSUMIDOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_INSCRITO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string INSCRICAO_MUNICIPAL { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPLEMENTO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string PONTO_REFERENCIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_LOGRADOURO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_UF_ID { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string ORGAO_EMISSOR_RG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_UF_RG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_RG { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CONFERENTE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_AVISO_COBRANCA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_RAMO_ATIVIDADE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAS_ATRASO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ATIVO_SINTEGRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_SINTEGRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CNAE_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_FANTASIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FUNDACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ULT_COMPRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ULT_VENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SUPERVISOR_VENDAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SUPERVISOR_TELEVENDAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string GERENTE_VENDAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TELE_VENDEDOR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_VENDA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PESSOA_COMISSIONADA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string TORPEDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_CONCEITO_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_MENSAGEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_ROTA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string REPRESENTADA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ORIGEM { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_UF_NASCIMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RESIDANO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RESIDMES { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string OUTROSDOCS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CONVENIADA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTCIVIL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SEXO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NATURALIDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRDEPENDE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CTPS { get; set; }
            [StringLength(17)]
        /// <summary>
        /// 
        /// </summary>
        public string TITELEITOR { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string EMPRESA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTADMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OUTRENDA { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string PAI { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string MAE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string RG { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string CONJUGE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTNASCCONJ { get; set; }

    }
}
