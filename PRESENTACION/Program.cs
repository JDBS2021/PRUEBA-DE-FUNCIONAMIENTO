using System;

namespace PRESENTACION
{
    class Program
    {
        static void Main(string[] args)
        {

            long NumeroLiquidacion;
            long DNI;
            string TipoDeAfiliacion;
            long SalarioDevengado;
            int ValorServicio;


            Console.WriteLine("Por Favor Digite El Numero De Liquidacion:  ");
            NumeroLiquidacion = long.Parse(Console.ReadLine());
            Console.WriteLine("Por Favor Digite La Identifiacion Del Usuario:  ");
            DNI = long.Parse(Console.ReadLine());
            Console.WriteLine("Por Favor Digite El Tipo De Afiliacion:    ");
            TipoDeAfiliacion = Console.ReadLine();
            Console.WriteLine("Por Favor Digite El Salario Devengado:    ");
            SalarioDevengado = long.Parse(Console.ReadLine());
            Console.WriteLine("Por Favor Digite El Tipo De Afiliacion:    ");
            ValorServicio = Convert.ToInt32(Console.ReadLine());




        }
    }
}

        
    

