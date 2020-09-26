using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Otthonbazar.Data
{
    public class City
    {
        //Fel fogja ismerni, hogy ez egy Id, ez lesz az elsődleges kulcs
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "Az irányítószám mező kitöltése kötelező."), StringLength(4, MinimumLength = 4, ErrorMessage = "Az irányítószám 4 db számból kell álljon.")] public string Zip { get; set; }

        public ICollection<Advertisement> Advertisements { get; set; }

    }
}
