
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PEDIDO
    {
            [StringLength(1)]
        /// <summary>
        /// indica pedido com produto sob encomenda - EM DESUSO. Sera pelo tipo de entrega
        /// </summary>
        public string IND_ENCOMENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PEDIDO_LOJA_ID { get; set; }
        
        /// <summary>
        /// Motivo do cancelamento
        /// </summary>
        public int DIE_MOTIVO_DEVOL_ID { get; set; }
        
        /// <summary>
        /// Data do cancelamento
        /// </summary>
        public string DT_CANC { get; set; }
        
        /// <summary>
        /// Usuario que efetuou o cancelamento
        /// </summary>
        public int ID_USER_CC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RECIENTR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTRECIBO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_LIBERADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// indica necessida de aprovacao de preco
        /// </summary>
        public string LIBERA_PRECO { get; set; }
        
        /// <summary>
        /// id do usario que  aprovou o preco
        /// </summary>
        public int ID_USER_LIB_PRECO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_TIPO_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_FINANCEIRA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SEGUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PLANO_VENDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Motivo por ter sido negada o pedido
        /// </summary>
        public string NEGADO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// indica que loja solicitou liberação
        /// </summary>
        public string IND_LIBERA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// indica que o pedido gerado sera pago com cheque pre
        /// </summary>
        public string IND_CHQPRE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Descricao para a NATUREZA DA OPERACAO da NFe alternativa
        /// </summary>
        public string DESC_TP_PEDIDO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Botao para disparar processo de link de pagto
        /// </summary>
        public string IND_PGTO_LINK { get; set; }
        
        /// <summary>
        /// Campanhas de desconto
        /// </summary>
        public int DIE_PES_BONUS_VENDA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLTF_ORIG { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Quando Y indica que é do novo simulador(portal)
        /// </summary>
        public string IND_SIMULADOR { get; set; }
            [StringLength(300)]
        /// <summary>
        /// Detalhar motivo do cancelamento
        /// </summary>
        public string MOTIVO_CANCEL { get; set; }
            [StringLength(150)]
        /// <summary>
        /// Justificativa da liberaçao do preco fora do padrao
        /// </summary>
        public string MOTIVO_PRECO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PEDIDO_ID { get; set; }
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
        public string DTEMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLMERC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CUSTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int FRETE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLGARANTIA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SEGURO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string LIBERADO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string PAGAENTR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLENTRADA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTDEPARC { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPOFI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRASSOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEGNROPC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEGVEND_ID { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string PLACA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// justificativa da liberacao ou negativa da proposta
        /// </summary>
        public string LIBERA { get; set; }
            [StringLength(400)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ENDENTID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VENCENTR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DESCEXTRA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPOPESSOA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string FINALIDADE { get; set; }

        [NotMapped]
        public string Trigger_TRG_AI_DIE_PEDIDO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n\n  V_VLR_01 NUMBER(14, 2);\n  V_VLR    NUMBER(14, 2);\n  VLR_TOT  NUMBER(14, 2);\n\nBEGIN\n\n  IF INSERTING OR UPDATING THEN\n    \n    IF :NEW.BEG_EST_TP_ESPECIE_ID = 2000003 AND :NEW.TIPOFI = 3 and  :NEW.IND_SIMULADOR ='N' THEN\n    \n      V_VLR   := ROUND(((:NEW.VLR_TOTAL - NVL(:NEW.VLENTRADA, 0)) /\n                       NVL(:NEW.QTDEPARC, 1)),\n                       2);\n      VLR_TOT := (V_VLR * :NEW.QTDEPARC) + NVL(:NEW.VLENTRADA, 0);\n    \n      IF VLR_TOT <> :NEW.VLR_TOTAL THEN\n      \n        IF VLR_TOT < :NEW.VLR_TOTAL THEN\n          V_VLR_01 := V_VLR + (:NEW.VLR_TOTAL - VLR_TOT);\n        ELSE\n          V_VLR_01 := V_VLR - (VLR_TOT - :NEW.VLR_TOTAL);\n        END IF;\n      ELSE\n        V_VLR_01 := V_VLR;\n      \n      END IF;\n    \n      UPDATE DIE_PEDPARC P\n         SET P.VLPARC = V_VLR_01\n       WHERE P.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID\n         AND trim(P.PARCELA) = '1';\n    \n      UPDATE DIE_PEDPARC P\n         SET P.VLPARC = V_VLR\n       WHERE P.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID\n         AND trim(P.PARCELA) NOT IN ('1', 'E','0');\n    \n    END IF;\n  \n  END IF;\n\nEND TRG_BIU_DIE_PEDIDO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIU_DIE_PEDIDO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  v_id   number;\n  v_dias number;\n\n  cursor c1 is\n    select t.*\n      from beg_ven_tipo_pedido t\n     where t.beg_ven_tipo_pedido_id = :new.beg_ven_tipo_pedido_id;\n  r1 c1%rowtype;\n\n  cursor c2 is\n    select t.*\n      from beg_pessoa t\n     where t.beg_pessoa_id = :new.beg_pessoa_id;\n  r2 c2%rowtype;\n\n  cursor busca_fl is\n  \n    select df.*, p.beg_vw_uf_id\n      from beg_dado_filial df, beg_pessoa p\n     where df.ad_org_id = :new.ad_org_id\n       and df.beg_pessoa_id = p.beg_pessoa_id;\n\n  r_fl busca_fl%rowtype;\n\n  cursor C_RECEB IS\n    SELECT NS.NRO_NFS, FL.VALUE, NS.LIBERADO, NS.DT_EMISSAO\n      FROM BEG_FAT_NFS NS, BEG_DADO_FILIAL FL, BEG_DADO_FILIAL DF\n     WHERE FL.AD_ORG_ID = NS.AD_ORG_ID\n       AND DF.AD_ORG_ID = :NEW.AD_ORG_ID\n       AND NS.BEG_VW_PESSOA_ENTREGA_ID = DF.BEG_PESSOA_ID\n       AND NS.BEG_EST_TP_ESPECIE_ID IN\n           (2000053, 2000026, 2000027, 2000051, 2000076, 2000074)\n       AND NVL(NS.CANCELADA, 'N') = 'N'\n       AND NVL(NS.LIBERADO, 'N') = 'N'\n       AND NS.DT_EMISSAO > (trunc(sysdate - 120))\n       AND TRUNC(NS.DT_EMISSAO) < TRUNC(SYSDATE - V_DIAS)\n     ORDER BY NS.DT_EMISSAO DESC;\n  R_RECEB C_RECEB%ROWTYPE;\n\n  CURSOR C_EMIT IS\n    SELECT NS.NRO_NFS, FL.VALUE FL_DESTINO, NS.LIBERADO, NS.DT_EMISSAO\n      FROM BEG_FAT_NFS NS, BEG_DADO_FILIAL FL\n     WHERE FL.BEG_PESSOA_ID = NS.BEG_VW_PESSOA_ENTREGA_ID\n       AND FL.AD_ORG_ID NOT IN (1000134)\n       AND NS.AD_ORG_ID = :NEW.AD_ORG_ID\n       AND NS.BEG_EST_TP_ESPECIE_ID IN\n           (2000053, 2000026, 2000027, 2000051, 2000076, 2000074)\n       AND NVL(NS.CANCELADA, 'N') = 'N'\n       AND NVL(NS.LIBERADO, 'N') = 'N'\n       AND NS.DT_EMISSAO > (trunc(sysdate - 120))\n       AND TRUNC(NS.DT_EMISSAO) < TRUNC(SYSDATE - V_DIAS)\n     ORDER BY NS.DT_EMISSAO DESC;\n  R_EMIT C_EMIT%ROWTYPE;\n\n  CURSOR C_BONUS IS\n    SELECT B.*\n      FROM DIE_PES_BONUS_VENDA B\n     WHERE B.BEG_PESSOA_ID = :NEW.BEG_PESSOA_ID\n       AND TRUNC(SYSDATE) BETWEEN B.DT_INI_BONUS AND B.DT_FIM_BONUS\n       AND B.DIE_FAT_PRE_NFS_ID IS NULL\n       AND B.DIE_PES_BONUS_VENDA_ID = :NEW.DIE_PES_BONUS_VENDA_ID;\n\n  R_BONUS C_BONUS%ROWTYPE;\n\nbegin\n\n  IF INSERTING AND :NEW.BEG_VEN_TIPO_PEDIDO_ID IN (2000019, 2000015) THEN\n  \n    V_DIAS := BEG_FNC_RETORNA_PARAM_GERAL('Geral',\n                                          'Faturamento',\n                                          'DIAS_PENDENTE_NF');\n  \n    OPEN C_RECEB;\n    FETCH C_RECEB\n      INTO R_RECEB;\n    CLOSE C_RECEB;\n  \n    IF R_RECEB.NRO_NFS IS NOT NULL THEN\n      raise_application_error(-20001,\n                              'Nota de Transferencia Nr ' ||\n                              R_RECEB.NRO_NFS || ' emitida pela loja ' ||\n                              R_RECEB.VALUE || ' pendente de entrada');\n    \n    END IF;\n  \n    OPEN C_EMIT;\n    FETCH C_EMIT\n      INTO R_EMIT;\n    CLOSE C_EMIT;\n  \n    IF R_EMIT.NRO_NFS IS NOT NULL THEN\n      raise_application_error(-20001,\n                              'Nota de Transferencia Nr ' || R_EMIT.NRO_NFS ||\n                              ' emitida pela loja pendente de entrada na filial '||R_EMIT.FL_DESTINO);\n    \n    END IF;\n  \n  END IF;\n\n  if :new.ad_org_id is not null then\n  \n    OPEN busca_fl;\n    FETCH busca_fl\n      INTO r_fl;\n    CLOSE busca_fl;\n  \n    OPEN c1;\n    FETCH c1\n      INTO r1;\n    CLOSE c1;\n  \n    if r1.ind_aceita_mesma_fl = 'N' and\n       r_fl.beg_pessoa_id = :new.beg_pessoa_id and\n       :new.beg_ven_tipo_pedido_id not in (2000052, 2000013) then\n      raise_application_error(-20001,\n                              'Filial destino igual filial emitente nao permitido para este tipo de pedido');\n    end if;\n  \n    if :new.beg_ven_tipo_pedido_id = 2000004 then\n    \n      OPEN c2;\n      FETCH c2\n        INTO r2;\n      CLOSE c2;\n    \n      if r_fl.beg_vw_uf_id = r2.beg_vw_uf_id and :new.docstatus<>'CA' then\n      \n        raise_application_error(-20001,\n                                'Tipo Pedido para fora do estado porem filial e fornecedor no mesmo estado. Verifique');\n      \n      end if;\n    \n    end if;\n  \n  end if;\n\n  IF UPDATING AND :OLD.DIE_PES_BONUS_VENDA_ID IS NULL AND\n     :NEW.DIE_PES_BONUS_VENDA_ID IS NOT NULL THEN\n  \n    OPEN C_BONUS;\n    FETCH C_BONUS\n      INTO R_BONUS;\n    CLOSE C_BONUS;\n    \n    IF (:NEW.VLMERC - NVL(:NEW.DESCONTO,0) - NVL(:NEW.VLENTRADA,0)) <= R_BONUS.VLR_BONUS THEN\n      \n       raise_application_error(-20001,\n                                'Valor do Bonus maior ou igual que valor do pedido menos a entrada. Verifique');\n    \n    END IF;\n  \n    :NEW.DESCONTO  := :NEW.DESCONTO + R_BONUS.VLR_BONUS;\n    :NEW.VLR_TOTAL := :NEW.VLR_TOTAL - R_BONUS.VLR_BONUS;\n  \n    DIE_PRC_RECALC_PED_BONUS(:NEW.DIE_PEDIDO_ID, :NEW.BEG_PESSOA_ID,:NEW.DIE_PES_BONUS_VENDA_ID, :NEW.BEG_CONDICAO_PAGAMENTO_ID, :NEW.VLR_TOTAL-:NEW.VLENTRADA);\n  \n  END IF;\n\nend die_trg_biu_die_pedido;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIU_DIE_PEDIDO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  V_ID    number(10);\n  V_ID2   NUMBER(10);\n  V_COUNT NUMBER;\n  V_PROD  NUMBER(10);\n\n  cursor C_ITEM IS\n    SELECT ((I.QTDE * I.VLUNITARIO) - I.DESCONTO) VLMERC\n      FROM DIE_ITEPED I\n     WHERE I.DIE_PEDIDO_ID = V_ID;\n\n  R_ITEM C_ITEM%ROWTYPE;\n\n  CURSOR C_PARC IS\n    SELECT sum(P.Vlparc) vlr_parc\n      FROM DIE_PEDPARC P\n     WHERE P.DIE_PEDIDO_ID = :new.die_pedido_id;\n\n  R_PARC C_PARC%ROWTYPE;\n\nbegin\n  \n  IF INSERTING AND :NEW.VALUE IS NULL THEN \n    \n  :NEW.VALUE := BEG_FNC_AD_SEQUENCE_VALUE('DIE_PEDIDO');\n  \n  END IF;\n\n\n\n  IF INSERTING OR UPDATING THEN\n    :new.vlr_total := :new.vlmerc - nvl(:new.desconto, 0) +\n                      nvl(:new.vlgarantia, 0) + nvl(:new.frete, 0) +\n                      nvl(:new.seguro, 0) + nvl(:new.custo, 0) ;\n  \n  END IF;\n\n  IF :NEW.BEG_CONVENIO_ID = 0 THEN\n    :NEW.BEG_CONVENIO_ID := NULL;\n  END IF;\n  \n  IF UPDATING AND NVL(:NEW.OBSERVACAO,'$') <> NVL(:OLD.OBSERVACAO,'$') AND :NEW.DOCSTATUS = 'IP' AND :OLD.DOCSTATUS='IP' THEN\n    \n   UPDATE DIE_FAT_PRE_NFS A SET\n          A.OBS = :NEW.OBSERVACAO\n    WHERE A.DIE_PEDIDO_ID = :NEW.DIE_PEDIDO_ID;\n  \n  END IF;\n \n\nend TRG_BIU_DIE_PEDIDO;\n"}`;
    
    }
}
