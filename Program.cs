Console.WriteLine("Qual o nome do aluno(a)? ");
string? nome = Console.ReadLine();

string? continuar = "s";

do
{
    Console.WriteLine("Quantas notas voce deseja adicionar? ");
    int num_notas;
    if(!int.TryParse(Console.ReadLine(), out num_notas) || num_notas <= 0)
    {
        Console.WriteLine("Valor invalido, digite outro valor.");
        continue;
    }

    double notas_soma = 0;
    int i = 0;
    while(i < num_notas)
    {
        Console.WriteLine($"Qual valor da {i+1}° nota: (0-10)");
        double nota_aux;
        if(!Double.TryParse(Console.ReadLine(), out nota_aux) || nota_aux < 0 || nota_aux > 10)
        {
            Console.WriteLine($"Valor da {i+1}° nota invalido... digite novamente");
            continue;
        }
        notas_soma += nota_aux;
    
        ++i;
    }
    
    double nota_final = (notas_soma / num_notas);

    string status;
    if(nota_final >= 6.0)
        status = "Aprovado(a)";
    else
        status = "Recuperacao";
    
    Console.WriteLine(  $"| Aluno(a):..... {nome}\n" +
                        $"| Nota Final:... {nota_final.ToString("F")}\n" +
                        $"| Status:....... {status}");

    Console.WriteLine("\nDeseja continuar adicionando alunos e notas? (s/n)");
    continuar = Console.ReadLine();

    if(continuar != "s" && continuar != "n")
        Console.WriteLine("Valor invalido");
        
    }while(continuar == "s");

Console.WriteLine("Terminando... volte sempre!");

