
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_REL_PADRAO
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do relatório padrão.
        /// </summary>
        public int BEG_GER_REL_PADRAO_ID { get; set; }
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
        /// ID do formato de impressão.
        /// </summary>
        public int AD_PRINTFORMAT_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do usuário principal q pode alterar o formato.
        /// </summary>
        public int AD_USER_ID { get; set; }
            [Required]
    [StringLength(255)]
        /// <summary>
        /// Descrição do relatório.
        /// </summary>
        public string DESCRIPTION { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_GER_REL_PADRAO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /*---------------------------------------------------------------------------------------------------\n    Objetivo(s)..: Trigger que valida a existência de usuários na tabela de usuários dos relatórios.\n    Modulo.......: GER - Geral\n    Analista.....: Tiago Gabriel\n    Alterações:\n    Data        Desenvolvedor  Alteração\n    03/06/2008  Tiago Gabriel  Criação.\n  ---------------------------------------------------------------------------------------------------*/\n  vn_dummy Number;\n\nbegin\n  select Count( 1 )\n    into vn_dummy\n    from beg_ger_rel_padrao_usuario\n   where beg_ger_rel_padrao_id = :new.beg_ger_rel_padrao_id\n     and ad_user_id            = :new.ad_user_id;\n\n  if vn_dummy > 0 then\n    Raise_Application_Error( -20001, 'Usuário informado na tabela filha!' );\n  end if;\n\nend BEG_TRG_BIU_GER_REL_PADRAO;\n"}`;
    
    }
}
