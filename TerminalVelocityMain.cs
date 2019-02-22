using System;
using System.Collections;


namespace TerminalVelocityCalc
{
    class TerminalVelocityMain
    {

        public static void Exit()
        {
            System.Environment.Exit(1);
        }

        public static int  GetMenu()
        {
            MainMenu menu = new MainMenu();
            menu.PrintMenu();
            return menu.GetInput();

        }

        static public void Main(String[] args)
        {
            int input = GetMenu();
            while(input != 0)
            {
                DropItem item = new DropItem();
                TerminalVelocity tv = new TerminalVelocity(item.ToDictionary());
                Console.WriteLine(tv.calculateTV());
                input = GetMenu();
            }
            
        }
    }
}