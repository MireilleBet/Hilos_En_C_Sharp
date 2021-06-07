using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HilosEnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SumarThread sumarThread = new SumarThread();

            Thread hilo1 = new Thread(new ParameterizedThreadStart(sumarThread.sumar));
            Thread hilo2 = new Thread(new ParameterizedThreadStart(sumarThread.sumar));
            Thread hilo3 = new Thread(new ParameterizedThreadStart(sumarThread.sumar));
            hilo1.Name = "Hilo 1";
            hilo2.Name = "Hilo 2";
            hilo3.Name = "Hilo 3";


            Int32[] parametro1 = { 2, 1 };
            Int32[] parametro2 = { 2, 1 };
            Int32[] parametro3 = { 2, 1 };

            Console.WriteLine("Preparando los hilos");
            hilo1.Start(parametro1);
            hilo2.Start(parametro2);
            hilo3.Start(parametro3);
            Console.WriteLine("Procesando hilos...");
            Console.ReadLine();
        }
    }
}
