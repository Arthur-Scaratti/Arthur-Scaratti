
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CARTAO_CR_HISTORICO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_CR_HISTORICO_ID { get; set; }
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
        /// 
        /// </summary>
        public string DT_PAGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_CR_CONC_ID { get; set; }
            [Required]
        /// <summary>
        /// V ALOR DA FATURA
        /// </summary>
        public int VLR_PARCELA { get; set; }
            [Required]
        /// <summary>
        /// VLR EFETIVAMENTE PAGO
        /// </summary>
        public int VLR_PAGO { get; set; }
            [Required]
        /// <summary>
        /// REEMBOLSO PARA A CR DOS JUROS DE ATRASO COBRADAS DO CLIENTE
        /// </summary>
        public int VLR_JUROS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [StringLength(300)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TPMOV_ID { get; set; }
            [Required]
        /// <summary>
        /// REEMBOLSO PARA A CR DA MULTA  COBRADAS DO CLIENTE
        /// </summary>
        public int VLR_MULTA { get; set; }
            [Required]
        /// <summary>
        /// REEMBOLSO PARA A CR DAS TAXAS COBRADAS DO CLIENTE
        /// </summary>
        public int VLR_TAXAS { get; set; }
        
        /// <summary>
        /// PAGO PELO CLIENTE
        /// </summary>
        public int VLR_PAGTO_ORIGINAL { get; set; }
        
        /// <summary>
        /// PAGO PELO CLIENTE
        /// </summary>
        public int VLR_JUROS_ORIGINAL { get; set; }
        
        /// <summary>
        /// PAGO PELO CLIENTE
        /// </summary>
        public int VLR_MULTA_ORIGINAL { get; set; }
        
        /// <summary>
        /// PAGO PELO CLIENTE
        /// </summary>
        public int VLR_TAXAS_ORIGINAL { get; set; }
        
        /// <summary>
        /// PAGO PELO CLIENTE
        /// </summary>
        public int VLR_JUROS_EMPR_ORIGINAL { get; set; }
        
        /// <summary>
        /// REEMBOLSO PARA A CR JUROS EMPRESTIMO PAGO PELO CLIENTE
        /// </summary>
        public int VLR_JUROS_EMPR { get; set; }
        
        /// <summary>
        /// PAGO PELO CLIENTE
        /// </summary>
        public int VLR_JUROS_VENDA_ORIGINAL { get; set; }
        
        /// <summary>
        /// REEMBOLSO PARA A CR DOS JUROS PARC. ADM PAGO PELO CLIENTE
        /// </summary>
        public int VLR_JUROS_VENDA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_CR_FATURA_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_CAR_HISTORICOS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  VN_CONT number := 0;\n  --\n  cursor BUSCA_TP_MOV is\n    select A.DEBITO_CREDITO,\n           A.CALCULA_JUROS,\n           A.TP_PGTO,\n           NVL(A.REFLEXO_COMISSAO, 'L') REFLEXO_COMISSAO\n      from BEG_CRC_TPMOV A\n     where BEG_CRC_TPMOV_ID = :new.BEG_CRC_TPMOV_ID;\n  --\n  VREG1 BUSCA_TP_MOV%rowtype;\n  --\n  cursor BUSCA_TITULO(Pdie_cartao_cr_fatura_ID number) is\n    SELECT B.VLR_ABERTO,\n           b.ad_org_id,\n           B.Vlr_Fatura   vlr_titulo,\n           B.VLR_MULTA,\n           B.VLR_JUROS,\n           B.VLR_DESCONTO,\n           B.Dt_Vcto      TITULO\n      from die_cartao_cr_fatura B\n     where B.Die_Cartao_Cr_Fatura_Id = Pdie_cartao_cr_fatura_ID;\n  --\n  VREG2 BUSCA_TITULO%rowtype;\n  --\n\nbegin\n  --\n  VN_CONT := 0; -- aok -- 03/07/2007\n\n  if inserting then\n    --\n    --\n    --open BUSCA_TITULO; -- AOK - 14/01/2009\n    open BUSCA_TITULO(:new.die_cartao_cr_fatura_id);\n    fetch BUSCA_TITULO\n      into VREG2;\n    CLOSE BUSCA_TITULO;\n    :new.ad_org_id := vreg2.ad_org_id;\n  \n    --\n    open BUSCA_TP_MOV;\n    fetch BUSCA_TP_MOV\n      into VREG1;\n    close BUSCA_TP_MOV;\n    --\n  /*  if :new.vlr_pago <= 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Valor do movimento deve ser maior que zero.');\n    end if;*/\n    if :new.VLR_MULTA < 0 then\n      RAISE_APPLICATION_ERROR(-20001, 'Valor da multa invalido.');\n    end if;\n    if :new.VLR_JUROS < 0 then\n      RAISE_APPLICATION_ERROR(-20002, 'Valor do juro invalido.');\n    end if;\n    if :new.VLR_DESCONTO < 0 then\n      RAISE_APPLICATION_ERROR(-20003, 'Valor do desconto invalido.');\n    end if;\n    if VREG1.TP_PGTO <> 'E' then\n      -- Emissao de titulo\n      --if VREG2.DEBITO_CREDITO = 'D' then\n      if VREG1.TP_PGTO = 'T' -- Baixa total\n       then\n        if VREG1.DEBITO_CREDITO = 'D' then\n          RAISE_APPLICATION_ERROR(-20004,\n                                  'Tipo de movimento de baixa invalido para este tipo de titulo.' ||\n                                  VREG2.TITULO);\n        else\n          if VREG2.VLR_TITULO <> VREG2.VLR_ABERTO then\n            RAISE_APPLICATION_ERROR(-20005,\n                                    'Titulo ja possui pagamentos tipo de movimento invalido para esta baixa, efetue uma baixa por saldo.' ||\n                                    VREG2.TITULO || ' - ' ||\n                                    TO_CHAR(VREG2.VLR_TITULO,\n                                            'fm99999g990d00'));\n          end if;\n          if VREG2.VLR_ABERTO <> :new.vlr_pago then\n            RAISE_APPLICATION_ERROR(-20006,\n                                    'Valor do movimento difere do valor em aberto ' ||\n                                    VREG2.VLR_ABERTO ||\n                                    ' para este titulo.' || VREG2.TITULO);\n          end if;\n          if :new.VLR_PAGO > VREG2.VLR_ABERTO then\n            RAISE_APPLICATION_ERROR(-20007,\n                                    'Valor do movimento maior que o valor em aberto para o titulo.' ||\n                                    VREG2.TITULO);\n          end if;\n        end if;\n      elsif VREG1.TP_PGTO = 'P' -- Baixa parcial\n       then\n        if VREG1.DEBITO_CREDITO = 'D' then\n          RAISE_APPLICATION_ERROR(-20008,\n                                  'Tipo de movimento de baixa invalido para este tipo de titulo.' ||\n                                  VREG2.TITULO);\n        else\n          if VREG2.VLR_ABERTO = :new.VLR_PAGO then\n            RAISE_APPLICATION_ERROR(-20009,\n                                    'Valor do movimento igual ao valor em aberto ' ||\n                                    VREG2.VLR_ABERTO ||\n                                    ' para este titulo.' || VREG2.TITULO);\n          end if;\n          if :new.VLR_PAGO > VREG2.VLR_ABERTO then\n            RAISE_APPLICATION_ERROR(-20010,\n                                    'Valor do movimento maior que o valor em aberto para o titulo.' ||\n                                    VREG2.TITULO);\n          end if;\n        end if;\n      elsif VREG1.TP_PGTO = 'S' then\n        if VREG1.DEBITO_CREDITO = 'D' then\n          RAISE_APPLICATION_ERROR(-20011,\n                                  'Tipo de movimento de baixa invalido para este tipo de titulo.' ||\n                                  VREG2.TITULO);\n        else\n          if VREG2.VLR_TITULO = VREG2.VLR_ABERTO then\n            RAISE_APPLICATION_ERROR(-20012,\n                                    'Nao houve pagamentos para este titulo, efetue baixa parcial ou total.' ||\n                                    VREG2.TITULO);\n          end if;\n          if VREG2.VLR_ABERTO <> :new.VLR_PAGO then\n            RAISE_APPLICATION_ERROR(-20013,\n                                    'Valor do movimento deve ser igual ao valor em  aberto ' ||\n                                    VREG2.VLR_ABERTO || ' para este titulo' ||\n                                    VREG2.TITULO);\n          end if;\n          if :new.VLR_PAGO > VREG2.VLR_ABERTO then\n            RAISE_APPLICATION_ERROR(-20014,\n                                    'Valor do movimento maior que o valor em aberto para o titulo.' ||\n                                    VREG2.TITULO);\n          end if;\n        end if;\n      elsif VREG1.TP_PGTO = 'R' -- Estorno total\n       then\n        if VREG1.DEBITO_CREDITO = 'C' then\n          RAISE_APPLICATION_ERROR(-20015,\n                                  'Tipo de movimento de baixa invalido para este tipo de titulo.' ||\n                                  VREG2.TITULO);\n        else\n          if (VREG2.VLR_TITULO - VREG2.VLR_ABERTO) <> :new.VLR_PAGO then\n            RAISE_APPLICATION_ERROR(-20016,\n                                    'Valor do movimento deve ser igual ao valor ja pago ' ||\n                                    (VREG2.VLR_TITULO - VREG2.VLR_ABERTO) ||\n                                    ' para este titulo, estorno invalido.' ||\n                                    VREG2.TITULO);\n          end if;\n          if :new.VLR_MULTA <> VREG2.VLR_MULTA then\n            RAISE_APPLICATION_ERROR(-20017,\n                                    'Valor da multa deve ser igual ao valor ja pago de multa.' ||\n                                    VREG2.TITULO);\n          end if;\n          if :new.VLR_JUROS <> VREG2.VLR_JUROS then\n            RAISE_APPLICATION_ERROR(-20018,\n                                    'Valor dos juros deve ser igual ao valor ja pago de juros.' ||\n                                    VREG2.TITULO);\n          end if;\n          if :new.VLR_DESCONTO <> VREG2.VLR_DESCONTO then\n            RAISE_APPLICATION_ERROR(-20019,\n                                    'Valor do desconto deve ser igual ao valor ja dado de desconto.' ||\n                                    VREG2.TITULO);\n          end if;\n        end if;\n      elsif VREG1.TP_PGTO = 'O' -- Estorno Parcial\n       then\n        if VREG1.DEBITO_CREDITO = 'C' then\n          RAISE_APPLICATION_ERROR(-20020,\n                                  'Tipo de movimento de baixa invalido para este tipo de titulo.' ||\n                                  VREG2.TITULO);\n        else\n          -- AOK  - 27/09/2006 - Alterado o sinal de maior para menor\n          if (VREG2.VLR_TITULO - VREG2.VLR_ABERTO) < :new.VLR_PAGO then\n            RAISE_APPLICATION_ERROR(-20021,\n                                    'Valor do movimento deve ser menor que o valor ja pago ' ||\n                                    (VREG2.VLR_TITULO - VREG2.VLR_ABERTO) ||\n                                    ' para este titulo, estorno invalido.' ||\n                                    VREG2.TITULO);\n          end if;\n        end if;\n      end if;\n      if VREG1.TP_PGTO in ('P', 'T', 'S') then\n        -- Pagto parcial, total ou por \n      \n        if VREG1.TP_PGTO in ('T', 'S') then\n          update DIE_CARTAO_CR_FATURA C\n             set C.VLR_ABERTO   = C.VLR_ABERTO - :new.VLR_PAGO,\n                 C.VLR_MULTA    = C.VLR_MULTA + :new.VLR_MULTA,\n                 C.VLR_JUROS    = C.VLR_JUROS + :new.VLR_JUROS,\n                 C.VLR_DESCONTO = C.VLR_DESCONTO + :new.VLR_DESCONTO,\n                 C.VLR_TAXAS    = C.VLR_TAXAS + :NEW.VLR_TAXAS,\n                 c.dt_pagto     = :new.dt_pagto\n           where C.DIE_CARTAO_CR_FATURA_ID = :new.DIE_CARTAO_CR_FATURA_ID;\n        else\n          update DIE_CARTAO_CR_FATURA C\n             set C.VLR_ABERTO   = C.VLR_ABERTO - :new.VLR_PAGO,\n                 C.VLR_MULTA    = C.VLR_MULTA + :new.VLR_MULTA,\n                 C.VLR_JUROS    = C.VLR_JUROS + :new.VLR_JUROS,\n                 C.VLR_DESCONTO = C.VLR_DESCONTO + :new.VLR_DESCONTO,\n                 C.VLR_TAXAS    = C.VLR_TAXAS + :NEW.VLR_TAXAS\n           where C.DIE_CARTAO_CR_FATURA_ID = :new.DIE_CARTAO_CR_FATURA_ID;\n        end if;\n      \n        ----------------------------------------------------\n      else\n        update die_cartao_cr_fatura C\n           set C.VLR_ABERTO   = C.VLR_ABERTO + :new.VLR_PAGO,\n               C.VLR_MULTA    = C.VLR_MULTA - :new.VLR_MULTA,\n               C.VLR_JUROS    = C.VLR_JUROS - :new.VLR_JUROS,\n               C.VLR_DESCONTO = C.VLR_DESCONTO - :new.VLR_DESCONTO,\n               C.VLR_TAXAS    = C.VLR_TAXAS - :NEW.VLR_TAXAS,               \n               c.dt_pagto     = null\n         where C.die_cartao_cr_fatura_ID = :new.die_cartao_cr_fatura_ID;\n        ----------------------------------------------------\n      end if;\n      /*        --\n              -- AOK - 27/04/2006 - Assinala que o titulo foi renegociado qdo este estiver em cobranca\n              -- AOK -- 19/03/2008 - Procedimento foi alterado e passado para a trigger die_trg_bu_crc_historico\n              if VREG1.TP_PGTO in ('R') then\n                update BEG_TITULO_COBRADOR TC\n                   set TC.IND_RENEGOCIADO = 'Y'\n                 where TC.die_cartao_cr_fatura_ID = :new.die_cartao_cr_fatura_ID\n                   and TC.BEG_COBRADOR_ID = VREG2.BEG_COBRADOR_ID; -- aok - 30/03/2007\n              end if;\n      */\n      /*   else\n        -- titulos lancados a  credito de clientes em caso de devoluc?o\n        -- de mercadorias apos o pagamento\n        if VREG1.TP_PGTO = 'T' then\n          if VREG1.DEBITO_CREDITO = 'C' then\n            RAISE_APPLICATION_ERROR(-20022,\n                                    'Tipo de movimento de baixa invalido para este tipo de titulo.' ||\n                                    VREG2.TITULO);\n          else\n            if VREG2.VLR_TITULO <> VREG2.VLR_ABERTO then\n              RAISE_APPLICATION_ERROR(-20023,\n                                      'Titulo ja possui pagamentos tipo de movimento invalido para esta baixa, efetue uma baixa por saldo.' ||\n                                      VREG2.TITULO || ' - ' ||\n                                      TO_CHAR(VREG2.VLR_TITULO,\n                                              'fm99999g990d00'));\n            end if;\n            if VREG2.VLR_ABERTO <> :new.VLR_PAGO then\n              RAISE_APPLICATION_ERROR(-20024,\n                                      'Valor do movimento difere do valor em aberto ' ||\n                                      VREG2.VLR_ABERTO ||\n                                      ' para este titulo.' || VREG2.TITULO);\n            end if;\n            if :new.VLR_PAGO > VREG2.VLR_ABERTO then\n              RAISE_APPLICATION_ERROR(-20025,\n                                      'Valor do movimento maior que o valor em aberto para o titulo.' ||\n                                      VREG2.TITULO);\n            end if;\n          end if;\n        elsif VREG1.TP_PGTO = 'P' then\n          if VREG1.DEBITO_CREDITO = 'C' then\n            RAISE_APPLICATION_ERROR(-20026,\n                                    'Tipo de movimento de baixa invalido para este tipo de titulo.' ||\n                                    VREG2.TITULO);\n          else\n            if VREG2.VLR_ABERTO = :new.VLR_PAGO then\n              RAISE_APPLICATION_ERROR(-20027,\n                                      'Valor do movimento igual ao valor em aberto ' ||\n                                      VREG2.VLR_ABERTO ||\n                                      ' para este titulo.' || VREG2.TITULO);\n            end if;\n            if :new.VLR_PAGO > VREG2.VLR_ABERTO then\n              RAISE_APPLICATION_ERROR(-20028,\n                                      'Valor do movimento maior que o valor em aberto para o titulo.' ||\n                                      VREG2.TITULO);\n            end if;\n          end if;\n        elsif VREG1.TP_PGTO = 'S' then\n          if VREG1.DEBITO_CREDITO = 'C' then\n            RAISE_APPLICATION_ERROR(-20029,\n                                    'Tipo de movimento de baixa invalido para este tipo de titulo.' ||\n                                    VREG2.TITULO);\n          else\n            if VREG2.VLR_TITULO = VREG2.VLR_ABERTO then\n              RAISE_APPLICATION_ERROR(-20030,\n                                      'Nao houve pagamentos para este titulo, efetue baixa parcial ou total.' ||\n                                      VREG2.TITULO);\n            end if;\n            if VREG2.VLR_ABERTO <> :new.VLR_PAGO then\n              RAISE_APPLICATION_ERROR(-20031,\n                                      'Valor do movimento deve ser igual ao valor em  aberto ' ||\n                                      VREG2.VLR_ABERTO ||\n                                      ' para este titulo' || VREG2.TITULO);\n            end if;\n            if :new.VLR_PAGO > VREG2.VLR_ABERTO then\n              RAISE_APPLICATION_ERROR(-20032,\n                                      'Valor do movimento maior que o valor em aberto para o titulo.' ||\n                                      VREG2.TITULO);\n            end if;\n          end if;\n        elsif VREG1.TP_PGTO = 'R' then\n          if VREG1.DEBITO_CREDITO = 'D' then\n            RAISE_APPLICATION_ERROR(-20033,\n                                    'Tipo de movimento de baixa invalido para este tipo de titulo.' ||\n                                    VREG2.TITULO);\n          else\n            if (VREG2.VLR_TITULO - VREG2.VLR_ABERTO) <> :new.VLR_PAGO then\n              RAISE_APPLICATION_ERROR(-20034,\n                                      'Valor do movimento deve ser igual ao valor ja pago ' ||\n                                      (VREG2.VLR_TITULO - VREG2.VLR_ABERTO) ||\n                                      ' para este titulo, estorno invalido.' ||\n                                      VREG2.TITULO);\n            end if;\n            if :new.VLR_MULTA <> VREG2.VLR_MULTA then\n              RAISE_APPLICATION_ERROR(-20035,\n                                      'Valor da multa deve ser igual ao valor ja pago de multa.' ||\n                                      VREG2.TITULO);\n            end if;\n            if :new.VLR_JUROS <> VREG2.VLR_JUROS then\n              RAISE_APPLICATION_ERROR(-20036,\n                                      'Valor dos juros deve ser igual ao valor ja pago de juros.' ||\n                                      VREG2.TITULO);\n            end if;\n            if :new.VLR_DESCONTO <> VREG2.VLR_DESCONTO then\n              RAISE_APPLICATION_ERROR(-20037,\n                                      'Valor do desconto deve ser igual ao valor ja dado de desconto.' ||\n                                      VREG2.TITULO);\n            end if;\n          end if;\n        elsif VREG1.TP_PGTO = 'O' then\n          if VREG1.DEBITO_CREDITO = 'D' then\n            RAISE_APPLICATION_ERROR(-20038,\n                                    'Tipo de movimento de baixa invalido para este tipo de titulo.' ||\n                                    VREG2.TITULO);\n          else\n            if (VREG2.VLR_TITULO - VREG2.VLR_ABERTO) > :new.VLR_PAGO then\n              RAISE_APPLICATION_ERROR(-20039,\n                                      'Valor do movimento deve ser menor que o valor ja pago ' ||\n                                      (VREG2.VLR_TITULO - VREG2.VLR_ABERTO) ||\n                                      ' para este titulo, estorno invalido.' ||\n                                      VREG2.TITULO);\n            end if;\n          end if;\n        end if;\n      \n        if VREG1.TP_PGTO in ('P', 'T', 'S') then\n          update die_cartao_cr_fatura C\n             set C.VLR_ABERTO   = C.VLR_ABERTO - :new.VLR_PAGO,\n                 C.VLR_MULTA    = C.VLR_MULTA + :new.VLR_MULTA,\n                 C.VLR_JUROS    = C.VLR_JUROS + :new.VLR_JUROS,\n                 C.VLR_DESCONTO = C.VLR_DESCONTO + :new.VLR_DESCONTO\n           where C.die_cartao_cr_fatura_ID = :new.die_cartao_cr_fatura_ID;\n          ----------------------------------------------------\n        else\n          update die_cartao_cr_fatura C\n             set C.VLR_ABERTO   = C.VLR_ABERTO + :new.VLR_PAGO,\n                 C.VLR_MULTA    = C.VLR_MULTA - :new.VLR_MULTA,\n                 C.VLR_JUROS    = C.VLR_JUROS - :new.VLR_JUROS,\n                 C.VLR_DESCONTO = C.VLR_DESCONTO - :new.VLR_DESCONTO\n           where C.die_cartao_cr_fatura_ID = :new.die_cartao_cr_fatura_ID;\n        end if;\n      end if;*/\n    end if;\n    -- Busca a sequencia para o registro de inclusao de historico\n  \n  end if;\n\nend;\n"}`;
    
    }
}
