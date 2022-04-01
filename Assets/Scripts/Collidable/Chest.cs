using UnityEngine;

public class Chest : Collectable
{
    public PlayerData data;
    [SerializeField] private int storedPesos = 5;
    public Sprite fullChest;
    public Sprite emptyChest;

    protected override void Start()
    {
        base.Start();
        GetComponent<SpriteRenderer>().sprite = storedPesos > 0 ? fullChest : emptyChest;
    }

    protected override bool OnCollect()
    {
        // Debug.Log("Money " + storedPesos);
        data.money += storedPesos;
        storedPesos = 0;
        GetComponent<SpriteRenderer>().sprite = storedPesos > 0 ? fullChest : emptyChest;
        return true;
    }
}