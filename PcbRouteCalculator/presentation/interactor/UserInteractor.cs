using System;
using MessagesProvider;
using CurrentInformation;
using AreaInformation;

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
            Console.BackgroundColor = ConsoleColor.Black;

        }

        public void NotYetSuportedAlert()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(messages.notYetSuported);
            Console.BackgroundColor = ConsoleColor.Black;

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

        public AreaInformations getTrailInformation()
        {
            showMessageToCurrentThroughArea();

            AreaInformations currentInformations = new AreaInformations(
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

            showMessage("trilha:");
            showMessage("1 - externa");
            showMessage("2 - interna");
            int.TryParse(Console.ReadLine(), out choosenTrail);
            Console.WriteLine();

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
            showInlineMessage("corrente em Amperes: ");
            double.TryParse(Console.ReadLine(), out current);

            return current;
        }

        double getOncaInfo()
        {
            double onca = 0.0;
            showInlineMessage("espessura do cobre em onças: ");
            double.TryParse(Console.ReadLine(), out onca);

            return onca;
        }

        double getLenghInfo()
        {
            double comprimentoDoCondutor = 0.0;
            showInlineMessage("comprimento do condutor em milimetros: ");
            double.TryParse(Console.ReadLine(), out comprimentoDoCondutor);

            return comprimentoDoCondutor;
        }

        double getTemperatureVariation()
        {
            double temperatureVariation = 0.0;
            showInlineMessage("variação da temperatura em °C: ");
            double.TryParse(Console.ReadLine(), out temperatureVariation);

            return temperatureVariation;
        }

        public void showMessage(String message)
        {
            Console.WriteLine(message);
        }

        public void showInlineMessage(String message)
        {
            Console.Write(message);
        }
        public void showMessageToCurrentThroughArea()
        {
            Console.WriteLine(messages.toCalculateCurrent);
        }

        public AplicationFlow getAplicationFlow()
        {
            int choosenOption = GetNumberInformation();
            Console.WriteLine();
            AplicationFlow flow;

            if (choosenOption == 1)
            {
                flow = AplicationFlow.Current;
            }
            else
            {
                if (choosenOption == 2)
                {
                    flow = AplicationFlow.Area;
                }
                else
                {
                    flow = AplicationFlow.notChosen;
                }
            }

            return flow;
        }
    }

    enum AplicationFlow
    {
        Current,
        Area,
        notChosen
    }
}
