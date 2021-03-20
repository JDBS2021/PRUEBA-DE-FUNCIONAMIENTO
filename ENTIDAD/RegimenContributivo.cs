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

        public RegimenContributivo(long numeroLiquidacion, long pacienteID, string tipoAfiliacion, long salarioPaciente)
        base(numeroLiquidacion, pacienteID, tipoAfiliacion, salarioPaciente)

        {

        }

    public override void CalcularTarifa()
    {
        if (SalarioPaciente < 2)
        {
            tasa = 0.15;
        }
        else if (SalarioPaciente >= 2 && SalarioPaciente <= 5)
        {
            tasa = 0.20;
        }
        else if (SalarioPaciente > 5)
        {
            tasa = 0.25;
        }
    }

    public override void CalcularTope()
    {
        if (SalarioPaciente < 2)
        {
            Tope = 250000;
        }
        else if (SalarioPaciente >= 2 && SalarioPaciente <= 5)
        {
            Tope = 9000000;
        }
        else if (SalarioPaciente > 5)
        {
            Tope = 1500000;
        }
    }
}
