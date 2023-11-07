using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public class KeyReader : AbstractStringSubject
    {
        public void ReadKeys()
        {
            bool loop = true;
            ConsoleKey key;
            while(loop)
            {
                key= Console.ReadKey(true).Key;

                if (key != ConsoleKey.Escape)
                {
                    Item = key.ToString();
                }

                else
                    loop = false;
            }
        }
    }
}