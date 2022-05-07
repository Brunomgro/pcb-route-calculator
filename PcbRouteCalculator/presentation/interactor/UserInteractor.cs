using System;
using MessagesProvider;

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

        public int GetNumberInformation()
        {
            int value = 0;

            Int32.TryParse(Console.ReadLine(), out value);

            return value;
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
    }
}
