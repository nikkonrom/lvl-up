using System;

namespace Classes
{
    class Title
    {
        string content;

        public string Content
        {
            private get 
            {
                if (content != null)
                    return content;
                else
                    return "Заголовок отсутствует.";
            }
            set 
            {
                content = value; 
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
