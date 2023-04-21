using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Camera_State.State;

namespace Camera_State
{
    internal class Camera
    {
        private CameraState state;

        public Camera()
        {
            state = new CameraNotInitializedState(this);
        }

        public CameraState State
        {
            get { return state; }
            set { state = value; }
        }

        public void Initialize()
        {
            state.Initialize();
        }

        public void StartCapture()
        {
            state.StartCapture();
        }

        public void PauseCapture()
        {
            state.PauseCapture();
        }

        public void StopCapture()
        {
            state.StopCapture();
        }
    }
}
