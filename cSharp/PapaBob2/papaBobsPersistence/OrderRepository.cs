using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace papaBobsPersistence
{
    public class OrderRepository
    {
        public static void CreateOrder(papaBobs.DTO.OrderDTO orderDTO)
        {
            var db = new papaBobsDBEntities1();


            var order = convertToEntity(orderDTO);
            db.tbl_orders.Add(order);
            db.SaveChanges();
        }

        private static tbl_orders convertToEntity(papaBobs.DTO.OrderDTO orderDTO)
        {
            var order = new tbl_orders();

            order.orderID = orderDTO.orderID;
            order.size = orderDTO.size;
            order.crust = orderDTO.crust;
            order.sausage = orderDTO.sausage;
            order.pepperoni = orderDTO.pepperoni;
            order.onions = orderDTO.onions;
            order.greenPeppers = orderDTO.greenPeppers;
            order.customerName = orderDTO.customerName;
            order.customerAddress = orderDTO.customerAddress;
            order.customerPhone = orderDTO.customerPhone;
            order.customerZip = orderDTO.customerZip;
            order.totalCost = orderDTO.totalCost;
            order.paymentType = orderDTO.paymentType;
            order.completed = orderDTO.completed;

            return order;
        }

        public static void CompleteOrder(Guid orderId)
        {
            var db = new papaBobsDBEntities1();
            var order = db.tbl_orders.FirstOrDefault(p => p.orderID == orderId);
            order.completed = true;
            db.SaveChanges();
        }

        public static List<papaBobs.DTO.OrderDTO> GetOrders()
        {
            var db = new papaBobsDBEntities1();
            var orders = db.tbl_orders.Where(P => P.completed == false).ToList();
            var ordersDTO = convertToDTO(orders);
            return ordersDTO;

        }

        private static List<papaBobs.DTO.OrderDTO> convertToDTO(List<tbl_orders> orders)
        {
            var ordersDTO = new List<papaBobs.DTO.OrderDTO>();

            foreach (var order in orders)
            {
                var orderDTO = new papaBobs.DTO.OrderDTO();
                orderDTO.orderID = order.orderID;
                orderDTO.size = order.size;
                orderDTO.crust = order.crust;
                orderDTO.customerName = order.customerName;
                orderDTO.customerAddress = order.customerAddress;
                orderDTO.customerZip = order.customerZip;
                orderDTO.customerPhone = order.customerPhone;
                orderDTO.sausage = order.sausage;
                orderDTO.pepperoni = order.pepperoni;
                orderDTO.onions = order.onions;
                orderDTO.greenPeppers = order.greenPeppers;
                orderDTO.paymentType = order.paymentType;
                orderDTO.completed = order.completed;
                ordersDTO.Add(orderDTO);
                
                
            }
            return ordersDTO;
        }
    }
}
