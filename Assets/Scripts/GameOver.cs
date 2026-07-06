using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>Game-over screen buttons. Names are wired via Unity's Inspector OnClick() UI events — do not rename.</summary>
public class GameOver : MonoBehaviour
{
    public void ShowMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
