
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PESSOA_FILIAL
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_FILIAL_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AD_PESSOA_FILIAL { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  --\n  pragma autonomous_transaction;\n  VN_BEG_PESSOA_FILIAL_ID BEG_PESSOA_FILIAL.BEG_PESSOA_FILIAL_ID%type;\n  --\nbegin\n  --\n  VN_BEG_PESSOA_FILIAL_ID := BEG_FNC_AD_SEQUENCE('BEG_PESSOA_FILIAL');\n  --\n  insert into BEG_PESSOA_FILIAL\n    (BEG_PESSOA_FILIAL_ID,\n     AD_CLIENT_ID,\n     AD_ORG_ID,\n     ISACTIVE,\n     value,\n     CREATED,\n     CREATEDBY,\n     UPDATED,\n     UPDATEDBY,\n     BEG_FILIAL_ID,\n     BEG_PESSOA_ID)\n  values\n    (VN_BEG_PESSOA_FILIAL_ID,\n     :old.AD_CLIENT_ID,\n     :old.AD_ORG_ID,\n     :old.ISACTIVE,\n     :old.value,\n     :old.CREATED,\n     :old.CREATEDBY,\n     :old.UPDATED,\n     :old.UPDATEDBY,\n     :old.BEG_FILIAL_ID,\n     :old.BEG_PESSOA_ID);\n  --\n  insert into DIE_LOG_TABELA\n    (DIE_LOG_TABELA_ID,\n     AD_CLIENT_ID,\n     AD_ORG_ID,\n     ISACTIVE,\n     value,\n     CREATED,\n     CREATEDBY,\n     UPDATED,\n     UPDATEDBY,\n     name,\n     USUARIO,\n     BEG_PESSOA_ID)\n  values\n    (BEG_FNC_AD_SEQUENCE('DIE_LOG_TABELA'),\n     NVL(:old.AD_CLIENT_ID, 1000000), -- AD_CLIENTE_ID\n     NVL(:old.BEG_FILIAL_ID, 0), -- AD_ORG_ID\n     'Y',\n     'BEG_PESSOA_FILIAL', --VALUE,\n     sysdate, --CREATED,\n     0, --CREATEDBY,\n     sysdate, --UPDATED,\n     0, --UPDATEDBY,\n     'Eliminado codigo: ' || :old.BEG_PESSOA_FILIAL_ID ||\n     ' Recriado Novo: ' || VN_BEG_PESSOA_FILIAL_ID || ' (' || :old.value || ')',\n     user,\n     :old.BEG_PESSOA_ID);\n  --\n  commit;\n  --\nend BEG_TRG_AD_PESSOA_FILIAL;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BI_PESSOA_FILIAL { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  cursor BUSCA_TITULOS is\n    select NVL(E.DTVENCTO, E.DTEMISSAO) DTVENCTO,\n           E.DTEMISSAO,\n           E.CDDUPL,\n           E.PARCELA,\n           E.VALOR,\n           E.CODIGO,\n           E.NRBANCO,\n           E.CONVENIADA,\n           E.SERIE,\n           E.NRNF,\n           E.DTREMESSA,\n           E.SEQREMESSA,\n           E.local,\n           E.VLPAGO,\n           E.DTPAGTO,\n           E.SRDUP,\n           E.CLASSIF,\n           DECODE(SIGN(E.DESCONTO), -1, 0, E.DESCONTO) DESCONTO,\n           DECODE(SIGN(E.DESCONTO), -1, ABS(E.DESCONTO) + E.JUROS, JUROS) JUROS,\n           E.rowid,\n           E.TPDEVOL,\n           E.NFDEVOL,\n           F.BEG_FILIAL_ID AD_ORG_ID,\n           FP.BEG_FILIAL_ID,\n           E.LOCALPG\n      from RECORACLE  E,\n           BEG_FILIAL F,\n           BEG_FILIAL FP\n     where E.DTPAGTO is not null -- GSC\n       and NVL(E.SITUACAO, 'A') not in ('B', 'C')\n       and E.BEG_CRC_TITULO_ID is null\n       and E.CODIGO = :new.value\n       and E.VALOR > 0\n       and F.AD_CLIENT_ID = 1000000 -- Diementz\n       and F.BEG_FILIAL_ID = :new.BEG_FILIAL_ID\n       and FP.AD_CLIENT_ID = F.AD_CLIENT_ID\n       and F.value = E.local\n       and FP.value(+) = E.LOCALPG\n       and not exists\n     (select 1\n              from BEG_CRC_TITULO T\n             where T.value = E.CDDUPL\n               and T.PARCELA = E.PARCELA\n               and T.AD_ORG_ID = F.BEG_FILIAL_ID\n               and NVL(T.SRDUP, '^') = NVL(E.SRDUP, '^')\n               and NVL(T.CLASSIF, '^') = NVL(E.CLASSIF, '^')); --\n  VREG1                  BUSCA_TITULOS%rowtype;\n  V_BEG_CRC_HISTORICO_ID number(10);\n  --\n  cursor BUSCA_BANCO is\n    select * from BEG_BANCO B where B.value = VREG1.NRBANCO;\n  --\n  VREG2 BUSCA_BANCO%rowtype;\n  --\n  cursor BUSCA_CONVENIO is\n    select * from BEG_CONVENIO where value = VREG1.CONVENIADA;\n  --\n  VREG3 BUSCA_CONVENIO%rowtype;\n  --\n  V_TITULO_ID      number(10);\n  V_CONTADOR       number(10);\n  V_TIPO_TITULO_ID number(10);\n  V_VLR_TITULO     number(18, 2);\n  V_VLR_PAGO       number(18, 2);\n  --\n  --  V_MAIOR_ID number(10);\n  --  V_MENOR_ID number(10);\n\n  cursor C_FILIAL_PGTO(P_VALUE varchar) is\n    select AD_ORG_ID\n      from AD_ORG A\n     where value = P_VALUE\n       and AD_CLIENT_ID = 1000000;\n  V_FILIAL_PGTO_ID number(10);\n\nbegin\n  --\n  for VREG1 in BUSCA_TITULOS\n  loop\n    -- Busca o Id do banco\n    VREG2.BEG_BANCO_ID := null;\n    if VREG1.NRBANCO is not null then\n      open BUSCA_BANCO;\n      fetch BUSCA_BANCO\n        into VREG2;\n      close BUSCA_BANCO;\n    end if;\n  \n    -- busca o id do convenio\n    VREG3.BEG_CONVENIO_ID := null;\n    if VREG1.CONVENIADA is not null then\n      open BUSCA_CONVENIO;\n      fetch BUSCA_CONVENIO\n        into VREG3;\n      close BUSCA_CONVENIO;\n    end if;\n  \n    --Compra programada\n    if VREG1.CLASSIF = '6' then\n      V_TIPO_TITULO_ID := 2500007; -- Compra Programada\n      V_VLR_TITULO     := VREG1.VALOR;\n    \n      if VREG1.DTPAGTO is not null then\n        V_VLR_PAGO := VREG1.VALOR;\n      end if;\n    \n    end if;\n  \n    --Normal\n    if VREG1.CLASSIF <> '6' then\n      V_TIPO_TITULO_ID := 2500004; -- Venda Crediario\n      V_VLR_TITULO     := VREG1.VALOR;\n    \n      if VREG1.DTPAGTO is not null then\n        V_VLR_PAGO := VREG1.VALOR;\n      end if;\n    \n    end if;\n  \n    --Convenio\n    if VREG1.CLASSIF <> '6'\n       and VREG1.CONVENIADA > 0 then\n      V_TIPO_TITULO_ID := 2500008; -- Venda COnvenio\n      V_VLR_TITULO     := VREG1.VALOR;\n    \n      if VREG1.DTPAGTO is not null then\n        V_VLR_PAGO := VREG1.VALOR;\n      end if;\n    \n    end if;\n  \n    --Complemento entrada\n    if VREG1.CLASSIF <> '6'\n       and VREG1.PARCELA = '00' then\n      V_TIPO_TITULO_ID := 2500010; -- Venda Crediario - Complemento\n      V_VLR_TITULO     := VREG1.VALOR;\n      if VREG1.DTPAGTO is not null then\n        V_VLR_PAGO := VREG1.VALOR;\n      end if;\n    end if;\n  \n    V_TITULO_ID := BEG_FNC_AD_SEQUENCE('BEG_CRC_TITULO');\n  \n    insert into BEG_CRC_TITULO\n      (BEG_CRC_TITULO_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       value,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       PARCELA,\n       DT_EMISSAO,\n       DT_VCTO,\n       VLR_TITULO,\n       VLR_MULTA,\n       VLR_JUROS,\n       VLR_DESCONTO,\n       VLR_ABERTO,\n       TP_COBRANCA,\n       NUMERO_TITULO_BANCO,\n       OBS,\n       VLR_DESPESA,\n       BEG_TIPO_TITULO_ID,\n       BEG_PESSOA_ID,\n       BEG_MOEDA_ID,\n       BEG_CONVENIO_ID,\n       BEG_BANCO_ID,\n       SERIE,\n       NUM_NF_SAIDA,\n       IND_ABERTO,\n       DT_ENVIO_BCO,\n       SEQ_ENVIO_BCO,\n       BEG_FILIAL_ID,\n       SRDUP,\n       CLASSIF,\n       TIPO_DEVOL,\n       NUM_NF_DEVOL)\n    values\n      (V_TITULO_ID,\n       1000000,\n       VREG1.AD_ORG_ID,\n       'Y',\n       VREG1.CDDUPL,\n       VREG1.DTEMISSAO, --sysdate, -- AOK - 24/09/2007\n       1000000,\n       VREG1.DTEMISSAO, --sysdate,  -- AOK - 24/09/2007\n       1000000,\n       NVL(VREG1.PARCELA, 0),\n       VREG1.DTEMISSAO,\n       VREG1.DTVENCTO,\n       V_VLR_TITULO,\n       0,\n       0,\n       0,\n       VREG1.VALOR,\n       'N',\n       null,\n       null,\n       0,\n       V_TIPO_TITULO_ID,\n       :new.BEG_PESSOA_ID,\n       1000000,\n       VREG3.BEG_CONVENIO_ID,\n       VREG2.BEG_BANCO_ID,\n       VREG1.SERIE,\n       VREG1.NRNF,\n       'Y',\n       VREG1.DTREMESSA,\n       VREG1.SEQREMESSA,\n       VREG1.AD_ORG_ID,\n       VREG1.SRDUP,\n       VREG1.CLASSIF,\n       VREG1.TPDEVOL,\n       VREG1.NFDEVOL);\n  \n    update RECORACLE\n       set BEG_CRC_TITULO_ID = V_TITULO_ID\n     where rowid = VREG1.rowid;\n  \n    --\n    if VREG1.DTPAGTO is not null then\n    \n      V_FILIAL_PGTO_ID := null;\n    \n      open C_FILIAL_PGTO(VREG1.LOCALPG);\n      fetch C_FILIAL_PGTO\n        into V_FILIAL_PGTO_ID;\n      close C_FILIAL_PGTO;\n    \n      V_BEG_CRC_HISTORICO_ID := BEG_FNC_AD_SEQUENCE('BEG_CRC_HISTORICO');\n      insert into BEG_CRC_HISTORICO\n        (BEG_CRC_HISTORICO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         value,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         VLR_MOVTO,\n         VLR_JUROS,\n         VLR_MULTA,\n         VLR_DESCONTO,\n         RECIBO_PAGTO,\n         BEG_CRC_TPMOV_ID,\n         BEG_CRC_TITULO_ID,\n         BEG_PESSOA_COBRADOR_ID,\n         BEG_PESSOA_CAIXA_ID,\n         BEG_BANCO_ID,\n         BEG_FILIAL_PGTO_ID,\n         DT_PGTO)\n      values\n        (V_BEG_CRC_HISTORICO_ID,\n         1000000,\n         VREG1.AD_ORG_ID,\n         'Y',\n         2,\n         VREG1.DTPAGTO, -- sysdate, -- AOK -- 24/09/2007\n         1000000,\n         VREG1.DTPAGTO, -- sysdate, -- AOK -- 24/09/2007\n         1000000,\n         V_VLR_PAGO,\n         NVL(VREG1.JUROS, 0),\n         0,\n         NVL(VREG1.DESCONTO, 0),\n         null,\n         1000006,\n         V_TITULO_ID,\n         null,\n         null,\n         null,\n         VREG1.BEG_FILIAL_ID,\n         VREG1.DTPAGTO);\n      --\n    end if;\n    V_CONTADOR := NVL(V_CONTADOR, 0) + 1;\n  end loop;\n  --close BUSCA_TITULOS;\n  --\nend DIE_TRG_BI_PESSOA_FILIAL;\n"}`;
    
    }
}
