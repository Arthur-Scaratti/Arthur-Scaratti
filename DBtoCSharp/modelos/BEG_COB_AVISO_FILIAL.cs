
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_AVISO_FILIAL
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_COB_AVISO_FILIAL { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  if :new.IND_GERAR_AVISO = :new.IND_RECUPERA_CRED then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Escolha uma alternativa - Gerar Aviso Cobrança ou Recuperacao Credito?');\n  end if;\n  if UPDATING('ind_gerar_aviso')\n     and :new.IND_GERAR_AVISO = 'N' then\n    :new.IND_ENVIAR    := 'N';\n    :new.IND_NEGATIVAR := 'N';\n  end if;\nend BEG_TRG_BIU_COB_AVISO_FILIAL;\n"}`;
    
    }
}
