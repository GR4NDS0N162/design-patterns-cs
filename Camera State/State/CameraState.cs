using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_State.State
{
    internal abstract class CameraState
    {
        protected Camera camera;

        public CameraState(Camera camera)
        {
            this.camera = camera;
        }

        public abstract void Initialize();
        public abstract void StartCapture();
        public abstract void PauseCapture();
        public abstract void StopCapture();
    }
}
