using UnityEngine;


[CreateAssetMenu(fileName = "PS", menuName = "GameData/Sprite", order = 0)]
public class PlayerSprite : ScriptableObject
{
    public PlayerClasses className;
    public Sprite[] playerSprite;
}