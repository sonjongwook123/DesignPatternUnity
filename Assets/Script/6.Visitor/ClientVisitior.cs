using UnityEngine;

namespace Pattern.Visitor
{
    public class ClientVisitior : MonoBehaviour
    {
        public PowerUp enginePowerUp;
        public PowerUp shiledPowerUp;
        public PowerUp weaponPowerUp;
        
        private BikeController _bikeController;

        void Start()
        {
            _bikeController = gameObject.AddComponent<BikeController>();
        }

        void OnGUI()
        {
            if(GUILayout.Button("Power Up Shield"))
            {
                _bikeController.Accept(shiledPowerUp);
            }

            if(GUILayout.Button("Power Up Engine"))
            {
                _bikeController.Accept(enginePowerUp);
            }

            if(GUILayout.Button("Power Up Weapon"))
            {
                _bikeController.Accept(weaponPowerUp);
            }
        }
    }
}