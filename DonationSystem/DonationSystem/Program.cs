namespace DonationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donation System");

            //Menu
            int option;
            Console.WriteLine("Insira o que deseja");
            Console.WriteLine("+-----+----------------------------+");
            Console.WriteLine("|  1  |   Registrar um novo user   |");
            Console.WriteLine("|  2  |           Login            |");
            Console.WriteLine("|  3  |          Logout            |"); 
            Console.WriteLine("+-----+----------------------------+");

            Console.Write("Opção: ");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Insira seu nome: ");
                string name = Console.ReadLine();
                Console.WriteLine("Insira seu apelido: ");
                string nickName = Console.ReadLine();
                Console.WriteLine("Insira seu e-mail: ");
                string email = Console.ReadLine();
                Console.WriteLine("Insira seu telefone: ");
                string cellphone = Console.ReadLine();
                Console.WriteLine("Insira seu senha: ");
                string password = Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine();
                Console.Write("Insira e-mail: ");
                string emailLogin = Console.ReadLine(); 
                Console.Write("Insira senha: ");
                string passwordLogin = Console.ReadLine();

                if (emailLogin.Equals("admin@fiap.com.br") && passwordLogin.Equals("admin123"))
                {
                    Console.WriteLine("Bem vindo ao sistema sr." + emailLogin);
                }else
                {
                    Console.WriteLine("Usuário e/ou senha inválidos"); 
                }
            }



        }
    }
}