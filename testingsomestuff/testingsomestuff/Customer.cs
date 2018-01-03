using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace testingsomestuff
{
    class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Kennitala { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public Apartment ApartmentStuff { get; set; }


        public ObservableCollection<Apartment> Apartments { get; set; }

        public Customer()
        {
            Apartments = new ObservableCollection<Apartment>();
        }
    }
}
