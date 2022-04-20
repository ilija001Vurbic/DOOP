using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dataset dataset = new Dataset("test.txt");
            //Analyzer3rdParty analyzer = new Analyzer3rdParty();
            //Adapter adapter = new Adapter(analyzer);
            //double[] columnAverages = adapter.CalculateAveragePerColumn(dataset);
            //Console.WriteLine(string.Join(" ",columnAverages));
            //double[] rowAverages = adapter.CalculateAveragePerRow(dataset);
            //Console.WriteLine(string.Join(" ",rowAverages));
            //RentingConsolePrinter printer = new RentingConsolePrinter();

            //List<IRentable> rentables = new List<IRentable>();
            //List<IRentable> flashSale = new List<IRentable>();
            //rentables.Add(new Book("1984"));
            //rentables.Add(new Video("Terminator"));
            //rentables.Add(new HotItem(new Book("Animal Farm")));
            //rentables.Add(new HotItem(new Video("Titanic")));
            //printer.DisplayItems(rentables);
            //printer.PrintTotalPrice(rentables);

            //foreach(IRentable rentable in rentables)
            //{
            //    flashSale.Add(new DiscountedItem(rentable,50));
            //}
            //printer.DisplayItems(flashSale);
            //printer.PrintTotalPrice(flashSale);

            //string password = "Abc123";
            //string email = "bla@ferit.hr";
            //PasswordValidator passwordValidator = new PasswordValidator(5);
            //EmailValidator emailValidator = new EmailValidator();
            //Console.WriteLine(passwordValidator.IsValidPassword(password));
            //Console.WriteLine(emailValidator.IsValidAddress(email));

            RegistrationValidator registrationValidator = new RegistrationValidator();
            UserEntry entry;
            do
            {
                entry = UserEntry.ReadUserFromConsole();

            } while (!registrationValidator.IsUserEntryValid(entry));
            Console.WriteLine("All clear");
            Console.ReadLine();
        }

    }
}
