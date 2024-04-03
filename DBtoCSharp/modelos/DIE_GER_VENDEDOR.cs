
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_GER_VENDEDOR
    {
            [StringLength(1)]
        /// <summary>
        /// Indicativo funcao quando novo cadastro
        /// </summary>
        public string IND_FUNCAO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do Vendedor
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da filial que o vendedor esta lotado
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Codigo do Vendedor
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
        /// Id do Parceiro Comerical
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// Data inicial 
        /// </summary>
        public string DT_INICIAL { get; set; }
        
        /// <summary>
        /// Data final
        /// </summary>
        public string DT_FINAL { get; set; }
        
        /// <summary>
        /// Valor disponivel inteiro
        /// </summary>
        public int VL_INTEIRO1 { get; set; }
        
        /// <summary>
        /// Valor disponivel inteiro
        /// </summary>
        public int VL_INTEIRO2 { get; set; }
        
        /// <summary>
        /// Valor disponivel com decimal
        /// </summary>
        public int VL_VALOR1 { get; set; }
        
        /// <summary>
        /// Valor disponivel com decimal
        /// </summary>
        public int VL_VALOR2 { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Campo disponivel com 50 posicoes
        /// </summary>
        public string CARACTER1 { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Campo disponivel com 50 posicoes
        /// </summary>
        public string CARACTER2 { get; set; }
        
        /// <summary>
        /// Indicativo de venda direta
        /// </summary>
        public string IND_VENDA_DIRETA { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_GER_VENDEDOR { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\nbegin\n  --\n  if INSERTING then\n    /*if NVL(:new.value, 0) = 0 then\n      select min(B.COD) + 1\n        into :new.value\n        from (select TO_NUMBER(V.value) COD,\n                     LEAD(TO_NUMBER(V.value), 1, TO_NUMBER(V.value) + 1) OVER(order by TO_NUMBER(V.value)) PROX\n                from DIE_GER_VENDEDOR V) B\n       where B.PROX - B.COD > 1\n         and B.PROX > 100000;\n    \n    end if;*/\n    update BEG_PESSOA P\n       set P.VENDEDOR = 'Y', P.COD_VENDA = :new.value\n     where P.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  end if;\n\n  if UPDATING then\n    if UPDATING('DT_FINAL') then\n      if :new.DT_FINAL <= :new.DT_INICIAL then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Data final deve ser maior que a data inicial!');\n      end if;\n      update BEG_PESSOA P\n         set P.VENDEDOR = 'N', P.COD_VENDA = null\n       where P.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    end if;\n    if :new.value <> :old.value and :new.ISACTIVE = 'Y' then\n      update BEG_PESSOA P\n         set P.VENDEDOR = 'Y', P.COD_VENDA = :new.value\n       where P.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    end if;\n  \n    if :new.dt_final is not null and :new.isactive = 'Y' then\n    \n      :new.isactive := 'N';\n    \n    end if;\n  \n    --Tiago da Silva 06/08/2010\n    if :new.ISACTIVE = 'Y' then\n      update BEG_PESSOA P\n         set P.VENDEDOR = 'Y', p.cod_venda = :new.value\n       where P.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    end if;\n  \n    if :new.ISACTIVE = 'N' then\n      update BEG_PESSOA P\n         set P.VENDEDOR = 'N', p.cod_venda = null\n       where P.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    end if;\n  \n    --Tiago da Silva 06/08/2010\n  end if;\n\n  IF NOT DELETING THEN\n  \n    :NEW.VALUE := TRIM(:NEW.VALUE);\n  \n    IF LENGTH(:NEW.VALUE) > 6 THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'O código do vendedor não pode ter mais de seis digitos!');\n    END IF;\n  END IF;\n\n  if DELETING then\n    update BEG_PESSOA P\n       set P.VENDEDOR = 'N', P.COD_VENDA = null\n     where P.BEG_PESSOA_ID = :old.BEG_PESSOA_ID;\n  end if;\nend DIE_TRG_BIUD_GER_VENDEDOR;\n"}`;
    
    }
}
