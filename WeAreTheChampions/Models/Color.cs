using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Colors")]
    public class Color
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string ColorName { get; set; }

        [Range(0,255,ErrorMessage = "0-255 arasında değer giriniz.")]
        public int Red { get; set; }

        [Range(0, 255, ErrorMessage = "0-255 arasında değer giriniz.")]
        public int Green { get; set; }
        
        [Range(0, 255, ErrorMessage = "0-255 arasında değer giriniz.")]
        public int Blue { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
        public override string ToString()
        {
            return ColorName;
        }
    }
}
