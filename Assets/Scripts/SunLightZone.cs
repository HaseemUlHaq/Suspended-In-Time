using UnityEngine;

public class SunLightZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ButterflyMovement butterfly = other.GetComponent<ButterflyMovement>();

        if (butterfly != null)
        {
            butterfly.SetLit(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ButterflyMovement butterfly = other.GetComponent<ButterflyMovement>();

        if (butterfly != null)
        {
            butterfly.SetLit(false);
        }
    }
}