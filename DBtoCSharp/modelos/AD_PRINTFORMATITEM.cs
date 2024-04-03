
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_PRINTFORMATITEM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTFORMATITEM_ID { get; set; }
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
        public int AD_PRINTFORMAT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PRINTNAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPRINTED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PRINTAREATYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SEQNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PRINTFORMATTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_COLUMN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTFORMATCHILD_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISRELATIVEPOSITION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISNEXTLINE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int XSPACE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int YSPACE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int XPOSITION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int YPOSITION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MAXWIDTH { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISHEIGHTONELINE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MAXHEIGHT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string FIELDALIGNMENTTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string LINEALIGNMENTTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTCOLOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTFONT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISORDERBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SORTNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISGROUPBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPAGEBREAK { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSUMMARIZED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IMAGEISATTACHED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IMAGEURL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISAVERAGED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCOUNTED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSETNLPOSITION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSUPPRESSNULL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BELOWCOLUMN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTGRAPH_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISFIXEDWIDTH { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISNEXTPAGE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PRINTNAMESUFFIX { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMINCALC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMAXCALC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISRUNNINGTOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RUNNINGTOTALLINES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISVARIANCECALC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDEVIATIONCALC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISFILLEDRECTANGLE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LINEWIDTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ARCDIAMETER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SHAPETYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCENTRALLYMAINTAINED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISIMAGEFIELD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string BARCODETYPE { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BUD_AD_PRINTFORMATITEM { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"begin\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que bloqueia a alteração de formatos de impressão criados como padrão. Por hora\n                  serão testados IDs fixos.\n   Modulo.......: AD - Dicionário\n   Analista.....: Tiago Gabriel\n   Alterações:\n   Data        Desenvolvedor  Alteração\n   17/10/2007  Tiago Gabriel  Criação.\n   30/06/2008  Tiago Gabriel  Alterada função de validação. Passou a buscar informações em tabela.\n  --------------------------------------------------------------------------------------------------- */\n--  if BEG_FNC_AD_ChangePrintFormat( :new.ad_printformat_id, :new.updatedby ) = 'N' then\n--    Raise_Application_Error( -20001, 'Formato de impressão padrão não pode ser alterado!' );\n--  end if;\n  NULL;\nend BEG_TRG_BUD_AD_PRINTFORMATITEM;"}`;
    
    }
}
