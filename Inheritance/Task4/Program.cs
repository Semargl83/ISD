using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyUser, keyPro = "123", keyExp = "456";
            DocumentWorker worker = new DocumentWorker();
            Console.WriteLine("Введите ключ версии");
            keyUser = Console.ReadLine();
            if (keyUser == keyPro)
            {
                worker = new ProDocumentWorker();
            }
            if (keyUser == keyExp)
            {
                worker = new ExpertDocumentWorker();
            }
            worker.EditDocument();
            worker.SaveDocument();
            Console.ReadKey();
        }
    }
}
