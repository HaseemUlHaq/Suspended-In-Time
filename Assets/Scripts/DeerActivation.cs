using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using ithappy.Animals_FREE;

public class DeerActivation : MonoBehaviour
{
    public Animator animator;
    public CreatureMover mover;

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    private bool isLit = false;
    private bool activated = false;

    void Awake()
    {
        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

        grabInteractable.selectEntered.AddListener(OnGrab);

        if (animator == null)
            animator = GetComponentInChildren<Animator>();

        if (mover == null)
            mover = GetComponent<CreatureMover>();

        // Freeze animation
        if (animator != null)
            animator.speed = 0f;

        // Disable movement initially
        if (mover != null)
            mover.enabled = false;

        // Disable grabbing initially
        grabInteractable.enabled = false;
    }

    public void SetLit(bool value)
    {
        isLit = value;

        grabInteractable.enabled = value;
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        if (!isLit || activated) return;

        activated = true;

        // Start animation
        if (animator != null)
            animator.speed = 1f;

        // Enable movement
        if (mover != null)
            mover.enabled = true;
    }
}