// cream sound

string mensagemDeBoasVindas = "boas vindas ao sreen sound";
// List<string> ListasDasBandas = new List<string> { "U2", "Calypso"};
Dictionary<String, List<int>> bandasRegistradas = new Dictionary<String, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new list<int>());
void ExibirLogo()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");
    Console.WriteLine(mensagemDeBoasVindas);

}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    // mostra na tela as mensagens
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção");
    // input que recebe a opção mostrada acima
    string opcaoEscolhida = Console.ReadLine()!;
    // transforma o input que entrou na variavel acima para numerica
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    // logica se/senão
    //if (opcaoEscolhidaNumerica == 1)
    //{
    //    Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    //}
    //else if (opcaoEscolhidaNumerica == 2)
    //{
    //    Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    //}

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda(); // efetua a função RegistrarBanda
            break; //termina

        case 2:
            MostrarBandasRegistradas();
            break;

        case 3:
            AvaliarUmaBanda();
            break;

        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;

        case 0:
            Console.WriteLine("Você deseja sair! bye bye :) " + opcaoEscolhidaNumerica);
            break;

        default:
            Console.WriteLine("Opção invalida! Digite um número Valido");
            break;
    }
}

void RegistrarBanda()
{   //função para registrar os nomes das bandas
    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("Digite o nome da banda que deseja Registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new list<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000); //demora para aparecer a proxima coisa
    Console.Clear(); // limpa o console
    ExibirOpcoesDoMenu(); // volta para o menu

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas Registradas");
    //for (int i = 0; i < ListasDasBandas.Count; i++) // int variavel i recebe 0; enquanto o i for menor que o numero de bandas; i recebe mais 1
    //{
    //    Console.WriteLine($"Banda: {ListasDasBandas[i]}");

    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu proincipal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void ExibirTituloDaOpcao(string titulo)
{
    int qtdDeLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(qtdDeLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
}
void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    // se a banda exite no dicionario >> atribuir uma nota
    //senão, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar:");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {

    }
    else
    {
        Console.WriteLine($"A Banda {nomeDaBanda} não foi Encontrada");
        Console.WriteLine("Digite uma teclada para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
ExibirOpcoesDoMenu();


