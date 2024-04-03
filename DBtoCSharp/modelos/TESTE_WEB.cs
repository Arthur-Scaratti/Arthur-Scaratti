
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TESTE_WEB
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string PARTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PAGINA { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_TESTE_WEB { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  null;\n  /*\n  if :new.id is null then\n    :new.parte := :new.parte || ' -> NULL';\n  else\n    :new.parte := :new.parte || ' -> NOT NULL';\n  end if;\n  */\n\nend TRG_BIU_TESTE_WEB;\n"}`;
    
    }
}
