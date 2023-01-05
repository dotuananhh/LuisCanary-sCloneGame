using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UIManager : MonoBehaviour
{
    public GameObject optionsPanel;
    public AudioSource clip;    //âm thanh

    public void OptionsPanel()
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }
    public void Return()
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }

    public void AnotherOptions()
    {
        //Sound
        //Graphics
    }
    public void GoMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))   //Khi người chơi ấn nút esc thì sẽ tạm dừng trò chơi
        {
            Time.timeScale = 0;
            optionsPanel.SetActive(true);
        }
    }

    public void PlaySoundButton()
    {
        clip.Play();
    }
}
