
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FAT_DEVOLUCAO_ITEM
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int PREDBCEFET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VBCEFET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PICMSEFET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VICMSEFET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_COFINS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CST_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NR_ITEM { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_DEVOLUCAO_ITEM_ID { get; set; }
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
        public int NRO_NFS { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE_NFS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
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
        /// 
        /// </summary>
        public int VL_CUSTO_FINANCEIRO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NFS_ENTREGA_FUT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LINHA_NFS_ENTREGA_FUT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_DESCONTO { get; set; }
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
        public int BEG_FAT_DEVOLUCAO_ID { get; set; }
        
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
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CST_ICMS { get; set; }
        
        /// <summary>
        /// Id do almoxarifado
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// id do item da nota saida
        /// </summary>
        public int BEG_FAT_NFS_ITEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ICMS_ST { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BU_DEV_PARCIAL_CLIENTE { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  V_PERCENTUAL     number(18, 6);\n  V_TOTAL_PROD_NEW number(18, 4);\n  V_TOTAL_PROD_NEW_LIQ number(18, 4);  \n  V_TOTAL_PROD_OLD number(18, 4);\n\n   cursor CQTDIDEV is\n    select NVL(sum(DI.QTD_DEVOLVIDA), 0) QTD_DEVOL\n      from BEG_HST_NOTA_FISCAL DI\n     where DI.BEG_FAT_NFS_ITEM_ID = :new.BEG_FAT_NFS_ITEM_ID;\n  VN_QTD_ITM_JA_DEVOL number := 0;\n  VN_QTD_DISP NUMBER :=0;\n\n\nbegin\n  if :NEW.QTD_DEVOLVIDA > :NEW.QTDE then\n    RAISE_APPLICATION_ERROR(-20501,\n                            'Quantidade devolvida superior a quantidade da venda');\n  end if;\n\n  open CQTDIDEV;\n    fetch CQTDIDEV\n      into VN_QTD_ITM_JA_DEVOL;\n    close CQTDIDEV;\n\n    VN_QTD_DISP:= :new.qtde - VN_QTD_ITM_JA_DEVOL ;\n\n  if VN_QTD_DISP < :new.qtd_devolvida then\n    RAISE_APPLICATION_ERROR(-20501,\n                            'Quantidade devolvida superior a quantidade disponivel para devolucao - '|| VN_QTD_DISP );\n\n  end if;\n\n\n  if :OLD.QTD_DEVOLVIDA > 0 then\n    V_PERCENTUAL := ((:NEW.QTD_DEVOLVIDA * 100) / :OLD.QTD_DEVOLVIDA) / 100;\n  else\n    V_PERCENTUAL := ((:NEW.QTD_DEVOLVIDA * 100) / :NEW.QTDE) / 100;\n  end if;\n  --  :NEW.VL_ICMS              := ROUND(:NEW.VL_ICMS * V_PERCENTUAL, 2); -- aok - 10/10/2013\n  :NEW.VL_BASE_CALCULO_ICMS := ROUND(:NEW.VL_BASE_CALCULO_ICMS *\n                                     V_PERCENTUAL,\n                                     2);\n  :NEW.VL_ICMS              := ROUND(:NEW.VL_BASE_CALCULO_ICMS *\n                                     :NEW.PERC_ICMS / 100,\n                                     2); -- aok - 10/10/2013\n  --raise_application_error(-20501,'perc '||v_percentual||' base new'||:new.vl_base_calculo_icms||' old '||:old.vl_base_calculo_icms);\n  :NEW.VL_BASE_ISENTA_ICMS := ROUND(:NEW.VL_BASE_ISENTA_ICMS * V_PERCENTUAL,\n                                    2);\n  :NEW.VL_BASE_OUTRAS_ICMS := ROUND(:NEW.VL_BASE_OUTRAS_ICMS * V_PERCENTUAL,\n                                    2);\n  --  :NEW.VL_IPI              := ROUND(:NEW.VL_IPI * V_PERCENTUAL, 2); -- aok - 10/10/2013\n  :NEW.VL_BASE_CALCULO_IPI := ROUND(:NEW.VL_BASE_CALCULO_IPI * V_PERCENTUAL,\n                                    2);\n  :NEW.VL_IPI              := ROUND(:NEW.VL_BASE_CALCULO_IPI *\n                                    :NEW.PERC_IPI / 100,\n                                    2); -- aok - 10/10/2013\n  :NEW.VL_BASE_ISENTA_IPI  := ROUND(:NEW.VL_BASE_ISENTA_IPI * V_PERCENTUAL,\n                                    2);\n  :NEW.VL_BASE_OUTRAS_IPI  := ROUND(:NEW.VL_BASE_OUTRAS_IPI * V_PERCENTUAL,\n                                    2);\n  :NEW.VL_ICMS_SUBST       := ROUND(:NEW.VL_ICMS_SUBST * V_PERCENTUAL, 2);\n  :NEW.VL_BASE_SUBST_TRIB  := ROUND(:NEW.VL_BASE_SUBST_TRIB * V_PERCENTUAL,\n                                    2);\n  :NEW.VL_FRETE_ITEM       := ROUND(:NEW.VL_FRETE_ITEM * V_PERCENTUAL, 2);\n  --\n  :NEW.VL_BASE_CALCULO_PIS    := ROUND(NVL(:NEW.VL_BASE_CALCULO_PIS *\n                                           V_PERCENTUAL,\n                                           0),\n                                       2);\n  :NEW.VL_BASE_CALCULO_COFINS := ROUND(NVL(:NEW.VL_BASE_CALCULO_COFINS *\n                                           V_PERCENTUAL,\n                                           0),\n                                       2);\n  :NEW.VL_PIS                 := ROUND(NVL(:NEW.VL_PIS, 0) * V_PERCENTUAL,\n                                       2);\n  :NEW.VL_COFINS              := ROUND(NVL(:NEW.VL_COFINS, 0) *\n                                       V_PERCENTUAL,\n                                       2);\n  :new.vl_desconto            := ROUND(NVL(:NEW.Vl_Desconto, 0) *\n                                       V_PERCENTUAL,\n                                       2);\n  :new.vl_custo_financeiro    := ROUND(NVL(:NEW.vl_custo_financeiro, 0) *\n                                       V_PERCENTUAL,\n                                       2);\n\n\n  --\n  V_TOTAL_PROD_NEW_LIQ := (:NEW.QTD_DEVOLVIDA * :NEW.VL_UNITARIO) +\n                      NVL(:NEW.VL_IPI, 0) + NVL(:NEW.VL_FRETE_ITEM, 0) +\n                      NVL(:NEW.VL_ICMS_SUBST, 0) - NVL(:NEW.VL_DESCONTO,0);\n  V_TOTAL_PROD_NEW := (:NEW.QTD_DEVOLVIDA * :NEW.VL_UNITARIO) +\n                      NVL(:NEW.VL_IPI, 0) + NVL(:NEW.VL_FRETE_ITEM, 0) +\n                      NVL(:NEW.VL_ICMS_SUBST, 0);                      \n  V_TOTAL_PROD_OLD := (:OLD.QTD_DEVOLVIDA * :OLD.VL_UNITARIO) +\n                      NVL(:OLD.VL_IPI, 0) + NVL(:OLD.VL_FRETE_ITEM, 0) +\n                      NVL(:OLD.VL_ICMS_SUBST, 0)- NVL(:OLD.VL_DESCONTO,0);\n\n  --\n  if :OLD.QTD_DEVOLVIDA > 0 then\n    update BEG_FAT_DEVOLUCAO\n       set VL_ICMS              = VL_ICMS - :OLD.VL_ICMS + :NEW.VL_ICMS,\n           VL_BASE_CALCULO_ICMS = VL_BASE_CALCULO_ICMS -\n                                  :OLD.VL_BASE_CALCULO_ICMS +\n                                  :NEW.VL_BASE_CALCULO_ICMS,\n           VL_BASE_ISENTA_ICMS  = VL_BASE_ISENTA_ICMS -\n                                  :OLD.VL_BASE_ISENTA_ICMS +\n                                  :NEW.VL_BASE_ISENTA_ICMS,\n           VL_BASE_OUTRAS_ICMS  = VL_BASE_OUTRAS_ICMS -\n                                  :OLD.VL_BASE_OUTRAS_ICMS +\n                                  :NEW.VL_BASE_OUTRAS_ICMS,\n           VL_IPI               = VL_IPI - :OLD.VL_IPI + :NEW.VL_IPI,\n           VL_BASE_CALCULO_IPI  = VL_BASE_CALCULO_IPI -\n                                  :OLD.VL_BASE_CALCULO_IPI +\n                                  :NEW.VL_BASE_CALCULO_IPI,\n           VL_BASE_ISENTA_IPI   = VL_BASE_ISENTA_IPI -\n                                  :OLD.VL_BASE_ISENTA_IPI +\n                                  :NEW.VL_BASE_ISENTA_IPI,\n           VL_BASE_OUTRAS_IPI   = VL_BASE_OUTRAS_IPI -\n                                  :OLD.VL_BASE_OUTRAS_IPI +\n                                  :NEW.VL_BASE_OUTRAS_IPI,\n           VL_ICMS_SUBST        = VL_ICMS_SUBST - :OLD.VL_ICMS_SUBST +\n                                  :NEW.VL_ICMS_SUBST,\n           VL_BASE_ICMS_SUBST   = VL_BASE_ICMS_SUBST -\n                                  :OLD.VL_BASE_SUBST_TRIB +\n                                  :NEW.VL_BASE_SUBST_TRIB,\n           VL_FRETE             = VL_FRETE - :OLD.VL_FRETE_ITEM +\n                                  :NEW.VL_FRETE_ITEM,\n           VL_BASE_CALCULO_PIS    = VL_BASE_CALCULO_PIS - NVL(:OLD.VL_BASE_CALCULO_PIS, 0) +\n                                    NVL(:NEW.VL_BASE_CALCULO_PIS, 0),\n           VL_BASE_CALCULO_COFINS = VL_BASE_CALCULO_COFINS - NVL(:OLD.VL_BASE_CALCULO_COFINS, 0) +\n                                    NVL(:NEW.VL_BASE_CALCULO_COFINS, 0),\n           VL_PIS                 = VL_PIS - NVL(:OLD.VL_PIS, 0) + NVL(:NEW.VL_PIS, 0),\n           VL_COFINS              = VL_COFINS - NVL(:OLD.VL_COFINS, 0) + NVL(:NEW.VL_COFINS, 0),\n           VL_DESCONTO          = nvl(VL_DESCONTO,0) -NVL(:OLD.VL_DESCONTO,0) + NVL(:NEW.VL_DESCONTO,0),\n           VL_CUSTO_FINANCEIRO  = nvl(VL_CUSTO_FINANCEIRO,0) -NVL(:OLD.VL_CUSTO_FINANCEIRO,0) + NVL(:NEW.VL_CUSTO_FINANCEIRO,0),\n           VL_TOTAL_PROD        = VL_TOTAL_PROD - V_TOTAL_PROD_OLD +\n                                  V_TOTAL_PROD_NEW,\n           VL_TOTAL_NFS         = VL_TOTAL_NFS - V_TOTAL_PROD_OLD +\n                                  V_TOTAL_PROD_NEW_LIQ\n     where BEG_FAT_DEVOLUCAO_ID = :NEW.BEG_FAT_DEVOLUCAO_ID;\n  else\n    update BEG_FAT_DEVOLUCAO\n       set VL_ICMS                = VL_ICMS + :NEW.VL_ICMS,\n           VL_BASE_CALCULO_ICMS   = VL_BASE_CALCULO_ICMS +\n                                    :NEW.VL_BASE_CALCULO_ICMS,\n           VL_BASE_ISENTA_ICMS    = VL_BASE_ISENTA_ICMS +\n                                    :NEW.VL_BASE_ISENTA_ICMS,\n           VL_BASE_OUTRAS_ICMS    = VL_BASE_OUTRAS_ICMS +\n                                    :NEW.VL_BASE_OUTRAS_ICMS,\n           VL_IPI                 = VL_IPI + :NEW.VL_IPI,\n           VL_BASE_CALCULO_IPI    = VL_BASE_CALCULO_IPI +\n                                    :NEW.VL_BASE_CALCULO_IPI,\n           VL_BASE_ISENTA_IPI     = VL_BASE_ISENTA_IPI +\n                                    :NEW.VL_BASE_ISENTA_IPI,\n           VL_BASE_OUTRAS_IPI     = VL_BASE_OUTRAS_IPI +\n                                    :NEW.VL_BASE_OUTRAS_IPI,\n           VL_ICMS_SUBST          = VL_ICMS_SUBST + :NEW.VL_ICMS_SUBST,\n           VL_BASE_ICMS_SUBST     = VL_BASE_ICMS_SUBST +\n                                    :NEW.VL_BASE_SUBST_TRIB,\n           VL_FRETE               = VL_FRETE + :NEW.VL_FRETE_ITEM,\n           VL_BASE_CALCULO_PIS    = VL_BASE_CALCULO_PIS +\n                                    NVL(:NEW.VL_BASE_CALCULO_PIS, 0),\n           VL_BASE_CALCULO_COFINS = VL_BASE_CALCULO_COFINS +\n                                    NVL(:NEW.VL_BASE_CALCULO_COFINS, 0),\n           VL_PIS                 = VL_PIS + NVL(:NEW.VL_PIS, 0),\n           VL_COFINS              = VL_COFINS + NVL(:NEW.VL_COFINS, 0),\n           VL_DESCONTO          = nvl(VL_DESCONTO,0)  + NVL(:NEW.VL_DESCONTO,0),\n           VL_CUSTO_FINANCEIRO  = nvl(VL_CUSTO_FINANCEIRO,0)  + NVL(:NEW.VL_CUSTO_FINANCEIRO,0),\n           VL_TOTAL_PROD          = VL_TOTAL_PROD +\n                                    V_TOTAL_PROD_NEW,\n           VL_TOTAL_NFS           = VL_TOTAL_NFS  +\n                                    V_TOTAL_PROD_NEW_LIQ\n     where BEG_FAT_DEVOLUCAO_ID = :NEW.BEG_FAT_DEVOLUCAO_ID;\n  end if;\nend BEG_TRG_BU_DEV_PARCIAL_CLIENTE;\n"}`;
    
    }
}
