
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_PGTO_SIMP_TITULO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_PGTO_SIMP_TIT { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\n  cursor BUSCA_TITULO is\n    select T.DT_VCTO\n      from BEG_CRC_TITULO T\n     where T.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID\n       and T.IND_ABERTO = 'Y';\n  --\n  VREG1 BUSCA_TITULO%rowtype;\n  --\n  cursor BUSCA_LOTE is\n    select DOCSTATUS,\n           DT_PGTO,\n           IND_INICIALIZA_DATA\n      from BEG_CRC_PGTO_SIMPLIF P\n     where P.BEG_CRC_PGTO_SIMPLIF_ID = :new.BEG_CRC_PGTO_SIMPLIF_ID;\n  --\n  VREG2 BUSCA_LOTE%rowtype;\n  --\nbegin\n  if INSERTING then\n    --\n    open BUSCA_LOTE;\n    fetch BUSCA_LOTE\n      into VREG2;\n  \n    if VREG2.DT_PGTO is not null then\n      if VREG2.IND_INICIALIZA_DATA = 'Y' then\n        :new.DT_PGTO_TIT := VREG2.DT_PGTO;\n      end if;\n    end if;\n    if VREG2.DOCSTATUS = 'CO' then\n      close BUSCA_LOTE;\n      RAISE_APPLICATION_ERROR(-20501, 'Lote ja encerrado');\n    end if;\n  \n    open BUSCA_TITULO;\n    fetch BUSCA_TITULO\n      into VREG1;\n    if BUSCA_TITULO%notfound then\n      close BUSCA_TITULO;\n      RAISE_APPLICATION_ERROR(-20501, 'Titulo ja esta pago');\n    end if;\n  \n    close BUSCA_LOTE;\n    close BUSCA_TITULO;\n    --\n    :new.VLR_TOTAL := :new.VLR_BAIXA + :new.VLR_JUROS - :new.VLR_DESCONTO;\n  \n    update BEG_CRC_PGTO_SIMPLIF P\n       set P.VLR_TOTAL = P.VLR_TOTAL + :new.VLR_TOTAL\n     where P.BEG_CRC_PGTO_SIMPLIF_ID = :new.BEG_CRC_PGTO_SIMPLIF_ID;\n  \n  elsif UPDATING then\n  \n    :new.VLR_TOTAL := :new.VLR_BAIXA + :new.VLR_JUROS - :new.VLR_DESCONTO;\n  \n    update BEG_CRC_PGTO_SIMPLIF P\n       set P.VLR_TOTAL = P.VLR_TOTAL - :old.VLR_TOTAL + :new.VLR_TOTAL\n     where P.BEG_CRC_PGTO_SIMPLIF_ID = :old.BEG_CRC_PGTO_SIMPLIF_ID;\n  \n  else\n  \n    update BEG_CRC_PGTO_SIMPLIF P\n       set P.VLR_TOTAL = P.VLR_TOTAL - :old.VLR_TOTAL\n     where P.BEG_CRC_PGTO_SIMPLIF_ID = :old.BEG_CRC_PGTO_SIMPLIF_ID;\n  \n  end if;\n\nend;\n"}`;
    
    }
}
