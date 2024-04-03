
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_PESSOA_RENEG
    {
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_RENEGOCIACAO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_PESSOA_RENEG_ID { get; set; }
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

        [NotMapped]
        public string Trigger_TRG_AIUD_PESSOA_RENEG_NEW { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  V_TITULO_RENEGOCIADO number(10);\n  --\n  cursor BUSCA_TITULOS_ABERTOS is\n    select T.BEG_CRC_TITULO_ID,\n           DECODE(SIGN(sysdate - T.DT_VCTO),\n                  1,\n                  (((TRUNC(sysdate - T.DT_VCTO) * 0.125) / 100) *\n                  NVL(T.VLR_ABERTO, T.VLR_TITULO) +\n                  NVL(T.VLR_ABERTO, T.VLR_TITULO)) +\n                  ((NVL(T.VLR_ABERTO, T.VLR_TITULO) * 2) / 100),\n                  NVL(T.VLR_ABERTO, T.VLR_TITULO)) VLR_ABERTO,\n           DECODE(SIGN(sysdate - T.DT_VCTO),\n                  1,\n                  ((TRUNC(sysdate - T.DT_VCTO) * 0.125) / 100) *\n                  NVL(T.VLR_ABERTO, T.VLR_TITULO),\n                  0) JUROS,\n           DECODE(SIGN(sysdate - T.DT_VCTO),\n                  1,\n                  ((NVL(T.VLR_ABERTO, T.VLR_TITULO) * 2) / 100),\n                  0) MULTA,\n           NVL(T.VLR_ABERTO, T.VLR_TITULO) VLR_TITULO,\n           T.PARCELA,\n           T.DT_VCTO,\n           TRUNC(sysdate - T.DT_VCTO) DIAS_VCTO,\n           \n           CASE WHEN T.BEG_TIPO_TITULO_ID IN (2500015, 2500012) THEN\n              CASE WHEN T.VLR_ABERTO < T.VLR_TITULO THEN\n                 ROUND(T.VLR_ORIGINAL * (T.VLR_ABERTO / T.VLR_TITULO), 2)\n              ELSE\n                 T.VLR_ORIGINAL\n              END\n           ELSE\n              T.VLR_ABERTO\n           END VLR_ORIGINAL,\n           \n           ROUND(T.VLR_TX_FINANCEIRA * (T.VLR_ABERTO / T.VLR_TITULO), 2) VLR_TX_FINANCEIRA,\n           \n           ROUND(T.VLR_SEGUROS * (T.VLR_ABERTO / T.VLR_TITULO), 2) VLR_SEGUROS,\n           \n           ROUND(T.VLR_SEGURO * (T.VLR_ABERTO / T.VLR_TITULO), 2) VLR_SEGURO,\n           \n           ROUND(T.VLR_GARANTIA * (T.VLR_ABERTO / T.VLR_TITULO), 2) VLR_GARANTIA\n    \n      from BEG_CRC_TITULO T\n     where T.IND_ABERTO = 'Y' --t.Titulo_Aberto = 1\n       and T.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n       and t.beg_tipo_titulo_id not in 2500008\n       and nvl(t.num_nf_devol, 0) = 0\n     order by TRUNC(sysdate - T.DT_VCTO) desc;\n  --\n  VREG1 BUSCA_TITULOS_ABERTOS%rowtype;\n  --\n  cursor CONTA_TITULOS is\n    select NVL(count(*), 0) + 1 value\n      from BEG_CRC_TITULO_RENEGOCIADO T\n     where T.BEG_CRC_RENEGOCIACAO_ID = :new.BEG_CRC_RENEGOCIACAO_ID;\n  --\n  VREG2 CONTA_TITULOS%rowtype;\n  --\nbegin\n  if INSERTING then\n    open BUSCA_TITULOS_ABERTOS;\n    loop\n      fetch BUSCA_TITULOS_ABERTOS\n        into VREG1;\n      exit when BUSCA_TITULOS_ABERTOS%notfound;\n      AD_SEQUENCE_NEXT('BEG_CRC_TITULO_RENEGOCIADO',\n                       0,\n                       V_TITULO_RENEGOCIADO);\n      open CONTA_TITULOS;\n      fetch CONTA_TITULOS\n        into VREG2;\n      close CONTA_TITULOS;\n      insert into BEG_CRC_TITULO_RENEGOCIADO\n        (BEG_CRC_TITULO_RENEGOCIADO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         value,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         VLR_ABERTO,\n         BEG_CRC_TITULO_ID,\n         BEG_CRC_RENEGOCIACAO_ID,\n         RENEGOCIAR,\n         DT_VCTO,\n         PARCELA,\n         DIAS_VCTO,\n         JUROS,\n         MULTA,\n         VLR_ORIGINAL,\n         VLR_TX_FINANCEIRA,\n         VLR_SEGUROS,\n         VLR_SEGURO,\n         VLR_GARANTIA,\n         VLR_TIT)\n      values\n        (V_TITULO_RENEGOCIADO,\n         :new.AD_CLIENT_ID,\n         :new.AD_ORG_ID,\n         'Y',\n         VREG2.value,\n         :new.CREATED,\n         :new.CREATEDBY,\n         :new.UPDATED,\n         :new.UPDATEDBY,\n         VREG1.VLR_TITULO, -- VLR_ABERTO\n         VREG1.BEG_CRC_TITULO_ID,\n         :new.BEG_CRC_RENEGOCIACAO_ID,\n         'Y',\n         VREG1.DT_VCTO,\n         VREG1.PARCELA,\n         VREG1.DIAS_VCTO,\n         VREG1.JUROS,\n         VREG1.MULTA,\n         VREG1.VLR_ORIGINAL,\n         VREG1.VLR_TX_FINANCEIRA,\n         VREG1.VLR_SEGUROS,\n         VREG1.VLR_SEGURO,\n         VREG1.VLR_GARANTIA,\n         VREG1.VLR_TITULO);\n    end loop;\n    close BUSCA_TITULOS_ABERTOS;\n  end if;\n\nexception\n  when others then\n    RAISE_APPLICATION_ERROR(-20501,\n                            'ERRO NO TITULO ' || VREG1.BEG_CRC_TITULO_ID ||\n                            ' - ' || :new.BEG_PESSOA_ID || ' - ' || sqlerrm);\nend TRG_AIUD_PESSOA_RENEG;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_AIUD_PESSOA_RENEG { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  V_TITULO_RENEGOCIADO number(10);\n  --\n  cursor BUSCA_TITULOS_ABERTOS is\n    select T.BEG_CRC_TITULO_ID,\n           DECODE(SIGN(sysdate - T.DT_VCTO),\n                  1,\n                  (((TRUNC(sysdate - T.DT_VCTO) * 0.125) / 100) *\n                  NVL(T.VLR_ABERTO, T.VLR_TITULO) +\n                  NVL(T.VLR_ABERTO, T.VLR_TITULO)) +\n                  ((NVL(T.VLR_ABERTO, T.VLR_TITULO) * 2) / 100),\n                  NVL(T.VLR_ABERTO, T.VLR_TITULO)) VLR_ABERTO,\n           DECODE(SIGN(sysdate - T.DT_VCTO),\n                  1,\n                  ((TRUNC(sysdate - T.DT_VCTO) * 0.125) / 100) *\n                  NVL(T.VLR_ABERTO, T.VLR_TITULO),\n                  0) JUROS,\n           DECODE(SIGN(sysdate - T.DT_VCTO),\n                  1,\n                  ((NVL(T.VLR_ABERTO, T.VLR_TITULO) * 2) / 100),\n                  0) MULTA,\n           NVL(T.VLR_ABERTO, T.VLR_TITULO) VLR_TITULO,\n           T.PARCELA,\n           T.DT_VCTO,\n           TRUNC(sysdate - T.DT_VCTO) DIAS_VCTO,\n           CASE WHEN T.VLR_ABERTO< T.VLR_TITULO OR T.AD_ORG_ID <> :NEW.AD_ORG_ID  OR T.BEG_TIPO_TITULO_ID IN (2500015,2500012) THEN\n             0\n           ELSE T.VLR_TITULO END VLR_ORIGINAL,\n           CASE WHEN T.VLR_ABERTO< T.VLR_TITULO OR T.AD_ORG_ID <> :NEW.AD_ORG_ID OR T.BEG_TIPO_TITULO_ID IN (2500015,2500012) THEN\n             0\n           ELSE  T.VLR_TX_FINANCEIRA END VLR_TX_FINANCEIRA,\n           CASE WHEN T.VLR_ABERTO< T.VLR_TITULO OR T.AD_ORG_ID <> :NEW.AD_ORG_ID OR T.BEG_TIPO_TITULO_ID IN (2500015,2500012) THEN\n             0\n           ELSE T.VLR_SEGUROS END VLR_SEGUROS,\n           CASE WHEN T.VLR_ABERTO< T.VLR_TITULO OR T.AD_ORG_ID <> :NEW.AD_ORG_ID OR T.BEG_TIPO_TITULO_ID IN (2500015,2500012) THEN\n             0\n           ELSE T.VLR_SEGURO END VLR_SEGURO,\n           CASE WHEN T.VLR_ABERTO< T.VLR_TITULO OR T.AD_ORG_ID <> :NEW.AD_ORG_ID OR T.BEG_TIPO_TITULO_ID IN (2500015,2500012) THEN\n             0\n           ELSE  T.VLR_GARANTIA END VLR_GARANTIA\n      from BEG_CRC_TITULO T\n     where T.IND_ABERTO = 'Y' --t.Titulo_Aberto = 1\n       and T.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n       and t.beg_tipo_titulo_id not in 2500008\n       and nvl(t.num_nf_devol,0) = 0 \n     order by TRUNC(sysdate - T.DT_VCTO) desc;\n  --\n  VREG1 BUSCA_TITULOS_ABERTOS%rowtype;\n  --\n  cursor CONTA_TITULOS is\n    select NVL(count(*), 0) + 1 value\n      from BEG_CRC_TITULO_RENEGOCIADO T\n     where T.BEG_CRC_RENEGOCIACAO_ID = :new.BEG_CRC_RENEGOCIACAO_ID;\n  --\n  VREG2 CONTA_TITULOS%rowtype;\n  --\nbegin\n  if INSERTING then\n    open BUSCA_TITULOS_ABERTOS;\n    loop\n      fetch BUSCA_TITULOS_ABERTOS\n        into VREG1;\n      exit when BUSCA_TITULOS_ABERTOS%notfound;\n      AD_SEQUENCE_NEXT('BEG_CRC_TITULO_RENEGOCIADO',\n                       0,\n                       V_TITULO_RENEGOCIADO);\n      open CONTA_TITULOS;\n      fetch CONTA_TITULOS\n        into VREG2;\n      close CONTA_TITULOS;\n      insert into BEG_CRC_TITULO_RENEGOCIADO\n        (BEG_CRC_TITULO_RENEGOCIADO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         value,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         VLR_ABERTO,\n         BEG_CRC_TITULO_ID,\n         BEG_CRC_RENEGOCIACAO_ID,\n         RENEGOCIAR,\n         DT_VCTO,\n         PARCELA,\n         DIAS_VCTO,\n         JUROS,\n         MULTA,\n         VLR_ORIGINAL,\n         VLR_TX_FINANCEIRA,\n         VLR_SEGUROS,\n         VLR_SEGURO,\n         VLR_GARANTIA ,\n         VLR_TIT\n         )\n      values\n        (V_TITULO_RENEGOCIADO,\n         :new.AD_CLIENT_ID,\n         :new.AD_ORG_ID,\n         'Y',\n         VREG2.value,\n         :new.CREATED,\n         :new.CREATEDBY,\n         :new.UPDATED,\n         :new.UPDATEDBY,\n         VREG1.VLR_TITULO, -- VLR_ABERTO\n         VREG1.BEG_CRC_TITULO_ID,\n         :new.BEG_CRC_RENEGOCIACAO_ID,\n         'Y',\n         VREG1.DT_VCTO,\n         VREG1.PARCELA,\n         VREG1.DIAS_VCTO,\n         VREG1.JUROS,\n         VREG1.MULTA,\n         VREG1.VLR_ORIGINAL,\n         VREG1.VLR_TX_FINANCEIRA,\n         VREG1.VLR_SEGUROS,\n         VREG1.VLR_SEGURO,\n         VREG1.VLR_GARANTIA,\n         VREG1.VLR_TITULO);\n    end loop;\n    close BUSCA_TITULOS_ABERTOS;\n  end if;\n\nexception\n  when others then\n    RAISE_APPLICATION_ERROR(-20501,\n                            'ERRO NO TITULO ' || VREG1.BEG_CRC_TITULO_ID ||\n                            ' - ' || :new.BEG_PESSOA_ID || ' - ' || sqlerrm);\nend TRG_AIUD_PESSOA_RENEG;\n"}`;
    
    }
}
