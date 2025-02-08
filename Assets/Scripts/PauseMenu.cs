using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Button pause;
    public Button resume;
    public Button loadMenu;
    public Button quit;
    public GameObject pauseMenu;

    void Start () {
        Button btn = pause.GetComponent<Button>();
        Button btn2 = resume.GetComponent<Button>();
        Button btn3 = loadMenu.GetComponent<Button>();
        Button btn4 = quit.GetComponent<Button>(); 
        btn.onClick.AddListener(TaskOnClick);
        btn2.onClick.AddListener(Resume);
        btn4.onClick.AddListener(Die);
    }

    void TaskOnClick(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    
    void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    
    void Die()
    {
        Application.Quit();
    }
}
