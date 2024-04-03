
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class STORE_BLOB
    {
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] BLOB_FILE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED_DATE { get; set; }

    }
}
