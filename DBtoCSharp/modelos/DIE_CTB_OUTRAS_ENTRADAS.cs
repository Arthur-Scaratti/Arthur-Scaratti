
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CTB_OUTRAS_ENTRADAS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
        
        /// <summary>
        /// 
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
            [StringLength(18)]
        /// <summary>
        /// 
        /// </summary>
        public string INSCRICAO { get; set; }
            [StringLength(44)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE_NFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_IPI_CALC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_REDUZIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_PRODUTOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_PARCELAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTROS_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS_SUBST { get; set; }
        
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
        public int BEG_VW_CFOP_ENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_TECNICA_ITEM { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DIE_COD_ESTRUTURADO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_APROV_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CONTABIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGURO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OUTRAS_DESPESAS { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ_FILIAL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ITEM_DESDOBR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_TRIB_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CTB_OUT_ENT_ID { get; set; }
        
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
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRNF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CFOP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CD_FILIAL_CONTABIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CST { get; set; }
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

    }
}
