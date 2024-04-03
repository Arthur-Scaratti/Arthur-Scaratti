
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VEN_META
    {
            [Required]
    [Key]
        /// <summary>
        /// Id da Meta
        /// </summary>
        public int DIE_VEN_META_ID { get; set; }
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
        /// Valor da meta de venda
        /// </summary>
        public int VLR_META_VENDA { get; set; }
            [Required]
        /// <summary>
        /// Mes e Ano de referencia
        /// </summary>
        public string MESANO { get; set; }
            [Required]
        /// <summary>
        /// Data inicial  de referencia
        /// </summary>
        public string DT_INICIAL { get; set; }
        
        /// <summary>
        /// Data final  de referenca
        /// </summary>
        public string DT_FINAL { get; set; }
            [Required]
        /// <summary>
        /// Valor da receita de venda
        /// </summary>
        public int VLR_RECEITA { get; set; }
        
        /// <summary>
        /// codigo da filial
        /// </summary>
        public int FILIAL { get; set; }
            [Required]
        /// <summary>
        /// Qtde de vendedores ativo no mes
        /// </summary>
        public int NR_VENDEDORES { get; set; }
            [Required]
        /// <summary>
        /// Valor meta por vendedor(vlr_meta_venda/nr_vendedores)
        /// </summary>
        public int VLR_META_VENDEDOR { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BI_META_VENDA { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  VFILIAL number(3);\nbegin\n  --\n  select TO_NUMBER(F.value)\n    into VFILIAL\n    from BEG_FILIAL F\n   where F.AD_ORG_ID = :new.AD_ORG_ID;\n  --\n  :new.FILIAL := VFILIAL;\n  --\nend DIE_TRG_BI_META_VENDA;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_META_VENDA { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  pragma autonomous_transaction;\n  VDIE_VEN_COTA_GRUPO_ID DIE_VEN_COTA_GRUPO.DIE_VEN_COTA_GRUPO_ID%type;\n  VDIE_VEN_META_GRUPO_ID DIE_VEN_META_GRUPO.DIE_VEN_META_GRUPO_ID%type;\n  VDIE_VEN_META_ID       DIE_VEN_META.DIE_VEN_META_ID%type;\n  VN_DIA_INICIAL_META    number(2); -- AOK - 27/03/2009\n  VN_DIA_FINAL_META      number(2); -- AOK - 27/03/2009\n  V_PERC                 NUMBER(9,2):=0;\n  --\n  cursor C_FILIAL is\n    select DF.DIE_VEN_COTA_GRUPO_ID\n      from AD_ORG O, BEG_DADO_FILIAL DF\n     where DF.AD_ORG_ID = O.AD_ORG_ID\n       and O.AD_ORG_ID = :new.AD_ORG_ID;\n  --\n  cursor META_GRUPO is\n    select *\n      from DIE_VEN_META_GRUPO MG\n     where MG.DIE_VEN_META_ID = VDIE_VEN_META_ID;\n  --\n  cursor COTA_GRUPO(PDIE_VEN_COTA_GRUPO_ID number) is\n    select CGP.*\n      from DIE_VEN_COTA_GRUPO CG, DIE_VEN_COTA_GRUPO_PRODUTO CGP\n     where (CG.DIE_VEN_COTA_GRUPO_ID = PDIE_VEN_COTA_GRUPO_ID or\n           PDIE_VEN_COTA_GRUPO_ID = 0)\n       and CG.DIE_VEN_COTA_GRUPO_ID = CGP.DIE_VEN_COTA_GRUPO_ID;\n  --\n    \n  --\nbegin\n  --\n  if DELETING then\n    VDIE_VEN_META_ID := :old.DIE_VEN_META_ID;\n    for MG in META_GRUPO loop\n      delete DIE_VEN_META_GRUPO XMG\n       where XMG.DIE_VEN_META_GRUPO_ID = MG.DIE_VEN_META_GRUPO_ID;\n    end loop;\n    commit;\n  end if;\n  if UPDATING or INSERTING then\n    VDIE_VEN_META_ID := :new.DIE_VEN_META_ID;\n    execute immediate 'alter trigger DIE_TRG_BIUD_VEN_META_GRUPO disable';\n  \n    :new.vlr_meta_vendedor := ROUND(:NEW.VLR_META_VENDA /\n                                    :NEW.NR_VENDEDORES,\n                                    2);\n  \n    -- AOK - Busca parametros do dia inicial e final para geracao da meta - 27/03/2009\n    /*VN_DIA_INICIAL_META := BEG_FNC_RETORNA_PARAM_GERAL('Vendas',\n                                                       null,\n                                                       'DIA_INICIAL_META');\n    VN_DIA_FINAL_META   := BEG_FNC_RETORNA_PARAM_GERAL('Vendas',\n                                                       null,\n                                                       'DIA_FINAL_META');*/\n    --\n    :new.MESANO     := LAST_DAY(:new.MESANO);\n    :new.DT_INICIAL := TO_DATE('01' || '-' ||\n                               TO_CHAR((:new.MESANO), 'MM-RRRR'),\n                               'DD-MM-RRRR');\n    :new.DT_FINAL   := LAST_DAY(:new.MESANO);\n    --\n    IF :NEW.VLR_META_VENDA > 0 THEN\n      \n     SELECT NVL(SUM(A.PERC_META),0) \n        INTO V_PERC\n    FROM DIE_VEN_META_DIA A\n    WHERE A.DATA BETWEEN :NEW.DT_INICIAL AND :NEW.DT_FINAL;\n     \n       IF V_PERC <> 100 THEN\n         RAISE_APPLICATION_ERROR(-20001,\n                                  'Metas diarias com diferenca nas somas. Lançado total de :'|| v_perc);\n       END IF;\n    \n    END IF;\n    if UPDATING then\n      if not UPDATING('ISACTIVE') -- aok - 17/10/2008\n       then\n        if :new.VLR_META_VENDA = 0 then\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Valor da meta não pode ser zerada');\n        end if;\n        --\n        for MG in META_GRUPO loop\n          for CG in COTA_GRUPO(MG.DIE_VEN_COTA_GRUPO_ID) loop\n            update DIE_VEN_META_GRUPO_PRODUTO MGP\n               set MGP.VLR_META_VENDA = :new.VLR_META_VENDA * CG.PERC_COTA / 100\n             where MGP.DIE_VEN_META_GRUPO_ID = MG.DIE_VEN_META_GRUPO_ID\n               and MGP.DIE_PRD_GRUPO_ID = CG.DIE_PRD_GRUPO_ID\n               and MGP.DIE_VEN_COTA_GRUPO_ID = CG.DIE_VEN_COTA_GRUPO_ID;\n          end loop;\n        end loop;\n      end if;\n      /*    DIE_PRC_VEN_META_GRUPO('M',\n                                 :new.DIE_VEN_META_ID,\n                                 null,\n                                 null,\n                                 :new.VLR_META_VENDA);\n      */ --\n    else\n      -- AOK -- 23/07/2007\n      if :new.AD_ORG_ID > 0 then\n        open C_FILIAL;\n        fetch C_FILIAL\n          into VDIE_VEN_COTA_GRUPO_ID;\n        if C_FILIAL%notfound or NVL(VDIE_VEN_COTA_GRUPO_ID, 0) = 0 then\n          RAISE_APPLICATION_ERROR(-20002,\n                                  'Não encontrou o a cota padrao para a filial!');\n        end if;\n        --  RAISE_APPLICATION_ERROR(-20003, :new.DIE_VEN_META_ID);\n        VDIE_VEN_META_GRUPO_ID := BEG_FNC_AD_SEQUENCE('DIE_VEN_META_GRUPO');\n        insert into DIE_VEN_META_GRUPO\n          (DIE_VEN_META_GRUPO_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           DIE_VEN_COTA_GRUPO_ID,\n           DIE_VEN_META_ID)\n        values\n          (VDIE_VEN_META_GRUPO_ID,\n           :new.AD_CLIENT_ID,\n           :new.AD_ORG_ID,\n           'Y',\n           sysdate,\n           :new.CREATEDBY,\n           sysdate,\n           :new.UPDATEDBY,\n           VDIE_VEN_COTA_GRUPO_ID,\n           :new.DIE_VEN_META_ID);\n      \n        for CG in COTA_GRUPO(VDIE_VEN_COTA_GRUPO_ID) loop\n          insert into DIE_VEN_META_GRUPO_PRODUTO\n            (DIE_VEN_META_GRUPO_PRODUTO_ID,\n             DIE_VEN_META_GRUPO_ID,\n             AD_CLIENT_ID,\n             AD_ORG_ID,\n             ISACTIVE,\n             CREATED,\n             CREATEDBY,\n             UPDATED,\n             UPDATEDBY,\n             VLR_META_VENDA,\n             DIE_VEN_COTA_GRUPO_ID,\n             DIE_PRD_GRUPO_ID)\n          values\n            (BEG_FNC_AD_SEQUENCE('DIE_VEN_META_GRUPO_PRODUTO'),\n             VDIE_VEN_META_GRUPO_ID,\n             :new.AD_CLIENT_ID,\n             :new.AD_ORG_ID,\n             'Y',\n             sysdate,\n             :new.CREATEDBY,\n             sysdate,\n             :new.UPDATEDBY,\n             :new.VLR_META_VENDA * CG.PERC_COTA / 100, --VLR_META_VENDA,\n             CG.DIE_VEN_COTA_GRUPO_ID,\n             CG.DIE_PRD_GRUPO_ID);\n        end loop;\n        --    \n      end if;\n    end if;\n    commit;\n    execute immediate 'alter trigger DIE_TRG_BIUD_VEN_META_GRUPO enable';\n  end if;\n  --\nend DIE_TRG_BIUD_META_VENDA;\n"}`;
    
    }
}
