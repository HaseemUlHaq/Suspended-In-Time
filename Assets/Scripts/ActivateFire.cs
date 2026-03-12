using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateFire : MonoBehaviour
{
    public ParticleSystem fire;

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    private bool isLit = false;
    private bool activated = false;

    void Awake()
    {
        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

        grabInteractable.selectEntered.AddListener(OnGrab);

        if (fire == null)
            fire = GetComponentInChildren<ParticleSystem>();

        // Stop particles initially
        if (fire != null)
            fire.Pause();

        // Disable grabbing initially
        grabInteractable.enabled = false;
    }

    public void SetLit(bool value)
    {
        isLit = value;

        // Enable grabbing only in sunlight
        grabInteractable.enabled = value;
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        if (!isLit || activated) return;

        activated = true;

        if (fire != null)
            fire.Play();
    }
}