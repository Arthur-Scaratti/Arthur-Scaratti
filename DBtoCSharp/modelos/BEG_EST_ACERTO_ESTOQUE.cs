
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_EST_ACERTO_ESTOQUE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ACERTO_ESTOQUE_ID { get; set; }
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
        public int QUANTIDADE { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_MOVTO_ESTOQUE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string POSICAO_FISICA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_DISPONIVEL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ESTOQUE_ATUAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_RESERVA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_EST_ALMOXARIFADO_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00044 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_EST_ACERTO_EST { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  v_Sequence number;\n  Walmox     varchar2(1);\n  cursor Busca_Estoque is\n    select Nvl(e.Qtd,\n               0) - Nvl(e.Qtd_Reservada,\n                        0) Estoque_Disponivel,\n           p.value,\n           p.name\n    from   Beg_Estoque e,\n           Beg_Produto p\n    where  e.Beg_Est_Almoxarifado_Id = :new.Beg_Est_Almoxarifado_Id\n    and    e.Beg_Produto_Id = :new.Beg_Produto_Id\n    and    e.Beg_Prd_Sku_Id = :new.Beg_Prd_Sku_Id\n    and    p.Beg_Produto_Id = e.Beg_Produto_Id;\n  --\n  Vreg1 Busca_Estoque%rowtype;\n  --\n  CURSOR C_PROD IS\n  SELECT p.beg_produto_id, sk.beg_prd_situacao_id, p.die_cod_estruturado\n    FROM BEG_PRODUTO P,\n         BEG_PRD_SKU_DETALHE SK\n  WHERE SK.BEG_PRODUTO_ID = P.BEG_PRODUTO_ID\n    AND P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID ;\n  R_PROD C_PROD%ROWTYPE;\n           \n  \n  \nbegin\n  \n    open C_PROD;\n      fetch C_PROD\n        into R_PROD;\n    close C_PROD;\n\n   if r_prod.beg_prd_situacao_id = 2000004 then\n     Raise_Application_Error(-20001,\n                              'Produto '|| R_PROD.die_cod_estruturado ||' está Liquidado não permite movimento');\n   end if;\n\n  --\n  if Inserting\n     or Updating then\n    :new.Data := Trunc(sysdate);\n    \n--    if :new.quantidade > :new.qtd_disponivel and :new.BEG_EST_TP_ESPECIE_ID=2000057 then\n    if :new.quantidade > (:new.Qtd_Disponivel + :NEW.QTD_RESERVA) and :new.BEG_EST_TP_ESPECIE_ID=2000057 then\n       Raise_Application_Error(-20001,\n                              'Quantidade informada maior que estoque disponível = ' ||(:new.Qtd_Disponivel + :NEW.QTD_RESERVA)|| '. Verifique');\n    \n    end if;\n    \n  end if;\n\n  if Inserting then\n    if Instr(:new.value,\n             '-L') = 0 then\n      :new.value := :new.value || '-A';\n    end if;\n    if :new.Quantidade <= 0 then\n      Raise_Application_Error(-20001,\n                              'Quantidade deve ser maior que zero!');\n    end if;\n  end if;\n  if Updating then\n    Raise_Application_Error(-20001,\n                            'Registro n?o pode ser alterado!');\n  elsif Deleting then\n/*    Raise_Application_Error(-20002,\n                            'Registro n?o pode ser eliminado!');*/\n                            NULL;\n  else\n    --\n    select Tp_Movto\n    into   Walmox\n    from   Beg_Est_Tp_Especie\n    where  Beg_Est_Tp_Especie_Id = :new.Beg_Est_Tp_Especie_Id;\n    --\n    if Walmox = 'D' then\n      open Busca_Estoque;\n      fetch Busca_Estoque\n        into Vreg1;\n      if Busca_Estoque%notfound then\n        Vreg1.Estoque_Disponivel := 0;\n      end if;\n      close Busca_Estoque;\n      --Valdir alterou em 19/12/2015 para ajustar saldos errados\n   /*   if :new.Quantidade > Vreg1.Estoque_Disponivel then\n        Raise_Application_Error(-20002,\n                                'Estoque disponivel para o item' || Vreg1.value || ' ' ||\n                                Vreg1.name || ' ' || Vreg1.Estoque_Disponivel ||\n                                ' menor que a quantidade a ser baixada ' || :new.Quantidade || '.');\n      end if;*/\n    end if;\n    Ad_Sequence_Next('BEG_EST_MOVTO_ESTOQUE',\n                     1000000,\n                     v_Sequence);\n    begin\n      insert into Beg_Est_Movto_Estoque\n        (Beg_Est_Movto_Estoque_Id,\n         Ad_Client_Id,\n         Ad_Org_Id,\n         Isactive,\n         Created,\n         Createdby,\n         Updated,\n         Updatedby,\n         Beg_Est_Tp_Especie_Id,\n         Beg_Prd_Sku_Id,\n         Beg_Produto_Id,\n         Beg_Est_Almoxarifado_Id,\n         Beg_Est_Vw_Almox_Destino_Id,\n         Vlr_Movto,\n         Qtd_Movto,\n         Documento,\n         data)\n      values\n        (v_Sequence,\n         :new.Ad_Client_Id,\n         :new.Ad_Org_Id,\n         'Y',\n         :new.Created,\n         :new.Createdby,\n         :new.Updated,\n         :new.Updatedby,\n         :new.Beg_Est_Tp_Especie_Id,\n         :new.Beg_Prd_Sku_Id,\n         :new.Beg_Produto_Id,\n         Decode(Walmox,\n                'D',\n                :new.Beg_Est_Almoxarifado_Id,\n                'T',\n                :new.Beg_Est_Almoxarifado_Id,\n                NULL),\n         Decode(Walmox,\n                'S',\n                :new.Beg_Est_Almoxarifado_Id,\n                'T',\n                :new.BEG_VW_EST_ALMOXARIFADO_ID,\n                NULL),\n         0,\n         :new.Quantidade,\n         :new.value,\n         trunc(sysdate));\n    exception\n      when others then\n        Raise_Application_Error(-20009,\n                                sqlerrm);\n    end;\n    --\n    :new.Beg_Est_Movto_Estoque_Id := v_Sequence;\n    --\n  end if;\n  --\nend Trg_Biud_Beg_Est_Acerto_Est;\n"}`;
    
    }
}
