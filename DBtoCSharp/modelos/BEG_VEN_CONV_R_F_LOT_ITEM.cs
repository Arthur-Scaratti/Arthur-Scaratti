
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_CONV_R_F_LOT_ITEM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_CONV_R_F_LOT_ITEM_ID { get; set; }
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
        /// 
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TITULO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_CONV_REC_FAT_LOT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_REFERENCIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONTRATO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_JUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BAIXA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string TITULO_PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MULTA { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CONV_RF_FAT_ITEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n  CURSOR C_CAPA IS\n    SELECT C.PERC_COMISSAO\n      FROM beg_ven_conv_rec_fat_lot C\n     WHERE C.BEG_VEN_CONV_REC_FAT_LOT_ID = :NEW.BEG_VEN_CONV_REC_FAT_LOT_ID;\n  --\n  VN_PERC_COMISSAO NUMBER(10);\n  --\nBEGIN\n  --\n  OPEN C_CAPA;\n  FETCH C_CAPA INTO VN_PERC_COMISSAO;\n  CLOSE C_CAPA;  \n  --\n  IF INSERTING THEN\n    --\n    IF :NEW.ISACTIVE = 'Y' THEN\n    --\n    UPDATE beg_ven_conv_rec_fat_lot C\n       SET C.VLR_REPASSE = NVL(C.VLR_REPASSE,0) + (:NEW.VLR_TITULO - ((VN_PERC_COMISSAO * :NEW.VLR_TITULO) / 100))\n         , C.VLR_LOTE_FINAL = NVL(C.VLR_LOTE_FINAL,0) + :NEW.VLR_TITULO\n     WHERE beg_ven_conv_rec_fat_lot_id = :NEW.BEG_VEN_CONV_REC_FAT_LOT_ID;    \n    --\n    :NEW.VLR_DESCONTO := NVL(:NEW.VLR_DESCONTO,0) + ((VN_PERC_COMISSAO * :NEW.VLR_TITULO) / 100);\n    --\n    END IF;\n    \n  END IF;\n  --\n  IF :NEW.ISACTIVE = 'Y' AND :OLD.ISACTIVE = 'N' THEN\n\n      UPDATE beg_ven_conv_rec_fat_lot C\n         SET C.VLR_LOTE_FINAL = NVL(C.VLR_LOTE_FINAL,0) + :NEW.VLR_TITULO\n           , C.VLR_REPASSE = NVL(C.VLR_REPASSE,0) + (:NEW.VLR_TITULO - ((VN_PERC_COMISSAO * :NEW.VLR_TITULO) / 100))\n       WHERE beg_ven_conv_rec_fat_lot_id = :NEW.BEG_VEN_CONV_REC_FAT_LOT_ID;\n\n  ELSIF :NEW.ISACTIVE = 'N' AND :OLD.ISACTIVE = 'Y' THEN\n    UPDATE beg_ven_conv_rec_fat_lot C\n       SET C.VLR_LOTE_FINAL = NVL(C.VLR_LOTE_FINAL,0) - :NEW.VLR_TITULO\n         , C.VLR_REPASSE = NVL(C.VLR_REPASSE,0) - (:NEW.VLR_TITULO - ((VN_PERC_COMISSAO * :NEW.VLR_TITULO) / 100))\n     WHERE beg_ven_conv_rec_fat_lot_id = :NEW.BEG_VEN_CONV_REC_FAT_LOT_ID;\n  END IF;\n  --\n   IF :NEW.VLR_TITULO <> :OLD.VLR_TITULO THEN\n    \n     :NEW.VLR_DESCONTO :=  ROUND(((VN_PERC_COMISSAO * :NEW.VLR_TITULO) / 100),2);     \n   \n   UPDATE beg_ven_conv_rec_fat_lot C          \n         SET C.VLR_LOTE_FINAL = NVL(C.VLR_LOTE_FINAL,0) + :NEW.VLR_TITULO - :OLD.VLR_TITULO\n           , C.VLR_REPASSE = NVL(C.VLR_REPASSE,0)-(:OLD.VLR_TITULO -:OLD.VLR_DESCONTO) + (:NEW.VLR_TITULO - ((VN_PERC_COMISSAO * :NEW.VLR_TITULO) / 100))\n       WHERE beg_ven_conv_rec_fat_lot_id = :NEW.BEG_VEN_CONV_REC_FAT_LOT_ID;     \n   \n   END IF;\n  \n  --\nEND;\n"}`;
    
    }
}
