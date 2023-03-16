namespace DiamantesDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, x, espacos;

            while (true)
            {

                Console.WriteLine("Digite um número impar: ");
                numero = int.Parse(Console.ReadLine());


                if (numero % 2 == 1)
                {
                    x = 1;
                    espacos = (numero - 1) / 2;
                    for (int linha = 1; espacos > 0; linha++)
                    {

                        for (int i = 1; i <= espacos; i++)
                        {
                            Console.Write(" ");
                        }


                        for (int i = 1; i <= x; i++)
                        {
                            Console.Write("x");
                        }

                        espacos--;
                        x += 2;
                        Console.WriteLine();
                    }

                    for (int j = 1; x > 0; j++)
                    {


                        for (int i = 1; i <= espacos; i++)
                        {
                            Console.Write(" ");
                        }


                        for (int i = 1; i <= x; i++)
                        {
                            Console.Write("x");
                        }

                        espacos++;
                        x -= 2;
                        Console.WriteLine();
                    }
                }

                else
                {
                    Console.WriteLine("O número digitado não é impar! ");
                }
                Console.ReadLine();
                continue;
            }
        }
    }
}
