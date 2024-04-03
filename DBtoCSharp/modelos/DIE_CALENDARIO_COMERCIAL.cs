
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CALENDARIO_COMERCIAL
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CALENDARIO_COMERCIAL_ID { get; set; }
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
        /// Data juliana
        /// </summary>
        public int JDATE { get; set; }
            [Required]
        /// <summary>
        /// data inicio dia
        /// </summary>
        public string LDATE { get; set; }
            [Required]
        /// <summary>
        /// data final dia
        /// </summary>
        public string HDATE { get; set; }
            [Required]
        /// <summary>
        /// ano
        /// </summary>
        public int YYYY { get; set; }
            [Required]
    [StringLength(7)]
        /// <summary>
        /// ano-mes
        /// </summary>
        public string YYYY_MM { get; set; }
            [Required]
    [StringLength(7)]
        /// <summary>
        /// ano-semana
        /// </summary>
        public string YYYY_WY { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// mes numerico
        /// </summary>
        public string MM { get; set; }
            [Required]
    [StringLength(6)]
        /// <summary>
        /// mes-numerico- abreviado
        /// </summary>
        public string MM_MMSN { get; set; }
            [Required]
        /// <summary>
        /// numero do dia na semana
        /// </summary>
        public int D { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// dia mes
        /// </summary>
        public string DD { get; set; }
            [Required]
        /// <summary>
        /// numero do dia do ano
        /// </summary>
        public int DDD { get; set; }
            [Required]
        /// <summary>
        /// numero da semana do ano
        /// </summary>
        public int WY { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// dia da semana abreviado
        /// </summary>
        public string WDY { get; set; }
            [Required]
    [StringLength(7)]
        /// <summary>
        /// dia da semana
        /// </summary>
        public string WDAY { get; set; }

        [NotMapped]
        public string Trigger_DIE_CALENDARIO_COMERCIAL { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  lc__    constant varchar2(1e2) := 'Trigger ' || $$plsql_unit || ':';\nbegin\n  raise_application_error(num => -20888,\n                          msg => 'Sorry, No DML allowed:' || $$plsql_line);\nexception when others then\n  raise_application_error(num => -20777,\n                          msg => lc__ || $$plsql_line || chr(10)\n                              || sys.dbms_utility.format_error_stack);\nend die_calendario_comercial;\n------------------------------------------------------------------\n"}`;
    
    }
}
