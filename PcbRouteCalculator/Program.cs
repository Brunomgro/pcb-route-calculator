using PcbLayoutManager;
using PcbUserInteractor;
using PcbCalculator;
using System;

namespace PcbRouteCalculator
{
    class Program
    {
        static LayoutManager layoutManager = new LayoutManager();
        static UserInteractor userInteractor = new UserInteractor();
        static Calculator pcbCalculator = new Calculator();

        static void Main(string[] args)
        {
            Double current = 0.0;
            Double onca = 0.0;
            Double comprimentoDoCondutor = 0.0;
            Double temperaturaAmbiente = 0.0;
            Double temperaturaDeTrabalho = 0.0;
            Int32 trailOption;


            layoutManager.Start();
            userInteractor.Greet();


            userInteractor.ShowOptions();

            int choosenOption = userInteractor.GetNumberInformation();

            if (choosenOption == 1)
            {
                userInteractor.showMessageToCurrentThroughArea();

                userInteractor.showInlineMessage("corrente: ");
                Double.TryParse(Console.ReadLine(), out current);

                userInteractor.showInlineMessage("\nonça: ");
                Double.TryParse(Console.ReadLine(), out onca);

                userInteractor.showInlineMessage("\ncomprimento do condutor: ");
                Double.TryParse(Console.ReadLine(), out comprimentoDoCondutor);

                userInteractor.showInlineMessage("\ntemperatura ambient: e");
                Double.TryParse(Console.ReadLine(), out temperaturaAmbiente);

                userInteractor.showInlineMessage("\ntemperatura de trabalho: ");
                Double.TryParse(Console.ReadLine(), out temperaturaDeTrabalho);

                userInteractor.showMessage("\ntrilha:");
                userInteractor.showMessage("1 - externa");
                userInteractor.showMessage("2 - interna");
                Int32.TryParse(Console.ReadLine(), out trailOption);

                Double value = pcbCalculator.CorrenteAtravesDaArea(current, onca, trailOption, comprimentoDoCondutor, temperaturaAmbiente, temperaturaDeTrabalho);

                Console.WriteLine(value + " MILS");
            } else
            {
                
            }

            Console.ReadKey();
        }
    }
}
