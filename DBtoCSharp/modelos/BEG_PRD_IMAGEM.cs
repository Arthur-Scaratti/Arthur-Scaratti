
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_IMAGEM
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_IMAGEM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] IMAGEM { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string FILENAME { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string MIMETYPE { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_IMAGENS { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  V_AD_USER_ID integer default 1000000;\nbegin\n\n  /*  begin\n    select AD_USER_ID\n      into V_AD_USER_ID\n      from BEG_APEX_USER\n     where UPPER(USUARIO) = V('APP_USER');\n  exception\n    when NO_DATA_FOUND then\n      RAISE_APPLICATION_ERROR(-20031\n                             ,'Usuário inexistente na base de dados. Verifique.');\n  end;*/\n\n  :NEW.UPDATEDBY := V_AD_USER_ID;\n  :NEW.UPDATED   := sysdate;\n  if INSERTING then\n    :NEW.BEG_PRD_IMAGEM_ID := BEG_FNC_AD_SEQUENCE('BEG_PRD_IMAGEM');\n    :NEW.AD_CLIENT_ID      := 1000000;\n    :NEW.AD_ORG_ID         := 1000001;\n    :NEW.ISACTIVE          := 'Y';\n    :NEW.CREATED           := sysdate;\n    :NEW.CREATEDBY         := V_AD_USER_ID;\n  end if;\nend BEG_TRG_BIU_IMAGENS;\n"}`;
    
    }
}
