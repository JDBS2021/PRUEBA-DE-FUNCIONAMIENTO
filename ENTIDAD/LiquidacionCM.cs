using System;

namespace ENTIDAD
{
    public abstract class LiquidacionCM
    {
        public LiquidacionCM() { }

        public LiquidacionCM(long numeroLiquidacion, long dni, string tipoDeAfiliacion, long salarioDevengado, int salarioServicio)
        {
            NumeroLiquidacion = numeroLiquidacion;
            DNI = dni;
            TipoDeAfiliacion = tipoDeAfiliacion;
            SalarioDevengado = salarioDevengado;
            SalarioServicio = salarioServicio;
        }

        public long NumeroLiquidacion { get; set; }

        public long DNI { get; set; }

        public string TipoDeAfiliacion { get; set; }

        public long SalarioDevengado { get; set; }

        public int SalarioServicio { get; set; }

        public long tasa { get; set; }

        public long Tope { get; set; }

        public long Liquidacion { get; set; }

        public long CuotaModeradora { get; set; }

        public long CuotaModeradoraInicial { get; set; }

        public abstract void CalcularTarifa();

        public abstract void CalcularTope();

        public void CalcularCM()
        {
            CalcularTarifa();
            CuotaModeradoraInicial = SalarioServicio - tasa;
            CalcularTope();
            CuotaModeradora = DefinirCuotaModeradora();
        }


        public long DefinirCuotaModeradora()
        {
            if (CuotaModeradoraInicial > Tope)
            {

                return Tope;
            }
            return CuotaModeradoraInicial;


        }
        public override string ToString()
        {
            return $"NumeroLiquidacion:  {NumeroLiquidacion} - DNI {DNI} - TipoAfiliacion {TipoDeAfiliacion} - SalarioDevengado {SalarioDevengado} - SalarioServicio {SalarioServicio}";
        }

    }
}






