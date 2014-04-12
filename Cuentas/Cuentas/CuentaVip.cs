using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas
{
    class CuentaVip:CuentaBanco
    {

         public CuentaVip(string idCuenta, string nombreUsuario, float balance, float interes, string tipoCuenta)
            : base(idCuenta, nombreUsuario, balance, interes, tipoCuenta)
        {
            this.tipoCuenta = "Vip";
            this.interes = 0.8f;
        }

        public override string ToString()
        {
            return base.ToString()+"";
        }
    }
}
