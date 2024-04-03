
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_PRINTFORMATITEM_TRL
    {
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
        public string PRINTNAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISTRANSLATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PRINTNAMESUFFIX { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTFORMATITEM_ID { get; set; }
            [Required]
    [StringLength(6)]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string AD_LANGUAGE { get; set; }
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

        [NotMapped]
        public string Trigger_BEG_TRG_BUD_AD_PRINTFRMIT_TRL { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que bloqueia a alteração de formatos de impressão criados como padrão. Por hora\n                  serão testados IDs fixos.\n   Modulo.......: AD - Dicionário\n   Analista.....: Tiago Gabriel\n   Alterações:\n   Data        Desenvolvedor  Alteração\n   17/10/2007  Tiago Gabriel  Criação.\n   30/06/2008  Tiago Gabriel  Alterada função de validação. Passou a buscar informações em tabela.\n  --------------------------------------------------------------------------------------------------- */\n  VN_AD_PRINTFORMAT_ID AD_PRINTFORMAT.AD_PRINTFORMAT_ID%type;\n\nbegin\n--  select AD_PRINTFORMAT_ID\n--    into VN_AD_PRINTFORMAT_ID\n--    from AD_PRINTFORMATITEM\n--   where AD_PRINTFORMATITEM_ID = :new.AD_PRINTFORMATITEM_ID;\nNULL;\n--  if BEG_FNC_AD_CHANGEPRINTFORMAT(VN_AD_PRINTFORMAT_ID, :new.UPDATEDBY) = 'N' then\n--    RAISE_APPLICATION_ERROR(-20001,\n--                            'Formato de impressão padrão não pode ser alterado!');\n--  end if;\n\nend BEG_TRG_BUD_AD_PRINTFRMIT_TRL;"}`;
    
    }
}
