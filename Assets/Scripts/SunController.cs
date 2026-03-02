using UnityEngine;
using UnityEngine.InputSystem;

public class SunController : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float rotationSpeed = 50f;
    public float verticalClampMin = -20f;
    public float verticalClampMax = 80f;

    private float currentXRotation;

    void Start()
    {
        currentXRotation = transform.eulerAngles.x;
    }

    void Update()
    {
        // Read right joystick input
        Vector2 input = UnityEngine.XR.InputDevices
            .GetDeviceAtXRNode(UnityEngine.XR.XRNode.RightHand)
            .TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxis, out Vector2 axis)
            ? axis
            : Vector2.zero;

        float horizontal = input.x;
        float vertical = input.y;

        // Horizontal rotation (Y axis)
        transform.Rotate(Vector3.up, horizontal * rotationSpeed * Time.deltaTime, Space.World);

        // Vertical rotation (X axis with clamp)
        currentXRotation -= vertical * rotationSpeed * Time.deltaTime;
        currentXRotation = Mathf.Clamp(currentXRotation, verticalClampMin, verticalClampMax);

        Vector3 angles = transform.eulerAngles;
        angles.x = currentXRotation;
        transform.eulerAngles = angles;
    }
}