using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class CuentaPesos : Cuenta
    {
        public CuentaPesos()
        {
            cantidadDinero = 0;
            tipo = TipoDeCuenta.CuentaCorrientePesos;
        }

        public CuentaPesos(int monto)
        {
            cantidadDinero = monto;
            tipo = TipoDeCuenta.CuentaCorrientePesos;
        }

        public override void Extraccion(int monto, TipoDeExtraccion tipoex)
        {
            if (cantidadDinero - monto < -5000)
                Console.WriteLine("Fondos insuficientes.");
            else
            {
                if(tipoex == TipoDeExtraccion.CajeroHumano)
                    cantidadDinero -= monto;
                else
                {
                    if (monto > 20000)
                        Console.WriteLine("No puede sacar mas de 20.000 pesos");
                    else
                        cantidadDinero -= monto;
                }
            }
        }
    }
}
