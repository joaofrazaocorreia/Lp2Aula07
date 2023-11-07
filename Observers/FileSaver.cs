using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {
        private string fileName;

        public FileSaver(string name)
        {
            fileName = name;
        }


        public void Update(AbstractStringSubject sub)
        {
            File.AppendAllText(fileName,sub.Item);
        }
    }
}