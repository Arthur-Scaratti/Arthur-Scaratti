
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_POSICAO_GER_CLI
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_POSICAO_GER_CLI_ID { get; set; }
        
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
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_TOTTIT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_TOTSLD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_VLRDEV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_TOTCLI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_TOTCLS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_TOTDEV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_TOTMOV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_TOTJRS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_TOTMUL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_TOTDES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_TOTPGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_VLMVTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_VLRJRS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_VLRMUL { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string VC_OBS1 { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string VC_OBS2 { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string VC_OBS3 { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string VC_OBS4 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_VLRDES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_VLRPGO { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string VC_DTAPGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VD_DATA_DEVOL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_DIAS_QUITACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DEVIDO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string VC_COBRADOR { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string VC_DEVOL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_NUM_NF_DEVOL { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string TELEFONE { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CODFIL { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_SESSION_ID { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string VC_SUBTIT { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string VC_TITULO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SRDUP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CLASSIF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ACOMPENSAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VENCIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MEDIA_ATRASO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCELAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAS_ATRASO { get; set; }
            [StringLength(2000)]
        /// <summary>
        /// 
        /// </summary>
        public string VC_OBSERV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AVISO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIALPGTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_PGTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_PRODUTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SIT_TITULO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRATO1 { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPLEMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_VLRTIT { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string VC_MARCA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRATO2 { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRATO3 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_AVISO_PGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGURO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_GARANTIA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_COBRANCA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string VN_VALUE1 { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string VN_VALUE2 { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string VN_VALUE3 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_CONVENIO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CONVENIO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_MOV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_HISTORICO_ID { get; set; }

    }
}
