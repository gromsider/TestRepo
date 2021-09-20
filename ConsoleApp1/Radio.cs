using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Radio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Слушаем радио..." : "Грустно молчим без радио...");
        }
    }
}
