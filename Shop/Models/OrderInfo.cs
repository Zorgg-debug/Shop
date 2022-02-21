using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class OrderInfo
    {
        public string Id { get; set; }
        public string Date_record { get; set; }
        public string Id_user { get; set; }
        public string Chat_id { get; set; }
        public string Status { get; set; }
        public string Adress { get; set; }
        public List<ProductBriefInfo> Product { get; set; }

    }
}
