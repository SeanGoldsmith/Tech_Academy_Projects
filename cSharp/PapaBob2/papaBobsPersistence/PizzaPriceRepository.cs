using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papaBobsPersistence
{
    public class PizzaPriceRepository
    {
        public static papaBobs.DTO.PizzaPriceDTO GetPizzaPrices()
        {
            var db = new papaBobsDBEntities1();
            var prices = db.PizzaPrices.First();
            var dto = convertToDTO(prices);
            return dto;
        }

        private static papaBobs.DTO.PizzaPriceDTO convertToDTO(PizzaPrice pizzaPrice)
        {
            var dto = new papaBobs.DTO.PizzaPriceDTO();

            dto.SmallSizeCost = pizzaPrice.SmallSizeCost;
            dto.MediumSizeCost = pizzaPrice.MediumSizeCost;
            dto.LargeSizeCost = pizzaPrice.LargeSizeCost;
            dto.ThickCrustCost = pizzaPrice.ThickCrustCost;
            dto.ThinCurstCost = pizzaPrice.ThinCurstCost;
            dto.RegularCrustCost = pizzaPrice.RegularCrustCost;
            dto.SauasgeCost = pizzaPrice.SauasgeCost;
            dto.PepperoniCost = pizzaPrice.PepperoniCost;
            dto.OnionCost = pizzaPrice.OnionCost;
            dto.GreenPepperCost = pizzaPrice.GreenPepperCost;



            return dto;
        }
    }
}
