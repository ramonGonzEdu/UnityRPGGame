using UnityEngine;


[CreateAssetMenu(fileName = "Sword", menuName = "GameData/Weapon", order = 0)]
public class Weapon : ScriptableObject
{
    [SerializeField] public Sprite sprite;
    [SerializeField] public int price;
}