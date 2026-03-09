using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BeeMovement : MonoBehaviour
{
    public ParticleSystem beeParticles;

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    private bool isLit = false;
    private bool activated = false;

    void Awake()
    {
        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

        grabInteractable.selectEntered.AddListener(OnGrab);

        if (beeParticles == null)
            beeParticles = GetComponentInChildren<ParticleSystem>();

        // Stop particles initially
        if (beeParticles != null)
            beeParticles.Pause();

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

        if (beeParticles != null)
            beeParticles.Play();
    }
}