namespace ConversionRomanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero romano: ");
            string? numRomano = Console.ReadLine().ToUpper().Trim();

            int numeroConvertido = ConversionesHelper.ConvertirRomanoDecimal(numRomano);    

            if (numeroConvertido != -1)
            {
                Console.WriteLine ($"El numero romano {numRomano} en decimal es {numeroConvertido}");
                return;
            }

            Console.WriteLine("Numero romano no valido");
        }
    }
}
