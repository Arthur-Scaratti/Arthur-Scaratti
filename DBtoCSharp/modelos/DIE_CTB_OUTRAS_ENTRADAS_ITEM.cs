
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CTB_OUTRAS_ENTRADAS_ITEM
    {
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ_FILIAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_APROV_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CTB_OUT_ENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
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
        public int COD_FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CD_FILIAL_CONTABIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTRADA_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTRADA_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRNF { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CFOP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CST { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string FORNECEDOR { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_NOTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS_CALC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEQUENCIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_COD_PRODUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_UNITARIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_DETALHADA { get; set; }
        
        /// <summary>
        /// V
        /// </summary>
        public int VLR_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string DTENTRADA { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_ENTRADA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DIE_COD_ESTRUTURADO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCR_UNIDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS_SUBST { get; set; }
            [StringLength(18)]
        /// <summary>
        /// 
        /// </summary>
        public string INSCRICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_TRIB_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ITEM_DESDOBR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ACRESCIMO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEQ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FRETE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTRAS_DESPESAS { get; set; }

    }
}
