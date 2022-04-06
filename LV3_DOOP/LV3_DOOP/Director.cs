using System;
using System.Collections.Generic;
using System.Text;

namespace LV3_DOOP
{
    class Director
    {
        private IBuilder builder;
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public ConsoleNotification CreateInfoNotification(string author)
        {
            return builder
                .SetLevel(Category.INFO)
                .SetAuthor(author)
                .SetTitle("Information")
                .SetText("ovo je informacija")
                .SetColor(ConsoleColor.Yellow)
                .SetTime(DateTime.Now)
                .Build();
        }
        public ConsoleNotification CreateAlertNotification(string author)
        {
            return builder
                .SetLevel(Category.ALERT)
                .SetAuthor(author)
                .SetTitle("Alert")
                .SetText("ovo je alert")
                .SetColor(ConsoleColor.Cyan)
                .SetTime(DateTime.Now)
                .Build();
        }
        public ConsoleNotification CreateErrorNotification(string author)
        {
            return builder
                .SetLevel(Category.ERROR)
                .SetAuthor(author)
                .SetTitle("Error")
                .SetText("ovo je error")
                .SetColor(ConsoleColor.Red)
                .SetTime(DateTime.Now)
                .Build();
        }
    }
}
