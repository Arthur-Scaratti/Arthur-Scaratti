
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_TITULO_COBRADOR
    {
        
        /// <summary>
        /// Indica se o titulo (Y/N) - se aberto Y, se naum N
        /// </summary>
        public string IND_ABERTO { get; set; }
        
        /// <summary>
        /// indica se funcionario (Y/N)
        /// </summary>
        public string FUNCIONARIO { get; set; }
        
        /// <summary>
        /// Tipo da pessoa (parceiro comercial)
        /// </summary>
        public string TP_PESSOA { get; set; }
        
        /// <summary>
        /// Indica que se o relatorio ja foi impresso
        /// </summary>
        public string IND_RELATORIO { get; set; }
        
        /// <summary>
        /// Id do tipo de movimento da baixa
        /// </summary>
        public int BEG_CRC_TPMOV_ID { get; set; }
        
        /// <summary>
        /// id do tipo do titulo
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do cobrador
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
        
        /// <summary>
        /// Id da cidade
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do titulo referente ao Cobrador
        /// </summary>
        public int BEG_TITULO_COBRADOR_ID { get; set; }
            [Required]
        /// <summary>
        /// Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Filial do titulo
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo (Y / N)
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// Data de criacao do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da ultima alteracao do registro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que executou a ultima alteracao no registro
        /// </summary>
        public int UPDATEDBY { get; set; }
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
        
        /// <summary>
        /// Data de envio para cobranca
        /// </summary>
        public string DT_ENVIO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Descricao do motivo da baixa
        /// </summary>
        public string DESC_MOTIVO { get; set; }
        
        /// <summary>
        /// Id do motivo anterior - beg_crc_tpmov_id
        /// </summary>
        public int ID_MOTIVO_ANT { get; set; }
        
        /// <summary>
        /// Id do lote de cobranca assessoria
        /// </summary>
        public int BEG_COB_LOTE_ASSESSORIA_ID { get; set; }
        
        /// <summary>
        /// Data da cobranca do titulo
        /// </summary>
        public string DT_COBRANCA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indicativo se e para baixar cobranca
        /// </summary>
        public string IND_BAIXA_COBRANCA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indicativo de enviado para cobranca
        /// </summary>
        public string IND_ENVIADO { get; set; }
        
        /// <summary>
        /// Data do pagamento do titulo
        /// </summary>
        public string DT_PAGTO { get; set; }
        
        /// <summary>
        /// Valor pago do titulo
        /// </summary>
        public int VLR_PAGTO { get; set; }
        
        /// <summary>
        /// Filial responsavel pela entrega do titulo ao cobrador
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// Indica que é para baixar todo o contrato do cobrador ref. este titulo 
        /// </summary>
        public string IND_BAIXA_CONTRATO { get; set; }
            [Required]
        /// <summary>
        /// Id do cliente
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// id fo titulo
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// Indicador de titulo renegociado
        /// </summary>
        public string IND_RENEGOCIADO { get; set; }
        
        /// <summary>
        /// Id do lote de cobranca
        /// </summary>
        public int BEG_COB_LOTE_COBR_ID { get; set; }
        
        /// <summary>
        /// Numero do contrato (titulo)
        /// </summary>
        public int CONTRATO { get; set; }
        
        /// <summary>
        /// Data da baixa cobranca
        /// </summary>
        public string DT_BAIXA_COBRANCA { get; set; }
        
        /// <summary>
        /// Data de pagamento anterior
        /// </summary>
        public string DT_PAGTO_ANT { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BD_TITULO_COBRADOR { get; set; } = `{"triggering_event":"DELETE","trigger_body":"begin\n  --\n  if BEG_PCK_COB_COBRANCA.VC_EXECUTA = 'Y' -- aok - 08/04/2009\n   then\n    update BEG_CRC_TITULO T\n       set T.BEG_COBRADOR_ID = null\n     where T.BEG_CRC_TITULO_ID = :old.BEG_CRC_TITULO_ID\n       and T.IND_ABERTO = 'Y'\n       and T.BEG_COBRADOR_ID = :old.BEG_COBRADOR_ID;\n    -- AOK - 08/04/2009\n    if sql%rowcount = 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Não pode ser eliminado - provavelmente o titulo já esta quitado!');\n    end if;\n  end if;\n  --\nend DIE_TRG_BD_TITULO_COBRADOR;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_AU_TITULO_COB_BAIXA { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"begin\n\n  if BEG_PCK_COB_COBRANCA.VC_IND_BAIXA_CONTRATO = 'Y' then\n  \n    BEG_PCK_COB_COBRANCA.VC_IND_BAIXA_CONTRATO := 'N';\n  \n    update BEG_TITULO_COBRADOR A\n       set A.DT_BAIXA_COBRANCA  = BEG_PCK_COB_COBRANCA.VD_DT_BAIXA_COBRANCA,\n           A.DESC_MOTIVO        = BEG_PCK_COB_COBRANCA.VC_DESC_MOTIVO,\n           A.IND_BAIXA_CONTRATO = 'Y'\n     where A.BEG_TITULO_COBRADOR_ID <>\n           BEG_PCK_COB_COBRANCA.VN_BEG_TITULO_COBRADOR_ID\n       and A.CONTRATO = BEG_PCK_COB_COBRANCA.VN_CONTRATO\n       and A.BEG_TIPO_TITULO_ID =\n           BEG_PCK_COB_COBRANCA.VN_BEG_TIPO_TITULO_ID\n       and A.AD_CLIENT_ID = BEG_PCK_COB_COBRANCA.VN_AD_CLIENT_ID\n       and A.AD_ORG_ID = BEG_PCK_COB_COBRANCA.VN_AD_ORG_ID\n       and A.BEG_PESSOA_ID = BEG_PCK_COB_COBRANCA.VN_BEG_PESSOA_ID\n       and A.BEG_COBRADOR_ID = BEG_PCK_COB_COBRANCA.VN_BEG_COBRADOR_ID;\n  \n  end if;\nend BEG_TRG_AU_TITULO_COB_BAIXA;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BU_TIT_COB_BAIXA { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"begin\n\n  if NVL(:new.IND_BAIXA_CONTRATO, 'N') = 'Y'\n     and NVL(:old.IND_BAIXA_CONTRATO, 'N') = 'N'\n     and NVL(BEG_PCK_COB_COBRANCA.VC_IND_BAIXA_CONTRATO, 'N') = 'N' then\n  \n    BEG_PCK_COB_COBRANCA.VC_IND_BAIXA_CONTRATO     := 'Y';\n    BEG_PCK_COB_COBRANCA.VD_DT_BAIXA_COBRANCA      := :new.DT_BAIXA_COBRANCA;\n    BEG_PCK_COB_COBRANCA.VC_DESC_MOTIVO            := :new.DESC_MOTIVO;\n    BEG_PCK_COB_COBRANCA.VN_BEG_TITULO_COBRADOR_ID := :new.BEG_TITULO_COBRADOR_ID;\n    BEG_PCK_COB_COBRANCA.VN_CONTRATO               := :new.CONTRATO;\n    BEG_PCK_COB_COBRANCA.VN_BEG_COBRADOR_ID        := :new.BEG_COBRADOR_ID;\n    BEG_PCK_COB_COBRANCA.VN_BEG_TIPO_TITULO_ID     := :new.BEG_TIPO_TITULO_ID;\n    BEG_PCK_COB_COBRANCA.VN_AD_CLIENT_ID           := :new.AD_CLIENT_ID;\n    BEG_PCK_COB_COBRANCA.VN_AD_ORG_ID              := :new.AD_ORG_ID;\n    BEG_PCK_COB_COBRANCA.VN_BEG_PESSOA_ID          := :new.BEG_PESSOA_ID;\n  \n  end if;\nend BEG_TRG_BU_TITULO_COB_BAIXA;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BU_OF_TITULO_COBRADOR { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n\n  if :new.DT_BAIXA_COBRANCA is null\n     and :new.DESC_MOTIVO is null then\n    null;\n  else\n    if :new.DT_BAIXA_COBRANCA is null\n       or :new.DESC_MOTIVO is null then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Faltou informar Data ou Motivo da baixa! ');\n    end if;\n  \n    if :new.DT_BAIXA_COBRANCA is not null then\n      if :new.DESC_MOTIVO is null then\n        RAISE_APPLICATION_ERROR(-20002,\n                                'Faltou informar o motivo da baixa! ');\n      end if;\n      --\n      :new.IND_BAIXA_COBRANCA := 'Y';\n    \n      -- Retirar o codigo do cobrador do titulo (beg_crc_titulo)\n      -- AOK -- 28/10/2008 - Apenas anular o cobrador se este for diferente\n      if :new.IND_ABERTO = 'Y' then\n        update BEG_CRC_TITULO T\n           set T.BEG_COBRADOR_ID = case when T.BEG_COBRADOR_ID = :new.BEG_COBRADOR_ID then null else T.BEG_COBRADOR_ID end\n        -- set T.BEG_COBRADOR_ID = case when null\n         where T.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID;\n         -- aok - 29/10/2008\n         update beg_cob_titulo_tmp tmp\n         set tmp.beg_cobrador_id = case when tmp.BEG_COBRADOR_ID = :new.BEG_COBRADOR_ID then null else tmp.BEG_COBRADOR_ID end\n         where tmp.beg_crc_titulo_id = :new.beg_crc_titulo_id;\n         --\n      end if;\n      --\n    end if;\n  end if;\n  --\nend BEG_TRG_BU_OF_TITULO_COBRADOR;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BU_TITULO_COBRADOR { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n-- AOK - 03/10/2008\n  cursor CHIST is\n    select H.BEG_CRC_TPMOV_ID,\n           H.DT_PGTO\n    -- , H.VLR_MOVTO\n      from BEG_CRC_HISTORICO H\n     where H.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID\n       and H.value > 1\n     order by H.BEG_CRC_HISTORICO_ID desc;\n  RHIST CHIST%rowtype;\n\n  cursor C_TPMOV is\n    select *\n      from BEG_CRC_TPMOV X\n     where X.BEG_CRC_TPMOV_ID = RHIST.BEG_CRC_TPMOV_ID; --:new.BEG_CRC_TPMOV_ID;\n  R_TPMOV C_TPMOV%rowtype;\n\nbegin\n  --\n  if :new.VLR_ABERTO = 0 then\n    :new.IND_ABERTO := 'N';\n    if NVL(:new.BEG_CRC_TPMOV_ID, 0) = 0 then -- AOK - 03/10/2008\n      open CHIST;\n      fetch CHIST\n        into RHIST;\n      if CHIST%notfound then\n        RHIST.DT_PGTO          := sysdate;\n        RHIST.BEG_CRC_TPMOV_ID := :new.BEG_CRC_TPMOV_ID;\n      end if;\n      close CHIST;\n    else\n      RHIST.BEG_CRC_TPMOV_ID := :new.BEG_CRC_TPMOV_ID;\n      RHIST.DT_PGTO          := sysdate;\n    end if;\n  \n    :new.DT_BAIXA_COBRANCA  := RHIST.DT_PGTO;\n    :new.IND_BAIXA_COBRANCA := 'Y';\n    R_TPMOV.DESCRICAO       := null;\n    if NVL(RHIST.BEG_CRC_TPMOV_ID, 0) > 0 then\n      open C_TPMOV;\n      fetch C_TPMOV\n        into R_TPMOV;\n      close C_TPMOV;\n    end if;\n    if :NEW.IND_RENEGOCIADO = 'N' THEN\n    :new.DESC_MOTIVO := NVL(UPPER(R_TPMOV.DESCRICAO), 'BAIXA POR QUITACAO');\n    ELSE \n      :NEW.DESC_MOTIVO := 'BAIXA POR RENEGOCIACAO';\n    END IF;  \n  else\n    :new.IND_ABERTO := 'Y';\n  end if;\n  --\nend BEG_TRG_BU_TITULO_COBRADOR;\n"}`;
    
    }
}
