
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_APEX_USER_TST
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_APEX_USER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TELEVENDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_COTA_FAIXA_ID { get; set; }
            [Required]
    [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string USUARIO { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string SENHA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_REPRESENTANTE_ID { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_SUPERVISOR_VENDAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_SUPERVISOR_TELEVENDAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_GERENTE_VENDAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_TELE_VENDEDOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_SEPARADOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_VENDEDOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_COMPRADOR { get; set; }
            [Required]
    [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ_REPRESENTADA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CAIXA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CREDIARISTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_COBRADOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ROLE_ID { get; set; }

    }
}
