using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public partial class Item
    {
        public Item()
        {

        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal Cost { get; set; }
        public int? ItemInStock { get; set; }
        public int? ReOrderLevel { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DiscountPercentage { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int SupplierID { get; set; }

        public virtual Supplier Supplier { get; set; }

    }
}
