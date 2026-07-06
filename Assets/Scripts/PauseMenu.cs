using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>Wires up the in-game pause menu: pause/resume, returning to the main menu, and quitting.</summary>
public class PauseMenu : MonoBehaviour
{
    public Button pause;
    public Button resume;
    public Button loadMenu;
    public Button quit;
    public GameObject pauseMenu;

    void Start()
    {
        pause.onClick.AddListener(OpenPauseMenu);
        resume.onClick.AddListener(ResumeGame);
        loadMenu.onClick.AddListener(LoadMainMenu);
        quit.onClick.AddListener(QuitApplication);
    }

    void OpenPauseMenu()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    void QuitApplication()
    {
        Application.Quit();
    }
}
