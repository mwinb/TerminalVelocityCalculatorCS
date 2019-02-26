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
            Console.Clear();
            while(input != 0)
            {
                DropItem item = new DropItem();
                TerminalVelocity tv = new TerminalVelocity(item.ToHash());
                Console.Write("Terminal Velocity: {0:0.000}\n", tv.calculateTV());
                input = GetMenu();
                Console.Clear();
            }
            
        }
    }
}