
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CARGA_SPC_TMP
    {
            [StringLength(40)]
        /// <summary>
        /// Numero do documento registrado no SPC - Carga
        /// </summary>
        public string NRODOC_CARGA { get; set; }
        
        /// <summary>
        /// Data de pesquisa
        /// </summary>
        public string DT_PESQUISA { get; set; }
            [StringLength(14)]
        /// <summary>
        /// CPF ou CGC do devedor
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Nome do devedor
        /// </summary>
        public string NOME { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Nro documento
        /// </summary>
        public string NRODOC { get; set; }
        
        /// <summary>
        /// Data de emissao
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// Data de vencimento
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// Data de inclusao do registro
        /// </summary>
        public string DT_INC_REG { get; set; }
        
        /// <summary>
        /// codigo da filial
        /// </summary>
        public int CODFIL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indicativo se cliente inativo
        /// </summary>
        public string CLIENTE_INATIVO { get; set; }
        
        /// <summary>
        /// codio da filial no SPC
        /// </summary>
        public int COD_SPC_FILIAL { get; set; }
        
        /// <summary>
        /// Id da Pessoa (BD)
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// Id do titulo (BD)
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// Valor da divida
        /// </summary>
        public int VL_DIVIDA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Observacoes do registro
        /// </summary>
        public string OBS_REG { get; set; }
        
        /// <summary>
        /// codigo do banco
        /// </summary>
        public int COD_BANCO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// nome do banco
        /// </summary>
        public string NOME_BANCO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// descricao do motito devolucao - cheques
        /// </summary>
        public string DESC_MOT_DEVOL { get; set; }
        
        /// <summary>
        /// data de notificacao de debito
        /// </summary>
        public string DT_NOT_DEBITO { get; set; }
        
        /// <summary>
        /// data de liberacao para consulta
        /// </summary>
        public string DT_LIB_CONSULTA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indicavo de titulo em aberto (y/n)
        /// </summary>
        public string IND_ABERTO { get; set; }
        
        /// <summary>
        /// Valor em aberto
        /// </summary>
        public int VLR_ABERTO { get; set; }
        
        /// <summary>
        /// Valor do titulo
        /// </summary>
        public int VLR_TITULO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// (C)omprador ou (F)iador
        /// </summary>
        public string IND_REGISTRO { get; set; }
        
        /// <summary>
        /// Id do cliente quando o ind_registro = 'F'
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Nome do afiancado quando ind_registro = 'F'
        /// </summary>
        public string NOME_AFIANCADO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Nome da filial cadastrada no SPC
        /// </summary>
        public string NOME_FILIAL { get; set; }

    }
}
