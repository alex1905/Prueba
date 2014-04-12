using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas
{
    class CuentaBasica:CuentaBanco
    {


        public CuentaBasica(string idCuenta, string nombreUsuario, float balance, float interes, string tipoCuenta)
            : base(idCuenta, nombreUsuario, balance, interes, tipoCuenta)
        {
            this.tipoCuenta = "Basica";
            this.interes = 0.1f;
        }

        public override string ToString()
        {
            return base.ToString()+"";
        }
    }
}
