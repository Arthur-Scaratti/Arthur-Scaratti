
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_COB_SPC_CHEQUE
    {
            [Required]
    [Key]
        /// <summary>
        /// Id dos cheques no SPC
        /// </summary>
        public int DIE_COB_SPC_CHEQUE_ID { get; set; }
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
    [StringLength(20)]
        /// <summary>
        /// Nro documento registrado
        /// </summary>
        public string NRO_DOCUMENTO { get; set; }
        
        /// <summary>
        /// Cod.Banco
        /// </summary>
        public int COD_BANCO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Nome do Banco
        /// </summary>
        public string NOME_BANCO { get; set; }
        
        /// <summary>
        /// Codigo do motivo da devolução
        /// </summary>
        public int COD_MOT_DEVOL { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Descricao do motivo da devolução
        /// </summary>
        public string DESC_MOT_DEVOL { get; set; }
        
        /// <summary>
        /// Data do registro no SPC
        /// </summary>
        public string DT_ENVIO_SPC { get; set; }
        
        /// <summary>
        /// Data de vencimento
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// Id da Pessoa (quando cadastrado)
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// Registro (C)onsumidor (F)iador
        /// </summary>
        public string IND_REGISTRO { get; set; }
        
        /// <summary>
        /// Id da pessoa quando dor afiancado
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
        
        /// <summary>
        /// Valor do chque
        /// </summary>
        public int VLR_DIVIDA { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuario Apex
        /// </summary>
        public string APP_USER { get; set; }
            [StringLength(70)]
        /// <summary>
        /// Nome do devedor
        /// </summary>
        public string NOME_DEVEDOR { get; set; }
            [StringLength(15)]
        /// <summary>
        /// CPF ou CGC do devedor
        /// </summary>
        public string CPFCGC { get; set; }
        
        /// <summary>
        /// codigo da agencia
        /// </summary>
        public int COD_AGENCIA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// nro_cheque
        /// </summary>
        public string NRO_CHEQUE { get; set; }
        
        /// <summary>
        /// data de pesquisa
        /// </summary>
        public string DT_PESQUISA { get; set; }

    }
}
