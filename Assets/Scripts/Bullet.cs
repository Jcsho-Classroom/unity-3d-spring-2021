using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.forward;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + transform.forward * Time.deltaTime);
    }
}
