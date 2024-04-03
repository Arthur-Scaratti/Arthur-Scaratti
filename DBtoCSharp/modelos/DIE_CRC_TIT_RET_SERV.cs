
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_TIT_RET_SERV
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_TIT_RET_SERV_ID { get; set; }
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
        public int PARCELA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TITULO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_NF_SAIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_PRE_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_NFS_RETORNO_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_COBRANCA { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
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
        public int VLR_TX_FINANCEIRA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SRDUP { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CLASSIF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PAGO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }
        
        /// <summary>
        /// Id do recibo do caixa
        /// </summary>
        public int DIE_CRC_RECIBO_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_CRC_TIT_RET_SERV { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  pragma autonomous_transaction;\n\n  CURSOR C_SERV IS\n    SELECT S.*\n      FROM DIE_FAT_SERVICO_RET S\n     WHERE S.DIE_FAT_NFS_RET_ID = :NEW.DIE_FAT_PRE_NFS_ID\n       AND TRUNC(S.CREATED)  = TRUNC(:NEW.DT_EMISSAO)\n       AND NOT EXISTS (SELECT 1 FROM DIE_FAT_SERVICO SS WHERE SS.DIE_FAT_SERVICO_ID = S.DIE_FAT_SERVICO_RET_ID);\n\n  R_SERV C_SERV%ROWTYPE;\n\nbegin\n\n  IF :NEW.STATUS = 100 THEN\n  \n   \n  \n    -- V_TIT_ID := BEG_FNC_AD_SEQUENCE('BEG_CRC_TITULO');\n    INSERT INTO BEG_CRC_TITULO\n    \n      (\n       \n       BEG_CRC_TITULO_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       VALUE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       PARCELA,\n       DT_EMISSAO,\n       DT_VCTO,\n       VLR_TITULO,\n       VLR_MULTA,\n       VLR_JUROS,\n       VLR_DESCONTO,\n       VLR_ABERTO,\n       TP_COBRANCA,\n       NUMERO_TITULO_BANCO,\n       OBS,\n       VLR_DESPESA,\n       BEG_TIPO_TITULO_ID,\n       BEG_PESSOA_ID,\n       BEG_MOEDA_ID,\n       BEG_CONVENIO_ID,\n       BEG_BANCO_ID,\n       SERIE,\n       NUM_NF_SAIDA,\n       IND_ABERTO,\n       DT_ENVIO_BCO,\n       SEQ_ENVIO_BCO,\n       BEG_FILIAL_ID,\n       BEG_CRC_RENEGOCIACAO_ID,\n       IMPRESSO,\n       BEG_COB_AVISO_ID,\n       BEG_FIN_PORTADOR_ID,\n       IND_LOTE_COB_ESCR,\n       BEG_PCE_LOTE_COBRANCA_ID,\n       LINHA_DIGITAVEL,\n       CODIGO_BARRAS,\n       BEG_PCE_COMANDO_REM_COB_ID,\n       BEG_PCE_INSTRUCAO_COBRANCA_ID,\n       BEG_VW_PCE_INSTR_COBR_ID,\n       COMISSAO,\n       BEG_VEN_PEDIDO_ID,\n       BEG_FAT_NFS_ID,\n       VLR_SEGURO,\n       VLR_GARANTIA,\n       VLR_TX_FINANCEIRA,\n       BEG_CRC_LOCALIZACAO_ID,\n       BEG_VW_PREPOSTO_ID,\n       BEG_VW_TELEVENDA_ID,\n       VLR_REAJUSTE,\n       SRDUP,\n       CLASSIF,\n       DT_AVISO_PGTO,\n       NUM_NF_DEVOL,\n       TIPO_DEVOL,\n       DATA_DEVOL,\n       BEG_COB_AVISO_PESSOA_ID,\n       BEG_COBRADOR_ID,\n       VLR_ORIGINAL,\n       DT_GERA_AVISO,\n       IND_COBRADOR,\n       DT_PGTO_COBRANCA,\n       VLR_SEGUROS,\n       DT_PGTO,\n       IND_NEW_PDV)\n    VALUES\n      (\n       \n       --V_TIT_ID,\n       :NEW.DIE_CRC_TIT_RET_SERV_ID,\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID,\n       :NEW.ISACTIVE,\n       :new.Num_Nf_Saida, --:NEW.VALUE,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       :NEW.PARCELA,\n       :NEW.DT_EMISSAO,\n       :NEW.DT_VCTO,\n       :NEW.VLR_TITULO,\n       0, --:NEW.VLR_MULTA                     ,\n       0, -- :NEW.VLR_JUROS                     ,\n       0, --:NEW.VLR_DESCONTO                  ,\n       :NEW.VLR_TITULO,\n       :NEW.TP_COBRANCA,\n       NULL, --:NEW.NUMERO_TITULO_BANCO           ,\n       :NEW.OBS ||' (ID RECIBO : '||:NEW.DIE_CRC_RECIBO_ID||')',\n       0, --:NEW.VLR_DESPESA                   ,\n       :NEW.BEG_TIPO_TITULO_ID,\n       :NEW.BEG_PESSOA_ID,\n       1000000, --:NEW.BEG_MOEDA_ID,\n       CASE WHEN :NEW.BEG_CONVENIO_ID = 0 THEN NULL ELSE\n       :NEW.BEG_CONVENIO_ID END,\n       NULL, --:NEW.BEG_BANCO_ID                  ,\n       :NEW.SERIE,\n       :new.Num_Nf_Saida,\n       'Y', --:NEW.IND_ABERTO                    ,\n       NULL, --:NEW.DT_ENVIO_BCO                  ,\n       NULL, --:NEW.SEQ_ENVIO_BCO                 ,\n       :NEW.BEG_FILIAL_ID,\n       NULL, --:NEW.BEG_CRC_RENEGOCIACAO_ID       ,\n       NULL, --:NEW.IMPRESSO                      ,\n       NULL, --:NEW.BEG_COB_AVISO_ID              ,\n       NULL, --:NEW.BEG_FIN_PORTADOR_ID           ,\n       'N', --:NEW.IND_LOTE_COB_ESCR             ,\n       NULL, --:NEW.BEG_PCE_LOTE_COBRANCA_ID      ,\n       NULL, --:NEW.LINHA_DIGITAVEL               ,\n       NULL, --:NEW.CODIGO_BARRAS                 ,\n       NULL, --:NEW.BEG_PCE_COMANDO_REM_COB_ID    ,\n       NULL, --:NEW.BEG_PCE_INSTRUCAO_COBRANCA_ID ,\n       NULL, --:NEW.BEG_VW_PCE_INSTR_COBR_ID      ,\n       0, --:NEW.COMISSAO                      ,\n       NULL, --:NEW.BEG_VEN_PEDIDO_ID             ,\n       :NEW.DIE_FAT_PRE_NFS_ID, --:NEW.BEG_FAT_NFS_ID                ,\n       :NEW.VLR_SEGURO,\n       :NEW.VLR_TITULO,  -- VLR_GARANTIA\n       :NEW.VLR_TX_FINANCEIRA,\n       NULL, --:NEW.BEG_CRC_LOCALIZACAO_ID        ,\n       NULL, --:NEW.BEG_VW_PREPOSTO_ID            ,\n       NULL, --:NEW.BEG_VW_TELEVENDA_ID           ,\n       0, --:NEW.VLR_REAJUSTE                  ,\n       :NEW.SRDUP,\n       '1', --:NEW.CLASSIF,\n       NULL, --:NEW.DT_AVISO_PGTO                 ,\n       NULL, --:NEW.NUM_NF_DEVOL                  ,\n       NULL, --:NEW.TIPO_DEVOL                    ,\n       NULL, --:NEW.DATA_DEVOL                    ,\n       NULL, --:NEW.BEG_COB_AVISO_PESSOA_ID       ,\n       NULL, --:NEW.BEG_COBRADOR_ID               ,\n       0, --:NEW.VLR_ORIGINAL                  ,\n       NULL, --:NEW.DT_GERA_AVISO                 ,\n       'N', --:NEW.IND_COBRADOR                  ,\n       NULL, --:NEW.DT_PGTO_COBRANCA              ,\n       :NEW.VLR_SEGUROS,\n       NULL, --  :NEW.DT_PGTO\n       'Y')\n    \n    ;\n    --    COMMIT;\n    ------------------\n    insert into BEG_CRC_HISTORICO\n      (BEG_CRC_HISTORICO_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       value,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       VLR_MOVTO,\n       VLR_JUROS,\n       VLR_MULTA,\n       VLR_DESCONTO,\n       RECIBO_PAGTO,\n       BEG_CRC_TPMOV_ID,\n       BEG_CRC_TITULO_ID)\n    values\n      (BEG_FNC_AD_SEQUENCE('BEG_CRC_HISTORICO'),\n       :new.AD_CLIENT_ID,\n       :new.AD_ORG_ID,\n       :new.ISACTIVE,\n       1,\n       :new.CREATED, --sysdate, -- AOK -- 24/09/2007\n       :new.CREATEDBY,\n       :new.UPDATED, --sysdate, -- AOK -- 24/09/2007\n       :new.UPDATEDBY,\n       :NEW.VLR_TITULO,\n       0,\n       0,\n       0,\n       null,\n       1000001,\n       :NEW.DIE_CRC_TIT_RET_SERV_ID);\n  \n    ------------------\n    commit;\n    IF :NEW.BEG_TIPO_TITULO_ID IN (2500022) THEN\n      INSERT INTO BEG_CRC_HISTORICO\n        (BEG_CRC_HISTORICO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         VALUE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         VLR_MOVTO,\n         VLR_JUROS,\n         VLR_MULTA,\n         VLR_DESCONTO,\n         RECIBO_PAGTO,\n         BEG_CRC_TPMOV_ID,\n         BEG_CRC_TITULO_ID,\n         BEG_PESSOA_COBRADOR_ID,\n         BEG_PESSOA_CAIXA_ID,\n         BEG_BANCO_ID,\n         BEG_FILIAL_PGTO_ID,\n         DT_PGTO,\n         COMISSAO,\n         SEQ_PGTO,\n         VLR_DESPESA,\n         VLR_REAJUSTE,\n         NRO_CAIXA,\n         OBS,\n         LOTE_MANUAL,\n         BEG_VEN_CONV_REC_FAT_LOT_ID,\n         IND_RENEGOCIACAO)\n      VALUES\n        (BEG_FNC_AD_SEQUENCE('BEG_CRC_HISTORICO'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'Y', --ISACTIVE                    ,\n         '2', --VALUE                       ,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         :NEW.VLR_TITULO, --VLR_MOVTO                   ,\n         0, --VLR_JUROS                   ,\n         0, --VLR_MULTA                   ,\n         0, --VLR_DESCONTO                ,\n         NULL, --RECIBO_PAGTO                ,\n         1000006, --BEG_CRC_TPMOV_ID            ,\n         :NEW.Die_Crc_Tit_Ret_Serv_Id, --BEG_CRC_TITULO_ID           ,\n         NULL, --BEG_PESSOA_COBRADOR_ID      ,\n         NULL, --BEG_PESSOA_CAIXA_ID         ,\n         NULL, --BEG_BANCO_ID                ,\n         :NEW.AD_ORG_ID, --BEG_FILIAL_PGTO_ID          ,\n         :NEW.DT_EMISSAO, --DT_PGTO                     ,\n         NULL, --COMISSAO                    ,\n         NULL, --SEQ_PGTO                    ,\n         0, ---VLR_DESPESA                 ,\n         0, --VLR_REAJUSTE                ,\n         0, --NRO_CAIXA                   ,\n         NULL, --OBS                         ,\n         NULL, --LOTE_MANUAL                 ,\n         NULL, --BEG_VEN_CONV_REC_FAT_LOT_ID ,\n         'N' ---IND_RENEGOCIACAO\n         );\n    \n    END IF;\n  \n   FOR R_SERV IN C_SERV LOOP\n        INSERT INTO DIE_FAT_SERVICO\n          (DIE_FAT_SERVICO_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           VALUE,\n           DT_INICIO,\n           DT_FIM,\n           DT_CANCELAMENTO,\n           NRO_AUT_DEVOLUCAO,\n           VLR_PRECO,\n           NRO_SERIE,\n           IND_TIPO_VENDA,\n           COD_SERVICO,\n           DT_ENVIO,\n           BEG_PRODUTO_ID,\n           BEG_PRD_SKU_ID,\n           BEG_FAT_NFS_ITEM_ID,\n           DIE_GER_VENDEDOR_ID,\n           VLR_PRODUTO,\n           DIE_PRD_GARANTIA_ID,\n           BEG_CPR_NFE_ID,\n           DIE_CRC_RECIBO_ID,\n           OBSERVACAO,\n           DATA,\n           CEP,\n           ENDERECO,\n           NUMERO,\n           BAIRRO,\n           CIDADE,\n           ESTADO,\n           TIPORISCO,\n           NRSORTE,\n           APOLICEGAR,\n           APOLICEPF,\n           APOLICERES,\n           BEG_FAT_NFS_ID,\n           NR_RECIBO,\n           BEG_PESSOA_ID,\n           NRO_NOTA,\n           SERIE_NOTA)\n        VALUES\n          (R_SERV.DIE_FAT_SERVICO_RET_ID,\n           R_SERV.AD_CLIENT_ID,\n           R_SERV.AD_ORG_ID,\n           R_SERV.ISACTIVE,\n           R_SERV.CREATED,\n           R_SERV.CREATEDBY,\n           R_SERV.UPDATED,\n           R_SERV.UPDATEDBY,\n           R_SERV.VALUE,\n           trunc(R_SERV.DT_INICIO),\n           trunc(R_SERV.DT_FIM),\n           R_SERV.DT_CANCELAMENTO,\n           R_SERV.NRO_AUT_DEVOLUCAO,\n           R_SERV.VLR_PRECO,\n           R_SERV.NRO_SERIE,\n           R_SERV.IND_TIPO_VENDA,\n           R_SERV.COD_SERVICO,\n           R_SERV.DT_ENVIO,\n           R_SERV.BEG_PRODUTO_ID,\n           R_SERV.BEG_PRD_SKU_ID,\n           R_SERV.DIE_FAT_NFS_ITEM_RETORNO_ID, ---BEG_FAT_NFS_ITEM_ID ,\n           R_SERV.DIE_GER_VENDEDOR_ID,\n           R_SERV.VLR_PRODUTO,\n           R_SERV.DIE_PRD_GARANTIA_ID,\n           R_SERV.BEG_CPR_NFE_ID,\n           R_SERV.DIE_CRC_RECIBO_ID,\n           R_SERV.OBSERVACAO,\n           TRUNC(R_SERV.CREATED),\n           R_SERV.CEP,\n           R_SERV.ENDERECO,\n           R_SERV.NUMERO,\n           R_SERV.BAIRRO,\n           R_SERV.CIDADE,\n           R_SERV.ESTADO,\n           R_SERV.TIPORISCO,\n           R_SERV.NRSORTE,\n           R_SERV.APOLICEGAR,\n           R_SERV.APOLICEPF,\n           R_SERV.APOLICERES,\n           R_SERV.DIE_FAT_NFS_RET_ID, --BEG_FAT_NFS_ID      ,\n           R_SERV.NR_RECIBO,\n           :NEW.BEG_PESSOA_ID,\n           :NEW.NUM_NF_SAIDA,\n           :NEW.SERIE);\n      \n      END LOOP;\n  \n  \n    COMMIT;\n  END IF;\n\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BI_CRC_TIT_RET_SERV { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n\n\n\n  CURSOR C1 IS\n\n    SELECT MAX(T.SRDUP) SERIE\n      FROM BEG_CRC_TITULO T\n     WHERE T.VALUE = :NEW.NUM_NF_SAIDA\n       AND T.AD_ORG_ID = :NEW.AD_ORG_ID\n       ;\n\n  R1 C1%ROWTYPE;\n\n  V_SERIE VARCHAR2(1);\n\nbegin\n\n\n IF INSERTING THEN\n\n    OPEN C1;\n    FETCH C1\n      INTO R1;\n    CLOSE C1;\n\n    V_SERIE := NVL(R1.SERIE,3) + 1 ;\n\n    :NEW.SRDUP := V_SERIE;\n\n END IF;\n\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_BI_CRC_TIT_RET_SERV { get; set; } = `{"triggering_event":"INSERT","trigger_body":"BEGIN\n\n\n :NEW.DIE_CRC_TIT_RET_SERV_ID := BEG_FNC_AD_SEQUENCE('BEG_CRC_TITULO');\n\n\n\n\nEND DIE_BI_CRC_TIT_RET_SERV;\n"}`;
    
    }
}
