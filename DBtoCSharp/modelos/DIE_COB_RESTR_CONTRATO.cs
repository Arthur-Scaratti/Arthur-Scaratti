
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_COB_RESTR_CONTRATO
    {
            [Required]
    [Key]
        /// <summary>
        /// Id da resticoes de contrato para a cobranca
        /// </summary>
        public int DIE_COB_RESTR_CONTRATO_ID { get; set; }
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
    [StringLength(10)]
        /// <summary>
        /// Contrato
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Id do tipo do titulo
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// Data inicial da restricao
        /// </summary>
        public string DT_INICIAL { get; set; }
        
        /// <summary>
        /// Data final da restricao
        /// </summary>
        public string DT_FINAL { get; set; }
            [StringLength(300)]
        /// <summary>
        /// Observacao
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// Id do parceiro comercial
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// Valor do conrato
        /// </summary>
        public int VL_CONTRATO { get; set; }
        
        /// <summary>
        /// Valor em aberto do contrato
        /// </summary>
        public int VL_CONTRATO_ABERTO { get; set; }
            [Required]
        /// <summary>
        /// Status do registro  1aberto 2.fechado
        /// </summary>
        public int DIE_STATUS { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuario Apex
        /// </summary>
        public string APP_USER { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BI_COB_REST_CONTRATO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  cursor CRESTR is\n    select *\n      from DIE_COB_RESTR_CONTRATO X\n     where X.AD_ORG_ID = :new.AD_ORG_ID\n       and X.value = :new.value\n       and X.BEG_TIPO_TITULO_ID = :new.BEG_TIPO_TITULO_ID\n       and exists\n     (select 1\n              from BEG_CRC_TITULO_ABERTO_ORG T\n             where T.AD_CLIENT_ID = X.AD_CLIENT_ID\n               and T.AD_ORG_ID = X.AD_ORG_ID\n               and T.value = X.value\n               and T.BEG_TIPO_TITULO_ID = X.BEG_TIPO_TITULO_ID)\n       and (X.DT_FINAL is null or X.DT_FINAL > TRUNC(sysdate));\n  RRESTR CRESTR%rowtype;\n\nbegin\n\n  open CRESTR;\n  fetch CRESTR\n    into RRESTR;\n  if CRESTR%found then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Já existe uma restricao ativa para este contrato - Verifique!');\n  end if;\n\nend DIE_TRG_BI_COB_REST_CONTRATO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIU_COB_RESTR_CONTRATO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  cursor CTITULO is\n    select T.BEG_PESSOA_ID,\n           sum(T.VLR_TITULO) VL_CONTRATO,\n           sum(T.VLR_ABERTO) VL_CONTRATO_ABERTO,\n           count(1) QTDE\n      from BEG_CRC_TITULO T\n     where T.AD_CLIENT_ID = :new.AD_CLIENT_ID\n       and T.AD_ORG_ID = :new.AD_ORG_ID\n       and T.value = :new.value\n       and T.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n       and T.BEG_TIPO_TITULO_ID = :new.BEG_TIPO_TITULO_ID\n       and T.ISACTIVE = 'Y'\n       and T.IND_ABERTO = 'Y'\n     group by T.BEG_PESSOA_ID;\n\n  RTITULO     CTITULO%rowtype;\n  VB_APEX     boolean;\n  V_AD_ORG_ID number(10);\n\nbegin\n\n  if :new.APP_USER is not null\n     and INSERTING then\n    VB_APEX := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TABLE(:new.APP_USER,\n                                                        'DIE_COB_RESTR_CONTRATO',\n                                                        :new.AD_CLIENT_ID,\n                                                        V_AD_ORG_ID,\n                                                        :new.CREATED,\n                                                        :new.CREATEDBY,\n                                                        :new.UPDATED,\n                                                        :new.UPDATEDBY,\n                                                        :new.DIE_COB_RESTR_CONTRATO_ID);\n  end if;\n  if :new.APP_USER is not null\n     and UPDATING then\n    VB_APEX := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TAB_UPD(:new.APP_USER,\n                                                          :new.UPDATED,\n                                                          :new.UPDATEDBY);\n    :new.APP_USER := null;\n  end if;\n\n  if INSERTING then\n  \n    open CTITULO;\n    fetch CTITULO\n      into RTITULO;\n    if CTITULO%notfound\n       or NVL(RTITULO.QTDE, 0) = 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Contrato não existente ou todas as parcelas liquidadas');\n    end if;\n    :new.BEG_PESSOA_ID      := RTITULO.BEG_PESSOA_ID;\n    :new.VL_CONTRATO        := RTITULO.VL_CONTRATO;\n    :new.VL_CONTRATO_ABERTO := RTITULO.VL_CONTRATO_ABERTO;\n    close CTITULO;\n    :new.DIE_STATUS := 1;\n  else\n    if :new.DT_FINAL is not null then\n      if :new.DT_FINAL < :new.DT_INICIAL then\n        RAISE_APPLICATION_ERROR(-20002,\n                                'Data final não pode ser inferior a data inicial');\n      end if;\n      :new.DIE_STATUS := 2;\n    end if;\n  end if;\n\n  -- AOK -- 21/07/2008 - Consistir observacao\n  if :new.OBSERVACAO is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Observação para a restrição do contrato obrigatória!!');\n  end if;\n  --\nend DIE_TRG_BIU_COB_RESTR_CONTRATO;\n"}`;
    
    }
}
