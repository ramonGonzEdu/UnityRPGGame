using UnityEngine;
using DaMastaCoda.Tags;

public class Collectable : Collidable
{
    protected bool isCollected = false;
    protected override void OnCollide(Collider2D hit)
    {
        if (hit.GetTags().HasTagAncestry("entities.player") && !isCollected)
            isCollected = OnCollect();

    }
    protected virtual bool OnCollect()
    {
        return true;
    }


}