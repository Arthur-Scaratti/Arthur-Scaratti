
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_AVISO_PESSOA_HIST
    {
        
        /// <summary>
        /// Id do cliente afiancado
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
        
        /// <summary>
        /// id do avalista do contrato
        /// </summary>
        public int DIE_CRC_CONTRATO_AVALISTA_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do aviso da pessoa - historico
        /// </summary>
        public int BEG_COB_AVISO_PESSOA_HIST_ID { get; set; }
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
        /// <summary>
        /// Codigo do cliente
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(60)]
        /// <summary>
        /// Nome do cliente - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string NOME { get; set; }
            [StringLength(60)]
        /// <summary>
        /// Endereco - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string ENDERECO { get; set; }
        
        /// <summary>
        /// Bairro - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Cidade - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Estado (UF) - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string ESTADO { get; set; }
            [StringLength(9)]
        /// <summary>
        /// Codigo de enderecamento postal - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string CEP { get; set; }
            [StringLength(600)]
        /// <summary>
        /// Contratos
        /// </summary>
        public string CONTRATOS { get; set; }
            [Required]
        /// <summary>
        /// id do aviso
        /// </summary>
        public int BEG_COB_AVISO_ID { get; set; }
        
        /// <summary>
        /// id da filial - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// Numero do aviso
        /// </summary>
        public int NRO_AVISO { get; set; }
        
        /// <summary>
        /// Dias inicial para validacao do aviso - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public int DIAS_INI { get; set; }
        
        /// <summary>
        /// Fias final    para validacao do aviso - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public int DIAS_FIN { get; set; }
            [Required]
        /// <summary>
        /// Indicativo de aviso impresso
        /// </summary>
        public string IND_IMPRESSO { get; set; }
        
        /// <summary>
        /// Data de impressao do aviso
        /// </summary>
        public string DT_IMPRESSAO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Complemento do endereco - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string COMPLEMENTO { get; set; }
        
        /// <summary>
        /// Id da pessoa na Filial
        /// </summary>
        public int BEG_VW_GER_PESSOA_FILIAL_ID { get; set; }
        
        /// <summary>
        /// Indicativo para enviar o aviso para o cliente
        /// </summary>
        public string IND_ENVIAR { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Observacao refente a  alteracao do indicativo de n?o enviar o aviso ao cliente
        /// </summary>
        public string OBS { get; set; }

    }
}
