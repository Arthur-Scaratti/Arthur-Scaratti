
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_CONJUNTO
    {
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que na exclusão os registros de preço devem ser excluídos.
        /// </summary>
        public string IND_EXCLUI_PRECOS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do conjunto
        /// </summary>
        public int BEG_PRD_CONJUNTO_ID { get; set; }
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
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// Data de início da vigência
        /// </summary>
        public string DT_INICIO { get; set; }
        
        /// <summary>
        /// Data final da vigência
        /// </summary>
        public string DT_FIM { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Botão auxiliar para o Compiere. Dispara o processo de cópia do conjunto
        /// </summary>
        public string BTN_COPIA_CONJUNTO { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_PRD_CONJUNTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que valida os dados inseridos na tabela de conjuntos.\n   Módulo.......: PRD - Produtos\n   Analista.....: Tiago Gabriel\n   Alterações:\n   Data        Desenvolvedor  Alteração\n   05/04/2007  Tiago Gabriel  Criação.\n   24/06/2008  Tiago Gabriel  Validação para alteração da data de início não ser menor que hoje. Era\n                              validada somente na inclusão.\n  --------------------------------------------------------------------------------------------------- */\n  pragma autonomous_transaction;\n\n  vc_msg_erro VarChar2( 200 );\n  vn_dummy    Number;\n  vdt_fim     beg_prd_conjunto.dt_fim%Type;\n\nbegin\n  if deleting then\n    -- Deve estar sem itens\n    select Count( 1 )\n      into vn_dummy\n      from beg_prd_preco\n     where beg_prd_conjunto_id = :old.beg_prd_conjunto_id\n       and ind_aprovado        = 'Y';\n\n    if vn_dummy > 0 then\n      vc_msg_erro := 'Conjunto possui itens (preços) vinculados que não podem ser excluídos!';\n    end if;\n\n    -- Verifica se deve excluir os itens (preços)\n    if :new.ind_exclui_precos = 'Y' then\n      delete from beg_prd_preco\n       where beg_prd_conjunto_id = :old.beg_prd_conjunto_id;\n    end if;\n\n    select Count( 1 )\n      into vn_dummy\n      from beg_prd_preco\n     where beg_prd_conjunto_id = :old.beg_prd_conjunto_id;\n\n    if vn_dummy > 0 then\n      vc_msg_erro := 'Conjunto possui itens vinculados!';\n    end if;\n    goto fim;\n  end if;\n\n  :new.ind_exclui_precos := 'N';\n\n  -- Data deve ter sido informada\n  if :new.dt_inicio is null then\n    vc_msg_erro := 'Data de início deve ser informada!';\n    goto fim;\n  end if;\n\n  -- Data de início deve ser maior que hoje (sysdate).\n  if ( inserting or Updating( 'DT_INICIO' ) ) and\n     :new.dt_inicio <= Trunc( sysdate )       then\n    vc_msg_erro := 'Data de início deve ser maior que hoje!';\n    goto fim;\n  end if;\n\n  -- Para facilitar as validações\n  vdt_fim := Nvl( :new.dt_fim, Trunc( sysdate ) );\n\n  -- Intervalo de datas deve ser válido\n  if Nvl( :new.dt_fim, :new.dt_inicio ) < :new.dt_inicio then\n    vc_msg_erro := 'Data de término deve estar em branco ou ser maior ou igual a data de início!';\n    goto fim;\n  end if;\n\n  -- Não permite alterações nos Conjuntos vigentes e anteriores.\n  if updating                                               and\n     :old.dt_inicio <= Trunc( sysdate )                     and\n     vdt_fim        =  Nvl( :old.dt_fim, Trunc( sysdate ) ) then\n    vc_msg_erro := 'Conjunto vigente ou anterior não permite alteração!';\n    goto fim;\n  end if;\n\n  <<fim>>\n  if vc_msg_erro is not null then\n    Raise_Application_Error( -20001, vc_msg_erro );\n  end if;\n\nend TRG_BIUD_BEG_PRD_CONJUNTO;\n"}`;
    
    }
}
