using UnityEngine;
using UnityEngine.UI;
public class PlatformsDestroyedCounter : MonoBehaviour
{
    public Game game;
    public Text text;
    public Player player;

    private void Update()
    {
        if(player.CurrentPlatform == null)
            text.text = "Score " + player._platformDestroyedCounter.ToString();
    }
}
