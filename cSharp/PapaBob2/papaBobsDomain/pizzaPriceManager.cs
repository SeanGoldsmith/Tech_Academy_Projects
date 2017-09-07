using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using papaBobs.DTO;

namespace papaBobsDomain
{
    public class pizzaPriceManager
    {
        public static decimal calculatePizzaPrice(papaBobs.DTO.OrderDTO order)
        {
            decimal cost = 0.0M;
            var prices = getPizzaPrices();

            cost += calculateSizeCost(order,prices);
            cost += calculateCurstCost(order,prices);
            cost += calculateToppingsCost(order, prices);




            return cost;
        }

        private static decimal calculateCurstCost(OrderDTO order, PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            switch (order.crust)
            {
                case papaBobs.DTO.Enums.crustType.Regular:
                    cost = prices.RegularCrustCost;
                    break;
                case papaBobs.DTO.Enums.crustType.Thin:
                    cost = prices.ThinCurstCost;
                    break;
                case papaBobs.DTO.Enums.crustType.Thick:
                    cost = prices.ThickCrustCost;
                    break;
                default:
                    break;
            }
            return cost;

        }

        private static decimal calculateToppingsCost(OrderDTO order,papaBobs.DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            cost += (order.sausage) ? prices.SauasgeCost : 0M;
            cost += (order.pepperoni) ? prices.PepperoniCost : 0M;
            cost += (order.onions) ? prices.OnionCost : 0M;
            cost += (order.greenPeppers) ? prices.GreenPepperCost : 0M;

            return cost;
        }

        private static decimal calculateSizeCost(OrderDTO order, papaBobs.DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;
            

            switch (order.size)
            {
                case papaBobs.DTO.Enums.SizeType.Small:
                    cost = prices.SmallSizeCost;
                    break;
                case papaBobs.DTO.Enums.SizeType.Medium:
                    cost = prices.MediumSizeCost;
                    break;
                case papaBobs.DTO.Enums.SizeType.Large:
                    cost = prices.LargeSizeCost;
                    break;
                default:
                    break;
            }


            return cost;
        }

        public static papaBobs.DTO.PizzaPriceDTO getPizzaPrices()
        {
            var prices = papaBobsPersistence.PizzaPriceRepository.GetPizzaPrices();
            return prices;
        }

    }
}
