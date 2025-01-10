//Aplicativo Alura - Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

//Criando uma lista
//List<String> ListaDasBandas = new List<string>();
//Carregando a lista
List<String> ListaDasBandas = new List<string> { "Harpa Cristã"};


//https://fsymbols.com/pt/geradores/
//quando utilizamos o @ antes
//queremo mostra o string com ele esta
//Verbativo literal





//criando uma função
//quando eu quero que não retorne nada eu utilizo o void
void ExibirLogo() {
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu() {
    ExibirLogo();
    Console.WriteLine("\n Digite 1 para registra uma banda" );
    Console.WriteLine("Digite 2 para mostra todas as bandas");
    Console.WriteLine("Digite 3 para para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine( "\n Digite a sua opção :");
    //o Console.ReadLine permite que digitamos um nulo
    //O ponto de exclamação (!) no final de Console.ReadLine() em
    //C# indica a utilização do operador de nulidade nula (!) para suprimir a verificação de nulidade.
    //! não quero trabalhar com valor nulo
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    //if (opcaoEscolhidaNumerica == 1) {
    //    Console.WriteLine("Voce digitou a opção " + opcaoEscolhida);
    //}

    switch (opcaoEscolhidaNumerica) {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistras();
            break;
        case 3:
            Console.WriteLine("Voce digitou a opção " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Voce digitou a opção " + opcaoEscolhida);
            break;
        case - 1:
            Console.WriteLine("Voce digitou a opção " + opcaoEscolhida);
            break;
        default:
            Console.WriteLine("opcao invalida " + opcaoEscolhida);
            break;
    }


}

void RegistrarBanda()
{
    //limpando
    Console.Clear();
    Console.WriteLine("*************************");
    Console.WriteLine("Registro de Banda ");
    Console.WriteLine("*************************");
    Console.Write("Digite o nome da banda que deseja registra ");
    String nomeDaBanda = Console.ReadLine()!;
    ListaDasBandas.Add(nomeDaBanda);
    //itilizando interpolação de string
    //começa com $ e onde esta a variaveil coloco a chaves{}
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    //Thread.Sleep(2000); faz com que a execução durma ou pause por um determinado período de tempo.
    //Thread.Sleep(2000); milissegundos (ms), ou seja, 2000 ms, que equivalem a 2 segundos.
    Thread.Sleep(2000);
    //limpando
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistras()
{
    Console.Clear();
    Console.WriteLine("*************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("*************************\n");
    //percore um lista
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (string banda in ListaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();



}

ExibirOpcoesDoMenu();