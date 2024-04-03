
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_PEDIDO_CONFERIDO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_DIVISAO_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PESSOA_ENTREGA_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PEDIDO_CONFERIDO_ID { get; set; }
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
        public int PESO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VOLUME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PEDIDO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARTES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string AGUARDANDO_LIBERACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RECALCULA_PEDIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_BASE_VCTO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BI_PED_CONF { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  cursor BUSCA_PEDIDO is\n    select P.DOCSTATUS,\n           PV.value,\n           P.BEG_GER_DIVISAO_PEDIDO_ID,\n           P.BEG_VW_CLIENTE_ID\n      from BEG_VEN_PEDIDO      P,\n           BEG_VEN_PLANO_VENDA PV\n     where P.BEG_VEN_PEDIDO_ID = :new.BEG_VEN_PEDIDO_ID\n       and P.BEG_VEN_PLANO_VENDA_ID = PV.BEG_VEN_PLANO_VENDA_ID(+);\n  --\n  VREG1 BUSCA_PEDIDO%rowtype;\n  --\nbegin\n  open BUSCA_PEDIDO;\n  fetch BUSCA_PEDIDO\n    into VREG1;\n  close BUSCA_PEDIDO;\n  :NEW.BEG_VW_PESSOA_ENTREGA_ID := VREG1.BEG_VW_CLIENTE_ID;\n  :NEW.BEG_GER_DIVISAO_PEDIDO_ID := VREG1.BEG_GER_DIVISAO_PEDIDO_ID;\nend BEG_TRG_BI_PED_CONF;\n"}`;
    
    }
}
