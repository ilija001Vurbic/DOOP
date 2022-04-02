using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2_DOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller roller = new DiceRoller();
            for (int i = 0; i < 20; i++)
            {
                roller.InsertDie(new Die(6));
            }
            //PrintRollingResults(roller.GetRollingResults());
            FileLogger fileLogger = new FileLogger("data.txt");
            fileLogger.Log(roller);
            ConsoleLogger consoleLogger = new ConsoleLogger();
            consoleLogger.Log(roller);
            FlexibleDiceRoller flexibleDiceRoller = new FlexibleDiceRoller();
            consoleLogger.Log(flexibleDiceRoller);
            Console.ReadKey();
        }
        /*static void PrintRollingResults(IList<int> rollingResults)
        {
            Console.WriteLine(string.Join("\n", rollingResults));
        }*/
    }
}
