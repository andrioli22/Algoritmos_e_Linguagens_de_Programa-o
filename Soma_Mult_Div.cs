{
    class Program
    {
        static void Main(string[] args)
        {
            Double  num1, num2, soma, mult, div, sub;
            Console.WriteLine("digite o primeiro numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("sua soma é");
            soma = num1 + num2;
            Console.WriteLine(soma);
            Console.WriteLine("sua subtracao é");
            sub = num1-num2;
            Console.WriteLine(sub);
            Console.WriteLine("sua multiplicacao é");
            mult = num1*num2;
            Console.WriteLine(mult);
            Console.WriteLine("sua divisao é");
            

        }
    }
}




