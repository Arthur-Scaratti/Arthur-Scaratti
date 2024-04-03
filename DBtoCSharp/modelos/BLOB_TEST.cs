
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BLOB_TEST
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] CAMPO1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] CAMPO2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CAMPO3 { get; set; }
            [StringLength(150)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }

    }
}
