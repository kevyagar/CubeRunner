using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Rigidbody rb;
    public float boostForce = 10000f;
    public GameObject player;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            rb.constraints = RigidbodyConstraints.None;
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            

        }
        if(collisionInfo.collider.tag == "Boost")
        {
            collisionInfo.collider.isTrigger = true;
            Debug.Log("You hit a speed boost!");
            rb.AddForce(0, 0, boostForce);

        }
        if(collisionInfo.collider.tag == "Coin")
        {
            collisionInfo.collider.isTrigger = true;
            Debug.Log("You got money!");
            player.GetComponent<Currency>().addMoney(1);
        }

    }
}
