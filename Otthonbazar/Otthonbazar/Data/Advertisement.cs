using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Otthonbazar.Data
{
    public class Advertisement
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Adja meg a címet!")]
        [Display(Name = "Cím")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Adja meg az építési évet!")]
        [Display(Name = "Építés éve")]
        public int BuildDate { get; set; }
        [Required(ErrorMessage = "Adja meg a várost!")]
        [Display(Name = "Város")]
        public int CityId { get; set; }
        [Display(Name = "Város")]
        public City City { get; set; }
        [Display(Name = "Leírás")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Adja meg a félszobák számát!")]
        [Display(Name = "Félszobák")]
        public int HalfRoom { get; set; }
        [Display(Name = "Fénykép")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Adja meg az eladási árat!")]
        [Display(Name = "Eladási ár")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Adja meg a szobák számát!")]
        [Display(Name = "Szobák")]
        public int Room { get; set; }
        [Required(ErrorMessage = "Adja meg az alapterületet!")]
        [Display(Name = "Alapterület")]
        public int Size { get; set; }
        [Required(ErrorMessage = "Adja meg a ház típusát!")]
        [Display(Name = "Típus")]
        public AdvertisementType AdvertisementType { get; set; }

    }
}
