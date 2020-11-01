using System;
using System.Collections.Generic;
using System.Text;

namespace TulipBusiness
{
    public interface ITulipRepository
    {
        decimal GetTulipYearSales(int year);
        decimal GetTulipMonthlySales(int year);
    }
}
