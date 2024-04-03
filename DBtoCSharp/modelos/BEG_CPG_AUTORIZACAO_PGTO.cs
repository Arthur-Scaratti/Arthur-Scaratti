
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_AUTORIZACAO_PGTO
    {
            [Required]
    [Key]
        /// <summary>
        /// ID da autorizac?o de pagamento
        /// </summary>
        public int BEG_CPG_AUTORIZACAO_PGTO_ID { get; set; }
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
        /// Codigo da autorizac?o de pagamento
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Valor da autorizac?o
        /// </summary>
        public int VLR_AUTORIZACAO { get; set; }
            [Required]
        /// <summary>
        /// Data de vencimento da autorizac?o
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// Data de pagamento da autorizac?o
        /// </summary>
        public string DT_PGTO { get; set; }
            [Required]
        /// <summary>
        /// Numero da via que foi impressa
        /// </summary>
        public int NRO_VIA_IMPRESSA { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Observac?o da autorizac?o
        /// </summary>
        public string OBS { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Status da autorizac?o de pagamento: WP - Aguardando pagamento (Waiting Payment) / PA - Paga (PAyed) / CA - Cancelada (CAnceled)
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// ID do fornecedor
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// ID da nota fiscal de entrada especial
        /// </summary>
        public int BEG_VW_CPR_NFE_ESPECIAL_ID { get; set; }
        
        /// <summary>
        /// ID da nota fiscal de entrada
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// ID da forma de pagamento
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// ID da informac?o bancaria do fornecedor
        /// </summary>
        public int BEG_DADOS_BANCARIOS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_CPG_AUT_PGTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /* ----------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que valida as informac?es para as autorizac?es de pagamento.\n   Modulo.......: CPG - Contas a Pagar\n   Analista.....: Tiago Gabriel\n   Alterac?es:\n   Data        Desenvolvedor  Alterac?o\n   27/07/2006  Tiago Gabriel  Criac?o.\n  ---------------------------------------------------------------------------------------------- */\n  VN_DUMMY number;\n\nbegin\n  -- Valida os campos informados e inicializa os possiveis\n  if NVL(:new.BEG_VW_FORNECEDOR_ID, 0) = 0 then\n    if NVL(:new.BEG_CPR_NFE_ID, 0) = 0\n       and NVL(:new.BEG_VW_CPR_NFE_ESPECIAL_ID, 0) = 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Fornecedor, nota normal ou nota especial devem ser informados!');\n    else\n      begin\n        select BEG_VW_FORNECEDOR_ID,\n               NVL(:new.VLR_AUTORIZACAO,\n                   sum(VLR_TOTAL_NOTA - VLR_TOTAL_FATURADO))\n          into :new.BEG_VW_FORNECEDOR_ID,\n               :new.VLR_AUTORIZACAO\n          from BEG_CPR_NFE\n         where BEG_CPR_NFE_ID in (NVL(:new.BEG_CPR_NFE_ID, 0),\n                NVL(:new.BEG_VW_CPR_NFE_ESPECIAL_ID, 0))\n         group by BEG_VW_FORNECEDOR_ID;\n      \n      exception\n        when NO_DATA_FOUND then\n          RAISE_APPLICATION_ERROR(-20001, 'Nota(s) n?o encontrada(s)!');\n        \n        when TOO_MANY_ROWS then\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Nota(s) com fornecedor diferente!');\n        \n      end;\n    end if;\n  \n  else\n  \n    if NVL(:new.BEG_CPR_NFE_ID, 0) > 0\n       or NVL(:new.BEG_VW_CPR_NFE_ESPECIAL_ID, 0) > 0 then\n      begin\n        select 1\n          into VN_DUMMY\n          from BEG_CPR_NFE\n         where BEG_CPR_NFE_ID in (NVL(:new.BEG_CPR_NFE_ID, 0),\n                NVL(:new.BEG_VW_CPR_NFE_ESPECIAL_ID, 0))\n           and BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID\n         group by BEG_VW_FORNECEDOR_ID;\n      \n      exception\n        when NO_DATA_FOUND then\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Fornecedor informado n?o pertence as notas informadas!');\n        \n        when TOO_MANY_ROWS then\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Nota(s) com fornecedor diferente!');\n        \n      end;\n    \n    end if;\n  \n  end if;\n\n  -- Valida os dados bancarios, caso ja tenham sido informados\n  if NVL(:new.BEG_DADOS_BANCARIOS_ID, 0) > 0 then\n    select count(1)\n      into VN_DUMMY\n      from BEG_DADOS_BANCARIOS\n     where BEG_DADOS_BANCARIOS_ID = :new.BEG_DADOS_BANCARIOS_ID\n       and BEG_PESSOA_ID = :new.BEG_VW_FORNECEDOR_ID;\n  \n    if VN_DUMMY = 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Dados bancarios pertencem a outro fornecedor!');\n    end if;\n  end if;\n\n  -- Se informou a forma de pagamento, inicializa ou valida as informac?es financeiras\n  if NVL(:new.BEG_VEN_FORMA_PAGAMENTO_ID, 0) > 0 then\n    select count(1)\n      into VN_DUMMY\n      from BEG_VEN_FORMA_PAGAMENTO\n     where IND_OBRIGA_DADOS_BANCARIOS = 'Y'\n       and BEG_VEN_FORMA_PAGAMENTO_ID = :new.BEG_VEN_FORMA_PAGAMENTO_ID;\n  \n    if VN_DUMMY > 0\n       and NVL(:new.BEG_DADOS_BANCARIOS_ID, 0) <= 0 then\n      begin\n        select BEG_DADOS_BANCARIOS_ID\n          into :new.BEG_DADOS_BANCARIOS_ID\n          from BEG_FIN_INF_PESSOA\n         where BEG_PESSOA_ID = :new.BEG_VW_FORNECEDOR_ID\n           and NVL(BEG_DADOS_BANCARIOS_ID, 0) > 0;\n      \n      exception\n        when NO_DATA_FOUND then\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Informac?o bancaria padr?o do fornecedor n?o encontrada!');\n        \n        when TOO_MANY_ROWS then\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Informac?o financeira do fornecedor duplicada!');\n        \n      end;\n    end if;\n  \n  end if;\n\nend TRG_BIU_BEG_CPG_AUT_PGTO;\n"}`;
    
    }
}
