
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_CONV_FAT_LOT
    {
            [StringLength(30)]
        /// <summary>
        /// Usuario do portal
        /// </summary>
        public string APP_USER { get; set; }
        
        /// <summary>
        /// data do faturamento
        /// </summary>
        public string DT_FATURAMENTO { get; set; }
        
        /// <summary>
        /// Data de emissao do relatorio
        /// </summary>
        public string DT_EMISSAO_RELATO { get; set; }
        
        /// <summary>
        /// ID da Filial responsavel pelo convenio
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// id do lote do convenio
        /// </summary>
        public int BEG_VEN_CONV_FAT_LOT_ID { get; set; }
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
        /// Id do convenio
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// data do processamento do lote
        /// </summary>
        public string DT_ATUALIZACAO { get; set; }
            [Required]
        /// <summary>
        /// valor do lote
        /// </summary>
        public int VLR_LOTE { get; set; }
            [Required]
        /// <summary>
        /// qtde titulos do lote
        /// </summary>
        public int QTD_TITULO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuario quem processou o lote
        /// </summary>
        public string USUARIO { get; set; }
            [Required]
        /// <summary>
        /// data de referencia
        /// </summary>
        public string DT_REFERENCIA { get; set; }

    }
}
