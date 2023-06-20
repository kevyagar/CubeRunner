using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public TrailRenderer tail;
    public float forwardForce = 100f;
    public float sidewaysForce = 150f;
    public float jumpForce = .00001f;
    public bool showTail = false;
    public Material[] face;
    Renderer faceRend;
    int x;
    bool grounded;
    // Start is called before the first frame update
    void Start()
    {  
        grounded = true;
        x = 0;
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        faceRend = GetComponent<Renderer>();
        faceRend.enabled = true;
        faceRend.sharedMaterial = face[x];

        if (showTail == false)
        {
            tail.enabled = false;
        }

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            x = 2;
            showTail = false;
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            x = 1;
            showTail = false;
        }
        
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 10);
            showTail = true;
            x = 0;
            tail.enabled = true;
        }
        if (Input.GetKey("space") && grounded == true)
        {
            rb.AddForce(0, jumpForce, forwardForce * Time.deltaTime);
            grounded = false;
            showTail = false;
            
        }
        if (rb.velocity.y == 0)
        {
            grounded = true;
        }
        if (rb.position.y < -10f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
   
    


    

