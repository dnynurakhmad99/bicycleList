using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuykuy
{
    class Program
    {
        static void Main(string[] args)
        {  
            Menus menu1 = new Menus();
            Opening open = new Opening();
            open.Header1();
            menu1.DisplayMenu();
        }
    }
}
