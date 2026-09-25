using UnityEngine;

public class SpinObjectOnMarker : MonoBehaviour
{
    public float rotationSpeed = 40f;

    void Update()
    {
        transform.Rotate(
            Vector3.up,
            rotationSpeed * Time.deltaTime,
            Space.World
        );
    }
}