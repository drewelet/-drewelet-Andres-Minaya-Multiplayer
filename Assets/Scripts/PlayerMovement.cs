using UnityEngine;
using Mirror;

public class PlayerMovement : NetworkBehaviour
{
    public float playerSpeed = 1.0f;

    void Update()
    {
        if (isLocalPlayer)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * playerSpeed, 0, Input.GetAxis("Vertical") * playerSpeed);
            transform.position = transform.position + movement;
        }
    }
}
