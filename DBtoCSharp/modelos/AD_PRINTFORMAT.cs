
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_PRINTFORMAT
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTPAPER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTCOLOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTFONT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSTANDARDHEADERFOOTER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int HEADERMARGIN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int FOOTERMARGIN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATECOPY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_REPORTVIEW_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTTABLEFORMAT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PRINTERNAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDEFAULT { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTFORMAT_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISTABLEBASED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISFORM { get; set; }
            [Required]
        /// <summary>
        /// AD_Table_ID Definition
        /// </summary>
        public int AD_TABLE_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BUD_AD_PRINTFORMAT { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"begin\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que bloqueia a alteração de formatos de impressão criados como padrão. Por hora\n                  serão testados IDs fixos.\n   Modulo.......: AD - Dicionário\n   Analista.....: Tiago Gabriel\n   Alterações:\n   Data        Desenvolvedor  Alteração\n   17/10/2007  Tiago Gabriel  Criação.\n   30/06/2008  Tiago Gabriel  Alterada função de validação. Passou a buscar informações em tabela.\n  --------------------------------------------------------------------------------------------------- */\n  --if BEG_FNC_AD_CHANGEPRINTFORMAT(:new.AD_PRINTFORMAT_ID, :new.UPDATEDBY) = 'N' then\n  --  RAISE_APPLICATION_ERROR(-20001,\n  --                          'Formato de impressão padrão não pode ser alterado!');\n  --end if;\n  NULL;\nend BEG_TRG_BUD_AD_PRINTFORMAT;"}`;
    
    }
}
