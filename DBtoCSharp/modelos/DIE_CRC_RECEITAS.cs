
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_RECEITAS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_RESUMO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_RECEITAS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_INI { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string REIMPRESSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ACERTO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT3 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT4 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT5 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT13 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT6 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT20 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT21 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT22 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT7 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT8 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT9 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT10 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT11 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT14 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT12 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT23 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT24 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VTOT25 { get; set; }

    }
}
