
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_TITULO_ABERTO_ORG
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ABERTO_ORG_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        public int PARCELA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TITULO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MULTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_JUROS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_COBRANCA { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO_TITULO_BANCO { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESPESA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_NF_SAIDA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENVIO_BCO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEQ_ENVIO_BCO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_RENEGOCIACAO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IMPRESSO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COB_AVISO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_LOTE_COB_ESCR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PCE_LOTE_COBRANCA_ID { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string LINHA_DIGITAVEL { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO_BARRAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PCE_COMANDO_REM_COB_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PCE_INSTRUCAO_COBRANCA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PCE_INSTR_COBR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGURO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_GARANTIA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TX_FINANCEIRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_LOCALIZACAO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PREPOSTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TELEVENDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_REAJUSTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SRDUP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CLASSIF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_AVISO_PGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_NF_DEVOL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_DEVOL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_DEVOL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COB_AVISO_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }

    }
}
