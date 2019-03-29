using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayTex : MonoBehaviour
{
    public string text;
    public bool display = false;

  
    void OnGUI()
    {
      if(display == true)
        {
            
            GUI.Box(new Rect(0, 50, Screen.width, Screen.height - 50), text);
            Destroy(gameObject, 10);
        }
    }
}
