
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_SERVICO
    {
        
        /// <summary>
        /// Id do Nr da Sorte
        /// </summary>
        public int DIE_NR_SORTE_ID { get; set; }
        
        /// <summary>
        /// Numero de meses de garantia de fabrica
        /// </summary>
        public int MESES_GAR_FABRICA { get; set; }
        
        /// <summary>
        /// Quantos anos adquiridos na garantia
        /// </summary>
        public int TEMPO_GAR_ESTENDIDA { get; set; }
        
        /// <summary>
        /// Data emissao venda
        /// </summary>
        public string DT_EMISSAO_VENDA { get; set; }
        
        /// <summary>
        /// Id do Cliente
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// NR da nota para visualizacao
        /// </summary>
        public string NRO_NOTA { get; set; }
        
        /// <summary>
        /// id da nota de devolucao
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// recibo da venda direta
        /// </summary>
        public int DIE_CRC_RECIBO_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// Data da venda do servico
        /// </summary>
        public string DATA { get; set; }
            [StringLength(8)]
        /// <summary>
        /// campo para dados venda seguro residencial
        /// </summary>
        public string CEP { get; set; }
            [StringLength(100)]
        /// <summary>
        /// campo para dados venda seguro residencial
        /// </summary>
        public string ENDERECO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// campo para dados venda seguro residencial
        /// </summary>
        public string NUMERO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// campo para dados venda seguro residencial
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// campo para dados venda seguro residencial
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// campo para dados venda seguro residencial
        /// </summary>
        public string ESTADO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// campo para dados venda seguro residencial
        /// </summary>
        public string TIPORISCO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// nr da sorte na venda de ap 
        /// </summary>
        public string NRSORTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int APOLICEGAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int APOLICEPF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int APOLICERES { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Serie da nota para visualizacao
        /// </summary>
        public string SERIE_NOTA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Forma como foi pago o servico: AP, AV, CC
        /// </summary>
        public string FORMA_PGTO { get; set; }
        
        /// <summary>
        /// ID do nr da NF de venda
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
        
        /// <summary>
        /// Id da garantia para exportação seguradora
        /// </summary>
        public int DIE_PRD_GARANTIA_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do vendedor do serviço (pode ser diferente da venda)
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do serviço vinculado
        /// </summary>
        public int DIE_FAT_SERVICO_ID { get; set; }
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
        /// Código do serviço (certificado)
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Data de inicio da vigencia
        /// </summary>
        public string DT_INICIO { get; set; }
        
        /// <summary>
        /// Data final da vigencia
        /// </summary>
        public string DT_FIM { get; set; }
        
        /// <summary>
        /// Data do cancelamento
        /// </summary>
        public string DT_CANCELAMENTO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Número da autorização de devolução
        /// </summary>
        public string NRO_AUT_DEVOLUCAO { get; set; }
            [Required]
        /// <summary>
        /// Valor base do serviço
        /// </summary>
        public int VLR_PRECO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Número de série do produto
        /// </summary>
        public string NRO_SERIE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica o tipo de venda do serviço: V - Venda com NF , A - Avulsa , D - Direta/Depois , F - Faturado
        /// </summary>
        public string IND_TIPO_VENDA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Código do serviço para envio
        /// </summary>
        public string COD_SERVICO { get; set; }
        
        /// <summary>
        /// Data do envio do serviço para seguradora
        /// </summary>
        public string DT_ENVIO { get; set; }
        
        /// <summary>
        /// ID do produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// ID do SKU
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
        
        /// <summary>
        /// ID do item da nota do serviço
        /// </summary>
        public int BEG_FAT_NFS_ITEM_ID { get; set; }
        
        /// <summary>
        /// Valor fixo alternativo para produtos(ex: celulares a um real)
        /// </summary>
        public int VLR_PRODUTO { get; set; }
        
        /// <summary>
        /// Nr do Recibo quando garantia Direta
        /// </summary>
        public int NR_RECIBO { get; set; }

        [NotMapped]
        public string Trigger_TRG_BI_DIE_FAT_SERVICO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  CURSOR C1 IS\n    SELECT N.NR_SORTE, N.DIE_NR_SORTE_ID, N.DATA\n      FROM DIE_NR_SORTE N\n     WHERE N.NR_SORTE = :NEW.NRSORTE\n       AND TRUNC(N.DATA) = TRUNC(:NEW.DATA);\n  R1 C1%ROWTYPE;\n\n  CURSOR C2 IS\n    SELECT SU.NRO_MESES_GARANTIA, SG.TEMPO_GARANTIA\n      FROM DIE_PRD_GARANTIA          G,\n           DIE_PRD_SUBGRUPO_GARANTIA SG,\n           BEG_PRODUTO               P,\n           BEG_PRD_SUPRIMENTO        SU\n     WHERE G.DIE_PRD_GARANTIA_ID = SG.DIE_PRD_GARANTIA_ID\n       AND P.DIE_PRD_SUBGRUPO_ID = SG.DIE_PRD_SUBGRUPO_ID\n       AND SU.BEG_PRODUTO_ID = P.BEG_PRODUTO_ID\n       AND P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID\n       AND G.VALUE = :NEW.COD_SERVICO;\n  R2 C2%ROWTYPE;\n\n  CURSOR C3 IS\n    SELECT N.DT_EMISSAO\n      FROM BEG_FAT_NFS N\n     WHERE N.BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID;\n\n  R3 C3%ROWTYPE;\nbegin\n\n  if inserting and :new.die_nr_sorte_id is null and\n     :new.beg_produto_id = 2035646 then\n  \n    OPEN C1;\n    FETCH C1\n      INTO R1;\n    CLOSE C1;\n  \n    :NEW.DIE_NR_SORTE_ID := R1.DIE_NR_SORTE_ID;\n  \n  end if;\n\n  IF (INSERTING OR UPDATING) AND NVL(:NEW.COD_SERVICO, 'PFIN') <> 'PFIN' THEN\n  \n    OPEN C2;\n    FETCH C2\n      INTO R2;\n    CLOSE C2;\n  \n    IF R2.NRO_MESES_GARANTIA IS NULL OR R2.TEMPO_GARANTIA IS NULL THEN\n      -- RAISE_APPLICATION_ERROR(-20001,'NAO LOCALIZOU TEMPOS ID SERVICO:  '||:NEW.DIE_FAT_SERVICO_ID);\n      NULL;\n    \n    ELSE \n      OPEN C3;\n      FETCH C3\n        INTO R3;\n      CLOSE C3;\n    \n     /* IF R3.DT_EMISSAO IS NULL THEN\n        RAISE_APPLICATION_ERROR(-20001,\n                                'NAO LOCALIZOU NOTA ID SERVICO:  ' ||\n                                :NEW.DIE_FAT_SERVICO_ID);\n      END IF;*/\n    \n      :NEW.DT_EMISSAO_VENDA := R3.DT_EMISSAO;\n      :NEW.DT_INICIO        := ADD_MONTHS((R3.DT_EMISSAO + 1),\n                                          R2.NRO_MESES_GARANTIA);\n    \n      IF R2.TEMPO_GARANTIA = 1 THEN\n        :NEW.DT_FIM := ADD_MONTHS((:NEW.DT_INICIO - 1), 12);\n      ELSE\n        :NEW.DT_FIM := ADD_MONTHS((:NEW.DT_INICIO - 1), 24);\n      END IF;\n    \n      :NEW.MESES_GAR_FABRICA   := R2.NRO_MESES_GARANTIA;\n      :NEW.TEMPO_GAR_ESTENDIDA := R2.TEMPO_GARANTIA;\n    END IF;\n  END IF;\n\nend;\n"}`;
    
    }
}
