using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform Target;
    
    private void Update()
    {
        transform.position = Target.position;
    }
}
