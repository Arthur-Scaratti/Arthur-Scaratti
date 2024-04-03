
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_PEDIDO_CONSOLIDADO
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PEDIDO_CONSOLIDADO_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_DIVISAO_PEDIDO_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_TIPO_PEDIDO_ID { get; set; }

        [NotMapped]
        public string Trigger_BKN_TRG_CONSOLIDA_PED { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  -- local variables here\n  cursor busca_dados_pedido is \n    select P.beg_vw_cliente_id,\n           P.beg_ger_divisao_pedido_id,\n           P.BEG_VEN_TIPO_PEDIDO_ID,\n           TP.IND_ACEITA_AGRUPAMENTO\n    from   beg_ven_pedido p, \n           BEG_VEN_TIPO_PEDIDO TP\n    where  p.beg_ven_pedido_id = :new.beg_ven_pedido_id\n    AND    TP.BEG_VEN_TIPO_PEDIDO_ID = P.BEG_VEN_TIPO_PEDIDO_ID;\n  --\n  v_pedido busca_dados_pedido%rowtype;\n  --\n  cursor busca_demais is \n    select P.BEG_VEN_PEDIDO_ID,\n           P.DT_ENTREGA\n    from   beg_ven_pedido p,\n           BEG_VEN_TIPO_PEDIDO T\n    where  p.beg_vw_cliente_id = :new.beg_vw_cliente_id\n-- comentado em 19/02/2018 para permitir agrupar pedidos de depositos diferentes\n--    and    NVL(p.beg_ger_divisao_pedido_id,-1) = NVL(:new.beg_ger_divisao_pedido_id,-1)\n    AND    P.BEG_VEN_PEDIDO_ID <> :NEW.BEG_VEN_PEDIDO_ID\n    and    nvl(p.num_nf,0) = 0\n    and    exists (select 1 \n                   from   beg_ven_pedido_conferido c\n                   where  c.beg_ven_pedido_id = p.beg_ven_pedido_id)\n    and    exists (select 1 \n                   from   BEG_VEN_LINHA_PEDIDO c\n                   where  c.beg_ven_pedido_id = p.beg_ven_pedido_id)    \n    AND    T.BEG_VEN_TIPO_PEDIDO_ID = P.BEG_VEN_TIPO_PEDIDO_ID\n/*    AND    ((NVL(V_PEDIDO.IND_ACEITA_AGRUPAMENTO,'N') ='N'\n           AND T.BEG_VEN_TIPO_PEDIDO_ID = V_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID)\n           OR (NVL(V_PEDIDO.IND_ACEITA_AGRUPAMENTO,'N') ='Y'\n           AND T.BEG_VEN_TIPO_PEDIDO_ID IN(SELECT TR.BEG_VEN_TIPO_PEDIDO_ID\n                                           FROM   BEG_VEN_TIPO_PEDIDO TR\n                                           WHERE  TR.IND_ACEITA_AGRUPAMENTO = 'Y')))*/;\n  --\n  v_demais     busca_demais%rowtype;\n  --\nbegin\n  open busca_dados_pedido;\n  fetch busca_dados_pedido into v_pedido;\n  close busca_dados_pedido;\n  :new.beg_vw_cliente_id := v_pedido.beg_vw_cliente_id;\n  :new.beg_ger_divisao_pedido_id := v_pedido.beg_ger_divisao_pedido_Id;\n  :NEW.BEG_VEN_TIPO_PEDIDO_ID := V_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID;\n  :new.docstatus := 'IP';\n  open busca_demais;\n  loop\n    fetch busca_demais into v_demais;\n    exit when busca_demais%notfound;\n    insert into beg_ven_pedido_origem\n      (beg_ven_pedido_origem_id,\n       ad_client_id,\n       ad_org_id,\n       isactive,\n       created,\n       createdby,\n       updated,\n       updatedby,\n       beg_ven_pedido_consolidado_id,\n       beg_ven_pedido_id,\n       dt_entrega)\n    values\n      (beg_fnc_ad_sequence('BEG_VEN_PEDIDO_ORIGEM'),\n       :new.ad_client_id,\n       :new.ad_org_id,\n       'N',--       :new.isactive,\n       :new.created,\n       :new.createdby,\n       :new.updated,\n       :new.updatedby,\n       :new.beg_ven_pedido_consolidado_id,\n       v_demais.beg_ven_pedido_id,\n       v_demais.dt_entrega);\n  end loop;\n  close busca_demais;\nend bkn_trg_consolida_ped;\n"}`;
    
    }
}
