using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable))]
public class ButterflyXRGlow : MonoBehaviour
{
    [Header("Glow Settings")]
    public Renderer butterflyRenderer;
    public Color glowColor = Color.orange;
    public float pulseSpeed = 2f;
    public float pulseIntensity = 2f;

    private Material butterflyMat;
    private bool isInteracted = false;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable;

    void Awake()
    {
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();

        // Subscribe to the modern event
        interactable.selectEntered.AddListener(OnSelected);
    }

    void Start()
    {
        // Make a unique instance of the material
        butterflyMat = butterflyRenderer.material;
        butterflyMat.EnableKeyword("_EMISSION");
    }

    void Update()
    {
        if (!isInteracted)
        {
            float intensity = 1f + Mathf.Sin(Time.time * pulseSpeed) * pulseIntensity;
            butterflyMat.SetColor("_EmissionColor", glowColor * intensity);
        }
    }

    // Called automatically when XR controller selects the butterfly
    private void OnSelected(SelectEnterEventArgs args)
    {
        isInteracted = true;
        butterflyMat.SetColor("_EmissionColor", Color.black);
    }

    private void OnDestroy()
    {
        // Unsubscribe to avoid memory leaks
        interactable.selectEntered.RemoveListener(OnSelected);
    }
}