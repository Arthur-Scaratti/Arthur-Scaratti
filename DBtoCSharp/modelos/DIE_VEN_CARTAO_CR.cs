
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VEN_CARTAO_CR
    {
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_ABREV { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF_PORTADOR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_CARTAO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_PORTADOR { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF_TITULAR { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_TITULAR { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_INCLUSAO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(35)]
        /// <summary>
        /// 
        /// </summary>
        public string LOGRADOURO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPLEMENTO { get; set; }
            [StringLength(35)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTADO { get; set; }

    }
}
