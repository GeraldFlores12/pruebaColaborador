using System;

namespace lab3_semana1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ancho = 0, alto = 0, area = 0, perimetro = 0;
            String entrada = "";
            sumas ins = new sumas();

            Console.WriteLine("Ingrese el ancho: ");
            entrada = Console.ReadLine();
            ancho = Convert.ToDouble(entrada);
            Console.WriteLine("Ingrese el alto: ");
            entrada = Console.ReadLine();
            alto = Convert.ToDouble(entrada);

            ins.calcularArea(ancho,alto);
            ins.calcularPerimetro(ancho, alto);
            Console.WriteLine("el Area es: {0}", ins.area);
            Console.WriteLine("el perimetro es {0}", ins.perimetro);
            Console.ReadKey();
        }
    }
}
