using Chapter.SpatialPartition;
using UnityEngine;

public class Segment : MonoBehaviour
{
    public TrackController trackController;
    
    private void OnDestroy()
    {
        if(trackController)
        {
            trackController.LoadNextSegment();
        }
    }
}  