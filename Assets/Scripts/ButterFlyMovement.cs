using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButterflyMovement : MonoBehaviour
{
    public Animator animator;

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    private bool isLit = false;
    private bool activated = false;

    void Awake()
    {
        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

        grabInteractable.selectEntered.AddListener(OnGrab);

        if (animator == null)
            animator = GetComponentInChildren<Animator>();

        if (animator != null)
            animator.speed = 0f;

        // Disable grabbing initially
        grabInteractable.enabled = false;
    }

    public void SetLit(bool value)
    {
        isLit = value;

        // Enable grabbing only when in sunlight
        grabInteractable.enabled = value;
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        if (!isLit || activated) return;

        activated = true;

        if (animator != null)
            animator.speed = 1f;
    }
}