
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class FORLOJA
    {
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string RAZAO { get; set; }
            [StringLength(35)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTADO { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string TELEFONE { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE1 { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string FAX { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CGC { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string INSCRICAO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTATO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTNASC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTULTATUAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string GRUPO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCIA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string LISTA { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string GERAREZA { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CDREPRES { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string CLCON { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTMOVIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string LISTAFORNE { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE2 { get; set; }

    }
}
