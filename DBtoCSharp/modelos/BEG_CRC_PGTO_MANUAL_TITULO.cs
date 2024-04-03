
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_PGTO_MANUAL_TITULO
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRATO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCELA { get; set; }
        
        /// <summary>
        /// Número do recibo de pagamento.
        /// </summary>
        public int RECIBO_PAGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SRDUP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CLASSIF { get; set; }
        
        /// <summary>
        /// Tipo título.
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// Data para calculo do pagamento dos juros
        /// </summary>
        public string DT_PGTO_JUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_PGTO_MANUAL_FORNEC_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Observação referente ao pagamento manual do título
        /// </summary>
        public string OBS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id dos pagamentos manuais de titulos do CR
        /// </summary>
        public int BEG_CRC_PGTO_MANUAL_TITULO_ID { get; set; }
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
        /// Id dos pagamentos panuais do CR
        /// </summary>
        public int BEG_CRC_PGTO_MANUAL_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do titulo
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// Pagar (s/n)
        /// </summary>
        public string PAGAR { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// Valor do titulo
        /// </summary>
        public int VLR_TITULO { get; set; }
        
        /// <summary>
        /// Valor dos juros
        /// </summary>
        public int VLR_JUROS { get; set; }
        
        /// <summary>
        /// Valor do desconto
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// Id do parceiro comercial - cliente
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Título + parcela
        /// </summary>
        public string TITULO_PARCELA { get; set; }
        
        /// <summary>
        /// Valor da despesa
        /// </summary>
        public int VLR_DESPESA { get; set; }
        
        /// <summary>
        /// Valor da baixa
        /// </summary>
        public int VLR_BAIXA { get; set; }
        
        /// <summary>
        /// Valor de devolução
        /// </summary>
        public int VLR_DEVOLUCAO { get; set; }
        
        /// <summary>
        /// Valor total
        /// </summary>
        public int VLR_TOTAL { get; set; }
        
        /// <summary>
        /// Data do vencimento
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// Data de pagamento do titulo
        /// </summary>
        public string DT_PGTO_TIT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIFERENCA { get; set; }
        
        /// <summary>
        /// Valor corrigido do titulo ao dia do pagamento
        /// </summary>
        public int VLR_CORRIGIDO { get; set; }
        
        /// <summary>
        /// Valor efetivamente pago do titulo
        /// </summary>
        public int VLR_PAGO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_PGTO_MANUAL_TIT { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\n  cursor BUSCA_TITULO is\n    select T.DT_VCTO\n      from BEG_CRC_TITULO T\n     where T.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID\n       and T.IND_ABERTO = 'Y';\n  --\n  VREG1 BUSCA_TITULO%rowtype;\n  --\n  cursor BUSCA_LOTE is\n    select docstatus,\n           DT_PGTO,\n           IND_INICIALIZA_DATA\n      from BEG_CRC_PGTO_MANUAL P\n     where P.BEG_CRC_PGTO_MANUAL_ID = :new.BEG_CRC_PGTO_MANUAL_ID;\n  --\n  VREG2 BUSCA_LOTE%rowtype;\n  ---\n    cursor BUSCA_LOTE2 is\n    select docstatus,\n           DT_PGTO,\n           IND_INICIALIZA_DATA\n      from BEG_CRC_PGTO_MANUAL P\n     where P.BEG_CRC_PGTO_MANUAL_ID = :old.BEG_CRC_PGTO_MANUAL_ID;\n  --\n  VREG3 BUSCA_LOTE2%rowtype;\n  --\nbegin\n    IF deleting then \n    open BUSCA_LOTE2;\n    fetch BUSCA_LOTE2\n      into VREG3;\n  \n    \n    if vreg3.docstatus = 'CO' then\n      close BUSCA_LOTE2;\n      RAISE_APPLICATION_ERROR(-20501, 'Lote ja encerrado-LOTE2 ');\n    end if;\n    end if;\n  if INSERTING then\n    --\n    IF :NEW.ISACTIVE = 'Y' THEN\n      --\n      \n      UPDATE BEG_CRC_PGTO_MANUAL_FORNEC C\n         SET C.VLR_TITULO = C.VLR_TITULO + NVL(:NEW.VLR_PAGO,0) + NVL(:new.VLR_JUROS,0) - NVL(:new.VLR_DESCONTO,0)\n       WHERE C.BEG_CRC_PGTO_MANUAL_FORNEC_ID = :NEW.BEG_CRC_PGTO_MANUAL_FORNEC_ID;\n      --\n    END IF;\n    --\n    open BUSCA_LOTE;\n    fetch BUSCA_LOTE\n      into VREG2;\n  \n    /* Tiago Gabriel em 06/12/2006\n       Passou a trazer o docstatus pois preciso dos dados do cursor abaixo. Por isso, mudei o teste.\n    if BUSCA_LOTE%found then\n      close BUSCA_LOTE;\n      RAISE_APPLICATION_ERROR(-20501, 'Lote ja encerrado');\n    end if;*/\n    if vreg2.docstatus = 'CO' then\n      close BUSCA_LOTE;\n      RAISE_APPLICATION_ERROR(-20501, 'Lote ja encerrado-LOTE1 ');\n    end if;\n  \n    open BUSCA_TITULO;\n    fetch BUSCA_TITULO\n      into VREG1;\n    if BUSCA_TITULO%notfound then\n      close BUSCA_TITULO;\n      RAISE_APPLICATION_ERROR(-20501, 'Titulo ja esta pago');\n    end if;\n  \n    /* Tiago Gabriel em 22/11/2006\n       Passou a inicializar a data de vencimento ou data da capa do lote, conforme selecionado.*/\n    if :new.DT_PGTO_TIT is null then\n      if VREG2.IND_INICIALIZA_DATA = 'Y' then\n        :new.DT_PGTO_TIT := VREG2.DT_PGTO;\n      else\n        :new.DT_PGTO_TIT := VREG1.DT_VCTO;\n      end if;\n    end if;\n\n    close BUSCA_LOTE;\n    close BUSCA_TITULO;\n    --\n    :new.VLR_TOTAL := NVL(:NEW.VLR_PAGO,0) + NVL(:new.VLR_JUROS,0) - NVL(:new.VLR_DESCONTO,0);\n  \n/*    update BEG_CRC_PGTO_MANUAL P\n       set P.VLR_TOTAL = P.VLR_TOTAL + NVL(:new.VLR_TOTAL,0)\n     where P.BEG_CRC_PGTO_MANUAL_ID = :new.BEG_CRC_PGTO_MANUAL_ID;*/\n  \n  elsif UPDATING then\n  \n    open BUSCA_LOTE;\n    fetch BUSCA_LOTE\n      into VREG2;\n  \n    /* Tiago Gabriel em 06/12/2006\n       Passou a trazer o docstatus pois preciso dos dados do cursor abaixo. Por isso, mudei o teste.\n    if BUSCA_LOTE%found then\n      close BUSCA_LOTE;\n      RAISE_APPLICATION_ERROR(-20501, 'Lote ja encerrado');\n    end if;*/\n    if vreg2.docstatus = 'CO' then\n      close BUSCA_LOTE;\n      RAISE_APPLICATION_ERROR(-20501, 'Lote ja encerrado');\n    end if;\n    --\n    IF :NEW.ISACTIVE = 'Y' AND\n       :NEW.ISACTIVE <> :OLD.ISACTIVE THEN\n      --\n      UPDATE BEG_CRC_PGTO_MANUAL_FORNEC C\n         SET C.VLR_TITULO = C.VLR_TITULO +( NVL(:NEW.VLR_PAGO,0)+ NVL(:new.VLR_JUROS,0) - NVL(:new.VLR_DESCONTO,0))\n       WHERE C.BEG_CRC_PGTO_MANUAL_FORNEC_ID = :NEW.BEG_CRC_PGTO_MANUAL_FORNEC_ID;\n      --\n    ELSIF :NEW.ISACTIVE = 'N' AND\n       :NEW.ISACTIVE <> :OLD.ISACTIVE  THEN\n      --\n      UPDATE BEG_CRC_PGTO_MANUAL_FORNEC C\n         SET C.VLR_TITULO = C.VLR_TITULO - ( NVL(:NEW.VLR_PAGO,0)+ NVL(:new.VLR_JUROS,0) - NVL(:new.VLR_DESCONTO,0))\n       WHERE C.BEG_CRC_PGTO_MANUAL_FORNEC_ID = :NEW.BEG_CRC_PGTO_MANUAL_FORNEC_ID;\n      --\n    ELSIF :NEW.ISACTIVE = 'Y' AND :OLD.ISACTIVE ='Y' THEN \n      \n      UPDATE BEG_CRC_PGTO_MANUAL_FORNEC C\n         SET C.VLR_TITULO = C.VLR_TITULO -( NVL(:OLD.VLR_PAGO,0)+ NVL(:OLD.VLR_JUROS,0) - NVL(:OLD.VLR_DESCONTO,0)) +( NVL(:NEW.VLR_PAGO,0)+ NVL(:new.VLR_JUROS,0) - NVL(:new.VLR_DESCONTO,0))\n       WHERE C.BEG_CRC_PGTO_MANUAL_FORNEC_ID = :NEW.BEG_CRC_PGTO_MANUAL_FORNEC_ID;\n        \n    END IF;\n    --  \n    :new.VLR_TOTAL := NVL(:new.VLR_PAGO,0) + NVL(:new.VLR_JUROS,0) - NVL(:new.VLR_DESCONTO,0);\n  \n    /*update BEG_CRC_PGTO_MANUAL P\n       set P.VLR_TOTAL = P.VLR_TOTAL - NVL(:old.VLR_TOTAL,0) + NVL(:new.VLR_TOTAL,0)\n     where P.BEG_CRC_PGTO_MANUAL_ID = :old.BEG_CRC_PGTO_MANUAL_ID;*/\n  \n  else \n    if :old.isactive='Y' THEN \n      \n    update BEG_CRC_PGTO_MANUAL_FORNEC P\n       set P.Vlr_Titulo = P.Vlr_Titulo - ( NVL(:OLD.VLR_PAGO,0)+ NVL(:OLD.VLR_JUROS,0) - NVL(:OLD.VLR_DESCONTO,0))\n     where P.Beg_Crc_Pgto_Manual_Fornec_Id = :old.beg_crc_pgto_manual_fornec_id;\n   \n   END IF; \n\n  end if;\n\nend BEG_TRG_BIUD_PGTO_MANUAL_TIT;\n"}`;
    
    }
}
