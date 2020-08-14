using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Helpers
{
    public static class Helpers
    {
        public static void CenterText(string text)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
        }
    }
}
