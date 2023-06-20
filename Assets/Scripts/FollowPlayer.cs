
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Rigidbody rb;
    public TrailRenderer tail;



    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 2, -5);
       
    }
}
