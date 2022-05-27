namespace Aula27_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome da pessoa: "); string n = Console.ReadLine();
            Console.Write("Digite a idade de {0}: ", n); int i = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura de {0}: ", n); double a = double.Parse(Console.ReadLine());
           
            Pessoa pessoa = new Pessoa(n, i, a);

            Console.WriteLine("\n\n*** Dados da Pessoa ***\n");
            Console.WriteLine(pessoa.ToString());

            Console.ReadKey();
        }
    }
}