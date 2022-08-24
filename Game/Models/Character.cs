using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models
{
    internal class Character
    {
        [Key]
        public int Id { get; set; }
        //[ForeignKey("Id")]
        public int UserId { get; set; }
        public string CharacterName { get; set; }
        public string Type { get; set; }
        public int AttackPoints { get; set; }
        public int DefencePoints { get; set; }
        public int HealthPoints { get; set; }
        public DateTime DateCreated { get; set; }
        [ForeignKey("UserId")]
        public User ParentUser { get; set; }
    }
}
