using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos_DOTNET.models
{
    public class Calculadora
    {
        public void Somar(int x , int y) => Console.WriteLine($"{x} + {y} = {x + y}");

        public void Subtrair(int x , int y) => Console.WriteLine($"{x} - {y} = {x - y}");

        public void Multiplicar(int x , int y) => Console.WriteLine($"{x} X {y} = {x * y}");

        public void Dividir(int x , int y) => Console.WriteLine($"{x} / {y} = {x / y}");

        public void Potencia(int x , int y) => Console.WriteLine($"{x} ^ {y} = {Math.Pow(x,y)}");

        public void Seno ( double angulo){

            double radiando = angulo * Math.PI /180;
            double seno = Math.Sin(radiando);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno,4)}");
        }

        public void Coseno ( double angulo){

            double radiando = angulo * Math.PI /180;
            double coseno = Math.Cos(radiando);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(coseno,4)}");
        }

        public void Tangente ( double angulo){

            double radiando = angulo * Math.PI /180;
            double tangente = Math.Tan(radiando);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(tangente,4)}");
        }

        public void RaizQuadrada(double x) => Console.WriteLine
                                        ($"Raiz quadrada de {x} = {Math.Sqrt(x)}");
    }
}