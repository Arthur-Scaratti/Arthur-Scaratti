
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PESSOA
    {
        
        /// <summary>
        /// DIEMENTZ - De onde vem a informaçao - Postgre/null (oracle)
        /// </summary>
        public string ORIGEM { get; set; }
        
        /// <summary>
        /// Estado (UF) referente ao nascimento carteira de identidade (RG)
        /// </summary>
        public int BEG_VW_UF_NASCIMENTO_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Contem o mesmo valor do campo referente ao CPFCNPJ
        /// </summary>
        public string VALUE { get; set; }
            [StringLength(60)]
        /// <summary>
        /// Nome do parceiro Comercial
        /// </summary>
        public string NOME { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SEPARADOR { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
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
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
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
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
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
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string INSCRICAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TPMORADIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ALUGUEL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string FIADOR { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string APROVADOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_NASCIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTSITUACAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTCIVIL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SEXO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NATURALIDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRDEPENDE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CTPS { get; set; }
            [StringLength(17)]
        /// <summary>
        /// 
        /// </summary>
        public string TITELEITOR { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string EMPRESA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTADMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OUTRENDA { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string PAI { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string MAE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string RG { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string CONJUGE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTNASCCONJ { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string EMPRESACONJ { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CARGOCONJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTADMISSAOCONJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RENDACONJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OUTRENDACONJ { get; set; }
        
        /// <summary>
        /// Id da filial que efetuou a ultima alteracao - Diementz
        /// </summary>
        public int LOCAL_ULT_ATUALIZACAO { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF_CONJUGE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CPF_RES_PAGAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CPF_RESP_COMPRAS { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Atributo nao esta sendo utilizado - ver EMAIL
        /// </summary>
        public string E_MAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LIMITE_DE_CREDITO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string RENDA_COMPROVADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RENDA_FAMILIAR { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string RESP_COMPRAS { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string RESP_PAGAMENTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CLIENTE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string FORNECEDOR { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TRANSPORTADORA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string COBRADOR { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string VENDEDOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TP_PESSOA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CBO_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCR_CIDADE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string FUNCIONARIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CONJUGE_AUTORIZADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string MOTORISTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPRADOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CORRETOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string SEGURADORA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TP_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CONSUMIDOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_INSCRITO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string INSCRICAO_MUNICIPAL { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Complemento do endereco
        /// </summary>
        public string COMPLEMENTO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Numero relativo ao endereco
        /// </summary>
        public string NUMERO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Ponto de referencia relativo ao endereco
        /// </summary>
        public string PONTO_REFERENCIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_LOGRADOURO_ID { get; set; }
        
        /// <summary>
        /// Estado (UF) referente ao endereço
        /// </summary>
        public int BEG_VW_UF_ID { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string ORGAO_EMISSOR_RG { get; set; }
        
        /// <summary>
        /// Estado (UF) referente a carteira de identidade (RG)
        /// </summary>
        public int BEG_VW_UF_RG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_RG { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CONFERENTE { get; set; }
            [Required]
        /// <summary>
        /// Este campo não mais esta sendo usado - AOK - 19/12/2006 
        /// </summary>
        public string IND_AVISO_COBRANCA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_RAMO_ATIVIDADE_ID { get; set; }
        
        /// <summary>
        /// Este campo não mais esta sendo usado - AOK - 19/12/2006
        /// </summary>
        public int DIAS_ATRASO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ATIVO_SINTEGRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_SINTEGRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CNAE_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_FANTASIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FUNDACAO { get; set; }
        
        /// <summary>
        /// Dada da ultima compra  - Fornecedor
        /// </summary>
        public string DT_ULT_COMPRA { get; set; }
        
        /// <summary>
        /// Data da ultilma venda - Cliente
        /// </summary>
        public string DT_ULT_VENDA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string SUPERVISOR_VENDAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string SUPERVISOR_TELEVENDAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string GERENTE_VENDAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string TELE_VENDEDOR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_VENDA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PESSOA_COMISSIONADA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string TORPEDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_CONCEITO_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_MENSAGEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_ROTA_ID { get; set; }
            [StringLength(60)]
        /// <summary>
        /// Nome do parceiro Comercial
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string REPRESENTADA { get; set; }
        
        /// <summary>
        /// Quantos anos de residencia   no mesmo endereço  -- AOK - 16/01/2007
        /// </summary>
        public int RESIDANO { get; set; }
        
        /// <summary>
        /// Quantos meses de residencia no mesmo endereço  -- AOK - 16/01/2007
        /// </summary>
        public int RESIDMES { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Outros docs  -- AOK - 16/01/2007
        /// </summary>
        public string OUTROSDOCS { get; set; }
        
        /// <summary>
        /// Indica que é uma empresa Conveniada
        /// </summary>
        public string CONVENIADA { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_BEG_PESSOA_CE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  \n    IF :NEW.TP_PESSOA = 'F' or (:NEW.TP_PESSOA = 'J' and :new.inscricao ='ISENTO') THEN\n       :NEW.IND_CONSUMIDOR := 'Y';       \n    END IF;   \n\n    IF :NEW.TP_PESSOA = 'J' and :new.inscricao <>'ISENTO' THEN\n       :NEW.IND_CONSUMIDOR := 'N';       \n       :new.ind_inscrito   := 'Y';\n    END IF;   \n    \n\n  if inserting then\n    :new.BAIRRO              := fnc_beg_remove_ce(:new.BAIRRO);\n    :new.INSCRICAO           := fnc_beg_remove_ce(:new.INSCRICAO);\n    :new.NATURALIDADE        := fnc_beg_remove_ce(:new.NATURALIDADE);\n    :new.EMPRESA             := fnc_beg_remove_ce(:new.EMPRESA);\n    :new.PAI                 := fnc_beg_remove_ce(:new.PAI);\n    :new.MAE                 := fnc_beg_remove_ce(:new.MAE);\n    :new.CONJUGE             := fnc_beg_remove_ce(:new.CONJUGE);\n    :new.EMPRESACONJ         := fnc_beg_remove_ce(:new.EMPRESACONJ);\n    :new.CARGOCONJ           := fnc_beg_remove_ce(:new.CARGOCONJ);\n    :new.EMAIL               := fnc_beg_remove_ce(:new.EMAIL);\n    :new.DESCR_CIDADE        := fnc_beg_remove_ce(:new.DESCR_CIDADE);\n    :new.INSCRICAO_MUNICIPAL := fnc_beg_remove_ce(:new.INSCRICAO_MUNICIPAL);\n    :new.COMPLEMENTO         := fnc_beg_remove_ce(:new.COMPLEMENTO);\n    :new.PONTO_REFERENCIA    := fnc_beg_remove_ce(:new.PONTO_REFERENCIA);\n    :new.NOME_FANTASIA       := fnc_beg_remove_ce(:new.NOME_FANTASIA);\n    :new.NAME                := fnc_beg_remove_ce(:new.NAME);\n    :new.NOME                := fnc_beg_remove_ce(:new.NOME);\n  end if;\n\n  if updating and\n     (:new.BAIRRO <> :old.bairro or :new.INSCRICAO <> :old.inscricao or\n     :new.NATURALIDADE <> :old.NATURALIDADE or\n     :new.EMPRESA <> :old.empresa or :new.PAI <> :old.pai or\n     :new.MAE <> :old.mae or :new.CONJUGE <> :old.conjuge or\n     :new.EMPRESACONJ <> :old.empresaconj or\n     :new.CARGOCONJ <> :old.cargoconj or :new.EMAIL <> :old.email or\n     :new.DESCR_CIDADE <> :old.descr_cidade or\n     :new.INSCRICAO_MUNICIPAL <> :old.inscricao_municipal or\n     :new.COMPLEMENTO <> :old.complemento or\n     :new.PONTO_REFERENCIA <> :old.ponto_referencia or\n     :new.NOME_FANTASIA <> :old.nome_fantasia or :new.NAME <> :old.name or\n     :new.NOME <> :old.nome) then\n  \n    :new.BAIRRO              := fnc_beg_remove_ce(:new.BAIRRO);\n    :new.INSCRICAO           := fnc_beg_remove_ce(:new.INSCRICAO);\n    :new.NATURALIDADE        := fnc_beg_remove_ce(:new.NATURALIDADE);\n    :new.EMPRESA             := fnc_beg_remove_ce(:new.EMPRESA);\n    :new.PAI                 := fnc_beg_remove_ce(:new.PAI);\n    :new.MAE                 := fnc_beg_remove_ce(:new.MAE);\n    :new.CONJUGE             := fnc_beg_remove_ce(:new.CONJUGE);\n    :new.EMPRESACONJ         := fnc_beg_remove_ce(:new.EMPRESACONJ);\n    :new.CARGOCONJ           := fnc_beg_remove_ce(:new.CARGOCONJ);\n    :new.EMAIL               := fnc_beg_remove_ce(:new.EMAIL);\n    :new.DESCR_CIDADE        := fnc_beg_remove_ce(:new.DESCR_CIDADE);\n    :new.INSCRICAO_MUNICIPAL := fnc_beg_remove_ce(:new.INSCRICAO_MUNICIPAL);\n    :new.COMPLEMENTO         := fnc_beg_remove_ce(:new.COMPLEMENTO);\n    :new.PONTO_REFERENCIA    := fnc_beg_remove_ce(:new.PONTO_REFERENCIA);\n    :new.NOME_FANTASIA       := fnc_beg_remove_ce(:new.NOME_FANTASIA);\n    :new.NAME                := fnc_beg_remove_ce(:new.NAME);\n    :new.NOME                := fnc_beg_remove_ce(:new.NOME);\n  end if;\n\nend DIE_TRG_BIU_BEG_PESSOA_CE;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BU_PESSOA_COBRANCA { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n\n  VN_LIXO  number(1) := 0;\n  VN_IDADE number;\n  VC_ERRO  varchar2(1);\n\n  cursor DIVERGENCIA is\n    select 1\n      from DIE_COB_DIVERGENCIA D\n     where D.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n\n  cursor PARAM_GERAL is\n    select *\n      from BEG_COB_PARAMETRO P\n     where P.AD_CLIENT_ID = :new.AD_CLIENT_ID\n       and P.AD_ORG_ID = 0;\n  RPARAM PARAM_GERAL%rowtype;\n\nbegin\n\n  VC_ERRO  := 'N';\n  VN_IDADE := 0;\n  open DIVERGENCIA;\n  fetch DIVERGENCIA\n    into VN_LIXO;\n  if DIVERGENCIA%found then\n    if NVL(:new.DT_NASCIMENTO, TRUNC(sysdate)) !=\n       NVL(:old.DT_NASCIMENTO, TRUNC(sysdate)) then\n      VN_IDADE := TRUNC((TRUNC(sysdate) - :new.DT_NASCIMENTO) / 365);\n      open PARAM_GERAL;\n      fetch PARAM_GERAL\n        into RPARAM;\n      if PARAM_GERAL%notfound then\n        RPARAM.IDADE_MINIMA := 0;\n        RPARAM.IDADE_MAXIMA := 0;\n      end if;\n      close PARAM_GERAL;\n      if VN_IDADE < RPARAM.IDADE_MINIMA\n         or VN_IDADE > RPARAM.IDADE_MAXIMA then\n        VC_ERRO := 'Y';\n      end if;\n    end if;\n    -- Apenas eliminar a divergencia quando o erro for resolvido\n    if VC_ERRO = 'N' then\n      delete DIE_COB_DIVERGENCIA D\n       where D.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    end if;\n  end if;\n\nend BEG_TRG_BU_PESSOA_COBRANCA;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIU_BEG_PESSOA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  VN_DUMMY integer;\nbegin\n  if INSERTING then\n    if NVL(:new.CPFCNPJ, '^') = '^'\n       and :new.CLIENTE = 'Y' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Cliente não pode ser cadastrado sem CPF ou CNPJ!');\n    end if;\n  end if;\n  if UPDATING\n     and :new.CLIENTE <> :old.CLIENTE then\n    if :new.CLIENTE = 'Y' then\n       if  NVL(:new.CPFCNPJ, '^') = '^' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Cliente não pode ser cadastrado sem CPF ou CNPJ!');\n        end if      ;                        \n    else\n      select count(1)\n        into VN_DUMMY\n        from BEG_CRC_TITULO TIT\n       where TIT.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n      if VN_DUMMY > 0 then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Existe(m) titulo(s) para este cliente! ' ||\n                                :new.name || ' ' || :new.CPFCNPJ);\n      end if;\n    end if;\n  end if;\nend DIE_TRG_BIU_BEG_PESSOA;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_PESSOA_UPPER { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n\n-- if inserting then \n  -- AOK - 12/02/2010 \n  if :new.TP_PESSOA = 'F'\n     and (:new.INSCRICAO is null or :new.INSCRICAO <> 'ISENTO') and length(:NEW.cpfcnpj) = 11 then\n    :new.INSCRICAO := 'ISENTO';\n  end if;\n  --\n -- MF - 26/10/2011 \n if :new.TP_PESSOA = 'J'\n     and (:new.INSCRICAO ='isento' or :new.INSCRICAO='isenta' or :new.INSCRICAO='ISENTA' or :new.INSCRICAO='ISNETO' or :new.INSCRICAO ='isneto' \n          or :new.INSCRICAO ='IZENTO'  ) then\n    :new.INSCRICAO := 'ISENTO';\n  end if;\n  --\n  if :new.TP_PESSOA = 'J'\n     and :new.cliente= 'N' then\n    :new.cliente := 'Y';\n  end if;\n  --\n  \n  if :new.transportadora = 'Y' and :new.fornecedor = 'N' then\n    :new.fornecedor := 'Y';\n  end if;\n  \n  :new.name := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.name));\n  :new.nome := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.nome));  \n  if NVL(:new.BAIRRO, '^') != '^' then\n    :new.BAIRRO := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.BAIRRO));\n  end if;\n  if NVL(:new.ENDERECO, '^') != '^' then\n    :new.ENDERECO := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.ENDERECO));\n  end if;\n  if NVL(:new.COMPLEMENTO, '^') != '^' then\n    :new.COMPLEMENTO := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.COMPLEMENTO));\n  end if;\n  if NVL(:new.NATURALIDADE, '^') != '^' then\n    :new.NATURALIDADE := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.NATURALIDADE));\n  end if;\n  if NVL(:new.PAI, '^') != '^' then\n    :new.PAI := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.PAI));\n  end if;\n  if NVL(:new.MAE, '^') != '^' then\n    :new.MAE := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.MAE));\n  end if;\n  if NVL(:new.CONJUGE, '^') != '^' then\n    :new.CONJUGE := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.CONJUGE));\n  end if;\n  if NVL(:new.NOME_FANTASIA, '^') != '^' then\n    :new.NOME_FANTASIA := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.NOME_FANTASIA));\n  end if;\n  if NVL(:new.PONTO_REFERENCIA, '^') != '^' then\n    :new.PONTO_REFERENCIA := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.PONTO_REFERENCIA));\n  end if;\n  if NVL(:new.EMPRESACONJ, '^') != '^' then\n    :new.EMPRESACONJ := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.EMPRESACONJ));\n  end if;\n  if NVL(:new.EMPRESA, '^') != '^' then\n    :new.EMPRESA := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.EMPRESA));\n  end if;\n-- end if;  \n ---- ACRESCENTADO EM 03/11/2023 POR MARCELO FRITSCH PARA ELIMINAR DIVERGENCIAS NOS CADASTROS EVITANDO ENVIO DE E-MAIL PARA LOJAS\n  if UPPER(NVL(:new.NUMERO,'SN')) = 'SN' then\n    :new.NUMERO :='S/N';\n  end if;\n\n\n \n   if updating and\n     (:new.BAIRRO <> :old.bairro or :new.INSCRICAO <> :old.inscricao or\n     :new.NATURALIDADE <> :old.NATURALIDADE or\n     :new.EMPRESA <> :old.empresa or :new.PAI <> :old.pai or\n     :new.MAE <> :old.mae or :new.CONJUGE <> :old.conjuge or\n     :new.EMPRESACONJ <> :old.empresaconj or\n     :new.CARGOCONJ <> :old.cargoconj or :new.EMAIL <> :old.email or\n     :new.DESCR_CIDADE <> :old.descr_cidade or\n     :new.INSCRICAO_MUNICIPAL <> :old.inscricao_municipal or\n     :new.COMPLEMENTO <> :old.complemento or\n     :new.PONTO_REFERENCIA <> :old.ponto_referencia or\n     :new.NOME_FANTASIA <> :old.nome_fantasia or :new.NAME <> :old.name or\n     :new.NOME <> :old.nome) then\n  -- AOK - 12/02/2010 \n  if :new.TP_PESSOA = 'F'\n     and (:new.INSCRICAO is null or :new.INSCRICAO <> 'ISENTO') then\n    :new.INSCRICAO := 'ISENTO';\n  end if;\n  --\n -- MF - 26/10/2011 \n if :new.TP_PESSOA = 'J'\n     and (:new.INSCRICAO ='isento' or :new.INSCRICAO='isenta' or :new.INSCRICAO='ISENTA' or :new.INSCRICAO='ISNETO' or :new.INSCRICAO ='isneto'  ) then\n    :new.INSCRICAO := 'ISENTO';\n  end if;\n  --\n  if :new.TP_PESSOA = 'J'\n     and :new.cliente= 'N' then\n    :new.cliente := 'Y';\n  end if;\n  --\n  \n  :new.name := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.name));\n  :new.nome := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.nome));\n  if NVL(:new.BAIRRO, '^') != '^' then\n    :new.BAIRRO := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.BAIRRO));\n  end if;\n  if NVL(:new.ENDERECO, '^') != '^' then\n    :new.ENDERECO := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.ENDERECO));\n  end if;\n  if NVL(:new.COMPLEMENTO, '^') != '^' then\n    :new.COMPLEMENTO := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.COMPLEMENTO));\n  end if;\n  if NVL(:new.NATURALIDADE, '^') != '^' then\n    :new.NATURALIDADE := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.NATURALIDADE));\n  end if;\n  if NVL(:new.PAI, '^') != '^' then\n    :new.PAI := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.PAI));\n  end if;\n  if NVL(:new.MAE, '^') != '^' then\n    :new.MAE := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.MAE));\n  end if;\n  if NVL(:new.CONJUGE, '^') != '^' then\n    :new.CONJUGE := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.CONJUGE));\n  end if;\n  if NVL(:new.NOME_FANTASIA, '^') != '^' then\n    :new.NOME_FANTASIA := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.NOME_FANTASIA));\n  end if;\n  if NVL(:new.PONTO_REFERENCIA, '^') != '^' then\n    :new.PONTO_REFERENCIA := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.PONTO_REFERENCIA));\n  end if;\n  if NVL(:new.EMPRESACONJ, '^') != '^' then\n    :new.EMPRESACONJ := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.EMPRESACONJ));\n  end if;\n  if NVL(:new.EMPRESA, '^') != '^' then\n    :new.EMPRESA := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.EMPRESA));\n  end if;\n end if;  \n  \nend BEG_TRG_BIU_PESSOA_UPPER;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AI_BEG_PESSOA { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  -- local variables here\nbegin\n  if NVL(:new.CPFCNPJ, '^') != '^'\n     and :new.CLIENTE = 'Y' then\n    delete DIE_BEG_PESSOA B where B.CPFCNPJ = :new.CPFCNPJ;\n  end if;\nend DIE_TRG_AI_BEG_PESSOA;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_AUR_PESSOA { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  -- local variables here\n  cursor C_INFO_CLIENTE is\n    select 1\n      from BEG_INFO_CLIENTE\n     where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  V_EXISTE number;\nbegin\n  open C_INFO_CLIENTE;\n  fetch C_INFO_CLIENTE\n    into V_EXISTE;\n  if C_INFO_CLIENTE%notfound then\n    AD_SEQUENCE_NEXT('BEG_INFO_CLIENTE', 0, V_EXISTE);\n    insert into BEG_INFO_CLIENTE\n      (BEG_INFO_CLIENTE_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       BEG_PESSOA_ID)\n    values\n      (V_EXISTE,\n       :new.AD_CLIENT_ID,\n       :new.AD_ORG_ID,\n       :new.ISACTIVE,\n       :new.CREATED,\n       :new.CREATEDBY,\n       :new.UPDATED,\n       :new.UPDATEDBY,\n       :new.BEG_PESSOA_ID);\n  end if;\n  close C_INFO_CLIENTE;\n\n \n    \n  PRC_BEG_INFO_CLIENTE(:new.BEG_PESSOA_ID);\n  \n\n  --\nend BEG_TRG_AUR_PESSOA;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_PESSOA_CPFCNPJ { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\n  cursor C_PESSOA(P_TP_PESSOA varchar, P_CPFCNPJ varchar) is\n    select BEG_FNC_PESSOA_EXISTE(P_TP_PESSOA, P_CPFCNPJ) from DUAL;\n  V_EXISTE number := 0;\n  --\n  V_NOME          BEG_PESSOA.NOME%type;\n  V_CEP           BEG_PESSOA.CEP%type;\n  V_ENDERECO      BEG_PESSOA.ENDERECO%type;\n  V_COMPLEMENTO   BEG_PESSOA.COMPLEMENTO%type;\n  V_NUMERO        BEG_PESSOA.NUMERO%type;\n  V_BAIRRO        BEG_PESSOA.BAIRRO%type;\n  V_TP_PESSOA     BEG_PESSOA.TP_PESSOA%type;\n  V_ERRO          varchar2(5000);\n  V_DDD           BEG_TELEFONE.DDD%type;\n  V_FONE          BEG_TELEFONE.value%type;\n  V_SIT           BEG_PESSOA.ATIVO_SINTEGRA%type;\n  V_NOME_FANTASIA BEG_PESSOA.NOME_FANTASIA%type;\n  V_DT_FUNDACAO   date;\n  --\n  cursor BUSCA_CEP is\n    select * from BEG_CEP C where C.value = V_CEP;\n  --\n  VREG1 BUSCA_CEP%rowtype;\n  --\n  cursor C_BEG_CNAE(P_CNAE varchar) is\n    select BEG_FIS_CNAE_ID\n      from BEG_FIS_CNAE A\n     where A.COD_REDUZIDO = P_CNAE;\n\n  V_BEG_FIS_CNAE_ID number(10);\n  V_BEG_FIS_CNAE    varchar(20);\nbegin\n\n  if INSERTING\n     or UPDATING then\n    :new.name := :new.NOME;\n    --  -----------------------------------------\n    -- AOK - 14/09/2006\n    :new.TP_PESSOA := 'F'; -- aok - 09/03/07 - Inicialização\n    :new.CPFCNPJ   := trim(:new.CPFCNPJ); -- AOK - 23/04/2007 - tirar espaços\n      \n    \n    if :new.CPFCNPJ is not null then\n      if LENGTH(:new.CPFCNPJ) > 11 then\n        :new.TP_PESSOA := 'J'; :new.FORNECEDOR := 'Y' ; \n      end if;\n    end if;\n    \n     if LENGTH(:new.CPFCNPJ) < 11 or (LENGTH(:new.CPFCNPJ)> 11 and  LENGTH(:new.CPFCNPJ)< 14) then\n      RAISE_APPLICATION_ERROR(-20001,'CPF/CNPJ incompleto verifique !!!');\n    end if;\n    \n    --\n   if INSERTING then\n      if LENGTH(:new.CPFCNPJ) > 11 then\n         :new.ativo_sintegra := 'Y';\n       end if;   \n           \n/*     \n      V_NOME          := ' ';\n      V_ENDERECO      := ' ';\n      V_NUMERO        := 0;\n      V_CEP           := ' ';\n      V_BAIRRO        := ' ';\n      V_TP_PESSOA     := ' ';\n      V_DT_FUNDACAO   := null;\n      V_NOME_FANTASIA := ' ';\n      --\n      V_ERRO := null;\n      --\n      if :new.NOME is null then\n        BEG_PRC_FIS_WEB_SINTEGRA(:new.CPFCNPJ,\n                                 :new.INSCRICAO,\n                                 :new.BEG_VW_UF_ID,\n                                 V_NOME,\n                                 V_ENDERECO,\n                                 V_COMPLEMENTO,\n                                 V_NUMERO,\n                                 V_CEP,\n                                 V_BAIRRO,\n                                 V_TP_PESSOA,\n                                 V_DDD,\n                                 V_FONE,\n                                 V_SIT,\n                                 V_BEG_FIS_CNAE,\n                                 V_NOME_FANTASIA,\n                                 V_DT_FUNDACAO,\n                                 V_ERRO);\n      \n        if V_ERRO is null then\n          open BUSCA_CEP;\n          fetch BUSCA_CEP\n            into VREG1;\n        \n          if BUSCA_CEP%found then\n            :new.BEG_CIDADE_ID := VREG1.BEG_CIDADE_ID;\n            :new.BEG_VW_UF_ID  := VREG1.BEG_UF_ID;\n          end if;\n          close BUSCA_CEP;\n          :new.NOME           := V_NOME;\n          :new.NUMERO         := V_NUMERO;\n          :new.ENDERECO       := V_ENDERECO;\n          :new.CEP            := V_CEP;\n          :new.BAIRRO         := V_BAIRRO;\n          :new.TP_PESSOA      := V_TP_PESSOA;\n--          :new.ATIVO_SINTEGRA := V_SIT;\n          :new.DT_SINTEGRA    := sysdate;\n          :new.NOME_FANTASIA  := V_NOME_FANTASIA;\n          :new.DT_FUNDACAO    := V_DT_FUNDACAO;\n        \n          open C_BEG_CNAE(V_BEG_FIS_CNAE);\n          fetch C_BEG_CNAE\n            into V_BEG_FIS_CNAE_ID;\n          close C_BEG_CNAE;\n        \n          :new.BEG_FIS_CNAE_ID := V_BEG_FIS_CNAE_ID;\n        \n          if NVL(V_FONE, 0) > 0 then\n            insert into BEG_TELEFONE\n              (BEG_TELEFONE_ID,\n               AD_CLIENT_ID,\n               AD_ORG_ID,\n               ISACTIVE,\n               CREATED,\n               CREATEDBY,\n               UPDATED,\n               UPDATEDBY,\n               DDD,\n               value,\n               TP_TELEFONE,\n               BEG_PESSOA_ID)\n            values\n              (BEG_FNC_AD_SEQUENCE('BEG_TELEFONE'),\n               :new.AD_CLIENT_ID,\n               :new.AD_ORG_ID,\n               'Y',\n               :new.CREATED,\n               :new.CREATEDBY,\n               :new.UPDATED,\n               :new.UPDATEDBY,\n               V_DDD,\n               V_FONE,\n               'O',\n               :new.BEG_PESSOA_ID);\n          end if;\n        end if;\n      end if;*/\n    end if;\n  \n    -- AOK - 04/12/2006 - Alterado de posiçao na trigger\n    V_EXISTE := 0;\n    if :new.CPFCNPJ is not null then\n      open C_PESSOA(NVL(:new.TP_PESSOA, 'F'), :new.CPFCNPJ);\n      fetch C_PESSOA\n        into V_EXISTE;\n      close C_PESSOA;\n      /* -- Este if abaixo estva desabilitado -- */\n      if V_EXISTE = 1\n         and INSERTING then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Parceiro Comercial já cadastrado !');\n      end if;\n    \n      if V_EXISTE = 2 then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'CPF/CNPJ inválido ! : ' || :new.TP_PESSOA || ' ' ||\n                                :new.CPFCNPJ);\n      end if;\n    end if;\n    --\n    /* \n    insert into BEG_PESSOA_CPFCNPJ\n      (BEG_PESSOA_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       CPFCNPJ,\n       NOME)\n    values\n      (:new.BEG_PESSOA_ID,\n       :new.AD_CLIENT_ID,\n       :new.AD_ORG_ID,\n       :new.ISACTIVE,\n       :new.CREATED,\n       :new.CREATEDBY,\n       :new.UPDATED,\n       :new.UPDATEDBY,\n       :new.CPFCNPJ,\n       :new.NOME);  */\n  else\n    --\n    delete from BEG_PESSOA_CPFCNPJ\n     where BEG_PESSOA_ID = :old.BEG_PESSOA_ID;\n  \n    -- AOK - 14/09/2006\n    delete from BEG_INFO_CLIENTE where BEG_PESSOA_ID = :old.BEG_PESSOA_ID;\n    --\n  end if;\n\nend BEG_TRG_BIUD_PESSOA_CPFCNPJ;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BU_PESSOA_ATIVA { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n\n  pragma autonomous_transaction;\n\n  VN_DUMMY integer;\n\nbegin\n\n  if :new.ISACTIVE <> :old.ISACTIVE then\n    --\n    select count(1)\n      into VN_DUMMY\n      from BEG_CRC_TITULO TIT\n     where TIT.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe títulos em aberto para este cliente!');\n    end if;\n  \n    -- Pessoa Relacionada\n    update BEG_PESSOA_RELACIONADA PR\n       set PR.ISACTIVE = :new.ISACTIVE\n     where PR.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  \n    -- Endereços\n    update BEG_PESSOA_ENDERECO PE\n       set PE.ISACTIVE = :new.ISACTIVE\n     where PE.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  \n    -- Observacoes\n    update BEG_PESSOA_OBS PO\n       set PO.ISACTIVE = :new.ISACTIVE\n     where PO.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  \n    -- Referencia bancaria\n    update BEG_REF_BANCARIA RB\n       set RB.ISACTIVE = :new.ISACTIVE\n     where RB.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  \n    -- Dados bancarios\n    update BEG_DADOS_BANCARIOS DB\n       set DB.ISACTIVE = :new.ISACTIVE\n     where DB.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  \n    -- Telefone\n    update BEG_TELEFONE T\n       set T.ISACTIVE = :new.ISACTIVE\n     where T.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  \n    -- Referencia comercial\n    update BEG_REF_COMERCIAL RC\n       set RC.ISACTIVE = :new.ISACTIVE\n     where RC.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  \n    -- Restricao\n    update BEG_PESSOA_RESTRICAO R\n       set R.ISACTIVE = :new.ISACTIVE\n     where R.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  \n    -- Referemcia pessoal\n    update BEG_REF_PESSOAL RP\n       set RP.ISACTIVE = :new.ISACTIVE\n     where RP.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  \n    -- Cobrador\n    update BEG_COBRADOR C\n       set C.ISACTIVE = :new.ISACTIVE\n     where C.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  \n    -- Filiais de atendimento pelo Cobrador\n    update BEG_COBRADOR_FILIAL CF\n       set CF.ISACTIVE = :new.ISACTIVE\n     where CF.BEG_COBRADOR_ID =\n           (select C.BEG_COBRADOR_ID\n              from BEG_COBRADOR C\n             where C.BEG_PESSOA_ID = :new.BEG_PESSOA_ID);\n  \n    -- Pessoa Filial\n    update BEG_PESSOA_FILIAL PF\n       set PF.ISACTIVE = :new.ISACTIVE\n     where PF.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  \n    -- Motorista\n    update BEG_FRO_MOTORISTA M\n       set M.ISACTIVE = :new.ISACTIVE\n     where M.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  \n    -- Especificaçoes do motorista\n    update BEG_FRO_MOTOR_ESPEC ME\n       set ME.ISACTIVE = :new.ISACTIVE\n     where ME.BEG_FRO_MOTORISTA_ID =\n           (select M.BEG_FRO_MOTORISTA_ID\n              from BEG_FRO_MOTORISTA M\n             where M.BEG_PESSOA_ID = :new.BEG_PESSOA_ID);\n  \n    commit;\n  end if;\nend BEG_TRG_BU_PESSOA_ATIVA;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BU_PESSOA_VALIDACAO { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  VN_DUMMY integer;\nbegin\n\n  -- AOK -- 03/06/2008 - Consistencia para troca de CPF\n  if :new.CPFCNPJ <> :old.CPFCNPJ\n     or :new.CPFCNPJ is null then\n    select count(1)\n      into VN_DUMMY\n      from BEG_COB_TITULO_SPC SPC\n     where SPC.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n       and SPC.DT_BAIXA_SPC is null;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Cliente esta negativado no SPC com este CPF! ('|| :NEW.BEG_PESSOA_ID ||')');\n    end if;\n  end if;\n\n  --\n  -- Validacoes referente ao atributo Cliente\n  --\n  if NVL(:new.CLIENTE, 'x') <> NVL(:old.CLIENTE, 'x')\n     and NVL(:new.CLIENTE, 'x') = 'N' then\n    --\n    select count(1)\n      into VN_DUMMY\n      from BEG_FAT_PRE_NFS\n     where BEG_VW_CLIENTE_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Pre Nota para este cliente!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_VEN_PEDIDO\n     where BEG_VW_CLIENTE_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentaçao de Pedidos para este cliente!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_VEN_PV_IMPORTADO\n     where BEG_VW_CLIENTE_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Pedidos importados para este cliente!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_VEN_COTACAO\n     where BEG_VW_CLIENTE_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Cotações para este cliente!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_VEN_AGENDAMENTO\n     where BEG_VW_CLIENTE_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de agendamentos de Contatos para este cliente!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_VEN_ABORDAGEM\n     where BEG_VW_CLIENTE_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação deste cliente em BEG_VEN_ABORDAGEM!');\n    end if;\n    /*select count(1)\n      into VN_DUMMY\n      from BEG_CRC_PGTO_MANUAL\n     where BEG_VW_CLIENTE_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentac?o de Pagamentos Manuais para este cliente!');\n    end if;*/\n  end if;\n  --\n  -- Validacoes referente ao atributo Fornecedor\n  --\n  if NVL(:new.FORNECEDOR, 'x') <> NVL(:old.FORNECEDOR, 'x')\n     and NVL(:new.FORNECEDOR, 'x') = 'N' then\n    --\n    select count(1)\n      into VN_DUMMY\n      from BEG_CPG_TITULO\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Titulos para este fornecedor!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_CPG_ADIANTAMENTO\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Adiantamentos para este fornecedor!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_INS_LIBERACAO\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de BEG_INS_LIBERACAO para este fornecedor !');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_PRD_OPERACAO\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de BEG_PRD_OPERACAO para este fornecedor !');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_PCE_LOTE_PAGAMENTO\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Lote de Pagamento para este fornecedor!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_CPG_PGTO_MANUAL\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Pagamentos Manuais para este fornecedor!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_PRD_FORNEC_MARCA\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação em Marcas de Produtos para este fornecedor !');\n    end if;\n    /*    select count(1)\n          into VN_DUMMY\n          from BEG_SUP_FORNECEDOR\n         where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n        if VN_DUMMY > 0 then\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Existe movimentac?o de Suprimentos para este fornecedor!');\n        end if;\n    */\n    select count(1)\n      into VN_DUMMY\n      from BEG_SUP_LISTA_FORNECEDOR\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Lista de Preco Produtos para este fornecedor!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_CPR_NEC_PARAM\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação em BEG_CPR_NEC_PARAM para este fornecedor !');\n    end if;\n  \n    select count(1)\n      into VN_DUMMY\n      from BEG_CPG_AUTORIZACAO_PGTO\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Autorizac?es de Pagamaneto para este fornecedor!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_CPG_RENEG_FORNECEDOR\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Renegociac?es para este fornecedor!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_CPR_NFE\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Nota Fiscal de Entrada para este fornecedor!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_PCE_LOTE_PAGTO_TIT\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Titulos em Lote de Pagamaneto para este fornecedor!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_CPG_RENEG\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Renegociações para este fornecedor!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_CPR_ORDEM\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Ordens de Compra para este fornecedor!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_PRD_FORNECEDOR\n     where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe movimentação de Produtos para este fornecedor!');\n    end if;\n  end if;\n  --\n  -- Validacoes referente ao atributo Transportadora\n  --\n  if NVL(:new.TRANSPORTADORA, 'x') <> NVL(:old.TRANSPORTADORA, 'x')\n     and NVL(:new.TRANSPORTADORA, 'x') = 'N' then\n    --\n    select count(1)\n      into VN_DUMMY\n      from BEG_VEN_PEDIDO\n     where BEG_VW_TRANSPORTADORA_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe vinculo desta transportadora com Pedido de Venda!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_CPR_ORDEM\n     where BEG_VW_TRANSPORTADORA_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe vinculo desta transportadora com a Ordem de Compra!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_VEN_PV_IMPORTADO\n     where BEG_VW_TRANSPORTADORA_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe vinculo desta transportadora com um Pedido de Venda Importado!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_CPR_NFE\n     where BEG_VW_TRANSPORTADORA_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe vinculo desta transportadora com Nota Fiscal de Entrada!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_SUP_FORNECEDOR\n     where BEG_VW_TRANSPORTADORA_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe vinculo desta transportadora com Suprimentos do Fornecedor!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_FAT_NFS\n     where BEG_VW_TRANSPORTADORA_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe vinculo desta transportadora com Nota Fiscal de Saida!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_FAT_PRE_NFS\n     where BEG_VW_TRANSPORTADORA_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe vinculo desta transportadora com a geracao de uma Pre Nota de Saida!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_FRO_ROTA\n     where BEG_VW_TRANSPORTADORA_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe Vinculo desta transportadora com Rota!');\n    end if;\n    -- select count(1)\n    --   into VN_DUMMY\n    --   from BEG_TEL_PEDIDO\n    --  where BEG_VW_TRANSPORTADORA_ID = :old.BEG_PESSOA_ID;\n    -- if VN_DUMMY > 0 then\n    --   RAISE_APPLICATION_ERROR(-20001,\n    --                           'Existe movimentac?o desta transportadora em BEG_TEL_PEDIDO!');\n    -- end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_CIDADE\n     where BEG_VW_TRANSPORTADORA_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe referencia nas Cidades para esta transportadora!');\n    end if;\n    select count(1)\n      into VN_DUMMY\n      from BEG_BAIRRO\n     where BEG_VW_TRANSPORTADORA_ID = :old.BEG_PESSOA_ID;\n    if VN_DUMMY > 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Existe vinculo desta transportadora com algum Bairro!');\n    end if;\n  end if;\n  --  \nend BEG_TRG_BU_PESSOA_VALIDACAO;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_PESSOA_NAME { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  -- AOK -- 30/07/2007\n /* if inserting then\n    if NVL(:new.NOME, '^') != '^' then\n      :new.NOME := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.NOME));\n    end if;\n  end if;  \n  --\n   if updating and :new.NOME<> :old.Nome then\n    if NVL(:new.NOME, '^') != '^' then\n      :new.NOME := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.NOME));\n    end if;\n  end if; */\n  \n  :new.name  := :new.NOME;\n  :new.value := :new.CPFCNPJ;\n  if UPPER(:new.TP_PESSOA) = 'J' then\n    :new.NOME_FANTASIA := NVL(:new.NOME_FANTASIA, RPAD(:new.NOME, 40));\n  end if;\n  --\nend BEG_TRG_BIU_PESSOA_NAME;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_PESSOA { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  cursor CONF_CIDADE is\n    select *\n      from BEG_CIDADE C\n     where C.BEG_CIDADE_ID = :new.BEG_CIDADE_ID\n       and C.BEG_UF_ID = :new.BEG_VW_UF_ID;\n  RCONF CONF_CIDADE%rowtype;\n  \n  CURSOR C_CEP IS\n    select *\n    from beg_cep ce\n   where ce.value = :NEW.Cep;\n   RCEP C_CEP%rowtype;\n  --\n  --ISVALID            boolean;\n  V_LOGRADOURO       varchar(100);\n  V_BAIRRO           varchar(40);\n  V_CIDADE_ID        number(10);\n  V_UF_ID            number(10);\n  V_CIDADE_DESCRICAO varchar(100);\n  V_UF_DESCRICAO     varchar(100);\n  V_CEP_ID           number(10);\n  --\nbegin\n\n  /* Tiago Gabriel em 19/07/2007\n     Comentado pois não tem a necessidade de inserir na BEG_SUP_FORNECEDOR\n  if NVL(:old.FORNECEDOR, 'x') <> NVL(:new.FORNECEDOR, 'x') then\n  \n    if NVL(:old.FORNECEDOR, 'x') = 'Y' then\n      delete from BEG_SUP_FORNECEDOR\n       where BEG_VW_FORNECEDOR_ID = :old.BEG_PESSOA_ID;\n    end if;\n  \n    if NVL(:new.FORNECEDOR, 'x') = 'Y' then\n      insert into BEG_SUP_FORNECEDOR\n        (BEG_SUP_FORNECEDOR_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         CREATEDBY,\n         UPDATEDBY,\n         BEG_VW_FORNECEDOR_ID)\n      values\n        (BEG_FNC_AD_SEQUENCE('BEG_SUP_FORNECEDOR'), -- beg_sup_fornecedor_id\n         :new.AD_CLIENT_ID, -- ad_client_id\n         :new.AD_ORG_ID, -- ad_org_id\n         :new.UPDATEDBY, -- createdby\n         :new.UPDATEDBY, -- updatedby\n         :new.BEG_PESSOA_ID); -- beg_vw_fornecedor_id\n    \n    end if;\n  \n  end if;\n  */\n  --\n  if not DELETING then\n    \n     :new.cliente :='Y';\n  \n    if :new.BEG_CIDADE_ID is not null and\n       nvl(:new.BEG_CIDADE_ID, 0) <> nvl(:old.BEG_CIDADE_ID, 0) then\n      open CONF_CIDADE;\n      fetch CONF_CIDADE\n        into RCONF;\n      if CONF_CIDADE%notfound then\n        RAISE_APPLICATION_ERROR(-20003,\n                                'Cidade não cadastrada ou não pertence ao Estado informado - verifique !!! ID:' || :new.beg_pessoa_id);\n      end if;\n    end if;\n    \n    IF :NEW.ENDERECO IS NOT NULL AND :NEW.CEP IS NULL THEN \n        RAISE_APPLICATION_ERROR(-20003,\n                                'Faltou informar o CEP - verifique !!! BEG_PESSOA_ID =' || :new.beg_pessoa_id);      \n    END IF;\n    \n    \n    if :new.cep is not null then \n      open C_CEP;\n      fetch C_CEP\n        into RCEP;\n      if C_CEP%notfound then\n        RAISE_APPLICATION_ERROR(-20003,\n                                'CEP '|| :new.cep ||'  nao cadastrado verifique com setor de TI - verifique !!!');\n      end if;\n    \n    end if;\n    --  AOK -- 11/01/2007 - \n    -- Arok -- 12/01/2007 - Desabilitado devido a excesso de erros de carga\n    /*    ISVALID := REGEXP_LIKE(:new.CEP, '^([[:digit:]]{8})$');\n        if (not ISVALID) then\n          RAISE_APPLICATION_ERROR(-20003,\n                                  'Informac?o do CEP - errado ou mal formado  - verifique !!!');\n        end if;\n    */ --\n  end if;\n\n  -- 28/02/2007 - AOK - quando existir um cep valido e a cidade naum for informada, usar a cidade do cep.\n  if INSERTING or UPDATING then\n    if NVL(:new.CEP, '^') != '^' and NVL(:new.BEG_CIDADE_ID, 0) = 0 then\n      PRC_BEG_CEP(:new.CEP,\n                  V_CEP_ID,\n                  V_LOGRADOURO,\n                  V_BAIRRO,\n                  V_CIDADE_ID,\n                  V_UF_ID,\n                  V_CIDADE_DESCRICAO,\n                  V_UF_DESCRICAO);\n      if V_CIDADE_ID is not null then\n        :new.BEG_CIDADE_ID := V_CIDADE_ID;\n        if LENGTH(:new.CEP) = 8 and INSTR(:new.CEP, '-') = 0 then\n          :new.CEP := SUBSTR(:new.CEP, 1, 5) || '-' ||\n                      SUBSTR(:new.CEP, 6, 3);\n        end if;\n      end if;\n    end if;\n    if NVL(:new.BEG_CIDADE_ID, 0) > 0 then\n      :new.DESCR_CIDADE := null;\n    end if;\n  end if;\n\n  -- Apos o beg_cbo_id ter sido informado, não mais podera ser nulo - guarda historico\n  if UPDATING then\n    if NVL(:old.BEG_CBO_ID, 0) > 0 and NVL(:new.BEG_CBO_ID, 0) = 0 then\n--      :new.BEG_CBO_ID := :old.BEG_CBO_ID;\n      insert into DIE_LOG_TABELA\n        (DIE_LOG_TABELA_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         value,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         name,\n         USUARIO,\n         BEG_PESSOA_ID)\n      values\n        (BEG_FNC_AD_SEQUENCE('DIE_LOG_TABELA'),\n         NVL(:new.AD_CLIENT_ID, 1000000), -- AD_CLIENTE_ID\n         NVL(:new.AD_ORG_ID, 0), -- AD_ORG_ID\n         'Y',\n         'BEG_PESSOA', --VALUE,\n         sysdate, --CREATED,\n         0, --CREATEDBY,\n         sysdate, --UPDATED,\n         0, --UPDATEDBY,\n         'Beg_Cbo_Id informada - nao pode ser nula ',\n         user,\n         :new.BEG_PESSOA_ID);\n    end if;\n  \n    -- Quando cnae ja tiver sido informado e for pessoa juridica  não permite zerá-lo\n    if NVL(:old.BEG_FIS_CNAE_ID, 0) > 0 and\n       NVL(:new.BEG_FIS_CNAE_ID, 0) = 0 and :new.TP_PESSOA = 'J' then\n      :new.BEG_FIS_CNAE_ID := :old.BEG_FIS_CNAE_ID;\n    end if;\n  end if;\n  --\nend BEG_TRG_BIUD_PESSOA;\n"}`;
    
    }
}
