using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rigidBody;
    float horizontalInput;
    public float movementSpeed = 200;
    public float sideSpeed = 1;
    public float maxSpeed = 10;


    // Start is called before the first frame update
    void Start()
    {   
        //Grabas the rigidbody component on the object attached to this script
        rigidBody = GetComponent<Rigidbody>();

    }

    // Fixed update is used for physics related stuff
    void FixedUpdate()
    {
        //Call the function that moves player on input
        applyForceOnInput();

        //Forces the ball to move forward by default
        rigidBody.AddForce(0, 0, movementSpeed);
    }

    private void Update()
    {
        // Calls the function that checks direction of input
        checkInput();
        rigidBody.velocity = Vector3.ClampMagnitude(rigidBody.velocity, maxSpeed);
    }

    void checkInput()
    {
        // Checks for any horizontal user input(A, D, left or right keys, etc) and stores it
        horizontalInput = Input.GetAxis("Horizontal");
            
    }

    void applyForceOnInput()
    {
        // Creates a variable for force speed based on the direction of the user input
        float sideForce = horizontalInput * sideSpeed * Time.deltaTime;
        // Apply the force of input to the current gameobject
        rigidBody.AddForce(sideForce, 0, 0, ForceMode.VelocityChange);
    }
}
