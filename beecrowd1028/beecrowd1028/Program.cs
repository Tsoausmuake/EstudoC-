using System;

namespace beecrowd1028
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i, m1, m2;

            for (i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int f1 = int.Parse(vet[0]);
                int f2 = int.Parse(vet[1]);
                m1 = f1;
                m2 = f2;
                bool test = true;
                bool test2 = false;

                while (test == true)
                {
                    if (test2 == true)
                    { //fazendo um teste para dar entrada novamente nos valores, em caso de entrada de valores inválidos.

                        vet = Console.ReadLine().Split(' ');
                        f1 = int.Parse(vet[0]);
                        f2 = int.Parse(vet[1]);
                        Console.WriteLine("----------------------------");
                    }
                    //-----------------------------------------------------------------------------------------------------------------------------

                    if (f1 % 2 == 0 && f2 % 2 == 0)
                    {
                        if (f1 > f2)
                        {
                            m2--;
                            while (f2 % m2 != 0)
                            {
                                m2--;
                                if (f2 % m2 == 0)
                                {
                                    Console.WriteLine(f2 / m2);

                                }
                                else
                                {
                                    m2--;
                                }
                            }
                            test = false;
                            test2 = false;
                            Console.WriteLine("----------------------------");
                        }
                        else
                        {

                            m1--;

                            while (f1 % m1 != 0)
                            {
                                m1--;
                                if (f1 % m1 == 0)
                                {
                                    Console.WriteLine(f1 / m1);
                                }


                            }
                            test = false;
                            test2 = false;
                            Console.WriteLine("----------------------------");
                        }
                    }
                    else if (f1 % 2 != 0 && f2 % 2 != 0)
                    {
                        if (f1 > f2)
                        {
                            m2--;

                            while (f2 % m2 != 0)
                            {
                                m2--;
                                if (f2 % m2 == 0)
                                {
                                    Console.WriteLine(f2 / m2);
                                }


                            }
                            test = false;
                            test2 = false;
                            Console.WriteLine("----------------------------");
                        }
                        else
                        {

                            m1--;

                            while (f1 % m1 != 0)
                            {
                                m1--;
                                if (f1 % m1 == 0)
                                {
                                    Console.WriteLine(f1 / m1);
                                }


                            }
                            test = false;
                            test2 = false;
                            Console.WriteLine("----------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("Dados Incompatíveis com o teste: ");
                        Console.WriteLine($"Entre novamente com 2 valores inteiros: ");
                        Console.WriteLine($"Ainda restam {n - i} entradas de dados: ");
                        test = true;
                        test2 = true;
                        Console.WriteLine("----------------------------");
                    }
                }
            }
        }
    }
}
