using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_State.State
{
    internal class CameraNotInitializedState : CameraState
    {
        public CameraNotInitializedState(Camera camera) : base(camera)
        {
        }

        public override void Initialize()
        {
            Console.WriteLine("Инициализация камеры...");
            camera.State = new CameraReadyState(camera);
            Console.WriteLine("Камера проинициализированна");
        }

        public override void StartCapture()
        {
            Console.WriteLine("Ошибка: камера не инициализирована");
        }

        public override void PauseCapture()
        {
            Console.WriteLine("Ошибка: камера не инициализирована");
        }

        public override void StopCapture()
        {
            Console.WriteLine("Ошибка: камера не инициализирована");
        }
    }
}
