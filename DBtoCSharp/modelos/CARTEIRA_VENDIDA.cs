
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CARTEIRA_VENDIDA
    {
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [StringLength(45)]
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
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string EMISSAO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// B - Baixado pelo Processo, P - Cobrado pela loja
        /// </summary>
        public string STATUS { get; set; }

    }
}
