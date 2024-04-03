
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_RENEGOCIACAO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ENTRADA { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ACRESCIMO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IMPRESSO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_RENEGOCIACAO_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TITULO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_RENEGOCIADO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_RENEGOCIACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TX_JURO_ORIGINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TX_JURO_NEGOCIADA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Em andamento = IP
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MULTA_ORIGINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MULTA_NEGOCIADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ROLE { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_CRC_BIU_RENEG { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  --\n  if UPDATING\n     and NVL(:new.VLR_TOTAL_RENEGOCIADO, 0) > 0 /*or NVL(:new.VLR_TOTAL_RENEGOCIADO, 0)<>NVL(:old.VLR_TOTAL_RENEGOCIADO, 0)*/ then\n    BEG_PRC_CRC_CALCULA_PARC_RENEG(:new.BEG_CRC_RENEGOCIACAO_ID,\n                                   :new.VLR_TOTAL_RENEGOCIADO,\n                                   :new.BEG_CONDICAO_PAGAMENTO_ID,\n                                   :NEW.VLR_ENTRADA);\n\n       if :OLD.AD_ORG_ID <> :NEW.AD_ORG_ID THEN\n         \n         UPDATE BEG_CRC_PESSOA_RENEG P SET\n            P.AD_ORG_ID = :NEW.AD_ORG_ID\n         WHERE P.BEG_CRC_RENEGOCIACAO_ID = :NEW.BEG_CRC_RENEGOCIACAO_ID;\n         \n         UPDATE BEG_CRC_TITULO_RENEGOCIADO P SET\n            P.AD_ORG_ID = :NEW.AD_ORG_ID\n         WHERE P.BEG_CRC_RENEGOCIACAO_ID = :NEW.BEG_CRC_RENEGOCIACAO_ID;\n\n         UPDATE BEG_CRC_PARCELA_RENEG P SET\n            P.AD_ORG_ID = :NEW.AD_ORG_ID\n         WHERE P.BEG_CRC_RENEGOCIACAO_ID = :NEW.BEG_CRC_RENEGOCIACAO_ID;         \n         \n       end if;\n\n  end if;  \n  --\n  if INSERTING then\n    :new.VLR_TOTAL_RENEGOCIADO := NVL(:new.VLR_TOTAL_RENEGOCIADO, 0) +\n                                  NVL(:new.VLR_ACRESCIMO, 0) -\n                                  NVL(:new.VLR_DESCONTO, 0);\n  elsif UPDATING then\n    :new.VLR_TOTAL_RENEGOCIADO := NVL(:new.VLR_TOTAL_RENEGOCIADO, 0) -\n                                  NVL(:old.VLR_ACRESCIMO, 0) +\n                                  NVL(:old.VLR_DESCONTO, 0);\n    :new.VLR_TOTAL_RENEGOCIADO := NVL(:new.VLR_TOTAL_RENEGOCIADO, 0) +\n                                  NVL(:new.VLR_ACRESCIMO, 0) -\n                                  NVL(:new.VLR_DESCONTO, 0);\n  end if;\nend BEG_TRG_CRC_BIU_RENEG;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BI_CRC_RENEGOCIACAO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  cursor busca_seq is\n    select beg_crc_reneg_seq.nextval seq\n    from   dual;\n  --\n  vreg1    busca_seq%rowtype;\n  --\n  CURSOR BUSCA_JUROS IS\n    SELECT C.JUROS,MULTA,PERC_ACRESCIMO\n    FROM   BEG_CONDICAO_PAGAMENTO C\n    WHERE  C.BEG_CONDICAO_PAGAMENTO_ID = :NEW.BEG_CONDICAO_PAGAMENTO_ID;\n  --\n  VREG2    BUSCA_JUROS%ROWTYPE;\n  --\nbegin\n  if inserting then \n  open busca_seq;\n  fetch busca_seq into vreg1;\n  close busca_seq;\n  :new.value := vreg1.seq;\n  OPEN BUSCA_JUROS;\n  FETCH BUSCA_JUROS INTO VREG2;\n  CLOSE BUSCA_JUROS;\n  :NEW.TX_JURO_ORIGINAL := VREG2.JUROS;\n  :NEW.TX_JURO_NEGOCIADA := VREG2.JUROS;\n  :NEW.MULTA_ORIGINAL := VREG2.MULTA;\n  :NEW.MULTA_NEGOCIADA := VREG2.MULTA;\n  :NEW.PERC_ACRESCIMO := VREG2.PERC_ACRESCIMO;\n  end if;\n   \n   if updating and :old.beg_condicao_pagamento_id <> :new.beg_condicao_pagamento_id  then \n  open busca_seq;\n  fetch busca_seq into vreg1;\n  close busca_seq;\n  :new.value := vreg1.seq;\n  OPEN BUSCA_JUROS;\n  FETCH BUSCA_JUROS INTO VREG2;\n  CLOSE BUSCA_JUROS;\n  :NEW.TX_JURO_ORIGINAL := VREG2.JUROS;\n  :NEW.TX_JURO_NEGOCIADA := VREG2.JUROS;\n  :NEW.MULTA_ORIGINAL := VREG2.MULTA;\n  :NEW.MULTA_NEGOCIADA := VREG2.MULTA;\n  :NEW.PERC_ACRESCIMO := VREG2.PERC_ACRESCIMO;\n  end if; \n  \nend trg_bi_crc_renegociacao;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_AIUD_CRC_RENEGOCIACAO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\n  V_PESSOA_RENEG_ID  number(10);\n  V_PARCELA_RENEG_ID number(10);\n  V_GEROU_ENTRADA    varchar2(1);\n  --\n  cursor BUSCA_PARCELAS is\n    /*select ROWNUM PARCELA,\n           (P.DIAS_VENCIMENTO + sysdate) DATA,\n           P.PORCENTAGEM,\n           C.ENTRADA\n      from BEG_PARCELA_CONDICAO   P,\n           BEG_CONDICAO_PAGAMENTO C\n     where P.BEG_CONDICAO_PAGAMENTO_ID = :new.BEG_CONDICAO_PAGAMENTO_ID\n       and p.value >= '01'\n       and C.BEG_CONDICAO_PAGAMENTO_ID = P.BEG_CONDICAO_PAGAMENTO_ID*/\n       select to_number(p.value) PARCELA,\n--           (P.DIAS_VENCIMENTO + trunc(sysdate)) DATA,\n        --  case when  to_char ((P.DIAS_VENCIMENTO + trunc(sysdate)),'MM') ='02' then\n            (P.DIAS_VENCIMENTO + trunc(sysdate))\n        --    else\n        --   to_date(to_char(sysdate,'DD')|| to_char ((P.DIAS_VENCIMENTO + trunc(sysdate)),'MMYYYY'),'DDMMYYYY' )\n           /*end*/ DATA,\n           P.PORCENTAGEM,\n           C.ENTRADA\n      from BEG_PARCELA_CONDICAO   P,\n           BEG_CONDICAO_PAGAMENTO C\n     where P.BEG_CONDICAO_PAGAMENTO_ID = :new.BEG_CONDICAO_PAGAMENTO_ID\n       and to_number(p.value) >= '1'\n       and C.BEG_CONDICAO_PAGAMENTO_ID = P.BEG_CONDICAO_PAGAMENTO_ID\n       order by to_number(p.value)\n       ;\n  --\n  VREG1 BUSCA_PARCELAS%rowtype;\n  --\n  cursor CALCULA_PARCELAS is\n    select count(*) PARC\n      from BEG_CRC_PARCELA_RENEG CP\n     where CP.BEG_CRC_RENEGOCIACAO_ID = :new.BEG_CRC_RENEGOCIACAO_ID;\n  --\n  VREG3 CALCULA_PARCELAS%rowtype;\n  --\n  V_TOTAL_TITULOS   number(18, 2);\n  V_NUMERO_PARCELAS number(3);\n  V_VLR             number(18, 2);\n  V_VALOR_RATEADO   number(18, 2);\nbegin\n  if INSERTING then\n    V_PESSOA_RENEG_ID := beg_fnc_ad_sequence('BEG_CRC_PESSOA_RENEG');\n    insert into BEG_CRC_PESSOA_RENEG\n      (BEG_CRC_PESSOA_RENEG_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       value,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       BEG_CRC_RENEGOCIACAO_ID,\n       BEG_PESSOA_ID)\n    values\n      (V_PESSOA_RENEG_ID,\n       :new.AD_CLIENT_ID,\n       :new.AD_ORG_ID,\n       'Y',\n       1,\n       :new.CREATED,\n       :new.CREATEDBY,\n       :new.UPDATED,\n       :new.UPDATEDBY,\n       :new.BEG_CRC_RENEGOCIACAO_ID,\n       :new.BEG_PESSOA_ID);\n  end if;\n  if INSERTING  then\n    open BUSCA_PARCELAS;\n    loop\n      fetch BUSCA_PARCELAS\n        into VREG1;\n      exit when BUSCA_PARCELAS%notfound;\n      if VREG1.ENTRADA = 'Y'\n         and NVL(V_GEROU_ENTRADA, 'N') = 'N' then\n        V_GEROU_ENTRADA := 'S';\n        AD_SEQUENCE_NEXT('BEG_CRC_PARCELA_RENEG', 0, V_PARCELA_RENEG_ID);\n        insert into BEG_CRC_PARCELA_RENEG\n          (BEG_CRC_PARCELA_RENEG_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           PARCELA,\n           DT_VCTO,\n           VLR_VCTO,\n           BEG_CRC_RENEGOCIACAO_ID)\n        values\n          (V_PARCELA_RENEG_ID,\n           :new.AD_CLIENT_ID,\n           :new.AD_ORG_ID,\n           'Y',\n           :new.CREATED,\n           :new.CREATEDBY,\n           :new.UPDATED,\n           :new.UPDATEDBY,\n           0,\n           sysdate,\n           0,\n           :new.BEG_CRC_RENEGOCIACAO_ID);\n      end if;\n      AD_SEQUENCE_NEXT('BEG_CRC_PARCELA_RENEG', 0, V_PARCELA_RENEG_ID);\n      insert into BEG_CRC_PARCELA_RENEG\n        (BEG_CRC_PARCELA_RENEG_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         PARCELA,\n         DT_VCTO,\n         VLR_VCTO,\n         BEG_CRC_RENEGOCIACAO_ID)\n      values\n        (V_PARCELA_RENEG_ID,\n         :new.AD_CLIENT_ID,\n         :new.AD_ORG_ID,\n         'Y',\n         :new.CREATED,\n         :new.CREATEDBY,\n         :new.UPDATED,\n         :new.UPDATEDBY,\n         VREG1.PARCELA,\n         VREG1.DATA,\n         0,\n         :new.BEG_CRC_RENEGOCIACAO_ID);\n    end loop;\n    close BUSCA_PARCELAS;\n  end if;\n/*  if UPDATING\n     and NVL(:new.VLR_TOTAL_RENEGOCIADO, 0) > 0 then\n    BEG_PRC_CRC_CALCULA_PARC_RENEG(:new.BEG_CRC_RENEGOCIACAO_ID,\n                                   :new.VLR_TOTAL_RENEGOCIADO,\n                                   :new.BEG_CONDICAO_PAGAMENTO_ID,\n                                   :NEW.VLR_ENTRADA);\n  end if;*/\n\n  -------\n   if updating and :old.beg_condicao_pagamento_id <> :new.beg_condicao_pagamento_id   then\n\n     delete BEG_CRC_PARCELA_RENEG\n     where BEG_CRC_RENEGOCIACAO_ID = :NEW.BEG_CRC_RENEGOCIACAO_ID;\n\n    open BUSCA_PARCELAS;\n    loop\n      fetch BUSCA_PARCELAS\n        into VREG1;\n      exit when BUSCA_PARCELAS%notfound;\n      if VREG1.ENTRADA = 'Y'\n         and NVL(V_GEROU_ENTRADA, 'N') = 'N' then\n        V_GEROU_ENTRADA := 'S';\n        AD_SEQUENCE_NEXT('BEG_CRC_PARCELA_RENEG', 0, V_PARCELA_RENEG_ID);\n        insert into BEG_CRC_PARCELA_RENEG\n          (BEG_CRC_PARCELA_RENEG_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           PARCELA,\n           DT_VCTO,\n           VLR_VCTO,\n           BEG_CRC_RENEGOCIACAO_ID)\n        values\n          (V_PARCELA_RENEG_ID,\n           :new.AD_CLIENT_ID,\n           :new.AD_ORG_ID,\n           'Y',\n           :new.CREATED,\n           :new.CREATEDBY,\n           :new.UPDATED,\n           :new.UPDATEDBY,\n           0,\n           sysdate,\n           0,\n           :new.BEG_CRC_RENEGOCIACAO_ID);\n      end if;\n      AD_SEQUENCE_NEXT('BEG_CRC_PARCELA_RENEG', 0, V_PARCELA_RENEG_ID);\n      insert into BEG_CRC_PARCELA_RENEG\n        (BEG_CRC_PARCELA_RENEG_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         PARCELA,\n         DT_VCTO,\n         VLR_VCTO,\n         BEG_CRC_RENEGOCIACAO_ID)\n      values\n        (V_PARCELA_RENEG_ID,\n         :new.AD_CLIENT_ID,\n         :new.AD_ORG_ID,\n         'Y',\n         :new.CREATED,\n         :new.CREATEDBY,\n         :new.UPDATED,\n         :new.UPDATEDBY,\n         VREG1.PARCELA,\n         VREG1.DATA,\n         0,\n         :new.BEG_CRC_RENEGOCIACAO_ID);\n    end loop;\n    close BUSCA_PARCELAS;\n  end if;\nend TRG_AIUD_CRC_RENEGOCIACAO;\n"}`;
    
    }
}
