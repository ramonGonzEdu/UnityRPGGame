using UnityEngine;
using DaMastaCoda.Tags;

public class Portal : Collidable
{
    public string[] sceneOptions;

    protected override void OnCollide(Collider2D hit)
    {
        if (hit.GetTags().HasTagAncestry("entities.player"))
        {
            // Teleport player to target
            var sceneName = sceneOptions[Random.Range(0, sceneOptions.Length)];
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}