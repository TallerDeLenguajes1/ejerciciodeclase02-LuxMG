using System;
using System.Collections.Generic;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            Cuenta c1 = new CuentaDolares(256);
            Cuenta c2 = new CuentaPesos(450);
            Cuenta c3 = new CajaAhorros(632);

            cuentas.Add(c1);
            cuentas.Add(c2);
            cuentas.Add(c3);

            foreach (Cuenta c in cuentas)
            {
                Console.WriteLine("Tipo de cuenta: " + c.Tipo.ToString());
                Console.WriteLine("Fondos disponibles: " + c.CantidadDinero);
                Console.WriteLine("Intento sacar 250 por cajero humano: ");
                c.Extraccion(250, TipoDeExtraccion.CajeroHumano);
                Console.WriteLine("Intento sacar 20000 por cajero automatico: ");
                c.Extraccion(20000, TipoDeExtraccion.CajeroAutomatico);
                Console.WriteLine("Fondos disponibles: " + c.CantidadDinero);
                Console.WriteLine();
            }
        }
    }
}
