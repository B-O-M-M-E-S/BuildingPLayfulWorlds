using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class damagePlayer : MonoBehaviour
{

    public int playerHealth = 30;
    int damage = 5;
    

    void Start()
    {
        print (playerHealth);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Enemy")
        {
            playerHealth -= damage;
            if (playerHealth <= 0)
            {
                Die();
            }
        }
        if (hit.gameObject.tag == "einde")
        {
            Debug.Log("YO EINDIG");

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
    void OnGUI()
    {
        GUI.color = Color.white;
        GUI.Label(new Rect(20, 20, 400, 20), "Health : " + playerHealth);
    }

    void Die()
    {
        
    
         FindObjectOfType<gameManager>().EndGame();
   
    }
 
    }

