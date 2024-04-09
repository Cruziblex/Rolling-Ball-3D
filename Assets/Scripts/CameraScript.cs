using UnityEngine;

public class CameraScript : MonoBehaviour
{
    GameObject player;
    public Vector3 offset;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
