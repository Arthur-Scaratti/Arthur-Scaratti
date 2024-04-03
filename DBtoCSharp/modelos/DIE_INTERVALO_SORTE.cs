
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_INTERVALO_SORTE
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int INICIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_ATUAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }

    }
}
