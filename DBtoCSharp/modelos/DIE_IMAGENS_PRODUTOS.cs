
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_IMAGENS_PRODUTOS
    {
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string FILECHARSET { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_PADRAO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_IMAGENS_PRODUTOS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] FOTO { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string FILENAME { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string MIMETYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ATUALIZACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_IMAGENS_PRODUTOS { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  cursor c1 is\n    select b.die_cod_estruturado || substr(:new.filename, -4) filename\n      from  beg_produto b\n     where  b.beg_produto_id = :new.beg_produto_id\n;\n  r1 c1%rowtype;\n\nbegin\n\n  if trim(to_char((dbms_lob.getlength(:new.foto) / 1024), '999999990D9')) >\n     500.5 then\n  \n    raise_application_error(-20501,\n                            'Tamanho da imagem, excede o tamanho maximo permitido de 500 KB!!');\n  \n  end if;\n\n  open c1;\n  fetch c1\n    into r1;\n\n  :new.filename := r1.filename;\n\n  close c1;\nend;\n"}`;
    
    }
}
