
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_PROMOCAO
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_FIM { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PROMOCAO_ID { get; set; }
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
            [Required]
    [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_PROMOCAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIO { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_VEN_PROMOCAO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  pragma autonomous_transaction;\n--  VN_DUMMY number;\n\nbegin\n  if TRUNC(NVL(:new.DT_FIM, sysdate)) < TRUNC(sysdate) then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Promoc?o ja finalizada n?o permite alterac?o!');\n  end if;\n\n  if :new.DT_INICIO is null then\n    RAISE_APPLICATION_ERROR(-20001, 'Data de inicio deve ser informada!');\n  end if;\n\n  -- Verifica intervalo\n  if :new.DT_INICIO > NVL(:new.DT_FIM, :new.DT_INICIO) then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Data de inicio deve ser menor que data de fim ou esta deve estar em branco!');\n  end if;\n\n  /* Tiago Gabriel em 20/10/2006\n     Comentado por solicitac?o do Rudinei para possibilitar o cadastro de listas no mesmo periodo.\n     Apenas deve ser validado se o item existe em mais de uma lista vigente.\n  -- Verifica se existem listas abertas\n  select count(1)\n    into VN_DUMMY\n    from BEG_VEN_PROMOCAO\n   where (:new.DT_INICIO between TRUNC(DT_INICIO) and\n         NVL(TRUNC(DT_FIM), :new.DT_INICIO) or\n         (TRUNC(DT_INICIO) > :new.DT_INICIO and\n         NVL(:new.DT_FIM, TRUNC(NVL(DT_FIM, sysdate))) >=\n         TRUNC(NVL(DT_FIM, sysdate))) or\n         NVL(:new.DT_FIM, TRUNC(NVL(DT_FIM, sysdate))) >= TRUNC(DT_INICIO))\n     and BEG_VEN_PROMOCAO_ID <> NVL(:new.BEG_VEN_PROMOCAO_ID, 0);\n\n  if VN_DUMMY > 0 then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Ja existem listas vigentes para o periodo informado!');\n  end if;\n  */\n\nend TRG_BIU_BEG_VEN_PROMOCAO;\n"}`;
    
    }
}
