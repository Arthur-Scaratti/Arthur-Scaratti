
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_TIT_GERAL_TMP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_TIT_GERAL_TMP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TP_COBRANCA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CLIENTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONTRATO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_DEVOL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_TITULO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_NF_SAIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CPFCNPJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TP_PESSOA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_SESSION_ID { get; set; }

    }
}
