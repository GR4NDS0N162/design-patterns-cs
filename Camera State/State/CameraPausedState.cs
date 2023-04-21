using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_State.State
{
    internal class CameraPausedState : CameraState
    {
        public CameraPausedState(Camera camera) : base(camera)
        {
        }

        public override void Initialize()
        {
            Console.WriteLine("Ошибка: камера уже инициализирована");
        }

        public override void StartCapture()
        {
            Console.WriteLine("Захват кадров продолжен");
            camera.State = new CameraCapturingState(camera);
        }

        public override void PauseCapture()
        {
            Console.WriteLine("Ошибка: захват кадров уже приостановлен");
        }

        public override void StopCapture()
        {
            Console.WriteLine("Захват кадров остановлен");
            camera.State = new CameraReadyState(camera);
        }
    }
}
