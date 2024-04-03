
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_REL_PADRAO_USUARIO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_GER_REL_PADRAO_USR { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /*---------------------------------------------------------------------------------------------------\n    Objetivo(s)..: Trigger que valida a existência de usuários na tabela de relatórios.\n    Modulo.......: GER - Geral\n    Analista.....: Tiago Gabriel\n    Alterações:\n    Data        Desenvolvedor  Alteração\n    03/06/2008  Tiago Gabriel  Criação.\n  ---------------------------------------------------------------------------------------------------*/\n  vn_dummy Number;\n\nbegin\n  select Count( 1 )\n    into vn_dummy\n    from beg_ger_rel_padrao\n   where beg_ger_rel_padrao_id = :new.beg_ger_rel_padrao_id\n     and ad_user_id            = :new.ad_user_id;\n\n  if vn_dummy > 0 then\n    Raise_Application_Error( -20001, 'Usuário informado como principal!' );\n  end if;\n\nend BEG_TRG_BIU_GER_REL_PADRAO_USR;\n"}`;
    
    }
}
