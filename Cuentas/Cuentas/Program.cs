using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Menu m = new Menu();
            CuentaBasica cb = new CuentaBasica("89845", "JUAN", 300, 0, "");
            Console.WriteLine(cb);
          //  Console.WriteLine(cb.ToString);
            
            Console.ReadKey();

        }
    }
}
