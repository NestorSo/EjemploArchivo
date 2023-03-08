using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBanco
{
    public class Registro
    {
        private int cuenta;
        private string nombre;
        private string apellido;
        private decimal saldo;

        //el constructor sin pparametros establece los elementos a los valores predeterminados 
        public Registro() : this(0, "", "", 0.0M)
        {

        }
        public Registro(int valorCuenta, string valorPrimerNombre, string valorApellido, decimal valorSaldo)
        {
            cuenta = valorCuenta;
            nombre = valorPrimerNombre;
            apellido = valorApellido;
            saldo = valorSaldo;
        }
        public int Cuenta { get => cuenta; set => cuenta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
    }
}
