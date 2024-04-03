
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PARAMETRO_SISTEMA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PARAMETRO_SISTEMA_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo de parametro: C - Caracter / D - Data / T - Data e hora (time) / E - Chave Extrangeira / N - Numerico / P - Percentual
        /// </summary>
        public string TP_PARAMETRO { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string CARACTER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUMERO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERCENTUAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_MODULO_SISTEMA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_SUBMODULO_SISTEMA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TABLE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_COLUMN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_PARAMETRO_SISTEMA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /*-----------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que passa para upper case o nome dos parametros cadastrados.\n  Modulo.......: GER - Geral\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  25/08/2006  Tiago Gabriel  Criac?o.\n  -----------------------------------------------------------------------------------------------------*/\n\nbegin\n  :new.name := Upper( :new.name );\n\nend TRG_BIU_BEG_PARAMETRO_SISTEMA;\n"}`;
    
    }
}
