using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas
{
   class CuentaBanco : Banco
    {
       protected string nombreUsuario, idCuenta, tipoCuenta;
        protected float   interes,total,balan;

        public CuentaBanco() { }

        public float generaT(float i,float t,float b)
        {
            t=t+(i*b);
            return t;
        }

        public CuentaBanco(string idCuenta, string nombreUsuario, float balance, float interes, string tipoCuenta)
        {
            
            this.balan += balance;
            this.nombreUsuario = nombreUsuario;
            this.idCuenta=idCuenta;
            this.interes = interes;
            this.tipoCuenta = tipoCuenta;
            float x=this.balan+(this.balan*this.interes);
            this.total=x;
            
            
        }

        public string NombreUsuario
        {
            get { return this.nombreUsuario; }
            set { this.nombreUsuario = value; }
        }
       public String TipoCuenta{
           get { return this.tipoCuenta; }
           set { this.tipoCuenta = value; }
   }

       public float Interes
       {
           get { return this.interes; }
           set { this.interes = value; }
       }

       public string IdCuenta 
       {
           get { return this.idCuenta; }
           set { this.idCuenta = value; }
       }

       public float Total { 
           get { return this.total; }
          
           set { this.total = value; }
          
       }

       public float Balance {
           get { return this.balan; }
           set { this.balan = value; }
       
       }

        public override string ToString()
        {
            return "Cuenta: "+this.tipoCuenta +"\n"
            + "Id Cuenta: "+this.idCuenta+"\n"+
            "Nombre: " + this.nombreUsuario + "\n"+
            "Balance: " + this.balan+ "\n"+
            "Intereses: " + this.interes + "\n"+
            "Total: "+this.total+"\n \n ";
        }
        
    }
}
