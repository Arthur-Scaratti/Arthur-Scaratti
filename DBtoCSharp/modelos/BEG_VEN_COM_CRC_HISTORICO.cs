
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_COM_CRC_HISTORICO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_HIST_COMISSAO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  cursor C_NF is\n    select A.BEG_FAT_NFS_ID,\n           A.BEG_VEN_PEDIDO_ID\n      from BEG_CRC_TITULO A\n     where A.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID;\nbegin\n\n  open C_NF;\n  fetch C_NF\n    into :new.BEG_FAT_NFS_ID, :new.BEG_VEN_PEDIDO_ID;\n  close C_NF;\n\nend BEG_TRG_BIU_HIST_COMISSAO;\n"}`;
    
    }
}
