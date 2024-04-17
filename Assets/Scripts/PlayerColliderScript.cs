using Unity.VisualScripting;
using UnityEngine;

public class PlayerColliderScript : MonoBehaviour
{
    private void Start()
    {
        PlayerMovement = gameObject.GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        float xPosition = gameObject.transform.position.x;
        if (xPosition <= -10.5 || xPosition >= 10.5)
        {
            PlayerMovement.enabled = false;
        }
    }
    private PlayerMovement PlayerMovement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            PlayerMovement.enabled = false;
        }
    }

}
