using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public static Player player;
    private Rigidbody2D body;
    public float speed = 10.0f;
    private void Awake()
    {
        player = this;
    }
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    Vector2 inputDir = new Vector2(0, 0);

    private void FixedUpdate()
    {

        // Handling flipping character during left/right movement
        if (inputDir.x > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (inputDir.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        body.AddForce(inputDir * speed, ForceMode2D.Force);

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        // Using new InputSystem and Rigidbody2D for more interesting/intuitive movement
        inputDir = context.ReadValue<Vector2>();
    }
}