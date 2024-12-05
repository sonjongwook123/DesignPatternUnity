using UnityEngine;

namespace Chapter.command
{
    public class TurnLeft : Command
    {
        private BikeController _controller;

        public TurnLeft(BikeController controller)
        {
            _controller = controller;
        }

        public override void Excute()
        {
            _controller.Turn(BikeController.Directon.Left);    
        }
    }
}