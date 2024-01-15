{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, percentual, mult, soma, div;
            Console.WriteLine("Insira seu salario");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o percenual de aumento");
            percentual = double.Parse(Console.ReadLine());
            div = percentual / 100;
            mult = salario * div;
            soma = salario + mult;
            Console.Write("Seu salario novo é");
            Console.WriteLine(soma);
        }
    }
}
