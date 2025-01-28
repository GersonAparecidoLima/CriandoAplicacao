//Aplicativo Alura - Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

//Criando uma lista
//List<String> ListaDasBandas = new List<string>();
//Carregando a lista
//List<String> ListaDasBandas = new List<string> { "Harpa Cristã"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Fernadinho",new List<int> { 10,8,9});
bandasRegistradas.Add("Marquinhos Gomes", new List<int>());

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
    Console.WriteLine("\nDigite 1 para registra uma banda: " );
    Console.WriteLine("Digite 2 para mostra todas as bandas: ");
    Console.WriteLine("Digite 3 para para avaliar uma banda: ");
    Console.WriteLine("Digite 4 para exibir a média de uma banda: ");
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
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case - 1:
            Console.WriteLine("Tchau tchau");
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
    ExibirTituloDaOpcao("Registro de Banda");
    Console.Write("Digite o nome da banda que deseja registra ");
    String nomeDaBanda = Console.ReadLine()!;

    //estamos adicionando elemento para Lista
    //ListaDasBandas.Add(nomeDaBanda);

    //estamos adicionando elemento para dicionario
    //lembando que temos dois argumentos, no 
    //caso o nome(chave), e uma lista de notas
    bandasRegistradas.Add(nomeDaBanda, new List<int>());


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
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    //percore um lista
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();



}

void ExibirTituloDaOpcao( string titulo)
{
    //buscando a quantidade de letra do titulo
    int quantidadeDeLetra = titulo.Length;

    //criando uma string vazia
    //PadLeft adicionando quantidade de caracter a esquerda
    //passa dois parametros 1 quantidade de caracter 2 e o caracter
    string asterisco = string.Empty.PadLeft(quantidadeDeLetra, '*');
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco + "\n");

}

void AvaliarUmaBanda() { 
//digite qual banda deseja avaliar
//sea a banda exitir no dicionario >> atribuir uma nota
//senão, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    //quando colocamos o ! nos queremos uma string e não um valor
    string nomeDaBanda = Console.ReadLine()!;
    //verificado se tem a banda na lista
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        //Quando eu utilizo colchete eu acesso a segunda parte do dicionario
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine( $"\nA nota {nota} foi registrada com sucesso para a banda{nomeDaBanda}" );
        //esperando
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encotrado!");
        Console.WriteLine("Digite uam tecla para volta ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.WriteLine("Digite o nome da banda que deseja exibir a média");
    string nomeDaBanda = Console.ReadLine()!;
    //Verifica se a banda existe
    if (bandasRegistradas.ContainsKey(nomeDaBanda)) {
    
    List<int> notasDaBanda = bandasRegistradas [nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()} ");
        Console.WriteLine("Digite uma tecla para volta para ao menu principla");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encotrado!");
        Console.WriteLine("Digite uam tecla para volta ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }



}

ExibirOpcoesDoMenu();