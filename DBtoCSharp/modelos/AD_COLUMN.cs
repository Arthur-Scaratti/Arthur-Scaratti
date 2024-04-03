
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_COLUMN
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HELP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VERSION { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTITYTYPE { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string COLUMNNAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_TABLE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_REFERENCE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_REFERENCE_VALUE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_VAL_RULE_ID { get; set; }
        
        /// <summary>
        /// Only for VARCHAR and CHAR
        /// </summary>
        public int FIELDLENGTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DEFAULTVALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISKEY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPARENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMANDATORY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISUPDATEABLE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string READONLYLOGIC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISIDENTIFIER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEQNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISTRANSLATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISENCRYPTED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CALLOUT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VFORMAT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALUEMIN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALUEMAX { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSELECTIONCOLUMN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ELEMENT_ID { get; set; }
        
        /// <summary>
        /// Process to start when pressing Button
        /// </summary>
        public int AD_PROCESS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISSYNCDATABASE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISALWAYSUPDATEABLE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string COLUMNSQL { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_COLUMN_ID { get; set; }
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
        public string UPDATED { get; set; }

        [NotMapped]
        public string Trigger_TRG_BI_AD_COLUMN { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  /* -------------------------------------------------------------------------------------------------\n     Objetivo(s)..: Trigger que inicializa a descrição e o help da coluna de acordo com o comentário no\n                    banco e define a coluna VALUE como primeiro identifier.\n     Modulo.......: AD - Dicionário de dados\n     Analista.....: Tiago Gabriel\n     Alterações:\n     Data        Desenvolvedor  Alteração\n     04/10/2006  Tiago Gabriel  Criação.\n     23/08/2007  Tiago Gabriel  Passou a ser autônoma para definir descrição e nome como segundo e\n                                terceiro identifier (se existirem os dois).\n     ------------------------------------------------------------------------------------------------- */\n  pragma autonomous_transaction;\n  vn_dummy Number;\n\nbegin\n  if Upper( :new.columnname ) = 'VALUE' and :new.isidentifier = 'N' then\n    :new.isidentifier := 'Y';\n    :new.seqno        := 10;\n  end if;\n\n  if Upper( :new.columnname ) = 'NAME' and :new.isidentifier = 'N' then\n    select Count( 1 )\n      into vn_dummy\n      from ad_column\n     where ad_table_id = :new.ad_table_id\n       and columnname = 'DESCRIPTION';\n\n    :new.isidentifier := 'Y';\n    if vn_dummy = 0 then\n      :new.seqno := 20;\n    else\n      :new.seqno := 30;\n    end if;\n  end if;\n\n  if Upper( :new.columnname ) = 'DESCRIPTION' and :new.isidentifier = 'N' then\n    select Count( 1 )\n      into vn_dummy\n      from ad_column\n     where ad_table_id = :new.ad_table_id\n       and columnname = 'NAME';\n\n    :new.isidentifier := 'Y';\n    if vn_dummy = 0 then\n      :new.seqno := 20;\n    else\n      :new.seqno := 30;\n    end if;\n  end if;\n\n  select Nvl( :new.description, SubStr( c.comments, 1,  255 ) )\n       , Nvl( :new.help,        SubStr( c.comments, 1, 2000 ) )\n    into :new.description\n       , :new.help\n    from user_col_comments c\n   where c.column_name = Upper( :new.columnname )\n     and c.table_name  = ( select t.tablename\n                             from ad_table t\n                            where t.ad_table_id = :new.ad_table_id );\n\nexception\n  when no_data_found then\n    null;\n  \nend TRG_BI_AD_COLUMN;\n"}`;
    
    }
}
