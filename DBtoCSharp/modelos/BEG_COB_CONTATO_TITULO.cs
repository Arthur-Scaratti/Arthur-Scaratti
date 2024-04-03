
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_CONTATO_TITULO
    {
        
        /// <summary>
        /// Id do tipo do titulo
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string APP_USER { get; set; }
        
        /// <summary>
        /// Id da nota fiscal relacionada -- AOK - 07/08/2007
        /// </summary>
        public int DIE_VW_FAT_NFSI_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id dos titulos referente o contato
        /// </summary>
        public int BEG_COB_CONTATO_TITULO_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
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
        /// Id do titulo
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do contato realizado pelo cobrador
        /// </summary>
        public int BEG_COB_CONTATO_ID { get; set; }
            [Required]
        /// <summary>
        /// Data de emissao do titulo
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// Data de vencimento do titulo
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// Valor em aberto
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [Required]
        /// <summary>
        /// numero de dias em atraso
        /// </summary>
        public int DIAS_ATRASADO { get; set; }
        
        /// <summary>
        /// Data prevista de pagamento informada
        /// </summary>
        public string DT_AVISO_PGTO { get; set; }
        
        /// <summary>
        /// Valor previsto para pagamento
        /// </summary>
        public int VL_PREVISTO_PGTO { get; set; }
        
        /// <summary>
        /// Valor em aberto atualizado com a data do aviso
        /// </summary>
        public int VL_ABERTO_ATUAL { get; set; }
        
        /// <summary>
        /// numero de aviso
        /// </summary>
        public int NRO_AVISO { get; set; }
        
        /// <summary>
        /// Indica para enviar aviso
        /// </summary>
        public string IND_ENVIAR { get; set; }
        
        /// <summary>
        /// Data da geracao do aviso
        /// </summary>
        public string DT_AVISO { get; set; }
        
        /// <summary>
        /// Data da impressao do aviso
        /// </summary>
        public string DT_AVISO_IMPRESSO { get; set; }
        
        /// <summary>
        /// Data que foi enviado o cliente com este titulo para o SPC
        /// </summary>
        public string DT_ENVIO_SPC { get; set; }
            [Required]
        /// <summary>
        /// Indicativo de protecao financeira
        /// </summary>
        public string IND_PROTECAO_FINANCEIRA { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_COB_CONTATO_TITULO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  cursor CTITULO is\n  \n    select T1.value\n      from BEG_CRC_TITULO T1\n     where T1.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID;\n  RTITULO CTITULO%rowtype;\n\n    VD_DT1 date := null;  -- Teste\n    VD_DT2 date := null;\nbegin\n  --\n    VD_DT1 := :new.DT_AVISO_PGTO;\n    VD_DT2 := :old.DT_AVISO_PGTO;\n  --\n  if (:new.DT_AVISO_PGTO is not null and :old.DT_AVISO_PGTO is null)\n     or (:new.DT_AVISO_PGTO is null and :old.DT_AVISO_PGTO is not null)\n     or (:new.DT_AVISO_PGTO is not null and :old.DT_AVISO_PGTO is not null and :new.DT_AVISO_PGTO > :old.DT_AVISO_PGTO) then\n     --    RAISE_APPLICATION_ERROR(-20001, 'ID: ' || :new.beg_crc_titulo_id || \n     --                           ' Datas - new : '||:new.DT_AVISO_PGTO || ' old: ' || :old.DT_AVISO_PGTO);\n    open CTITULO;\n    fetch CTITULO\n      into RTITULO;\n    close CTITULO;\n    if NVL(BEG_PCK_COB_COBRANCA.VN_CONTRATO, 0) <> RTITULO.value then\n      BEG_PCK_COB_COBRANCA.VN_CONTRATO          := RTITULO.value;\n      BEG_PCK_COB_COBRANCA.VN_BEG_CRC_TITULO_ID := :new.BEG_CRC_TITULO_ID;\n      BEG_PCK_COB_COBRANCA.VD_DT_AVISO_PGTO     := :new.DT_AVISO_PGTO;\n      BEG_PCK_COB_COBRANCA.VC_IND_DTA_AVISO     := 'Y';\n      -- Executa o processo que verifica se existe outros titulos a inserir aviso pgto.\n      DIE_PRC_CRC_AVISO_PGTO;\n    \n    end if;\n  end if;\n  --\nend DIE_TRG_BIU_COB_CONTATO_TITULO;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_COB_CONTATO_TITULO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  cursor CTITULO is\n  \n    select T1.value\n      from BEG_CRC_TITULO T1\n     where T1.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID;\n  RTITULO CTITULO%rowtype;\n\n    VD_DT1 date := null;  -- Teste\n    VD_DT2 date := null;\nbegin\n  --\n    VD_DT1 := :new.DT_AVISO_PGTO;\n    VD_DT2 := :old.DT_AVISO_PGTO;\n  --\n  if (:new.DT_AVISO_PGTO is not null and :old.DT_AVISO_PGTO is null)\n     or (:new.DT_AVISO_PGTO is null and :old.DT_AVISO_PGTO is not null)\n     or (:new.DT_AVISO_PGTO is not null and :old.DT_AVISO_PGTO is not null and :new.DT_AVISO_PGTO > :old.DT_AVISO_PGTO) then\n     --    RAISE_APPLICATION_ERROR(-20001, 'ID: ' || :new.beg_crc_titulo_id || \n     --                           ' Datas - new : '||:new.DT_AVISO_PGTO || ' old: ' || :old.DT_AVISO_PGTO);\n    open CTITULO;\n    fetch CTITULO\n      into RTITULO;\n    close CTITULO;\n    if NVL(BEG_PCK_COB_COBRANCA.VN_CONTRATO, 0) <> RTITULO.value then\n      BEG_PCK_COB_COBRANCA.VN_CONTRATO          := RTITULO.value;\n      BEG_PCK_COB_COBRANCA.VN_BEG_CRC_TITULO_ID := :new.BEG_CRC_TITULO_ID;\n      BEG_PCK_COB_COBRANCA.VD_DT_AVISO_PGTO     := :new.DT_AVISO_PGTO;\n      BEG_PCK_COB_COBRANCA.VC_IND_DTA_AVISO     := 'Y';\n      -- Executa o processo que verifica se existe outros titulos a inserir aviso pgto.\n      DIE_PRC_CRC_AVISO_PGTO;\n    \n    end if;\n  end if;\n  --\nend BEG_TRG_BIU_COB_CONTATO_TITULO;\n"}`;
    
    }
}
