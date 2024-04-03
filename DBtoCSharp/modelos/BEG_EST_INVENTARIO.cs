
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_EST_INVENTARIO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_INVENTARIO_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIAL { get; set; }
            [Required]
        /// <summary>
        /// WC-Aguardando confirmacao, CO-Completo
        /// </summary>
        public string DOCSTATUS { get; set; }

        [NotMapped]
        public string Trigger_TBIU_EST_INVENTAROIO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  -- local variables here\n  cursor C_RESERVAS is\n    select count(*)\n      from BEG_VW_RESERVAS_ITEM A\n     where A.BEG_EST_ALMOXARIFADO_ID = :new.BEG_EST_ALMOXARIFADO_ID;\n  --\n  V_TOTAL binary_integer := 0;\n  ---\nbegin\n  --Verificando as reservas\n  open C_RESERVAS;\n  fetch C_RESERVAS\n    into V_TOTAL;\n  close C_RESERVAS;\n\n  if V_TOTAL > 0 then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Existem reservas neste almoxarifado e o inventario n?o pode ser inicializado !');\n  end if;\n  :new.DOCSTATUS := 'IP';\nend;\n"}`;
    
    }
}
