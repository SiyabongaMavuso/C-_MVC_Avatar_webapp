using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvatarAssignment_2MVC.Models
{
    public class Fighter
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string BenderName { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Weapon { get; set; }

        [Required]
        public string FightingStyles { get; set; }
    }
}
