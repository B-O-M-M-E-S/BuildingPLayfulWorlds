using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class QuitGame : MonoBehaviour
{
    public void quit()
    {
        Application.Quit();
        Debug.Log("YOU KILLED HIM!");
    }
}
