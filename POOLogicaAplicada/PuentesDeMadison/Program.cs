namespace PuentesMadisonApp
{
    using PuentesMadison;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Ingrese el puente: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    continue;
                }

                List<char> estructura = new List<char>(input.ToCharArray());

                try
                {
                    var puente = new Puente(estructura);
                    Console.WriteLine("VALIDO");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}