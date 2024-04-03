
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FAT_DEV_FORNECEDOR_ITEM
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
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NFE { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE_NFE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTRADA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_UNITARIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_CUSTO_PRODUTO { get; set; }
        
        /// <summary>
        /// Valor das outras despesas.
        /// </summary>
        public int VL_CUSTO_FINANCEIRO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NFS_ENTREGA_FUT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LINHA_NFS_ENTREGA_FUT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_DESCONTO { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_TECNICA_ITEM { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_PATRIMONIO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTREGUE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string GERA_RESERVA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS_LINHA_NFS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_REDUCAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ISENTA_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_OUTRAS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ISENTA_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_OUTRAS_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_SUBST_TRIB { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_FRETE_ITEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_ORIGEM_MERC_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_DEV_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_MOVTO_ESTOQUE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_TRIB_ICMS_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CFOP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ICMS_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_DEVOLVIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_MATRIZ_TRIBUTARIA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ITEM_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CST_PIS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CST_COFINS { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CST_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ITEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_ICMS_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ISENTA_ICMS_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_OUTRAS_ICMS_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_IPI_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_IPI_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ISENTA_IPI_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_OUTRAS_IPI_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS_SUBST_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_SUBST_TRIB_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_FRETE_ITEM_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQ_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// id do almoxarifado
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_PIS_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_COFINS_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_PIS_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_COFINS_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VBCSTRET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VICMSSUBSTITUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VICMSSTRET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_CUSTO_FINANCEIRO_ORIG { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_DEV_FORNECEDOR_ITEM_ID { get; set; }
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
        public string Trigger_BEG_TRG_BIU_DEV_FORN_ITEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  V_PERC                  NUMBER(18, 8);\n  V_PERC_OLD              NUMBER(18, 8);\n  VN_VLR_COFINS           NUMBER(17, 4) := 0;\n  VN_VLR_PIS              NUMBER(17, 4) := 0;\n  VN_VLR_BASE_COFINS      NUMBER(17, 4) := 0;\n  VN_VLR_BASE_PIS         NUMBER(17, 4) := 0;\n  VN_VL_ICMS_SUBST        NUMBER(17, 4) := 0;\n  VN_VL_BASE_ICMS_SUBST   NUMBER(17, 4) := 0;\n  VN_VL_IPI               NUMBER(17, 4) := 0;\n  VN_VL_BASE_OUTRAS_IPI   NUMBER(17, 4) := 0;\n  VN_VL_BASE_ISENTA_IPI   NUMBER(17, 4) := 0;\n  VN_VL_BASE_CALCULO_IPI  NUMBER(17, 4) := 0;\n  VN_VL_ICMS              NUMBER(17, 4) := 0;\n  VN_VL_BASE_OUTRAS_ICMS  NUMBER(17, 4) := 0;\n  VN_VL_BASE_ISENTA_ICMS  NUMBER(17, 4) := 0;\n  VN_VL_BASE_CALCULO_ICMS NUMBER(17, 4) := 0;\n  VN_VLR_TOTAL_NFS        NUMBER(17, 4) := 0;\n  VN_VL_FRETE             NUMBER(17, 4) := 0;  \n  VN_VL_CUSTO_FINANCEIRO  NUMBER(17, 4) := 0;\n  V_ALMOX                 NUMBER(10);\n  --\n  \n    cursor C_ALMOX is\n    select A.*\n      from BEG_EST_ALMOXARIFADO A\n     where A.AD_ORG_ID = :NEW.AD_ORG_ID\n       AND A.IND_DISPONIVEL = 'Y';\n  --           and a.isactive ='Y';\n  --\n  R_ALMOX C_ALMOX%rowtype;\n  \n    cursor BUSCA_ESTOQUE is\n    select P.BEG_PRODUTO_ID,\n           P.DIE_COD_ESTRUTURADO,\n           E.QTD,\n           E.QTD_RESERVADA,\n           PL.ACEITA_NEGATIVO,\n           PL.CONTROLA_ESTOQUE_RESERVA,\n           F.CONTROLA_RESERVA\n      from BEG_ESTOQUE        E,\n           BEG_PRODUTO        P,\n           BEG_PRD_LOGISTICA  PL,\n           BEG_PRD_FABRICANTE F\n     WHERE E.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID\n       and BEG_EST_ALMOXARIFADO_ID =\n           NVL(:NEW.BEG_EST_ALMOXARIFADO_ID, V_ALMOX)\n       AND E.BEG_PRODUTO_ID = P.BEG_PRODUTO_ID\n       AND P.BEG_PRD_FABRICANTE_ID = F.BEG_PRD_FABRICANTE_ID\n       AND P.BEG_PRODUTO_ID = PL.BEG_PRODUTO_ID;\n  --\n  R_EST BUSCA_ESTOQUE%rowtype;\n  \n  \nbegin\n  \n  IF INSERTING OR UPDATING THEN\n  \n    IF :NEW.BEG_EST_ALMOXARIFADO_ID IS NULL AND V_ALMOX IS NULL THEN\n    \n      OPEN C_ALMOX;\n      FETCH C_ALMOX\n        INTO R_ALMOX;\n      CLOSE C_ALMOX;\n    \n      V_ALMOX := R_ALMOX.BEG_EST_ALMOXARIFADO_ID;\n    \n    END IF;\n  \n  /*  open BUSCA_ESTOQUE;\n    fetch BUSCA_ESTOQUE\n      into R_EST;\n    if BUSCA_ESTOQUE%notfound OR\n       R_EST.QTD - R_EST.QTD_RESERVADA < :NEW.QTD_DEVOLVIDA AND R_EST.ACEITA_NEGATIVO='N'  then\n      RAISE_APPLICATION_ERROR(-20501,\n                              'Qtde em estoque menor que quantidade informada para devolucao. Qtde em estoque: ' ||\n                              R_EST.QTD || ' Qtde Reservada: ' ||\n                              R_EST.QTD_RESERVADA || ' Qtde Disponivel: ' ||\n                              TO_CHAR(R_EST.QTD - R_EST.QTD_RESERVADA));\n    end if;\n    close BUSCA_ESTOQUE;*/\n  \n  END IF;\n\n\n  if INSERTING then\n    :new.VL_ICMS_ORIG              := :new.VL_ICMS;\n    :new.VL_BASE_CALCULO_ICMS_ORIG := :new.VL_BASE_CALCULO_ICMS;\n    :new.VL_BASE_ISENTA_ICMS_ORIG  := :new.VL_BASE_ISENTA_ICMS;\n    :new.VL_BASE_OUTRAS_ICMS_ORIG  := :new.VL_BASE_OUTRAS_ICMS;\n    :new.VL_IPI_ORIG               := :new.VL_IPI;\n    :new.VL_BASE_CALCULO_IPI_ORIG  := :new.VL_BASE_CALCULO_IPI;\n    :new.VL_BASE_ISENTA_IPI_ORIG   := :new.VL_BASE_ISENTA_IPI;\n    :new.VL_BASE_OUTRAS_IPI_ORIG   := :new.VL_BASE_OUTRAS_IPI;\n    :new.VL_ICMS_SUBST_ORIG        := :new.VL_ICMS_SUBST;\n    :new.VL_BASE_SUBST_TRIB_ORIG   := :new.VL_BASE_SUBST_TRIB;\n    :new.VL_FRETE_ITEM_ORIG        := :new.VL_FRETE_ITEM;\n    :NEW.VLR_BASE_PIS_ORIG         := :NEW.VLR_BASE_PIS;\n    :NEW.VLR_BASE_COFINS_ORIG      := :NEW.VLR_BASE_COFINS;\n    :NEW.VL_PIS_ORIG               := :NEW.VLR_PIS;\n    :NEW.VL_COFINS_ORIG            := :NEW.VLR_COFINS;\n    :NEW.VL_CUSTO_FINANCEIRO_ORIG  := :NEW.VL_CUSTO_FINANCEIRO;\n  end if;\n  if UPDATING then\n    --\n    IF :NEW.QTDE < :NEW.QTD_DEVOLVIDA THEN\n      RAISE_APPLICATION_ERROR(-20001,'Quantidade a ser Devolvida não pode ser maior que quantidade do Item!');\n    END IF;\n    \n    ---\n     IF LENGTH(:NEW.CST_ICMS) < 2 THEN\n      RAISE_APPLICATION_ERROR(-20001,'CST ICMS fora do padrão favor revisar!');\n    END IF;\n    \n    \n    \n    --\n    IF NVL(:NEW.QTD_DEVOLVIDA, 0) <> NVL(:OLD.QTD_DEVOLVIDA, 0) THEN\n      --\n      V_PERC     := (:new.QTD_DEVOLVIDA * 100 / :new.QTDE) / 100;\n      V_PERC_OLD := (:OLD.QTD_DEVOLVIDA * 100 / :OLD.QTDE) / 100;\n      --\n      IF (NVL(:NEW.VL_COFINS_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VL_COFINS_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VLR_COFINS := ROUND((NVL(:NEW.VL_COFINS_ORIG, 0) * V_PERC) -\n                         (NVL(:OLD.VL_COFINS_ORIG, 0) * V_PERC_OLD),2);\n      ELSE\n        VN_VLR_COFINS := ROUND(NVL(:NEW.VL_COFINS_ORIG, 0) * V_PERC,2);\n      END IF;\n      --    \n      IF (NVL(:NEW.VL_PIS_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VL_PIS_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VLR_PIS := ROUND((NVL(:NEW.VL_PIS_ORIG, 0) * V_PERC) -\n                      (NVL(:OLD.VL_PIS_ORIG, 0) * V_PERC_OLD),2);\n      ELSE\n        VN_VLR_PIS := ROUND(NVL(:NEW.VL_PIS_ORIG, 0) * V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VLR_BASE_COFINS_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VLR_BASE_COFINS_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VLR_BASE_COFINS := ROUND((NVL(:NEW.VLR_BASE_COFINS_ORIG, 0) * V_PERC) -\n                              (NVL(:OLD.VLR_BASE_COFINS_ORIG, 0) * V_PERC_OLD),2);\n      ELSE\n        VN_VLR_BASE_COFINS := ROUND(NVL(:NEW.VLR_BASE_COFINS_ORIG, 0) * V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VLR_BASE_PIS_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VLR_BASE_PIS_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VLR_BASE_PIS := ROUND((NVL(:NEW.VLR_BASE_PIS_ORIG, 0) * V_PERC) -\n                           (NVL(:OLD.VLR_BASE_PIS_ORIG, 0) * V_PERC_OLD),2);\n      ELSE\n        VN_VLR_BASE_PIS := ROUND(NVL(:NEW.VLR_BASE_PIS_ORIG, 0) * V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VL_ICMS_SUBST_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VL_ICMS_SUBST_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VL_ICMS_SUBST := ROUND((NVL(:NEW.VL_ICMS_SUBST_ORIG, 0) * V_PERC) -\n                            (NVL(:OLD.VL_ICMS_SUBST_ORIG, 0) * V_PERC_OLD),2);\n      ELSE\n        VN_VL_ICMS_SUBST := ROUND(NVL(:NEW.VL_ICMS_SUBST_ORIG, 0) * V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VL_BASE_SUBST_TRIB_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VL_BASE_SUBST_TRIB_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VL_BASE_ICMS_SUBST := ROUND((NVL(:NEW.VL_BASE_SUBST_TRIB_ORIG, 0) * V_PERC) -\n                                 (NVL(:OLD.VL_BASE_SUBST_TRIB_ORIG, 0) *\n                                 V_PERC_OLD),2);\n      ELSE\n        VN_VL_BASE_ICMS_SUBST := ROUND(NVL(:NEW.VL_BASE_SUBST_TRIB_ORIG, 0) * V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VL_IPI_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VL_IPI_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VL_IPI := ROUND((NVL(:NEW.VL_IPI_ORIG, 0) * V_PERC) -\n                     (NVL(:OLD.VL_IPI_ORIG, 0) * V_PERC_OLD),2);\n      ELSE\n        VN_VL_IPI := ROUND(NVL(:NEW.VL_IPI_ORIG, 0) * V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VL_BASE_OUTRAS_IPI_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VL_BASE_OUTRAS_IPI_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VL_BASE_OUTRAS_IPI := ROUND((NVL(:NEW.VL_BASE_OUTRAS_IPI_ORIG, 0) * V_PERC) -\n                                 (NVL(:OLD.VL_BASE_OUTRAS_IPI_ORIG, 0) *\n                                 V_PERC_OLD),2);\n      ELSE\n        VN_VL_BASE_OUTRAS_IPI := ROUND(NVL(:NEW.VL_BASE_OUTRAS_IPI_ORIG, 0) * V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VL_BASE_ISENTA_IPI_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VL_BASE_ISENTA_IPI_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VL_BASE_ISENTA_IPI := ROUND((NVL(:NEW.VL_BASE_ISENTA_IPI_ORIG, 0) * V_PERC) -\n                                 (NVL(:OLD.VL_BASE_ISENTA_IPI_ORIG, 0) *\n                                 V_PERC_OLD),2);\n      ELSE\n        VN_VL_BASE_ISENTA_IPI := ROUND(NVL(:NEW.VL_BASE_ISENTA_IPI_ORIG, 0) * V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VL_BASE_CALCULO_IPI_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VL_BASE_CALCULO_IPI_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VL_BASE_CALCULO_IPI := ROUND((NVL(:NEW.VL_BASE_CALCULO_IPI_ORIG, 0) *\n                                  V_PERC) - (NVL(:OLD.VL_BASE_CALCULO_IPI_ORIG,\n                                                 0) * V_PERC_OLD),2);\n      ELSE\n        VN_VL_BASE_CALCULO_IPI := ROUND(NVL(:NEW.VL_BASE_CALCULO_IPI_ORIG, 0) * V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VL_ICMS_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VL_ICMS_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VL_ICMS := ROUND((NVL(:NEW.VL_ICMS_ORIG, 0) * V_PERC) -\n                      (NVL(:OLD.VL_ICMS_ORIG, 0) * V_PERC_OLD),2);\n      ELSE\n        VN_VL_ICMS := ROUND(NVL(:NEW.VL_ICMS_ORIG, 0) * V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VL_BASE_OUTRAS_ICMS_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VL_BASE_OUTRAS_ICMS_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VL_BASE_OUTRAS_ICMS := ROUND((NVL(:NEW.VL_BASE_OUTRAS_ICMS_ORIG, 0) *\n                                  V_PERC) - (NVL(:OLD.VL_BASE_OUTRAS_ICMS_ORIG,\n                                                 0) * V_PERC_OLD),2);\n      ELSE\n        VN_VL_BASE_OUTRAS_ICMS := ROUND(NVL(:NEW.VL_BASE_OUTRAS_ICMS_ORIG, 0) * V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VL_BASE_ISENTA_ICMS_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VL_BASE_ISENTA_ICMS_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VL_BASE_ISENTA_ICMS := ROUND((NVL(:NEW.VL_BASE_ISENTA_ICMS_ORIG, 0) *\n                                  V_PERC) - (NVL(:OLD.VL_BASE_ISENTA_ICMS_ORIG,\n                                                 0) * V_PERC_OLD),2);\n      ELSE\n        VN_VL_BASE_ISENTA_ICMS := ROUND(NVL(:NEW.VL_BASE_ISENTA_ICMS_ORIG, 0) * V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VL_BASE_CALCULO_ICMS_ORIG, 0) * V_PERC) <>\n         (NVL(:OLD.VL_BASE_CALCULO_ICMS_ORIG, 0) * V_PERC_OLD) THEN\n        VN_VL_BASE_CALCULO_ICMS := ROUND((NVL(:NEW.VL_BASE_CALCULO_ICMS_ORIG, 0) *\n                                   V_PERC) -\n                                   (NVL(:OLD.VL_BASE_CALCULO_ICMS_ORIG, 0) *\n                                   V_PERC_OLD),2);\n      ELSE\n        VN_VL_BASE_CALCULO_ICMS := ROUND(NVL(:NEW.VL_BASE_CALCULO_ICMS_ORIG, 0) *\n                                   V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VL_FRETE_ITEM, 0) * V_PERC) <>\n         (NVL(:OLD.VL_FRETE_ITEM, 0) * V_PERC_OLD) THEN\n        VN_VL_FRETE := ROUND((NVL(:NEW.VL_FRETE_ITEM_ORIG, 0) *\n                                   V_PERC) -\n                                   (NVL(:OLD.VL_FRETE_ITEM_ORIG, 0) *\n                                   V_PERC_OLD),2);\n      ELSE\n        VN_VL_FRETE := ROUND(NVL(:NEW.VL_FRETE_ITEM, 0) *\n                                   V_PERC,2);\n      END IF;\n      --\n      IF (NVL(:NEW.VL_CUSTO_FINANCEIRO, 0) * V_PERC) <>\n         (NVL(:OLD.VL_CUSTO_FINANCEIRO, 0) * V_PERC_OLD) THEN\n        VN_VL_FRETE := ROUND((NVL(:NEW.VL_CUSTO_FINANCEIRO_ORIG, 0) *\n                                   V_PERC) -\n                                   (NVL(:OLD.VL_CUSTO_FINANCEIRO_ORIG, 0) *\n                                   V_PERC_OLD),2);\n      ELSE\n        VN_VL_CUSTO_FINANCEIRO := ROUND(NVL(:NEW.VL_CUSTO_FINANCEIRO, 0) *\n                                   V_PERC,2);\n      END IF;\n      \n      ---\n      :NEW.VL_BASE_CALCULO_ICMS := ROUND((NVL(:NEW.VL_BASE_CALCULO_ICMS_ORIG, 0) * V_PERC),2);\n      :NEW.VL_BASE_ISENTA_ICMS  := ROUND((NVL(:NEW.VL_BASE_ISENTA_ICMS_ORIG, 0) * V_PERC),2);\n      :NEW.VL_BASE_OUTRAS_ICMS  := ROUND((NVL(:NEW.VL_BASE_OUTRAS_ICMS_ORIG, 0) * V_PERC),2);\n      :NEW.VL_ICMS              := ROUND((NVL(:NEW.VL_ICMS_ORIG, 0) * V_PERC),2);\n      :NEW.VL_BASE_CALCULO_IPI  := ROUND((NVL(:NEW.VL_BASE_CALCULO_IPI_ORIG, 0) * V_PERC),2);\n      :NEW.VL_BASE_ISENTA_IPI   := ROUND((NVL(:NEW.VL_BASE_ISENTA_IPI_ORIG, 0) * V_PERC),2);\n      :NEW.VL_BASE_OUTRAS_IPI   := ROUND((NVL(:NEW.VL_BASE_OUTRAS_IPI_ORIG, 0) * V_PERC),2);\n      :NEW.VL_IPI               := ROUND((NVL(:NEW.VL_IPI_ORIG, 0) * V_PERC),2);\n      :NEW.VL_BASE_SUBST_TRIB   := ROUND((NVL(:NEW.VL_BASE_SUBST_TRIB_ORIG, 0) * V_PERC),2);\n      :NEW.VL_ICMS_SUBST        := ROUND((NVL(:NEW.VL_ICMS_SUBST_ORIG, 0) * V_PERC),2);\n      :NEW.VLR_BASE_PIS         := ROUND((NVL(:NEW.VLR_BASE_PIS_ORIG, 0) * V_PERC),2);\n      :NEW.VLR_BASE_COFINS      := ROUND((NVL(:NEW.VLR_BASE_COFINS_ORIG, 0) * V_PERC),2);\n      :NEW.VLR_PIS              := ROUND((NVL(:NEW.VL_PIS_ORIG, 0) * V_PERC),2);\n      :NEW.VLR_COFINS           := ROUND((NVL(:NEW.VL_COFINS_ORIG, 0) * V_PERC),2);\n      :NEW.VL_FRETE_ITEM        := ROUND((NVL(:NEW.VL_FRETE_ITEM_ORIG, 0) * V_PERC),2); \n      :NEW.VL_CUSTO_FINANCEIRO  := ROUND((NVL(:NEW.VL_CUSTO_FINANCEIRO_ORIG, 0) * V_PERC),2);\n\n      --\n      update BEG_FAT_DEV_FORNECEDOR F\n         set F.VL_BASE_CALCULO_ICMS = F.VL_BASE_CALCULO_ICMS +\n                                      VN_VL_BASE_CALCULO_ICMS, --TRUNC(:new.VL_BASE_CALCULO_ICMS_ORIG * V_PERC, 2) - NVL(:old.VL_BASE_CALCULO_ICMS,0) ,\n             F.VL_BASE_ISENTA_ICMS  = F.VL_BASE_ISENTA_ICMS +\n                                      VN_VL_BASE_ISENTA_ICMS, --TRUNC(NVL(:new.VL_BASE_ISENTA_ICMS,0) * V_PERC, 2) - NVL(:old.VL_BASE_ISENTA_ICMS,0) ,\n             F.VL_BASE_OUTRAS_ICMS  = F.VL_BASE_OUTRAS_ICMS +\n                                      VN_VL_BASE_OUTRAS_ICMS, -- TRUNC(NVL(:new.VL_BASE_OUTRAS_ICMS,0) * V_PERC, 2) - NVL(:old.VL_BASE_OUTRAS_ICMS,0) ,\n             F.VL_ICMS              = F.VL_ICMS + VN_VL_ICMS, -- TRUNC(NVL(:new.VL_ICMS,0) * V_PERC, 2) - NVL(:old.VL_ICMS,0),\n             F.VL_BASE_CALCULO_IPI  = F.VL_BASE_CALCULO_IPI +\n                                      VN_VL_BASE_CALCULO_IPI, --TRUNC(NVL(:new.VL_BASE_CALCULO_IPI,0) * V_PERC, 2) - NVL(:old.VL_BASE_CALCULO_IPI,0) ,\n             F.VL_BASE_ISENTA_IPI   = F.VL_BASE_ISENTA_IPI +\n                                      VN_VL_BASE_ISENTA_IPI, --TRUNC(NVL(:new.VL_BASE_ISENTA_IPI,0) * V_PERC, 2) - NVL(:old.VL_BASE_ISENTA_IPI,0) ,\n             F.VL_BASE_OUTRAS_IPI   = F.VL_BASE_OUTRAS_IPI +\n                                      VN_VL_BASE_OUTRAS_IPI, -- TRUNC(NVL(:new.VL_BASE_OUTRAS_IPI,0) * V_PERC, 2) - NVL(:old.VL_BASE_OUTRAS_IPI,0) ,\n             F.VL_IPI               = F.VL_IPI + VN_VL_IPI, --TRUNC(NVL(:new.VL_IPI,0) * V_PERC, 2) - NVL(:old.VL_IPI,0),\n             F.VL_BASE_ICMS_SUBST   = F.VL_BASE_ICMS_SUBST +\n                                      VN_VL_BASE_ICMS_SUBST, --(TRUNC(NVL(:new.VL_BASE_SUBST_TRIB,0) * V_PERC, 2) - NVL(:old.VL_BASE_SUBST_TRIB,0)),\n             F.VL_ICMS_SUBST        = F.VL_ICMS_SUBST + VN_VL_ICMS_SUBST, --(TRUNC(NVL(:new.VL_ICMS_SUBST_ORIG,0) * V_PERC,2) - NVL(:old.VL_ICMS_SUBST,0)),\n             F.VLR_BASE_PIS           = VLR_BASE_PIS + VN_VLR_BASE_PIS, --(NVL(:NEW.VLR_BASE_PIS * V_PERC, 0) - NVL(:OLD.VLR_BASE_PIS, 0)),\n             F.VLR_BASE_COFINS        = VLR_BASE_COFINS + VN_VLR_BASE_COFINS, --(NVL(:NEW.VLR_BASE_COFINS * V_PERC, 0) - NVL(:OLD.VLR_BASE_COFINS, 0)),\n             F.VLR_PIS                = VLR_PIS + VN_VLR_PIS,\n             F.VLR_COFINS             = F.VLR_COFINS + VN_VLR_COFINS,\n             F.VL_TOTAL_PROD        = F.VL_TOTAL_PROD +\n                                      ((NVL(:NEW.QTD_DEVOLVIDA, 0) *\n                                      NVL(:NEW.VL_UNITARIO, 0)) -\n                                     ( NVL(:OLD.QTD_DEVOLVIDA, 0) *\n                                      NVL(:OLD.VL_UNITARIO, 0))),\n             F.VL_TOTAL_NFS         = F.VL_TOTAL_NFS +\n                                      ((NVL(:NEW.QTD_DEVOLVIDA, 0) *\n                                      NVL(:NEW.VL_UNITARIO, 0) + NVL(:NEW.VL_CUSTO_FINANCEIRO,0) -\n                                      (NVL(:OLD.QTD_DEVOLVIDA, 0) *\n                                      NVL(:OLD.VL_UNITARIO, 0)) - NVL(:OLD.VL_CUSTO_FINANCEIRO,0)) + VN_VL_IPI + VN_VL_ICMS_SUBST),\n            F.VL_FRETE              = F.VL_FRETE + VN_VL_FRETE,     \n            F.VL_OUTRAS_DESPESAS   = F.VL_OUTRAS_DESPESAS + VN_VL_CUSTO_FINANCEIRO                 \n       where BEG_FAT_DEV_FORNECEDOR_ID = :new.BEG_FAT_DEV_FORNECEDOR_ID;\n    END IF;\n  end if;\nend BEG_TRG_BIU_DEV_FORN_ITEM;\n"}`;
    
    }
}
