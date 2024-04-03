
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FPG_PESSOA
    {
            [StringLength(4)]
        /// <summary>
        /// Categoria da carteira de motorista.
        /// </summary>
        public string CATEGORIA_CARTA { get; set; }
        
        /// <summary>
        /// Data de emissão da carteira de motorista.
        /// </summary>
        public string DT_EMISSAO_CARTA { get; set; }
        
        /// <summary>
        /// Data da primeira carteira de motorista.
        /// </summary>
        public string DT_PRI_HABILITACAO { get; set; }
        
        /// <summary>
        /// Data de vencimento da carteira de motorista.
        /// </summary>
        public string DT_VECTO_CARTA { get; set; }
            [StringLength(15)]
        /// <summary>
        /// Número da carteira de habilitação.
        /// </summary>
        public string NRO_HABILITACAO { get; set; }
        
        /// <summary>
        /// Número de dependentes para salário família.
        /// </summary>
        public int NRO_DEPENDENTES_SF { get; set; }
        
        /// <summary>
        /// Número de dependentes para imposto de renda.
        /// </summary>
        public int NRO_DEPENDENTES_IR { get; set; }
        
        /// <summary>
        /// Número de férias já gozadas na implantação do sistema.
        /// </summary>
        public int NRO_FERIAS_IMPLANTACAO { get; set; }
        
        /// <summary>
        /// Número de férias calculadas pelo sistema.
        /// </summary>
        public int NRO_FERIAS_CALCULADAS { get; set; }
            [Required]
        /// <summary>
        /// Situação atual do empregado.
        /// </summary>
        public int BEG_FPG_SITUACAO_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Carteira Profissional
        /// </summary>
        public string CTPS { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Registro Geral
        /// </summary>
        public string RG { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Órgão Emissor RG
        /// </summary>
        public string ORGAO_EMISSOR_RG { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Sexo -> F- Feminino, M- Masculino
        /// </summary>
        public string SEXO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Estado Civil -> A- Amigado, C- Casado, D- Divorciado, M- Amasiado, O- Outros, P- Separado Judicialmente, S- Solteiro, V- Viuvo
        /// </summary>
        public string ESTCIVIL { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Nacionalidade -> 10- Brasileiro, 20- Naturalizado Brasileiro, 21- Argentino, 22- Boliviano, 23- Chileno 
24- Paraguaio, 25- Uruguaio, 30- Alemão, 31- Belga, 32- Britânico, 34- Canadense,	
35- Espanhol, 36- Norte-americano (EUA), 37- Francês, 38- Suíço, 39- Italiano, 
41- Japonês, 42- Chinês, 43- Coreano, 45- Português, 48- Outros latino-americanos, 49- Outros asiáticos, 50- Outros

        /// </summary>
        public string NACIONALIDADE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Escolaridade -> 1- Analfabeto (Não sabe ler/escrever), 2- Ensino Fundamental Incompleto, 3- Ensino Fundamental Completo, 4- Ensino Médio Incompleto, 5- Ensino Médio Completo, 6- Superior Incompleto, 7- Superior Completo
        /// </summary>
        public string ESCOLARIDADE { get; set; }
        
        /// <summary>
        /// Data de emissão do RG
        /// </summary>
        public string DT_EMISSAO_RG { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Serie Carteira Profisional
        /// </summary>
        public string SERIE_CTPS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Código do vendedor
        /// </summary>
        public string COD_VENDA { get; set; }
        
        /// <summary>
        /// Data nascimento funcionario
        /// </summary>
        public string DT_NASCIMENTO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Codigo funcionario novo sistema Athenas Eza
        /// </summary>
        public string CODIGO_NOVO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FPG_PESSOA_ID { get; set; }
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
    [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// Código do funcionário.
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// ID da pessoa.
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// Data de admissão.
        /// </summary>
        public string DT_ADMISSAO { get; set; }
        
        /// <summary>
        /// Data de demissão.
        /// </summary>
        public string DT_DEMISSAO { get; set; }
        
        /// <summary>
        /// Centro de Custo atual.
        /// </summary>
        public int BEG_FPG_CENTRO_CUSTO_ID { get; set; }
            [Required]
        /// <summary>
        /// Função atual.
        /// </summary>
        public int BEG_FPG_FUNCAO_ID { get; set; }
            [Required]
        /// <summary>
        /// CBO.
        /// </summary>
        public int BEG_CBO_ID { get; set; }
        
        /// <summary>
        /// Chapa.
        /// </summary>
        public int CHAPEIRA { get; set; }
            [StringLength(15)]
        /// <summary>
        /// Número do PIS.
        /// </summary>
        public string PIS { get; set; }
        
        /// <summary>
        /// Data do PIS.
        /// </summary>
        public string DT_PIS { get; set; }
            [StringLength(17)]
        /// <summary>
        /// Número do Título de eleitor.
        /// </summary>
        public string TITELEITOR { get; set; }
        
        /// <summary>
        /// Data de emissão do Título de eleitor.
        /// </summary>
        public string DT_TITELEITOR { get; set; }
        
        /// <summary>
        /// Zona do Título de eleitor.
        /// </summary>
        public int ZONA_TITELEITOR { get; set; }
        
        /// <summary>
        /// Seção do Título de eleitor.
        /// </summary>
        public int SECAO_TITELEITOR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Número do certificado de reservista.
        /// </summary>
        public string CERTIFICADO_RESERVISTA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Categoria do certificado de reservista.
        /// </summary>
        public string CERTIFICADO_RESERVISTA_CATE { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AIU_BEG_FPG_PESSOA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  VC_FUNCIONARIO char(1) := 'N';\nbegin\n\n  if :new.BEG_FPG_SITUACAO_ID <> 1000006 -- Desligado \n   then\n    VC_FUNCIONARIO := 'Y';\n  end if;\n  -- AOK - 12/01/2009 - Adicionado admissao e empresa\n  update BEG_PESSOA P\n     set FUNCIONARIO  = VC_FUNCIONARIO\n        , P.DTADMISSAO = case when VC_FUNCIONARIO = 'Y' then :new.DT_ADMISSAO else P.DTADMISSAO end,\n         P.EMPRESA    = case when VC_FUNCIONARIO = 'Y' then 'DIEMENTZ' else P.EMPRESA end\n   where P.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n\n  -- AOK - 22/10/2008\n  update BEG_APEX_USER U\n     set U.ISACTIVE  = case when VC_FUNCIONARIO = 'Y' then 'Y' else 'N' end,\n         U.UPDATED   = sysdate,\n         U.UPDATEDBY = 0\n   where U.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  --\n\n  /*  if :new.BEG_FPG_SITUACAO_ID <> 1000006 then -- Desligado\n    \n      update BEG_PESSOA\n         set FUNCIONARIO = 'Y'\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    \n    else\n    \n      update BEG_PESSOA\n         set FUNCIONARIO = 'N'\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    \n    end if;\n  */\nend DIE_TRG_AIU_BEG_FPG_PESSOA;\n"}`;
    
    }
}
