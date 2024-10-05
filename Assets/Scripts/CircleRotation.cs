using UnityEngine;

public class CircleRotation : MonoBehaviour
{
    public float rotationSpeed = 100f;
    private float direction = 1f;

    void Update()
    {
        RotateCircle();

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            ToggleRotationDirection();
        }
    }

    void RotateCircle()
    {
        // Rotate around the z-axis
        transform.Rotate(0, 0, direction * rotationSpeed * Time.deltaTime);
    }

    void ToggleRotationDirection()
    {
        direction *= -1;
    }
}
