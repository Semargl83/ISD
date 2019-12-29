using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Record();
            Thread.Sleep(3500);
            ((IRecodable)player).Pause();
            Thread.Sleep(1200);
            ((IRecodable)player).Stop();
            player.Play();
            Thread.Sleep(3500);            
            ((IPlayable)player).Pause();
            Thread.Sleep(1200);
            ((IPlayable)player).Stop();
            Console.ReadKey();
        }
    }
}
