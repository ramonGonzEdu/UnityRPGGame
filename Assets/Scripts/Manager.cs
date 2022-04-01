using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum PlayerClasses
{
    Citizen,
    BodyBuilder,
    Dwarf,
    Wizard,
    ToolMaker,
    Pirate,
    Swordsman,

}

public class Manager : MonoBehaviour
{
    public static Manager manager;

    public PlayerSprite[] classSprite;
    PlayerSprite sprites;
    Player player;
    public PlayerData data;

    bool triedLoad = false;



    void Awake()
    {
        manager = this;
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += SaveState;
        SceneManager.sceneLoaded += LoadState;
    }
    void Start()
    {
        player = Player.player;
    }

    void SaveState(Scene s, LoadSceneMode mode)
    {
        if (!triedLoad) return;
        string dataJSON = JsonUtility.ToJson(data);
        Debug.Log(dataJSON);
        PlayerPrefs.SetString("PlayerData", dataJSON);
    }
    void LoadState(Scene s, LoadSceneMode mode)
    {
        triedLoad = true;
        if (!PlayerPrefs.HasKey("PlayerData")) return;

        string dat = PlayerPrefs.GetString("PlayerData");
        JsonUtility.FromJsonOverwrite(dat, data);
    }
}
