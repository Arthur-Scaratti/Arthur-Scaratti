
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAR_RESUMO_CARTOES
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_RES_CARTOES_ID { get; set; }
        
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
        public string DATA_INICIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_FINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ANT_VISA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ANT_REDECARD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ANT_AMEX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ANT_BANRICOMPRAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VEN_VISA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VEN_REDECARD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VEN_AMEX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VEN_BANRICOMPRAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_REP_VISA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_REP_REDECARD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_REP_AMEX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_REP_BANRICOMPRAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DES_VISA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DES_REDECARD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DES_AMEX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DES_BANRICOMPRAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CAN_VISA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CAN_REDECARD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CAN_AMEX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CAN_BANRICOMPRAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ATU_VISA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ATU_REDECARD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ATU_AMEX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ATU_BANRICOMPRAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_ANT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_VEN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_REP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_DES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_CAN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_ATU { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string RESUMO_FINAL { get; set; }

    }
}
