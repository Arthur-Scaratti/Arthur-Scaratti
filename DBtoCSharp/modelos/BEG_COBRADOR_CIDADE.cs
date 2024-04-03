
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COBRADOR_CIDADE
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do cobrador Cidade
        /// </summary>
        public int BEG_COBRADOR_CIDADE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Id do Cobrador
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da Cidade
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuario do Apex
        /// </summary>
        public string APP_USER { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BI_COB_CIDADE_APEX { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  --\n  VB_APEX boolean;\n  --\nbegin\n  if :new.APP_USER is not null\n     and INSERTING then\n    --  :new.DOCSTATUS := 'CO';\n    VB_APEX       := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TABLE(:new.APP_USER,\n                                                              'BEG_COBRADOR_CIDADE',\n                                                              :new.AD_CLIENT_ID,\n                                                              :new.AD_ORG_ID,\n                                                              :new.CREATED,\n                                                              :new.CREATEDBY,\n                                                              :new.UPDATED,\n                                                              :new.UPDATEDBY,\n                                                              :new.BEG_COBRADOR_CIDADE_ID);\n    :new.APP_USER := null;\n  end if;\nend BEG_TRG_BI_COB_CIDADE_APEX;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_IR_COB_CIDADE { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n  -- local variables here\n  CURSOR Busca_Dados_Apex IS\n    SELECT *\n      FROM Beg_Apex_User u\n     WHERE u.Ad_User_Id = :NEW.Createdby;\n  --\n  Vdados_Apex Busca_Dados_Apex%ROWTYPE;\n  --\nBEGIN\n  IF :NEW.Ad_Client_Id IS NULL THEN\n    OPEN Busca_Dados_Apex;\n    FETCH Busca_Dados_Apex\n      INTO Vdados_Apex;\n    CLOSE Busca_Dados_Apex;\n    :NEW.Ad_Client_Id           := Vdados_Apex.Ad_Client_Id;\n    :NEW.Ad_Org_Id              := Vdados_Apex.Ad_Org_Id;\n    :NEW.Created                := SYSDATE;\n    :NEW.Updated                := SYSDATE;\n    :NEW.Updatedby              := Vdados_Apex.Ad_User_Id;\n    :NEW.Isactive               := 'Y';\n    :NEW.Beg_Cobrador_Cidade_Id := Beg_Fnc_Ad_Sequence('BEG_COBRADOR_CIDADE');\n  END IF;\nEND Beg_Trg_Ir_Cob_Cidade;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_COBRADOR_CIDADE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  cursor C_COBRADOR is\n    select *\n      from BEG_COBRADOR C\n     where C.BEG_COBRADOR_ID = :new.BEG_COBRADOR_ID;\n  R_COBRADOR C_COBRADOR%rowtype;\nbegin\n\n  open C_COBRADOR;\n  fetch C_COBRADOR\n    into R_COBRADOR;\n  close C_COBRADOR;\n  if R_COBRADOR.IND_ATUACAO != 'E' then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Manutenção permitida apenas para cobradores externos! ');\n  end if;\n\nend BEG_TRG_BIU_COBRADOR_CIDADE;\n"}`;
    
    }
}
