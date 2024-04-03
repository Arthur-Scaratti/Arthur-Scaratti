
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_MULTA
    {
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
        public string DT_MULTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PONTUACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MULTA { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL_INFRACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_VEICULO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_VW_MOTORISTA_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_MULTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PGTO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_MULTA_ID { get; set; }
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

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FRO_MULTA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  :new.LOCAL_INFRACAO := UPPER(:new.LOCAL_INFRACAO);\nend TRG_BIU_BEG_FRO_MULTA;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BI_BEG_FRO_MULTA { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  cursor BUSCA_MOTORISTA is\n    select SV.BEG_FRO_VW_MOTORISTA_ID MOTORISTA\n      from BEG_FRO_SAIDA_VEICULO SV\n     where SV.BEG_FRO_VEICULO_ID = :new.BEG_FRO_VEICULO_ID\n       and :new.DT_MULTA between SV.DT_INICIAL and\n           NVL(SV.DT_FINAL, sysdate);\n  --\n  WREG BUSCA_MOTORISTA%rowtype;\n  --\nbegin\n  --\n  open BUSCA_MOTORISTA;\n  fetch BUSCA_MOTORISTA\n    into WREG;\n  if BUSCA_MOTORISTA%notfound then\n    close BUSCA_MOTORISTA;\n    RAISE_APPLICATION_ERROR(-20000,\n                            'Não existe saida do veiculo para registro desta multa');\n  end if;\n  close BUSCA_MOTORISTA;\n  :new.BEG_FRO_VW_MOTORISTA_ID := WREG.MOTORISTA;\n  --\nend TRG_BI_BEG_FRO_MULTA;\n"}`;
    
    }
}
