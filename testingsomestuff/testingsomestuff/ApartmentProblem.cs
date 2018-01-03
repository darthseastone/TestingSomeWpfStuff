using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingsomestuff
{
    class ApartmentProblem
    {
        public int Id { get; set; }
        [Required]
        public string Problem { get; set; }
    }
}
