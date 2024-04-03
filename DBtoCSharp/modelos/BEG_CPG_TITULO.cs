
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_TITULO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IOF { get; set; }
        
        /// <summary>
        /// ID da Nota de Saida
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FUNRURAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TARIFA_DOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VENDOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_RENEG { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ORIGEM_RENEG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CPG_CONTA_ID { get; set; }
        
        /// <summary>
        /// Codigo de Pagamento do INSS.
        /// </summary>
        public int COD_PGTO_INSS { get; set; }
            [StringLength(6)]
        /// <summary>
        /// Competência do Pagamento do INSS.
        /// </summary>
        public string COMPETENCIA_INSS { get; set; }
        
        /// <summary>
        /// Valor do INSS.
        /// </summary>
        public int VLR_INSS { get; set; }
        
        /// <summary>
        /// Valor de outras entidades INSS.
        /// </summary>
        public int VLR_OUT_ENT { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Instrucao para pagamento Pr- Titulo prorrogado Vcto C - Pagar em Cartorio 
        /// </summary>
        public string INSTR_PAGTO { get; set; }
        
        /// <summary>
        /// Id beneficiario do titulo exigencia Febraban
        /// </summary>
        public int DIE_VW_BENEFICIARIO_ID { get; set; }
        
        /// <summary>
        /// Data original do vencimento antes de ser prorrogado ou com promessa de pagamento
        /// </summary>
        public string DT_VCTO_ORIGINAL { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do titulo
        /// </summary>
        public int BEG_CPG_TITULO_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// Numero do titulo
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Parcela do titulo
        /// </summary>
        public int PARCELA { get; set; }
            [Required]
        /// <summary>
        /// Data de emiss?o do titulo
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// Data de recebimento do titulo
        /// </summary>
        public string DT_RECEBIMENTO { get; set; }
            [Required]
        /// <summary>
        /// Data de vencimento do titulo
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// Data de pagamento do titulo
        /// </summary>
        public string DT_PGTO { get; set; }
            [Required]
        /// <summary>
        /// Valor do titulo
        /// </summary>
        public int VLR_TITULO { get; set; }
            [Required]
        /// <summary>
        /// Valor original (renegociac?o)
        /// </summary>
        public int VLR_ORIGINAL { get; set; }
            [Required]
        /// <summary>
        /// Valor dos encargos (renegociac?o)
        /// </summary>
        public int VLR_ENCARGOS { get; set; }
            [Required]
        /// <summary>
        /// Valor em aberto para o titulo
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [Required]
        /// <summary>
        /// Valor do desconto / abatimento do titulo
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// Valor de outras deduc?es do titulo
        /// </summary>
        public int VLR_OUTRAS_DEDUCOES { get; set; }
            [Required]
        /// <summary>
        /// Valor de multa / mora do titulo
        /// </summary>
        public int VLR_MULTA { get; set; }
            [Required]
        /// <summary>
        /// Valor de juros do titulo
        /// </summary>
        public int VLR_JUROS { get; set; }
            [Required]
        /// <summary>
        /// Valor de outros acrescimos do titulo
        /// </summary>
        public int VLR_OUTROS_ACRESCIMOS { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Status do titulo: WC - Aguardando confirmac?o (Waiting Confirmation) / WP - Liberado para movimentac?o (Waiting Payment) / PA - Pago (PAyed) / CA - Cancelado (CAnceled)
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Observac?o do titulo
        /// </summary>
        public string OBS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ind.Lote Pagto Escritural
        /// </summary>
        public string IND_LOTE_PGTO_ESCRITURAL { get; set; }
        
        /// <summary>
        /// Data de envio  - pagamento escritural
        /// </summary>
        public string DT_ENVIO_BCO { get; set; }
            [StringLength(204)]
        /// <summary>
        /// Linha Digitavel - pagamento bancario
        /// </summary>
        public string LINHA_DIGITAVEL { get; set; }
            [StringLength(48)]
        /// <summary>
        /// Codigo de barras do documento
        /// </summary>
        public string CODIGO_BARRAS { get; set; }
            [Required]
        /// <summary>
        /// ID do fornecedor
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do tipo do titulo
        /// </summary>
        public int BEG_CPG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// ID da nota fiscal de entrada
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// ID da parcela da renegociac?o
        /// </summary>
        public int BEG_CPG_RENEG_PARCELA_ID { get; set; }
        
        /// <summary>
        /// ID do banco
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// ID da moeda
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
        
        /// <summary>
        /// ID do portador
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
        
        /// <summary>
        /// Numero do lote - pagamento escritural
        /// </summary>
        public int BEG_PCE_LOTE_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// Dados bancarios do fornecedor
        /// </summary>
        public int BEG_DADOS_BANCARIOS_ID { get; set; }
            [Required]
        /// <summary>
        /// ID da conta de lancamentos
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
        
        /// <summary>
        /// ID da forma de pagamento
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }

        [NotMapped]
        public string Trigger_ACC_TRG_BIUD_CPG_TITULO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  cursor c_conta_new is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :NEW.BEG_CPG_CONTA_ID;\n   r_conta_new c_conta_new%rowtype;\n\n   cursor c_conta_old is\n    select c.ind_rj\n      from beg_cpg_conta c\n     where c.beg_cpg_conta_id = :OLD.BEG_CPG_CONTA_ID;\n   r_conta_old c_conta_old%rowtype;\n\nBEGIN\n\n  if inserting and :NEW.BEG_CPG_CONTA_ID IS NOT NULL THEN\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_new.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a inclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if deleting  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    if r_conta_old.ind_rj ='Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n  if updating and :NEW.BEG_CPG_CONTA_ID <> :OLD.BEG_CPG_CONTA_ID  THEN\n\n    OPEN c_conta_old;\n    FETCH c_conta_old\n      INTO r_conta_old;\n    CLOSE c_conta_old;\n\n    OPEN c_conta_new;\n    FETCH c_conta_new\n      INTO r_conta_new;\n    CLOSE c_conta_new;\n\n    if r_conta_old.ind_rj ='Y' and r_conta_new.ind_rj ='N' then\n      RAISE_APPLICATION_ERROR(-20001,'Conta Contábil específica para processo de RJ não permitida a exclusão. Verifique!!');\n    end if;\n\n  end if;\n\n\n\nEND ACC_TRG_BIUD_CPG_TITULO;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_DADOS_INSS { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n/*  for T in (select 1\n              from BEG_PCE_PORTADOR_LOTE PL\n             where PL.BEG_CPG_TIPO_TITULO_ID = :NEW.BEG_CPG_TIPO_TITULO_ID\n               and PL.Segmento = 'I')\n  loop\n    if :NEW.VLR_OUT_ENT is null then\n      RAISE_APPLICATION_ERROR(-20012\n                             ,'Para o tipo de título selecionado, obrigatório informar Valor de Outras Entidades.');\n    elsif :NEW.COD_PGTO_INSS is null then\n      RAISE_APPLICATION_ERROR(-20012\n                             ,'Para o tipo de título selecionado, obrigatório informar Código de Pagamento do INSS.');\n    elsif :NEW.COMPETENCIA_INSS is null then\n      RAISE_APPLICATION_ERROR(-20012\n                             ,'Para o tipo de título selecionado, obrigatório informar Competência de Pagamento do INS.');\n    end if;\n  end loop;*/\n  --\n  if :new.vlr_aberto > 0 then\n    :new.docstatus := 'WP';\n  end if;\n  --\nend BEG_TRG_BIU_DADOS_INSS;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BD_CPG_TITULO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  --\n  cursor C_FECH_CONT is\n    select MAX(C.DT_FINAL) DT_FINAL\n      from BEG_FECH_CONTABIL C\n     WHERE C.DT_INICIAL <= :old.dt_recebimento\n       AND C.DT_FINAL >= :old.dt_recebimento;\n  --\n  R_FECH_CONT C_FECH_CONT%rowtype;\n  --\n\n  cursor C_FECH_CONT2 is\n    select C.DT_FINAL, C.DT_INICIAL, C.IND_ESCRITA\n      from BEG_FECH_CONTABIL C\n     WHERE C.DT_INICIAL <= :NEW.dt_recebimento\n       AND C.DT_FINAL >= :NEW.dt_recebimento;\n  --\n  R_FECH_CONT2 C_FECH_CONT2%rowtype;\n  \n   cursor C_FECH_CONT3 is\n    select C.DT_FINAL, C.DT_INICIAL, C.IND_ESCRITA\n      from BEG_FECH_CONTABIL C\n     WHERE C.DT_INICIAL <= :OLD.dt_recebimento\n       AND C.DT_FINAL >= :OLD.dt_recebimento;\n  --\n  R_FECH_CONT3 C_FECH_CONT3%rowtype;\n\n  cursor C_FECH_CONT1 is\n    select ind_escrita\n      from BEG_FECH_CONTABIL C\n     where c.dt_final = R_FECH_CONT.DT_FINAL;\n  R_FECH_CONT1 C_FECH_CONT1%rowtype;\n  \n  cursor C_NOTA is\n  select n.*\n   from beg_cpr_nfe n\n  where n.beg_cpr_nfe_id = :old.beg_cpr_nfe_id;\n  R_NOTA C_NOTA%rowtype;\n  \nBEGIN\n  --\n  IF DELETING THEN\n    open C_FECH_CONT;\n    fetch C_FECH_CONT\n      into R_FECH_CONT;\n    close C_FECH_CONT;\n    open C_FECH_CONT1;\n    fetch C_FECH_CONT1\n      into R_FECH_CONT1;\n    close C_FECH_CONT1;\n  \n    --\n    if R_FECH_CONT.DT_FINAL >= :old.dt_recebimento AND\n       nvl(R_FECH_CONT1.IND_ESCRITA, 'N') = 'N' then\n      raise_application_error(-20501, 'Movimento contabil ja encerrado!');\n    end if;\n    --\n    IF :OLD.DOCSTATUS = 'PA' THEN\n      RAISE_APPLICATION_ERROR(-20001, 'Não pode deletar titulos já pagos!');\n    END IF;\n    --\n  END IF;\n  IF INSERTING THEN\n    open C_FECH_CONT2;\n    fetch C_FECH_CONT2\n      into R_FECH_CONT2;\n    --\n    if R_FECH_CONT2.DT_FINAL >= :NEW.dt_recebimento AND  nvl(R_FECH_CONT2.IND_ESCRITA, 'N') = 'N' then\n      raise_application_error(-20501, 'Movimento contabil ja encerrado!');\n    end if;\n    --\n  END IF;\n  IF UPDATING THEN\n    IF :OLD.DT_RECEBIMENTO <> :NEW.DT_RECEBIMENTO THEN\n      open C_FECH_CONT3;\n      fetch C_FECH_CONT3\n        into R_FECH_CONT3;\n      --\n      if R_FECH_CONT3.DT_FINAL >= :OLD.dt_recebimento AND  nvl(R_FECH_CONT3.IND_ESCRITA, 'N') = 'N' then\n        raise_application_error(-20501, 'Movimento contabil ja encerrado!');\n      end if;\n      --\n      open C_FECH_CONT2;\n      fetch C_FECH_CONT2\n      into R_FECH_CONT2;\n    --\n    if R_FECH_CONT2.DT_FINAL >= :NEW.dt_recebimento AND  nvl(R_FECH_CONT2.IND_ESCRITA, 'N') = 'N' then\n      raise_application_error(-20501, 'Movimento contabil ja encerrado!');\n    end if;\n    END IF;\n  \n  END IF;\n  \n  IF DELETING AND :OLD.BEG_CPR_NFE_ID IS NOT NULL THEN \n\n      open C_NOTA;\n      fetch C_NOTA\n      into R_NOTA;\n      CLOSE C_NOTA;\n   IF R_NOTA.DOCSTATUS <> 'WC' THEN\n      raise_application_error(-20501, 'Nota ja confirmada nao permite excluir titulo');   \n   END IF;\n      \n  END IF;\n\n   IF DELETING AND :OLD.BEG_CPG_RENEG_PARCELA_ID IS NOT NULL THEN \n    \n      raise_application_error(-20501, 'Titulo de renegociacao nao permite exclusao');   \n\n      \n   END IF;\n\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BI_BEG_CPG_TITULO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n  -- pragma autonomous_transaction;\n  --\n  CURSOR C1 IS\n    select n.beg_cpg_tipo_titulo_id, n.beg_cpg_conta_id, n.docstatus, n.beg_vw_fornecedor_id\n      from beg_cpr_nfe n\n     where n.beg_cpr_nfe_id = :new.beg_cpr_nfe_id;\n  --\n  R_C1 c1%rowtype;\n  --\n  cursor c2 is\n    select c.ind_obriga_nota\n      from beg_cpg_tipo_titulo c\n     where c.beg_cpg_tipo_titulo_id = :new.beg_cpg_tipo_titulo_id;\n  --\n  r_c2 c2%rowtype;\n  --\n  CURSOR C_CONTR IS\n    SELECT COUNT(1) QTDE\n      FROM DIE_FIN_CONTRATOS C\n     WHERE C.BEG_VW_FORNECEDOR_ID = :NEW.BEG_VW_FORNECEDOR_ID\n       AND C.BEG_CPG_TIPO_TITULO_ID = :NEW.BEG_CPG_TIPO_TITULO_ID\n       AND C.AD_ORG_ID = :NEW.AD_ORG_ID\n       AND C.ISACTIVE = 'Y'\n       AND C.DT_VCTO >= :NEW.DT_RECEBIMENTO\n       AND C.DOCSTATUS = 'CO';\n  R_CONTR C_CONTR%ROWTYPE;\n  --\n\nBEGIN\n  --\n  OPEN C1;\n  FETCH C1\n    INTO R_C1;\n  CLOSE C1;\n  --\n  IF UPDATING AND :NEW.BEG_CPR_NFE_ID IS NOT NULL THEN\n    IF (R_C1.beg_cpg_tipo_titulo_id <> :NEW.BEG_CPG_TIPO_TITULO_ID or\n       R_C1.BEG_CPG_CONTA_ID <> :NEW.BEG_CPG_CONTA_ID) and\n       :new.beg_cpg_conta_id not in (2001403, 2002204, 2002209, 2001405) and\n       R_C1.DOCSTATUS NOT IN ('WC') THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Tipo de Titulo ou conta contabil difere da nota!  ' ||\n                              :NEW.VALUE || '  --   ');\n    END IF;\n    IF :NEW.BEG_VW_FORNECEDOR_ID <> R_C1.BEG_VW_FORNECEDOR_ID  THEN\n      RAISE_APPLICATION_ERROR(-20001,'Fornecedor diferente da nota de entrada, alteração não permitida');\n    END IF;\n  END IF;\n\n  IF INSERTING THEN\n    IF R_C1.beg_cpg_tipo_titulo_id <> :NEW.BEG_CPG_TIPO_TITULO_ID and\n       :new.beg_cpg_conta_id not in (2001403, 2002204, 2002209, 2001405) and\n       R_C1.DOCSTATUS NOT IN ('WC') THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Tipo de Titulo diferente do Tipo Titulo da Capa!  ' ||\n                              :NEW.VALUE || '  ');\n    END IF;\n  \n  END IF;\n  --\n  open c2;\n  fetch c2\n    into r_c2;\n  close c2;\n  --\n  /*if r_c2.ind_obriga_nota = 'Y' AND :NEW.BEG_CPR_NFE_ID IS NULL then\n    RAISE_APPLICATION_ERROR(-20001,'Faltou informar para qual nota pertence esse titulo!');\n  end if;*/\n  --\n\n  /*IF INSERTING THEN\n  \n    OPEN C_CONTR;\n    FETCH C_CONTR\n      INTO R_CONTR;\n    CLOSE C_CONTR;\n  \n    IF NVL(R_CONTR.QTDE, 0) > 0 THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Fornecedor possui contrato ativo para esta filial. Verifique!!.');\n    \n    END IF;\n  \n  END IF;*/\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_CPG_TITULO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que valida o titulo do contas a pagar\n   Modulo.......: CPG - Contas a Pagar\n   Analista.....: Tiago Gabriel\n   Alterac?es:\n   Data        Desenvolvedor  Alterac?o\n   01/09/2006  Tiago Gabriel  Adicionado o comentario.\n   13/09/2006  Aroldo O Krul  Quando o pedido estiver aprovado, permitir a alteracao de atributos\n                              ligados ao Pagamento escritural\n   14/09/2006  Tiago Gabriel  Ajuste na validac?o das alterac?es dos dados referente pagamento\n                              escritural.\n  --------------------------------------------------------------------------------------------------- */\n  VN_VLR_DESCONTO  BEG_CPG_TITULO.VLR_DESCONTO%type;\n  VN_VLR_ACRESCIMO BEG_CPG_TITULO.VLR_MULTA%type;\n  VC_DOCSTATUS     BEG_CPR_NFE.DOCSTATUS%type;\n  vn_teste         varchar2(100);\n  VN_VLR_IMPOSTOS  NUMBER(18,4);\n  --\n  CURSOR C_VALID_LINHA_DIG IS\n    SELECT C.TIPO1\n         , C.TIPO2\n      FROM BEG_CPG_TIPO_TITULO C\n     WHERE C.BEG_CPG_TIPO_TITULO_ID = :NEW.BEG_CPG_TIPO_TITULO_ID;\n  --\n  R_VALID_LINHA_DIG C_VALID_LINHA_DIG%ROWTYPE;\n  --  \n \n\nbegin\n  --\n  vn_teste := :old.dt_recebimento;\n  --\n  --if inserting then \n  \n  --\n  IF :NEW.DT_VCTO <> :OLD.DT_VCTO AND :NEW.INSTR_PAGTO IS NULL AND :NEW.DOCSTATUS = 'WP' THEN\n    RAISE_APPLICATION_ERROR(-20001,'Favor alterar a Instrucao de Pagamento!');      \n  END IF;\n\n  --\n  IF :NEW.DT_VCTO <> :OLD.DT_VCTO AND :NEW.INSTR_PAGTO IN ('PR','PP','C','N') AND :NEW.DT_VCTO_ORIGINAL IS NULL AND :NEW.DOCSTATUS IN ('WP','WC') THEN\n    :NEW.DT_VCTO_ORIGINAL := :OLD.DT_VCTO;    \n  END IF;  \n  \n  ---\n  IF :NEW.COMPETENCIA_INSS IS NOT NULL\n    AND LENGTH(:NEW.COMPETENCIA_INSS)  < 6 THEN\n    --\n    RAISE_APPLICATION_ERROR(-20001,'Competencia INSS tem que ter 6 digitos!');\n  END IF;\n  --\n/*  IF NVL(:NEW.VLR_INSS,0) > 0 OR\n     NVL(:NEW.VLR_OUT_ENT,0) > 0 THEN\n    --\n    VN_VLR_IMPOSTOS := NVL(:NEW.VLR_INSS,0) \n                     + NVL(:NEW.VLR_OUT_ENT,0)\n                  --   + NVL(:NEW.VLR_MULTA,0)\n                  --   + NVL(:NEW.VLR_JUROS,0)\n                  --   + NVL(:NEW.VLR_OUTROS_ACRESCIMOS,0)\n                     - NVL(:NEW.VLR_DESCONTO,0);\n    --\n    IF :NEW.VLR_TITULO <> VN_VLR_IMPOSTOS THEN\n      RAISE_APPLICATION_ERROR(-20001,'Soma dos Valores do INSS + OUTRAS ENTIDADES é diferente do valor do Titulos!');\n    END IF;\n    --\n  END IF;*/\n  --\n  IF UPDATING THEN \n    \n    OPEN C_VALID_LINHA_DIG;\n    FETCH C_VALID_LINHA_DIG INTO R_VALID_LINHA_DIG;\n    CLOSE C_VALID_LINHA_DIG;\n    --\n    IF R_VALID_LINHA_DIG.TIPO1 = 47 AND\n      length(:new.linha_digitavel) <> R_VALID_LINHA_DIG.TIPO1 THEN\n      RAISE_APPLICATION_ERROR(-20001,'Para esse tipo de titulo linha digitavel deve ter 47 casas!');\n    ELSIF R_VALID_LINHA_DIG.TIPO1 = 48 AND\n      length(:new.linha_digitavel) <> R_VALID_LINHA_DIG.TIPO1 THEN\n      RAISE_APPLICATION_ERROR(-20001,'Para esse tipo de titulo linha digitavel deve ter 48 casas!');\n    END IF;\n    --  \n    --if NVL(:new.CODIGO_BARRAS, 'X') = 'X' --is null\n    --  and \n    --   NVL(:new.LINHA_DIGITAVEL, 'X') <> 'X' then\n       if length(:new.linha_digitavel) = 47 then\n         :new.codigo_barras := BEG_PCK_FIN_CPG.FNC_CPG_CODIGO_BARRA(:new.LINHA_DIGITAVEL);\n       ELSE \n         :new.codigo_barras := :NEW.LINHA_DIGITAVEL;\n       end if;\n    -- END IF;\n/*    elsif NVL(:new.LINHA_DIGITAVEL, 'X') = 'X' -- is null\n          and NVL(:new.CODIGO_BARRAS, 'X') <> 'X' then\n      if length(:new.codigo_barras) = 44 then\n        :new.linha_digitavel := BEG_PCK_FIN_CPG.FNC_CPG_LINHA_DIGITAVEL(:new.CODIGO_BARRAS);\n      end if;\n    end if;*/\n    \n    \n    \n    IF R_VALID_LINHA_DIG.TIPO2 = 44 AND\n      length(:new.codigo_barras) <> R_VALID_LINHA_DIG.TIPO2 THEN\n      RAISE_APPLICATION_ERROR(-20001,'Para esse tipo de titulo Cod. Barras deve ter 44 casas!');\n    ELSIF R_VALID_LINHA_DIG.TIPO2 = 48 AND\n      length(:new.codigo_barras) <> R_VALID_LINHA_DIG.TIPO2 THEN\n      RAISE_APPLICATION_ERROR(-20001,'Para esse tipo de titulo Cod. Barras deve ter 48 casas!');\n    END IF;\n    --\n    if  beg_pck_fin_cpg.vb_variavel_pgto_manual = false then\n      --\n      IF length(:new.linha_digitavel) = 47 AND\n        SUBSTR(:new.linha_digitavel,38,10) <> ((:NEW.VLR_TITULO+:NEW.VLR_ENCARGOS+:NEW.VLR_JUROS+nvl(:NEW.VLR_VENDOR,0)-:NEW.VLR_DESCONTO+nvl(:new.vlr_multa,0)) * 100) THEN\n        RAISE_APPLICATION_ERROR(-20001,:NEW.BEG_CPG_TITULO_ID || 'Valor do Titulo difere com valor do Cod Barras!');\n      END IF;\n      --\n    END IF;\n    --    \n  end if;\n  --\n  if INSERTING\n     and :new.DOCSTATUS <> 'WC' then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Somente e possivel incluir titulos aguardando confirmac?o!');\n  end if;\n  \n  -- Verifica filial\n  if NVL(:new.AD_ORG_ID, 0) = 0 then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Deve ser selecionada uma filial para o titulo!');\n  end if;\n  vn_teste := :new.value;\n  -- Verifica o numero\n  if NVL(:new.value, 0) is null then --<= 0 then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Numero deve ser informado e maior que zero!');\n  end if;\n\n  -- Verifica a parcela\n  if NVL(:new.PARCELA, 0) < 0 then\n    RAISE_APPLICATION_ERROR(-20001, 'Parcela n?o pode ser negativa!');\n  else\n    -- Verifica vencimento da entrada\n    if :new.PARCELA = 0 then\n      :new.DT_VCTO := NVL(:new.DT_VCTO, TRUNC(sysdate));\n      if :new.DT_VCTO <> :new.DT_EMISSAO then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Parcela zero e a entrada. Vencimento deve ser igual a emiss?o!');\n      end if;\n    else\n      if :new.DT_VCTO = TRUNC(:new.DT_EMISSAO) and :new.BEG_VEN_FORMA_PAGAMENTO_ID <> 2000005 then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Para a entrada (vencimento igual a emiss?o) a parcela deve ser zero!');\n      end if;\n    end if;\n  end if;\n\n  VN_VLR_DESCONTO  := 0;\n  VN_VLR_ACRESCIMO := 0;\n\n  -- Verifica o valor do titulo\n  if NVL(:new.VLR_TITULO, 0) = 0 then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Titulo sem valor ou com valor zerado!');\n  end if;\n  \n/*  -- Verifica se o valor do titulo não é menos que o valor em aberto\n  IF :NEW.VLR_ABERTO > :NEW.VLR_TITULO THEN\n    RAISE_APPLICATION_ERROR(-20001,'Valor em aberto é maior que valor do Titulo!');\n  END IF;*/\n\n  -- Verifica data de vencimento\n  if :new.DT_VCTO < :new.DT_EMISSAO then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Data de vencimento menor que data de emissão do titulo!');\n  end if;\n\n if :new.DT_VCTO < :new.dt_recebimento then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Data de vcto gerado a partir da emissao da NF, < que data de entrada da NF!');\n  end if;\n\n\n  -- Total de descontos\n  VN_VLR_DESCONTO := :new.VLR_DESCONTO + :new.VLR_OUTRAS_DEDUCOES;\n\n  -- Total de acrescimos\n  VN_VLR_ACRESCIMO := :new.VLR_MULTA + :new.VLR_JUROS +\n                      :new.VLR_OUTROS_ACRESCIMOS;\n\n  -- Valida o desconto\n  vn_teste := :new.VLR_TITULO;\n/*  if VN_VLR_DESCONTO > :new.VLR_TITULO + VN_VLR_ACRESCIMO then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Valor do desconto mais o valor de outras deducões maior que o valor do titulo mais acrescimos!');\n  end if;*/\n\n  if not BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_HIST then\n  \n    -- Testa a alterac?o do docstatus\n    if UPDATING then\n    \n      if :old.DOCSTATUS = :new.DOCSTATUS then\n      \n        -- Se titulo estiver como aprovado, somente altera o portador, e as informac?es da cobranca escritural\n        vn_teste := :old.docstatus;\n/*        if :old.DOCSTATUS = 'WP' then\n          if NVL(:old.BEG_BANCO_ID, 0) = NVL(:new.BEG_BANCO_ID, 0)\n             and NVL(:old.BEG_FIN_PORTADOR_ID, 0) =\n             NVL(:new.BEG_FIN_PORTADOR_ID, 0)\n             and NVL(:old.IND_LOTE_PGTO_ESCRITURAL, '^') =\n             NVL(:new.IND_LOTE_PGTO_ESCRITURAL, '^')\n             and NVL(:old.BEG_PCE_LOTE_PAGAMENTO_ID, 0) =\n             NVL(:new.BEG_PCE_LOTE_PAGAMENTO_ID, 0)\n             and\n             NVL(:old.DT_ENVIO_BCO, TO_DATE('01/01/1500', 'dd/mm/rrrr')) =\n             NVL(:new.DT_ENVIO_BCO, TO_DATE('01/01/1500', 'dd/mm/rrrr'))\n             and NVL(:old.LINHA_DIGITAVEL, '^') =\n             NVL(:new.LINHA_DIGITAVEL, '^')\n             and\n             NVL(:old.CODIGO_BARRAS, '^') = NVL(:new.CODIGO_BARRAS, '^')\n             and NVL(:old.BEG_DADOS_BANCARIOS_ID, 0) =\n             NVL(:new.BEG_DADOS_BANCARIOS_ID, 0) then\n\n            RAISE_APPLICATION_ERROR(-20001,\n                                    'Somente e possivel alterar o portador e dados da cobranca escritural!');\n          end if;\n*/        if :old.DOCSTATUS = 'CA' then\n          RAISE_APPLICATION_ERROR(-20001, 'Titulo encontra-se cancelado!');\n        end if;\n      end if;\n    end if;\n   \n  end if;\n  --\n  if :new.vlr_aberto > 0 then\n    :new.docstatus := 'WP';\n    :new.dt_pgto   := null;\n  end if;\n  --\n  -- Tiago Gabriel em 12/07/2006\n  -- Adicionada a verificac?o do status da NFE\n  if UPDATING\n     and :new.DOCSTATUS <> :old.DOCSTATUS\n     and :new.BEG_CPR_NFE_ID is not null then\n    begin\n    select DOCSTATUS\n      into VC_DOCSTATUS\n      from BEG_CPR_NFE\n     where BEG_CPR_NFE_ID = :new.BEG_CPR_NFE_ID;\n      if VC_DOCSTATUS in ('WC', 'CA') then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Nota fiscal de entrada vinculada ao titulo ainda esta em digitacao! '||:new.value||'-');\n      end if;\n    exception\n      when no_data_found then \n          null;\n    end;\n  end if;\n\nend BEG_TRG_BIU_CPG_TITULO;\n"}`;
    
    }
}
