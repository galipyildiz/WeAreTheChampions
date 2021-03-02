using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Players")]
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string PlayerName { get; set; }

        public string PhotoPath { get; set; }
        public byte[] Photo { get; set; }

        [ForeignKey("Team")]
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }
        public override string ToString()
        {
            return PlayerName;
        }

    }
}
