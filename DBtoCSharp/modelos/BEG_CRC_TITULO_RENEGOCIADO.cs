
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_TITULO_RENEGOCIADO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TX_FINANCEIRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGURO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_GARANTIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TIT { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_RENEGOCIADO_ID { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_RENEGOCIACAO_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string RENEGOCIAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAS_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int JUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MULTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ORIGINAL { get; set; }

        [NotMapped]
        public string Trigger_TRG_BUD_TIT_RENEG { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\n  cursor BUSCA_PARCELAS is\n    select count(*) PARC\n      from BEG_CRC_PARCELA_RENEG CP\n     where CP.BEG_CRC_RENEGOCIACAO_ID = :new.BEG_CRC_RENEGOCIACAO_ID;\n  --\n  VREG1 BUSCA_PARCELAS%rowtype;\n  --\n  V_NUMERO_PARCELAS number(3);\n  V_VALOR_RATEADO   number(18, 2) := 0;\n  V_VLR             number(18, 2) := 0;\nbegin\n  if UPDATING then\n    if :new.RENEGOCIAR <> :old.RENEGOCIAR then\n      if :new.RENEGOCIAR = 'Y' then\n        open BUSCA_PARCELAS;\n        fetch BUSCA_PARCELAS\n          into VREG1;\n        close BUSCA_PARCELAS;\n        --\n        V_NUMERO_PARCELAS := VREG1.PARC;\n        VREG1.PARC        := VREG1.PARC - 1;\n        loop\n          V_VLR := ROUND((:new.VLR_ABERTO * (100 / V_NUMERO_PARCELAS)) / 100,\n                         2);\n          if VREG1.PARC > 0 then\n            V_VALOR_RATEADO := V_VALOR_RATEADO + V_VLR;\n            update BEG_CRC_PARCELA_RENEG R\n               set R.VLR_VCTO = R.VLR_VCTO + V_VLR\n             where R.BEG_CRC_RENEGOCIACAO_ID = :new.BEG_CRC_RENEGOCIACAO_ID\n               and R.PARCELA = VREG1.PARC;\n            VREG1.PARC := VREG1.PARC - 1;\n          else\n            exit;\n          end if;\n        end loop;\n        update BEG_CRC_PARCELA_RENEG R\n           set R.VLR_VCTO = R.VLR_VCTO + (:new.VLR_ABERTO - V_VALOR_RATEADO)\n         where R.BEG_CRC_RENEGOCIACAO_ID = :new.BEG_CRC_RENEGOCIACAO_ID\n           and R.PARCELA = 0;\n        --\n        update BEG_CRC_RENEGOCIACAO R\n           set R.VLR_TITULO = R.VLR_TITULO + :new.VLR_ABERTO\n         where R.BEG_CRC_RENEGOCIACAO_ID = :new.BEG_CRC_RENEGOCIACAO_ID;\n      else\n        update BEG_CRC_RENEGOCIACAO R\n           set R.VLR_TITULO = R.VLR_TITULO - :new.VLR_ABERTO\n         where R.BEG_CRC_RENEGOCIACAO_ID = :new.BEG_CRC_RENEGOCIACAO_ID;\n      end if;\n    end if;\n  else\n    update BEG_CRC_RENEGOCIACAO R\n       set R.VLR_TITULO = R.VLR_TITULO - :old.VLR_ABERTO\n     where R.BEG_CRC_RENEGOCIACAO_ID = :old.BEG_CRC_RENEGOCIACAO_ID;\n  end if;\nend TRG_BUD_TIT_RENEG;\n"}`;
    
    }
}
