using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(25f, 70f, 15f);

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, Space.World);
    }
}
