
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CAIXAGAR
    {
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRAUTENTI { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRDOCFIS { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRCONTROLE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTDEVOL { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRAUTDEVOL { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CDVENDEDOR { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CDPRODUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEQ { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string MODELO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string MARCA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CDGARANTIA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NROCERTIF { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NROSERIE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECOGAR { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRRECIBO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTRECIBO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTGERADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTMOVIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRBASE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTBANCO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLORIGINAL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRSORTE_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TPVENDA { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRNF { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(35)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO { get; set; }
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
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPORISCO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRSORTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int APOLICEGAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int APOLICEPF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int APOLICERES { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CERT_ANTIG { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string IDORACLE { get; set; }

    }
}
