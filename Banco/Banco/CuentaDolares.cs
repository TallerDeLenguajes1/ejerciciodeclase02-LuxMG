using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class CuentaDolares : Cuenta
    {
        public CuentaDolares()
        {
            cantidadDinero = 0;
            tipo = TipoDeCuenta.CuentaCorrienteDolares;
        }

        public CuentaDolares(int monto)
        {
            cantidadDinero = monto;
            tipo = TipoDeCuenta.CuentaCorrienteDolares;
        }

        public override void Extraccion(int monto, TipoDeExtraccion tipoex)
        {
            if (tipoex == TipoDeExtraccion.CajeroHumano)
                cantidadDinero -= monto;
            else
            {
                if (monto > 200)
                    Console.WriteLine("No puede sacar mas de 200 dolares");
                else
                    cantidadDinero -= monto;
            }
        }
    }
}
