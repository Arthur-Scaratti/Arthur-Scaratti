
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_LIN_COTACAO
    {

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00031 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n\n\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_APEX_001 { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  V_RESULT boolean;\nbegin\n  :NEW.ISACTIVE := 'Y';\n  V_RESULT := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TABLE(P_APP_USER     => :new.APP_USER,\n                                                       P_TABLE_NAME   => 'BEG_VEN_LIN_COTACAO',\n                                                       P_AD_CLIENT_ID => :new.AD_CLIENT_ID,\n                                                       P_AD_ORG_ID    => :new.AD_ORG_ID,\n                                                       P_CREATED      => :new.CREATED,\n                                                       P_CREATEDBY    => :new.CREATEDBY,\n                                                       P_UPDATED      => :new.UPDATED,\n                                                       P_UPDATEDBY    => :new.UPDATEDBY,\n                                                       P_PRIMARY      => :new.BEG_VEN_LIN_COTACAO_ID);\n\nend TRG_APEX_001;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_LIN_COT { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  pragma autonomous_transaction;\n  -- local variables here\n  V_COTACAO   number(10);\n  V_ALMOX_FAT number(10);\n  V_RETORNO   varchar2(1000);\n  V_RESERVA   varchar2(1);\n  --\n  V_TOTAL_ITEM_NEW   number(18, 2);\n  V_TOTAL_ITEM_OLD   number(18, 2);\n  V_VLR_UNITARIO_NEW number;\n  V_VLR_UNITARIO_OLD number;\n  V_RESULT           boolean;\n  --\n  cursor BUSCA_COTACAO is\n    select * from BEG_VEN_COTACAO C where C.BEG_VEN_COTACAO_ID = V_COTACAO;\n  ---\n  VREG1 BUSCA_COTACAO%rowtype;\n  --\nbegin\n  if INSERTING\n     or UPDATING then\n    if :new.QUANTIDADE < 0 then\n      RAISE_APPLICATION_ERROR(-20501,\n                              'Quantidade de venda deve ser maior que zero');\n    end if;\n    if :new.QTD_RESERVA < 0 then\n      RAISE_APPLICATION_ERROR(-20501,\n                              'Quantidade de venda deve ser maior que zero');\n    end if;\n    V_COTACAO   := :new.BEG_VEN_COTACAO_ID;\n    V_RESERVA   := :new.RESERVA;\n    V_ALMOX_FAT := BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n                                             :new.AD_ORG_ID,\n                                             'Estoque',\n                                             'Faturamento',\n                                             'ALMOXARIFADO_FATURAMENTO');\n  else\n    V_COTACAO   := :old.BEG_VEN_COTACAO_ID;\n    V_RESERVA   := :old.RESERVA;\n    V_ALMOX_FAT := BEG_FNC_RETORNA_PARAMETRO(:old.AD_CLIENT_ID,\n                                             :old.AD_ORG_ID,\n                                             'Estoque',\n                                             'Faturamento',\n                                             'ALMOXARIFADO_FATURAMENTO');\n  end if;\n  open BUSCA_COTACAO;\n  fetch BUSCA_COTACAO\n    into VREG1;\n  close BUSCA_COTACAO;\n  --  RAISE_APPLICATION_ERROR(-20501,'erro'||v_cotacao);\n  if V_RESERVA = 'Y' then\n    if INSERTING then\n      if :new.QTD_RESERVA is null then\n        V_RETORNO := 'OK';\n        V_RETORNO := BEG_FNC_ATUALIZA_RESERVA(:new.AD_ORG_ID,\n                                              :new.AD_CLIENT_ID,\n                                              VREG1.value,\n                                              :new.BEG_PRODUTO_ID,\n                                              :new.BEG_PRD_SKU_ID,\n                                              V_ALMOX_FAT,\n                                              :new.QUANTIDADE,\n                                              'R');\n        if V_RETORNO <> 'OK' then\n          RAISE_APPLICATION_ERROR(-20501, V_RETORNO);\n        end if;\n      else\n        V_RETORNO := 'OK';\n        V_RETORNO := BEG_FNC_ATUALIZA_RESERVA(:new.AD_ORG_ID,\n                                              :new.AD_CLIENT_ID,\n                                              VREG1.value,\n                                              :new.BEG_PRODUTO_ID,\n                                              :new.BEG_PRD_SKU_ID,\n                                              V_ALMOX_FAT,\n                                              :new.QTD_RESERVA,\n                                              'R');\n        if V_RETORNO <> 'OK' then\n          RAISE_APPLICATION_ERROR(-20501, V_RETORNO);\n        end if;\n      end if;\n    elsif UPDATING then\n      if :old.QTD_RESERVA <> :new.QTD_RESERVA then\n        if :old.RESERVA = 'Y' then\n          V_RETORNO := 'OK';\n          V_RETORNO := BEG_FNC_ATUALIZA_RESERVA(:new.AD_ORG_ID,\n                                                :new.AD_CLIENT_ID,\n                                                VREG1.value,\n                                                :new.BEG_PRODUTO_ID,\n                                                :new.BEG_PRD_SKU_ID,\n                                                V_ALMOX_FAT,\n                                                NVL(:old.QTD_RESERVA, 0),\n                                                'L');\n          if V_RETORNO <> 'OK' then\n            RAISE_APPLICATION_ERROR(-20501, V_RETORNO);\n          end if;\n        end if;\n        V_RETORNO := 'OK';\n        V_RETORNO := BEG_FNC_ATUALIZA_RESERVA(:new.AD_ORG_ID,\n                                              :new.AD_CLIENT_ID,\n                                              VREG1.value,\n                                              :new.BEG_PRODUTO_ID,\n                                              :new.BEG_PRD_SKU_ID,\n                                              V_ALMOX_FAT,\n                                              :new.QTD_RESERVA,\n                                              'R');\n        if V_RETORNO <> 'OK' then\n          RAISE_APPLICATION_ERROR(-20501,\n                                  V_RETORNO || ' QTD ESTOQUE ' ||\n                                  :new.QUANTIDADE || ' RES ' ||\n                                  :new.QTD_RESERVA);\n        end if;\n      end if;\n    else\n      V_RETORNO := 'OK';\n      V_RETORNO := BEG_FNC_ATUALIZA_RESERVA(:old.AD_ORG_ID,\n                                            :old.AD_CLIENT_ID,\n                                            VREG1.value,\n                                            :old.BEG_PRODUTO_ID,\n                                            :old.BEG_PRD_SKU_ID,\n                                            V_ALMOX_FAT,\n                                            :old.QTD_RESERVA,\n                                            'L');\n      if V_RETORNO <> 'OK' then\n        RAISE_APPLICATION_ERROR(-20501, V_RETORNO);\n      end if;\n    end if;\n  end if;\n\n  --Atualizando total da cotacao\n\n  if NVL(:new.VLR_UNIT_SUGERIDO, 0) > 0 then\n    V_VLR_UNITARIO_NEW := :new.VLR_UNIT_SUGERIDO;\n  else\n    V_VLR_UNITARIO_NEW := :new.VALOR;\n  end if;\n\n  if :old.VLR_UNIT_SUGERIDO > 0 then\n    V_VLR_UNITARIO_OLD := :old.VLR_UNIT_SUGERIDO;\n  else\n    V_VLR_UNITARIO_OLD := :old.VALOR;\n  end if;\n\n  V_TOTAL_ITEM_NEW := V_VLR_UNITARIO_NEW * :new.QUANTIDADE;\n  V_TOTAL_ITEM_OLD := V_VLR_UNITARIO_OLD * :old.QUANTIDADE;\n  commit;\nend BEG_TRG_BIUD_LIN_COT;\n"}`;
    
    }
}
