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
            double current = 0.0;
            double onca = 0.0;
            double comprimentoDoCondutor = 0.0;
            double temperatureVariation;
            int trailOption;


            layoutManager.Start();
            userInteractor.Greet();


            userInteractor.ShowOptions();

            int choosenOption = userInteractor.GetNumberInformation();

            if (choosenOption == 1)
            {
                double value = pcbCalculator.currentThroughTrail(userInteractor.getCurrentInformation());

                Console.WriteLine(value + " MILS");
            } else
            {
                
            }

            Console.ReadKey();
        }
    }
}
