using System;

namespace LV3_DOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dataset originalData = new Dataset("data.txt");
            Console.WriteLine(originalData.ToString());
            Dataset dataClone = (Dataset)originalData.Clone();
            originalData.ClearData();
            Console.WriteLine(dataClone);
            
            double[][] matrix = MatrixGenerator
                                           .GetInstance()
                                           .GenerateMatrix(5,3);
            foreach(double[] row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
            FileLogger.GetInstance().Log("ovo je poruka");
            */
            NotificationManager manager = new NotificationManager();
            NotificationBuilder builder = new NotificationBuilder();
            ConsoleNotification plainNotification = builder
                                                        .SetAuthor("ja")
                                                        .SetColor(ConsoleColor.Green)
                                                        .SetTitle("poruka")
                                                        .SetText("ovo je sadrzaj poruke, lp")
                                                        .Build();
            manager.Display(plainNotification);
            Director director = new Director(builder);
            ConsoleNotification infoNotification = director.CreateInfoNotification("Autor");
            manager.Display(infoNotification);
            ConsoleNotification alertNotification = director.CreateAlertNotification("Autor alerta");
            manager.Display(alertNotification);
            ConsoleNotification errorNotification = director.CreateErrorNotification("Autor errora");
            manager.Display(errorNotification);
        }
    }
}
