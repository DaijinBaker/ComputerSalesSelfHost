using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSalesWinForm
{
    public class clsBrand
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public List<clsAllComputers> ComputerList { get; set; }
    }

    public class clsAllComputers
    {
        public int ComputerID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime LastModified { get; set; }
        public int Quantity { get; set; }
        public Char Type { get; set; }
        public string Ram { get; set; }
        public string HDD { get; set; }
        public string Graphics { get; set; }
        public string Color { get; set; }
        public string TowerType { get; set; }
        public string BrandName { get; set; }

        public static readonly string FACTORY_PROMPT = "D = Desktop & L = Laptop";

        public static clsAllComputers NewComputer(char prChoice)
        {
            return new clsAllComputers() { Type = Char.ToUpper(prChoice) };
        }

        public override string ToString()
        {
            return Name + "\t" + LastModified.ToShortDateString();
        }
    }

    public class clsOrder
    {
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public int OrderID { get; set; }
        public decimal PriceAtOrder { get; set; }
        public DateTime OrderDateTime { get; set; }
        public int OrderQuantity { get; set; }
        public int ComputerID { get; set; }
        public List<clsOrder> OrderList { get; set; }

    }
}
