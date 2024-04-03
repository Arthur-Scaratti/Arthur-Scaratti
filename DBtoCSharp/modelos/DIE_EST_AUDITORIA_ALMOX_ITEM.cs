
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_EST_AUDITORIA_ALMOX_ITEM
    {
        
        /// <summary>
        /// Id do Item da Auditoria do Almoxarifado
        /// </summary>
        public int DIE_EST_AUDITOR_ALMOX_ITEM_ID { get; set; }
        
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
        /// Ativo - yes / no
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// Data da criacao do registro
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// Id do Usuario que criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// Data da ultima alteracao do regsitro
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// Id do Usuario que fez a ultima alteracao no registro
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// Id da Auditoria do Almoxarifado de Inspecao
        /// </summary>
        public int DIE_EST_AUDITORIA_ALMOX_ID { get; set; }
        
        /// <summary>
        /// Id do Produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// Quantidade
        /// </summary>
        public int QTDE { get; set; }
        
        /// <summary>
        /// Quantidades Contadas
        /// </summary>
        public int QTDE_CONTADAS { get; set; }
        
        /// <summary>
        /// Preco
        /// </summary>
        public int PRECO { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Observacoes
        /// </summary>
        public string OBS { get; set; }

    }
}
