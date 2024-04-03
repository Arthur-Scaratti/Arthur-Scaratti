
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_HISTORICO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TIPO_DOCUMENTO_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_APROVACAO { get; set; }
        
        /// <summary>
        /// id do titulo no lote q foi pago 
        /// </summary>
        public int BEG_CPG_PGTO_MANUAL_DEBITO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PCE_LOTE_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_PGTO_MANUAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TARIFA_DOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VENDOR { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do historico
        /// </summary>
        public int BEG_CPG_HISTORICO_ID { get; set; }
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
        /// <summary>
        /// Valor do movimento
        /// </summary>
        public int VLR_MOVIMENTO { get; set; }
            [Required]
        /// <summary>
        /// Valor efetivo calculados descontos e acrescimos
        /// </summary>
        public int VLR_EFETIVO { get; set; }
            [Required]
        /// <summary>
        /// Valor do desconto / abatimento do historico
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// Valor de outras deduc?es do historico
        /// </summary>
        public int VLR_OUTRAS_DEDUCOES { get; set; }
            [Required]
        /// <summary>
        /// Valor de multa / mora do historico
        /// </summary>
        public int VLR_MULTA { get; set; }
            [Required]
        /// <summary>
        /// Valor de juros do historico
        /// </summary>
        public int VLR_JUROS { get; set; }
            [Required]
        /// <summary>
        /// Valor de outros acrescimos do historico
        /// </summary>
        public int VLR_OUTROS_ACRESCIMOS { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Observac?o do historico
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// ID do tipo de movimento
        /// </summary>
        public int BEG_CPG_TPMOV_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do titulo
        /// </summary>
        public int BEG_CPG_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// Data efetiva do movimento
        /// </summary>
        public string DT_MOVIMENTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Numero do documento do movimento
        /// </summary>
        public string DOCUMENTO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_CPG_HISTORICO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  --\n  cursor C_FECH_CONT is\n  select MAX(C.DT_FINAL) DT_FINAL\n    from BEG_FECH_CONTABIL C\n   WHERE C.IND_ESCRITA = 'N';\n  --\n  R_FECH_CONT C_FECH_CONT%rowtype;\n  --\n  cursor C_FECH_CONT1 is\n  select ind_escrita from BEG_FECH_CONTABIL C where c.dt_final = R_FECH_CONT.DT_FINAL;\n  --\n  R_FECH_CONT1 C_FECH_CONT1%rowtype;\n\nbegin\n\n /*  -- N?o permite atualizac?o ou exclus?o do historico.\n  if UPDATING or DELETING then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Somente e possivel incluir historicos!');\n  end if;\n*/\n  --\n  OPEN C_FECH_CONT;\n  FETCH C_FECH_CONT INTO R_FECH_CONT;\n  CLOSE C_FECH_CONT;\n  --\n  open C_FECH_CONT1;\n  fetch C_FECH_CONT1\n    into R_FECH_CONT1;\n  close C_FECH_CONT1;\n  --\n  IF :NEW.DT_MOVIMENTO <= R_FECH_CONT.DT_FINAL AND :NEW.BEG_CPG_TPMOV_ID NOT IN (2000000,2000011,2000005) THEN\n  --  if nvl(r_FECH_CONT1.ind_escrita,'N') ='N' then\n      RAISE_APPLICATION_ERROR(-20001,'Não pode deletar, alterar ou inserir registro quando fechamentos contabil está fechado!');\n  --  END IF;\n  END IF;\n  --\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CPG_HISTORICO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  /*----------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que valida o historico incluido para um titulo.\n  Modulo.......: CPR - Compras\n  Analista.....: Tiago Gabriel\n  Parametro(s).: -> p_instance_id: ID da instancia do compiere\n  Alterac?es:\n  Data        Desenvolvedor   Alterac?o\n  06/06/2006  Tiago Gabriel   Criac?o.\n  22/06/2006  Aroldo O. Krul  Quando ocorre o erro de 20008 - inserido o numero do titulo.\n  26/06/2006  Aroldo O. Krul  Desabilitado teste de valor desconto (na carga dos titulos\n                              (nacional) houve desonto > que o valor do titulo.\n  03/07/2006  Tiago Gabriel   Alterada a forma como os valores são processados para ficar\n                              da mesma forma como no contas a receber (CRC).\n  12/07/2006  Tiago Gabriel   Atualiza o status da nota de entrada quando todos os titulos\n                              forem pagos.\n  07/10/2006  Tiago Gabriel   Adicionada validacão para não permitir exclusão de historicos.\n  23/11/2006  Tiago Gabriel   Corrigido o calculo do valor efetivo do movimento.\n  ----------------------------------------------------------------------------------------*/\n  VN_VLR_TITULO             BEG_CPG_TITULO.VLR_TITULO%type;\n  VN_VLR_ABERTO             BEG_CPG_TITULO.VLR_ABERTO%type;\n  VC_DOCSTATUS_TIT          BEG_CPG_TITULO.DOCSTATUS%type;\n  VC_DTENT                  BEG_CPG_TITULO.DT_RECEBIMENTO%type;\n  VN_BEG_CPG_TPMOV_ID       BEG_CPG_TPMOV.BEG_CPG_TPMOV_ID%type;\n  VC_DC_TITULO              BEG_CPG_TPMOV.DEBITO_CREDITO%type;\n  VC_DC_HIST                BEG_CPG_TPMOV.DEBITO_CREDITO%type;\n  VC_IND_MOV                BEG_CPG_TPMOV.IND_MOV%type;\n  VN_VLR_DESCONTO           BEG_CPG_HISTORICO.VLR_DESCONTO%type;\n  VN_VLR_ACRESCIMO          BEG_CPG_HISTORICO.VLR_MULTA%type;\n  VN_VLR_LIQ_MVTO           BEG_CPG_HISTORICO.VLR_MOVIMENTO%type;\n  VN_TIT                    BEG_CPG_TITULO.VALUE%type;\n  VN_PARC_TIT               BEG_CPG_TITULO.PARCELA%type;\n  VN_FORNECEDOR             BEG_CPG_TITULO.BEG_VW_FORNECEDOR_ID%type;\n  VN_BEG_CPR_NFE_ID         BEG_CPG_TITULO.BEG_CPR_NFE_ID%type;\n  VN_QTD_TITULOS            number;\n  VN_QTD_TITULOS_QUITADOS   number;\n  VN_BEG_CPG_TIPO_TITULO_ID number(10);\n  TESTE                     number(18, 4);\n  t_teste                   varchar2(50);\n  --VN_VLR_TITULO             NUMBER(1\n  --\n  cursor C1 is\n    select T.AD_ORG_ID, T.TARIFA_DOC\n      from BEG_CPG_TITULO T\n     where T.BEG_CPG_TITULO_ID = :NEW.BEG_CPG_TITULO_ID;\n  --\nbegin\n /* -- N?o permite atualizac?o ou exclus?o do historico.\n  if UPDATING or DELETING then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Somente e possivel incluir historicos!');\n  end if;*/\n  --\n  :NEW.OBS := BEG_PCK_UTIL.CONVERTE_ACENTOS(:NEW.OBS);\n  --\n  IF NVL(:NEW.TARIFA_DOC, 0) = 0 THEN\n    --\n    open C1;\n    fetch C1\n      into :NEW.BEG_FILIAL_ID, :NEW.TARIFA_DOC;\n    close C1;\n    --\n  END IF;\n  --\n  -- Verifica o status do titulo para permitir movimentac?o\n  select TIT.VALUE,\n         TIT.PARCELA,\n         TIT.BEG_VW_FORNECEDOR_ID,\n         TIT.VLR_TITULO,\n         TIT.VLR_ABERTO,\n         TIT.DOCSTATUS,\n         TP_TIT.BEG_CPG_TPMOV_ID,\n         TP_TIT.DEBITO_CREDITO,\n         TP_TIT.BEG_CPG_TIPO_TITULO_ID,\n         TIT.DT_RECEBIMENTO\n    into VN_TIT,\n         VN_PARC_TIT,\n         VN_FORNECEDOR,\n         VN_VLR_TITULO,\n         VN_VLR_ABERTO,\n         VC_DOCSTATUS_TIT,\n         VN_BEG_CPG_TPMOV_ID,\n         VC_DC_TITULO,\n         VN_BEG_CPG_TIPO_TITULO_ID,\n         VC_DTENT\n    from BEG_CPG_TITULO TIT, BEG_CPG_TIPO_TITULO TP_TIT\n   where TIT.BEG_CPG_TIPO_TITULO_ID = TP_TIT.BEG_CPG_TIPO_TITULO_ID\n     and TIT.BEG_CPG_TITULO_ID = :NEW.BEG_CPG_TITULO_ID;\n\n --  Data de baixa não pode ser menor que data recebimento\n \n if trunc(:NEW.DT_MOVIMENTO) < VC_DTENT and :new.beg_cpg_tpmov_id not in (2000011,2000005,2000000) THEN\n   RAISE_APPLICATION_ERROR(-20001,\n                              'Data de pagamento não pode ser menor que data de entrada! id: ' ||:new.beg_cpg_titulo_id|| '  ' );\n \n END IF;\n\n\n\n\n  -- Titulo ainda não liberado\n  if VC_DOCSTATUS_TIT = 'WC' then\n  \n    if :NEW.BEG_CPG_TPMOV_ID <> VN_BEG_CPG_TPMOV_ID then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Titulo ainda não liberado para movimentacão!');\n    end if;\n  elsif VC_DOCSTATUS_TIT = 'PA' and\n        :NEW.BEG_CPG_TPMOV_ID = VN_BEG_CPG_TIPO_TITULO_ID then\n    RAISE_APPLICATION_ERROR(-20002, 'Titulo pago (liquidado)!');\n  elsif VC_DOCSTATUS_TIT = 'CA' then\n    RAISE_APPLICATION_ERROR(-20002, 'Titulo cancelado!');\n  end if;\n\n  -- Verifica filial\n  /*  if :new.AD_ORG_ID = 0 then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Deve ser selecionada uma filial para o titulo!');\n  end if;*/\n\n  -- Total de descontos\n  VN_VLR_DESCONTO := :NEW.VLR_DESCONTO + :NEW.VLR_OUTRAS_DEDUCOES;\n\n  -- Total de acrescimos\n  VN_VLR_ACRESCIMO := :NEW.VLR_MULTA + :NEW.VLR_JUROS +\n                      :NEW.VLR_OUTROS_ACRESCIMOS;\n  TESTE            := NVL(:NEW.VLR_MOVIMENTO, 0);\n  -- Valida valores\n  if NVL(:NEW.VLR_MOVIMENTO, 0) <= 0 then\n    RAISE_APPLICATION_ERROR(-20003,\n                            'Movimento com valor zerado ou negativo!');\n  end if;\n\n  if VN_VLR_DESCONTO < 0 then\n    RAISE_APPLICATION_ERROR(-20003,\n                            'Titulo com valor de desconto negativo!');\n  end if;\n\n  if VN_VLR_ACRESCIMO < 0 then\n    RAISE_APPLICATION_ERROR(-20003,\n                            'Titulo com valor de acrescimo negativo!');\n  end if;\n\n  -- Valida o desconto\n  -- AOK  - 26/06/2006\n  -- Tiago Gabriel em 12/08/2006\n  -- Retirado comentario.\n  TESTE := :NEW.VLR_MOVIMENTO;\n/*  if VN_VLR_DESCONTO > :NEW.VLR_MOVIMENTO + VN_VLR_ACRESCIMO then\n    RAISE_APPLICATION_ERROR(-20004,\n                            'Valor do desconto mais o valor de outras deduc?es maior que o valor do movimento mais acrescimos!    ' ||\n                            :NEW.BEG_CPG_TITULO_ID);\n  end if;*/\n\n  -- Busca o indicativo de debito ou credito do movimento\n  begin\n    --\n    t_teste := :NEW.BEG_CPG_TPMOV_ID;\n    --\n    select DEBITO_CREDITO, IND_MOV\n      into VC_DC_HIST, VC_IND_MOV\n      from BEG_CPG_TPMOV\n     where BEG_CPG_TPMOV_ID = :NEW.BEG_CPG_TPMOV_ID;\n  \n  exception\n    when NO_DATA_FOUND then\n      RAISE_APPLICATION_ERROR(-20001, 'Tipo de movimento nao encontrado! '|| :NEW.BEG_CPG_TITULO_ID);\n    \n  end;\n\n  -- Valor liquido do movimento\n  if VC_DC_HIST = 'C' then\n    VN_VLR_LIQ_MVTO := :NEW.VLR_MOVIMENTO + VN_VLR_ACRESCIMO -\n                       VN_VLR_DESCONTO;\n  else\n    -- Valor liquido do movimento\n    VN_VLR_LIQ_MVTO := :NEW.VLR_MOVIMENTO + VN_VLR_DESCONTO -\n                       VN_VLR_ACRESCIMO;\n  end if;\n\n  -- Se e a inclus?o do titulo, inicializa o valor em aberto com o valor do titulo\n  if :NEW.BEG_CPG_TPMOV_ID = VN_BEG_CPG_TPMOV_ID then\n    VN_VLR_ABERTO := VN_VLR_TITULO;\n  end if;\n  \n  -- no processo de  baixa do lote de Adiantamento/Devolucao, quando ocorrer tentar ajuste por aqui ou usar o\n--  processo beg_prc_cpg_dev no ID colocar o nr que aparece na mensagem do compiere.\n\n  TESTE := :NEW.VLR_MOVIMENTO;\n  if VC_IND_MOV <> 'T' and VN_VLR_TITULO = VN_VLR_ABERTO and\n     :NEW.VLR_MOVIMENTO = VN_VLR_ABERTO then\n    RAISE_APPLICATION_ERROR(-20005,\n                            'Movimento deve ser total. ' ||\n                            :new.beg_cpg_titulo_id);\n  end if;\n  \n/* if VC_IND_MOV <> 'L' and VN_VLR_TITULO <> VN_VLR_ABERTO and\n   :NEW.VLR_MOVIMENTO = VN_VLR_ABERTO then\n  RAISE_APPLICATION_ERROR(-20006, 'Movimento deve ser de liquidacao! ' ||\n                          :new.beg_cpg_titulo_id);\nend if;*/\n\n  if VC_IND_MOV <> 'P' and VN_VLR_TITULO <> VN_VLR_ABERTO and\n     :NEW.VLR_MOVIMENTO <> VN_VLR_ABERTO and\n     :NEW.BEG_CPG_TPMOV_ID = VN_BEG_CPG_TIPO_TITULO_ID then\n    RAISE_APPLICATION_ERROR(-20007, 'Movimento deve ser parcial. ');\n  end if;\n\n  -- Somente atualiza o valor em aberto se n?o for inclus?o de titulo\n  if :NEW.BEG_CPG_TPMOV_ID <> VN_BEG_CPG_TPMOV_ID then\n    -- Se o titulo e o historico sao de tipos (debito e credito) iguais, simplesmente soma o valor em aberto\n    if VC_DC_TITULO = VC_DC_HIST then\n      VN_VLR_ABERTO := VN_VLR_ABERTO + :NEW.VLR_MOVIMENTO;\n    \n      -- Caso contrario\n    else\n      -- Valida o valor liquido do movimento\n      TESTE := :NEW.VLR_MOVIMENTO;\n      if :NEW.VLR_MOVIMENTO > VN_VLR_ABERTO then\n        RAISE_APPLICATION_ERROR(-20008,\n                                'Valor liquido do movimento maior que o valor em aberto do titulo! (' ||\n                                VN_TIT || '/' || VN_PARC_TIT || ' ' ||\n                                VN_FORNECEDOR);\n      end if;\n      VN_VLR_ABERTO := VN_VLR_ABERTO - :NEW.VLR_MOVIMENTO;\n    end if;\n  end if;\n\n  -- Atualiza o valor em aberto. Liquida o titulo caso o valor em aberto seja zero.\n  BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_HIST := true;\n  --\n  TESTE := :new.tarifa_doc;\n  --\n  update BEG_CPG_TITULO C\n     set UPDATED      = :NEW.UPDATED,\n         UPDATEDBY    = :NEW.UPDATEDBY,\n         VLR_ABERTO   = VN_VLR_ABERTO, --+ :NEW.VLR_JUROS,\n         VLR_DESCONTO = case\n                          when :new.beg_cpg_tpmov_id in (2000015, 2000016) then\n                           VLR_DESCONTO - :NEW.VLR_DESCONTO\n                          else\n                           VLR_DESCONTO + :NEW.VLR_DESCONTO\n                        end,\n         /*TARIFA_DOC          = case\n         when :new.beg_cpg_tpmov_id in (2000015,2000016) then\n          TARIFA_DOC - NVL(:NEW.TARIFA_DOC,0)\n         else \n          TARIFA_DOC + NVL(:NEW.TARIFA_DOC,0)\n         end*/\n         TARIFA_DOC = case\n                        when :new.beg_cpg_tpmov_id in (2000015, 2000016) then\n                         nvl(TARIFA_DOC,0) - NVL(:NEW.TARIFA_DOC, 0)\n                        else\n                         case\n                           when nvl(tarifa_doc, 0) <> NVL(:NEW.TARIFA_DOC, 0) then\n                            nvl(TARIFA_DOC,0) + NVL(:NEW.TARIFA_DOC, 0)\n                           else\n                            NVL(:NEW.TARIFA_DOC, 0)\n                         end\n                      end,\n         --VLR_DESCONTO + :NEW.VLR_DESCONTO,\n         VLR_OUTRAS_DEDUCOES = VLR_OUTRAS_DEDUCOES +\n                               :NEW.VLR_OUTRAS_DEDUCOES,\n         VLR_MULTA           = VLR_MULTA + NVL(:NEW.VLR_MULTA, 0),\n         VLR_JUROS = case\n                       when :new.beg_cpg_tpmov_id in (2000015, 2000016) then\n                        VLR_JUROS - :NEW.VLR_JUROS\n                       else\n                        VLR_JUROS + :NEW.VLR_JUROS\n                     end,\n         --VLR_JUROS + NVL(:new.VLR_JUROS,0),\n         VLR_OUTROS_ACRESCIMOS = VLR_OUTROS_ACRESCIMOS +\n                                 :NEW.VLR_OUTROS_ACRESCIMOS,\n         DOCSTATUS             = DECODE(VN_VLR_ABERTO, 0, 'PA', DOCSTATUS),\n         DT_PGTO               = DECODE(VN_VLR_ABERTO,\n                                        0,\n                                        TRUNC(:NEW.DT_MOVIMENTO),\n                                        DT_PGTO)\n   where BEG_CPG_TITULO_ID = :NEW.BEG_CPG_TITULO_ID\n     and C.DOCSTATUS <> 'WC';\n  --  \n  TESTE := VN_VLR_ABERTO + :NEW.TARIFA_DOC + :NEW.VLR_JUROS +\n           :NEW.VLR_OUTROS_ACRESCIMOS + :NEW.VLR_MULTA - :NEW.VLR_DESCONTO;\n  update BEG_CPG_TITULO C\n     set UPDATED    = :NEW.UPDATED,\n         UPDATEDBY  = :NEW.UPDATEDBY,\n         VLR_ABERTO = VN_VLR_ABERTO + NVL(:NEW.TARIFA_DOC, 0) +\n                      NVL(:NEW.VLR_JUROS, 0) +\n                      NVL(:NEW.VLR_OUTROS_ACRESCIMOS, 0) +\n                      NVL(:NEW.VLR_MULTA, 0) - NVL(:NEW.VLR_DESCONTO, 0) +\n                      NVL(:NEW.VLR_VENDOR, 0),\n         --VLR_DESCONTO          = VLR_DESCONTO + :new.VLR_DESCONTO,\n         --VLR_OUTRAS_DEDUCOES   = VLR_OUTRAS_DEDUCOES +\n         --                        :new.VLR_OUTRAS_DEDUCOES,\n         --VLR_MULTA             = VLR_MULTA + :new.VLR_MULTA,\n         --VLR_JUROS             = VLR_JUROS + :new.VLR_JUROS,\n         --VLR_OUTROS_ACRESCIMOS = VLR_OUTROS_ACRESCIMOS +\n         --                        :new.VLR_OUTROS_ACRESCIMOS,\n         DOCSTATUS = DECODE(VN_VLR_ABERTO, 0, 'PA', DOCSTATUS),\n         DT_PGTO   = DECODE(VN_VLR_ABERTO,\n                            0,\n                            TRUNC(:NEW.DT_MOVIMENTO),\n                            DT_PGTO)\n   where BEG_CPG_TITULO_ID = :NEW.BEG_CPG_TITULO_ID\n     and C.DOCSTATUS = 'WC';\n  -- Atualiza o status da nota de entrada\n  -- Busca a nota do titulo corrente\n  select BEG_CPR_NFE_ID\n    into VN_BEG_CPR_NFE_ID\n    from BEG_CPG_TITULO\n   where BEG_CPG_TITULO_ID = :NEW.BEG_CPG_TITULO_ID;\n\n  if VN_BEG_CPR_NFE_ID is not null then\n  \n    -- Busca quantidade de titulos da nota corrente\n    select count(1)\n      into VN_QTD_TITULOS\n      from BEG_CPG_TITULO\n     where BEG_CPR_NFE_ID = VN_BEG_CPR_NFE_ID;\n  \n    -- Busca quantidade de titulos pagos da nota corrente\n    select count(1)\n      into VN_QTD_TITULOS_QUITADOS\n      from BEG_CPG_TITULO\n     where BEG_CPR_NFE_ID = VN_BEG_CPR_NFE_ID\n       and DOCSTATUS = 'PA';\n  \n    update BEG_CPR_NFE\n       set DOCSTATUS = DECODE(VN_QTD_TITULOS,\n                              VN_QTD_TITULOS_QUITADOS,\n                              'PA',\n                              'WP')\n     where DOCSTATUS <>\n           DECODE(VN_QTD_TITULOS, VN_QTD_TITULOS_QUITADOS, 'PA', 'WP')\n       and BEG_CPR_NFE_ID = VN_BEG_CPR_NFE_ID;\n  \n  end if;\n\n  BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_HIST := false;\n\n  -- Atualiza o valor efetivo do movimento\n  :NEW.VLR_EFETIVO := VN_VLR_LIQ_MVTO;\n\nend BEG_TRG_BIUD_CPG_HISTORICO;\n"}`;
    
    }
}
