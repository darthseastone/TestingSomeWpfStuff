using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingsomestuff
{
    class SharedContext
    {
        public static OkurLeigaContext context = new OkurLeigaContext();
        public static Customer selectedCustomer;

    }
}
