
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CEL_OCORRENCIA
    {

        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CEL_OCORRENCIA { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  /*------------------------------------------------------------------------------------------------\n    Objetivo(s)..: Trigger que troca o campo de descrição para upper case e atualiza os status das\n                   tabelas relacionadas.\n    Módulo.......: CEL - Celulares\n    Analista.....: Tiago Gabriel\n    Alterações:\n    Data        Desenvolvedor  Alteração\n    08/11/2007  Tiago Gabriel  Criação.\n    ------------------------------------------------------------------------------------------------*/\n  vn_count Number;\n\nbegin\n  if deleting then\n    Raise_Application_Error( -20001, 'Impossível excluir ocorrências! Elas devem ser atendidas.' );\n  end if;\n\n  -- Se é ocorrência para item de arquivo, atualiza o ID do arquivo\n  if :new.beg_cel_arquivo_id is null          and\n     :new.beg_cel_arquivo_item_id is not null then\n    select beg_cel_arquivo_id\n      into :new.beg_cel_arquivo_id\n      from beg_cel_arquivo_item\n     where beg_cel_arquivo_item_id = :new.beg_cel_arquivo_item_id;\n\n    select Count( 1 )\n      into vn_count\n      from beg_cel_arquivo\n     where beg_cel_arquivo_id = :new.beg_cel_arquivo_id\n       and docstatus          in ( 'CO', 'RE' );\n\n    if vn_count > 0 then\n      Raise_Application_Error( -20001, 'Lote já completo não permite ocorrência!' );\n    end if;\n\n  end if;\n\n  -- Se é ocorrência para item de lote, atualiza o ID da capa de lote e verifica se ainda não foi processado\n  if :new.beg_cel_lote_id is null          and\n     :new.beg_cel_lote_item_id is not null then\n    select beg_cel_lote_id\n      into :new.beg_cel_lote_id\n      from beg_cel_lote_item\n     where beg_cel_lote_item_id = :new.beg_cel_lote_item_id;\n\n    select Count( 1 )\n      into vn_count\n      from beg_cel_lote\n     where beg_cel_lote_id = :new.beg_cel_lote_id\n       and docstatus       = 'CO';\n\n    if vn_count > 0 then\n      Raise_Application_Error( -20001, 'Lote já completo não permite ocorrência!' );\n    end if;\n  end if;\n\n  :new.description     := Upper( :new.description );\n  :new.des_atendimento := Upper( :new.des_atendimento );\n\n  -- Se o atendimento está nulo, anula data de atendimento\n  if :new.des_atendimento is null then\n    :new.dt_atendimento := null;\n  else\n    -- Se está atendendo atualiza a data\n    if :old.des_atendimento is null then\n      :new.dt_atendimento := Trunc( sysdate );\n    end if;\n  end if;\n\nend BEG_TRG_BIUD_CEL_OCORRENCIA;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_AIU_CEL_OCORRENCIA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /*------------------------------------------------------------------------------------------------\n    Objetivo(s)..: Trigger que troca o campo de descrição para upper case e atualiza os status das\n                   tabelas relacionadas.\n    Módulo.......: CEL - Celulares\n    Analista.....: Tiago Gabriel\n    Alterações:\n    Data        Desenvolvedor  Alteração\n    08/11/2007  Tiago Gabriel  Criação.\n    ------------------------------------------------------------------------------------------------*/\n  pragma autonomous_transaction;\n\n  vn_count Number;\n\nbegin\n  -- Se o atendimento está nulo invalida as relações\n  if :new.des_atendimento is null then\n\n    -- Arquivo\n    if :new.beg_cel_arquivo_id is not null then\n      update beg_cel_arquivo\n         set docstatus = 'IN'\n       where beg_cel_arquivo_id = :new.beg_cel_arquivo_id;\n    end if;\n\n    -- Serial\n    if :new.beg_cel_serial_id is not null then\n      update beg_cel_serial\n         set docstatus = 'IN'\n       where beg_cel_serial_id = :new.beg_cel_serial_id;\n    end if;\n\n    -- Lote\n    if :new.beg_cel_lote_id is not null then\n      update beg_cel_lote\n         set docstatus = 'NA'\n       where beg_cel_lote_id = :new.beg_cel_lote_id;\n    end if;\n\n    -- Item do lote\n    if :new.beg_cel_lote_item_id is not null then\n      update beg_cel_lote_item\n         set docstatus = 'IN'\n       where beg_cel_lote_item_id = :new.beg_cel_lote_item_id;\n    end if;\n\n  else\n    -- Se está atendendo verifica outras ocorrências e atualiza os status das relações\n    if :old.des_atendimento is null then\n      -- Arquivo\n      if :new.beg_cel_arquivo_id is not null then\n        select Count( 1 )\n          into vn_count\n          from beg_cel_ocorrencia\n         where des_atendimento is null\n           and beg_cel_arquivo_id    =  :new.beg_cel_arquivo_id\n           and beg_cel_ocorrencia_id <> :new.beg_cel_ocorrencia_id;\n\n        -- Se não possuem ocorrências, atualiza. Caso contrário não precisa alterar\n        -- uma vez que o status continuará o mesmo (na inclusão ele é alterado)\n        if vn_count = 0 then\n          update beg_cel_arquivo\n             set docstatus = 'RE'\n           where beg_cel_arquivo_id = :new.beg_cel_arquivo_id;\n        end if;\n      end if;\n\n      -- Serial\n      if :new.beg_cel_serial_id is not null then\n        select Count( 1 )\n          into vn_count\n          from beg_cel_ocorrencia\n         where des_atendimento is null\n           and beg_cel_serial_id     =  :new.beg_cel_serial_id\n           and beg_cel_ocorrencia_id <> :new.beg_cel_ocorrencia_id;\n\n        -- Se não possuem ocorrências, atualiza. Caso contrário não precisa alterar\n        -- uma vez que o status continuará o mesmo (na inclusão ele é alterado)\n        if vn_count = 0 then\n          update beg_cel_serial\n             set docstatus = Nvl2( beg_cel_arquivo_item_id, 'RE', 'VO' )\n           where beg_cel_serial_id = :new.beg_cel_serial_id;\n        end if;\n      end if;\n\n      -- Lote\n      if :new.beg_cel_lote_id is not null then\n        select Count( 1 )\n          into vn_count\n          from beg_cel_ocorrencia\n         where des_atendimento is null\n           and beg_cel_lote_id       =  :new.beg_cel_lote_id\n           and beg_cel_ocorrencia_id <> :new.beg_cel_ocorrencia_id;\n\n        -- Se não possuem ocorrências, atualiza. Caso contrário não precisa alterar\n        -- uma vez que o status continuará o mesmo (na inclusão ele é alterado)\n        if vn_count = 0 then\n          update beg_cel_lote\n             set docstatus = 'AP'\n           where beg_cel_lote_id = :new.beg_cel_lote_id;\n        end if;\n      end if;\n\n      -- Item do lote\n      if :new.beg_cel_lote_item_id is not null then\n        select Count( 1 )\n          into vn_count\n          from beg_cel_ocorrencia\n         where des_atendimento is null\n           and beg_cel_lote_item_id  =  :new.beg_cel_lote_item_id\n           and beg_cel_ocorrencia_id <> :new.beg_cel_ocorrencia_id;\n\n        -- Se não possuem ocorrências, atualiza. Caso contrário não precisa alterar\n        -- uma vez que o status continuará o mesmo (na inclusão ele é alterado)\n        if vn_count = 0 then\n          update beg_cel_lote_item\n             set docstatus = 'RE'\n           where beg_cel_lote_item_id = :new.beg_cel_lote_item_id;\n        end if;\n      end if;\n\n    end if;\n\n  end if;\n\n  commit;\n\nend BEG_TRG_AIU_CEL_OCORRENCIA;\n"}`;
    
    }
}
