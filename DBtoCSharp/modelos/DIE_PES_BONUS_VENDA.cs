
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PES_BONUS_VENDA
    {
            [StringLength(10)]
        /// <summary>
        /// NSU Sitef
        /// </summary>
        public string NSU { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_NOVA_COMPRA { get; set; }
        
        /// <summary>
        /// ID do Pedido que gerou o credito
        /// </summary>
        public int DIE_PEDIDO_ID { get; set; }
            [StringLength(300)]
        /// <summary>
        /// Para descricao da origem do bonus campanha, resgate pontos, etc
        /// </summary>
        public string ORIGEM_BONUS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PES_BONUS_VENDA_ID { get; set; }
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
        public string CPFCNPJ { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_LIMITE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INI_BONUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FIM_BONUS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COMPRA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BONUS { get; set; }
            [Required]
        /// <summary>
        /// Até quantos dias apos a compra pode utilizar o bonus
        /// </summary>
        public int QTDE_DIAS { get; set; }
        
        /// <summary>
        /// Id da pre-nfs que utilizou o bonus, para nao permitir utilizar em duplicidade
        /// </summary>
        public int DIE_FAT_PRE_NFS_ID { get; set; }
            [StringLength(200)]
        /// <summary>
        /// Mensagem a ser impressa no cupom
        /// </summary>
        public string MENSAGEM { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BI_PES_BONUS_VENDA { get; set; } = `{"triggering_event":"INSERT","trigger_body":"BEGIN\n\n  IF :NEW.NSU IS NOT NULL THEN\n  \n    IF SUBSTR(:NEW.NSU, 1, 2) <> TO_CHAR(:NEW.DT_INI_BONUS, 'DD') AND\n       :NEW.ORIGEM_BONUS NOT LIKE 'ROLETA%' AND :NEW.ORIGEM_BONUS NOT LIKE 'COLCHAO%'  THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'NSU nao pertence ao dia.' ||\n                              SUBSTR(:NEW.NSU, 1, 2) || '-' ||\n                              TO_CHAR(:NEW.DT_INI_BONUS, 'DD'));\n    \n    END IF;\n  \n  END IF;\n\n  IF :NEW.NSU IS NULL AND :NEW.ORIGEM_BONUS NOT LIKE 'CASHBACK%' THEN\n  \n    :NEW.NSU := :NEW.DIE_PES_BONUS_VENDA_ID;\n  \n  END IF;\n\n  IF :NEW.NSU IS NULL AND :NEW.ORIGEM_BONUS LIKE 'CASHBACK%' THEN\n  \n    RAISE_APPLICATION_ERROR(-20001, 'Faltou informar o NSU');\n  \n  END IF;\n\n  IF :NEW.ORIGEM_BONUS LIKE 'ROLETA%' THEN\n  \n    IF TRUNC(SYSDATE) > '28/02/2022' THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Prazo para este tipo de bonus expirado');\n    \n    END IF;\n  \n    IF :NEW.VLR_BONUS NOT IN (10, 20, 30, 40, 50, 70, 80, 100) THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Valor fora dos parametros para este tipo de bonus');\n    \n    END IF;\n  \n    :NEW.VLR_COMPRA      := 1000;\n    :NEW.VLR_NOVA_COMPRA := 1000;\n    :NEW.DT_LIMITE       := TRUNC(SYSDATE);\n    :NEW.DT_FIM_BONUS    := TRUNC(SYSDATE);\n    :NEW.DT_INI_BONUS    := TRUNC(SYSDATE);\n  \n  END IF;\n  \n  IF :NEW.ORIGEM_BONUS LIKE 'COLCHAO%' THEN\n  \n    IF TRUNC(SYSDATE) > '30/06/2022' THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Prazo para este tipo de bonus expirado');\n    \n    END IF;\n  \n    IF :NEW.VLR_BONUS NOT IN (50, 100, 200) THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Valor fora dos parametros para este tipo de bonus');\n    \n    END IF;\n  \n    :NEW.VLR_COMPRA      := 0;\n    :NEW.VLR_NOVA_COMPRA := :NEW.VLR_BONUS;\n    :NEW.DT_LIMITE       := TRUNC(SYSDATE);\n    :NEW.DT_FIM_BONUS    := TRUNC(SYSDATE);\n    :NEW.DT_INI_BONUS    := TRUNC(SYSDATE);\n  \n  END IF;\n\nEND DIE_TRG_BI_PES_BONUS_VENDA;\n"}`;
    
    }
}
