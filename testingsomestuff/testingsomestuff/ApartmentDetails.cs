using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace testingsomestuff
{
    class ApartmentDetails
    {
        //private List<Apartment> function;

        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        public int YearBuilt { get; set; }
        [Required]
        public int ApartmentSize { get; set; }
        [Required]
        public int RoomsCount { get; set; }
        [Required]
        public int BedroomCount { get; set; }
        [Required]
        public int ToiletCount { get; set; }
        [Required]
        public string Entrance { get; set; }
        [Required]
        public string Garage { get; set; }

    }
}
