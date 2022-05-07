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

        static void Main()
        {
            layoutManager.Start();
            userInteractor.Greet();
            userInteractor.ShowOptions();

            if (getAplicationFlow() == AplicationFlow.Current)
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
