// using UnityEngine;
// using UnityEngine.XR.Interaction.Toolkit;

// public class ButterFlyMovement : MonoBehaviour
// {
//     public Animator animator;
//     private UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable;
//     private bool activated = false;

//     void Awake()
//     {
//         interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
//         interactable.hoverEntered.AddListener(OnHover);
//     }

//     void Start()
//     {
//         if (animator != null)
//             animator.enabled = false; // frozen butterfly
//     }

//     void OnHover(HoverEnterEventArgs args)
//     {
//         if (activated) return;

//         activated = true;

//         if (animator != null)
//             animator.enabled = true; // butterfly comes alive
//     }
// }

using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButterFlyMovement : MonoBehaviour
{
    public Animator animator;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable;
    private bool activated = false;

    void Awake()
    {
        // Get the XR Simple Interactable
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        if (interactable != null)
        {
            interactable.hoverEntered.AddListener(OnHover);
        }

        // Find the Animator if not assigned
        if (animator == null)
        {
            animator = GetComponentInChildren<Animator>();
        }

        // Freeze butterfly at start
        if (animator != null)
        {
            animator.speed = 0f; // freeze animation
        }
    }

    void OnHover(HoverEnterEventArgs args)
    {
        Debug.Log("Hover detected on " + gameObject.name);
        if (activated) return;
        activated = true;

        if (animator != null)
        animator.speed = 1f;
        
        if (activated) return;

        activated = true;

        if (animator != null)
        {
            animator.speed = 1f; // start animation
        }
    }
}