
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CLI_FCDL
    {
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string CLIENTE { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_ASSOCIADO { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL_CLIENTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INCLUSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VENC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_COMPRA { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string VALOR { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string ORIGEM_INCLUSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_DISPONIVEL { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string ORIGEM_EXCLUSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EXCLUSAO { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_NOTIFICACAO { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string MOTIVO_EXCLUSAO { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string LOGRADOURO { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPLEMENTO { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRATO { get; set; }

    }
}
