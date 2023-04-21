using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_State.State
{
    internal class CameraCapturingState : CameraState
    {
        public CameraCapturingState(Camera camera) : base(camera)
        {
        }

        public override void Initialize()
        {
            Console.WriteLine("Ошибка: камера уже инициализирована");
        }

        public override void StartCapture()
        {
            Console.WriteLine("Ошибка: захват кадров уже начат");
        }

        public override void PauseCapture()
        {
            Console.WriteLine("Захват кадров приостановлен");
            camera.State = new CameraPausedState(camera);
        }

        public override void StopCapture()
        {
            Console.WriteLine("Захват кадров остановлен");
            camera.State = new CameraReadyState(camera);
        }
    }
}
