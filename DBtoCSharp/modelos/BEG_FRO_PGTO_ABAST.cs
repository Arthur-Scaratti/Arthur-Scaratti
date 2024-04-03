
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_PGTO_ABAST
    {
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
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_FINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_PGTO_ABAST_ID { get; set; }
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

        [NotMapped]
        public string Trigger_TRG_BD_BEG_FRO_PGTO_ABAST { get; set; } = `{"triggering_event":"DELETE","trigger_body":"begin\n\n  update BEG_FRO_ABASTECIMENTO A\n     set A.IND_PAGTO = 'N'\n   where A.BEG_FRO_ABASTECIMENTO_ID in\n         (select BEG_FRO_ABASTECIMENTO_ID\n            from BEG_FRO_ABASTECIMENTO_PAGO B\n           where B.BEG_FRO_PGTO_ABAST_ID = :old.BEG_FRO_PGTO_ABAST_ID);\n\n  delete from BEG_FRO_ABASTECIMENTO_PAGO C\n   where C.BEG_FRO_PGTO_ABAST_ID = :old.BEG_FRO_PGTO_ABAST_ID;\n\nend TRG_BI_BEG_FRO_PGTO_ABAST;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BI_BEG_FRO_PGTO_ABAST { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n  :new.DOCSTATUS := 'WC';\nend TRG_BI_BEG_FRO_PGTO_ABAST;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_AIU_BEG_FRO_PGTO_ABAST { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  V_ABASTECIMENTO_PAGO number(10);\n  --  V_PARCELA_RENEG_ID   number(10);\n  --  V_GEROU_ENTRADA      varchar2(1);\n  --\n  cursor BUSCA_ABASTECIDAS is\n    select B.BEG_FRO_ABASTECIMENTO_ID,\n           null OS,\n           B.VLR_TOTAL\n      from BEG_FRO_ABASTECIMENTO B\n     where B.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n       and B.DT_ABAST between :new.DT_INICIAL and :new.DT_FINAL\n       and B.IND_PAGTO = 'N'\n    union\n    select null,\n           D.BEG_FRO_ORDEM_SERVICO_ID,\n           D.VLR_TOTAL\n      from BEG_FRO_ORDEM_SERVICO D\n     where D.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n       and D.DT_ENCERRAM_OS between :new.DT_INICIAL and :new.DT_FINAL\n       and D.IND_PAGTO = 'N';\n  --\n  VREG1 BUSCA_ABASTECIDAS%rowtype;\n  --\nbegin\n  if INSERTING then\n    open BUSCA_ABASTECIDAS;\n    loop\n      fetch BUSCA_ABASTECIDAS\n        into VREG1;\n      exit when BUSCA_ABASTECIDAS%notfound;\n      AD_SEQUENCE_NEXT('BEG_FRO_ABASTECIMENTO_PAGO',\n                       0,\n                       V_ABASTECIMENTO_PAGO);\n      insert into BEG_FRO_ABASTECIMENTO_PAGO\n        (BEG_FRO_ABASTECIMENTO_PAGO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         value,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         IND_PAGTO,\n         BEG_FRO_PGTO_ABAST_ID,\n         BEG_FRO_ABASTECIMENTO_ID,\n         BEG_FRO_ORDEM_SERVICO_ID,\n         VLR_ABAST)\n      values\n        (V_ABASTECIMENTO_PAGO,\n         :new.AD_CLIENT_ID,\n         :new.AD_ORG_ID,\n         :new.ISACTIVE,\n         :new.value,\n         :new.CREATED,\n         :new.CREATEDBY,\n         :new.UPDATED,\n         :new.UPDATEDBY,\n         'N',\n         :new.BEG_FRO_PGTO_ABAST_ID,\n         VREG1.BEG_FRO_ABASTECIMENTO_ID,\n         VREG1.OS,\n         VREG1.VLR_TOTAL);\n    end loop;\n    close BUSCA_ABASTECIDAS;\n  elsif UPDATING\n        and :new.DOCSTATUS <> 'CO' then\n    delete from BEG_FRO_ABASTECIMENTO_PAGO C\n     where C.BEG_FRO_PGTO_ABAST_ID = :new.BEG_FRO_PGTO_ABAST_ID;\n    open BUSCA_ABASTECIDAS;\n    loop\n      fetch BUSCA_ABASTECIDAS\n        into VREG1;\n      exit when BUSCA_ABASTECIDAS%notfound;\n      AD_SEQUENCE_NEXT('BEG_FRO_ABASTECIMENTO_PAGO',\n                       0,\n                       V_ABASTECIMENTO_PAGO);\n      insert into BEG_FRO_ABASTECIMENTO_PAGO\n        (BEG_FRO_ABASTECIMENTO_PAGO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         value,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         IND_PAGTO,\n         BEG_FRO_PGTO_ABAST_ID,\n         BEG_FRO_ABASTECIMENTO_ID,\n         BEG_FRO_ORDEM_SERVICO_ID,\n         VLR_ABAST)\n      values\n        (V_ABASTECIMENTO_PAGO,\n         :new.AD_CLIENT_ID,\n         :new.AD_ORG_ID,\n         :new.ISACTIVE,\n         :new.value,\n         :new.CREATED,\n         :new.CREATEDBY,\n         :new.UPDATED,\n         :new.UPDATEDBY,\n         'N',\n         :new.BEG_FRO_PGTO_ABAST_ID,\n         VREG1.BEG_FRO_ABASTECIMENTO_ID,\n         VREG1.OS,\n         VREG1.VLR_TOTAL);\n    end loop;\n    close BUSCA_ABASTECIDAS;\n  end if;\nend TRG_AIUD_CRC_RENEGOCIACAO;\n"}`;
    
    }
}
