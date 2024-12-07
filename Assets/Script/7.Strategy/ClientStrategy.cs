using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Strategy
{
    public class ClientStrategy : MonoBehaviour
    {
        private GameObject _drone;

        private List<IManeuverBehavior> _components = new List<IManeuverBehavior>();
        
        private void SpawnDrone()
        {
            _drone = GameObject.CreatePrimitive(PrimitiveType.Cube);

            _drone.AddComponent<Drone>();
            
            _drone.transform.position = Random.insideUnitSphere * 10;
            
            ApplyRandomStrategies();
        }
        
        private void ApplyRandomStrategies()
        {
            _components.Add(_drone.AddComponent<WeavingManeuver>());
            _components.Add(_drone.AddComponent<BoppingManeuver>());
            _components.Add(_drone.AddComponent<FallbackManeuver>());

            int index = Random.Range(0,_components.Count);

            _drone.GetComponent<Drone>().ApplyStrategy(_components[index]);
        }
        
        void OnGUI()
        {
            if(GUILayout.Button("Spawn Drone"))
            {
                SpawnDrone();
            }
        }
    }
}