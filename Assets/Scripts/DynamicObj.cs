using UnityEngine;

public class DynamicObj : MonoBehaviour
{
    private void Update()
    {
        GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(transform.position.y * 100f) * -1 + Mathf.RoundToInt(transform.position.z * 100f) * -1;
    }
}