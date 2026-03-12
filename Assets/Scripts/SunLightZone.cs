using UnityEngine;

public class SunLightZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ButterflyMovement butterfly = other.GetComponent<ButterflyMovement>();
        ActivateFire fire = other.GetComponent<ActivateFire>();

        if (butterfly != null)
        {
            butterfly.SetLit(true);
        }

        if (fire != null)
        {
            fire.SetLit(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ButterflyMovement butterfly = other.GetComponent<ButterflyMovement>();
        ActivateFire fire = other.GetComponent<ActivateFire>();
        if (fire != null)
        {
            fire.SetLit(false);
        }
        if (butterfly != null)
        {
            butterfly.SetLit(false);
        }
    }
}