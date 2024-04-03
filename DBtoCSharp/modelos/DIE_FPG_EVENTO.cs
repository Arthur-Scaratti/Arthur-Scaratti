
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FPG_EVENTO
    {
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_EVENTO_NOVO { get; set; }
            [Required]
        /// <summary>
        /// Codigos de eventos para folha de pagamento
        /// </summary>
        public int DIE_FPG_EVENTO_ID { get; set; }
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
            [Required]
    [StringLength(5)]
        /// <summary>
        /// codigo do evento na folha de pagamento
        /// </summary>
        public string COD_EVENTO { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// descricao do tipo de evento
        /// </summary>
        public string DESCRICAO { get; set; }

    }
}
