using UnityEngine;

namespace Chapter.command
{
    public class BikeController : MonoBehaviour
    {
        public enum Directon
        {
            Left = -1,
            Right = 1
        }

        private bool _isTurboOn;
        private float _distance = 1.0f;

        public void ToggleTurbo()
        {
            _isTurboOn = !_isTurboOn;
            Debug.Log("Turbo Active: " + _isTurboOn.ToString());
        }

        public void Turn(Directon directon)
        {
            if(directon == Directon.Left)
            {
                transform.Translate(Vector3.left * _distance);
            }
            if(directon == Directon.Right)
            {
                transform.Translate(Vector3.right * _distance);
            }
        }

        public void ResetPosition()
        {
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
}
