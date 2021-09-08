using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public enum TipoDeExtraccion 
    {
        CajeroHumano = 1,
        CajeroAutomatico = 2
    };

    public enum TipoDeCuenta
    {
        NULL,
        CuentaCorrientePesos,
        CuentaCorrienteDolares,
        CajaAhorroPesos
    };

    class Cuenta
    {
        protected double cantidadDinero;
        protected TipoDeCuenta tipo;

        public double CantidadDinero { get => cantidadDinero; set => cantidadDinero = value; }
        public TipoDeCuenta Tipo { get => tipo; set => tipo = value; }

        public Cuenta()
        {
        }

        public virtual void Extraccion(int monto, TipoDeExtraccion tipoex)
        {

        }

        public void Insercion(int monto)
        {
            cantidadDinero += monto;
        }
        
    }
}
