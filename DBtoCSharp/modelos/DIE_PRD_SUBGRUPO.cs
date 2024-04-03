
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PRD_SUBGRUPO
    {
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que subgrupo permite geração automática de produto especial (código especial).
        /// </summary>
        public string IND_ESPECIAL { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// Nome do subgrupo.
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int GARANTIA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string MONTAGEM { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que subgrupo aceita plano. Usado para celulares.
        /// </summary>
        public string IND_ACEITA_PLANO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que subgrupo permite geração automática de produto encomenda.
        /// </summary>
        public string IND_ENCOMENDA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que subgrupo permite geração automática de produto reservado.
        /// </summary>
        public string IND_RESERVADO { get; set; }
            [Required]
        /// <summary>
        /// ID do grupo.
        /// </summary>
        public int DIE_PRD_GRUPO_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do subgrupo.
        /// </summary>
        public int DIE_PRD_SUBGRUPO_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// Código do subgrupo.
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// ID do grupo de dados de venda
        /// </summary>
        public int BEG_GPR_DADOS_VENDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_PROD_CAIXA_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// DEPOSITO PADRAO DO PRODUTO
        /// </summary>
        public string DEP_PADRAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_COM_MARGEM_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// QTDE MAXIMA A SER PERMITIDA POR LINHA
        /// </summary>
        public int QTDE_MAXIMA { get; set; }
        
        /// <summary>
        /// Classificacao comercial
        /// </summary>
        public int BEG_PRD_COMERCIAL_CLASS_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string MONTAGEM_INTERNA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// CODIGO DA MAPFRE INTERROMPIDO TEMPORARIAMENTE 05/11/2022
        /// </summary>
        public string GARANTIA_MAPFRE { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AIU_PRD_SUBGRUPO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  CURSOR C1 IS\n    SELECT G.DIE_PRD_GARANTIA_ID, G.VALUE\n      FROM DIE_PRD_GARANTIA G\n     WHERE SUBSTR(G.VALUE, 1, 2) = TO_CHAR(:NEW.GARANTIA)\n       AND G.ISACTIVE = 'Y';\n\nBEGIN\n\n  IF INSERTING AND NVL(:NEW.GARANTIA, 0) <> 0 THEN\n    FOR X IN C1 LOOP\n      INSERT INTO DIE_PRD_SUBGRUPO_GARANTIA\n        (DIE_PRD_SUBGRUPO_GARANTIA_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         DIE_PRD_SUBGRUPO_ID,\n         DIE_PRD_GARANTIA_ID,\n         TEMPO_GARANTIA)\n      VALUES\n        (BEG_FNC_AD_SEQUENCE('DIE_PRD_SUBGRUPO_GARANTIA'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         :NEW.ISACTIVE,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         :NEW.DIE_PRD_SUBGRUPO_ID,\n         X.DIE_PRD_GARANTIA_ID,\n         TO_NUMBER(SUBSTR(X.VALUE, 4, 1)) --X.TEMPO_GARANTIA \n         );\n    \n    END LOOP;\n  \n  END IF;\n  \n  IF UPDATING  AND NVL(:NEW.GARANTIA, 0) <> 0 AND NVL(:OLD.GARANTIA, 0) = 0 THEN\n    FOR X IN C1 LOOP\n      INSERT INTO DIE_PRD_SUBGRUPO_GARANTIA\n        (DIE_PRD_SUBGRUPO_GARANTIA_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         DIE_PRD_SUBGRUPO_ID,\n         DIE_PRD_GARANTIA_ID,\n         TEMPO_GARANTIA)\n      VALUES\n        (BEG_FNC_AD_SEQUENCE('DIE_PRD_SUBGRUPO_GARANTIA'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         :NEW.ISACTIVE,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         :NEW.DIE_PRD_SUBGRUPO_ID,\n         X.DIE_PRD_GARANTIA_ID,\n         SUBSTR(X.VALUE, 4, 1) --X.TEMPO_GARANTIA \n         );\n    \n    END LOOP;\n  \n  END IF;\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BU_PRD_SUBGRUPO { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"begin\n  if :new.beg_ven_com_margem_produto_id <> :old.beg_ven_com_margem_produto_id then\n    update beg_prd_sku_detalhe d\n       set d.beg_ven_com_margem_produto_id = :new.beg_ven_com_margem_produto_id\n    where  d.beg_produto_id in (select beg_produto_id \n                                from   beg_produto p\n                                where  p.die_prd_subgrupo_id = :new.die_prd_subgrupo_id)\n    and    d.beg_ven_com_margem_produto_id = :old.beg_ven_com_margem_produto_id; \n  end if;\nend DIE_TRG_BU_PRD_GRUPO;\n"}`;
    
    }
}
