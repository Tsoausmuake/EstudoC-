using System;
using System.Globalization;

namespace URIExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            //URI 1001
            /*
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int X = A + B;

            Console.WriteLine("X = " + X);
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            /*
            //URI 1002
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * (Math.Pow(raio, 2.0));

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            /*
            //URI 1003
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            /*
            //URI 1004
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int PROD = A * B;

            Console.WriteLine("PROD = " + PROD);
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            /*
            //URI 1005
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaA = A * 3.5 / 11;
            double notaB = B * 7.5 / 11;

            double media = notaA + notaB;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            /*
            //URI 1006

            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaA = A * 2 / 10;
            double notaB = B * 3 / 10;
            double notaC = C * 5 / 10;
            double media = notaA + notaB + notaC;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            /*
            //URI 1007

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int prodAB = A * B;
            int prodCD = C * D;

            int diferencaABCD = prodAB - prodCD;

            Console.WriteLine("DIFERENCA = " + diferencaABCD);
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            /*
            //URI 1008

            int numeroDoFuncionario = int.Parse(Console.ReadLine());
            int horasDeTrabalho = int.Parse(Console.ReadLine());
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horasDeTrabalho * valorPorHora;


            Console.WriteLine("NUMBER = " + numeroDoFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            */

            //---------------------------------------------------------------------------------------------------------------------------------------------------------

            /*
            //URI 1009

            string nomeDoVendedor = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorDeVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double comissao = valorDeVendas * 0.15;

            double salarioFinal = salarioFixo + comissao;


            Console.WriteLine("TOTAL = R$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            /*
            //URI 1010

            string[] vet = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            int codigoDoProduto = int.Parse(vet[0]);
            int qntDeProdutos = int.Parse(vet[1]);
            double preco = double.Parse(vet[2], CultureInfo.InvariantCulture);

            int codigoDoProduto1 = int.Parse(vet2[0]);
            int qntDeProdutos1 = int.Parse(vet2[1]);
            double preco1 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valorTotalPagar = qntDeProdutos * preco + qntDeProdutos1 * preco1;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotalPagar.ToString("F2", CultureInfo.InvariantCulture));
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            //URI 1011
            /*
            int R = int.Parse(Console.ReadLine());
            double pi = 3.14159;
            double volume = 4.0 / 3 * pi * (Math.Pow(R, 3));

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            //URI 1012
            /*
            string[] vet = Console.ReadLine().Split(' ');

            double A = double.Parse(vet[0]);
            double B = double.Parse(vet[1]);
            double C = double.Parse(vet[2]);
            double pi = 3.14159;

            double areaTriangulo = A * C / 2;
            double areaCirculo = pi * (Math.Pow(C, 2));
            double areaTrapezio = ((A + B) * C) / 2;
            double areaQuadrado = B * B;
            double areaRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            */

            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            //URI 1013
            /*

            string[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int Abs = int.Parse(vet[2]);

            int maior = (A + B + Abs * (A - B)) / 2;

            if (A > B && A > Abs)
            {
                Console.WriteLine(A + " eh o maior");
            }
            else if(B > A && B > Abs)
            {
                Console.WriteLine(B + " eh o maior");
            }
            else 
            {
                Console.WriteLine(Abs + " eh o maior");
            }

            if (maior > Abs)
            {
                Console.WriteLine(maior + " eh o maior");
            }
            else
            {
                Console.WriteLine(Abs + " eh o maior");
            }
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            //URI 1014
            /*
            int distancia = int.Parse(Console.ReadLine());
            double combustivelGasto = double.Parse(Console.ReadLine());

            double kml = distancia / combustivelGasto;

            Console.WriteLine(kml.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            //URI 1015
            /*
            string[] vet = Console.ReadLine().Split(' ');
            string[] vet1 = Console.ReadLine().Split(' ');

            double x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            double x2 = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(vet1[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            //URI 1016
            /*
            int distancia = int.Parse(Console.ReadLine());

            int distanciaEntreCarros = distancia * 2;

            Console.WriteLine(distanciaEntreCarros + " minutos");
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            //URI 1017
            /*
            int tempoGasto = int.Parse(Console.ReadLine());
            int velocidadeMedia = int.Parse(Console.ReadLine());

            int espacoPercorrido = velocidadeMedia * tempoGasto;
            double gastoDeCombustivel = espacoPercorrido / 12.0;

            Console.WriteLine(gastoDeCombustivel.ToString("F3", CultureInfo.InvariantCulture));
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            //URI 1018
            /*
            int valor = int.Parse(Console.ReadLine());

            int nota100 = valor / 100;
            int resto100 = valor % 100;

            int nota50 = resto100 / 50;
            int resto50 = resto100 % 50;

            int nota20 = resto50 / 20;
            int resto20 = resto50 % 20;

            int nota10 = resto20 / 10;
            int resto10 = resto20 % 10;

            int nota5 = resto10 / 5;
            int resto5 = resto10 % 5;

            int nota2 = resto5 / 2;
            int resto2 = resto5 % 2;

            int nota1 = resto2 / 1;
            int resto1 = resto2 % 1;

            Console.WriteLine(nota100 + " nota (s) de R$ 100,00");
            Console.WriteLine(nota50 + " nota (s) de R$ 50,00");
            Console.WriteLine(nota20 + " nota (s) de R$ 20,00");
            Console.WriteLine(nota10 + " nota (s) de R$ 10,00");
            Console.WriteLine(nota5 + " nota (s) de R$ 5,00");
            Console.WriteLine(nota2 + " nota (s) de R$ 2,00");
            Console.WriteLine(nota1 + " nota (s) de R$ 1,00");
            */
            /*
            CultureInfo culture = new CultureInfo("en-US");

            int valor = 0;
            int[] valores = new int[] {100, 50, 20, 10, 5, 2, 1 };
            int[] cedulas = new int[7];

            int.TryParse(Console.ReadLine(), out valor);

            int _valor = valor;

            for (int i = 0; i < valores.Length; i++)
            {
                if ((_valor / valores[i]) > 0)
                {
                    cedulas[i] = (_valor / valores[i]);
                    _valor = _valor % valores[i];

                }
                else
                {
                    cedulas[i] = 0;
                }
            }

            Console.WriteLine(String.Format("{0}", valor));

            for (int i = 0; valores.Length > i; i++)
            {
                Console.WriteLine(String.Format("{0} nota(s) de R$ {1}", cedulas[i], (double.Parse(valores[i].ToString())).ToString("F2", culture)));
            }
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            //URI 1019
            /*
            int horas, minutos, segundos, resto;

            int N = int.Parse(Console.ReadLine());


            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
            */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            //URI 1020

            /*
            int idade, dias, meses, anos, anos_;

            idade = int.Parse(Console.ReadLine());

            anos = idade / 365;
            anos_ = idade % 365;

            meses = anos_ / 30;
            dias = anos_ % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dias(s)");
            */

            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            //URI 1021

            /*
             decimal N, quociente, resto, nota;

            N = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTAS:");

            resto = N;

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(Math.Floor(quociente) + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto %= nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine(Math.Floor(quociente) + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto %= nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine(Math.Floor(quociente) + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto %= nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine(Math.Floor(quociente) + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto %= nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine(Math.Floor(quociente) + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto %= nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine(Math.Floor(quociente) + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto %= nota;

            Console.WriteLine("MOEDAS:");

            nota = 1;
            quociente = resto / nota;
            Console.WriteLine(Math.Floor(quociente) + " moeda(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto %= nota;

            nota = 0.5M;
            quociente = resto / nota;
            Console.WriteLine(Math.Floor(quociente) + " moeda(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto %= nota;

            nota = 0.25M;
            quociente = resto / nota;
            Console.WriteLine(Math.Floor(quociente) + " moeda(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto %= nota;

            nota = 0.10M;
            quociente = resto / nota;
            Console.WriteLine(Math.Floor(quociente) + " moeda(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto %= nota;

            nota = 0.05M;
            quociente = resto / nota;
            Console.WriteLine(Math.Floor(quociente) + " moeda(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto %= nota;

            nota = 0.01M;
            quociente = resto / nota;
            Console.WriteLine(Math.Floor(quociente) + " moeda(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto %= nota;

                        */
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            //URI 1061

            Console.Write("Dia ");
            int diaInicio = int.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(" : ");
            int horaInicial = int.Parse(vet[0]);
            int minutoInicial = int.Parse(vet[1]);
            int segundoInicial = int.Parse(vet[2]);

            Console.Write("Dia ");
            int diaFinal = int.Parse(Console.ReadLine());

            string[] vet1 = Console.ReadLine().Split(" : ");
            int horaFinal = int.Parse(vet1[0]);
            int minutoFinal = int.Parse(vet1[1]);
            int segundoFinal = int.Parse(vet1[2]);

            int segundosInicio = (horaInicial * 60 * 60) + (minutoInicial * 60) + segundoInicial;
            int segundosFinal = (horaFinal * 60 * 60) + (minutoFinal * 60) + segundoFinal;

            int horas, minutos, segundos;

            // dias resolvido nesse if
            if (segundosInicio > segundosFinal)
            {
                int totalDeDias = diaFinal - diaInicio - 1;
                Console.WriteLine(totalDeDias + " dias(s)");

                                
            }
            else
            {
                int totalDeDias = diaFinal - diaInicio;
                Console.WriteLine(totalDeDias + " dias(s)");
                
            }

            //horas resolvidos nesse if 
            if (horaInicial > horaFinal)
            {
                horas = 24 - (horaInicial - horaFinal);
                 
                Console.WriteLine(horas + " hora (s)");
                
                
            }
            else
            {
                horas = (horaFinal - horaInicial);
                Console.WriteLine(horas + " hora (s)");

            }

            //minutos resolvidos nesse if
            if (minutoInicial > minutoFinal)
            {
                minutos = 60 - (minutoInicial - minutoFinal);
                Console.WriteLine(minutos + " minuto (s)");
            }
            else
            {
                minutos = (minutoFinal - minutoInicial);
                Console.WriteLine(minutos + " minuto (s)");
            }

            //segundos resolvido nesse if
            if (segundoInicial > segundoFinal)
            {
                segundos = 60 - (segundoInicial - segundoFinal);
                Console.WriteLine(segundos + " segundo (s)");
            }
            else
            {
                segundos = (segundoFinal - segundoInicial);
                Console.WriteLine(segundos + " segundo (s)");
            }
           
           
        }
    }
}
