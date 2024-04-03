
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_CLI_INATIVO_VM
    {
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CD_FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_MES_INATIVO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_RESUMIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ULT_COMPRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONTRATO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ULT_COMPRA { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string TELEFONES { get; set; }
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
        public string CONDICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MEDIO_PARC { get; set; }
            [StringLength(240)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_TITULO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_UF_ID { get; set; }

    }
}
