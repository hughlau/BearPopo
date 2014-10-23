using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearPopo.Model.Product
{
    [Serializable]
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCompany { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public ProductModel() { }
    }
}
