
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_SIT_CONTATO
    {
        
        /// <summary>
        /// Indica o envio de e-mail para a loja
        /// </summary>
        public string IND_EMAIL_LOJA { get; set; }
        
        /// <summary>
        /// indica o envio de e-mail para o cliente
        /// </summary>
        public string IND_EMAIL_CLIENTE { get; set; }
            [Required]
        /// <summary>
        /// Numero de dias para novo contato
        /// </summary>
        public int QTDE_DIAS { get; set; }
        
        /// <summary>
        /// Indica que será feito o reagendamento automatico
        /// </summary>
        public string IND_REAGENDA { get; set; }
        
        /// <summary>
        /// Indica para criar observacao no titulos pendentes
        /// </summary>
        public string IND_OBS_TITULO { get; set; }
            [Required]
        /// <summary>
        /// Indica que será enviado para cobranca externa
        /// </summary>
        public string IND_COBRADOR { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id da situacao do contato
        /// </summary>
        public int BEG_COB_SIT_CONTATO_ID { get; set; }
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
        /// Codigo reduzido da situacao do contato
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
    [StringLength(100)]
        /// <summary>
        /// Descricao do contato
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// Indicar que o cliente informou que ira depositar em conta corrente
        /// </summary>
        public string IND_DEPOSITO { get; set; }

    }
}
