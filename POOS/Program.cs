using System;
namespace POOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circulos");
            Circulos primerCirculo; //creacion del objeto Circulos
            primerCirculo = new Circulos(); //Instanciacion de la clase Circulos
            Console.WriteLine(primerCirculo.CalculoArea(5.0));

            ///USAMOS LA CLASE CONVERTIRBOLVIANODOLAR
            ConversorBolivianoDolar monto = new ConversorBolivianoDolar();
            Console.WriteLine(monto.ConvierteEnDolares(50));
            
        }
    }
    class Circulos
    {
        //Propiedades 
        private const double PI = 3.141565;
        //Metodos
        public double CalculoArea(double radio)
        {
         return  Math.Pow(radio, 2) * PI;
        }
    }
    class ConversorBolivianoDolar
    {
        private double boliviano = 6.96;

        public double Boliviano 
        { 
            get => boliviano;
            
            set => boliviano = value; 
        }

        public double ConvierteEnDolares(int cantidad)
        {
            return cantidad * Boliviano;
        }

        

    }
}