
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CARTEIRA_VENDIDA2_DBF
    {
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [StringLength(37)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRATO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VCTO { get; set; }
            [StringLength(22)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_TITULO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ID_DO_TITULO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// B - JÁ FOI BAIXADA E ENVIADA PARA ASP
        /// </summary>
        public string STATUS { get; set; }
        
        /// <summary>
        /// DATA DA BAIXA DO TITULO PARA AQUELES COM STATUS NULO
        /// </summary>
        public string DATA_BAIXA { get; set; }

    }
}
