using System;
using System.Collections.Generic;
using System.Text;

namespace TulipBusiness
{
    public class TulipBusinessClass : ITulipBusiness
    {
        private readonly ITulipRepository _tulipRepository;

        public TulipBusinessClass(ITulipRepository tulipRespository)
        {
            _tulipRepository = tulipRespository;
        }
        public decimal GetTulipAnnualSales(int year)
        {
            decimal salesAmount = _tulipRepository.GetTulipYearSales(year);
            if(salesAmount == 0)
            {
                throw new Exception("No sales found");
            }

            return salesAmount;
        }
    }
}
