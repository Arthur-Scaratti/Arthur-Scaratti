
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_RENEGOCIACAO
    {
        
        /// <summary>
        /// Filial responsavel pela entrega do titulo ao cobrador
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Diementz
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Loja que emitiu o titulo
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(40)]
    [Key]
        /// <summary>
        /// Contrato (Beg_crc_titulo)
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// Id do cobrador
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
        
        /// <summary>
        /// Data da Renegociacao
        /// </summary>
        public string DT_RENEGOCIACAO { get; set; }

    }
}
