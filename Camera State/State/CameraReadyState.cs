using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_State.State
{
    internal class CameraReadyState : CameraState
    {
        public CameraReadyState(Camera camera) : base(camera)
        {
        }

        public override void Initialize()
        {
            Console.WriteLine("Ошибка: камера уже инициализирована");
        }

        public override void StartCapture()
        {
            Console.WriteLine("Захват кадров начат");
            camera.State = new CameraCapturingState(camera);
        }

        public override void PauseCapture()
        {
            Console.WriteLine("Ошибка: захват кадров еще не начат");
        }

        public override void StopCapture()
        {
            Console.WriteLine("Ошибка: захват кадров еще не начат");
        }
    }
}
