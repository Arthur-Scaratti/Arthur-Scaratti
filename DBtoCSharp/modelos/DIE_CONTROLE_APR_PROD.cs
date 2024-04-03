
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CONTROLE_APR_PROD
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CONTROLE_APR_PROD_ID { get; set; }
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
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_DESC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LISTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PROMOCAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CUSTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CONTROLE_APROVACAO_ID { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DIE_COD_ESTRUTURADO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIQUIDO { get; set; }

        [NotMapped]
        public string Trigger_TRG_BI_DIE_CONT_APR_PROD { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  cursor c1 is\n    /*SELECT BEG_FNC_PRD_PRECO(0, :NEW.Beg_Produto_Id, NULL, null, 'C') vlr_lista\n      FROM DUAL;*/\n      SELECT --BEG_FNC_PRD_PRECO(0, P.BEG_PRODUTO_ID, NULL, null, 'C') vlr_lista,\nCASE WHEN  trunc(sysdate) between '01/05/2017' and '07/05/2017' then\n         CASE WHEN P.Die_Cod_Estruturado = 'L417001' or\n                 P.Die_Cod_Estruturado like 'S%' then\n              round(nvl(BEG_FNC_PRD_PRECO(0,\n                                   P.BEG_PRODUTO_ID,\n                                   null,\n                                   null,\n                                   'C',\n                                   TRUNC(SYSDATE)),0),2)\n           WHEN P.die_prd_grupo_id in (1000005,1000000,1000004,1000011,1000010) then\n             round(nvl(BEG_FNC_PRD_PRECO(0,\n                                   P.BEG_PRODUTO_ID,\n                                   null,\n                                   null,\n                                   'C',\n                                   TRUNC(SYSDATE)),0) * 0.94)\n            ELSE\n            round(nvl(BEG_FNC_PRD_PRECO(0,\n                                   P.BEG_PRODUTO_ID,\n                                   null,\n                                   null,\n                                   'C',\n                                   TRUNC(SYSDATE)),\n                       0) * 0.89)\n          end\n       else\n         BEG_FNC_PRD_PRECO(0,\n                                   P.BEG_PRODUTO_ID,\n                                   null,\n                                   null,\n                                   'C',\n                                   TRUNC(SYSDATE))\n       end  vlr_lista\n\n      FROM beg_produto p\n      where p.beg_produto_id = :NEW.Beg_Produto_Id;\n      \n      \n  r1 c1%rowtype;\n\n  cursor c2 is\n    SELECT BEG_FNC_PRD_PRECO(0,\n                             :new.beg_produto_id,\n                             NULL,\n                             null,\n                             'P',\n                             trunc(sysdate)/*,\n                             null,\n                             'Y',\n                             'Y',\n                             'Y',\n                             'Y',\n                             'Y'*/) vlr_PROMO\n      FROM DUAL;\n  r2 c2%rowtype;\n\n  cursor c3 is\n    select max(l1.vlr_final) vlr_custo\n      from beg_sup_lista_fornecedor l1\n     where l1.beg_produto_id = :new.beg_produto_id\n       and l1.updated = (select max(l.updated)\n                           from beg_sup_lista_fornecedor l\n                          where l.isactive = 'Y'\n                            and l.beg_produto_id = :NEW.beg_produto_id\n                            and l.vlr_final > 0);\n  r3 c3%rowtype;\n  \n  CURSOR C4 IS \n    SELECT P.BEG_PRODUTO_ID\n      FROM BEG_PRODUTO P\n     WHERE P.DIE_COD_ESTRUTURADO = UPPER(:NEW.DIE_COD_ESTRUTURADO);\n  \n  R4 C4%ROWTYPE;    \n\nbegin\n  \n   OPEN C4;\n  FETCH C4\n    INTO R4;\n  CLOSE C4;\n  \n    :NEW.BEG_PRODUTO_ID := R4.BEG_PRODUTO_ID;\n  \n\n  OPEN C1;\n  FETCH C1\n    INTO R1;\n  CLOSE C1;\n\n  OPEN C2;\n  FETCH C2\n    INTO R2;\n  CLOSE C2;\n\n  OPEN C3;\n  FETCH C3\n    INTO R3;\n  CLOSE C3;\n\n  \n\n\n  :new.vlr_lista    := r1.vlr_lista;\n  :NEW.VLR_PROMOCAO := R2.VLR_PROMO;\n  :new.vlr_custo    := NVL(r3.vlr_custo,0);\n  :new.die_cod_estruturado := UPPER(:NEW.DIE_COD_ESTRUTURADO);\n  :NEW.VLR_LIQUIDO  := :NEW.VLR_LISTA - ROUND(:NEW.VLR_LISTA * (NVL(:NEW.PERC_DESC,0) / 100),2);\n  \nend;\n"}`;
    
    }
}
