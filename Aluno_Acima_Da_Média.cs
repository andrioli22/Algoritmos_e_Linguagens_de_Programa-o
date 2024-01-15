using System;
					
public class Program
{
	public static void Main()
	{
		double num, soma=0, media;
    int i=0;
   
    while (i<10)
    {
        Console.WriteLine("digite os valores");
        num = double.Parse (Console.ReadLine());
		soma = soma+num;
        i++; 
    }
		Console.WriteLine(soma/12);
		media = soma/10;
		if (num>media)
			{
				
		for (int x = 0;x>media;x++)
		{
			Console.WriteLine("alunos acima da media{0}", x);
							  }
			} 
		
	
		
	}
}
