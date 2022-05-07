using System;
using MessagesProvider;
using CurrentInformation;

namespace PcbUserInteractor
{

    class UserInteractor
    {
        static Messages messages = new Messages();
        public void Greet()
        {
            Console.WriteLine(messages.greetingMessage);
            Console.ReadKey();
        }

        public void ShowOptions()
        {
            Console.WriteLine(messages.currentOption);
            Console.WriteLine(messages.areaOption);

            Console.WriteLine(messages.selectTheOption);
        }

        public void WrongInformationAlert()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(messages.genericError);

            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }

        static public int GetNumberInformation()
        {
            int value = 0;

            Int32.TryParse(Console.ReadLine(), out value);

            return value;
        }

        public CurrentInformations getCurrentInformation() {
            showMessageToCurrentThroughArea();

            CurrentInformations currentInformations = new CurrentInformations(
                getLenghInfo(),
                getCurrentInfo(),
                getOncaInfo(),
                getTemperatureVariation(),
                getTrailInfo()
            );

            return currentInformations;
        }

        TrailType getTrailInfo()
        {
            int choosenTrail;
            TrailType trailType;

            showMessage("\ntrilha:");
            showMessage("1 - externa");
            showMessage("2 - interna");
            int.TryParse(Console.ReadLine(), out choosenTrail);

            if (choosenTrail == 1)
            {
                trailType = TrailType.External;
            }
            else
            {
                trailType = TrailType.Internal;
            }

            return trailType;
        }

        double getCurrentInfo()
        {
            double current = 0.0;
            showInlineMessage("corrente: ");
            double.TryParse(Console.ReadLine(), out current);

            return current;
        }

        double getOncaInfo()
        {
            double onca = 0.0;
            showInlineMessage("\nonça: ");
            double.TryParse(Console.ReadLine(), out onca);

            return onca;
        }

        double getLenghInfo()
        {
            double comprimentoDoCondutor = 0.0;
            showInlineMessage("\ncomprimento do condutor: ");
            double.TryParse(Console.ReadLine(), out comprimentoDoCondutor);

            return comprimentoDoCondutor;
        }

        double getTemperatureVariation()
        {
            double temperatureVariation = 0.0;
            showInlineMessage("\nvariação da temperatura: ");
            double.TryParse(Console.ReadLine(), out temperatureVariation);

            return temperatureVariation;
        }

        public void showMessage(String message)
        {
            Console.WriteLine(message+"\n");
        }

        public void showInlineMessage(String message)
        {
            Console.Write(message);
        }
        public void showMessageToCurrentThroughArea()
        {
            Console.WriteLine(messages.toCalculateCurrent);
        }

        static public AplicationFlow getAplicationFlow()
        {
            int choosenOption = GetNumberInformation();
            AplicationFlow flow;

            if (choosenOption == 1)
            {
                flow = AplicationFlow.Current;
            }
            else
            {
                flow = AplicationFlow.Area;
            }

            return flow;
        }
    }

    enum AplicationFlow
    {
        Current,
        Area
    }
}
