
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_LOTE_COBR_TIT
    {
        
        /// <summary>
        /// Indica se o lote ja foi confirmado a nivel de itens
        /// </summary>
        public string IND_LOTE_CONFIRMADO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COB_LOTE_COBR_TIT_ID { get; set; }
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
        /// Id do titulo
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// Naum deve ser mais usado
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do parceiro comercial - devedor
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// Data de emissao
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// Data de vencimento
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// Valor em aberto do titulo
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [Required]
        /// <summary>
        /// Id do lote da cobranca - header
        /// </summary>
        public int BEG_COB_LOTE_COBR_ID { get; set; }
        
        /// <summary>
        /// Contrato
        /// </summary>
        public int CONTRATO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BUD_COB_LOTE_COBR_TIT { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n\n  VC_STATUS varchar2(2);\n\n  cursor C_STATUS is\n    select LC.DOCSTATUS\n      from BEG_COB_LOTE_COBR LC\n     where LC.BEG_COB_LOTE_COBR_ID = :old.BEG_COB_LOTE_COBR_ID;\n\n  cursor CPESSOA is\n    select 1\n      from BEG_PESSOA P\n     where P.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n       and P.CPFCNPJ is not null;\n  RPESSOA CPESSOA%rowtype;\n\n  pragma autonomous_transaction;\n\nbegin\n\n  open C_STATUS;\n  fetch C_STATUS\n    into VC_STATUS;\n  close C_STATUS;\n\n  if VC_STATUS = 'CO' then\n    if DELETING then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Lote já processado! Não permite exclusão.');\n    else\n      RAISE_APPLICATION_ERROR(-20002,\n                              'Lote já processado! Não permite alteração.');\n    end if;\n  end if;\n  -- AOK - 13/03/2009 - Não permitir reativar cliente sem cpf/cgc\n  if UPDATING then\n    if :new.ISACTIVE = 'Y'\n       and :old.ISACTIVE = 'N' then\n      open CPESSOA;\n      fetch CPESSOA\n        into RPESSOA;\n      if CPESSOA%notfound then\n        RAISE_APPLICATION_ERROR(-20003,\n                                'Registro não pode ser reativado, pois o cliente esta sem CPF / CNPJ !');\n      end if;\n    end if;\n  end if;\n  --\nend BEG_TRG_BUD_COB_LOTE_COBR_TIT;\n"}`;
    
    }
}
