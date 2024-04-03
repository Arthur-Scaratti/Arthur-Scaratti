
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_ABASTECIMENTO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_ABASTECIMENTO_ID { get; set; }
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
        public string DT_ABAST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NOTA_FISCAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ODOMETRO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QUANTIDADE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_UNITARIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABAST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRZ_ABAST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_VEICULO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_TP_COBRANCA_ID { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_POSTO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Serie da nota fiscal.
        /// </summary>
        public string SERIE_NF { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_PAGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MEDIA_CONSUMO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int KM_PERCORRIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_VIAGEM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_VW_MOTORISTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_ORDEM_SERVICO_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_ORDEM_SERVICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string GERA_OS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ABERTURA_OS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ORDEM_SERVICO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string TP_ABASTECIMENTO { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FRO_ABASTECIMENTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  WVLR_ABAST BEG_FRO_ABASTECIMENTO.VLR_ABAST%type;\n  WVLR_UNIT  BEG_FRO_ABASTECIMENTO.VLR_UNITARIO%type;\n  WQTDE      BEG_FRO_ABASTECIMENTO.QUANTIDADE%type;\n  WDT_SAIDA  BEG_FRO_VIAGEM.DT_SAIDA%type;\n  --\n  cursor C_ABAST is\n    select 1\n      from BEG_FRO_ABASTECIMENTO T\n     where T.NOTA_FISCAL = :new.NOTA_FISCAL\n       and NVL(T.SERIE_NF, '^') = NVL(:new.SERIE_NF, '^')\n       and NVL(T.BEG_PESSOA_ID, 0) = NVL(:new.BEG_PESSOA_ID, 0)\n       and T.BEG_FRO_VEICULO_ID = :new.BEG_FRO_VEICULO_ID\n       and T.BEG_FRO_VW_MOTORISTA_ID = :new.BEG_FRO_VW_MOTORISTA_ID;\n  R_ABAST C_ABAST%rowtype;\n\n  -- AOK -- 07/11/2008\n/*  cursor CVEIC is\n    select *\n      from BEG_FRO_VEICULO V\n     where V.BEG_FRO_VEICULO_ID = :new.BEG_FRO_VEICULO_ID;\n  RVEIC CVEIC%rowtype;\n*/  --\nbegin\n\n  -- Consiste a existencia obrigatoria do odometro\n  if NVL(:new.ODOMETRO, 0) = 0 then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Deve ser informado o valor do odômetro na data do abastecimento!');\n  end if;\n\n  if INSERTING then\n    -- AOK -- 04/02/2008\n    open C_ABAST;\n    fetch C_ABAST\n      into R_ABAST;\n    if C_ABAST%found then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Esta Nota Fiscal já esta cadastrada - verifique!');\n    \n    end if;\n    close C_ABAST;\n  \n    if :new.TP_ABASTECIMENTO = 'N' then\n      :new.GERA_OS := 'N';\n    else\n      :new.GERA_OS := 'Y';\n    end if;\n  end if;\n\n  -- AOK -- 30/01/2008 - quando desativar o reg. e possuir pgtos, desativar tbem.\n  if UPDATING then\n    if :new.ISACTIVE <> :old.ISACTIVE then\n      update BEG_FRO_ABASTECIMENTO_PAGO X\n         set X.ISACTIVE = :new.ISACTIVE\n       where X.BEG_FRO_ABASTECIMENTO_ID = :new.BEG_FRO_ABASTECIMENTO_ID;\n    end if;\n  end if;\n\n  --\n  -- Consiste a data de abastecimento\n  --  AOK -- 14/08/2007\n  if :new.DT_ABAST is not null then\n    if TO_NUMBER(TO_CHAR(:new.DT_ABAST, 'rrrr')) between\n       TO_NUMBER(TO_CHAR(sysdate, 'rrrr')) - 1 and\n       TO_NUMBER(TO_CHAR(sysdate, 'rrrr')) then\n      null;\n    else\n      RAISE_APPLICATION_ERROR(-20003,\n                              'Favor verificar a data de abastecimento informada!');\n    end if;\n  end if;\n  --\n  -- Consiste da nota fiscal \n  -- AOK -- 14/08/2007\n  if NVL(:new.NOTA_FISCAL, 0) = 0 then\n    RAISE_APPLICATION_ERROR(-20004, 'Nota fiscal deve ser informada!');\n  end if;\n\n  --\n  -- Consiste a existencia obrigatoria da descricao do posto ou parceiro comercial\n  --\n  if :new.DESC_POSTO is null\n     and :new.BEG_PESSOA_ID is null then\n    RAISE_APPLICATION_ERROR(-20005,\n                            'Nome do Posto ou Parceiro Comercial deve ser informado!');\n  end if;\n  --\n  -- Consiste data de abastecimento qdo pertencente a uma viagem\n  --\n  if :new.BEG_FRO_VIAGEM_ID is not null then\n    WDT_SAIDA := null;\n    begin\n      select DT_SAIDA\n        into WDT_SAIDA\n        from BEG_FRO_VIAGEM\n       where BEG_FRO_VIAGEM_ID = :new.BEG_FRO_VIAGEM_ID;\n    end;\n    if :new.DT_ABAST < WDT_SAIDA then\n      RAISE_APPLICATION_ERROR(-20006,\n                              'A data do abastecimento e anterior a saida da viagem!');\n    end if;\n  end if;\n  --\n  -- Atualiza a descricao do posto em caixa alta\n  --\n  if :new.DESC_POSTO is not null then\n    :new.DESC_POSTO := UPPER(:new.DESC_POSTO);\n  end if;\n  --\n  -- Valida a quantidade, valor unitario e valor abastecimento\n  --\n  :new.VLR_UNITARIO := 0;\n  if NVL(:new.QUANTIDADE, 0) > 0\n     and NVL(:new.VLR_UNITARIO, 0) > 0 then\n    WVLR_ABAST := ROUND((:new.QUANTIDADE * :new.VLR_UNITARIO), 2);\n    if NVL(:new.VLR_ABAST, 0) = 0 then\n      :new.VLR_ABAST := WVLR_ABAST;\n    elsif :new.VLR_ABAST != WVLR_ABAST then\n      RAISE_APPLICATION_ERROR(-20007,\n                              'O valor do abastecimento n?o esta correto!');\n    end if;\n  elsif NVL(:new.VLR_UNITARIO, 0) > 0\n        and NVL(:new.VLR_ABAST, 0) > 0 then\n    WQTDE := ROUND((:new.VLR_ABAST / :new.VLR_UNITARIO), 2);\n    if NVL(:new.QUANTIDADE, 0) = 0 then\n      :new.QUANTIDADE := WQTDE;\n    elsif :new.QUANTIDADE != WQTDE then\n      RAISE_APPLICATION_ERROR(-20008,\n                              'A quantidade de combustivel n?o esta correta!');\n    end if;\n  elsif NVL(:new.VLR_ABAST, 0) > 0\n        and NVL(:new.QUANTIDADE, 0) > 0 then\n    WVLR_UNIT := ROUND((:new.VLR_ABAST / :new.QUANTIDADE), 2);\n    if NVL(:new.VLR_UNITARIO, 0) = 0 then\n      :new.VLR_UNITARIO := WVLR_UNIT;\n    elsif :new.VLR_UNITARIO != WVLR_UNIT then\n      RAISE_APPLICATION_ERROR(-20009,\n                              'O valor unitario informado n?o esta correto!');\n    end if;\n    --else\n    --  RAISE_APPLICATION_ERROR(-20005,\n    --                          'No minimo dois dos valores ref. a quantidade, valor unitario e valor abastecimento devem ser informado!');\n  end if;\n\n  -- AOK -- 07/11/2008 - le veiculo para consistencia do odometro\n/*  open CVEIC;\n  fetch CVEIC\n    into RVEIC;\n  close CVEIC;\n  if NVL(RVEIC.ODOMETRO, 0) < NVL(:new.ODOMETRO, 0) then\n    RAISE_APPLICATION_ERROR(-20010,\n                            'Odometro informado menor que do veiculo... verifique!');\n  end if;\n*/  --\n  -- Altera o odometro do veiculo quando este for menor que a do veiculo\n  -- AOK -- 07/11/2008 - Desativado a alteracao - \n  -- AOK -- 14/11/2008 - Reativado\n    update BEG_FRO_VEICULO V\n       set V.ODOMETRO = :new.ODOMETRO\n     where V.BEG_FRO_VEICULO_ID = :new.BEG_FRO_VEICULO_ID\n       and V.ODOMETRO < NVL(:new.ODOMETRO, 0);\n   --\n  -- FIM\n  --\n\n  --Gerando Ordem de Servico somente no insert\n\n  if INSERTING then\n    if :new.GERA_OS = 'Y' then\n      declare\n        V_BEG_FRO_ORDEM_SERVICO_ID binary_integer;\n      begin\n      \n        if :new.TP_ORDEM_SERVICO is null then\n          RAISE_APPLICATION_ERROR(-20011,\n                                  'Tipo de OS deve ser informada !');\n        end if;\n      \n        V_BEG_FRO_ORDEM_SERVICO_ID := BEG_FNC_AD_SEQUENCE('BEG_FRO_ORDEM_SERVICO');\n      \n        BEG_PCK_FROTA.V_GERANDO_OS := true;\n      \n        insert into BEG_FRO_ORDEM_SERVICO\n          (BEG_FRO_ORDEM_SERVICO_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           value,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           DT_ABERTURA_OS,\n           VLR_MATERIAL,\n           VLR_OPERACAO,\n           TP_ORDEM_SERVICO,\n           BEG_FRO_VEICULO_ID,\n           BEG_PESSOA_ID,\n           BEG_FRO_VW_MOTORISTA_ID,\n           IND_PAGTO,\n           ODOMETRO,\n           NOTA_FISCAL)\n        values\n          (V_BEG_FRO_ORDEM_SERVICO_ID,\n           :new.AD_CLIENT_ID,\n           :new.AD_ORG_ID,\n           'Y',\n           V_BEG_FRO_ORDEM_SERVICO_ID,\n           :new.CREATED,\n           :new.CREATEDBY,\n           :new.UPDATED,\n           :new.UPDATEDBY,\n           :new.DT_ABAST,\n           0,\n           0,\n           :new.TP_ORDEM_SERVICO,\n           :new.BEG_FRO_VEICULO_ID,\n           :new.BEG_PESSOA_ID,\n           :new.BEG_FRO_VW_MOTORISTA_ID,\n           :new.IND_PAGTO,\n           :new.ODOMETRO,\n           :new.NOTA_FISCAL);\n      \n        BEG_PCK_FROTA.V_GERANDO_OS := false;\n      \n        :new.BEG_FRO_ORDEM_SERVICO_ID := V_BEG_FRO_ORDEM_SERVICO_ID;\n      \n      end;\n    \n    else\n      :new.GERA_OS                  := 'N';\n      :new.BEG_FRO_ORDEM_SERVICO_ID := null;\n    end if;\n  end if;\n\n  if :new.BEG_FRO_ORDEM_SERVICO_ID is null then\n    :new.VLR_ORDEM_SERVICO := 0;\n  end if;\n\n  if :new.BEG_FRO_ORDEM_SERVICO_ID is not null\n     and NVL(:new.VLR_ORDEM_SERVICO, 0) = 0 then\n    select VLR_TOTAL\n      into :new.VLR_ORDEM_SERVICO\n      from BEG_FRO_ORDEM_SERVICO\n     where BEG_FRO_ORDEM_SERVICO_ID = :new.BEG_FRO_ORDEM_SERVICO_ID;\n  end if;\n\n  :new.VLR_TOTAL := :new.VLR_ABAST + NVL(:new.VLR_ORDEM_SERVICO, 0);\n\nend TRG_BIU_BEG_FRO_ABASTECIMENTO;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_AIUD_BEG_FRO_ABASTECIMENTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\nbegin\n  --\n  -- Atualiza valor de despesa e o valor de acerto em viagem quando informada\n  --\n  if :new.BEG_FRO_VIAGEM_ID is not null then\n    if INSERTING then\n      update BEG_FRO_VIAGEM V\n         set V.VLR_DESPESAS = V.VLR_DESPESAS + :new.VLR_ABAST,\n             V.VLR_ACERTO   = V.VLR_ANTECIPADO - :new.VLR_ABAST\n       where V.BEG_FRO_VIAGEM_ID = :new.BEG_FRO_VIAGEM_ID;\n    end if;\n    --\n    if UPDATING then\n      update BEG_FRO_VIAGEM V\n         set V.VLR_DESPESAS = V.VLR_DESPESAS - :old.VLR_ABAST +\n                              :new.VLR_ABAST,\n             V.VLR_ACERTO   = V.VLR_ACERTO + :old.VLR_ABAST - :new.VLR_ABAST\n       where V.BEG_FRO_VIAGEM_ID = :new.BEG_FRO_VIAGEM_ID;\n    end if;\n  end if;\n  --\n  if DELETING then\n  \n    -- AOK -- 30/01/2008\n    -- Consiste se o abastecimento já foi pago - naum permitir a delecao\n    if :old.IND_PAGTO = 'Y' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Abastecimento pago ou em processo - não pode ser eliminado!');\n    end if;\n  \n    if :old.BEG_FRO_VIAGEM_ID is not null then\n      update BEG_FRO_VIAGEM V\n         set V.VLR_DESPESAS = V.VLR_DESPESAS - :old.VLR_ABAST,\n             V.VLR_ACERTO   = V.VLR_ACERTO + :old.VLR_ABAST\n       where V.BEG_FRO_VIAGEM_ID = :old.BEG_FRO_VIAGEM_ID;\n    end if;\n  end if;\n  --\n  -- FIM\n  --\nend TRG_AIUD_BEG_FRO_ABASTECIMENTO;\n"}`;
    
    }
}
