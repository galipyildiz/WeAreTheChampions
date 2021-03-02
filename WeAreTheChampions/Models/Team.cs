﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Teams")]
    public class Team
    {
        public Team()
        {
            this.Players = new HashSet<Player>();
            this.Colors = new HashSet<Color>();
            this.HomeMatches = new HashSet<Match>();
            this.AwayMatches = new HashSet<Match>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string TeamName { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Color> Colors { get; set; }

        [InverseProperty("Team1")]
        public virtual ICollection<Match> HomeMatches { get; set; }
        [InverseProperty("Team2")]
        public virtual ICollection<Match> AwayMatches { get; set; }

        public override string ToString()
        {
            return TeamName;
        }
    }
}
