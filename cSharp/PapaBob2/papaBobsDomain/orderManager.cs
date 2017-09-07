using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papaBobsDomain
{
    public class orderManager
    {
        public static void CreateOrder(papaBobs.DTO.OrderDTO orderDTO)
        {

            //Validation
            if (orderDTO.customerName.Trim().Length == 0)
                throw new Exception("Name is required");
            if (orderDTO.customerAddress.Trim().Length == 0)
                throw new Exception("Address is required");
            if (orderDTO.customerZip.Trim().Length == 0)
                throw new Exception("Zip is required");
            if (orderDTO.customerPhone.Trim().Length == 0)
                throw new Exception("Phone number is required");

            orderDTO.orderID = Guid.NewGuid();
            orderDTO.totalCost = pizzaPriceManager.calculatePizzaPrice(orderDTO);
            papaBobsPersistence.OrderRepository.CreateOrder(orderDTO);
        }

        public static void CompleteOrder(Guid orderId)
        {
            papaBobsPersistence.OrderRepository.CompleteOrder(orderId);
        }

        public static object GetOrders()
        {
            return papaBobsPersistence.OrderRepository.GetOrders();
        }
    }
}
