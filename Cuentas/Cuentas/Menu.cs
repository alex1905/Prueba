using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas
{
    class Menu
    {
        Banco banco = new Banco();
        int opc;
        
        
        public Menu()
        {
            while (opc != 6)
            {
                try
                {
                    
                    Console.WriteLine("\t" + "\t" + "\t" + "Sistema De Cuentas Bancarias");
                    Console.WriteLine();
                    Console.WriteLine("1. Agregar Cuenta");
                    Console.WriteLine("2. Eliminar Cuenta");
                    Console.WriteLine("3. Depositar en cuenta");
                    Console.WriteLine("4. Retirar de Cuenta");
                    Console.WriteLine("5. Imprimir reporte");
                    Console.WriteLine("6. Salir");
                    Console.WriteLine();
                   
                    Console.WriteLine("Ingresar su opcion:");
                    opc = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("\n \n ");
                    banco.gestiona(opc);
                    
                }
                catch(FormatException){
                    Console.WriteLine("Opcion invalida \n \n \n");
                }
                
            }
            
        }

        
    }
}
