using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    int levelUnlock;
    public Button[] buttons;
    void Start()
    {
        levelUnlock = PlayerPrefs.GetInt("levels", 1);
        for(int i=0; i<buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < levelUnlock; i++)
        {
            buttons[i].interactable = true;
        }
    }
    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
    
}
