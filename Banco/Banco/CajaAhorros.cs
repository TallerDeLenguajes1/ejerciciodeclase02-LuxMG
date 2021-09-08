using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class CajaAhorros : Cuenta
    {
        public CajaAhorros()
        {
            cantidadDinero = 0;
            tipo = TipoDeCuenta.CajaAhorroPesos;
        }

        public CajaAhorros(int monto)
        {
            cantidadDinero = monto;
            tipo = TipoDeCuenta.CajaAhorroPesos;
        }

        public override void Extraccion(int monto, TipoDeExtraccion tipoex)
        {
            if (cantidadDinero - monto < 0)
                Console.WriteLine("Fondos insuficientes.");
            else
            {
                if (tipoex == TipoDeExtraccion.CajeroHumano)
                    cantidadDinero -= monto;
                else
                {
                    if (monto > 10000)
                        Console.WriteLine("No puede sacar mas de 10.000 pesos");
                    else
                        cantidadDinero -= monto;
                }
            }
        }
    }
}
