using UnityEngine; //Vector3

namespace ClinicalXR.Reach
{

    public class ReachTrialManager : MonoBehaviour
    {
        // For tracking movement 
        public Transform hand; 
        public Transform workspaceOrigin;

        // Markers/ spheres patient touches 
        public Transform homeMarker; 
        public Transform targetMarker; 
    }
    

} //namespace ClinicalXR.Reach 