
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CTB_CONTA_CONTABIL
    {
            [Required]
    [Key]
        /// <summary>
        /// Id da Conta contabil
        /// </summary>
        public int DIE_CTB_CONTA_CONTABIL_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da Filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo Yes or No
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// Data da criação do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Usuário que criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Ultima alteração do registro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Usuário, ultima alteração registro
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// Código Reduzido 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// Descrição da Conta Contabil
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(22)]
        /// <summary>
        /// Classificador da conta contabil
        /// </summary>
        public string COD_CLASSIFICADOR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Tipo de Conta Contabil
        /// </summary>
        public string TP_CONTA { get; set; }
        
        /// <summary>
        /// Nivel da Conta
        /// </summary>
        public int NRO_NIVEL { get; set; }
        
        /// <summary>
        /// Id da contrapartida
        /// </summary>
        public int DIE_VW_CTB_CONTA_CONTABIL_ID { get; set; }
            [Required]
        /// <summary>
        /// Gera Contas a Pagar - RESUMO DE CONTAS
        /// </summary>
        public string IND_GERAEZA_CP { get; set; }
            [Required]
        /// <summary>
        /// Gera Caixa Geral
        /// </summary>
        public string IND_GERAEZA_CG { get; set; }
            [Required]
        /// <summary>
        /// Gara Banco
        /// </summary>
        public string IND_GERAEZA_BC { get; set; }
            [Required]
        /// <summary>
        /// Rateia Contas a Pagar - Gera Provisao de Despesas (DRE)
        /// </summary>
        public string IND_RATEIA_CP { get; set; }
            [Required]
        /// <summary>
        /// Rateia Caixa Geral
        /// </summary>
        public string IND_RATEIA_CG { get; set; }
            [Required]
        /// <summary>
        /// Rateia Banco
        /// </summary>
        public string IND_RATEIA_BC { get; set; }
            [Required]
        /// <summary>
        /// Permite lancar a nota pela tela das notas de despesas.
        /// </summary>
        public string IND_DESPESA { get; set; }
        
        /// <summary>
        /// Id da filial correspondente (centro de custo)
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// Indica se a conta está no processo de recuperacao judicial.
        /// </summary>
        public string IND_RJ { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Conta original antes de entrar em RJ
        /// </summary>
        public string CONTAREFERENTE { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_CTB_CONTA_CONTABIL { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\n  OMENSAGEM varchar2(250);\n  --\n  VC_MASCARA BEG_PARAMETRO_SISTEMA.CARACTER%type;\n  --\nbegin\n  -- Busca a mascara dos parametros\n  :new.name := UPPER(:new.name);\n  if INSERTING\n     or UPDATING(:new.value) then\n    VC_MASCARA := BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n                                            :new.AD_ORG_ID,\n                                            'Contabilidade',\n                                            null,\n                                            'CLASSIFICADOR_CONTABIL');\n  \n    if VC_MASCARA is null then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Mascara não parametrizada para a Contabilidade - Classificador Contabil!');\n    end if;\n    --\n    -- Procedure para validação das contas - ver beg_parametro_sistema.\n    --\n    -- Altera a chamada da procedure\n    BEG_VALIDA_CONTAS(:new.COD_CLASSIFICADOR,\n                      VC_MASCARA,\n                      :new.TP_CONTA,\n                      :new.NRO_NIVEL,\n                      OMENSAGEM);\n    --\n    if OMENSAGEM is not null then\n      RAISE_APPLICATION_ERROR(-20001, OMENSAGEM);\n    end if;\n  END IF;  --ELSE\n    if :new.NRO_NIVEL = 1 then\n      :new.TP_CONTA := 'S'; -- Sintetica\n    else\n      :new.TP_CONTA := 'A'; -- Analitica\n    end if;\n -- end if;\n  --\n  IF :NEW.IND_RATEIA_CP = 'Y' AND :NEW.DIE_VW_CTB_CONTA_CONTABIL_ID IS NULL THEN \n    RAISE_APPLICATION_ERROR(-20001,\n                              'Faltou informar a contra partida para Rateio de NF Despesas');\n  END IF ;                             \n  \nend DIE_TRG_BIU_CTB_CONTA_CONTABIL;\n"}`;
    
    }
}
