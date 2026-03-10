using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class SunOrbitController : MonoBehaviour
{
    public Transform pivot;        // Center of world / player
    public float radius = 6f;      // Distance from pivot
    public float height = 3f;      // Sun height
    public float minAngle = 10f;   // Minimum angle along arc
    public float maxAngle = 170f;  // Maximum angle along arc

    private XRGrabInteractable grabInteractable;
    private bool isGrabbed = false;

    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    void Update()
    {
        if (!isGrabbed) return;

        // Direction from pivot to controller
        Transform interactor = grabInteractable.interactorsSelecting[0].transform;
        Vector3 dir = interactor.position - pivot.position;

        // Project direction onto horizontal XZ plane
        Vector3 flatDir = new Vector3(dir.x, 0, dir.z).normalized;

        // Calculate angle on horizontal plane
        float angle = Mathf.Atan2(flatDir.z, flatDir.x) * Mathf.Rad2Deg;
        angle = Mathf.Clamp(angle, minAngle, maxAngle);

        float rad = angle * Mathf.Deg2Rad;

        // Set new position along circular orbit
        Vector3 newPos = new Vector3(Mathf.Cos(rad), 0, Mathf.Sin(rad)) * radius;
        newPos.y = height;

        transform.position = pivot.position + newPos;

        // Make sun look at pivot (so spotlight points correctly)
        transform.LookAt(pivot);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        isGrabbed = true;
    }

    void OnRelease(SelectExitEventArgs args)
    {
        isGrabbed = false;
    }
}