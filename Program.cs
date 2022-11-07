try
{
    string? continuar;

    do
    {
        Console.WriteLine("Qual o nome do aluno? ");
        string? nome = Console.ReadLine();
        
        Console.WriteLine("Quantas notas voce deseja adicionar? ");
        int num_notas = Convert.ToInt32(Console.ReadLine());
        
        double notas_soma = 0;
        int i = 0;
        while(i < num_notas)
        {
            Console.WriteLine($"Qual valor da nota {i}: ");
            notas_soma += Convert.ToDouble(Console.ReadLine());
        
            ++i;
        }
        double nota_final = (notas_soma / num_notas);
        string status;
        if(nota_final >= 6.0)
            status = "Aprovado";
        else
            status = "Recuperacao";
        
        Console.WriteLine($"| Aluno: {nome}\n" +
                            $"| Nota Final: {nota_final.ToString("F")}\n" +
                            $"| Status: {status}");
    
        Console.WriteLine("\nDeseja continuar adicionando alunos e notas? (s/n)");
        continuar = Console.ReadLine();
    
        if(continuar != "s" && continuar != "n")
            Console.WriteLine("Valor invalido");
            
        }while(continuar == "s");
}
catch(Exception)
{
    Console.WriteLine("Valor invalido");
}

Console.WriteLine("Terminando... volte sempre!");

