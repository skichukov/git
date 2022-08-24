using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models
{
    internal class Battle
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WinnerId { get; set; }
        public int LoserId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
