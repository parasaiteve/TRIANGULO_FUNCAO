using System;
using System.Globalization;

namespace Course
{
    // Definição da classe Triangulo
    public class Triangulo
    {
        // Propriedades que representam os lados do triângulo
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        
        // Método para calcular a área do triângulo
        public double CalcularArea()
        {
            // Cálculo do semiperímetro
            double p = (A + B + C) / 2.0;
            
            // Cálculo da área utilizando a fórmula de Heron
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            
            return area;
        }
    }
    
    // Classe principal Program
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ler as medidas do Triângulo X e criar objeto Triangulo correspondente
            Triangulo x = LerTriangulo("X");
            
            // Ler as medidas do Triângulo Y e criar objeto Triangulo correspondente
            Triangulo y = LerTriangulo("Y");
            
            // Calcular a área do Triângulo X
            double areaX = x.CalcularArea();
            
            // Calcular a área do Triângulo Y
            double areaY = y.CalcularArea();
            
            // Imprimir a área do Triângulo X com 4 casas decimais de precisão
            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            
            // Imprimir a área do Triângulo Y com 4 casas decimais de precisão
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            
            // Comparar as áreas dos triângulos e imprimir qual tem a maior área
            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
        }
        
        // Método para ler as medidas de um triângulo e retornar um objeto Triangulo
        public static Triangulo LerTriangulo(string nomeTriangulo)
        {
            // Criar um objeto Triangulo
            Triangulo triangulo = new Triangulo();
            
            // Solicitar ao usuário que entre com as medidas do triângulo
            Console.WriteLine("Entre com as medidas do triangulo " + nomeTriangulo + ":");
            
            // Ler as medidas e atribuir aos lados do objeto Triangulo
            triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            // Retornar o objeto Triangulo
            return triangulo;
        }
    }
}
