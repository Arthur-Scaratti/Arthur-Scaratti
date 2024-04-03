
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_EST_AUDITORIA_ALMOX
    {
            [Required]
    [Key]
        /// <summary>
        /// Id da Auditoria do Almoxarifado de Inspecao
        /// </summary>
        public int DIE_EST_AUDITORIA_ALMOX_ID { get; set; }
        
        /// <summary>
        /// Id da Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// Id da Filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Ativo - Yes / No
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// Data da criacao do registro
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// Id do usuario que criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// Data da ultima alteracao do registro
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// Id do usuario que fez a ultima alteracao registro
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// Data da Contagem
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// Id do Almoxarifado
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Observacoes
        /// </summary>
        public string OBS { get; set; }

    }
}
