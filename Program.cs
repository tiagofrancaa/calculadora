using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Entre com o número de X e Y: ");
             string[] vect = Console.ReadLine().Split(" ");
             double x = double.Parse(vect[0], CultureInfo.InvariantCulture);
             double y = double.Parse(vect[1], CultureInfo.InvariantCulture);
             Operaçoes n = new Operaçoes(x, y);
             System.Console.WriteLine();
             System.Console.WriteLine("1-Soma");
             System.Console.WriteLine("2-Subtração");
             System.Console.WriteLine("3-Multiplicação");
             System.Console.WriteLine("4-Divisão");
             System.Console.WriteLine();
             System.Console.Write("Escolha uma operação com base no número de tal: ");
             int oper = int.Parse(Console.ReadLine());
             double result = 0.0;
             switch (oper){
                 case 1:
                     result = n.Sum(oper);
                     break;
                 case 2:
                     result = n.Subtract(oper);
                     break;
                 case 3:
                     result = n.Multiplic(oper);
                     break;
                 case 4:
                     result = n.Divide(oper);
                     break;
                 default:
                     System.Console.WriteLine("Operação Inválida!");
                    break;
             }
             System.Console.WriteLine();
             System.Console.WriteLine("Resultado da operação: " + result.ToString("F2", CultureInfo.InvariantCulture));
             
        }
    }
}
