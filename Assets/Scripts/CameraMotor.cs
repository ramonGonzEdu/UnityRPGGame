using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;

    public float boundX = 0.15f;
    public float boundY = 0.05f;
    private Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    private void LateUpdate()
    {

        Vector2 cameraSnapInterval = new Vector2((cam.orthographicSize * 2 * cam.aspect) / Screen.width, (cam.orthographicSize * 2) / Screen.height);
        // Vector2 cameraSnapInterval = new Vector2(1 / 16, 1 / 16);

        Vector3 delta = Vector3.zero;

        // Check if Player is within camera bounds and set values in delta.
        float deltaX = lookAt.position.x - transform.position.x;
        if (Mathf.Abs(deltaX) > boundX)
            delta.x = deltaX - boundX * Mathf.Sign(deltaX);
        float deltaY = lookAt.position.y - transform.position.y;
        if (Mathf.Abs(deltaY) > boundY)
            delta.y = deltaY - boundY * Mathf.Sign(deltaY);

        transform.position += new Vector3(delta.x, delta.y, 0);

        // Snap to grid
        transform.position = new Vector3(
            (Mathf.Round(transform.position.x / cameraSnapInterval.x) + 0.01f) * cameraSnapInterval.x,
            (Mathf.Round(transform.position.y / cameraSnapInterval.y) + 0.01f) * cameraSnapInterval.y,
            transform.position.z
        );
    }
}