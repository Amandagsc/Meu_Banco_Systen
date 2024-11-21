namespace Meu_Banco_Systen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("Bem Vindo ao Banco Systen!");
            Console.WriteLine("Selecione a Opcção Desejada:\n1 - Consultar Saldo\n2 - Fazer Depósito\n3 - Saque\n4 - Transferência");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Este é o seu saldo!");
                    break;
                case 2:
                    Console.WriteLine("Qual valor deseja Depositar?");
                    break;
                case 3:
                    Console.WriteLine("Qual valor deseja sacar?");
                    break;
                case 4:
                        Console.WriteLine("Para qual conta deseja transferir?");
                    break;
                

                default:
                    Console.WriteLine("Fim do Programa!");
                    break;
            }
        }
    }
}