
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CARGA_DIARIO_FOR
    {
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CODFIL_LANCTO_ORIGINAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CONFERIDO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do diario cliente e fornecedor
        /// </summary>
        public int DIE_CARGA_DIARIO_FOR_ID { get; set; }
            [Required]
        /// <summary>
        /// Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// ativo sim ou nao
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
    [StringLength(1)]
        /// <summary>
        /// Tipo do diario - (F)ornecedor
        /// </summary>
        public string TP_DIARIO { get; set; }
            [Required]
        /// <summary>
        /// Data de lancamento
        /// </summary>
        public string DT_LANCAMENTO { get; set; }
        
        /// <summary>
        /// Nro lancamento
        /// </summary>
        public int NRO_LANCAMENTO { get; set; }
        
        /// <summary>
        /// Id do parceiro comercial - cliente / fornec
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// Conta de lancamento
        /// </summary>
        public int CONTRAPARTIDA { get; set; }
            [Required]
        /// <summary>
        /// Valor do lancamento
        /// </summary>
        public int VL_LANCAMENTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica debito ou credito
        /// </summary>
        public string IND_DEB_CRE { get; set; }
            [Required]
    [StringLength(200)]
        /// <summary>
        /// Historico do lancamento
        /// </summary>
        public string HISTORICO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// codigo da filial
        /// </summary>
        public string CODFIL { get; set; }
            [StringLength(14)]
        /// <summary>
        /// codigo do cliente ou fornecedor conforme o tipo do diario
        /// </summary>
        public string CODIGO { get; set; }
        
        /// <summary>
        /// mes do lancamento
        /// </summary>
        public int MES_LANCTO { get; set; }
        
        /// <summary>
        /// Ano do lancamento
        /// </summary>
        public int ANO_LANCTO { get; set; }
        
        /// <summary>
        /// Valor do lancamento a credito
        /// </summary>
        public int VL_LANCTO_CRE { get; set; }
        
        /// <summary>
        /// Valod do lancamento a debito
        /// </summary>
        public int VL_LANCTO_DEB { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_CARGA_DIARIO_FOR { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  cursor CFIL is\n    select LPAD(to_number(value), 2, 0) COD_FIL\n      from BEG_DADO_FILIAL O\n     where O.AD_ORG_ID = :new.AD_ORG_ID;\n  RFIL CFIL%rowtype;\n  --\n  cursor CFOR(PCODIGO varchar2) is\n    select * from DIE_FORNEC F where F.CODIGO = PCODIGO;\n  RFOR CFOR%rowtype;\n  --\n /* cursor CCTA(PCONTA DIE_CARGA_DIARIO.CONTRAPARTIDA%type) is\n    select distinct X.CONTRAPARTIDA\n      from DIE_CARGA_DIARIO_FOR X\n     where X.CONTRAPARTIDA = PCONTA;\n  RCTA CCTA%rowtype;*/\nbegin\n  if not DELETING then\n    if NVL(:new.CODIGO, '^') = '^' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Faltou informar o codigo do cliente ou fornececedor - confome diario!');\n    end if;\n    -- Inicializa variavel do codigo da filial (ad_org)\n    open CFIL;\n    fetch CFIL\n      into RFIL;\n    if CFIL%notfound then\n      RFIL.COD_FIL := null;\n    end if;\n    close CFIL;\n    -- Valida codigo do cliente ou fornecedor\n    :new.CODFIL := RFIL.COD_FIL;\n    open CFOR(:new.CODIGO);\n    fetch CFOR\n      into RFOR;\n   /* if CFOR%notfound then\n      RAISE_APPLICATION_ERROR(-20003,\n                              'Não existe este codigo como Fornecedor (dbf)!');\n    end if;*/\n    -- Inicializa variaveis\n    :new.ANO_LANCTO := TO_CHAR(:new.DT_LANCAMENTO, 'rrrr');\n    :new.MES_LANCTO := TO_CHAR(:new.DT_LANCAMENTO, 'mm');\n    if :new.IND_DEB_CRE = 'C' then\n      :new.VL_LANCTO_CRE := :new.VL_LANCAMENTO;\n      :new.VL_LANCTO_DEB := 0;\n    else\n      :new.VL_LANCTO_DEB := :new.VL_LANCAMENTO;\n      :new.VL_LANCTO_CRE := 0;\n    end if;\n\n    if INSERTING then\n      -- AOK - 24/04/2009\n      --\n      if :new.DT_LANCAMENTO not between TO_DATE('01/01/2023', 'dd/mm/rrrr') and\n         TO_DATE('31/12/2023', 'dd/mm/rrrr') then\n        RAISE_APPLICATION_ERROR(-20005,\n                                'Apenas permitido digitacao para o periodo de 2023!');\n      end if;\n     /* open CCTA(:new.CONTRAPARTIDA);\n      fetch CCTA\n        into RCTA;\n      if CCTA%notfound then\n        RAISE_APPLICATION_ERROR(-20004, 'Conta contabil não existe!');\n      end if;\n      close CCTA;*/\n      --\n      select max(T.NRO_LANCAMENTO) + 1\n        into :new.NRO_LANCAMENTO\n        from DIE_CARGA_DIARIO T\n       where T.AD_ORG_ID = :new.AD_ORG_ID;\n      --\n      insert into DIE_CARGA_DIARIO_FOR_LOG\n        (DIE_CARGA_DIARIO_FOR_LOG_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         TP_DIARIO,\n         DT_LANCAMENTO,\n         NRO_LANCAMENTO,\n         BEG_PESSOA_ID,\n         CONTRAPARTIDA,\n         VL_LANCTO_ANT,\n         VL_LANCTO_ATUAL,\n         IND_DEB_CRE_ANT,\n         IND_DEB_CRE_ATUAL,\n         HISTORICO,\n         CODFIL,\n         CODIGO,\n         MES_LANCTO,\n         ANO_LANCTO,\n         TP_REGISTRO,\n         DIE_CARGA_DIARIO_FOR_ID)\n      values\n        (BEG_FNC_AD_SEQUENCE('DIE_CARGA_DIARIO_FOR_LOG'),\n         :new.AD_CLIENT_ID,\n         :new.AD_ORG_ID,\n         :new.ISACTIVE,\n         :new.CREATED,\n         :new.CREATEDBY,\n         :new.UPDATED,\n         :new.UPDATEDBY,\n         :new.TP_DIARIO,\n         :new.DT_LANCAMENTO,\n         :new.NRO_LANCAMENTO,\n         :new.BEG_PESSOA_ID,\n         :new.CONTRAPARTIDA,\n         null, --vl_LANCTO_ANT,\n         :new.VL_LANCAMENTO, --VL_LANCTO_ATUAL,\n         null, --ind_deb_cre_ant\n         :new.IND_DEB_CRE, -- ind_deb_cre_atual\n         :new.HISTORICO,\n         :new.CODFIL,\n         :new.CODIGO,\n         :new.MES_LANCTO,\n         :new.ANO_LANCTO,\n         'I',\n         :new.DIE_CARGA_DIARIO_FOR_ID);\n    end if;\n\n    if UPDATING then\n      insert into DIE_CARGA_DIARIO_FOR_LOG\n        (DIE_CARGA_DIARIO_FOR_LOG_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         TP_DIARIO,\n         DT_LANCAMENTO,\n         NRO_LANCAMENTO,\n         BEG_PESSOA_ID,\n         CONTRAPARTIDA,\n         VL_LANCTO_ANT,\n         VL_LANCTO_ATUAL,\n         IND_DEB_CRE_ANT,\n         IND_DEB_CRE_ATUAL,\n         HISTORICO,\n         CODFIL,\n         CODIGO,\n         MES_LANCTO,\n         ANO_LANCTO,\n         TP_REGISTRO,\n         DIE_CARGA_DIARIO_FOR_ID)\n      values\n        (BEG_FNC_AD_SEQUENCE('DIE_CARGA_DIARIO_FOR_LOG'),\n         :new.AD_CLIENT_ID,\n         :new.AD_ORG_ID,\n         :new.ISACTIVE,\n         :new.CREATED,\n         :new.CREATEDBY,\n         :new.UPDATED,\n         :new.UPDATEDBY,\n         :new.TP_DIARIO,\n         :new.DT_LANCAMENTO,\n         :new.NRO_LANCAMENTO,\n         :new.BEG_PESSOA_ID,\n         :new.CONTRAPARTIDA,\n         :old.VL_LANCAMENTO, --vl_LANCTO_ANT,\n         :new.VL_LANCAMENTO, --VL_LANCTO_ATUAL,\n         :old.IND_DEB_CRE, --ind_deb_cre_ant\n         :new.IND_DEB_CRE, -- ind_deb_cre_atual\n         :new.HISTORICO,\n         :new.CODFIL,\n         :new.CODIGO,\n         :new.MES_LANCTO,\n         :new.ANO_LANCTO,\n         'A',\n         :new.DIE_CARGA_DIARIO_FOR_ID);\n    end if;\n  else\n    insert into DIE_CARGA_DIARIO_FOR_LOG\n      (DIE_CARGA_DIARIO_FOR_LOG_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       TP_DIARIO,\n       DT_LANCAMENTO,\n       NRO_LANCAMENTO,\n       BEG_PESSOA_ID,\n       CONTRAPARTIDA,\n       VL_LANCTO_ANT,\n       VL_LANCTO_ATUAL,\n       IND_DEB_CRE_ANT,\n       IND_DEB_CRE_ATUAL,\n       HISTORICO,\n       CODFIL,\n       CODIGO,\n       MES_LANCTO,\n       ANO_LANCTO,\n       TP_REGISTRO,\n       DIE_CARGA_DIARIO_FOR_ID)\n    values\n      (BEG_FNC_AD_SEQUENCE('DIE_CARGA_DIARIO_FOR_LOG'),\n       :old.AD_CLIENT_ID,\n       :old.AD_ORG_ID,\n       :old.ISACTIVE,\n       :old.CREATED,\n       :old.CREATEDBY,\n       :old.UPDATED,\n       :old.UPDATEDBY,\n       :old.TP_DIARIO,\n       :old.DT_LANCAMENTO,\n       :old.NRO_LANCAMENTO,\n       :old.BEG_PESSOA_ID,\n       :old.CONTRAPARTIDA,\n       null, --vl_LANCTO_ANT,\n       :old.VL_LANCAMENTO, --VL_LANCTO_ATUAL,\n       null, --ind_deb_cre_ant\n       :old.IND_DEB_CRE, -- ind_deb_cre_atual\n       :old.HISTORICO,\n       :old.CODFIL,\n       :old.CODIGO,\n       :old.MES_LANCTO,\n       :old.ANO_LANCTO,\n       'D',\n       :old.DIE_CARGA_DIARIO_FOR_ID);\n  end if;\nend DIE_TRG_BIU_CARGA_DIARIO_FOR;\n"}`;
    
    }
}
