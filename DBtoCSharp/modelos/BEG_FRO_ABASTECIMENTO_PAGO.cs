
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_ABASTECIMENTO_PAGO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NOTA_FISCAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_ABASTECIMENTO_PAGO_ID { get; set; }
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
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_PAGTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_PGTO_ABAST_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_ABASTECIMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABAST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_ORDEM_SERVICO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_OS { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FRO_ABAS_PAGO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  cursor C_ABASTECIMENTO(P_BEG_FRO_ABASTECIMENTO_ID number) is\n    select B.VLR_ABAST,\n           B.VLR_ORDEM_SERVICO,\n           B.BEG_FRO_ORDEM_SERVICO_ID,\n           B.NOTA_FISCAL,\n           B.DT_ABAST\n      from BEG_FRO_ABASTECIMENTO B\n     where B.BEG_FRO_ABASTECIMENTO_ID = P_BEG_FRO_ABASTECIMENTO_ID;\n\n  V_VLR_ABASTECIMENTO number(18, 4);\n  V_VLR_OS            number(18, 4);\n\nbegin\n  if :new.ISACTIVE = :old.ISACTIVE then -- AOK -- 30/01/2008\n    open C_ABASTECIMENTO(:new.BEG_FRO_ABASTECIMENTO_ID);\n  \n    fetch C_ABASTECIMENTO\n      into V_VLR_ABASTECIMENTO, V_VLR_OS, :new.BEG_FRO_ORDEM_SERVICO_ID, :new.NOTA_FISCAL, :new.DATA;\n  \n    close C_ABASTECIMENTO;\n  \n    :new.VLR_ABAST := V_VLR_ABASTECIMENTO;\n    :new.VLR_OS    := V_VLR_OS;\n    :new.VLR_TOTAL := V_VLR_OS + V_VLR_ABASTECIMENTO;\n    --  DBMS_OUTPUT.PUT_LINE(V_VLR_ABASTECIMENTO || ' ' || V_VLR_OS || ' ' ||\n    --                      :new.VLR_TOTAL);\n  end if;\nend;\n"}`;
    
    }
}
