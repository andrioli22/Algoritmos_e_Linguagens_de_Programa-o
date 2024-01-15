{
        double n1, n2;
        Console.WriteLine("Insira o primeiro numero");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo numero");
        n2 = double.Parse(Console.ReadLine());
        if (n1>n2)
        {
            Console.WriteLine("{0} e maior que {1}",n1,n2);
        }
        else
        {
            Console.WriteLine("{0} e maior que {1}",n2,n1);
        }
    }
