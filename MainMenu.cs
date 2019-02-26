using System;


namespace TerminalVelocityCalc
{
    public class MainMenu
    {
        private String welcome;
        private String calculate;
        private String exit;
        public MainMenu()
        {
            welcome = "Welcome to Terminal Velocity Calculator";
            calculate = "Press 1 to calculate new terminal velocity";
            exit = "Press enter to exit";
        }

        public void PrintMenu()
        {
            Console.Write("{0:s}\n{1:s}\n{2:s}\n", welcome, calculate, exit);

        }

        public int GetInput()
        {
            String userInput;
            Console.Write("Input:");
            userInput = Console.ReadLine();
            if (userInput != "1")
            {
                return 0;
            }

            return 1;

        }
    }
}
