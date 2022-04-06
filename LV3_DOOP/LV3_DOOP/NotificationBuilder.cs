using System;
using System.Collections.Generic;
using System.Text;

namespace LV3_DOOP
{
    class NotificationBuilder : IBuilder
    {
        private String author;
        private String title;
        private String text;
        private DateTime timestamp;
        private Category level;
        private ConsoleColor color;
        public NotificationBuilder()
        {
            author = string.Empty;
            title = string.Empty;
            text = string.Empty;
            timestamp = DateTime.Now;
            level = Category.INFO;
            color = ConsoleColor.White;
        }
        public IBuilder SetAuthor(String author)
        {
            this.author = author;
            return this;
        }
        public IBuilder SetTitle(String title)
        {
            this.title = title;
            return this;
        }
        public IBuilder SetTime(DateTime time)
        {
            timestamp = time;
            return this;
        }
        public IBuilder SetLevel(Category level)
        {
            this.level = level;
            return this;
        }
        public IBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }
        public IBuilder SetText(String text)
        {
            this.text = text;
            return this;
        }
        public ConsoleNotification Build()
        {
            return new ConsoleNotification(this.author, this.title, this.text, this.timestamp, this.level, this.color);
        }
    }
}
