using System;

class Aluno 
{
    public string Nome { get; set; } = "";
    public int Idade { get; set; }
    public int Ativo { get; set; }

}
class Program
{
    const int QuantMaxAlunos = 3;
    const int QuantMaxDisc = 3;



    static string[] disciplinas =
    {
    "Logica de programação",
    "Banco de dados",
    "Programação em C#"
    };

    static Aluno[] alunos = new Aluno[QuantMaxAlunos];

    static double[,] notas = new double[QuantMaxAlunos, QuantMaxDisc]; //matriz [,] notas valores com casa decimal.


    static void Main()
    {
         InicializarDados();

        int opcao = 0;

        do
        {
            Console.Clear();
            ExibirMenu();

            Console.Write("Digite a opção desejada: ");
            while (!int.TryParse(Console.ReadLine(), out opcao)); //enquanto a conversão deu errado, faça
            {
                Console.Write("Opção Inválida! Digite um número!");
            }
            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    // CadastrarAluno();
                    break;
                case 2:
                    // LancarNotas();
                    break;
                case 3:
                    //ConsultarResultado();
                    break;
                case 0:
                    Console.WriteLine("Programa Encerado");
                    break;
                default:
                    Console.WriteLine("Opção Inexixtente");
                    break;
            }
            if (opcao != 0)
            {
                Console.WriteLine("Precione ENTER para continuar");
                Console.ReadLine();
            }

        } while (opcao != 0);
    }
    static void ExibirMenu()
    {
        Console.WriteLine("================================");
        Console.WriteLine("SISTEMA DE ALUNOS E NOTAS - C#");
        Console.WriteLine("================================");
        Console.WriteLine("1 - Cadastrar aluno");
        Console.WriteLine("2 - Lançar notas");
        Console.WriteLine("3 - Consultar resultado");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("================================");
    }
    static void InicializarDados()
    {
        //Cria um objeto em cada objeto do array
        for (int i = 0; i < alunos.Length; i++);
    }


}
