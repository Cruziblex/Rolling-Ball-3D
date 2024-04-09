using Unity.VisualScripting;
using UnityEngine;

public class PlayerColliderScript : MonoBehaviour
{
    private PlayerMovement PlayerMovement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            PlayerMovement = gameObject.GetComponent<PlayerMovement>();
            PlayerMovement.enabled = false;
        }
    }
}
