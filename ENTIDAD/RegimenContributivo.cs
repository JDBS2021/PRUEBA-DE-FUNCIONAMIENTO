using System;
using System.Collections.Generic;
using System.Text;

namespace ENTIDAD
{
    public class RegimenContributivo : LiquidacionCM
    {
        public RegimenContributivo() 
        {
           
                  
        }

        public RegimenContributivo(long numeroLiquidacion, long pacienteID, string tipoAfiliacion, long salarioPaciente, int salarioServicio)
            : base(numeroLiquidacion, pacienteID, tipoAfiliacion, salarioPaciente, salarioServicio) { }

        public override void CalcularTarifa()
        {
            if (SalarioDevengado < 2)
            {
                tasa = 15;
            }
            else if (SalarioDevengado >= 2 && SalarioDevengado <= 5)
            {
                tasa = 20;
            }
            else if (SalarioDevengado > 5)
            {
                tasa = 25;
            }
        }

        public override void CalcularTope()
        {
            if (SalarioDevengado < 2)
            {
                Tope = 250000;
            }
            else if (SalarioDevengado >= 2 && SalarioDevengado <= 5)
            {
                Tope = 9000000;
            }
            else if (SalarioDevengado > 5)
            {
                Tope = 1500000;
            }
        }


    }



}
