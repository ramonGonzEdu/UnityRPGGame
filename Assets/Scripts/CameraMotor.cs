using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;

    public float boundX = 0.15f;
    public float boundY = 0.05f;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        // Check if Player is within camera bounds and set values in delta.
        float deltaX = lookAt.position.x - transform.position.x;
        if (Mathf.Abs(deltaX) > boundX)
            delta.x = deltaX - boundX * Mathf.Sign(deltaX);
        float deltaY = lookAt.position.y - transform.position.y;
        if (Mathf.Abs(deltaY) > boundY)
            delta.y = deltaY - boundY * Mathf.Sign(deltaY);

        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}