
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CEL_PLANO_PRODUTO
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do vínculo de planos e produtos.
        /// </summary>
        public int BEG_CEL_PLANO_PRODUTO_ID { get; set; }
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
        
        /// <summary>
        /// Data de inativação.
        /// </summary>
        public string DT_INATIVO { get; set; }
            [Required]
        /// <summary>
        /// ID do plano de celulares.
        /// </summary>
        public int BEG_CEL_PLANO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do produto.
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_CEL_PLANO_PRODUTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  vc_ind_aceita_plano die_prd_subgrupo.ind_aceita_plano%Type;\n  vn_dummy            Number;\n\nbegin\n  if :new.isactive = 'Y' then\n    :new.dt_inativo := null;\n  elsif :new.isactive = 'N' then\n    :new.dt_inativo := Nvl( :new.dt_inativo, Trunc( sysdate ) );\n  else\n    Raise_Application_Error( -20001, 'Marcação inválida!' );\n  end if;\n\n  if Updating( 'AD_ORG_ID' ) then\n    -- Valida filial referente ao plano e a operadora\n    select Count( 1 )\n      into vn_dummy\n      from beg_cel_operadora op\n         , beg_cel_plano     pl\n     where op.beg_cel_operadora_id                                        = pl.beg_cel_operadora_id\n       and pl.beg_cel_plano_id                                            = :new.beg_cel_plano_id\n       and ( BEG_PCK_GER_Geral.FNC_Org_Ok( :new.ad_org_id, op.ad_org_id ) = 'N'\n        or   BEG_PCK_GER_Geral.FNC_Org_Ok( :new.ad_org_id, pl.ad_org_id ) = 'N' )\n       and rownum                                                         < 2;\n    if vn_dummy > 0 then\n      Raise_Application_Error( -20001, 'Filial do vínculo de produtos inconsistente com filial do plano ou da operadora!' );\n    end if;\n  end if;\n\n  -- Somente permite vínculos com produtos pai\n  if :new.beg_produto_id <> BEG_FNC_PRD_Pai( :new.beg_produto_id ) then\n    Raise_Application_Error( -20001, 'Vínculo somente com produto pai!' );\n  end if;\n\n  -- Valida o subgrupo do produto\n  select sg.ind_aceita_plano\n    into vc_ind_aceita_plano\n    from die_prd_subgrupo sg\n       , beg_produto      p\n   where sg.die_prd_subgrupo_id = p.die_prd_subgrupo_id\n     and p.beg_produto_id       = :new.beg_produto_id;\n\n  if vc_ind_aceita_plano = 'N' then\n    Raise_Application_Error( -20001, 'Subgrupo não permite cadastramento de plano de celular!' );\n  end if;\n\nend BEG_TRG_BIU_CEL_PLANO_PRODUTO;\n"}`;
    
    }
}
