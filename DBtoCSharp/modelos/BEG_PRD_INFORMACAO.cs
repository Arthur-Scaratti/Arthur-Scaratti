
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_INFORMACAO
    {
        
        /// <summary>
        /// EM CENTIMETROS
        /// </summary>
        public int ALTURA { get; set; }
        
        /// <summary>
        /// EM CENTIMETROS
        /// </summary>
        public int LARGURA { get; set; }
        
        /// <summary>
        /// EM CENTIMETROS
        /// </summary>
        public int COMPRIMENTO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_INFORMACAO_ID { get; set; }
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
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_BARRAS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string MODELO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string MARCA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_FORNECEDOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TEMPO_REPOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int GARANTIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MULTIPLO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PESO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VOLUMES { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string URL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int STATUS { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string INFO_ADIC { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string ACOMPANHA { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_PRD_INF { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\n  cursor busca_marca is \n    select m.beg_prd_marca_id\n    from beg_prd_marca m\n    where m.descricao = :new.marca;\n  --\n  v_marca   number(10);\n  V_DESC_TECNICA VARCHAR2(4000);\nbegin\n  IF INSERTING \n    OR UPDATING THEN\n    open busca_marca;\n    fetch busca_marca into v_marca;\n    if busca_marca%notfound then\n      v_marca := beg_fnc_ad_sequence('BEG_PRD_MARCA');\n       insert into beg_prd_marca\n         (beg_prd_marca_id,\n          ad_client_id,\n          ad_org_id,\n          isactive,\n          created,\n          createdby,\n          updated,\n          updatedby,        \n          descricao)\n       values\n         (V_MARCA,\n          1000000,\n          0,\n          'Y',\n          SYSDATE,\n          1000000,\n          SYSDATE,\n          1000000,\n          :NEW.MARCA);\n                 \n    end iF;\n    close busca_marca;\n    update beg_produto p \n       set p.modelo = :new.modelo,\n           p.beg_prd_marca_id = V_MARCA,\n           P.DESC_TECNICA =  :NEW.INFO_ADIC\n    where  p.beg_produto_id = :new.beg_produto_id;\n    --\n    update beg_prd_logistica l\n       set l.nro_volume = :new.volumes,\n           l.peso = :new.peso,\n           l.lote_multiplo = :new.multiplo\n    where  l.beg_produto_id = :new.beg_produto_id;\n    --\n    update beg_prd_etiqueta e\n       set e.codigo_barra = :new.cod_barras\n    where  e.beg_produto_id = :new.beg_produto_id\n    and    e.beg_prd_etiqueta_tipo_id = 2000000; -- ean13\n    if sql%notfound then \n      insert into beg_prd_etiqueta\n        (beg_prd_etiqueta_id,\n         ad_client_id,\n         ad_org_id,\n         isactive,\n         created,\n         createdby,\n         updated,\n         updatedby,\n         codigo_barra,\n         imprime,\n         quantidade,\n         beg_produto_id,\n         beg_prd_etiqueta_tipo_id)\n      values\n        (beg_fnc_ad_sequence('BEG_PRD_ETIQUETA'),\n         1000000,\n         0,\n         'Y',\n         SYSDATE,\n         1000000,\n         SYSDATE,\n         1000000,\n         :NEW.COD_BARRAS,\n         'N',\n         2,\n         :NEW.beg_produto_id,\n         2000000);\n      \n    end if;\n    --\n    UPDATE BEG_PRD_SUPRIMENTO S\n       SET S.NRO_MESES_GARANTIA = :NEW.GARANTIA\n    WHERE  S.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n    --\n    update beg_sup_lista_fornecedor l\n       set l.referencia = :new.cod_fornecedor\n    where  l.beg_produto_id = :new.beg_produto_id;\n  ELSE\n    RAISE_APPLICATION_ERROR(-20501,'Exclusão nao permitida');\n  END IF;\nend BEG_TRG_BIUD_PRD_INF;\n"}`;
    
    }
}
