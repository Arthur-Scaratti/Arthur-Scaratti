
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CAR_UNIDADE
    {
            [Required]
        /// <summary>
        /// Código da Bandeira.
        /// </summary>
        public int BEG_CAR_BANDEIRA_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Código da loja conforme bandeira
        /// </summary>
        public string COD_LOJA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CAR_UNIDADE_ID { get; set; }
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
        /// Conta Corrente.
        /// </summary>
        public int BEG_FIN_CONTA_CORRENTE_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_CAR_UNIDADE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  cursor C1 is\n    select U.AD_ORG_ID,\n           U.COD_LOJA,\n           U.BEG_CAR_BANDEIRA_ID\n      from BEG_CAR_UNIDADE U\n     where U.AD_ORG_ID = :new.AD_ORG_ID\n       and U.BEG_CAR_BANDEIRA_ID = :new.BEG_CAR_BANDEIRA_ID\n       and U.COD_LOJA = :new.COD_LOJA\n       and U.ISACTIVE = 'Y';\n  R1 C1%rowtype;\n\n  pragma autonomous_transaction;\n  /* utilizado para o caso de necessitar desativar algum registro, em caso de não utilização\n  do pragma autonomous_transaction o erro de mutating table será apresentado.*/\n\nbegin\n\n  open C1;\n  fetch C1\n    into R1;\n\n  if C1%found\n     and :new.ISACTIVE = 'Y' then\n  \n    RAISE_APPLICATION_ERROR(-20002,\n                            'Já existe o mesmo Código de Loja Ativo para esta filial!');\n  \n  end if;\n\n  close C1;\n\nend DIE_TRG_BIU_CAR_UNIDADE;\n"}`;
    
    }
}
