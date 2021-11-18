using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("You have exited");
        Application.Quit();
    }
}
