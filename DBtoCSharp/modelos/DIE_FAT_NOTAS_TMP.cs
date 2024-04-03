
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_NOTAS_TMP
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_NOTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_INICIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string INUTILIZADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INUTILIZADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_FINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_NOTAS_TMP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
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
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NFS { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE_NFS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [StringLength(25)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ_FILIAL { get; set; }
            [StringLength(25)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ_DEST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_CONTABIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ACRESCIMO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_IPI { get; set; }
        
        /// <summary>
        /// Numero do cupom fiscal
        /// </summary>
        public int NRO_CUPOM_FISCAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CANCELADA { get; set; }

    }
}
