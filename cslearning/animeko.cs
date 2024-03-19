List<string> animeList = new List<string>();


void WelcomeMessage()
{
    Console.WriteLine("******************");
    Console.WriteLine(@"
    |\__/,|   (`\
  _.|o o  |_   ) )
-(((---(((--------
");
    Console.WriteLine("******************");
    Console.WriteLine("Qual opção deseja?");
}

void OptionsMenu()
{
    Console.WriteLine("\nDigite 1 para Cadastrar um Anime");
    Console.WriteLine("Digite 2 para Listar todos Animes");
    Console.WriteLine("Digite 3 para Excluir um Anime");
    Console.WriteLine("Digite 4 para sair");
    Console.Write("Sua opção: ");
    string userOption = Console.ReadLine()!;
    string animeName;

    try
    {
        int userOptionNumber = int.Parse(userOption);
        switch (userOptionNumber)
        {
            case 1:
                Console.Clear();
                Console.Write("Digite o anime que deseja adicionar: ");
                animeName = Console.ReadLine()!;
                animeList.Add(animeName);
                Console.Clear();
                Console.WriteLine($"{animeName} foi adicionado a lista.");
                Thread.Sleep(500);
                Console.WriteLine("Aperte qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
                OptionsMenu();


                break;
            case 2:
                Console.WriteLine("Lista de animes:\n");
                for (int i = 0; i < animeList.Count; i++)
                {
                    Console.WriteLine(animeList[i]);
                };
                Console.WriteLine("Aperte qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
                OptionsMenu();
                break;
            case 3:
                Console.WriteLine($"Escolheu a {userOptionNumber} opção.");
                break;
            case 4:
                Console.WriteLine("Tchau, até a próxima! :)");
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
    catch(FormatException)
    {
        Console.WriteLine("Você deve digitar um número.");
        Thread.Sleep(1000);
        Console.Clear();
        OptionsMenu();
    }


}


WelcomeMessage();
OptionsMenu();