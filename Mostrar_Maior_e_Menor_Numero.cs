public class Mostrar_Maior_e_Menor_Numero
{
    public static void Main(string[] args)
    {
          
    int n1, n2, n3, resultado;
Console.WriteLine("Digite o primeiro numero");
n1= int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
n2= int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro numero");
n3=int.Parse(Console.ReadLine());
resultado = m(n1,n2,n3);
Console.WriteLine(resultado);

    }
    
        public static int m (int n1, int n2, int n3)
{
    if (n1>n2 && n2>n3) { Console.WriteLine ("{0}",n3); }
    if (n1>n3 && n3>n2) {Console.WriteLine("{0}",n2);}
    if (n2>n1 && n1>n3) {Console.WriteLine("{0}",n3);}
    if (n2>n3 && n3>n1) {Console.WriteLine("{0}",n1);}
    if (n3>n1 && n1>n2) {Console.WriteLine("{0}",n2);}
    if (n3>n2 && n2>n1) {Console.WriteLine("{0}",n1);}
    return 00;
}
}
