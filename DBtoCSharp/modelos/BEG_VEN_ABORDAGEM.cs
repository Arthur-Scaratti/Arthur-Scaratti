
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_ABORDAGEM
    {

        [NotMapped]
        public string Trigger_TRG_AI_BEG_VEN_ABORDAGEM { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  V_SEQUENCE number;\nbegin\n  if :new.AGENDAR = 'Y' then\n    AD_SEQUENCE_NEXT('BEG_VEN_AGENDAMENTO', 1000000, V_SEQUENCE);\n  \n    insert into BEG_VEN_AGENDAMENTO\n      (BEG_VEN_AGENDAMENTO_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       OBS,\n       DATA_AGENDADA,\n       BEG_VW_CLIENTE_ID,\n       BEG_VW_REPRESENTANTE_ID,\n       BEG_VEN_ABORDAGEM_ID,\n       WINDOW)\n    values\n      (V_SEQUENCE,\n       :new.AD_CLIENT_ID,\n       :new.AD_ORG_ID,\n       'Y',\n       :new.CREATED,\n       :new.CREATEDBY,\n       :new.UPDATED,\n       :new.UPDATEDBY,\n       :new.OBS,\n       :new.DT_AGENDAMENTO,\n       :new.BEG_VW_CLIENTE_ID,\n       :new.BEG_VW_REPRESENTANTE_ID,\n       :new.BEG_VEN_ABORDAGEM_ID,\n       null);\n  end if;\nend TRG_BI_BEG_VEN_ABORDAGEM;\n"}`;
    
    }
}
