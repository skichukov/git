using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models
{
    internal class Round
    {
        [Key]
        public int Id { get; set; }
        public int BattleId { get; set; }
        public int Character1State { get; set; }
        public int Character2State { get; set; }
        public int RoundIndex { get; set; }
        public int RandomNumber { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("BattleId")]
        public Battle ParrentBattle { get; set; }
    }
}
