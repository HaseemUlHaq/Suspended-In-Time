using UnityEngine;

public class SunLightZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ButterflyMovement butterfly = other.GetComponent<ButterflyMovement>();
        ActivateFire fire = other.GetComponent<ActivateFire>();
        DeerActivation deer = other.GetComponent<DeerActivation>();

        if (butterfly != null)
        {
            butterfly.SetLit(true);
        }
        if (fire != null)
        {
            fire.SetLit(true);
        }
        if (deer != null)
        {
            deer.SetLit(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ButterflyMovement butterfly = other.GetComponent<ButterflyMovement>();
        ActivateFire fire = other.GetComponent<ActivateFire>();
        DeerActivation deer = other.GetComponent<DeerActivation>();

        if (fire != null)
        {
            fire.SetLit(false);
        }
        if (butterfly != null)
        {
            butterfly.SetLit(false);
        }
        if (deer != null)
        {
            deer.SetLit(false);
        }
    }
}