
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PCE_PAGAMENTO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PCE_PAGAMENTO_ID { get; set; }
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
        
        /// <summary>
        /// Data da ultima remessa
        /// </summary>
        public string DT_ULTIMA_REMESSA { get; set; }
        
        /// <summary>
        /// Data do ultimo retorno
        /// </summary>
        public string DT_ULTIMO_RETORNO { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// Diretorio de remessa
        /// </summary>
        public string DIRETORIO_REMESSA { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// Diretorio de remessa backup
        /// </summary>
        public string DIRETORIO_REMESSA_BACKUP { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// Diretorio de retorno
        /// </summary>
        public string DIRETORIO_RETORNO { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// Diretorio de retorno backup
        /// </summary>
        public string DIRETORIO_RETORNO_BACKUP { get; set; }
            [Required]
        /// <summary>
        /// Numero da ultima remessa
        /// </summary>
        public int NRO_ULTIMA_REMESSA { get; set; }
            [Required]
        /// <summary>
        /// Numero do ultimo retorno
        /// </summary>
        public int NRO_ULTIMO_RETORNO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica montagem do arquivo
        /// </summary>
        public string IND_MONTA_ARQUIVO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Prefixo do arquivo de remessa
        /// </summary>
        public string PREFIXO_ARQUIVO_REMESSA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Prefixo do arquivo de retorno
        /// </summary>
        public string PREFIXO_ARQUIVO_RETORNO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Extens?o do arquivo de remessa
        /// </summary>
        public string EXTENSAO_ARQUIVO_REMESSA { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Extens?o do arquivo de retorno
        /// </summary>
        public string EXTENSAO_ARQUIVO_RETORNO { get; set; }
            [Required]
        /// <summary>
        /// id do banco
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// Opcao para data de remessa
        /// </summary>
        public string OPC_DT_REMESSA { get; set; }
        
        /// <summary>
        /// Opcao para data de retorno
        /// </summary>
        public string OPC_DT_RETORNO { get; set; }
        
        /// <summary>
        /// Tipo de sequencia da remessa
        /// </summary>
        public string TP_SEQ_REMESSA { get; set; }
        
        /// <summary>
        /// Tipo da sequencia do retorno
        /// </summary>
        public string TP_SEQ_RETORNO { get; set; }
        
        /// <summary>
        /// Data da remessa anterior
        /// </summary>
        public string DT_REMESSA_ANTERIOR { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AIUD_PCE_PAGAMENTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\nbegin\n  if INSERTING then\n    if :new.AD_ORG_ID = 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Deve ser obrigatoriamente informado uma Filial!');\n    end if;\n    update BEG_BANCO\n       set IND_PAG_ESCRITURAL = 'Y'\n     where BEG_BANCO_ID = :new.BEG_BANCO_ID;\n  end if;\n  --\n  if DELETING then\n    update BEG_BANCO\n       set IND_PAG_ESCRITURAL = 'N'\n     where BEG_BANCO_ID = :old.BEG_BANCO_ID;\n  end if;\n  --\n  if UPDATING then\n    if :new.ISACTIVE != :old.ISACTIVE then\n      update BEG_BANCO\n         set IND_PAG_ESCRITURAL = :new.ISACTIVE\n       where BEG_BANCO_ID = :new.BEG_BANCO_ID;\n    end if;\n  end if;\nend BEG_TRG_AIUD_PCE_PAGAMENTO;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_PCE_PAGAMENTO_DIR { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  pragma autonomous_transaction;\n  --\n  V_SQL       varchar(4000);\n  V_DIRETORIO varchar(1000) := null; --'/opt/oracle/utl_file_dir/bancos/'; --Pegar dos parametros\n  V_SISTEMA   varchar2(100) := null;\n  V_REMESSA   varchar2(20) := null;\n  V_RETORNO   varchar2(20) := null;\n  V_REMESSA2  varchar2(20) := null;\n  V_RETORNO2  varchar2(20) := null;\n  V_FIL       varchar2(10);\n  --\n  cursor C_BANCO is\n    select A.value\n      from BEG_BANCO A\n     where A.BEG_BANCO_ID = NVL(:new.BEG_BANCO_ID, :old.BEG_BANCO_ID);\n  V_BANCO varchar(10);\n  --\n  cursor C_FILIAL is\n    select value COD\n      from AD_ORG\n     where AD_CLIENT_ID = :new.AD_CLIENT_ID\n       and AD_ORG_ID = :new.AD_ORG_ID;\n  --\n  cursor C_DIRETORIOS(P_VALUE varchar) is\n    select B.DIRECTORY_NAME,\n           B.DIRECTORY_PATH\n      from SYS.DBA_DIRECTORIES B\n     where B.DIRECTORY_NAME like 'PE' || '%' || P_VALUE || V_FIL;\nbegin\n  /*------------------------------------------\n    Buscando parametros o sistemas\n  ------------------------------------------*/\n  V_DIRETORIO := BEG_FNC_RETORNA_PARAM_GERAL('Geral',\n                                             null,\n                                             'DIR_PAGAMENTO_E');\n  --\n  if V_SISTEMA = -1 then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Parametro Sistema: DIR_PAGAMENTO_E. Verificar seu cadastramento!');\n  end if;\n  --\n  V_SISTEMA := UPPER(BEG_FNC_RETORNA_PARAM_GERAL('Geral',\n                                                 null,\n                                                 'SISTEMA_OPERACIONAL'));\n  -- \n  if V_SISTEMA not in ('UNIX', 'WINDOWS') then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Verificar Parametro Sistema: SISTEMA_OPERACIONAL. Liberado apenas para UNIX ou WINDOWS....');\n  end if;\n  /*----------------------------------------------\n   Busca o codigo do banco\n  ------------------------------------------------*/\n  open C_BANCO;\n  fetch C_BANCO\n    into V_BANCO;\n  close C_BANCO;\n\n  /*----------------------------------------------\n  Busca o codigo da filial\n  -----------------------------------------------*/\n  open C_FILIAL;\n  fetch C_FILIAL\n    into V_FIL;\n  if C_FILIAL%notfound then\n    V_FIL := null;\n  end if;\n  if V_FIL = '0' then\n    V_FIL := null;\n  end if;\n  close C_FILIAL;\n\n  /*----------------------------------------------\n   Criando o diretorio na tabela dba_diretories\n  ------------------------------------------------*/\n  for R in C_DIRETORIOS(V_BANCO)\n  loop\n    begin\n      V_SQL := 'DROP DIRECTORY ' || R.DIRECTORY_NAME;\n      execute immediate V_SQL;\n    exception\n      when others then\n        null;\n    end;\n  end loop;\n\n  ------------------------------------\n  -- Criacao no sistema operacional --\n  ------------------------------------\n  if V_SISTEMA = 'UNIX' then\n  \n    BEG_PRC_HOST('/bin/mkdir ' || V_DIRETORIO || V_BANCO || V_FIL || '/');\n    BEG_PRC_HOST('/bin/mkdir ' || V_DIRETORIO || V_BANCO || V_FIL ||\n                 '/remessas/');\n    BEG_PRC_HOST('/bin/mkdir ' || V_DIRETORIO || V_BANCO || V_FIL ||\n                 '/retornos/');\n    BEG_PRC_HOST('/bin/mkdir ' || V_DIRETORIO || V_BANCO || V_FIL ||\n                 '/remessas/bkp/');\n    BEG_PRC_HOST('/bin/mkdir ' || V_DIRETORIO || V_BANCO || V_FIL ||\n                 '/retornos/bkp/');\n    V_REMESSA  := '/remessas/';\n    V_RETORNO  := '/retornos/';\n    V_REMESSA2 := '/remessas/bkp/';\n    V_RETORNO2 := '/retornos/bkp/';\n  else\n    BEG_PRC_HOST('mkdir ' || V_DIRETORIO || V_BANCO || V_FIL || '\\');\n    BEG_PRC_HOST('mkdir ' || V_DIRETORIO || V_BANCO || V_FIL ||\n                 '\\remessas\\');\n    BEG_PRC_HOST('mkdir ' || V_DIRETORIO || V_BANCO || V_FIL ||\n                 '\\retornos\\');\n    BEG_PRC_HOST('mkdir ' || V_DIRETORIO || V_BANCO || V_FIL ||\n                 '\\remessas/bkp\\');\n    BEG_PRC_HOST('mkdir ' || V_DIRETORIO || V_BANCO || V_FIL ||\n                 '\\retornos\\bkp\\');\n    V_REMESSA  := '\\remessas\\';\n    V_RETORNO  := '\\retornos\\';\n    V_REMESSA2 := '\\remessas\\bkp\\';\n    V_RETORNO2 := '\\retornos\\bkp\\';\n  end if;\n  --\n  -- Criac?o na tabela dba_diretories\n  --\n  begin\n    V_SQL := 'CREATE DIRECTORY PE_REM_' || V_BANCO || V_FIL || ' AS ''' ||\n             V_DIRETORIO || V_BANCO || V_FIL || V_REMESSA || ''' ';\n    -- '/remessas/'' ';\n    execute immediate V_SQL;\n  exception\n    when others then\n      null;\n  end;\n  --\n  begin\n    V_SQL := 'CREATE DIRECTORY PE_RET_' || V_BANCO || V_FIL || ' AS ''' ||\n             V_DIRETORIO || V_BANCO || V_FIL || V_RETORNO || ''' ';\n    --'/retornos/'' ';\n    execute immediate V_SQL;\n  exception\n    when others then\n      null;\n  end;\n  --\n  :new.NRO_ULTIMA_REMESSA := NVL(:new.NRO_ULTIMA_REMESSA, 0);\n  :new.NRO_ULTIMO_RETORNO := NVL(:new.NRO_ULTIMO_RETORNO, 0);\n  --\n  :new.DIRETORIO_REMESSA        := V_DIRETORIO || V_BANCO || V_FIL ||\n                                   V_REMESSA;\n  :new.DIRETORIO_REMESSA_BACKUP := V_DIRETORIO || V_BANCO || V_FIL ||\n                                   V_REMESSA2;\n  :new.DIRETORIO_RETORNO        := V_DIRETORIO || V_BANCO || V_FIL ||\n                                   V_RETORNO;\n  :new.DIRETORIO_RETORNO_BACKUP := V_DIRETORIO || V_BANCO || V_FIL ||\n                                   V_RETORNO2;\n  --\nend BEG_TRG_BIU_PCE_PAGAMENTO_DIR;\n"}`;
    
    }
}
