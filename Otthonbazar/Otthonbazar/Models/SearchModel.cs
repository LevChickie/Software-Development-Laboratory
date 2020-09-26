using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Otthonbazar.Models
{
    public class SearchModel
    {
        public Nullable<int> CityId { get; set; }
        [Display(Name ="Name of the City")]
        public string CityName { get; set; }
        [Display(Name = "Minimum value of price")]
        public Nullable<decimal> PriceMin { get; set; }
        [Display(Name = "Maximum value of price")]
        public Nullable<decimal> PriceMax { get; set; }
        [Display(Name = "Maximum value of rooms")]
        public Nullable<int> RoomMax { get; set; }
        [Display(Name = "Minimum value of rooms")]
        public Nullable<int> RoomMin { get; set; }
        [Display(Name = "Maximum value of size")]
        public Nullable<int> SizeMax { get; set; }
        [Display(Name = "Minimum value of size")]
        public Nullable<int> SizeMin { get; set; }
    }
}
