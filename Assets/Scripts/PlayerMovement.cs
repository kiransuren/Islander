using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public Transform camera;
    public Transform player;
    public float forwardSpeed;
    public float strafeSpeed;
    private bool isOnGround = false;
    void Start()
    {
        //player.transform.position = new Vector3(0, 5, 0);

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //player.forward = camera.forward;

      if (Input.GetKey("w")){
            forwardMovement(forwardSpeed);
      }

      if ((Input.GetKey("w")) && Input.GetKey("left shift"))
        {
            forwardMovement(forwardSpeed * 2f);
        }

      if (Input.GetKey("s")){
            forwardMovement(-forwardSpeed);
        }

      if ((Input.GetKey("s")) && Input.GetKey("left shift"))
        {
            forwardMovement(-forwardSpeed * 2f);
        }

      if (Input.GetKey("a")){
            strafeMovement(-strafeSpeed);//Negative
      }

      if(Input.GetKey("d")){
            strafeMovement(strafeSpeed);
        }


      if (Input.GetKey("space"))
      {
            if (isOnGround)
            {
                rb.AddForce(0, 300, 0);
                isOnGround = false;
            }
      }

    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.collider.tag == "ground")
        {
            isOnGround = true;
        }
    }



    private void forwardMovement(float speed)
    {
        rb.velocity = new Vector3(camera.transform.forward.x * speed, rb.velocity.y, camera.transform.forward.z * speed);
    }

    private void strafeMovement(float speed)
    {
        rb.velocity = new Vector3(camera.transform.right.x * speed, rb.velocity.y, camera.transform.right.z * speed);
    }

}
