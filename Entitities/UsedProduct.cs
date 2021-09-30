using System.Globalization;
using System;

namespace ExercicioHeranca.Entitities
{
    class UsedProduct : Product // subclasse que herda metodos da classe Product
    {
        public DateTime Date { get; set; }

        public UsedProduct() { }

        public UsedProduct(DateTime date, string name, double price) : base (name, price) 
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2",CultureInfo.InvariantCulture) 
                + "( Manufacture date: " + Date.ToString("dd/MM/yyyy") + ")";
        }
    }
}
