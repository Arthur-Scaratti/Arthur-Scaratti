
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_ROLE
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TREE_MENU_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMANUAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSHOWACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPERSONALLOCK { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPERSONALACCESS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCANEXPORT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCANREPORT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SUPERVISOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCANAPPROVEOWNDOC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISACCESSALLORGS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCHANGELOG { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PREFERENCETYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITEPRICELIMIT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISUSEUSERORGACCESS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TREE_ORG_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CONFIRMQUERYRECORDS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MAXQUERYRECORDS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CONNECTIONPROFILE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Bot?o auxiliar para executar processo no Compiere
        /// </summary>
        public string BTN_CLEAR_ACCESS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ROLE_ID { get; set; }
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
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string USERLEVEL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AMTAPPROVAL { get; set; }

    }
}
