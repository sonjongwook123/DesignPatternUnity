using System.Collections.Generic;
using UnityEngine;

namespace Chapter.SpatialPartition
{
    [CreateAssetMenu(fileName ="New Track", menuName ="Track")]
    public class Track : ScriptableObject
    {
        [Tooltip("The expected legnth of segments")]
        public float segmentLength;

        [Tooltip("Add segments in expected loading order")]
        public List<GameObject> segments = new List<GameObject>();
    }
}
