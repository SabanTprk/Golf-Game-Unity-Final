using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void GoToGameScene()
    {
        // 'Game' isimli sahneye ge�i� yap
        SceneManager.LoadScene("LevelOne");
    }
    
    public void GoToGameSettings()
    {
        // 'Game' isimli sahneye ge�i� yap
        SceneManager.LoadScene("Settings");
    }

    public void GoToGameLevelPanel()
    {
        // 'Game' isimli sahneye ge�i� yap
        SceneManager.LoadScene("Level");
    }
    public void GoToGameLevelOne()
    {
        // 'Game' isimli sahneye ge�i� yap
        SceneManager.LoadScene("LevelOne");
    }

    public void GoToGameLevelTwo()
    {
        // 'Game' isimli sahneye ge�i� yap
        SceneManager.LoadScene("LevelTwo");
    }

    public void GoToGameLevelThree()
    {
        // 'Game' isimli sahneye ge�i� yap
        SceneManager.LoadScene("LevelThree");
    }

    public void GoToGameHome()
    {
        SceneManager.LoadScene("Start");
    }
    
    public void GoToGameControls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void ExitGame()
    {
        // Oyunu kapat
        Application.Quit();
    }
}
