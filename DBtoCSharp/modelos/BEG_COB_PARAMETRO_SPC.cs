
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_PARAMETRO_SPC
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COB_PARAMETRO_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_AVISO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_SPC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ULT_ENVIO_SPC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTD_ENVIO_ULT_DTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SEQ_PROC_SPC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ULT_ENVIO_ANT { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_SPC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_ASSOCIADO_SPC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_FILIAL_SPC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IDADE_MINIMA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IDADE_MAXIMA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CRIA_RESTRICAO_SPC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_TITULO_UNICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CONTATO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_COBRANCA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CARTORIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_RESTRICAO_CARTORIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_RESTRICAO_JURIDICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_DIAS_MAX_NEGATIVAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXECUTA1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXECUTA2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXECUTA3 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXECUTA4 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXECUTA5 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXECUTA6 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXECUTA7 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_INTEGRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_DIAS_MAX_AVISO { get; set; }

    }
}
