
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BASE_CLIENTES
    {
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF_CNPJ { get; set; }
            [StringLength(48)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_RAZAO { get; set; }
            [StringLength(45)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_MAE_N { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NASC_DT_AB { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SEXO_PORTE { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string SIGNO_ATIV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RENDA_FATU { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTADOCIVI { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CBO_CNAE { get; set; }
            [StringLength(99)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO_ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ESCOLARIDA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO2 { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CLUSTERS { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_LOGR { get; set; }
            [StringLength(7)]
        /// <summary>
        /// 
        /// </summary>
        public string TITULO_LOG { get; set; }
            [StringLength(55)]
        /// <summary>
        /// 
        /// </summary>
        public string LOGRADOURO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUMERO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMPLEMENT { get; set; }
            [StringLength(32)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(28)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD1 { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TIPO1 { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD2 { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE2 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO2 { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD3 { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE3 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO3 { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD4 { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE4 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO4 { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD5 { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE5 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO5 { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD6 { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE6 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO6 { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD7 { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE7 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO7 { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD8 { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE8 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO8 { get; set; }
            [StringLength(46)]
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL1 { get; set; }
            [StringLength(48)]
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL2 { get; set; }
            [StringLength(37)]
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL3 { get; set; }

    }
}
