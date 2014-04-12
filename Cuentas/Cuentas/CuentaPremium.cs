using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas
{
    class CuentaPremium:CuentaBanco
    {


        public CuentaPremium(string idCuenta, string nombreUsuario, float balance, float interes, string tipoCuenta)
            : base(idCuenta, nombreUsuario, balance, interes, tipoCuenta)
        {
            this.interes = 0.15f;
            this.tipoCuenta = "Premium";
        }
    }
}
