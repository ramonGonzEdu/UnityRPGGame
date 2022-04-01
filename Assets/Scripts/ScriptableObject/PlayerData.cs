using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "GameData/PlayerData", order = 0)]
public class PlayerData : ScriptableObject
{
    [SerializeField] public PlayerClasses pClass;
    [SerializeField] public Weapon currentWeapon;
    [SerializeField] public int money = 0;
    [SerializeField] public int xp = 0;
}