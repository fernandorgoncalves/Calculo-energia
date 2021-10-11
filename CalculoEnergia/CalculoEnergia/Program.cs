using System;

namespace CalculoEnergia
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Sistema de calculo de Energia***");

            Console.WriteLine("Digite da leitura anterior\n");
            string numAnte = Console.ReadLine();

            Console.WriteLine("Digite da leitura atual");
            string numAtual = Console.ReadLine();

            double QtdEnergia = Double.Parse(numAtual) - Double.Parse(numAnte);


            Console.WriteLine("A leitura atual é: "+ QtdEnergia);

            double consumoEnergia = 0.34893;
            double energiaTe = 0.32643;
            double adicionalBandeira =0.14200;
            double CosipSp=9.66;
            double pisPasep =0.57;
            double cofins = 2.76;
            

            double totalUso = QtdEnergia * consumoEnergia;
            double totalEnergiaTe = QtdEnergia * energiaTe;
            double calcadicionalBan = QtdEnergia * adicionalBandeira;
            //double calcMediaDiaria = QtdEnergia / 30;

            double total = 0;
            if(QtdEnergia < 100)
            {
                Console.WriteLine("USO SIST.DISTR.(TUSD): " + totalUso);
                Console.WriteLine("ENERGIA (TE): " + totalEnergiaTe);
                total = totalUso + totalEnergiaTe+CosipSp+pisPasep+cofins; 
            }else{ 
            Console.WriteLine("USO SIST.DISTR.(TUSD): "+totalUso.ToString("C"));
            Console.WriteLine("ENERGIA (TE): "+totalEnergiaTe.ToString("C"));
            Console.WriteLine("ADIC.BANDEIRA TARIFARIA: " + calcadicionalBan.ToString("C"));
                total = totalUso + totalEnergiaTe + CosipSp+calcadicionalBan+pisPasep+cofins;
            }
            Console.WriteLine("O total de tudo é: "+total.ToString("C"));
            Console.ReadLine();
            
        }
        
    }
}
