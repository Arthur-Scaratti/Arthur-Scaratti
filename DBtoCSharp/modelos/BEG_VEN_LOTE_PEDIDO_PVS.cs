
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_LOTE_PEDIDO_PVS
    {

        [NotMapped]
        public string Trigger_TRG_AIUD_VEN_LOTE_PEDIDO_PVS { get; set; } = `{"triggering_event":"INSERT OR DELETE","trigger_body":"declare\n  -- local variables here\n  cursor C_PEDIDO(P_BEG_VEN_PEDIDO_ID number) is\n    select A.VLR_TOTAL,\n           A.BEG_VW_CLIENTE_ID\n      from BEG_VEN_PEDIDO A\n     where A.BEG_VEN_PEDIDO_ID = (P_BEG_VEN_PEDIDO_ID);\n  R C_PEDIDO%rowtype;\n\nbegin\n  if INSERTING then\n    open C_PEDIDO(:new.BEG_VEN_PEDIDO_ID);\n    fetch C_PEDIDO\n      into R;\n    close C_PEDIDO;\n  \n    update BEG_VEN_LOTE_PEDIDO B\n       set B.TOTAL     = NVL(B.TOTAL, 0) + 1,\n           B.VLR_TOTAL = NVL(B.VLR_TOTAL, 0) + NVL(R.VLR_TOTAL, 0)\n     where B.BEG_VEN_LOTE_PEDIDO_ID = :new.BEG_VEN_LOTE_PEDIDO_ID;\n  \n  end if;\n\n  if DELETING then\n    open C_PEDIDO(:old.BEG_VEN_PEDIDO_ID);\n    fetch C_PEDIDO\n      into R;\n    close C_PEDIDO;\n  \n    update BEG_VEN_LOTE_PEDIDO B\n       set B.TOTAL     = NVL(B.TOTAL, 0) - 1,\n           B.VLR_TOTAL = NVL(B.VLR_TOTAL, 0) - NVL(R.VLR_TOTAL, 0)\n     where B.BEG_VEN_LOTE_PEDIDO_ID = :old.BEG_VEN_LOTE_PEDIDO_ID;\n  \n  end if;\n\nend TRG_AIUD_BEG_COBRADOR;\n"}`;
    
    }
}
