using System;

namespace InheritanceAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman carSalesObj = new CarSalesman("Mihir","Joshi");
            carSalesObj.Sell();
            RetailSalesman retailSalesObj = new RetailSalesman("Mihir", "Joshi");
            retailSalesObj.Sell();
        }
    }
}
