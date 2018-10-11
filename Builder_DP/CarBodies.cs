using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//in this class all body types' constructors are initialized
namespace Builder_DP
{
    class Sedan:Car
    {
        public Sedan()
        {
            Body = "Sedan";
            Engine = 98;
            Tires = 13;
            Efficiency = "5 Manual";
        }
    }
    class Coupe : Car
    {
        public Coupe()
        {
            Body = "Coupe";
            Engine = 160;
            Tires = 14;
            Efficiency = "4 Auto";
        }
    }
    class Universal : Car
    {
        public Universal()
        {
            Body = "Universal";
            Engine = 120;
            Tires = 16;
            Efficiency = "4 Manual";
        }
    }
    class HatchBack : Car
    {
        public HatchBack()
        {
            Body = "HatchBack";
            Engine = 66;
            Tires = 13;
            Efficiency = "4 Auto";
        }
    }
}
