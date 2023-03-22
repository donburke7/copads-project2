
namespace PrimeGen
{
    class PrimeGen {
        public static void Main(string[] args)
        {
            if (args.Length >= 1) {
                int bits = 0;
                int count = 1;
                try {
                    bits = int.Parse(args[0]);
                    if (args.Length > 1) {
                        count = int.Parse(args[1]);
                    }
                } catch (FormatException) { }

                if (bits % 8 == 0 && bits >= 32) {
                    Console.WriteLine("BitLength: {0} bits", bits);
                    //...
                }
                else {
                    PrintHelp();
                }

            } 
            else {
                PrintHelp();
            }
        }

        public static void PrintHelp() {
            Console.WriteLine("Usage: dotnet run <bits> <count=1>");
            Console.WriteLine("     - bits = the number of bits of the prime number, " +
                "this must be a multiple of 8, and at least 32 bits");
            Console.WriteLine("     - count = the number of prime numbers to generate, defaults to 1");
        }

    }
}