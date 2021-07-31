using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool TwoPGame;
    void Start()
    {
        Time.timeScale = 0;
    }
    public void Play(bool TwoPlayers)
    {
        if (TwoPlayers)
            TwoPGame = true;
        else
            TwoPGame = false;
        Time.timeScale = 1;
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
