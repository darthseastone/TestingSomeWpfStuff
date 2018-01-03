using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace testingsomestuff
{
    class Apartment
    {
        public int Id { get; set; }
        [Required]
        public string address { get; set; }
        public int Price { get; set; }

        public ApartmentProblem ApartmentProblems { get; set; }
        public ApartmentDetails ApartmentDetails { get; set; }
        public PostNumber PostNumber { get; set; }
        //public PostNumberTest PnrTest { get; set; }




        public ObservableCollection<Customer> Customers { get; set; }

        public Apartment()
        {
            Customers = new ObservableCollection<Customer>();
        }
    }
}
