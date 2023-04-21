using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camera camera = new Camera();

            camera.Initialize(); // Инициализация камеры

            camera.StartCapture(); // Захват кадров начат
            camera.PauseCapture(); // Захват кадров приостановлен
            camera.StartCapture(); // Захват кадров продолжен
            camera.StopCapture(); // Захват кадров остановлен

            // Ждем подтверждения от пользователя
            Console.ReadLine();
        }
    }
}
