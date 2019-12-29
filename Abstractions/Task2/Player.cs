using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Player : IPlayable, IRecodable
    {
        public void Record()
        {
            Console.WriteLine("Идет запись... ");
        }
        public void Play()
        {
            Console.WriteLine("Воспроизведение файла...");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Воспроизведение приостановлено");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Воспроизведение остановлено");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Запись приостановлена");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Запись остановлена");
        }
    }
}
