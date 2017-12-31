using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public partial class Outlet
    {
        public Outlet()
        {
            Customer = new HashSet<Customer>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int TelNumber { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
