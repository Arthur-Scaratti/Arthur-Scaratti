
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FUNCIONARIO
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_EMPRESA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_FUNCIONARIO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_DIVISAO_RH { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_CENTRO_CUSTO_CONTABIL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAPEIRA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_FUNCIONARIO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_LOGRADOURO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPLEMENTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_NASCIMENTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL_NASCIMENTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string PAI { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string MAE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NACIONALIDADE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string SEXO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string EST_CIVIL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string INSTRUCAO { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CTPS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EXP_CTPS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PIS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_CADASTRO_PIS { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string RG { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_RG { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ORGAO_EMISSOR_RG { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string UF_RG { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string TIT_ELEITOR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_TIT { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ZONA_TIT { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string SECAO_TIT { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CERT_RESERVISTA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CERT_RESERVISTA_CATEGORIA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CNH { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EXP_CNH { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VALIDADE_CNH { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CNH_CATEGORIA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ADMISSAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DEMISSAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO_ATUAL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string FUNCAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CBO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DEPENDENTES_SAL_FAMILIA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DEPENDENTES_IMPOSTO_RENDA { get; set; }

    }
}
