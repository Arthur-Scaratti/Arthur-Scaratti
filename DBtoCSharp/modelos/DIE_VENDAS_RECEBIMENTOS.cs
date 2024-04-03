
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VENDAS_RECEBIMENTOS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_VENDAS_RECEB_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_ENT_SERVICOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_SERVICOS_V { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_SERVICOS_P { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_FAT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
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
        public string DT_EMISSAO_INICIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_FINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_NFS_V { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_PREST_SERVICOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_CUSTO_FINANC_V { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_GARANTIA_V { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_SEGURO_V { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_SEGUROS_V { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_NFS_P { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_CUSTO_FINANC_P { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_GARANTIA_P { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_SEGURO_P { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_SEGUROS_P { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_FAT_SERVICOS_V { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_POSICAO_GERAL_A6 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SALDO_MES_ANTERIOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_BX_RENEG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_NEW_RENEG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_GER_NFS_V { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_GER_NFS_P { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_SUBTOTAIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_GER_SER_V { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_GER_SER_P { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_GER_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_FAT_SER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_FAT_P { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_APRAZO_G { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_APRAZO_SUBTOTAIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_APRAZO_SER_P { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_APRAZO_B { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_ENTRADAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_PREST_TF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_ENT_TF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_ENT_CARTAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_PRESTACOES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_SUB_SERVICOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_SUBTOTAL_CLI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_SUB_TF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_DESCONTOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_JUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_RECEBIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_GERAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_DEVOLUCAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DEVCLI_V { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ESTDEV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_RESULTADO_GE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_RESULTADO_CF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_RESULTADO_BCDEF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_GER_SUBTOTAIS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string REIMPRESSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_TF_SUBTOTAIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_APRAZO_P { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_VENDA_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DEV_SEGUROS { get; set; }

    }
}
