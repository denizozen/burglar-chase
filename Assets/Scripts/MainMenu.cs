using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>Main menu screen buttons. Names are wired via Unity's Inspector OnClick() UI events — do not rename.</summary>
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
