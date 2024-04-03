
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_BAIXA_MANUAL
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_BAIXA_MANUAL_ID { get; set; }
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
        /// 
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
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MOVTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_JUROS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MULTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RECIBO_PAGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TPMOV_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_COBRADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_CAIXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_PGTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_REAJUSTE { get; set; }
            [Required]
    [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CDDUPL { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string PARCELA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SRDUP { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CLASSIF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DTVENCTO { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string ERRO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PROCESSAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_HISTORICO_ID { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CRC_BAIXA_MANUAL { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  cursor C_TITULO(P_CDDUPL BEG_CRC_TITULO.value%type, P_PARCELA BEG_CRC_TITULO.PARCELA%type, P_AD_ORG_ID BEG_CRC_TITULO.AD_ORG_ID%type, P_SRDUP BEG_CRC_TITULO.SRDUP%type, P_BEG_PESSOA_ID number) is\n    select BEG_CRC_TITULO_ID,\n           DT_VCTO\n      from BEG_CRC_TITULO B\n     where B.BEG_PESSOA_ID = P_BEG_PESSOA_ID\n       and B.value = P_CDDUPL\n       and B.PARCELA = P_PARCELA\n       and B.AD_ORG_ID = P_AD_ORG_ID;\n\n  cursor C_HISTORICO(P_BEG_CRC_TITULO_ID number) is\n    select NVL(max(value), 0) + 1\n      from BEG_CRC_HISTORICO\n     where BEG_CRC_TITULO_ID = P_BEG_CRC_TITULO_ID;\n\n  V_BEG_CRC_TITULO_ID number(10);\n  V_DT_VCTO           date;\n  TITULO_NAO_ENCONTRADO exception;\n  VENCIMENTO_INVALIDO exception;\n  V_BEG_CRC_HISTORICO_ID number(10);\n  V_MAX_VALUE            binary_integer;\nbegin\n  -- Test statements here\n  :new.DT_PROCESSAMENTO := sysdate;\n  open C_TITULO(:new.CDDUPL,\n                :new.PARCELA,\n                :new.AD_ORG_ID,\n                :new.SRDUP,\n                :new.BEG_PESSOA_ID);\n\n  fetch C_TITULO\n    into V_BEG_CRC_TITULO_ID, V_DT_VCTO;\n\n  if C_TITULO%notfound then\n    close C_TITULO;\n    raise TITULO_NAO_ENCONTRADO;\n  end if;\n\n  if TRUNC(V_DT_VCTO) <> TRUNC(:new.DTVENCTO) then\n    close C_TITULO;\n    raise VENCIMENTO_INVALIDO;\n  end if;\n\n  close C_TITULO;\n\n  --Buscando maior value do historico\n  open C_HISTORICO(V_BEG_CRC_TITULO_ID);\n  fetch C_HISTORICO\n    into V_MAX_VALUE;\n  close C_HISTORICO;\n\n  --Inserindo o pagamento\n  V_BEG_CRC_HISTORICO_ID := BEG_FNC_AD_SEQUENCE('BEG_CRC_HISTORICO');\n\n  insert into BEG_CRC_HISTORICO\n    (BEG_CRC_HISTORICO_ID,\n     AD_CLIENT_ID,\n     AD_ORG_ID,\n     ISACTIVE,\n     value,\n     CREATED,\n     CREATEDBY,\n     UPDATED,\n     UPDATEDBY,\n     VLR_MOVTO,\n     VLR_JUROS,\n     VLR_MULTA,\n     VLR_DESCONTO,\n     RECIBO_PAGTO,\n     BEG_CRC_TPMOV_ID,\n     BEG_CRC_TITULO_ID,\n     BEG_PESSOA_COBRADOR_ID,\n     BEG_PESSOA_CAIXA_ID,\n     BEG_BANCO_ID,\n     BEG_FILIAL_PGTO_ID,\n     DT_PGTO,\n     COMISSAO,\n     SEQ_PGTO,\n     VLR_DESPESA,\n     VLR_REAJUSTE)\n  values\n    (V_BEG_CRC_HISTORICO_ID,\n     :new.AD_CLIENT_ID,\n     :new.AD_ORG_ID,\n     'Y',\n     V_MAX_VALUE,\n     :new.CREATED,\n     :new.CREATEDBY,\n     :new.UPDATED,\n     :new.UPDATEDBY,\n     :new.VLR_MOVTO,\n     :new.VLR_JUROS,\n     :new.VLR_MULTA,\n     :new.VLR_DESCONTO,\n     :new.RECIBO_PAGTO,\n     :new.BEG_CRC_TPMOV_ID,\n     V_BEG_CRC_TITULO_ID,\n     null,\n     null,\n     null,\n     :new.BEG_FILIAL_PGTO_ID,\n     :new.DT_PGTO,\n     0,\n     0,\n     0,\n     :new.VLR_REAJUSTE);\n\n  :new.DOCSTATUS            := 'CO';\n  :new.BEG_CRC_HISTORICO_ID := V_BEG_CRC_HISTORICO_ID;\n  :new.BEG_CRC_TITULO_ID    := V_BEG_CRC_TITULO_ID;\n  :new.ERRO                 := null;\n\nexception\n\n  when TITULO_NAO_ENCONTRADO then\n    :new.ERRO                 := 'Titulo não encontrado !!!';\n    :new.BEG_CRC_HISTORICO_ID := null;\n    :new.DOCSTATUS            := 'WC';\n    :new.BEG_CRC_TITULO_ID    := null;\n  \n  when VENCIMENTO_INVALIDO then\n    :new.ERRO                 := 'Vencimento Inválido !!!';\n    :new.BEG_CRC_HISTORICO_ID := null;\n    :new.DOCSTATUS            := 'WC';\n    :new.BEG_CRC_TITULO_ID    := null;\n  \n  when others then\n    :new.ERRO                 := sqlerrm;\n    :new.BEG_CRC_HISTORICO_ID := null;\n    :new.DOCSTATUS            := 'WC';\n    :new.BEG_CRC_TITULO_ID    := null;\nend;\n"}`;
    
    }
}
