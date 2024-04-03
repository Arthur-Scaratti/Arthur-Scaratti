
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_PAGAMENTO_COMISSAO
    {

        [NotMapped]
        public string Trigger_TRG_BD_BEG_PGTO_COMISSAO { get; set; } = `{"triggering_event":"DELETE","trigger_body":"begin\n  delete from BEG_VEN_COM_PAGTO_PESSOA\n   where BEG_VEN_PAGAMENTO_COMISSAO_ID = :old.BEG_VEN_PAGAMENTO_COMISSAO_ID;\n\n  update BEG_VEN_COM_CRC_HISTORICO\n     set BEG_VEN_PAGAMENTO_COMISSAO_ID = null\n   where BEG_VEN_PAGAMENTO_COMISSAO_ID = :old.BEG_VEN_PAGAMENTO_COMISSAO_ID;\n\nend TRG_BD_BEG_PGTO_COMISSAO;\n"}`;
    
    }
}
