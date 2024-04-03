
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_REL_CLI_CREDZ
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_VENDAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VENDA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string SEXO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_NASCIMENTO { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string IDADE { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string EMPRESA { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string FUNCAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_VENDAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TEMPO_RELACIONAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LIMITE_PARCELADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ULT_VENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RANDOM { get; set; }

    }
}
