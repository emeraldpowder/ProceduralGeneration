using UnityEngine;

public class PlayerTopDown : MonoBehaviour
{
    private Rigidbody componentRigidbody;
    
    public int TurnSpeed = 2;

    private void Start()
    {
        componentRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            componentRigidbody.AddForce(Vector3.forward* TurnSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            componentRigidbody.AddForce(Vector3.back * TurnSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            componentRigidbody.AddForce(Vector3.left * TurnSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            componentRigidbody.AddForce(Vector3.right * TurnSpeed);
        }
    }
}
