 public static void Main(string[] args)
    {
        double Celsius, result;
        Console.WriteLine("digite a temperatura em celsius");
        Celsius = double.Parse(Console.ReadLine());
        result = farenheight(Celsius);
        Console.WriteLine("sua temperatura em farenheight é {0}",result);
        
        
    }
    public static double farenheight (double Celsius)
{
    return (9*Celsius+160)/5;
}
}
