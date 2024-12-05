using UnityEngine;

namespace Chapter.command
{
    public class TurnRight : Command
    {
        private BikeController _controller;
        
        public TurnRight(BikeController controller)
        {
            _controller = controller;
        }

        public override void Excute()
        {
            _controller.Turn(BikeController.Directon.Right);
        }
    }
}
