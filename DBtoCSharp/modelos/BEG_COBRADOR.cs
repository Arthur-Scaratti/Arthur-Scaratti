
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COBRADOR
    {
            [Required]
    [Key]
        /// <summary>
        /// id co Conbrador
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// Codigo do cobrador ou sequencial do compiere
        /// </summary>
        public string VALUE { get; set; }
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
        /// percentual de comissao
        /// </summary>
        public int PERC_COMISSAO { get; set; }
            [Required]
        /// <summary>
        /// Id do parceiro comercial relacionado como cobrador
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// Data do ultimo retorno realizado
        /// </summary>
        public string DT_ULT_RETORNO { get; set; }
            [Required]
        /// <summary>
        /// Indica geração de dados em arquivo magnetico
        /// </summary>
        public string IND_ARQUIVO { get; set; }
        
        /// <summary>
        /// Numero de dias minimo  de atraso a ser considerado para este cobrador
        /// </summary>
        public int NRO_DIAS_MIN { get; set; }
        
        /// <summary>
        /// Numero de dias maximo de atraso a ser considerado para este cobrador
        /// </summary>
        public int NRO_DIAS_MAX { get; set; }
        
        /// <summary>
        /// Indicativo da atuacao - (I)nterno, (E)xterno e (A)mbos
        /// </summary>
        public string IND_ATUACAO { get; set; }
        
        /// <summary>
        /// Sequencia de envio de arquivo
        /// </summary>
        public int SQ_ENVIO_ARQ { get; set; }
        
        /// <summary>
        /// Data do ultimo envio de arquivo
        /// </summary>
        public string DT_ULT_ENVIO_ARQ { get; set; }
        
        /// <summary>
        /// Data para calculo do nro minimo de atraso a ser considerado
        /// </summary>
        public string DT_CALC_DIAS_MIN { get; set; }
        
        /// <summary>
        /// Data para calculo do nro maximo de atraso a ser considerado
        /// </summary>
        public string DT_CALC_DIAS_MAX { get; set; }
        
        /// <summary>
        /// Numero de dias maximo para título com cobrador - permanencia de titulos
        /// </summary>
        public int DIAS_MAX_COBR { get; set; }

        [NotMapped]
        public string Trigger_TRG_AIUD_BEG_COBRADOR { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  --\n  cursor CMVTO is\n    select NVL(count(1), 0) NRO_REG\n      from BEG_CRC_TITULO T\n     where T.BEG_COBRADOR_ID = :new.BEG_COBRADOR_ID\n       and T.ISACTIVE = 'Y'\n       and exists (select 1 from beg_titulo_cobrador tc -- AOK - 24/11/2008\n                   where tc.beg_cobrador_id = t.beg_cobrador_id\n                   and tc.ind_baixa_cobranca = 'N');\n  RMVTO CMVTO%rowtype;\n  --\nbegin\n  --\n  if INSERTING then\n    update BEG_PESSOA\n       set COBRADOR = 'Y'\n     where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  end if;\n  --\n  if DELETING then\n    update BEG_PESSOA\n       set COBRADOR = 'N'\n     where BEG_PESSOA_ID = :old.BEG_PESSOA_ID;\n  end if;\n  --\n  if UPDATING then\n    -- AOK - 22/08/2008\n    -- não permtir alterar o ativo do registro se possuir movimento para ele\n    if :new.ISACTIVE <> :old.ISACTIVE then\n      if :old.ISACTIVE = 'Y' then\n        open CMVTO;\n        fetch CMVTO\n          into RMVTO;\n        if CMVTO%notfound then\n          RMVTO.NRO_REG := 0;\n        end if;\n        close CMVTO;\n        if RMVTO.NRO_REG > 0 then\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Existem titulos para este cobrador');\n        end if;\n      end if;\n    end if;\n    --  \n    if :new.ISACTIVE != :old.ISACTIVE then\n      update BEG_PESSOA\n         set COBRADOR = :new.ISACTIVE\n       where BEG_PESSOA_ID = :old.BEG_PESSOA_ID;\n      --\n      update BEG_COBRADOR_FILIAL F\n         set ISACTIVE = :new.ISACTIVE\n       where F.AD_CLIENT_ID = :new.AD_CLIENT_ID\n         and F.AD_ORG_ID = :new.AD_ORG_ID\n         and F.BEG_COBRADOR_ID = :new.BEG_COBRADOR_ID;\n    end if;\n  end if;\n\nend TRG_AIUD_BEG_COBRADOR;\n"}`;
    
    }
}
