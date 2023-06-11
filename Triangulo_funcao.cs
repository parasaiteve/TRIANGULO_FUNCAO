using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Lê as medidas do Triângulo X
            double[] medidasX = LerMedidasTriangulo("X");
            
            // Lê as medidas do Triângulo Y
            double[] medidasY = LerMedidasTriangulo("Y");
            
            // Calcula a área do Triângulo X
            double areaX = CalcularAreaTriangulo(medidasX);
            
            // Calcula a área do Triângulo Y
            double areaY = CalcularAreaTriangulo(medidasY);
            
            // Imprime a área do Triângulo X com 4 casas decimais de precisão
            Console.WriteLine("Area de X =" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            
            // Imprime a área do Triângulo Y com 4 casas decimais de precisão
            Console.WriteLine("Area de Y =" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            
            // Compara as áreas dos triângulos e imprime qual tem a maior área
            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
        }
        
        // Lê as medidas de um triângulo e retorna um array com as medidas
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            double[] medidas = new double[3];
            
            // Solicita ao usuário que entre com as medidas do triângulo
            Console.WriteLine("Entre com as medidas do Triangulo " + nomeTriangulo + ":");
            
            // Lê as medidas e armazena no array
            for (int i = 0; i < 3; i++)
            {
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            
            return medidas;
        }
        
        // Calcula a área de um triângulo com base nas medidas dos lados
        public static double CalcularAreaTriangulo(double[] medidas)
        {
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];
            
            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            
            return area;
        }
    }
}
