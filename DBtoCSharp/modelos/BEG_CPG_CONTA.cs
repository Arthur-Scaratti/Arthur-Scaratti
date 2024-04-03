
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_CONTA
    {
        
        /// <summary>
        /// Id da conta contabil relacionado 
        /// </summary>
        public int DIE_CTB_CONTA_CONTABIL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CPG_CONTA_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXIGE_CENTRO_CUSTO { get; set; }
        
        /// <summary>
        /// INDICATIVO QUE A CONTA É DO PROCESSO DE RECUP. JUDICIAL 2023
        /// </summary>
        public string IND_RJ { get; set; }
            [StringLength(1)]
        /// <summary>
        /// INDICATIVO DE TERCEIRO/FORNECEDOR PARA GERAR ARQUIVOS EZA
        /// </summary>
        public string IND_EXIGE_TERCEIRO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID da conta dos titulos
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
            [Required]
        /// <summary>
        /// Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo (Y/N)
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// Data de criacao do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data ultima alteracao registro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario ultima alteracao registro
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// Codigo reduzido da conta
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// Descrição da conta
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// Codigo reduzido da conta
        /// </summary>
        public int COD_REDUZIDO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Tipo da conta: A - Analitica (totalizadora) / S - Sintetica (recebe lancamentos)
        /// </summary>
        public string TP_CONTA { get; set; }
        
        /// <summary>
        /// Nivel hierarquico da conta
        /// </summary>
        public int NRO_NIVEL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que conta deve ser listada no DRE (Demonstrativo de Resultado de Exercicio)
        /// </summary>
        public string IND_LISTA_DRE { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_CPG_CONTA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\n  OMENSAGEM varchar2(250);\n  --\n  VC_MASCARA BEG_PARAMETRO_SISTEMA.CARACTER%type;\n  --\nbegin\n  -- Busca a mascara dos parametros\n  :new.name := UPPER(:new.name);\n  if INSERTING\n     or UPDATING(:new.value) then\n    VC_MASCARA := BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n                                            :new.AD_ORG_ID,\n                                            'Contabilidade',\n                                            null,\n                                            'CLASSIFICADOR_CONTABIL');\n  \n    if VC_MASCARA is null then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Mascara não parametrizada para a Contabilidade - Classificador Contabil!');\n    end if;\n    --\n    -- Procedure para validação das contas - ver beg_parametro_sistema.\n    --\n    -- Altera a chamada da procedure\n    BEG_VALIDA_CONTAS(:new.value,\n                      VC_MASCARA,\n                      :new.TP_CONTA,\n                      :new.NRO_NIVEL,\n                      OMENSAGEM);\n    --\n    if OMENSAGEM is not null then\n      RAISE_APPLICATION_ERROR(-20001, OMENSAGEM);\n    end if;\n  else\n    if :new.NRO_NIVEL = 1 then\n      :new.TP_CONTA := 'S'; -- Sintetica\n    else\n      :new.TP_CONTA := 'A'; -- Analitica\n    end if;\n  end if;\n  --\nend BEG_TRG_BIU_CPG_CONTA;\n"}`;
    
    }
}
