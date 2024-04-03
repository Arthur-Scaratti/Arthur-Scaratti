
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CEL_OPERADORA
    {
        
        /// <summary>
        /// Data de inativação.
        /// </summary>
        public string DT_INATIVO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID da operadora.
        /// </summary>
        public int BEG_CEL_OPERADORA_ID { get; set; }
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
        /// Código da operadora.
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// Nome da operadora.
        /// </summary>
        public string NAME { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CEL_OPERADORA { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  vn_dummy Number;\n\nbegin\n  if deleting then\n    Raise_Application_Error( -20001, 'Impossível excluir operadoras!' );\n  end if;\n\n  if Updating( 'AD_ORG_ID' ) then\n    -- Valida filial referente aos planos\n    select Count( 1 )\n      into vn_dummy\n      from beg_cel_plano\n     where beg_cel_operadora_id                                      = :new.beg_cel_operadora_id\n       and BEG_PCK_GER_Geral.FNC_Org_Ok( ad_org_id, :new.ad_org_id ) = 'N'\n       and rownum                                                    < 2;\n    if vn_dummy > 0 then\n      Raise_Application_Error( -20001, 'Filial da operadora inconsistente com filial dos planos!' );\n    end if;\n\n    -- Valida filial referente aos vínculos\n    select Count( 1 )\n      into vn_dummy\n      from beg_cel_plano         pl\n         , beg_cel_plano_produto pp\n     where pl.beg_cel_plano_id                                          = pp.beg_cel_plano_id\n       and pl.beg_cel_operadora_id                                      = :new.beg_cel_operadora_id\n       and BEG_PCK_GER_Geral.FNC_Org_Ok( pp.ad_org_id, :new.ad_org_id ) = 'N'\n       and rownum                                                       < 2;\n    if vn_dummy > 0 then\n      Raise_Application_Error( -20001, 'Filial da operadora inconsistente com filial do vínculo de produtos!' );\n    end if;\n  end if;\n\n  if :new.isactive = 'Y' then\n    :new.dt_inativo := null;\n  elsif :new.isactive = 'N' then\n    -- Valida se oparadora possui planos padrão de produtos\n    if updating then\n      select Count( 1 )\n        into vn_dummy\n        from beg_produto   pr\n           , beg_cel_plano pl\n       where pr.beg_cel_plano_id     = pl.beg_cel_plano_id\n         and pl.beg_cel_operadora_id = :new.beg_cel_operadora_id\n         and rownum                  < 2;\n      if vn_dummy > 0 then\n        Raise_Application_Error( -20001, 'Operadora com planos padrão em produto!' );\n      end if;\n    end if;\n    :new.dt_inativo := Nvl( :new.dt_inativo, Trunc( sysdate ) );\n  else\n    Raise_Application_Error( -20001, 'Marcação inválida!' );\n  end if;\n\n  :new.name := Upper( :new.name );\n\nend BEG_TRG_BIUD_CEL_OPERADORA;\n"}`;
    
    }
}
