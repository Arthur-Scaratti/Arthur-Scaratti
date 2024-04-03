
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_EST_DISTRIBUICAO
    {

        [NotMapped]
        public string Trigger_DIE_TRG_BU_DISTRIB { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  :new.QTD_DISPONIVEL := NVL(:new.SALDO, 0) - NVL(:new.QTD_DISTRIBUIDA, 0) -\n                         NVL(:new.QTD_ASSISTENCIA, 0) -\n                         NVL(:new.QTD_ASSISTENCIA_EXTERNA, 0) -\n                         NVL(:new.QTD_RESERVADA, 0);\n\n  /*  :new.QTD_FINAL := NVL(:new.SALDO, 0) - NVL(:new.QTD_DISTRIBUIDA, 0) -\n                      NVL(:new.QTD_RESERVADA, 00) +\n                      NVL(:new.QTD_A_RECEBER, 0);\n  \n      if NVL(:new.QTD_DISPONIVEL, 0) < 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Quantidade insuficiente para operação !');\n    end if;\n  */\nend DIE_TRG_BIU_DISTRIB;\n"}`;
    
    }
}
