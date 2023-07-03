namespace MétodosFunções
{
    internal class Program
    {
        static void MainMenu()
        {
            Console.WriteLine("+---+-----------------+");
            Console.WriteLine("| 1 |     Adição      |");
            Console.WriteLine("| 2 |    Subtração    |");
            Console.WriteLine("| 3 |  Multiplicação  |");
            Console.WriteLine("| 4 |     Divisão     |");
            Console.WriteLine("| 5 |      Sair       |");
            Console.WriteLine("+---+-----------------+");
        }

        static double Sum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine(sum);
            return sum;
        }

        static double Sub(double x, double y)
        {
            double sub = x - y;
            Console.WriteLine(sub);
            return sub;
        }

        static double Mult(double x, double y) 
        { 
            double mult = x * y;
            Console.WriteLine(mult);
            return mult;
        }

        static double Div(double x, double y)
        {
            double div = x / y;
            Console.WriteLine(div);
            return div;
        }


        static void Main(string[] args)
        {
            double n1, n2, res;
            int option;

            do
            {
                Console.WriteLine("Calculadora \n\n");
                Console.Write("Digite o primeiro valor: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                n2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a operação que deseja!");
                MainMenu();
                Console.Write("Código da operação: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("A soma dos valor " + n1 + " + " + n2 + " = " + Sum(n1, n2));
                        break;
                    case 2:
                        Console.Write("A subtração dos valores " + n1 + " - " + n2 + " = " + Sub(n1, n2));
                        break;
                    case 3:
                        Console.Write("A multiplicação dos valores " + n1 + " * " + n2 + " = " + Mult(n1, n2));
                        break;
                    case 4:
                        if (n1 != 0)
                        {
                            Console.Write("A divisão dos valores " + n1 + " / " + n2 + " = " + Div(n1, n2));
                        }
                        else
                        {
                            Console.WriteLine("Impossivel dividir número por zero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }

            } while (option != 5);
        }
    }
}