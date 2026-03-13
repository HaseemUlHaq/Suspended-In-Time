using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerHead;
    public Vector3 offset = new Vector3(0.4f, 0.2f, 1.2f);

    void LateUpdate()
    {
        // Move with the player
        transform.position = playerHead.position + playerHead.TransformDirection(offset);

        // Keep the original rotation (do not rotate with head)
        transform.rotation = Quaternion.identity;
    }
}