
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_EST_LOTE
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string TP_MOVTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_EST_ALMOXARIFADO_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_LOTE_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_LOTE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string INVENTARIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ESPECIE_LINHA { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_INVENTARIO_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_BEG_EST_LOTE { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  cursor C_TIPO_LOTE is\n    select a.INVENTARIO,\n           a.ESPECIE_LINHA,\n           t.tp_movto\n      from BEG_EST_TP_LOTE A,\n           beg_est_tp_especie t\n     where A.BEG_EST_TP_LOTE_ID = :new.BEG_EST_TP_LOTE_ID\n     and   t.beg_est_tp_especie_id = a.beg_est_tp_especie_id;\n\n  cursor C_INVENTARIO is\n    select BEG_EST_INVENTARIO_ID\n      from BEG_EST_INVENTARIO A\n     where A.BEG_EST_ALMOXARIFADO_ID = :new.BEG_EST_ALMOXARIFADO_ID\n       and A.DOCSTATUS = 'IP';\n  V_BEG_EST_INVENTARIO_ID number(10);\nbegin\n  if INSERTING\n     or UPDATING\n     or DELETING then\n  \n    open C_TIPO_LOTE;\n    fetch C_TIPO_LOTE\n      into :new.INVENTARIO, :new.ESPECIE_LINHA,:new.tp_movto;\n    close C_TIPO_LOTE;\n  \n    if :old.DOCSTATUS = 'CO' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Lote completo n?o pode sofrer alterac?es !!!');\n    end if;\n  \n    if :new.INVENTARIO = 'Y' then\n      open C_INVENTARIO;\n      fetch C_INVENTARIO\n        into V_BEG_EST_INVENTARIO_ID;\n    \n      if C_INVENTARIO%notfound then\n        close C_INVENTARIO;\n        RAISE_APPLICATION_ERROR(-20001,\n                                'N?o existe inventario em aberto para este almoxarifado !!!');\n      else\n        close C_INVENTARIO;\n        :new.BEG_EST_INVENTARIO_ID := V_BEG_EST_INVENTARIO_ID;\n      end if;\n    \n    end if;\n  end if;\n\n  if :new.INVENTARIO = 'Y'\n     and :new.BEG_EST_INVENTARIO_ID is null then\n    RAISE_APPLICATION_ERROR(-20001, 'Inventario deve ser informado !!!');\n  end if;\n\nend;\n"}`;
    
    }
}
