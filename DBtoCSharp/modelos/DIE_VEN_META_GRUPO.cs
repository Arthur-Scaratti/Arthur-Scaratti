
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VEN_META_GRUPO
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do Grupo de metas
        /// </summary>
        public int DIE_VEN_META_GRUPO_ID { get; set; }
        
        /// <summary>
        /// Id da Meta de Venda
        /// </summary>
        public int DIE_VEN_META_ID { get; set; }
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
        /// Id do grupo de cotas
        /// </summary>
        public int DIE_VEN_COTA_GRUPO_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_VEN_META_GRUPO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  --\n  VN_PERC number(5, 2);\n  --  pragma autonomous_transaction;\n  --\n  cursor META is\n    select *\n      from DIE_VEN_META M\n     where M.DIE_VEN_META_ID = :new.DIE_VEN_META_ID;\n  RMETA META%rowtype;\n  --\n  cursor COTA_GRUPO is\n    select CGP.*\n      from DIE_VEN_COTA_GRUPO         CG,\n           DIE_VEN_COTA_GRUPO_PRODUTO CGP\n     where CG.DIE_VEN_COTA_GRUPO_ID = :new.DIE_VEN_COTA_GRUPO_ID\n       and CG.DIE_VEN_COTA_GRUPO_ID = CGP.DIE_VEN_COTA_GRUPO_ID;\n\nbegin\n  --\n  if DELETING\n     or UPDATING then\n    delete DIE_VEN_META_GRUPO_PRODUTO MGP\n     where MGP.DIE_VEN_META_GRUPO_ID = :old.DIE_VEN_META_GRUPO_ID;\n  end if;\n  --\n  if INSERTING\n     or UPDATING then\n    VN_PERC := 0;\n    select sum(CGP.PERC_COTA)\n      into VN_PERC\n      from DIE_VEN_COTA_GRUPO         CG,\n           DIE_VEN_COTA_GRUPO_PRODUTO CGP\n     where CG.DIE_VEN_COTA_GRUPO_ID = :new.DIE_VEN_COTA_GRUPO_ID\n       and CG.DIE_VEN_COTA_GRUPO_ID = CGP.DIE_VEN_COTA_GRUPO_ID;\n    --\n    if not (VN_PERC = 100) then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Percentual da cota dos grupos diferem de 100%');\n    end if;\n    --\n    open META;\n    fetch META\n      into RMETA;\n    if META%notfound then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Falha na leitura da Meta - Notifique CPD');\n    end if;\n    close META;\n    --\n    for CG in COTA_GRUPO\n    loop\n      insert into DIE_VEN_META_GRUPO_PRODUTO\n        (DIE_VEN_META_GRUPO_PRODUTO_ID,\n         DIE_VEN_META_GRUPO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         VLR_META_VENDA,\n         DIE_VEN_COTA_GRUPO_ID,\n         DIE_PRD_GRUPO_ID)\n      values\n        (BEG_FNC_AD_SEQUENCE('DIE_VEN_META_GRUPO_PRODUTO'),\n         :new.DIE_VEN_META_GRUPO_ID,\n         RMETA.AD_CLIENT_ID,\n         RMETA.AD_ORG_ID,\n         'Y',\n         sysdate,\n         RMETA.CREATEDBY,\n         sysdate,\n         RMETA.UPDATEDBY,\n         RMETA.VLR_META_VENDA * CG.PERC_COTA / 100, --VLR_META_VENDA,\n         CG.DIE_VEN_COTA_GRUPO_ID,\n         CG.DIE_PRD_GRUPO_ID);\n    end loop;\n    /*\n        DIE_PRC_VEN_META_GRUPO('G',\n                               :new.DIE_VEN_META_ID,\n                               :new.DIE_VEN_META_GRUPO_ID,\n                               :new.DIE_VEN_COTA_GRUPO_ID,\n                               null);\n    */\n  end if;\n  --\nend DIE_TRG_BIUD_VEN_META_GRUPO;\n"}`;
    
    }
}
