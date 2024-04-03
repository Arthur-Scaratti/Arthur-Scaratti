
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_SKU_DETALHE
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do detalhe do SKU por filial
        /// </summary>
        public int BEG_PRD_SKU_DETALHE_ID { get; set; }
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
            [StringLength(50)]
        /// <summary>
        /// Posic?o fisica de separac?o (no almoxarifado de faturamento) do produto / SKU
        /// </summary>
        public string POSICAO_FISICA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica abertura de embalagem
        /// </summary>
        public string IND_ABRE_EMBALAGEM { get; set; }
            [Required]
        /// <summary>
        /// ID do produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do SKU
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
            [Required]
        /// <summary>
        /// ID da situac?o do produto / SKU
        /// </summary>
        public int BEG_PRD_SITUACAO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID da margem do produto / SKU
        /// </summary>
        public int BEG_VEN_COM_MARGEM_PRODUTO_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AU_SKU_DETALHE { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"DECLARE\n\n  PRAGMA AUTONOMOUS_TRANSACTION;\n  V_SIT_ID NUMBER(10);\n\nBEGIN\n\n  --\n  IF :OLD.BEG_PRD_SITUACAO_ID = 2000004 AND\n     :NEW.BEG_PRD_SITUACAO_ID IN (2000001, 2000005) THEN\n  \n    V_SIT_ID := DIE_FNC_PRD_SIT_PAI(:NEW.BEG_PRODUTO_ID);\n  \n    IF V_SIT_ID = 2000004 THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Produto pai liquidado. Primeiro ativar codigo pai depois filho. Verifique! Id produto ' ||:NEW.BEG_PRODUTO_ID);\n    \n    END IF;\n  \n  END IF;\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIU_PRD_SKU_DETALHE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /*----------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que valida o saldo dos produtos para nao permitir liquidacao.\n  Modulo.......: PRD - produto\n  Analista.....: Marcelo Fritsch\n  Alterac?es:\n  Data        Desenvolvedor   Alteracao\n  21/08/2014  Marcelo Fritsch   Criacao.\n                               Só permite Liquidar codigo pai se filhos (voltagem/cor) também \n                               estiverem zerados.\n  ----------------------------------------------------------------------------------------*/\n\n  --\n  cursor C1 is\n    select COUNT(S.qtd) QTDE, P.DIE_COD_ESTRUTURADO\n      from BEG_ESTOQUE s, beg_produto p\n     where (s.beg_produto_id = p.beg_produto_id and\n           (s.qtd <> 0 or s.qtd_reservada <> 0) and p.beg_produto_id = /*2027417*/\n           :NEW.BEG_PRODUTO_ID)\n        OR (s.beg_produto_id = p.beg_produto_id and\n           (s.qtd <> 0 or s.qtd_reservada <> 0) and p.die_vw_prd_pai_id = /*2027417*/\n           :NEW.BEG_PRODUTO_ID)\n      GROUP BY P.DIE_COD_ESTRUTURADO;\n\n  R1 C1%rowtype;\n  --\n\nbegin\n\n  IF UPDATING AND :NEW.BEG_PRD_SITUACAO_ID <> :OLD.BEG_PRD_SITUACAO_ID THEN\n  \n    open C1;\n    fetch C1\n      into R1;\n    close C1;\n  \n    IF :NEW.BEG_PRD_SITUACAO_ID = 2000004 AND NVL(R1.QTDE, 0) <> 0 THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Produto '||R1.DIE_COD_ESTRUTURADO||'  possui saldo, nao pode ser liquidado. Verifique!');\n    \n    END IF;\n    --\n  \n  END IF;\n\n  IF :NEW.POSICAO_FISICA IS NULL THEN\n    :NEW.POSICAO_FISICA := '1';\n  END IF;\n\n  :NEW.POSICAO_FISICA := UPPER(:NEW.POSICAO_FISICA);\n\n  IF :NEW.POSICAO_FISICA NOT IN ('1',\n                                 'A',\n                                 'A1',\n                                 'A2',\n                                 'A3',\n                                 'A4',\n                                 'A5',\n                                 'A6',\n                                 'A7',\n                                 'A8',\n                                 'A9',\n                                 'B',\n                                 'B1',\n                                 'B2',\n                                 'B3',\n                                 'B4',\n                                 'B5',\n                                 'B6',\n                                 'B7',\n                                 'B8',\n                                 'B9',\n                                 'C',\n                                 'C1',\n                                 'C2',\n                                 'C3',\n                                 'C4',\n                                 'C5',\n                                 'C6',\n                                 'C7',\n                                 'C8',\n                                 'C9',\n                                 'D',\n                                 'D1',\n                                 'D2',\n                                 'D3',\n                                 'D4',\n                                 'D5',\n                                 'D6',\n                                 'D7',\n                                 'D8',\n                                 'D9',\n                                 'E',\n                                 'F',\n                                 'G',\n                                 'H',\n                                 'I',\n                                 'J',\n                                 'J1',\n                                 'J2',\n                                 'J3',\n                                 'J4',\n                                 'J5',\n                                 'J6',\n                                 'J7',\n                                 'J8',\n                                 'J9',\n                                 'K',\n                                 'K1',\n                                 'K2',\n                                 'K3',\n                                 'K4',\n                                 'K5',\n                                 'K6',\n                                 'K7',\n                                 'K8',\n                                 'K9',\n                                 'L',\n                                 'L1',\n                                 'L2',\n                                 'L3',\n                                 'L4',\n                                 'L5',\n                                 'L6',\n                                 'L7',\n                                 'L8',\n                                 'L9') THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Posicao fisica informada fora dos padroes permitidos. Verifique!');\n  END IF;\n\nend DIE_TRG_BIU_PRD_SKU_DETALHE;\n"}`;
    
    }
}
