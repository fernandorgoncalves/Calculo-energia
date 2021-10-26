using System;

namespace CalculoEnergia
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;

            Console.WriteLine("1-Energia" + "  " + "2-Gás" + "  " + "3-Sair");
            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("***Sistema de calculo de Energia***");

                    Console.WriteLine("Digite da leitura anterior\n");
                    string numAnte = Console.ReadLine();

                    Console.WriteLine("Digite da leitura atual");
                    string numAtual = Console.ReadLine();

                    double QtdEnergia = Double.Parse(numAtual) - Double.Parse(numAnte);


                    Console.WriteLine("A leitura atual é: " + QtdEnergia);

                    double consumoEnergia = 0.34893;
                    double energiaTe = 0.32643;
                    double adicionalBandeira = 0.14200;
                    double CosipSp = 9.66;
                    double pisPasep = 0.57;
                    double cofins = 2.76;


                    double totalUso = QtdEnergia * consumoEnergia;
                    double totalEnergiaTe = QtdEnergia * energiaTe;
                    double calcadicionalBan = QtdEnergia * adicionalBandeira;
                    //double calcMediaDiaria = QtdEnergia / 30;

                    double total = 0;
                    if (QtdEnergia < 100)
                    {
                        Console.WriteLine("USO SIST.DISTR.(TUSD): " + totalUso);
                        Console.WriteLine("ENERGIA (TE): " + totalEnergiaTe);
                        total = totalUso + totalEnergiaTe + CosipSp + pisPasep + cofins;
                    }
                    else
                    {
                        Console.WriteLine("USO SIST.DISTR.(TUSD): " + totalUso.ToString("C"));
                        Console.WriteLine("ENERGIA (TE): " + totalEnergiaTe.ToString("C"));
                        Console.WriteLine("ADIC.BANDEIRA TARIFARIA: " + calcadicionalBan.ToString("C"));
                        total = totalUso + totalEnergiaTe + CosipSp + calcadicionalBan + pisPasep + cofins;
                    }
                    Console.WriteLine("O total de tudo é: " + total.ToString("C"));
                    Console.ReadLine();
                    break;
                case 2:

                    Console.WriteLine("Bem vindo ao sistema de cálculo de gás");

                    double percentual = 18.0 / 100;
                    double resultFaixaP = 1.487404;
                    double resultFaixaS = 6.992124;

                    Console.WriteLine("Digite a numeração anterior");
                    Double numAnt = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite a numeração atual");
                    Double numAtu = Convert.ToDouble(Console.ReadLine());

                    Double result = numAtu - numAnt;

                    Console.WriteLine("O valor Parcial é  " + result);

                    if (result < 1.00)
                    {
                        double calc = result * resultFaixaP + 8.35;

                        Console.WriteLine("Consumo sem icms " + calc);
                        double resultIcms = calc + (percentual * calc);

                        Console.WriteLine("Consumo com icms" + resultIcms);

                    }
                    else if (result >= 1.00 && result <= 2.00)
                    {
                        double calc = result * resultFaixaP;

                        Console.WriteLine("Consumo sem icms " + calc);
                        double resultIcms = calc + (percentual * calc);

                        Console.WriteLine("Consumo com icms" + resultIcms);
                    }
                    break;
                case 3:
                    Console.WriteLine("O sistema será fechado");
                    break;
            }

            Console.ReadKey();

        }

    }
}
