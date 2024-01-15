Escreva um programa que informe a categoria de um jogador de futebol,
considerando sua idade: infantil (até 13 anos), juvenil (até 17 anos) ou sênior
(acima de 17 anos).


{
        int idade;
       Console.WriteLine("Insira a idade");
       idade = int.Parse(Console.ReadLine());
       if (idade>17)
       {
           Console.WriteLine("senior");
       }
       else
       if (idade<=13)
       {
           Console.WriteLine("infantil");
       }
       else 
       {
           Console.WriteLine("juvenil");
       }
        
        
    }
