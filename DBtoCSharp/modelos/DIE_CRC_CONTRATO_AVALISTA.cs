
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_CONTRATO_AVALISTA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_CONTRATO_AVALISTA_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRATO { get; set; }
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
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string APP_USER { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BU_CRC_CONTR_AVAL { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  VB_APEX boolean;\nbegin\n\n  if :new.APP_USER is not null\n     and UPDATING then\n    VB_APEX := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TAB_UPD(:new.APP_USER,\n                                                          :new.UPDATED,\n                                                          :new.UPDATEDBY);\n    :new.APP_USER := null;\n  end if;\n\nend DIE_TRG_BU_CRC_CONTR_AVAL;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BI_DIE_CONT_AVALISTA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  VB_APEX boolean;\n\n  cursor C_CONTRATO(P_AD_ORG_ID number, P_CONTRATO varchar) is\n    select BEG_CRC_TITULO_ID,\n           BEG_TIPO_TITULO_ID,\n           DT_EMISSAO\n      from BEG_CRC_TITULO TIT\n     where value = P_CONTRATO\n       and TIT.AD_ORG_ID = P_AD_ORG_ID\n       and NVL(TIT.NUM_NF_DEVOL, 0) = 0 -- AOK -- 21/10/2008\n       and TIT.PARCELA = 1;\n  --  and TIT.IND_ABERTO = 'Y';\n\n  cursor C_AVALISTA(P_DT_EMISSAO date, P_BEG_PESSOA_ID number) is\n    select BEG_PESSOA_ID\n      from BEG_PESSOA PES\n     where PES.ISACTIVE = 'Y'\n       and PES.CLIENTE = 'Y'\n       and PES.BEG_PESSOA_ID = P_BEG_PESSOA_ID\n       and PES.CPFCNPJ is not null\n       and PES.CEP is not null\n       and PES.ENDERECO is not null\n       and PES.BEG_PESSOA_ID not in\n           (select BEG_PESSOA_ID\n              from BEG_CRC_TITULO TITA\n             where TITA.BEG_PESSOA_ID = PES.BEG_PESSOA_ID\n               and TITA.DT_VCTO < P_DT_EMISSAO\n               and NVL(TITA.NUM_NF_DEVOL, 0) = 0 -- AOK -- 21/10/2008\n               and BEG_FNC_CRC_RETROAGE_TITULO(TITA.BEG_CRC_TITULO_ID,\n                                               P_DT_EMISSAO) > 0);\n  R_AVALISTA   C_AVALISTA%rowtype;\n  V_DT_EMISSAO date;\nbegin\n\n  if :new.APP_USER is not null\n     and INSERTING then\n    --  :new.DOCSTATUS := 'CO';\n    VB_APEX := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TABLE(:new.APP_USER,\n                                                        'BEG_COB_CONTATO',\n                                                        :new.AD_CLIENT_ID,\n                                                        :new.AD_ORG_ID,\n                                                        :new.CREATED,\n                                                        :new.CREATEDBY,\n                                                        :new.UPDATED,\n                                                        :new.UPDATEDBY,\n                                                        :new.DIE_CRC_CONTRATO_AVALISTA_ID);\n  end if;\n\n  --Validando existencia do Contrato\n  if :new.ISACTIVE = 'Y' then\n    -- AOK - 29/12/2008\n    open C_CONTRATO(:new.AD_ORG_ID, :new.CONTRATO);\n  \n    fetch C_CONTRATO\n      into :new.BEG_CRC_TITULO_ID, :new.BEG_TIPO_TITULO_ID, V_DT_EMISSAO;\n  \n    if C_CONTRATO%notfound then\n      close C_CONTRATO;\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Contrato não valido para essa filial !');\n    end if;\n    close C_CONTRATO;\n  \n    --Validando o Avalista\n    -- Se for necessario liberar um cadastramento de um avalista que não foi feito a analise corretamente\n    --- ******  COMENTE DAQUI (Cursor C_AVALISTA)  /*\n    open C_AVALISTA(V_DT_EMISSAO, :new.BEG_PESSOA_ID);\n  \n    fetch C_AVALISTA\n      into R_AVALISTA;\n  \n    if C_AVALISTA%notfound then\n      close C_AVALISTA;\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Problemas com o Avalista, Endereco ou Titulos vencidos !!!');\n    end if;\n    close C_AVALISTA;\n    --    */   --- *******ATE AQUI\n  end if;\n\nend;\n"}`;
    
    }
}
