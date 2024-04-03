
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FAT_NFE_XML
    {
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
        public string ARQUIVO_XML { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE_ACESSO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string XML_MYME { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string XML_FILENAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] XML_BLOB { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string INF_ADICIONAL { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string INF_FISCAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_INF_FISCAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_INF_ADICIONAL_ID { get; set; }
        
        /// <summary>
        /// 1 SAIDA / 2 ENTRADA
        /// </summary>
        public int TP_NF { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_GERA_TRANSFERENCIA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFE_XML_ID { get; set; }
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

        [NotMapped]
        public string Trigger_BEG_FAT_TRG_LOB_XML { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\n  VN_NF                    BEG_FAT_NFS.NRO_NFS%type;\n  VN_NFE                   BEG_CPR_NFE.NUMERO%type;\n  VN_BEG_FIS_COD_MODELO_ID BEG_FIS_COD_MODELO.BEG_FIS_COD_MODELO_ID%type;\n  --\n  cursor CCODMOD is\n    select BEG_FIS_COD_MODELO_ID\n      from BEG_FIS_COD_MODELO\n     where BEG_FIS_COD_MODELO.VALUE = '55';\n  --\nbegin\n  if :NEW.ARQUIVO_XML is not null then\n    if :NEW.BEG_FAT_NFS_ID is not null then\n      \n/*      select NRO_NFS\n        into VN_NF\n        from BEG_FAT_NFS\n       where BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID;*/\n       \n      :NEW.XML_MYME     := 'text/xml';\n      :NEW.XML_FILENAME := /*'F' || VN_NF ||*/ :NEW.CHAVE_ACESSO||'.xml';\n      select BEG_FNC_CLOB_TO_BLOB((:NEW.ARQUIVO_XML).GETCLOBVAL())\n        into :NEW.XML_BLOB\n        from DUAL;\n    end if;\n    -- aok - 25/04/2011 --\n    if :NEW.BEG_CPR_NFE_ID is not null then\n      open ccodmod;\n      fetch ccodmod into VN_BEG_FIS_COD_MODELO_ID;\n      close ccodmod;\n      update BEG_CPR_NFE_FISCAL B\n         set B.CHAVE_NFE             = :NEW.CHAVE_ACESSO,\n             B.COD_MOD_NF            = 55, -- Codigo modelo de nota fiscal eletronica,\n             B.BEG_FIS_COD_MODELO_ID = VN_BEG_FIS_COD_MODELO_ID -- id do modelo nf eletronica\n       where B.BEG_CPR_NFE_FISCAL_ID = :NEW.BEG_CPR_NFE_ID;\n       --\n\n/*      select n.numero\n        into VN_NFE\n        from beg_cpr_nfe n\n       where n.Beg_Cpr_Nfe_Id = :NEW.BEG_CPR_NFE_ID;*/\n\n       --\n      :NEW.XML_MYME     := 'text/xml';\n      :NEW.XML_FILENAME := :NEW.CHAVE_ACESSO||'.xml'; --'E' || VN_NFE || '.xml';\n\n      select BEG_FNC_CLOB_TO_BLOB((:NEW.ARQUIVO_XML).GETCLOBVAL())\n        into :NEW.XML_BLOB\n        from DUAL;\n    end if;\n    ----------------------\n  end if;\nend BEG_FAT_TRG_LOB_XML;\n"}`;
    
    }
}
