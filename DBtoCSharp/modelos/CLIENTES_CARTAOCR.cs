
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CLIENTES_CARTAOCR
    {
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string PRODUTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CLIENTE { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string SEXO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string E_MAIL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CELULAR { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD2 { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string TELEFONE { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_CADASTRO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_NASCTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string PRODUTO1 { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LIMITE_A_VISTA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LIMITE_A_VISTA_DISPONÍVEL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LIMITE_PARCELADO_DISPONÍVEL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LIMITE_PARCELAMES_DISPONÍVEL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LIMITE_PARCELADO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LIMITE_PARCELAMES { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string TOTAL_COMPRAS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string QTDE_COMPRAS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_ULTIMA_COMPRA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string VALOR_ULTIMA_COMPRA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string IDADE { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string PONTOS_DISPONÍVEIS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string RENDA { get; set; }

    }
}
