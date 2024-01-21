namespace Monto_por_cada_pais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Ingrese un número para generar los números ordinales hasta ese número: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    for (int i = 1; i <= numero; i++)
                    {
                        string ordinal = CardinalToOrdinal(i);
                        Console.Write($"{ordinal} ");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                }
            }

            static string CardinalToOrdinal(int numero)
            {
                if (numero <= 0)
                {
                    return numero.ToString();
                }

                
                string ordinalSuffix = "th";
                int ultimaCifra = numero % 10;
                int ultimasDosCifras = numero % 100;

                if (ultimaCifra == 1 && ultimasDosCifras != 11)
                {
                    ordinalSuffix = "st";
                }
                else if (ultimaCifra == 2 && ultimasDosCifras != 12)
                {
                    ordinalSuffix = "nd";
                }
                else if (ultimaCifra == 3 && ultimasDosCifras != 13)
                {
                    ordinalSuffix = "rd";
                }


                return $"{numero}{ordinalSuffix}";
            }
        }
    }
}