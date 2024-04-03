
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_GAR_TEMP
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ID_GAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ID_NF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NFS { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string MODAL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_VEND { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string NOM_VEND { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_CLIENTE { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDER { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_PEDIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_CONTROLE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_NASC { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string FIL1 { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string FIL2 { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string FIL3 { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string USUARIO { get; set; }

    }
}
