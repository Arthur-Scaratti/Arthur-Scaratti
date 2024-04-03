
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CST_PRODUTO
    {
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
        
        /// <summary>
        /// Valor do custo medio do produto, com base no custo, estoque e quantidade recebida na nota de entrada
        /// </summary>
        public int VLR_MEDIO { get; set; }
        
        /// <summary>
        /// ID do item da nota fiscal de entrada
        /// </summary>
        public int BEG_CPR_NFE_ITEM_ID { get; set; }
        
        /// <summary>
        /// ID da formula do calculo do custo
        /// </summary>
        public int BEG_CST_CALCULO_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do custo do produto
        /// </summary>
        public int BEG_CST_PRODUTO_ID { get; set; }
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
        /// Data de apurac?o ou digitac?o do custo
        /// </summary>
        public string DT_APURACAO { get; set; }
            [Required]
        /// <summary>
        /// Valor do custo do produto, aplicada a formula informada no item da nota de entrada
        /// </summary>
        public int VLR_CUSTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo do custo ou preco: I - Importado / C - Calculado na nota de entrada / D - Digitado
        /// </summary>
        public string TP_CUSTO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CST_PRODUTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /*---------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que inicializa os valores de custos.\n  Módulo.......: CST - Custos\n  Analista.....: Tiago Gabriel\n  Alterações:\n  Data        Desenvolvedor  Alteração\n  17/10/2006  Tiago Gabriel  Criação.\n  16/01/2007  Tiago Gabriel  Passou a buscar dados do detalhe do SKU, filtrado por filial.\n  02/03/2007  Tiago Gabriel  Adicionada msg de erro para produto sem margem definida.\n  03/03/2007  Tiago Gabriel  -> Removidas as colunas referente margem e preço sugerido, bem como a\n                                inicialização delas;\n                             -> Adicionado cálculo do custo médio.\n  ---------------------------------------------------------------------------------------------------*/\n  VN_VLR_MEDIO_ATUAL BEG_CST_PRODUTO.VLR_MEDIO%type;\n  VN_QTD_ATUAL       BEG_ESTOQUE.QTD%type;\n  VN_QTD_NFE         BEG_CPR_NFE_ITEM.QTD%type;\n  VC_VALUE           BEG_PRODUTO.value%type;\n\nbegin\n  select value\n    into VC_VALUE\n    from BEG_PRODUTO\n   where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n\n  if NVL(:new.VLR_CUSTO, 0) = 0 then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Produto <' || VC_VALUE ||\n                            '> não pode ter custo igual zero!');\n  end if;\n\n  if :new.DT_APURACAO is null then\n    :new.DT_APURACAO := sysdate;\n  else\n    -- Não informou a hora\n    if TRUNC(:new.DT_APURACAO) = :new.DT_APURACAO then\n      :new.DT_APURACAO := TO_DATE(TO_CHAR(:new.DT_APURACAO, 'dd/mm/rrrr') || ' ' ||\n                                  TO_CHAR(sysdate, 'hh:mi:ss'),\n                                  'dd/mm/rrrr hh:mi:ss');\n    end if;\n  end if;\n\n  -- Apura o custo médio se o registro está vinculado a um item de nota\n  if :new.BEG_CPR_NFE_ITEM_ID is not null then\n    VN_VLR_MEDIO_ATUAL := BEG_FNC_CST_VALOR(:new.AD_ORG_ID,\n                                            :new.BEG_PRODUTO_ID,\n                                            :new.BEG_PRD_SKU_ID);\n\n    /*\n    -- Se o custo medio atual esta zerado, deve ser digitado\n    if VN_VLR_MEDIO_ATUAL = 0 then\n      select value\n        into VC_VALUE\n        from BEG_PRODUTO\n       where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Produto <' || VC_VALUE ||\n                              '> deve ter o custo médio inicial digitado!');\n    end if;\n    */\n    -- Por hora, se o custo médio atual for zero, utiliza o custo líquido da entrada\n    if VN_VLR_MEDIO_ATUAL = 0 then\n      VN_VLR_MEDIO_ATUAL := :new.VLR_CUSTO;\n    end if;\n\n    VN_QTD_ATUAL := BEG_FNC_EST_RETORNA_QTD(:new.BEG_PRODUTO_ID,\n                                            :new.BEG_PRD_SKU_ID,\n                                            :new.AD_ORG_ID,\n                                            'T');\n    select QTD\n      into VN_QTD_NFE\n      from BEG_CPR_NFE_ITEM\n     where BEG_CPR_NFE_ITEM_ID = :new.BEG_CPR_NFE_ITEM_ID;\n\n    :new.VLR_MEDIO := ((VN_VLR_MEDIO_ATUAL * VN_QTD_ATUAL) +\n                      (:new.VLR_CUSTO * VN_QTD_NFE)) /\n                      (VN_QTD_ATUAL + VN_QTD_NFE);\n\n  end if;\n\n  if NVL(:new.VLR_MEDIO, 0) = 0 then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Produto <' || VC_VALUE ||\n                            '> não pode ter custo médio igual zero!');\n  end if;\n\nend BEG_TRG_BIUD_CST_PRODUTO;\n"}`;
    
    }
}
