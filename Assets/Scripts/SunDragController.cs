using UnityEngine;
using UnityEngine.InputSystem;


public class SunDragController : MonoBehaviour
{
    public Transform directionalLight;   // Assign your Sun light
    public InputActionProperty triggerAction;
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor rayInteractor;

    private bool isDragging = false;

    void Update()
    {
        float triggerValue = triggerAction.action.ReadValue<float>();

        if (triggerValue > 0.5f)
        {
            if (!isDragging)
            {
                TryStartDragging();
            }

            if (isDragging)
            {
                MoveSun();
            }
        }
        else
        {
            isDragging = false;
        }
    }

    void TryStartDragging()
    {
        if (rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit))
        {
            if (hit.transform == transform)
            {
                isDragging = true;
            }
        }
    }

    void MoveSun()
    {
        Ray ray = rayInteractor.transform.GetComponent<Camera>().ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2));
        
        // Instead of screen ray, we use controller forward direction
        Vector3 direction = rayInteractor.transform.forward;
        Vector3 newPosition = rayInteractor.transform.position + direction * 10f;

        transform.position = newPosition;

        if (directionalLight != null)
        {
            directionalLight.rotation = Quaternion.LookRotation(-direction);
        }
    }
}