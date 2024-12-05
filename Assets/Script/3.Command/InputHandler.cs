using UnityEngine;

namespace Chapter.command
{
    public class InputHandler : MonoBehaviour
    {
        private Invoker _invoker;
        private bool _isReplaying;
        private bool _isRecording;
        private BikeController _bikeController;
        private Command _buttonA, _buttonD, _buttonW;

        void Start()
        {
            _invoker = gameObject.AddComponent<Invoker>();
            _bikeController = FindAnyObjectByType<BikeController>();

            _buttonA = new TurnLeft(_bikeController);
            _buttonD = new TurnRight(_bikeController);
            _buttonW = new ToggleTurbo(_bikeController);
        }

        void Update()
        {
            if(!_isReplaying && _isRecording)
            {
                if(Input.GetKeyUp(KeyCode.A))
                {
                    _invoker.ExcuteCommand(_buttonA);
                }
                if(Input.GetKeyUp(KeyCode.D))
                {
                    _invoker.ExcuteCommand(_buttonD);
                }
                if(Input.GetKeyUp(KeyCode.W))
                {
                    _invoker.ExcuteCommand(_buttonW);
                }
            }
        }

        void OnGUI()
        {
            if(GUILayout.Button("Start Recording"))
            {
                _bikeController.ResetPosition();
                _isReplaying = false;
                _isRecording = true;
                _invoker.Record();
            }

            if(GUILayout.Button("Stop Recording"))
            {
                _bikeController.ResetPosition();
                _isRecording = false;
            }

            if(GUILayout.Button("Start Replay"))
            {
                _bikeController.ResetPosition();
                _isRecording = false;
                _isReplaying = true;
                _invoker.Replay();
            }
        }
    }
}
