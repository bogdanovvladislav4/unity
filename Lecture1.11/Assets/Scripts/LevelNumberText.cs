
using UnityEngine;
using UnityEngine.UI;

public class LevelNumberText : MonoBehaviour
{
    public Text text;
    public Game game;

    private void Start()
    {
        text.text = "Level " + (game.LevelIndex + 1).ToString();
    }
}
