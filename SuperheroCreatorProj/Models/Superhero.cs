using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperheroCreatorProj.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Superhero Name is required!")]
        public string SuperheroName { get; set; }

        [Required]
        public string AlterEgoName { get; set; }

        [Required]
        public string PrimaryAbility { get; set; }

        [Required]
        public string SecondaryAbility { get; set; }

        [Required]
        public string Catchphrase { get; set; }

    }
}
