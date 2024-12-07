using Chapter.command;
using UnityEngine;

public class SegmentMarker : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<BikeController>())
        {
            Destroy(transform.parent.gameObject);
        }
    }
}