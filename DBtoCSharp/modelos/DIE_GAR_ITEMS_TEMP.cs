
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_GAR_ITEMS_TEMP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int ID_GAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ITEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ITEM_NF { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_APOLICE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_AP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PREMIO_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LIMITE_INDE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IOF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_BILHETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_SORTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CODPRO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCPRO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NFS2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ID_NF2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int APOLICEPF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int APOLICEGAR { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int GAR_EST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int GAR_FAB { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_UNIT { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IDSERVICO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string USUARIO { get; set; }

    }
}
