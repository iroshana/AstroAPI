using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class ItermInventory
    {
        public ItermInventory()
        {

        }

        public int ID { get; set; }
        public int ItemID { get; set; }
        public decimal? Quantity { get; set; }
        
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int OutletID { get; set; }

        public virtual Item Item { get; set; }
        public virtual Outlet Outlet { get; set; }
    }
}
