
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_ROTA
    {
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_OPER_DUPLA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string MSG_NF { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_ROTA_ID { get; set; }
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
        public string DESC_ROTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TRANSPORTADORA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MINIMO_A_COBRAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_A_COBRAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MINIMO_A_PAGAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_A_PAGAR { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Nro. da Placa
        /// </summary>
        public string PLACA { get; set; }
        
        /// <summary>
        /// Estado (UF)
        /// </summary>
        public int BEG_UF_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indicativo  - (E)mitente ou (D)estinario
        /// </summary>
        public string IND_EMIT_DEST { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FRO_ROTA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  --\n  :new.DESC_ROTA := UPPER(:new.DESC_ROTA);\n  --\nend BEG_FRO_TRG_BIU_ROTA;\n"}`;
    
    }
}
