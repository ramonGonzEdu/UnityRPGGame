using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Collidable : UnityEngine.MonoBehaviour
{
    public ContactFilter2D filter;
    private Collider2D colliderComponent;
    private List<Collider2D> hits = new List<Collider2D>();

    protected virtual void Start()
    {
        colliderComponent = GetComponent<Collider2D>();
    }

    protected virtual void Update()
    {
        int hitCount = colliderComponent.OverlapCollider(filter, hits);
        for (int i = 0; i < hitCount; i++)
        {
            if (hits[i] == null) continue;

            OnCollide(hits[i]);

        }
    }

    protected virtual void OnCollide(Collider2D hit) { }
}