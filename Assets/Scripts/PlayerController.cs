using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject shooter;
    public ObjectPool bulletPool;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    // convert to public values
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = MovementLogic.Move(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")), playerSpeed);
        controller.Move(move * Time.deltaTime);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        playerVelocity.y += MovementLogic.Jump(Input.GetButtonDown("Jump") && groundedPlayer, jumpHeight, gravityValue);
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = bulletPool.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = shooter.transform.position;
                bullet.transform.rotation = shooter.transform.rotation;
                bullet.SetActive(true);
            }
        }
    }
}
