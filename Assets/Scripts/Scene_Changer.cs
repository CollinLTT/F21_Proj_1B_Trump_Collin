using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_Changer : MonoBehaviour
{
    public Button playButton;

    void Start()
    {
        PlayButton_Interact();
    }

    public void Roll_Character_Scene()
    {
        SceneManager.LoadScene("Scene_Roll_Character");
    }

 public void Main_Menu_Scene()
    {
        SceneManager.LoadScene("Scene_Main_Menu");
    }

 public void Play_Game_Scene()
    {
        SceneManager.LoadScene("Scene_Play_Game");
    }

 public void Settings_Scene()
    {
        SceneManager.LoadScene("Scene_Settings");
    }

 public void About_Scene()
    {
        SceneManager.LoadScene("Scene_About");
    }

 public void PlayButton_Interact()
    {
        if (Singleton.instance.charGenerated == true && playButton.interactable == false)
        {
            playButton.interactable = true;
        }

    }
}
