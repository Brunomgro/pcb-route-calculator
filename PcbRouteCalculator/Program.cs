using PcbLayoutManager;
using PcbUserInteractor;
using PcbCalculator;
using System;

namespace PcbRouteCalculator
{
    class Program
    {
        static LayoutManager layoutManager = new();
        static UserInteractor userInteractor = new();
        static Calculator pcbCalculator = new();

        static void Main()
        {
            layoutManager.Start();
            userInteractor.Greet();
            userInteractor.ShowOptions();

            bool shouldComeSelectAgain = true;
            AplicationFlow flow = AplicationFlow.Current;

            while (shouldComeSelectAgain)
            {
                flow = userInteractor.getAplicationFlow();

                if (flow is AplicationFlow.notChosen)
                {
                    userInteractor.WrongInformationAlert();
                    shouldComeSelectAgain = true;
                } else
                {
                    shouldComeSelectAgain = false;
                }
            }

            if (flow == AplicationFlow.Current)
            {
                double value = pcbCalculator.areaThroughCurrent(userInteractor.getCurrentInformation());
                Console.WriteLine(value + " MILS ou " + value*0.0254 + " milímetros");
            } else
            {
                userInteractor.NotYetSuportedAlert();
            }

            Console.ReadKey();
        }
    }

}
