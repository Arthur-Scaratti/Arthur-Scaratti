
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_COB_PESSOA_RESTRICAO
    {
        
        /// <summary>
        /// Id da Pessoa Restricao
        /// </summary>
        public int BEG_PESSOA_RESTRICAO_ID { get; set; }
        
        /// <summary>
        /// id  da origem (spc ou cartorio ou juridico)
        /// </summary>
        public int DIE_ORIGEM_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica qual a Origem - (S)pc, (C)artorio, (J)uridico 
        /// </summary>
        public string IND_ORIGEM { get; set; }

    }
}
