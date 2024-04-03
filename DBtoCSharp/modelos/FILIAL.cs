
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class FILIAL
    {
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CODEZA { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string NIRE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTNIRE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTULTATUAL { get; set; }
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
            [StringLength(18)]
        /// <summary>
        /// 
        /// </summary>
        public string TELEFONE { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CGC { get; set; }
            [StringLength(30)]
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
        public int ETIQUETA { get; set; }
            [StringLength(12)]
        /// <summary>
        /// 
        /// </summary>
        public string INSCRICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRCHEQUE { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CODEMP { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string CODFIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASE1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASE2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QUOTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRLIVRO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRLIVROINV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRFORNEC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEQREMESSA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BANCODEPOS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string RESERVA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CAC_ORGREC { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string CAC_CODLOJ { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CDCOBRADOR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ORACLE { get; set; }

    }
}
