
{
    class Program
    {
        static void Main(string[] args)
        {
            double basemaior, basemenor, altura, mult, soma, div;
            Console.WriteLine("Insira a base maior do trapézio");
            basemaior = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a base menor do trapézio");
            basemenor = double.Parse(Console.ReadLine());
            soma = basemaior + basemenor;
            Console.WriteLine("Insira a altura do trapézio");
            altura = double.Parse(Console.ReadLine());
            mult = soma * altura;
            div = mult / 2;
            Console.Write("A área do trapézio é:");
            Console.WriteLine(div);
