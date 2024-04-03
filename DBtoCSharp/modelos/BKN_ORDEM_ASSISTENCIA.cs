
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BKN_ORDEM_ASSISTENCIA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_POSTO_AUTORIZADO_ID { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string DEFEITO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NUM_SERIE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_AUTORIZADO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_OS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BKN_ORDEM_ASSISTENCIA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
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
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string ACESSORIOS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string LAUDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_GARANTIA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_GARANTIA_ESTENDIDA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_PAGO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string RESPONSAVEL_PGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }

    }
}
