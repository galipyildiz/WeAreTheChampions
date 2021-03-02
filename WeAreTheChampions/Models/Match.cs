using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Matches")]
    public class Match : IComparable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime MatchTime { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public Result? Result { get; set; }

        
        [ForeignKey("Team1")]
        public int Team1Id { get; set; }
        public virtual Team Team1 { get; set; }

        
        [ForeignKey("Team2")]
        public int Team2Id { get; set; }
        public virtual Team Team2 { get; set; }

        public int CompareTo(object obj)
        {
            Match match2 = (Match)obj;
            return match2.MatchTime.CompareTo(MatchTime);
        }
    }
}
