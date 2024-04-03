
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AGENCIAS
    {
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_BANCO { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string BANCO { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string SEGMENTO { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_AGENCI { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_DA_AG { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPLEMENT { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string MUNICIPIO { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTADO { get; set; }

    }
}
