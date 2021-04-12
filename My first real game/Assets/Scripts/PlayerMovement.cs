using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    //place to add variables
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
          //Only excuted if condition is PlayerMovement
          rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( Input.GetKey("a") )
        {
          //Only excuted if condition is PlayerMovement
          rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if (rb.position.y < -1f) {

          FindObjectOfType<GameManager>().EndGame();

        }
        if ( Input.GetKey("space") ) {
          rb.AddForce(0, 5f, 0);

        }
    }


}
