
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CLIENTEORA
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CTPS { get; set; }
            [StringLength(17)]
        /// <summary>
        /// 
        /// </summary>
        public string TITELEITOR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CARGOCONJ { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string EMPCONJ { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DDDCONJ { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string FONECONJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTADMICONJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RENDA1CONJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RENDA2CONJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTNASCONJ { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CLIBANCO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSADO { get; set; }
            [StringLength(35)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDCOM { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADECOM { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTADOCOM { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CARGOCOM { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string SETORCOM { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string OUTROSDOCS { get; set; }
            [StringLength(35)]
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCIA { get; set; }
            [StringLength(35)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDRESREF { get; set; }
            [StringLength(35)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDCOMREF { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string FONEREF { get; set; }
            [StringLength(35)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDEMPCONJ { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDEMPCONJ { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTEMPCONJ { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string SETEMPCONJ { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string OPERADOR { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CGCOLD { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DTULTATUAL { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CGC { get; set; }
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
        public string DEBITO { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string INSCRICAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CLASSIF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTINCLUSAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTCIVIL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SEXO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string EMPRESA { get; set; }
            [StringLength(18)]
        /// <summary>
        /// 
        /// </summary>
        public string FONEEMPR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTADMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RENDA1 { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string CONJUGE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string PAI { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string MAE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string RG { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DDDRES2 { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string FONERES2 { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DDDCEL { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string FONECEL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RESIDANO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RESIDMES { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TPMORADIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLALUGUEL { get; set; }
            [StringLength(35)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDANT { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NATURAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRDEPENDE { get; set; }

    }
}
