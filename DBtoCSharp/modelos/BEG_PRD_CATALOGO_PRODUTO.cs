
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_CATALOGO_PRODUTO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_CATALOGO_PRODUTO_ID { get; set; }
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
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_CATALOGO_ID { get; set; }
            [Required]
        /// <summary>
        /// Numero da pagina do catalogo
        /// </summary>
        public int NRO_PAGINA { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_PRD_CATALOGO_PROD { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  V_BEG_PRODUTO_ID BEG_PRD_SKU.BEG_PRODUTO_ID%type;\n\nbegin\n  ---- sku n?o for informado busca o sku padr?o\n  if :new.BEG_PRD_SKU_ID is null then\n    begin\n      select BEG_PRD_SKU_ID\n        into :new.BEG_PRD_SKU_ID\n        from BEG_PRD_SKU\n       where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n         and PADRAO = 'Y';\n    \n    exception\n      when NO_DATA_FOUND then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'SKU n?o informado e padr?o n?o encontrado!');\n      when TOO_MANY_ROWS then\n        RAISE_APPLICATION_ERROR(-20002, 'SKU duplicado.');\n    end;\n  \n  else\n  \n    if INSERTING then\n      begin\n        select BEG_PRODUTO_ID\n          into V_BEG_PRODUTO_ID\n          from BEG_PRD_SKU\n         where BEG_PRD_SKU_ID = :new.BEG_PRD_SKU_ID;\n      exception\n        when NO_DATA_FOUND then\n          RAISE_APPLICATION_ERROR(-20003, 'SKU n?o encontrado.');\n        when TOO_MANY_ROWS then\n          RAISE_APPLICATION_ERROR(-20002, 'SKU duplicado.');\n      end;\n    \n      if :new.BEG_PRODUTO_ID <> V_BEG_PRODUTO_ID then\n        RAISE_APPLICATION_ERROR(-20005,\n                                'SKU informado n?o pertence ao produto.');\n      end if;\n    \n    elsif UPDATING then\n      if :new.BEG_PRODUTO_ID <> :old.BEG_PRODUTO_ID then\n        :new.BEG_PRD_SKU_ID := null;\n      end if;\n    end if;\n  end if;\n\nend BEG_TRG_BIU_PRD_CATALOGO_PROD;\n"}`;
    
    }
}
