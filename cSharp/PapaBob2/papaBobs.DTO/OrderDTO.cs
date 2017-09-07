using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papaBobs.DTO
{
    public class OrderDTO
    {
        public System.Guid orderID { get; set; }
        public papaBobs.DTO.Enums.SizeType size { get; set; }
        public papaBobs.DTO.Enums.crustType crust { get; set; }
        public bool sausage { get; set; }
        public bool pepperoni { get; set; }
        public bool onions { get; set; }
        public bool greenPeppers { get; set; }
        public decimal totalCost { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string customerZip { get; set; }
        public string customerPhone { get; set; }
        public papaBobs.DTO.Enums.paymentType paymentType { get; set; }
        public bool completed { get; set; }
    }
}
