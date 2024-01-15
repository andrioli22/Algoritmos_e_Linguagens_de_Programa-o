{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, mult;
            Console.WriteLine("insira o número do primeiro lado do quadrado");
            lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("insira o número do segundo lado do quadrado");
            lado2 = double.Parse(Console.ReadLine());
            Console.Write("A área do quadrado é:");
            mult = lado1 * lado2;
            Console.WriteLine(mult);
            

        }
    }
}
