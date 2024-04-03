
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CHK_LIST
    {
            [Required]
    [Key]
        /// <summary>
        /// Id  do check list
        /// </summary>
        public int DIE_CHK_LIST_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
            [StringLength(240)]
        /// <summary>
        /// Descricao completa
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
        /// <summary>
        /// DATA INICIO DIGITAÇAO
        /// </summary>
        public string DATAHORA_CHEGADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATAHORA_SAIDA { get; set; }
            [Required]
        /// <summary>
        /// id tipo de check list
        /// </summary>
        public int DIE_TIPO_CHK_LIST_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Usuario
        /// </summary>
        public string APP_USER { get; set; }
            [Required]
    [StringLength(60)]
        /// <summary>
        /// Nome do gestor responsavel da filial
        /// </summary>
        public string GESTOR { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BI_DIE_CHK_LIST { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE \n\nCURSOR C1 IS\n \n  SELECT L.*\n    FROM DIE_TIPO_CHK_LIST L\n  WHERE L.DIE_VW_TIPO_CHK_LIST_ID = :NEW.DIE_TIPO_CHK_LIST_ID\n    AND L.ISACTIVE='Y'\n  order by l.die_tipo_chk_list_id;  \n\n\nBEGIN\n\n--IF 1=1 THEN\n  FOR X IN C1 LOOP \n    \n      INSERT INTO DIE_CHK_LIST_ITEM  \n       ( DIE_CHK_LIST_ITEM_ID ,\n        AD_CLIENT_ID         ,\n        AD_ORG_ID            ,\n        ISACTIVE             ,\n        VALUE                ,\n        CREATED              ,\n        CREATEDBY            ,\n        UPDATED              ,\n        UPDATEDBY            ,\n        DIE_TIPO_CHK_LIST_ID ,\n        DIE_CHK_LIST_ID     \n                 )\n        VALUES\n           (\n          beg_fnc_ad_sequence('DIE_CHK_LIST_ITEM') ,\n        :NEW.AD_CLIENT_ID         ,\n        :NEW.AD_ORG_ID            ,\n        :NEW.ISACTIVE             ,\n        :NEW.VALUE                ,\n        :NEW.CREATED              ,\n        :NEW.CREATEDBY            ,\n        :NEW.UPDATED              ,\n        :NEW.UPDATEDBY            ,\n        X.DIE_TIPO_CHK_LIST_ID ,\n        :NEW.DIE_CHK_LIST_ID     \n           );\n  \n  \n  END LOOP;   \n-- END IF; \n\nEND DIE_TRG_BI_DIE_CHK_LIST;\n"}`;
    
    }
}
