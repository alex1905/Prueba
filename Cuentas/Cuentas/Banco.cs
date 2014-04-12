using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas
{
    public class Banco
    {
       
         int cantidad;
        string cuenta,nombre;
        Random y = new Random();
       private List<CuentaBanco> cuentas= new List<CuentaBanco>();

        public void gestiona(int opc)
        {
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("1. Agregar Cuenta Basica");
                    Console.WriteLine("2. Agregar Cuenta Premium");
                    Console.WriteLine("3. Salir");
                    Console.WriteLine("Ingrese su opcion");
                    Console.WriteLine();
                    opc = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch(opc){
                        case 1:
                            Console.WriteLine("Ingrese la cuenta");
                            cuenta = Console.ReadLine();

                            if (encuentra(cuenta, cuentas) == null)
                            {
                                Console.WriteLine("Ingrese el nombre");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese la cantidad a depositar");
                                cantidad = int.Parse(Console.ReadLine());
                                CuentaBasica cb = new CuentaBasica(cuenta, nombre, cantidad, 0.1f, "");

                                cuentas.Add(cb);
                                Console.Clear();
                            }
                            else { Console.WriteLine("El numero de cuenta ya existe\n \n ");  }
                               
                            break;

                        case 2:
                            Console.WriteLine("Ingrese la cuenta");
                            cuenta = Console.ReadLine();
                             if (encuentra(cuenta, cuentas) == null)
                            {
                            Console.WriteLine("Ingrese el nombre");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la cantidad a depositar");
                            cantidad = int.Parse(Console.ReadLine());
                            CuentaPremium cp = new CuentaPremium(cuenta,nombre,cantidad,0.15f,"Premium");
                            cuentas.Add(cp);
                            Console.WriteLine("\n \n ");
                            Console.Clear();
                            }
                             else { Console.WriteLine("El numero de cuenta ya existe\n \n ");
                             
                             }
                               
                            break;

                        case 3:
                            Console.Clear();
                            break;
                        
                    }
                    break;

                case 2:
                    Console.WriteLine("Ingrese el numero de cuenta");
                    cuenta = Console.ReadLine();
                    if (encuentra(cuenta, cuentas) == null)
                    { Console.WriteLine("No se encontro la cuenta"); Console.WriteLine(); }

                    else { eliminar(cuenta, cuentas); }
                    break;

                case 3:
                    Console.WriteLine("Ingrese el numero de cuenta");
                    cuenta = Console.ReadLine();
                    if (encuentra(cuenta, cuentas) == null)
                    { Console.WriteLine("No se encontro la cuenta\n \n "); break; }

                    Console.WriteLine("Ingrese la cantidad a depositar");
                    cantidad = int.Parse(Console.ReadLine());

                    if (cantidad < 0) { Console.WriteLine("Cantidad negativa"); }

                    

                    else { depositar(cuenta, cuentas,cantidad); }
                    break;

                case 4:
                    Console.WriteLine("Ingrese el numero de cuenta");
                    cuenta = Console.ReadLine();
                    if (encuentra(cuenta, cuentas) == null)
                    { Console.WriteLine("No se encontro la cuenta\n \n "); break; }
                    Console.WriteLine("Ingrese la cantidad a retirar");
                    cantidad = int.Parse(Console.ReadLine());

                    if (cantidad < 0) { Console.WriteLine("Cantidad negativa\n \n ");  }

                     

                    else { retirar(cuenta, cuentas,cantidad); }
                    break;

                case 5:
                    foreach (CuentaBanco cb in cuentas)
                    {
                        Console.WriteLine(cb);
                    }
                    break;

            }
        }


        private CuentaBanco  encuentra(string ct, List<CuentaBanco> c)
        {
           foreach (CuentaBanco cv in c)
           {
               if (cv.IdCuenta.Equals(ct))
               {
                   return cv;
               }
           }
            return null;
        }

        private void eliminar(string ct, List<CuentaBanco> c)
        {
            CuentaBanco co = encuentra(ct,c);
            c.Remove(co);
            Console.WriteLine("Cuenta Eliminada");
            Console.WriteLine();
            
        }

        private void depositar(string ct, List<CuentaBanco> c,int y) 
        {
            CuentaBanco cv = encuentra(ct,c);
            cv.Balance += y;
            cv.Total += y;
           
        }

        private void retirar(string ct, List<CuentaBanco> c, int y)
        {
            CuentaBanco cv = encuentra(ct, c);
            if (cv.Balance < y) {
                Console.WriteLine("Cantidad mayor a la de la cuenta\n \n ");
              
            }
            else
            {
                cv.Balance -= y;
                cv.Total -= y;
            }
           
        }
         
  }
}
