
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_TROCA_ODOM
    {

        [NotMapped]
        public string Trigger_TRG_BIUD_TRC_ODOM { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\n  cursor BUSCA_ABASTECIMENTO is\n    select DT_ABAST,\n           ODOMETRO\n      from BEG_FRO_ABASTECIMENTO V\n     where V.BEG_FRO_VEICULO_ID = :new.BEG_FRO_VEICULO_ID\n     order by 1 desc,\n              2;\n  --\n  VREG1 BUSCA_ABASTECIMENTO%rowtype;\nbegin\n  if INSERTING then\n    update BEG_FRO_VEICULO V\n       set V.ODOMETRO = :new.ODOMETRO_NEW\n     where V.BEG_FRO_VEICULO_ID = :new.BEG_FRO_VEICULO_ID;\n    --\n  elsif UPDATING then\n    update BEG_FRO_VEICULO V\n       set V.ODOMETRO = :new.ODOMETRO_NEW\n     where V.BEG_FRO_VEICULO_ID = :new.BEG_FRO_VEICULO_ID;\n    --\n  else\n    open BUSCA_ABASTECIMENTO;\n    fetch BUSCA_ABASTECIMENTO\n      into VREG1;\n    if BUSCA_ABASTECIMENTO%found then\n      update BEG_FRO_VEICULO\n         set ODOMETRO = VREG1.ODOMETRO\n       where BEG_FRO_VEICULO_ID = :old.BEG_FRO_VEICULO_ID\n         and ODOMETRO <= :old.ODOMETRO_NEW;\n    end if;\n  end if;\nend TRG_BIUD_TRC_ODOM;\n"}`;
    
    }
}
